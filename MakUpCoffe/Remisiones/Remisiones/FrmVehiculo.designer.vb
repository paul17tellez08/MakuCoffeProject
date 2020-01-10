<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVehiculo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVehiculo))
        Me.LblTitulo = New System.Windows.Forms.Label
        Me.LblApellido = New System.Windows.Forms.Label
        Me.TxtMarca = New System.Windows.Forms.TextBox
        Me.LblNombre = New System.Windows.Forms.Label
        Me.LblCodigo = New System.Windows.Forms.Label
        Me.CboPlaca = New C1.Win.C1List.C1Combo
        Me.CboTipo = New C1.Win.C1List.C1Combo
        Me.CmdGrabar = New System.Windows.Forms.Button
        Me.ButtonBorrar = New System.Windows.Forms.Button
        Me.CmdNuevo = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.C1Button2 = New C1.Win.C1Input.C1Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.Label1 = New System.Windows.Forms.Label
        Me.CboActivo = New System.Windows.Forms.ComboBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        CType(Me.CboPlaca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.LblTitulo.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.LblTitulo.Location = New System.Drawing.Point(120, 22)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(226, 18)
        Me.LblTitulo.TabIndex = 113
        Me.LblTitulo.Text = "CATALOGO DE VEHICULOS"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.LblApellido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.LblApellido.Location = New System.Drawing.Point(12, 145)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(94, 15)
        Me.LblApellido.TabIndex = 154
        Me.LblApellido.Text = "Tipo Vehiculo"
        '
        'TxtMarca
        '
        Me.TxtMarca.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.TxtMarca.Location = New System.Drawing.Point(123, 112)
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.Size = New System.Drawing.Size(255, 23)
        Me.TxtMarca.TabIndex = 148
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.LblNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.LblNombre.Location = New System.Drawing.Point(12, 116)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(44, 15)
        Me.LblNombre.TabIndex = 152
        Me.LblNombre.Text = "Marca"
        '
        'LblCodigo
        '
        Me.LblCodigo.AutoSize = True
        Me.LblCodigo.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.LblCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.LblCodigo.Location = New System.Drawing.Point(12, 86)
        Me.LblCodigo.Name = "LblCodigo"
        Me.LblCodigo.Size = New System.Drawing.Size(39, 15)
        Me.LblCodigo.TabIndex = 151
        Me.LblCodigo.Text = "Placa"
        '
        'CboPlaca
        '
        Me.CboPlaca.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.CboPlaca.Caption = ""
        Me.CboPlaca.CaptionHeight = 17
        Me.CboPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CboPlaca.ColumnCaptionHeight = 17
        Me.CboPlaca.ColumnFooterHeight = 17
        Me.CboPlaca.ContentHeight = 15
        Me.CboPlaca.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.CboPlaca.EditorBackColor = System.Drawing.SystemColors.Window
        Me.CboPlaca.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboPlaca.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.CboPlaca.EditorHeight = 15
        Me.CboPlaca.Images.Add(CType(resources.GetObject("CboPlaca.Images"), System.Drawing.Image))
        Me.CboPlaca.ItemHeight = 15
        Me.CboPlaca.Location = New System.Drawing.Point(123, 82)
        Me.CboPlaca.MatchEntryTimeout = CType(2000, Long)
        Me.CboPlaca.MaxDropDownItems = CType(5, Short)
        Me.CboPlaca.MaxLength = 32767
        Me.CboPlaca.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CboPlaca.Name = "CboPlaca"
        Me.CboPlaca.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CboPlaca.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.CboPlaca.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CboPlaca.Size = New System.Drawing.Size(212, 21)
        Me.CboPlaca.TabIndex = 147
        Me.CboPlaca.PropBag = resources.GetString("CboPlaca.PropBag")
        '
        'CboTipo
        '
        Me.CboTipo.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.CboTipo.Caption = ""
        Me.CboTipo.CaptionHeight = 17
        Me.CboTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CboTipo.ColumnCaptionHeight = 17
        Me.CboTipo.ColumnFooterHeight = 17
        Me.CboTipo.ContentHeight = 15
        Me.CboTipo.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.CboTipo.EditorBackColor = System.Drawing.SystemColors.Window
        Me.CboTipo.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboTipo.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.CboTipo.EditorHeight = 15
        Me.CboTipo.Images.Add(CType(resources.GetObject("CboTipo.Images"), System.Drawing.Image))
        Me.CboTipo.ItemHeight = 15
        Me.CboTipo.Location = New System.Drawing.Point(123, 141)
        Me.CboTipo.MatchEntryTimeout = CType(2000, Long)
        Me.CboTipo.MaxDropDownItems = CType(5, Short)
        Me.CboTipo.MaxLength = 32767
        Me.CboTipo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CboTipo.Name = "CboTipo"
        Me.CboTipo.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CboTipo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.CboTipo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CboTipo.Size = New System.Drawing.Size(255, 21)
        Me.CboTipo.TabIndex = 254
        Me.CboTipo.PropBag = resources.GetString("CboTipo.PropBag")
        '
        'CmdGrabar
        '
        Me.CmdGrabar.FlatAppearance.BorderSize = 0
        Me.CmdGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdGrabar.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.CmdGrabar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.CmdGrabar.Image = Global.Remisiones.My.Resources.Resources.Save4821
        Me.CmdGrabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CmdGrabar.Location = New System.Drawing.Point(101, 205)
        Me.CmdGrabar.Name = "CmdGrabar"
        Me.CmdGrabar.Size = New System.Drawing.Size(78, 68)
        Me.CmdGrabar.TabIndex = 250
        Me.CmdGrabar.Tag = "25"
        Me.CmdGrabar.Text = "Grabar"
        Me.CmdGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdGrabar.UseVisualStyleBackColor = True
        '
        'ButtonBorrar
        '
        Me.ButtonBorrar.FlatAppearance.BorderSize = 0
        Me.ButtonBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBorrar.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.ButtonBorrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.ButtonBorrar.Image = Global.Remisiones.My.Resources.Resources.Eliminar42
        Me.ButtonBorrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonBorrar.Location = New System.Drawing.Point(207, 208)
        Me.ButtonBorrar.Name = "ButtonBorrar"
        Me.ButtonBorrar.Size = New System.Drawing.Size(75, 67)
        Me.ButtonBorrar.TabIndex = 251
        Me.ButtonBorrar.Tag = "29"
        Me.ButtonBorrar.Text = "Eliminar"
        Me.ButtonBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonBorrar.UseVisualStyleBackColor = True
        '
        'CmdNuevo
        '
        Me.CmdNuevo.FlatAppearance.BorderSize = 0
        Me.CmdNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdNuevo.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.CmdNuevo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.CmdNuevo.Image = Global.Remisiones.My.Resources.Resources.CirculoPlus48
        Me.CmdNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CmdNuevo.Location = New System.Drawing.Point(10, 206)
        Me.CmdNuevo.Name = "CmdNuevo"
        Me.CmdNuevo.Size = New System.Drawing.Size(75, 67)
        Me.CmdNuevo.TabIndex = 249
        Me.CmdNuevo.Text = "Nuevo"
        Me.CmdNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdNuevo.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Button8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Button8.Image = Global.Remisiones.My.Resources.Resources.exit48
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button8.Location = New System.Drawing.Point(303, 207)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 66)
        Me.Button8.TabIndex = 252
        Me.Button8.Text = "Salir"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button8.UseVisualStyleBackColor = True
        '
        'C1Button2
        '
        Me.C1Button2.FlatAppearance.BorderSize = 0
        Me.C1Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.C1Button2.Image = Global.Remisiones.My.Resources.Resources.Lupa32
        Me.C1Button2.Location = New System.Drawing.Point(341, 74)
        Me.C1Button2.Name = "C1Button2"
        Me.C1Button2.Size = New System.Drawing.Size(32, 32)
        Me.C1Button2.TabIndex = 248
        Me.C1Button2.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.PictureBox2.Image = Global.Remisiones.My.Resources.Resources.Carro100
        Me.PictureBox2.Location = New System.Drawing.Point(0, -9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(69, 69)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 112
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(400, 60)
        Me.PictureBox1.TabIndex = 111
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 255
        Me.Label1.Text = "Color"
        '
        'CboActivo
        '
        Me.CboActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboActivo.FormattingEnabled = True
        Me.CboActivo.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.CboActivo.Location = New System.Drawing.Point(303, 170)
        Me.CboActivo.Name = "CboActivo"
        Me.CboActivo.Size = New System.Drawing.Size(75, 21)
        Me.CboActivo.TabIndex = 253
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.TextBox1.Location = New System.Drawing.Point(123, 169)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(159, 23)
        Me.TextBox1.TabIndex = 256
        '
        'FrmVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 281)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CboTipo)
        Me.Controls.Add(Me.CboActivo)
        Me.Controls.Add(Me.CmdGrabar)
        Me.Controls.Add(Me.ButtonBorrar)
        Me.Controls.Add(Me.CmdNuevo)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.C1Button2)
        Me.Controls.Add(Me.LblApellido)
        Me.Controls.Add(Me.CboPlaca)
        Me.Controls.Add(Me.TxtMarca)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.LblCodigo)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmVehiculo"
        Me.Text = "Vehiculo"
        CType(Me.CboPlaca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LblTitulo As System.Windows.Forms.Label
    Friend WithEvents LblApellido As System.Windows.Forms.Label
    Friend WithEvents TxtMarca As System.Windows.Forms.TextBox
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents LblCodigo As System.Windows.Forms.Label
    Friend WithEvents C1Button2 As C1.Win.C1Input.C1Button
    Friend WithEvents CmdGrabar As System.Windows.Forms.Button
    Friend WithEvents ButtonBorrar As System.Windows.Forms.Button
    Friend WithEvents CmdNuevo As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents CboPlaca As C1.Win.C1List.C1Combo
    Friend WithEvents CboTipo As C1.Win.C1List.C1Combo
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboActivo As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
