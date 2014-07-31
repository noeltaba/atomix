Imports System.Data
Imports System.Data.SqlClient

Public Class frmAltaOrdenLaboratorio

    Dim obtenerDato As DataSet
    Dim conexionbd As New conexionBD
    Public entra As Integer = 0
    Dim entreUnavez As Integer = 0

    Private Sub frmAltaOrdenLaboratorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conexionbd.llenarComboBox(cbEstudio, "Analisis", "CT_Analisis", "Analisis")

    End Sub

    Private Sub txtIdPaciente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdPaciente.KeyPress

        If e.KeyChar.Equals(Convert.ToChar(Keys.Enter)) Then

            txtIdPaciente.Text = "llenar datos"

        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Dim buscarPaciente As New frmBuscarPaciente()

        buscarPaciente.Show()

    End Sub

    Private Sub cbEstudio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEstudio.SelectedIndexChanged

        obtenerDato = New DataSet
        obtenerDato.Reset()

        conexionbd.adaptador = conexionbd.consultaAdaptador("SELECT Precio FROM CT_Analisis WHERE Analisis = '" + cbEstudio.Text + "'")
        conexionbd.adaptador.Fill(obtenerDato, "CT_Analisis")

        If entra <> 0 Then

            Dim recibeDato As Integer = Convert.ToInt32(obtenerDato.Tables(0).Rows(0)(0))

            txtPrecio.Text = Convert.ToString(recibeDato)

        End If
    End Sub

    Private Sub btnAgregarEstudio_Click(sender As Object, e As EventArgs) Handles btnAgregarEstudio.Click

        If vacio() = Not True Then

            dgvEstudios.Rows.Insert(0, txtFolio.Text, cbEstudio.Text, txtPrecio.Text)
            sumarDataGridView()
            sumarSaldo()

        End If

    End Sub

    Private Function vacio()

        If txtApellido.Text = "" Or cbEstudio.Text = "" Then

            Return True

        Else
            Return False

        End If

    End Function

    Private Sub btnEliminarEstudio_Click(sender As Object, e As EventArgs) Handles btnEliminarEstudio.Click

        If dgvEstudios.Rows.Count <> 1 Then

            dgvEstudios.Rows.RemoveAt(dgvEstudios.CurrentRow.Index)
            sumarDataGridView()
            sumarSaldo()

        End If
    End Sub

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

End Class