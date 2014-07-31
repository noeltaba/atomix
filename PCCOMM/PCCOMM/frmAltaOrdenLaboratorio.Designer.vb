<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAltaOrdenLaboratorio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAltaOrdenLaboratorio))
        Me.btnEtiqueta = New System.Windows.Forms.Button()
        Me.btnImprimirOrdenLaboratorio = New System.Windows.Forms.Button()
        Me.btnTicket = New System.Windows.Forms.Button()
        Me.btnImprimirOrdenCliente = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnNuevaOrden = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.dgvEstudios = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colum2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnDescuento = New System.Windows.Forms.Button()
        Me.btnAbonar = New System.Windows.Forms.Button()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.txtAnticipo = New System.Windows.Forms.TextBox()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFolio = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnEliminarEstudio = New System.Windows.Forms.Button()
        Me.cbRecibi = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnAgregarEstudio = New System.Windows.Forms.Button()
        Me.cbMedico = New System.Windows.Forms.ComboBox()
        Me.cbEstudio = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEmailEnvio = New System.Windows.Forms.TextBox()
        Me.cbFormaDeEntrega = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIdPaciente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.dtpFechaActual = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvEstudios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEtiqueta
        '
        Me.btnEtiqueta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEtiqueta.Image = CType(resources.GetObject("btnEtiqueta.Image"), System.Drawing.Image)
        Me.btnEtiqueta.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEtiqueta.Location = New System.Drawing.Point(10, 480)
        Me.btnEtiqueta.Name = "btnEtiqueta"
        Me.btnEtiqueta.Size = New System.Drawing.Size(91, 65)
        Me.btnEtiqueta.TabIndex = 36
        Me.btnEtiqueta.Text = "Etiqueta"
        Me.btnEtiqueta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEtiqueta.UseVisualStyleBackColor = True
        '
        'btnImprimirOrdenLaboratorio
        '
        Me.btnImprimirOrdenLaboratorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimirOrdenLaboratorio.Image = CType(resources.GetObject("btnImprimirOrdenLaboratorio.Image"), System.Drawing.Image)
        Me.btnImprimirOrdenLaboratorio.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimirOrdenLaboratorio.Location = New System.Drawing.Point(204, 478)
        Me.btnImprimirOrdenLaboratorio.Name = "btnImprimirOrdenLaboratorio"
        Me.btnImprimirOrdenLaboratorio.Size = New System.Drawing.Size(96, 65)
        Me.btnImprimirOrdenLaboratorio.TabIndex = 35
        Me.btnImprimirOrdenLaboratorio.Text = "Imprimir orden laboratorio"
        Me.btnImprimirOrdenLaboratorio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimirOrdenLaboratorio.UseVisualStyleBackColor = True
        '
        'btnTicket
        '
        Me.btnTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTicket.Image = CType(resources.GetObject("btnTicket.Image"), System.Drawing.Image)
        Me.btnTicket.Location = New System.Drawing.Point(107, 480)
        Me.btnTicket.Name = "btnTicket"
        Me.btnTicket.Size = New System.Drawing.Size(91, 65)
        Me.btnTicket.TabIndex = 34
        Me.btnTicket.Text = "Ticket"
        Me.btnTicket.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTicket.UseVisualStyleBackColor = True
        '
        'btnImprimirOrdenCliente
        '
        Me.btnImprimirOrdenCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimirOrdenCliente.Image = CType(resources.GetObject("btnImprimirOrdenCliente.Image"), System.Drawing.Image)
        Me.btnImprimirOrdenCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimirOrdenCliente.Location = New System.Drawing.Point(306, 478)
        Me.btnImprimirOrdenCliente.Name = "btnImprimirOrdenCliente"
        Me.btnImprimirOrdenCliente.Size = New System.Drawing.Size(91, 65)
        Me.btnImprimirOrdenCliente.TabIndex = 33
        Me.btnImprimirOrdenCliente.Text = "Imprimir orden cliente"
        Me.btnImprimirOrdenCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimirOrdenCliente.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.Image = CType(resources.GetObject("btnActualizar.Image"), System.Drawing.Image)
        Me.btnActualizar.Location = New System.Drawing.Point(512, 480)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(91, 65)
        Me.btnActualizar.TabIndex = 32
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnNuevaOrden
        '
        Me.btnNuevaOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevaOrden.Image = CType(resources.GetObject("btnNuevaOrden.Image"), System.Drawing.Image)
        Me.btnNuevaOrden.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevaOrden.Location = New System.Drawing.Point(609, 480)
        Me.btnNuevaOrden.Name = "btnNuevaOrden"
        Me.btnNuevaOrden.Size = New System.Drawing.Size(91, 65)
        Me.btnNuevaOrden.TabIndex = 31
        Me.btnNuevaOrden.Text = "Nueva orden"
        Me.btnNuevaOrden.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevaOrden.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresar.Image = CType(resources.GetObject("btnRegresar.Image"), System.Drawing.Image)
        Me.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRegresar.Location = New System.Drawing.Point(706, 480)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(91, 65)
        Me.btnRegresar.TabIndex = 30
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'dgvEstudios
        '
        Me.dgvEstudios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEstudios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEstudios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Colum2, Me.Column3})
        Me.dgvEstudios.Location = New System.Drawing.Point(10, 333)
        Me.dgvEstudios.Name = "dgvEstudios"
        Me.dgvEstudios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEstudios.Size = New System.Drawing.Size(514, 139)
        Me.dgvEstudios.TabIndex = 29
        '
        'Column1
        '
        Me.Column1.HeaderText = "Num. Orden"
        Me.Column1.Name = "Column1"
        '
        'Colum2
        '
        Me.Colum2.HeaderText = "Estudio"
        Me.Colum2.Name = "Colum2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Precio"
        Me.Column3.Name = "Column3"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.LimeGreen
        Me.GroupBox3.Controls.Add(Me.btnDescuento)
        Me.GroupBox3.Controls.Add(Me.btnAbonar)
        Me.GroupBox3.Controls.Add(Me.txtSaldo)
        Me.GroupBox3.Controls.Add(Me.txtDescuento)
        Me.GroupBox3.Controls.Add(Me.txtAnticipo)
        Me.GroupBox3.Controls.Add(Me.txtSubTotal)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox3.Location = New System.Drawing.Point(530, 333)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(263, 139)
        Me.GroupBox3.TabIndex = 28
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pagos"
        '
        'btnDescuento
        '
        Me.btnDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDescuento.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDescuento.Image = CType(resources.GetObject("btnDescuento.Image"), System.Drawing.Image)
        Me.btnDescuento.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDescuento.Location = New System.Drawing.Point(171, 85)
        Me.btnDescuento.Name = "btnDescuento"
        Me.btnDescuento.Size = New System.Drawing.Size(86, 48)
        Me.btnDescuento.TabIndex = 9
        Me.btnDescuento.Text = "Descuento"
        Me.btnDescuento.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDescuento.UseVisualStyleBackColor = True
        '
        'btnAbonar
        '
        Me.btnAbonar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbonar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAbonar.Image = CType(resources.GetObject("btnAbonar.Image"), System.Drawing.Image)
        Me.btnAbonar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAbonar.Location = New System.Drawing.Point(171, 16)
        Me.btnAbonar.Name = "btnAbonar"
        Me.btnAbonar.Size = New System.Drawing.Size(86, 70)
        Me.btnAbonar.TabIndex = 8
        Me.btnAbonar.Text = "Abonar"
        Me.btnAbonar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAbonar.UseVisualStyleBackColor = True
        '
        'txtSaldo
        '
        Me.txtSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.Location = New System.Drawing.Point(80, 106)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(76, 20)
        Me.txtSaldo.TabIndex = 7
        '
        'txtDescuento
        '
        Me.txtDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescuento.Location = New System.Drawing.Point(80, 79)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(76, 20)
        Me.txtDescuento.TabIndex = 6
        '
        'txtAnticipo
        '
        Me.txtAnticipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnticipo.Location = New System.Drawing.Point(80, 52)
        Me.txtAnticipo.Name = "txtAnticipo"
        Me.txtAnticipo.Size = New System.Drawing.Size(76, 20)
        Me.txtAnticipo.TabIndex = 5
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.Location = New System.Drawing.Point(80, 25)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(76, 20)
        Me.txtSubTotal.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(35, 109)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 13)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Saldo"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(6, 83)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Descuento"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(21, 55)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Anticipo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(12, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Sub-Total"
        '
        'txtFolio
        '
        Me.txtFolio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFolio.Location = New System.Drawing.Point(45, 35)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(77, 29)
        Me.txtFolio.TabIndex = 27
        Me.txtFolio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.SteelBlue
        Me.GroupBox2.Controls.Add(Me.btnEliminarEstudio)
        Me.GroupBox2.Controls.Add(Me.cbRecibi)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.btnAgregarEstudio)
        Me.GroupBox2.Controls.Add(Me.cbMedico)
        Me.GroupBox2.Controls.Add(Me.cbEstudio)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtPrecio)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(10, 206)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(783, 121)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de la orden"
        '
        'btnEliminarEstudio
        '
        Me.btnEliminarEstudio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarEstudio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEliminarEstudio.Image = CType(resources.GetObject("btnEliminarEstudio.Image"), System.Drawing.Image)
        Me.btnEliminarEstudio.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminarEstudio.Location = New System.Drawing.Point(689, 19)
        Me.btnEliminarEstudio.Name = "btnEliminarEstudio"
        Me.btnEliminarEstudio.Size = New System.Drawing.Size(86, 80)
        Me.btnEliminarEstudio.TabIndex = 15
        Me.btnEliminarEstudio.Text = "Eliminar estudio"
        Me.btnEliminarEstudio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminarEstudio.UseVisualStyleBackColor = True
        '
        'cbRecibi
        '
        Me.cbRecibi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRecibi.FormattingEnabled = True
        Me.cbRecibi.Location = New System.Drawing.Point(399, 69)
        Me.cbRecibi.Name = "cbRecibi"
        Me.cbRecibi.Size = New System.Drawing.Size(184, 21)
        Me.cbRecibi.TabIndex = 14
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.SteelBlue
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(328, 72)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 13)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Recibi de:"
        '
        'btnAgregarEstudio
        '
        Me.btnAgregarEstudio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarEstudio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAgregarEstudio.Image = CType(resources.GetObject("btnAgregarEstudio.Image"), System.Drawing.Image)
        Me.btnAgregarEstudio.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregarEstudio.Location = New System.Drawing.Point(597, 19)
        Me.btnAgregarEstudio.Name = "btnAgregarEstudio"
        Me.btnAgregarEstudio.Size = New System.Drawing.Size(86, 80)
        Me.btnAgregarEstudio.TabIndex = 12
        Me.btnAgregarEstudio.Text = "Agregar estudio"
        Me.btnAgregarEstudio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregarEstudio.UseVisualStyleBackColor = True
        '
        'cbMedico
        '
        Me.cbMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMedico.FormattingEnabled = True
        Me.cbMedico.Location = New System.Drawing.Point(399, 29)
        Me.cbMedico.Name = "cbMedico"
        Me.cbMedico.Size = New System.Drawing.Size(184, 21)
        Me.cbMedico.TabIndex = 10
        '
        'cbEstudio
        '
        Me.cbEstudio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbEstudio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbEstudio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEstudio.FormattingEnabled = True
        Me.cbEstudio.Location = New System.Drawing.Point(65, 29)
        Me.cbEstudio.Name = "cbEstudio"
        Me.cbEstudio.Size = New System.Drawing.Size(250, 21)
        Me.cbEstudio.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.SteelBlue
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(6, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Estudio:"
        '
        'txtPrecio
        '
        Me.txtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.Location = New System.Drawing.Point(65, 74)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(80, 20)
        Me.txtPrecio.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.SteelBlue
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(12, 77)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Precio:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.SteelBlue
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(341, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Medico:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtApellido)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtEmailEnvio)
        Me.GroupBox1.Controls.Add(Me.cbFormaDeEntrega)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtIdPaciente)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(10, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(783, 121)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del paciente"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(563, 40)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(212, 20)
        Me.txtNombre.TabIndex = 38
        '
        'txtApellido
        '
        Me.txtApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.Location = New System.Drawing.Point(236, 39)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(243, 20)
        Me.txtApellido.TabIndex = 37
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.SteelBlue
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(446, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "E- mail para envio:"
        '
        'txtEmailEnvio
        '
        Me.txtEmailEnvio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailEnvio.Location = New System.Drawing.Point(563, 78)
        Me.txtEmailEnvio.Name = "txtEmailEnvio"
        Me.txtEmailEnvio.Size = New System.Drawing.Size(212, 20)
        Me.txtEmailEnvio.TabIndex = 9
        '
        'cbFormaDeEntrega
        '
        Me.cbFormaDeEntrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFormaDeEntrega.FormattingEnabled = True
        Me.cbFormaDeEntrega.Items.AddRange(New Object() {"ENVIAR POR CORREO", "ENVIAR POR FAX", "EL PACIENTE RECOGE", "EL DOCTOR RECOGE"})
        Me.cbFormaDeEntrega.Location = New System.Drawing.Point(236, 78)
        Me.cbFormaDeEntrega.Name = "cbFormaDeEntrega"
        Me.cbFormaDeEntrega.Size = New System.Drawing.Size(200, 21)
        Me.cbFormaDeEntrega.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.SteelBlue
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(109, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Formato de entrega:"
        '
        'txtIdPaciente
        '
        Me.txtIdPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdPaciente.Location = New System.Drawing.Point(85, 34)
        Me.txtIdPaciente.Name = "txtIdPaciente"
        Me.txtIdPaciente.Size = New System.Drawing.Size(77, 29)
        Me.txtIdPaciente.TabIndex = 1
        Me.txtIdPaciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.SteelBlue
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(491, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Nombre(s):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.SteelBlue
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(87, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ID paciente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(168, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Apellidos:"
        '
        'btnBuscar
        '
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(9, 34)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(65, 29)
        Me.btnBuscar.TabIndex = 21
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'dtpFechaActual
        '
        Me.dtpFechaActual.Location = New System.Drawing.Point(573, 40)
        Me.dtpFechaActual.Name = "dtpFechaActual"
        Me.dtpFechaActual.Size = New System.Drawing.Size(220, 20)
        Me.dtpFechaActual.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(527, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Fecha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Folio:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.VerToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 25
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(36, 20)
        Me.VerToolStripMenuItem.Text = "Ver"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'frmAltaOrdenLaboratorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 554)
        Me.Controls.Add(Me.btnEtiqueta)
        Me.Controls.Add(Me.btnImprimirOrdenLaboratorio)
        Me.Controls.Add(Me.btnTicket)
        Me.Controls.Add(Me.btnImprimirOrdenCliente)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnNuevaOrden)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.dgvEstudios)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtpFechaActual)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmAltaOrdenLaboratorio"
        Me.Text = "Alta orden laboratorio"
        CType(Me.dgvEstudios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEtiqueta As System.Windows.Forms.Button
    Friend WithEvents btnImprimirOrdenLaboratorio As System.Windows.Forms.Button
    Friend WithEvents btnTicket As System.Windows.Forms.Button
    Friend WithEvents btnImprimirOrdenCliente As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents btnNuevaOrden As System.Windows.Forms.Button
    Friend WithEvents btnRegresar As System.Windows.Forms.Button
    Friend WithEvents dgvEstudios As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDescuento As System.Windows.Forms.Button
    Friend WithEvents btnAbonar As System.Windows.Forms.Button
    Friend WithEvents txtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents txtDescuento As System.Windows.Forms.TextBox
    Friend WithEvents txtAnticipo As System.Windows.Forms.TextBox
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbRecibi As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnAgregarEstudio As System.Windows.Forms.Button
    Friend WithEvents cbMedico As System.Windows.Forms.ComboBox
    Friend WithEvents cbEstudio As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtEmailEnvio As System.Windows.Forms.TextBox
    Friend WithEvents cbFormaDeEntrega As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaActual As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtIdPaciente As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Colum2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnEliminarEstudio As System.Windows.Forms.Button
End Class
