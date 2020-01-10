<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEntrada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEntrada))
        Me.CboUsuario = New C1.Win.C1List.C1Combo
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.cmdEntrar = New System.Windows.Forms.Button
        CType(Me.CboUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CboUsuario
        '
        Me.CboUsuario.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.CboUsuario.AlternatingRows = True
        Me.CboUsuario.Caption = ""
        Me.CboUsuario.CaptionHeight = 17
        Me.CboUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CboUsuario.ColumnCaptionHeight = 17
        Me.CboUsuario.ColumnFooterHeight = 17
        Me.CboUsuario.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.CboUsuario.ContentHeight = 15
        Me.CboUsuario.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.CboUsuario.DefColWidth = 179
        Me.CboUsuario.EditorBackColor = System.Drawing.SystemColors.Window
        Me.CboUsuario.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboUsuario.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.CboUsuario.EditorHeight = 15
        Me.CboUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboUsuario.Images.Add(CType(resources.GetObject("CboUsuario.Images"), System.Drawing.Image))
        Me.CboUsuario.ItemHeight = 15
        Me.CboUsuario.Location = New System.Drawing.Point(177, 106)
        Me.CboUsuario.MatchEntryTimeout = CType(2000, Long)
        Me.CboUsuario.MaxDropDownItems = CType(5, Short)
        Me.CboUsuario.MaxLength = 32767
        Me.CboUsuario.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CboUsuario.Name = "CboUsuario"
        Me.CboUsuario.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CboUsuario.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.CboUsuario.RowSubDividerColor = System.Drawing.Color.Black
        Me.CboUsuario.Size = New System.Drawing.Size(179, 21)
        Me.CboUsuario.TabIndex = 0
        Me.CboUsuario.VisualStyle = C1.Win.C1List.VisualStyle.System
        Me.CboUsuario.PropBag = resources.GetString("CboUsuario.PropBag")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(111, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(220, 20)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "INGRESO DE USUARIOS"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtPassword.Location = New System.Drawing.Point(177, 138)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9632)
        Me.txtPassword.Size = New System.Drawing.Size(179, 22)
        Me.txtPassword.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(47, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 16)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Contraseña :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(48, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Usuario       :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(405, 60)
        Me.Panel1.TabIndex = 31
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox2.Image = Global.Remisiones.My.Resources.Resources.Security01
        Me.PictureBox2.Location = New System.Drawing.Point(4, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(54, 58)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(405, 27)
        Me.Panel2.TabIndex = 32
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = Global.Remisiones.My.Resources.Resources.SALIR02
        Me.PictureBox1.Location = New System.Drawing.Point(374, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 27)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.Image = Global.Remisiones.My.Resources.Resources.Close02
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(288, 190)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 49)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Salir"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'cmdEntrar
        '
        Me.cmdEntrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmdEntrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdEntrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEntrar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdEntrar.Image = Global.Remisiones.My.Resources.Resources.llave021
        Me.cmdEntrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdEntrar.Location = New System.Drawing.Point(4, 190)
        Me.cmdEntrar.Name = "cmdEntrar"
        Me.cmdEntrar.Size = New System.Drawing.Size(115, 49)
        Me.cmdEntrar.TabIndex = 2
        Me.cmdEntrar.Text = "Aceptar"
        Me.cmdEntrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdEntrar.UseVisualStyleBackColor = False
        '
        'FrmEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(405, 241)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.CboUsuario)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cmdEntrar)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmEntrada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmEntrada"
        CType(Me.CboUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CboUsuario As C1.Win.C1List.C1Combo
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdEntrar As System.Windows.Forms.Button
End Class
