Public Class frmModificaPaciente

    Dim conexiondb As New conexionBD

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Dim buscarPaciente As New frmBuscarPaciente()
        buscarPaciente.modificarPaciente = True
        buscarPaciente.Show()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim nombre As String = txtNombres.Text
        Dim apellido As String = txtApellidos.Text
        Dim domicilio As String = txtDomicilio.Text
        Dim ciudad As String = txtCiudadEstado.Text
        Dim correo As String = txtCorreo.Text
        Dim fechaNacimiento As String = dtpFecha.Value.ToString("yyyy-MM-dd hh:mm:ss.fff")
        Dim sexo As String = cbSexo.Text
        Dim telefono As String = txtTelefono.Text
        Dim idPaciente As String = txtIdPaciente.Text
        Dim sqlUpdatePaciente As String = "Nombre = '" & nombre & "', Apellidos = '" & apellido & "', Domicilio = '" & domicilio & "', Ciudad = '" & ciudad & "', Sexo = '" & sexo & "', FechaNacimiento = CONVERT(datetime,'" & fechaNacimiento & "'), Telefono = '" & telefono & "', Correo = '" & correo & "'"
        Dim sqlCondicion As String = "PKPaciente = '" & idPaciente & "'"

        If Not vacio() Then
            If conexiondb.actualizar("CT_Pacientes", sqlUpdatePaciente, sqlCondicion) = True Then
                MsgBox("Cambios realizados con exito")
            End If
        Else
            MsgBox("Favor de llenar los datos del formulario")
        End If


    End Sub

    Private Function vacio()

        Dim nombre As String = txtNombres.Text
        Dim apellido As String = txtApellidos.Text

        If nombre = "" Or apellido = "" Then
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