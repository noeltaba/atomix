Public Class frmBuscarPaciente

    Dim obtenerDatos As DataSet
    Dim conexiondb As New conexionBD()
    Public modificarPaciente As Boolean
    Public altaOrden As Boolean

    Private Sub frmBuscarPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conexiondb.llenarDataGridView(dgvPaciente, "PKPaciente, Nombre, Apellidos, Domicilio,Ciudad, Correo, Telefono,Sexo, FechaNacimiento", "CT_Pacientes", "Apellidos")

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNombrePaciente.TextChanged

        conexiondb.buscarDataGridView(dgvPaciente, "SELECT PKPaciente, Nombre, Apellidos, Domicilio,Correo ,Telefono, FechaNacimiento  FROM CT_Pacientes WHERE (Apellidos LIKE '" + txtNombrePaciente.Text + "%') OR (Nombre LIKE '" + txtNombrePaciente.Text + "%') ORDER BY Apellidos ASC", "CT_Pacientes")

    End Sub

    Private Sub dgvPaciente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPaciente.CellClick

        If altaOrden = True Then
            If dgvPaciente.RowCount > 0 Then
                frmAltaOrdenLaboratorio.txtIdPaciente.Text = dgvPaciente.Rows(e.RowIndex).Cells(0).Value.ToString()
                frmAltaOrdenLaboratorio.txtNombre.Text = dgvPaciente.Rows(e.RowIndex).Cells(1).Value.ToString()
                frmAltaOrdenLaboratorio.txtApellido.Text = dgvPaciente.Rows(e.RowIndex).Cells(2).Value.ToString()
                frmAltaOrdenLaboratorio.txtEmailEnvio.Text = dgvPaciente.Rows(e.RowIndex).Cells(4).Value.ToString()
            End If
        ElseIf modificarPaciente = True Then
            If dgvPaciente.RowCount > 0 Then
                frmModificaPaciente.txtIdPaciente.Text = dgvPaciente.Rows(e.RowIndex).Cells(0).Value.ToString()
                frmModificaPaciente.txtNombres.Text = dgvPaciente.Rows(e.RowIndex).Cells(1).Value.ToString()
                frmModificaPaciente.txtApellidos.Text = dgvPaciente.Rows(e.RowIndex).Cells(2).Value.ToString()
                frmModificaPaciente.txtDomicilio.Text = dgvPaciente.Rows(e.RowIndex).Cells(3).Value.ToString()
                frmModificaPaciente.txtCiudadEstado.Text = dgvPaciente.Rows(e.RowIndex).Cells(4).Value.ToString()
                frmModificaPaciente.txtCorreo.Text = dgvPaciente.Rows(e.RowIndex).Cells(5).Value.ToString()
                frmModificaPaciente.txtTelefono.Text = dgvPaciente.Rows(e.RowIndex).Cells(6).Value.ToString()
                frmModificaPaciente.cbSexo.SelectedIndex = frmModificaPaciente.cbSexo.FindString(dgvPaciente.Rows(e.RowIndex).Cells(7).Value.ToString())
                frmModificaPaciente.dtpFecha.Value = Convert.ToDateTime(dgvPaciente.Rows(e.RowIndex).Cells(8).Value.ToString())
            End If
        End If
    End Sub

    Private Sub btnCargaDatosCliente_Click(sender As Object, e As EventArgs) Handles btnCargaDatosCliente.Click
        Me.Close()
    End Sub

    Private Sub dgvPaciente_DoubleClick(sender As Object, e As EventArgs) Handles dgvPaciente.DoubleClick
        Me.Close()
        frmAltaOrdenLaboratorio.cbFormaDeEntrega.SelectedIndex = 0
    End Sub

    Private Sub frmBuscarPaciente_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        modificarPaciente = False
        altaOrden = False
    End Sub
End Class