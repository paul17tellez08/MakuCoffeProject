<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmComarMunici
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmComarMunici))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.CboMunicipio = New C1.Win.C1List.C1Combo
        Me.CboDepartamento = New C1.Win.C1List.C1Combo
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DgvComarcas = New System.Windows.Forms.DataGridView
        Me.BtnAbajo = New System.Windows.Forms.Button
        Me.BtnArriba = New System.Windows.Forms.Button
        Me.ButtonGuardar = New System.Windows.Forms.Button
        Me.CmdNuevo = New System.Windows.Forms.Button
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.BinListComarca = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnNuevaFila = New System.Windows.Forms.Button
        Me.BtnEliminarfila = New System.Windows.Forms.Button
        Me.CodComarca = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColComarca = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColActComarca = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.BtnEliminarMuni = New System.Windows.Forms.Button
        CType(Me.CboMunicipio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboDepartamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvComarcas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BinListComarca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CboMunicipio
        '
        Me.CboMunicipio.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.CboMunicipio.Caption = ""
        Me.CboMunicipio.CaptionHeight = 17
        Me.CboMunicipio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CboMunicipio.ColumnCaptionHeight = 17
        Me.CboMunicipio.ColumnFooterHeight = 17
        Me.CboMunicipio.ContentHeight = 21
        Me.CboMunicipio.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.CboMunicipio.DisplayMember = "Municipio"
        Me.CboMunicipio.EditorBackColor = System.Drawing.SystemColors.Window
        Me.CboMunicipio.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CboMunicipio.EditorForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CboMunicipio.EditorHeight = 21
        Me.CboMunicipio.Images.Add(CType(resources.GetObject("CboMunicipio.Images"), System.Drawing.Image))
        Me.CboMunicipio.ItemHeight = 25
        Me.CboMunicipio.KeepForeColor = True
        Me.CboMunicipio.Location = New System.Drawing.Point(224, 101)
        Me.CboMunicipio.MatchEntryTimeout = CType(2000, Long)
        Me.CboMunicipio.MaxDropDownItems = CType(5, Short)
        Me.CboMunicipio.MaxLength = 32767
        Me.CboMunicipio.MouseCursor = System.Windows.Forms.Cursors.Hand
        Me.CboMunicipio.Name = "CboMunicipio"
        Me.CboMunicipio.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CboMunicipio.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.CboMunicipio.RowSubDividerColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.CboMunicipio.Size = New System.Drawing.Size(182, 27)
        Me.CboMunicipio.TabIndex = 200
        Me.CboMunicipio.ValueMember = "IdMunicipio"
        Me.CboMunicipio.VisualStyle = C1.Win.C1List.VisualStyle.System
        Me.CboMunicipio.PropBag = resources.GetString("CboMunicipio.PropBag")
        '
        'CboDepartamento
        '
        Me.CboDepartamento.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.CboDepartamento.AlternatingRows = True
        Me.CboDepartamento.Caption = ""
        Me.CboDepartamento.CaptionHeight = 17
        Me.CboDepartamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CboDepartamento.ColumnCaptionHeight = 10
        Me.CboDepartamento.ColumnFooterHeight = 10
        Me.CboDepartamento.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.CboDepartamento.ContentHeight = 21
        Me.CboDepartamento.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.CboDepartamento.DisplayMember = "Departamento"
        Me.CboDepartamento.DropDownWidth = 182
        Me.CboDepartamento.EditorBackColor = System.Drawing.SystemColors.Window
        Me.CboDepartamento.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDepartamento.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.CboDepartamento.EditorHeight = 21
        Me.CboDepartamento.Images.Add(CType(resources.GetObject("CboDepartamento.Images"), System.Drawing.Image))
        Me.CboDepartamento.ItemHeight = 35
        Me.CboDepartamento.Location = New System.Drawing.Point(12, 101)
        Me.CboDepartamento.MatchEntryTimeout = CType(2000, Long)
        Me.CboDepartamento.MaxDropDownItems = CType(5, Short)
        Me.CboDepartamento.MaxLength = 32767
        Me.CboDepartamento.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CboDepartamento.Name = "CboDepartamento"
        Me.CboDepartamento.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CboDepartamento.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.CboDepartamento.RowSubDividerColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.CboDepartamento.Size = New System.Drawing.Size(182, 27)
        Me.CboDepartamento.TabIndex = 199
        Me.CboDepartamento.ValueMember = "IdDepartamento"
        Me.CboDepartamento.VisualStyle = C1.Win.C1List.VisualStyle.System
        Me.CboDepartamento.PropBag = resources.GetString("CboDepartamento.PropBag")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(221, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 15)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Nombre del Municipio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(9, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 15)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Departamento"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(101, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(353, 18)
        Me.Label9.TabIndex = 123
        Me.Label9.Text = "CATALOGOS DE MUNICIPIOS Y COMARCAS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(9, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 15)
        Me.Label1.TabIndex = 201
        Me.Label1.Text = "Comarcas del municipio de : "
        '
        'DgvComarcas
        '
        Me.DgvComarcas.AllowUserToAddRows = False
        Me.DgvComarcas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvComarcas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.DgvComarcas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvComarcas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvComarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvComarcas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodComarca, Me.ColComarca, Me.ColActComarca})
        Me.DgvComarcas.GridColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.DgvComarcas.Location = New System.Drawing.Point(12, 168)
        Me.DgvComarcas.Name = "DgvComarcas"
        Me.DgvComarcas.Size = New System.Drawing.Size(404, 216)
        Me.DgvComarcas.TabIndex = 0
        '
        'BtnAbajo
        '
        Me.BtnAbajo.FlatAppearance.BorderSize = 0
        Me.BtnAbajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAbajo.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.BtnAbajo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnAbajo.Image = Global.Remisiones.My.Resources.Resources.down
        Me.BtnAbajo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAbajo.Location = New System.Drawing.Point(422, 221)
        Me.BtnAbajo.Name = "BtnAbajo"
        Me.BtnAbajo.Size = New System.Drawing.Size(58, 53)
        Me.BtnAbajo.TabIndex = 203
        Me.BtnAbajo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAbajo.UseVisualStyleBackColor = True
        '
        'BtnArriba
        '
        Me.BtnArriba.FlatAppearance.BorderSize = 0
        Me.BtnArriba.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnArriba.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.BtnArriba.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnArriba.Image = Global.Remisiones.My.Resources.Resources.up
        Me.BtnArriba.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnArriba.Location = New System.Drawing.Point(422, 162)
        Me.BtnArriba.Name = "BtnArriba"
        Me.BtnArriba.Size = New System.Drawing.Size(58, 53)
        Me.BtnArriba.TabIndex = 202
        Me.BtnArriba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnArriba.UseVisualStyleBackColor = True
        '
        'ButtonGuardar
        '
        Me.ButtonGuardar.FlatAppearance.BorderSize = 0
        Me.ButtonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGuardar.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.ButtonGuardar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.ButtonGuardar.Image = Global.Remisiones.My.Resources.Resources.Save4811
        Me.ButtonGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonGuardar.Location = New System.Drawing.Point(104, 401)
        Me.ButtonGuardar.Name = "ButtonGuardar"
        Me.ButtonGuardar.Size = New System.Drawing.Size(75, 67)
        Me.ButtonGuardar.TabIndex = 126
        Me.ButtonGuardar.Text = "Guardar"
        Me.ButtonGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonGuardar.UseVisualStyleBackColor = True
        '
        'CmdNuevo
        '
        Me.CmdNuevo.FlatAppearance.BorderSize = 0
        Me.CmdNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdNuevo.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.CmdNuevo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.CmdNuevo.Image = Global.Remisiones.My.Resources.Resources.CirculoPlus48
        Me.CmdNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CmdNuevo.Location = New System.Drawing.Point(8, 401)
        Me.CmdNuevo.Name = "CmdNuevo"
        Me.CmdNuevo.Size = New System.Drawing.Size(75, 67)
        Me.CmdNuevo.TabIndex = 125
        Me.CmdNuevo.Text = "Nuevo"
        Me.CmdNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdNuevo.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.FlatAppearance.BorderSize = 0
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.BtnSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnSalir.Image = Global.Remisiones.My.Resources.Resources.exit48
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSalir.Location = New System.Drawing.Point(205, 401)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 66)
        Me.BtnSalir.TabIndex = 128
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.PictureBox2.Image = Global.Remisiones.My.Resources.Resources.Mundi
        Me.PictureBox2.Location = New System.Drawing.Point(9, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(71, 70)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 124
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(520, 71)
        Me.PictureBox1.TabIndex = 122
        Me.PictureBox1.TabStop = False
        '
        'BtnNuevaFila
        '
        Me.BtnNuevaFila.FlatAppearance.BorderSize = 0
        Me.BtnNuevaFila.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevaFila.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.BtnNuevaFila.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnNuevaFila.Image = Global.Remisiones.My.Resources.Resources.exit48
        Me.BtnNuevaFila.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnNuevaFila.Location = New System.Drawing.Point(422, 278)
        Me.BtnNuevaFila.Name = "BtnNuevaFila"
        Me.BtnNuevaFila.Size = New System.Drawing.Size(58, 53)
        Me.BtnNuevaFila.TabIndex = 204
        Me.BtnNuevaFila.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnNuevaFila.UseVisualStyleBackColor = True
        '
        'BtnEliminarfila
        '
        Me.BtnEliminarfila.FlatAppearance.BorderSize = 0
        Me.BtnEliminarfila.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminarfila.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.BtnEliminarfila.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnEliminarfila.Image = Global.Remisiones.My.Resources.Resources.Eliminar48
        Me.BtnEliminarfila.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnEliminarfila.Location = New System.Drawing.Point(422, 336)
        Me.BtnEliminarfila.Name = "BtnEliminarfila"
        Me.BtnEliminarfila.Size = New System.Drawing.Size(58, 53)
        Me.BtnEliminarfila.TabIndex = 205
        Me.BtnEliminarfila.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEliminarfila.UseVisualStyleBackColor = True
        '
        'CodComarca
        '
        Me.CodComarca.HeaderText = "Cod"
        Me.CodComarca.Name = "CodComarca"
        Me.CodComarca.ReadOnly = True
        Me.CodComarca.Width = 80
        '
        'ColComarca
        '
        Me.ColComarca.HeaderText = "Comarca"
        Me.ColComarca.Name = "ColComarca"
        Me.ColComarca.Width = 200
        '
        'ColActComarca
        '
        Me.ColActComarca.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ColActComarca.HeaderText = "Activa"
        Me.ColActComarca.Name = "ColActComarca"
        Me.ColActComarca.Width = 80
        '
        'BtnEliminarMuni
        '
        Me.BtnEliminarMuni.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminarMuni.Location = New System.Drawing.Point(422, 101)
        Me.BtnEliminarMuni.Name = "BtnEliminarMuni"
        Me.BtnEliminarMuni.Size = New System.Drawing.Size(58, 27)
        Me.BtnEliminarMuni.TabIndex = 206
        Me.BtnEliminarMuni.Text = "Eliminar Municipio"
        Me.BtnEliminarMuni.UseVisualStyleBackColor = True
        '
        'FrmComarMunici
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(520, 471)
        Me.Controls.Add(Me.BtnEliminarMuni)
        Me.Controls.Add(Me.BtnEliminarfila)
        Me.Controls.Add(Me.BtnNuevaFila)
        Me.Controls.Add(Me.BtnAbajo)
        Me.Controls.Add(Me.BtnArriba)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgvComarcas)
        Me.Controls.Add(Me.CboMunicipio)
        Me.Controls.Add(Me.CboDepartamento)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ButtonGuardar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmdNuevo)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmComarMunici"
        Me.Text = "Municipios Y Comarcas "
        CType(Me.CboMunicipio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboDepartamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvComarcas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BinListComarca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ButtonGuardar As System.Windows.Forms.Button
    Friend WithEvents CmdNuevo As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CboDepartamento As C1.Win.C1List.C1Combo
    Friend WithEvents BinListComarca As System.Windows.Forms.BindingSource
    Friend WithEvents CboMunicipio As C1.Win.C1List.C1Combo
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DgvComarcas As System.Windows.Forms.DataGridView
    Friend WithEvents BtnArriba As System.Windows.Forms.Button
    Friend WithEvents BtnAbajo As System.Windows.Forms.Button
    Friend WithEvents BtnNuevaFila As System.Windows.Forms.Button
    Friend WithEvents BtnEliminarfila As System.Windows.Forms.Button
    Friend WithEvents CodComarca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColComarca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColActComarca As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents BtnEliminarMuni As System.Windows.Forms.Button
End Class
