Imports System.Data
Imports System.Data.SqlClient

Public Class frmAltaOrdenLaboratorio

    Dim obtenerDato As DataSet
    Dim conexionbd As New conexionBD
    Public entra As Integer = 0

    ''EVENTO CARGA FORMULARIO
    Private Sub frmAltaOrdenLaboratorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conexionbd.llenarComboBox(cbEstudio, "Analisis", "CT_Analisis", "Analisis")
        conexionbd.llenarComboBox(cbRecibi, "Sucursal", "CT_Sucursales", "PKSucursal")
        txtSubTotal.Text = String.Format("{0:N2}", 0)
        txtAnticipo.Text = String.Format("{0:N2}", 0)
        txtDescuento.Text = String.Format("{0:N2}", 0)
        txtSaldo.Text = String.Format("{0:N2}", 0)

    End Sub

    ''EVENTOS CON TEXTBOX
    Private Sub txtIdPaciente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdPaciente.KeyPress

        If e.KeyChar.Equals(Convert.ToChar(Keys.Enter)) Then

            txtIdPaciente.Text = "llenar datos"

        End If
    End Sub

    Private Sub txtAnticipo_TextChanged(sender As Object, e As EventArgs) Handles txtAnticipo.TextChanged

        If txtSubTotal.Text <> "" Then

            sumarSaldo()

        End If
    End Sub

    Private Sub txtDescuento_TextChanged(sender As Object, e As EventArgs) Handles txtDescuento.TextChanged
        If txtSubTotal.Text <> "" Then
            sumarSaldo()
        End If
    End Sub
    ''FIN EVENTOS TEXTBOX

    ''EVENTOS CON BOTONES
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Dim buscarPaciente As New frmBuscarPaciente()

        buscarPaciente.Show()

    End Sub

    Private Sub btnAgregarEstudio_Click(sender As Object, e As EventArgs) Handles btnAgregarEstudio.Click

        If Not vacio() Then

            dgvEstudios.Rows.Insert(0, txtFolio.Text, cbEstudio.Text, txtPrecio.Text)
            sumarDataGridView()
            sumarSaldo()

        End If

    End Sub

    Private Sub btnEliminarEstudio_Click(sender As Object, e As EventArgs) Handles btnEliminarEstudio.Click

        If dgvEstudios.Rows.Count <> 1 Then

            dgvEstudios.Rows.RemoveAt(dgvEstudios.CurrentRow.Index)
            sumarDataGridView()
            sumarSaldo()

            If txtSubTotal.Text = "0.00" Then

                txtAnticipo.Text = "0.00"
                txtDescuento.Text = "0.00"
                sumarSaldo()

            End If
        End If
    End Sub

    Private Sub btnNuevaOrden_Click(sender As Object, e As EventArgs) Handles btnNuevaOrden.Click
        limpiar()
    End Sub

    Private Sub btnAbonar_Click(sender As Object, e As EventArgs) Handles btnAbonar.Click
        If Not vacio() Then
            'variables orden 
            Dim fkOrden As Integer = obtenerFolio()
            Dim fkSucursal As String = "SELECT PKSucursal FROM CT_Sucursales WHERE Sucursal = '" + cbRecibi.Text + "'"
            Dim fkPaciente As Integer = Convert.ToInt32(txtIdPaciente.Text)
            Dim fkUsuario As Integer = 1
            Dim fkStatus As Integer = 1
            Dim esRadiologia As Integer = 0
            'fin variables orden
            'variables pago
            Dim descuento As Double = Convert.ToDouble(txtDescuento.Text)
            Dim pago As Double = Convert.ToDouble(txtSaldo.Text)
            Dim subTotal As Double = Convert.ToDouble(txtSaldo.Text)
            Dim abono As Double = Convert.ToDouble(txtAnticipo.Text)
            'fin variables pago
            Dim sqlOrden As String = "INSERT INTO AR_Ordenes (FKSucursal, FKPaciente, FKUsuario,FKStatus,fechamodificacion,EsRadiologia)" +
                                     "VALUES ((" + fkSucursal + ")," & fkPaciente & "," & fkUsuario & "," & fkStatus & ", GETDATE(), 0)"
            Dim sqlPago As String = "INSERT INTO AR_Pagos (FKOrden,Descuento,Pago,Fecha,subtotal,abono,total)" +
                                    "VALUES (" & fkOrden & "," & descuento & "," & pago & ",GETDATE()," & subTotal & "," & abono & "," & pago & ")"

            If conexionbd.insertar(sqlOrden) Then 'se inserta el registro de la orden 

                llenarDetalleOrden(fkOrden, pago) 'se inserta el registro detalle orden

                If conexionbd.insertar(sqlPago) Then 'se inserta el registro de pago
                    txtFolio.Text = (obtenerFolio() - 1)
                    MsgBox("Registro de datos exitoso")
                Else
                    MsgBox("No se realizo el pago")
                End If
            Else
                MsgBox("Error al insertar orden de pago")
            End If
        End If

    End Sub
    ''FIN EVENTOS BOTONES

    ''EVENTOS COMBOBOX
    Private Sub cbEstudio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEstudio.SelectedIndexChanged

        obtenerDato = New DataSet
        obtenerDato.Reset()

        conexionbd.adaptador = conexionbd.consultaAdaptador("SELECT Precio FROM CT_Analisis WHERE Analisis = '" + cbEstudio.Text + "'")
        conexionbd.adaptador.Fill(obtenerDato, "CT_Analisis")

        If entra <> 0 And cbEstudio.SelectedIndex <> -1 Then

            Dim recibeDato As Integer = Convert.ToInt32(obtenerDato.Tables(0).Rows(0)(0))

            txtPrecio.Text = Convert.ToString(recibeDato)

        End If
    End Sub
    ''FIN EVENTO COMBOBOX

    ''FUNCIONES APLICACION
    '**suma los datos en la columna precio y obtine el subtotal
    Public Sub sumarDataGridView()

        Dim resultado As Decimal = 0D

        For Each row As DataGridViewRow In dgvEstudios.Rows

            ' Obtenemos el valor de la celda.
            Dim valorCelda As Object = row.Cells("Column3").Value

            Dim precio As Decimal

            Dim esDecimal As Boolean = Decimal.TryParse(Convert.ToString(valorCelda), precio)

            ' Si el valor alfanumérico no se puede convertir a número,
            ' continuamos el bucle.
            If (Not esDecimal) Then Continue For

            ' Sumamos el valor.
            resultado += Convert.ToDecimal(valorCelda)
        Next
        txtSubTotal.Text = String.Format("{0:N2}", resultado)
    End Sub
    '**suma el saldo final restando el descuento y anticipo del subtotal
    Public Sub sumarSaldo()

        Dim subTotal As Double = Convert.ToDouble(txtSubTotal.Text)
        Dim anticipo As Double = 0D
        Dim descuento As Double = 0D

        If txtAnticipo.Text <> "" Then
            anticipo = Convert.ToDouble(txtAnticipo.Text)
        End If
        If txtDescuento.Text <> "" Then
            descuento = Convert.ToDouble(txtDescuento.Text)
        End If

        txtSaldo.Text = String.Format("{0:N2}", Convert.ToDecimal((subTotal - descuento) - anticipo))

    End Sub
    'limpia todo los campo para realizar una nueva orden
    Private Sub limpiar()

        txtFolio.Text = ""
        txtIdPaciente.Text = ""
        txtApellido.Text = ""
        txtNombre.Text = ""
        txtEmailEnvio.Text = ""
        txtPrecio.Text = ""
        txtSubTotal.Text = String.Format("{0:N2}", 0)
        txtAnticipo.Text = String.Format("{0:N2}", 0)
        txtDescuento.Text = String.Format("{0:N2}", 0)
        txtSaldo.Text = String.Format("{0:N2}", 0)
        cbFormaDeEntrega.SelectedIndex = -1
        cbEstudio.SelectedIndex = -1
        cbRecibi.SelectedIndex = -1
        dgvEstudios.Rows.Clear()

    End Sub
    'sirve para verificar que los campos tengan datos antes de cargar un estudio o intentar eliminarlo
    Private Function vacio()

        If txtApellido.Text = "" Or cbEstudio.Text = "" Or cbRecibi.Text = "" Then

            Return True

        Else
            Return False

        End If

    End Function
    '**obtengo folio actual de la orden
    Private Function obtenerFolio()

        Dim folio As Integer = 0
        'Dim idOrden As Integer = 0

        obtenerDato = New DataSet
        obtenerDato.Reset()

        conexionbd.adaptador = conexionbd.consultaAdaptador("SELECT TOP 1 * FROM AR_Ordenes ORDER BY PKOrden DESC")
        conexionbd.adaptador.Fill(obtenerDato, "AR_Ordenes")

        folio = obtenerDato.Tables(0).Rows(0)(0)
        folio = folio + 1

        Return folio
    End Function
    'llenar detalle orden
    Private Sub llenarDetalleOrden(fkOrden As String, total As Double)

        For Each row As DataGridViewRow In dgvEstudios.Rows

            Dim analisis As String = row.Cells("rowEstudio").Value

            Dim queryInsertarDetalleOrden = "INSERT INTO AR_OrdenDetalles (FKOrden,FKAnalisis,Total,IVA) VALUES (" & fkOrden & ",(SELECT PKAnalisis FROM CT_Analisis WHERE Analisis = '" & analisis & "')," & total & ",16)"

            If analisis = "" Then Exit For

            If Not conexionbd.insertar(queryInsertarDetalleOrden) Then
                MsgBox("Error al intentar insertar detalle de orden")
            End If
        Next

    End Sub
    ''FIN FUNCIONES APLICACION

End Class