Public Class frmResultados

    Dim conexionbd As New conexionBD
    Dim obtenerDatos As DataSet
  
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        llenarDatosPaciente()
        llenarDataGridViewResultados()
    End Sub

    Private Sub llenarDatosPaciente()

        Dim folio As String = txtFolio.Text
        Dim sqlConsulta = "SELECT FKStatus,FechaCreacion,FKPaciente,Apellidos,Nombre,Correo FROM AR_Ordenes,CT_Pacientes AS Orden WHERE PKOrden = '" & folio & "' AND PKPaciente = (SELECT FKPaciente FROM AR_Ordenes WHERE PKOrden = '" & folio & "')"

        obtenerDatos = New DataSet
        obtenerDatos.Reset()

        conexionbd.adaptador = conexionbd.consultaAdaptador(sqlConsulta)
        conexionbd.adaptador.Fill(obtenerDatos, "Orden")

        If obtenerDatos.Tables.Count <> 0 Then

            Dim status As String = obtenerDatos.Tables("Orden").Rows(0)("FKStatus").ToString()
            Dim nombre As String = obtenerDatos.Tables("Orden").Rows(0)("Apellidos").ToString() + " " +
                                   obtenerDatos.Tables("Orden").Rows(0)("Nombre").ToString()
            Dim fechaOrden As String = obtenerDatos.Tables("Orden").Rows(0)("FechaCreacion")
            Dim id As String = obtenerDatos.Tables("Orden").Rows(0)("FKPaciente").ToString()
            Dim correo As String = obtenerDatos.Tables("Orden").Rows(0)("Correo").ToString()

            If status = 1 Then
                lStatus.Visible = True
                lStatus.Text = "ACTIVO"
            Else
                lStatus.Visible = True
                lStatus.Text = "INACTIVO"
            End If

            txtNombrePaciente.Text = obtenerDatos.Tables("Orden").Rows(0)("Apellidos").ToString() + obtenerDatos.Tables("Orden").Rows(0)("Nombre").ToString()
            txtFechaOrden.Text = Convert.ToDateTime(fechaOrden).ToString("dd-MMMM-yyyy")
            txtIdPaciente.Text = id
            txtEmail.Text = correo
        Else
            MsgBox("El dato ingresado no se encuentra el la base de datos")

        End If
    End Sub

    Private Sub llenarDataGridViewResultados()

        Dim pkAnalisis As Integer = 0
        Dim sqlDetalleOrden As String = "SELECT FKAnalisis FROM AR_OrdenDetalles WHERE FKOrden = '" & txtFolio.Text & "'"
        Dim sqlResultados As String = ""
        Dim analisis As String = ""
        Dim unidades As String = ""
        Dim valorReferencias As String = ""
        dgvResultados.Rows.Clear()
        obtenerDatos = New DataSet

        conexionbd.consultaReader(sqlDetalleOrden)

        If conexionbd.reader.HasRows Then
            Do While conexionbd.reader.Read()

                pkAnalisis = conexionbd.reader.GetInt32(0)
                sqlResultados = "SELECT Analisis,unidades,valorreferencia FROM CT_Analisis WHERE PKAnalisis = (" & pkAnalisis & ") ORDER BY Analisis ASC"
                obtenerDatos.Reset()
                conexionbd.adaptador = conexionbd.consultaAdaptador(sqlResultados)
                conexionbd.adaptador.Fill(obtenerDatos, "CT_Analisis")

                analisis = obtenerDatos.Tables("CT_Analisis").Rows(0)("Analisis").ToString()
                unidades = obtenerDatos.Tables("CT_Analisis").Rows(0)("unidades").ToString()
                valorReferencias = obtenerDatos.Tables("CT_Analisis").Rows(0)("valorreferencia").ToString()

                dgvResultados.Rows.Add(analisis, "", unidades, valorReferencias)
            Loop
        Else
            MsgBox("Resultado no encontrado")
        End If

        conexionbd.reader.Close()
        conexionbd.cerrarConexion()

    End Sub

End Class