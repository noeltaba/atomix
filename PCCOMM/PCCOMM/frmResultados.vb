Public Class frmResultados

    Dim conexionbd As New conexionBD
    Dim obtenerDatos As DataSet
  
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim folio As Integer = Convert.ToInt32(txtFolio.Text)
        Dim sqlConsulta = "SELECT FKStatus,FechaCreacion,Apellidos,Nombre,Correo FROM AR_Ordenes,CT_Pacientes AS Orden" +
                          "WHERE PKOrden = " & folio & " AND PKPaciente = (SELECT FKPaciente FROM AR_Ordenes WHERE PKOrden = " & folio & ") "

        obtenerDatos = New DataSet
        obtenerDatos.Reset()

        conexionbd.adaptador = conexionbd.consultaAdaptador(sqlConsulta)
        conexionbd.adaptador.Fill(obtenerDatos, "Orden")


    End Sub

  
End Class