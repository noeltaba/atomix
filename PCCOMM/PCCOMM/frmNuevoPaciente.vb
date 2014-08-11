Public Class frmNuevoPaciente

    Public conexionbd As New conexionBD

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim nombre As String = txtNombres.Text
        Dim apellido As String = txtApellidos.Text
        Dim domicilio As String = txtDomicilio.Text
        Dim ciudad As String = txtCiudadEstado.Text
        Dim sexo As String = cbSexo.Text
        Dim FechaNacimiento As String = dtpFecha.Value.ToString("yyyy-MM-dd hh:mm:ss.fff")
        Dim telefono As String = txtTelefono.Text
        Dim correo As String = txtCorreo.Text

        Dim sqlNuevoPaciente As String = "INSERT INTO CT_Pacientes (Nombre, Apellidos, Domicilio, Ciudad, Sexo, FechaNacimiento, Telefono, Correo, FechaCreacionCliente)" +
                                         "VALUES ('" & nombre & "','" & apellido & "','" & domicilio & "','" & ciudad & "','" & sexo & "',CONVERT(datetime,'" & FechaNacimiento & "'),'" & telefono & "','" & correo & "',GETDATE())"
        If Not vacio() Then

            If conexionbd.insertar(sqlNuevoPaciente) Then
                MsgBox("Paciente registrado")
            Else
                MsgBox("Error al intentar registar paciente")
            End If
        Else
            MsgBox("Favor de llenar todos los datos del formulario")
        End If


    End Sub

    Private Function vacio()

        Dim nombre As String = txtNombres.Text
        Dim apellido As String = txtApellidos.Text
        Dim domicilio As String = txtDomicilio.Text
        Dim ciudad As String = txtCiudadEstado.Text
        Dim sexo As String = cbSexo.Text
        Dim FechaNacimiento As DateTime = dtpFecha.Value
        Dim telefono As String = txtTelefono.Text
        Dim correo As String = txtCorreo.Text

        If nombre = "" Or apellido = "" Or domicilio = "" Or ciudad = "" Or sexo = "" Or telefono = "" Or correo = "" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged
        Dim calculoEdad As Double = ((DateTime.Today.Year * 12 + DateTime.Today.Month) - (dtpFecha.Value.Year * 12 + dtpFecha.Value.Month)) / 12

        txtEdad.Text = String.Format("{0:N0}", calculoEdad)
    End Sub
End Class