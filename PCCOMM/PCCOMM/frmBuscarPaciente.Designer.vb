<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarPaciente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvPaciente = New System.Windows.Forms.DataGridView()
        Me.txtNombrePaciente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCargaDatosCliente = New System.Windows.Forms.Button()
        CType(Me.dgvPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPaciente
        '
        Me.dgvPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPaciente.Location = New System.Drawing.Point(12, 50)
        Me.dgvPaciente.Name = "dgvPaciente"
        Me.dgvPaciente.ReadOnly = True
        Me.dgvPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPaciente.Size = New System.Drawing.Size(653, 218)
        Me.dgvPaciente.TabIndex = 0
        '
        'txtNombrePaciente
        '
        Me.txtNombrePaciente.Location = New System.Drawing.Point(109, 12)
        Me.txtNombrePaciente.Name = "txtNombrePaciente"
        Me.txtNombrePaciente.Size = New System.Drawing.Size(373, 20)
        Me.txtNombrePaciente.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre paciente:"
        '
        'btnCargaDatosCliente
        '
        Me.btnCargaDatosCliente.Location = New System.Drawing.Point(590, 278)
        Me.btnCargaDatosCliente.Name = "btnCargaDatosCliente"
        Me.btnCargaDatosCliente.Size = New System.Drawing.Size(75, 41)
        Me.btnCargaDatosCliente.TabIndex = 3
        Me.btnCargaDatosCliente.Text = "Cargar datos"
        Me.btnCargaDatosCliente.UseVisualStyleBackColor = True
        '
        'frmBuscarPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 331)
        Me.Controls.Add(Me.btnCargaDatosCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNombrePaciente)
        Me.Controls.Add(Me.dgvPaciente)
        Me.Name = "frmBuscarPaciente"
        Me.Text = "frmBuscarPaciente"
        CType(Me.dgvPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvPaciente As System.Windows.Forms.DataGridView
    Friend WithEvents txtNombrePaciente As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCargaDatosCliente As System.Windows.Forms.Button
End Class
