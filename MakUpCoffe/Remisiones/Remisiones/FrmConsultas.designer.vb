<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultas
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultas))
        Me.Label9 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TrueDBGridConsultas = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.ButtonSalir = New System.Windows.Forms.Button
        Me.BtnPagar = New System.Windows.Forms.Button
        Me.BindingConsultas = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrueDBGridConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(205, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 18)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "CONSULTAS"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = Global.Remisiones.My.Resources.Resources.Opera_glasses_100
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(83, 71)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 31
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(491, 73)
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'TrueDBGridConsultas
        '
        Me.TrueDBGridConsultas.AllowUpdate = False
        Me.TrueDBGridConsultas.AlternatingRows = True
        Me.TrueDBGridConsultas.Caption = "CONSULTAS"
        Me.TrueDBGridConsultas.FilterBar = True
        Me.TrueDBGridConsultas.GroupByCaption = "Drag a column header here to group by that column"
        Me.TrueDBGridConsultas.Images.Add(CType(resources.GetObject("TrueDBGridConsultas.Images"), System.Drawing.Image))
        Me.TrueDBGridConsultas.Location = New System.Drawing.Point(12, 80)
        Me.TrueDBGridConsultas.Name = "TrueDBGridConsultas"
        Me.TrueDBGridConsultas.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.TrueDBGridConsultas.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.TrueDBGridConsultas.PreviewInfo.ZoomFactor = 75
        Me.TrueDBGridConsultas.PrintInfo.PageSettings = CType(resources.GetObject("TrueDBGridConsultas.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.TrueDBGridConsultas.Size = New System.Drawing.Size(471, 222)
        Me.TrueDBGridConsultas.TabIndex = 28
        Me.TrueDBGridConsultas.Text = "C1TrueDBGrid1"
        Me.TrueDBGridConsultas.PropBag = resources.GetString("TrueDBGridConsultas.PropBag")
        '
        'ButtonSalir
        '
        Me.ButtonSalir.FlatAppearance.BorderSize = 0
        Me.ButtonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSalir.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSalir.ForeColor = System.Drawing.Color.White
        Me.ButtonSalir.Image = Global.Remisiones.My.Resources.Resources.exit48
        Me.ButtonSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonSalir.Location = New System.Drawing.Point(400, 305)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(83, 69)
        Me.ButtonSalir.TabIndex = 27
        Me.ButtonSalir.Text = "Salir"
        Me.ButtonSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'BtnPagar
        '
        Me.BtnPagar.FlatAppearance.BorderSize = 0
        Me.BtnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPagar.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnPagar.ForeColor = System.Drawing.Color.White
        Me.BtnPagar.Image = Global.Remisiones.My.Resources.Resources.icons8paste_48
        Me.BtnPagar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnPagar.Location = New System.Drawing.Point(12, 308)
        Me.BtnPagar.Name = "BtnPagar"
        Me.BtnPagar.Size = New System.Drawing.Size(81, 69)
        Me.BtnPagar.TabIndex = 26
        Me.BtnPagar.Text = "Pegar"
        Me.BtnPagar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPagar.UseVisualStyleBackColor = True
        '
        'FrmConsultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(491, 386)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TrueDBGridConsultas)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.BtnPagar)
        Me.Name = "FrmConsultas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultas"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrueDBGridConsultas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingConsultas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonSalir As System.Windows.Forms.Button
    Protected WithEvents BtnPagar As System.Windows.Forms.Button
    Friend WithEvents TrueDBGridConsultas As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents BindingConsultas As System.Windows.Forms.BindingSource
End Class
