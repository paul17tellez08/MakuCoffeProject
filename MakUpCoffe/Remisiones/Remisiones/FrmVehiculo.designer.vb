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
        Me.Label2 = New System.Windows.Forms.Label
        Me.CboModelo = New C1.Win.C1List.C1Combo
        Me.CboMarca = New C1.Win.C1List.C1Combo
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.CboColor = New C1.Win.C1List.C1Combo
        CType(Me.CboPlaca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboModelo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboColor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.BackColor = System.Drawing.Color.White
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
        Me.LblApellido.Location = New System.Drawing.Point(12, 173)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(94, 15)
        Me.LblApellido.TabIndex = 154
        Me.LblApellido.Text = "Tipo Vehiculo"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.LblNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.LblNombre.Location = New System.Drawing.Point(12, 116)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(52, 15)
        Me.LblNombre.TabIndex = 152
        Me.LblNombre.Text = "Marca :"
        '
        'LblCodigo
        '
        Me.LblCodigo.AutoSize = True
        Me.LblCodigo.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.LblCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.LblCodigo.Location = New System.Drawing.Point(12, 86)
        Me.LblCodigo.Name = "LblCodigo"
        Me.LblCodigo.Size = New System.Drawing.Size(47, 15)
        Me.LblCodigo.TabIndex = 151
        Me.LblCodigo.Text = "Placa :"
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
        Me.CboTipo.Location = New System.Drawing.Point(123, 169)
        Me.CboTipo.MatchEntryTimeout = CType(2000, Long)
        Me.CboTipo.MaxDropDownItems = CType(5, Short)
        Me.CboTipo.MaxLength = 32767
        Me.CboTipo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CboTipo.Name = "CboTipo"
        Me.CboTipo.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CboTipo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.CboTipo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CboTipo.Size = New System.Drawing.Size(212, 21)
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
        Me.CmdGrabar.Location = New System.Drawing.Point(101, 237)
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
        Me.ButtonBorrar.Location = New System.Drawing.Point(207, 240)
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
        Me.CmdNuevo.Location = New System.Drawing.Point(10, 238)
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
        Me.Button8.Location = New System.Drawing.Point(303, 239)
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
        Me.C1Button2.Location = New System.Drawing.Point(341, 76)
        Me.C1Button2.Name = "C1Button2"
        Me.C1Button2.Size = New System.Drawing.Size(32, 32)
        Me.C1Button2.TabIndex = 248
        Me.C1Button2.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
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
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(385, 60)
        Me.PictureBox1.TabIndex = 111
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 255
        Me.Label1.Text = "Color"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 15)
        Me.Label2.TabIndex = 257
        Me.Label2.Text = "Modelo :"
        '
        'CboModelo
        '
        Me.CboModelo.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.CboModelo.Caption = ""
        Me.CboModelo.CaptionHeight = 17
        Me.CboModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CboModelo.ColumnCaptionHeight = 17
        Me.CboModelo.ColumnFooterHeight = 17
        Me.CboModelo.ContentHeight = 15
        Me.CboModelo.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.CboModelo.EditorBackColor = System.Drawing.SystemColors.Window
        Me.CboModelo.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboModelo.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.CboModelo.EditorHeight = 15
        Me.CboModelo.Images.Add(CType(resources.GetObject("CboModelo.Images"), System.Drawing.Image))
        Me.CboModelo.ItemHeight = 15
        Me.CboModelo.Location = New System.Drawing.Point(123, 140)
        Me.CboModelo.MatchEntryTimeout = CType(2000, Long)
        Me.CboModelo.MaxDropDownItems = CType(5, Short)
        Me.CboModelo.MaxLength = 32767
        Me.CboModelo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CboModelo.Name = "CboModelo"
        Me.CboModelo.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CboModelo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.CboModelo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CboModelo.Size = New System.Drawing.Size(212, 21)
        Me.CboModelo.TabIndex = 258
        Me.CboModelo.PropBag = resources.GetString("CboModelo.PropBag")
        '
        'CboMarca
        '
        Me.CboMarca.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.CboMarca.Caption = ""
        Me.CboMarca.CaptionHeight = 17
        Me.CboMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CboMarca.ColumnCaptionHeight = 17
        Me.CboMarca.ColumnFooterHeight = 17
        Me.CboMarca.ContentHeight = 15
        Me.CboMarca.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.CboMarca.EditorBackColor = System.Drawing.SystemColors.Window
        Me.CboMarca.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboMarca.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.CboMarca.EditorHeight = 15
        Me.CboMarca.Images.Add(CType(resources.GetObject("CboMarca.Images"), System.Drawing.Image))
        Me.CboMarca.ItemHeight = 15
        Me.CboMarca.Location = New System.Drawing.Point(123, 112)
        Me.CboMarca.MatchEntryTimeout = CType(2000, Long)
        Me.CboMarca.MaxDropDownItems = CType(5, Short)
        Me.CboMarca.MaxLength = 32767
        Me.CboMarca.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CboMarca.Name = "CboMarca"
        Me.CboMarca.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CboMarca.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.CboMarca.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CboMarca.Size = New System.Drawing.Size(212, 21)
        Me.CboMarca.TabIndex = 259
        Me.CboMarca.PropBag = resources.GetString("CboMarca.PropBag")
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(266, 198)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(66, 19)
        Me.CheckBox1.TabIndex = 260
        Me.CheckBox1.Text = "Activo"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CboColor
        '
        Me.CboColor.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.CboColor.Caption = ""
        Me.CboColor.CaptionHeight = 17
        Me.CboColor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CboColor.ColumnCaptionHeight = 17
        Me.CboColor.ColumnFooterHeight = 17
        Me.CboColor.ContentHeight = 15
        Me.CboColor.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.CboColor.EditorBackColor = System.Drawing.SystemColors.Window
        Me.CboColor.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboColor.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.CboColor.EditorHeight = 15
        Me.CboColor.Images.Add(CType(resources.GetObject("CboColor.Images"), System.Drawing.Image))
        Me.CboColor.ItemHeight = 15
        Me.CboColor.Location = New System.Drawing.Point(123, 196)
        Me.CboColor.MatchEntryTimeout = CType(2000, Long)
        Me.CboColor.MaxDropDownItems = CType(5, Short)
        Me.CboColor.MaxLength = 32767
        Me.CboColor.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CboColor.Name = "CboColor"
        Me.CboColor.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CboColor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.CboColor.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CboColor.Size = New System.Drawing.Size(133, 21)
        Me.CboColor.TabIndex = 261
        Me.CboColor.PropBag = resources.GetString("CboColor.PropBag")
        '
        'FrmVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(385, 312)
        Me.Controls.Add(Me.CboColor)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.CboMarca)
        Me.Controls.Add(Me.CboModelo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CboTipo)
        Me.Controls.Add(Me.CmdGrabar)
        Me.Controls.Add(Me.ButtonBorrar)
        Me.Controls.Add(Me.CmdNuevo)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.C1Button2)
        Me.Controls.Add(Me.LblApellido)
        Me.Controls.Add(Me.CboPlaca)
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
        CType(Me.CboModelo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboMarca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboColor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LblTitulo As System.Windows.Forms.Label
    Friend WithEvents LblApellido As System.Windows.Forms.Label
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CboModelo As C1.Win.C1List.C1Combo
    Friend WithEvents CboMarca As C1.Win.C1List.C1Combo
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CboColor As C1.Win.C1List.C1Combo
End Class
