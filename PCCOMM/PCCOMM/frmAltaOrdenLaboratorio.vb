Imports System.Data
Imports System.Data.SqlClient

Public Class frmAltaOrdenLaboratorio

    Dim obtenerDato As DataSet
    Public conexionbd As New conexionBD


    Public Sub llenarCombo(MicomboBox As ComboBox, columna As String, tabla As String, orderBy As String)

        obtenerDato = New DataSet
        obtenerDato.Reset()
        conexionbd.adaptador = conexionbd.consulta("SELECT " + columna + " FROM " + tabla + " ORDER BY " + orderBy + " ASC")
        conexionbd.adaptador.Fill(obtenerDato, tabla)

        MicomboBox.DataSource = obtenerDato.Tables(tabla)
        MicomboBox.DisplayMember = columna
        MicomboBox.SelectedIndex = -1

    End Sub

    Private Sub frmAltaOrdenLaboratorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        llenarCombo(cbApellido, "Apellidos", "CT_Pacientes", "Apellidos")
        llenarCombo(cbNombre, "Nombre", "CT_Pacientes", "Apellidos")
        llenarCombo(cbEstudio, "Analisis", "CT_Analisis", "Analisis")

    End Sub

    Private Sub cbApellido_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbApellido.SelectedIndexChanged

        If cbApellido.SelectedIndex > 0 Then

            Dim index As Integer = cbApellido.SelectedIndex
            cbNombre.SelectedIndex = index

        End If
    End Sub

    Private Sub txtIdPaciente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdPaciente.KeyPress

        If e.KeyChar.Equals(Convert.ToChar(Keys.Enter)) Then

            txtIdPaciente.Text = "llenar datos"

        End If
    End Sub

End Class