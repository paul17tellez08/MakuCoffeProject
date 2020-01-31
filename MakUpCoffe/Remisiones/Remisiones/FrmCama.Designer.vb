<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCama))
        Me.CheckActivo = New System.Windows.Forms.CheckBox
        Me.TxtNiveles = New System.Windows.Forms.TextBox
        Me.C1Button2 = New C1.Win.C1Input.C1Button
        Me.LblApellido = New System.Windows.Forms.Label
        Me.CboCodigoCama = New C1.Win.C1List.C1Combo
        Me.TxtCama = New System.Windows.Forms.TextBox
        Me.LblNombre = New System.Windows.Forms.Label
        Me.LblCodigo = New System.Windows.Forms.Label
        Me.LblTitulo = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ButtonGrabar = New System.Windows.Forms.Button
        Me.ButtonBorrar = New System.Windows.Forms.Button
        Me.ButtonNuevo = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        CType(Me.CboCodigoCama, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckActivo
        '
        Me.CheckActivo.AutoSize = True
        Me.CheckActivo.Checked = True
        Me.CheckActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckActivo.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.CheckActivo.ForeColor = System.Drawing.Color.White
        Me.CheckActivo.Location = New System.Drawing.Point(125, 179)
        Me.CheckActivo.Name = "CheckActivo"
        Me.CheckActivo.Size = New System.Drawing.Size(66, 19)
        Me.CheckActivo.TabIndex = 289
        Me.CheckActivo.Text = "Activo"
        Me.CheckActivo.UseVisualStyleBackColor = True
        '
        'TxtNiveles
        '
        Me.TxtNiveles.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.TxtNiveles.Location = New System.Drawing.Point(125, 144)
        Me.TxtNiveles.Name = "TxtNiveles"
        Me.TxtNiveles.Size = New System.Drawing.Size(224, 23)
        Me.TxtNiveles.TabIndex = 286
        '
        'C1Button2
        '
        Me.C1Button2.FlatAppearance.BorderSize = 0
        Me.C1Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.C1Button2.Image = Global.Remisiones.My.Resources.Resources.Lupa323
        Me.C1Button2.Location = New System.Drawing.Point(317, 78)
        Me.C1Button2.Name = "C1Button2"
        Me.C1Button2.Size = New System.Drawing.Size(30, 30)
        Me.C1Button2.TabIndex = 285
        Me.C1Button2.UseVisualStyleBackColor = True
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.LblApellido.ForeColor = System.Drawing.Color.White
        Me.LblApellido.Location = New System.Drawing.Point(14, 147)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(105, 15)
        Me.LblApellido.TabIndex = 284
        Me.LblApellido.Text = "Niveles            :"
        '
        'CboCodigoCama
        '
        Me.CboCodigoCama.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.CboCodigoCama.Caption = ""
        Me.CboCodigoCama.CaptionHeight = 17
        Me.CboCodigoCama.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CboCodigoCama.ColumnCaptionHeight = 17
        Me.CboCodigoCama.ColumnFooterHeight = 17
        Me.CboCodigoCama.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.CboCodigoCama.ContentHeight = 18
        Me.CboCodigoCama.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.CboCodigoCama.EditorBackColor = System.Drawing.SystemColors.Window
        Me.CboCodigoCama.EditorFont = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.CboCodigoCama.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.CboCodigoCama.EditorHeight = 18
        Me.CboCodigoCama.Images.Add(CType(resources.GetObject("CboCodigoCama.Images"), System.Drawing.Image))
        Me.CboCodigoCama.ItemHeight = 15
        Me.CboCodigoCama.Location = New System.Drawing.Point(125, 84)
        Me.CboCodigoCama.MatchEntryTimeout = CType(2000, Long)
        Me.CboCodigoCama.MaxDropDownItems = CType(5, Short)
        Me.CboCodigoCama.MaxLength = 32767
        Me.CboCodigoCama.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CboCodigoCama.Name = "CboCodigoCama"
        Me.CboCodigoCama.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CboCodigoCama.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.CboCodigoCama.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CboCodigoCama.Size = New System.Drawing.Size(183, 24)
        Me.CboCodigoCama.TabIndex = 280
        Me.CboCodigoCama.PropBag = resources.GetString("CboCodigoCama.PropBag")
        '
        'TxtCama
        '
        Me.TxtCama.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.TxtCama.Location = New System.Drawing.Point(125, 114)
        Me.TxtCama.Name = "TxtCama"
        Me.TxtCama.Size = New System.Drawing.Size(224, 23)
        Me.TxtCama.TabIndex = 281
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.LblNombre.ForeColor = System.Drawing.Color.White
        Me.LblNombre.Location = New System.Drawing.Point(15, 116)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(104, 15)
        Me.LblNombre.TabIndex = 283
        Me.LblNombre.Text = "Nombre Cama :"
        '
        'LblCodigo
        '
        Me.LblCodigo.AutoSize = True
        Me.LblCodigo.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.LblCodigo.ForeColor = System.Drawing.Color.White
        Me.LblCodigo.Location = New System.Drawing.Point(15, 86)
        Me.LblCodigo.Name = "LblCodigo"
        Me.LblCodigo.Size = New System.Drawing.Size(104, 15)
        Me.LblCodigo.TabIndex = 282
        Me.LblCodigo.Text = "Codigo            :"
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.BackColor = System.Drawing.Color.White
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.LblTitulo.Location = New System.Drawing.Point(131, 24)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(132, 13)
        Me.LblTitulo.TabIndex = 292
        Me.LblTitulo.Text = "CATALOGO DE CAMA"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = Global.Remisiones.My.Resources.Resources.icons8_driver_100
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(63, 60)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 291
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(363, 60)
        Me.PictureBox1.TabIndex = 290
        Me.PictureBox1.TabStop = False
        '
        'ButtonGrabar
        '
        Me.ButtonGrabar.FlatAppearance.BorderSize = 0
        Me.ButtonGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGrabar.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonGrabar.ForeColor = System.Drawing.Color.White
        Me.ButtonGrabar.Image = Global.Remisiones.My.Resources.Resources.Save4811
        Me.ButtonGrabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonGrabar.Location = New System.Drawing.Point(98, 209)
        Me.ButtonGrabar.Name = "ButtonGrabar"
        Me.ButtonGrabar.Size = New System.Drawing.Size(78, 68)
        Me.ButtonGrabar.TabIndex = 294
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
        Me.ButtonBorrar.ForeColor = System.Drawing.Color.White
        Me.ButtonBorrar.Image = Global.Remisiones.My.Resources.Resources.Eliminar42
        Me.ButtonBorrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonBorrar.Location = New System.Drawing.Point(193, 210)
        Me.ButtonBorrar.Name = "ButtonBorrar"
        Me.ButtonBorrar.Size = New System.Drawing.Size(75, 67)
        Me.ButtonBorrar.TabIndex = 295
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
        Me.ButtonNuevo.ForeColor = System.Drawing.Color.White
        Me.ButtonNuevo.Image = Global.Remisiones.My.Resources.Resources.CirculoPlus481
        Me.ButtonNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonNuevo.Location = New System.Drawing.Point(7, 210)
        Me.ButtonNuevo.Name = "ButtonNuevo"
        Me.ButtonNuevo.Size = New System.Drawing.Size(75, 67)
        Me.ButtonNuevo.TabIndex = 293
        Me.ButtonNuevo.Text = "Nuevo"
        Me.ButtonNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonNuevo.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Image = Global.Remisiones.My.Resources.Resources.exit48
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button8.Location = New System.Drawing.Point(284, 210)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 66)
        Me.Button8.TabIndex = 296
        Me.Button8.Text = "Salir"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button8.UseVisualStyleBackColor = True
        '
        'FrmCama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(363, 284)
        Me.Controls.Add(Me.ButtonGrabar)
        Me.Controls.Add(Me.ButtonBorrar)
        Me.Controls.Add(Me.ButtonNuevo)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CheckActivo)
        Me.Controls.Add(Me.TxtNiveles)
        Me.Controls.Add(Me.C1Button2)
        Me.Controls.Add(Me.LblApellido)
        Me.Controls.Add(Me.CboCodigoCama)
        Me.Controls.Add(Me.TxtCama)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.LblCodigo)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCama"
        Me.Text = "Cama"
        CType(Me.CboCodigoCama, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckActivo As System.Windows.Forms.CheckBox
    Friend WithEvents TxtNiveles As System.Windows.Forms.TextBox
    Friend WithEvents C1Button2 As C1.Win.C1Input.C1Button
    Friend WithEvents LblApellido As System.Windows.Forms.Label
    Friend WithEvents CboCodigoCama As C1.Win.C1List.C1Combo
    Friend WithEvents TxtCama As System.Windows.Forms.TextBox
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents LblCodigo As System.Windows.Forms.Label
    Friend WithEvents LblTitulo As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonGrabar As System.Windows.Forms.Button
    Friend WithEvents ButtonBorrar As System.Windows.Forms.Button
    Friend WithEvents ButtonNuevo As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
End Class
