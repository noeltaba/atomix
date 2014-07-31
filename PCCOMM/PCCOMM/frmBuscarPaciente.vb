Public Class frmBuscarPaciente

    Dim obtenerDatos As DataSet
    Dim conexiondb As New conexionBD()

    Private Sub frmBuscarPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conexiondb.llenarDataGridView(dgvPaciente, "PKPaciente, Nombre, Apellidos, Domicilio, Correo, Telefono, FechaNacimiento", "CT_Pacientes", "Apellidos")

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNombrePaciente.TextChanged

        conexiondb.buscarDataGridView(dgvPaciente, "SELECT PKPaciente, Nombre, Apellidos, Domicilio,Correo ,Telefono, FechaNacimiento  FROM CT_Pacientes WHERE (Apellidos LIKE '" + txtNombrePaciente.Text + "%') OR (Nombre LIKE '" + txtNombrePaciente.Text + "%') ORDER BY Apellidos ASC", "CT_Pacientes")

    End Sub

    Private Sub dgvPaciente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPaciente.CellClick

        If dgvPaciente.RowCount > 0 Then
            frmAltaOrdenLaboratorio.txtIdPaciente.Text = dgvPaciente.Rows(e.RowIndex).Cells(0).Value.ToString()
            frmAltaOrdenLaboratorio.txtApellido.Text = dgvPaciente.Rows(e.RowIndex).Cells(2).Value.ToString()
            frmAltaOrdenLaboratorio.txtNombre.Text = dgvPaciente.Rows(e.RowIndex).Cells(1).Value.ToString()
            frmAltaOrdenLaboratorio.txtEmailEnvio.Text = dgvPaciente.Rows(e.RowIndex).Cells(4).Value.ToString()
        End If

    End Sub

    Private Sub btnCargaDatosCliente_Click(sender As Object, e As EventArgs) Handles btnCargaDatosCliente.Click
        Me.Close()
    End Sub

    Private Sub dgvPaciente_DoubleClick(sender As Object, e As EventArgs) Handles dgvPaciente.DoubleClick
        Me.Close()
        frmAltaOrdenLaboratorio.cbFormaDeEntrega.SelectedIndex = 0
    End Sub

End Class