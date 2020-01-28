<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsuarios))
        Me.TxtNivel = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxtConfirmar = New System.Windows.Forms.TextBox
        Me.LblConfirmar = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CboUsuario = New C1.Win.C1List.C1Combo
        Me.ChkAdministrador = New System.Windows.Forms.CheckBox
        Me.ButtonBorrar = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.CmdGrabar = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.TxtContraseña = New System.Windows.Forms.TextBox
        CType(Me.CboUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtNivel
        '
        Me.TxtNivel.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.TxtNivel.FormattingEnabled = True
        Me.TxtNivel.Items.AddRange(New Object() {"Administrador", "Punto Control", "Entrada/Salida", "Planta"})
        Me.TxtNivel.Location = New System.Drawing.Point(144, 125)
        Me.TxtNivel.Name = "TxtNivel"
        Me.TxtNivel.Size = New System.Drawing.Size(203, 26)
        Me.TxtNivel.TabIndex = 84
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(96, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(244, 22)
        Me.Label9.TabIndex = 82
        Me.Label9.Text = "REGISTRO DE USUARIOS"
        '
        'TxtConfirmar
        '
        Me.TxtConfirmar.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.TxtConfirmar.Location = New System.Drawing.Point(144, 191)
        Me.TxtConfirmar.Name = "TxtConfirmar"
        Me.TxtConfirmar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9632)
        Me.TxtConfirmar.Size = New System.Drawing.Size(203, 26)
        Me.TxtConfirmar.TabIndex = 79
        Me.TxtConfirmar.Visible = False
        '
        'LblConfirmar
        '
        Me.LblConfirmar.AutoSize = True
        Me.LblConfirmar.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConfirmar.ForeColor = System.Drawing.Color.White
        Me.LblConfirmar.Location = New System.Drawing.Point(14, 196)
        Me.LblConfirmar.Name = "LblConfirmar"
        Me.LblConfirmar.Size = New System.Drawing.Size(70, 14)
        Me.LblConfirmar.TabIndex = 78
        Me.LblConfirmar.Text = "Confirmar"
        Me.LblConfirmar.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(14, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 14)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(14, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 14)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Nivel"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 14)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Nombre Usuario"
        '
        'CboUsuario
        '
        Me.CboUsuario.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.CboUsuario.Caption = ""
        Me.CboUsuario.CaptionHeight = 17
        Me.CboUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CboUsuario.ColumnCaptionHeight = 17
        Me.CboUsuario.ColumnFooterHeight = 17
        Me.CboUsuario.ContentHeight = 21
        Me.CboUsuario.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.CboUsuario.EditorBackColor = System.Drawing.SystemColors.Window
        Me.CboUsuario.EditorFont = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.CboUsuario.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.CboUsuario.EditorHeight = 21
        Me.CboUsuario.Images.Add(CType(resources.GetObject("CboUsuario.Images"), System.Drawing.Image))
        Me.CboUsuario.ItemHeight = 15
        Me.CboUsuario.Location = New System.Drawing.Point(145, 91)
        Me.CboUsuario.MatchEntryTimeout = CType(2000, Long)
        Me.CboUsuario.MaxDropDownItems = CType(5, Short)
        Me.CboUsuario.MaxLength = 32767
        Me.CboUsuario.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CboUsuario.Name = "CboUsuario"
        Me.CboUsuario.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CboUsuario.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.CboUsuario.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CboUsuario.Size = New System.Drawing.Size(202, 27)
        Me.CboUsuario.TabIndex = 85
        Me.CboUsuario.PropBag = resources.GetString("CboUsuario.PropBag")
        '
        'ChkAdministrador
        '
        Me.ChkAdministrador.AutoSize = True
        Me.ChkAdministrador.Location = New System.Drawing.Point(219, 351)
        Me.ChkAdministrador.Name = "ChkAdministrador"
        Me.ChkAdministrador.Size = New System.Drawing.Size(128, 17)
        Me.ChkAdministrador.TabIndex = 86
        Me.ChkAdministrador.Text = "Usuario Administrador"
        Me.ChkAdministrador.UseVisualStyleBackColor = True
        Me.ChkAdministrador.Visible = False
        '
        'ButtonBorrar
        '
        Me.ButtonBorrar.FlatAppearance.BorderSize = 0
        Me.ButtonBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBorrar.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBorrar.ForeColor = System.Drawing.Color.White
        Me.ButtonBorrar.Image = Global.Remisiones.My.Resources.Resources.Eliminar45
        Me.ButtonBorrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonBorrar.Location = New System.Drawing.Point(191, 248)
        Me.ButtonBorrar.Name = "ButtonBorrar"
        Me.ButtonBorrar.Size = New System.Drawing.Size(75, 67)
        Me.ButtonBorrar.TabIndex = 83
        Me.ButtonBorrar.Text = "Eliminar"
        Me.ButtonBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonBorrar.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = Global.Remisiones.My.Resources.Resources.icons8_user_account_100
        Me.PictureBox2.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(74, 73)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 81
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(361, 74)
        Me.PictureBox1.TabIndex = 80
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Global.Remisiones.My.Resources.Resources.exit48
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(278, 247)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 68)
        Me.Button2.TabIndex = 77
        Me.Button2.Text = "Cancelar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CmdGrabar
        '
        Me.CmdGrabar.FlatAppearance.BorderSize = 0
        Me.CmdGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdGrabar.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdGrabar.ForeColor = System.Drawing.Color.White
        Me.CmdGrabar.Image = Global.Remisiones.My.Resources.Resources.Save4811
        Me.CmdGrabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CmdGrabar.Location = New System.Drawing.Point(98, 247)
        Me.CmdGrabar.Name = "CmdGrabar"
        Me.CmdGrabar.Size = New System.Drawing.Size(78, 68)
        Me.CmdGrabar.TabIndex = 76
        Me.CmdGrabar.Text = "Grabar"
        Me.CmdGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdGrabar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.Remisiones.My.Resources.Resources.CirculoPlus481
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(14, 248)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 67)
        Me.Button1.TabIndex = 87
        Me.Button1.Text = "Nuevo"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtContraseña
        '
        Me.TxtContraseña.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.TxtContraseña.Location = New System.Drawing.Point(144, 158)
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9632)
        Me.TxtContraseña.Size = New System.Drawing.Size(203, 26)
        Me.TxtContraseña.TabIndex = 75
        '
        'FrmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(361, 333)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ChkAdministrador)
        Me.Controls.Add(Me.CboUsuario)
        Me.Controls.Add(Me.TxtNivel)
        Me.Controls.Add(Me.ButtonBorrar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TxtConfirmar)
        Me.Controls.Add(Me.LblConfirmar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CmdGrabar)
        Me.Controls.Add(Me.TxtContraseña)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmUsuarios"
        Me.Text = "Agregar usuarios"
        CType(Me.CboUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtNivel As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonBorrar As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TxtConfirmar As System.Windows.Forms.TextBox
    Friend WithEvents LblConfirmar As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CmdGrabar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboUsuario As C1.Win.C1List.C1Combo
    Friend WithEvents ChkAdministrador As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TxtContraseña As System.Windows.Forms.TextBox
End Class
