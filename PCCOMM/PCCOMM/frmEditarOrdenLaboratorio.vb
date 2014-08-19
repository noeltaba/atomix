Imports System.Data
Imports System.Data.SqlClient

Public Class frmEditarOrdenLaboratorio

    Dim conexionbd As New conexionBD
    Dim obtenerDatos As DataSet
    Public entra As Integer = 0

    Private Sub frmEditarOrdenLaboratorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionbd.llenarComboBox(cbEstudio, "Analisis", "CT_Analisis", "mostrar = 1", "Analisis", True)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        llenarDatosPaciente()
        llenarDataGridViewOrdenes()
    End Sub

    Private Sub llenarDatosPaciente()

        Dim folio As String = txtFolio.Text
        Dim sqlConsulta = "SELECT FKStatus,FechaCreacion,FKPaciente,Apellidos,Nombre,Correo FROM AR_Ordenes,CT_Pacientes AS Orden WHERE PKOrden = '" & folio & "' AND PKPaciente = (SELECT FKPaciente FROM AR_Ordenes WHERE PKOrden = '" & folio & "')"

        obtenerDatos = New DataSet
        obtenerDatos.Reset()

        conexionBD.adaptador = conexionBD.consultaAdaptador(sqlConsulta)
        conexionBD.adaptador.Fill(obtenerDatos, "Orden")

        If obtenerDatos.Tables.Count <> 0 Then

            Dim status As String = obtenerDatos.Tables("Orden").Rows(0)("FKStatus").ToString()
            Dim nombre As String = obtenerDatos.Tables("Orden").Rows(0)("Apellidos").ToString() + " " +
                                   obtenerDatos.Tables("Orden").Rows(0)("Nombre").ToString()
            Dim fechaOrden As String = obtenerDatos.Tables("Orden").Rows(0)("FechaCreacion")
            Dim id As String = obtenerDatos.Tables("Orden").Rows(0)("FKPaciente").ToString()
            Dim correo As String = obtenerDatos.Tables("Orden").Rows(0)("Correo").ToString()

            txtNombres.Text = obtenerDatos.Tables("Orden").Rows(0)("Nombre").ToString()
            txtApellidos.Text = obtenerDatos.Tables("Orden").Rows(0)("Apellidos").ToString()
            dtpFecha.Value = Convert.ToDateTime(fechaOrden).ToString()
            txtIdPaciente.Text = id
            txtEmailEnvio.Text = correo
        Else
            MsgBox("El dato ingresado no se encuentra el la base de datos")

        End If
    End Sub

    Private Sub llenarDataGridViewOrdenes()

        Dim pkAnalisis As Integer = 0
        Dim sqlDetalleOrden As String = "SELECT FKAnalisis FROM AR_OrdenDetalles WHERE FKOrden = '" & txtFolio.Text & "'"
        Dim sqlResultados As String = ""
        Dim analisis As String = ""
        Dim precio As String = ""
        dgvOrdenes.Rows.Clear()
        obtenerDatos = New DataSet

        conexionbd.consultaReader(sqlDetalleOrden)

        If conexionbd.reader.HasRows Then
            Do While conexionbd.reader.Read()

                pkAnalisis = conexionbd.reader.GetInt32(0)
                sqlResultados = "SELECT Analisis,Precio FROM CT_Analisis WHERE PKAnalisis = (" & pkAnalisis & ") ORDER BY Analisis ASC"
                obtenerDatos.Reset()
                conexionbd.adaptador = conexionbd.consultaAdaptador(sqlResultados)
                conexionbd.adaptador.Fill(obtenerDatos, "CT_Analisis")

                analisis = obtenerDatos.Tables("CT_Analisis").Rows(0)("Analisis").ToString()
                precio = obtenerDatos.Tables("CT_Analisis").Rows(0)("Precio").ToString()

                dgvOrdenes.Rows.Add(txtFolio.Text, analisis, precio)
            Loop
        Else
            MsgBox("Resultado no encontrado")
        End If

        conexionbd.reader.Close()
        conexionbd.cerrarConexion()

    End Sub

    Private Sub cbEstudio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEstudio.SelectedIndexChanged
        obtenerDatos = New DataSet
        obtenerDatos.Reset()

        conexionbd.adaptador = conexionbd.consultaAdaptador("SELECT Precio FROM CT_Analisis WHERE Analisis = '" + cbEstudio.Text + "'")
        conexionbd.adaptador.Fill(obtenerDatos, "CT_Analisis")

        If entra <> 0 And cbEstudio.SelectedIndex <> -1 Then

            Dim recibeDato As Integer = Convert.ToInt32(obtenerDatos.Tables(0).Rows(0)(0))

            txtPrecio.Text = Convert.ToString(recibeDato)

        End If
    End Sub
End Class
