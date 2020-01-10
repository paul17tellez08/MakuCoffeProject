<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConductor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConductor))
        Me.CboActivo = New System.Windows.Forms.ComboBox
        Me.LblApellido = New System.Windows.Forms.Label
        Me.CboCodigoConductor = New C1.Win.C1List.C1Combo
        Me.TxtNombre = New System.Windows.Forms.TextBox
        Me.LblNombre = New System.Windows.Forms.Label
        Me.LblCodigo = New System.Windows.Forms.Label
        Me.LblTitulo = New System.Windows.Forms.Label
        Me.TxtCedula = New System.Windows.Forms.TextBox
        Me.TxtLicencia = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.CboLstaNegra = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtMotivo = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.ButtonGrabar = New System.Windows.Forms.Button
        Me.ButtonBorrar = New System.Windows.Forms.Button
        Me.ButtonNuevo = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.C1Button2 = New C1.Win.C1Input.C1Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.CboCodigoConductor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CboActivo
        '
        Me.CboActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboActivo.FormattingEnabled = True
        Me.CboActivo.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.CboActivo.Location = New System.Drawing.Point(122, 172)
        Me.CboActivo.Name = "CboActivo"
        Me.CboActivo.Size = New System.Drawing.Size(143, 21)
        Me.CboActivo.TabIndex = 268
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.LblApellido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.LblApellido.Location = New System.Drawing.Point(11, 124)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(50, 15)
        Me.LblApellido.TabIndex = 262
        Me.LblApellido.Text = "Cedula"
        '
        'CboCodigoConductor
        '
        Me.CboCodigoConductor.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.CboCodigoConductor.Caption = ""
        Me.CboCodigoConductor.CaptionHeight = 17
        Me.CboCodigoConductor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CboCodigoConductor.ColumnCaptionHeight = 17
        Me.CboCodigoConductor.ColumnFooterHeight = 17
        Me.CboCodigoConductor.ContentHeight = 15
        Me.CboCodigoConductor.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.CboCodigoConductor.EditorBackColor = System.Drawing.SystemColors.Window
        Me.CboCodigoConductor.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCodigoConductor.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.CboCodigoConductor.EditorHeight = 15
        Me.CboCodigoConductor.Images.Add(CType(resources.GetObject("CboCodigoConductor.Images"), System.Drawing.Image))
        Me.CboCodigoConductor.ItemHeight = 15
        Me.CboCodigoConductor.Location = New System.Drawing.Point(122, 69)
        Me.CboCodigoConductor.MatchEntryTimeout = CType(2000, Long)
        Me.CboCodigoConductor.MaxDropDownItems = CType(5, Short)
        Me.CboCodigoConductor.MaxLength = 32767
        Me.CboCodigoConductor.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CboCodigoConductor.Name = "CboCodigoConductor"
        Me.CboCodigoConductor.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CboCodigoConductor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.CboCodigoConductor.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CboCodigoConductor.Size = New System.Drawing.Size(177, 21)
        Me.CboCodigoConductor.TabIndex = 258
        Me.CboCodigoConductor.PropBag = resources.GetString("CboCodigoConductor.PropBag")
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(122, 96)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(260, 20)
        Me.TxtNombre.TabIndex = 259
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.LblNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.LblNombre.Location = New System.Drawing.Point(12, 98)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(57, 15)
        Me.LblNombre.TabIndex = 261
        Me.LblNombre.Text = "Nombre"
        '
        'LblCodigo
        '
        Me.LblCodigo.AutoSize = True
        Me.LblCodigo.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.LblCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.LblCodigo.Location = New System.Drawing.Point(12, 72)
        Me.LblCodigo.Name = "LblCodigo"
        Me.LblCodigo.Size = New System.Drawing.Size(52, 15)
        Me.LblCodigo.TabIndex = 260
        Me.LblCodigo.Text = "Codigo"
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.LblTitulo.Location = New System.Drawing.Point(119, 23)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(192, 13)
        Me.LblTitulo.TabIndex = 257
        Me.LblTitulo.Text = "CATALOGO DE CONDUCTORES"
        '
        'TxtCedula
        '
        Me.TxtCedula.Location = New System.Drawing.Point(122, 121)
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(259, 20)
        Me.TxtCedula.TabIndex = 269
        '
        'TxtLicencia
        '
        Me.TxtLicencia.Location = New System.Drawing.Point(122, 146)
        Me.TxtLicencia.Name = "TxtLicencia"
        Me.TxtLicencia.Size = New System.Drawing.Size(259, 20)
        Me.TxtLicencia.TabIndex = 271
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(11, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 15)
        Me.Label1.TabIndex = 270
        Me.Label1.Text = "Licencia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 15)
        Me.Label2.TabIndex = 272
        Me.Label2.Text = "Activo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(11, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 15)
        Me.Label3.TabIndex = 274
        Me.Label3.Text = "Lista Negra"
        '
        'CboLstaNegra
        '
        Me.CboLstaNegra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboLstaNegra.FormattingEnabled = True
        Me.CboLstaNegra.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.CboLstaNegra.Location = New System.Drawing.Point(122, 200)
        Me.CboLstaNegra.Name = "CboLstaNegra"
        Me.CboLstaNegra.Size = New System.Drawing.Size(143, 21)
        Me.CboLstaNegra.TabIndex = 273
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(8, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 15)
        Me.Label4.TabIndex = 275
        Me.Label4.Text = "Motivo Lta Negra"
        '
        'TxtMotivo
        '
        Me.TxtMotivo.Location = New System.Drawing.Point(122, 226)
        Me.TxtMotivo.Multiline = True
        Me.TxtMotivo.Name = "TxtMotivo"
        Me.TxtMotivo.Size = New System.Drawing.Size(259, 62)
        Me.TxtMotivo.TabIndex = 276
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Button3.Image = Global.Remisiones.My.Resources.Resources.Teclado32
        Me.Button3.Location = New System.Drawing.Point(306, 61)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(32, 32)
        Me.Button3.TabIndex = 277
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ButtonGrabar
        '
        Me.ButtonGrabar.FlatAppearance.BorderSize = 0
        Me.ButtonGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGrabar.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonGrabar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.ButtonGrabar.Image = Global.Remisiones.My.Resources.Resources.Save4811
        Me.ButtonGrabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonGrabar.Location = New System.Drawing.Point(104, 298)
        Me.ButtonGrabar.Name = "ButtonGrabar"
        Me.ButtonGrabar.Size = New System.Drawing.Size(78, 68)
        Me.ButtonGrabar.TabIndex = 265
        Me.ButtonGrabar.Tag = "25"
        Me.ButtonGrabar.Text = "Grabar"
        Me.ButtonGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonGrabar.UseVisualStyleBackColor = True
        '
        'ButtonBorrar
        '
        Me.ButtonBorrar.FlatAppearance.BorderSize = 0
        Me.ButtonBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBorrar.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonBorrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.ButtonBorrar.Image = Global.Remisiones.My.Resources.Resources.Eliminar42
        Me.ButtonBorrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonBorrar.Location = New System.Drawing.Point(212, 299)
        Me.ButtonBorrar.Name = "ButtonBorrar"
        Me.ButtonBorrar.Size = New System.Drawing.Size(75, 67)
        Me.ButtonBorrar.TabIndex = 266
        Me.ButtonBorrar.Tag = "29"
        Me.ButtonBorrar.Text = "Eliminar"
        Me.ButtonBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonBorrar.UseVisualStyleBackColor = True
        '
        'ButtonNuevo
        '
        Me.ButtonNuevo.FlatAppearance.BorderSize = 0
        Me.ButtonNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNuevo.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonNuevo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.ButtonNuevo.Image = Global.Remisiones.My.Resources.Resources.CirculoPlus481
        Me.ButtonNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonNuevo.Location = New System.Drawing.Point(9, 299)
        Me.ButtonNuevo.Name = "ButtonNuevo"
        Me.ButtonNuevo.Size = New System.Drawing.Size(75, 67)
        Me.ButtonNuevo.TabIndex = 264
        Me.ButtonNuevo.Text = "Nuevo"
        Me.ButtonNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonNuevo.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Button8.Image = Global.Remisiones.My.Resources.Resources.exit48
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button8.Location = New System.Drawing.Point(311, 298)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 66)
        Me.Button8.TabIndex = 267
        Me.Button8.Text = "Salir"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button8.UseVisualStyleBackColor = True
        '
        'C1Button2
        '
        Me.C1Button2.FlatAppearance.BorderSize = 0
        Me.C1Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.C1Button2.Image = Global.Remisiones.My.Resources.Resources.Lupa323
        Me.C1Button2.Location = New System.Drawing.Point(346, 61)
        Me.C1Button2.Name = "C1Button2"
        Me.C1Button2.Size = New System.Drawing.Size(32, 32)
        Me.C1Button2.TabIndex = 263
        Me.C1Button2.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.PictureBox2.Image = Global.Remisiones.My.Resources.Resources.Conductor100
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(63, 60)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 256
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(397, 60)
        Me.PictureBox1.TabIndex = 255
        Me.PictureBox1.TabStop = False
        '
        'FrmConductor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(397, 376)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TxtMotivo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CboLstaNegra)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtLicencia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtCedula)
        Me.Controls.Add(Me.CboActivo)
        Me.Controls.Add(Me.ButtonGrabar)
        Me.Controls.Add(Me.ButtonBorrar)
        Me.Controls.Add(Me.ButtonNuevo)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.C1Button2)
        Me.Controls.Add(Me.LblApellido)
        Me.Controls.Add(Me.CboCodigoConductor)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.LblCodigo)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmConductor"
        Me.Text = "Conductor"
        CType(Me.CboCodigoConductor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CboActivo As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonGrabar As System.Windows.Forms.Button
    Friend WithEvents ButtonBorrar As System.Windows.Forms.Button
    Friend WithEvents ButtonNuevo As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents C1Button2 As C1.Win.C1Input.C1Button
    Friend WithEvents LblApellido As System.Windows.Forms.Label
    Friend WithEvents CboCodigoConductor As C1.Win.C1List.C1Combo
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents LblCodigo As System.Windows.Forms.Label
    Friend WithEvents LblTitulo As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TxtCedula As System.Windows.Forms.TextBox
    Friend WithEvents TxtLicencia As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CboLstaNegra As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtMotivo As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
