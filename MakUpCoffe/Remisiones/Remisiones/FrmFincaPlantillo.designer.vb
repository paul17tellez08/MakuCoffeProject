<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFincaPlantillo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFincaPlantillo))
        Me.BtnEliminarMuni = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.CboMunicipio = New C1.Win.C1List.C1Combo
        Me.CboDepartamento = New C1.Win.C1List.C1Combo
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Button1 = New System.Windows.Forms.Button
        Me.CboFinca = New C1.Win.C1List.C1Combo
        Me.Label19 = New System.Windows.Forms.Label
        Me.CboComarca = New C1.Win.C1List.C1Combo
        Me.CboProductor = New C1.Win.C1List.C1Combo
        Me.TxtNotasCata = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.TxtEmbalaje = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtAltitud = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.BtnAgregarProductor = New System.Windows.Forms.Button
        Me.BtnBuscar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.DgvPlantillos = New System.Windows.Forms.DataGridView
        Me.ColCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColPlantillo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BtnArriba = New System.Windows.Forms.Button
        Me.BtnAbajo = New System.Windows.Forms.Button
        Me.BtnEliminarfila = New System.Windows.Forms.Button
        Me.BtnNuevaFila = New System.Windows.Forms.Button
        Me.TxtCodfinca = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.CmdNuevo = New System.Windows.Forms.Button
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.ButtonGuardar = New System.Windows.Forms.Button
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.C1Combo3 = New C1.Win.C1List.C1Combo
        Me.Label14 = New System.Windows.Forms.Label
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.C1Combo4 = New C1.Win.C1List.C1Combo
        Me.C1Combo5 = New C1.Win.C1List.C1Combo
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        CType(Me.CboMunicipio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboDepartamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.CboFinca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboComarca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboProductor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DgvPlantillos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.C1Combo3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Combo4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Combo5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnEliminarMuni
        '
        Me.BtnEliminarMuni.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminarMuni.Location = New System.Drawing.Point(641, 208)
        Me.BtnEliminarMuni.Name = "BtnEliminarMuni"
        Me.BtnEliminarMuni.Size = New System.Drawing.Size(58, 27)
        Me.BtnEliminarMuni.TabIndex = 223
        Me.BtnEliminarMuni.Text = "Eliminar Municipio"
        Me.BtnEliminarMuni.UseVisualStyleBackColor = True
        Me.BtnEliminarMuni.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(577, 238)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 15)
        Me.Label1.TabIndex = 218
        Me.Label1.Text = "Comarcas del municipio de : "
        Me.Label1.Visible = False
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
        Me.CboMunicipio.Location = New System.Drawing.Point(575, 208)
        Me.CboMunicipio.MatchEntryTimeout = CType(2000, Long)
        Me.CboMunicipio.MaxDropDownItems = CType(5, Short)
        Me.CboMunicipio.MaxLength = 32767
        Me.CboMunicipio.MouseCursor = System.Windows.Forms.Cursors.Hand
        Me.CboMunicipio.Name = "CboMunicipio"
        Me.CboMunicipio.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CboMunicipio.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.CboMunicipio.RowSubDividerColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.CboMunicipio.Size = New System.Drawing.Size(85, 27)
        Me.CboMunicipio.TabIndex = 217
        Me.CboMunicipio.ValueMember = "IdMunicipio"
        Me.CboMunicipio.Visible = False
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
        Me.CboDepartamento.Location = New System.Drawing.Point(580, 313)
        Me.CboDepartamento.MatchEntryTimeout = CType(2000, Long)
        Me.CboDepartamento.MaxDropDownItems = CType(5, Short)
        Me.CboDepartamento.MaxLength = 32767
        Me.CboDepartamento.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CboDepartamento.Name = "CboDepartamento"
        Me.CboDepartamento.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CboDepartamento.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.CboDepartamento.RowSubDividerColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.CboDepartamento.Size = New System.Drawing.Size(78, 27)
        Me.CboDepartamento.TabIndex = 216
        Me.CboDepartamento.ValueMember = "IdDepartamento"
        Me.CboDepartamento.Visible = False
        Me.CboDepartamento.VisualStyle = C1.Win.C1List.VisualStyle.System
        Me.CboDepartamento.PropBag = resources.GetString("CboDepartamento.PropBag")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(572, 191)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 15)
        Me.Label8.TabIndex = 208
        Me.Label8.Text = "Nombre del Municipio"
        Me.Label8.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(577, 295)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 15)
        Me.Label2.TabIndex = 209
        Me.Label2.Text = "Departamento"
        Me.Label2.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(166, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(307, 18)
        Me.Label9.TabIndex = 211
        Me.Label9.Text = "CATALOGOS DE FINCAS Y PLATILLOS"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.TabControl1.Location = New System.Drawing.Point(0, 71)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(595, 284)
        Me.TabControl1.TabIndex = 224
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.CboFinca)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.CboComarca)
        Me.TabPage1.Controls.Add(Me.CboProductor)
        Me.TabPage1.Controls.Add(Me.TxtNotasCata)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.TxtEmbalaje)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.TxtAltitud)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.BtnAgregarProductor)
        Me.TabPage1.Controls.Add(Me.BtnBuscar)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.ForeColor = System.Drawing.Color.Black
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(587, 256)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Finca"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(376, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 23)
        Me.Button1.TabIndex = 221
        Me.Button1.Text = "Eliminar Finca"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CboFinca
        '
        Me.CboFinca.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.CboFinca.AllowDrop = True
        Me.CboFinca.AlternatingRows = True
        Me.CboFinca.Caption = ""
        Me.CboFinca.CaptionHeight = 17
        Me.CboFinca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CboFinca.ColumnCaptionHeight = 10
        Me.CboFinca.ColumnFooterHeight = 10
        Me.CboFinca.ContentHeight = 21
        Me.CboFinca.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.CboFinca.DisplayMember = "NomFinca"
        Me.CboFinca.DropDownWidth = 230
        Me.CboFinca.EditorBackColor = System.Drawing.SystemColors.Window
        Me.CboFinca.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboFinca.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.CboFinca.EditorHeight = 21
        Me.CboFinca.Images.Add(CType(resources.GetObject("CboFinca.Images"), System.Drawing.Image))
        Me.CboFinca.ItemHeight = 35
        Me.CboFinca.Location = New System.Drawing.Point(81, 24)
        Me.CboFinca.MatchEntryTimeout = CType(2000, Long)
        Me.CboFinca.MaxDropDownItems = CType(5, Short)
        Me.CboFinca.MaxLength = 32767
        Me.CboFinca.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CboFinca.Name = "CboFinca"
        Me.CboFinca.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CboFinca.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.CboFinca.RowSubDividerColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.CboFinca.Size = New System.Drawing.Size(230, 27)
        Me.CboFinca.TabIndex = 220
        Me.CboFinca.ValueMember = "IdFinca"
        Me.CboFinca.VisualStyle = C1.Win.C1List.VisualStyle.System
        Me.CboFinca.PropBag = resources.GetString("CboFinca.PropBag")
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(3, 29)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(76, 15)
        Me.Label19.TabIndex = 219
        Me.Label19.Text = "Finca        :"
        '
        'CboComarca
        '
        Me.CboComarca.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.CboComarca.Caption = ""
        Me.CboComarca.CaptionHeight = 17
        Me.CboComarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CboComarca.ColumnCaptionHeight = 17
        Me.CboComarca.ColumnFooterHeight = 17
        Me.CboComarca.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.CboComarca.ContentHeight = 17
        Me.CboComarca.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.CboComarca.DisplayMember = "Comarca"
        Me.CboComarca.EditorBackColor = System.Drawing.SystemColors.Window
        Me.CboComarca.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboComarca.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.CboComarca.EditorHeight = 17
        Me.CboComarca.Images.Add(CType(resources.GetObject("CboComarca.Images"), System.Drawing.Image))
        Me.CboComarca.ItemHeight = 15
        Me.CboComarca.Location = New System.Drawing.Point(81, 122)
        Me.CboComarca.MatchEntryTimeout = CType(2000, Long)
        Me.CboComarca.MaxDropDownItems = CType(5, Short)
        Me.CboComarca.MaxLength = 32767
        Me.CboComarca.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CboComarca.Name = "CboComarca"
        Me.CboComarca.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CboComarca.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.CboComarca.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CboComarca.Size = New System.Drawing.Size(230, 23)
        Me.CboComarca.TabIndex = 217
        Me.CboComarca.ValueMember = "IdComarca"
        Me.CboComarca.PropBag = resources.GetString("CboComarca.PropBag")
        '
        'CboProductor
        '
        Me.CboProductor.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.CboProductor.AlternatingRows = True
        Me.CboProductor.Caption = ""
        Me.CboProductor.CaptionHeight = 17
        Me.CboProductor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CboProductor.ColumnCaptionHeight = 10
        Me.CboProductor.ColumnFooterHeight = 10
        Me.CboProductor.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.CboProductor.ContentHeight = 21
        Me.CboProductor.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.CboProductor.DisplayMember = "Nombre"
        Me.CboProductor.DropDownWidth = 182
        Me.CboProductor.EditorBackColor = System.Drawing.SystemColors.Window
        Me.CboProductor.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboProductor.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.CboProductor.EditorHeight = 21
        Me.CboProductor.Images.Add(CType(resources.GetObject("CboProductor.Images"), System.Drawing.Image))
        Me.CboProductor.ItemHeight = 35
        Me.CboProductor.Location = New System.Drawing.Point(81, 73)
        Me.CboProductor.MatchEntryTimeout = CType(2000, Long)
        Me.CboProductor.MaxDropDownItems = CType(5, Short)
        Me.CboProductor.MaxLength = 32767
        Me.CboProductor.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CboProductor.Name = "CboProductor"
        Me.CboProductor.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CboProductor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.CboProductor.RowSubDividerColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.CboProductor.Size = New System.Drawing.Size(230, 27)
        Me.CboProductor.TabIndex = 216
        Me.CboProductor.ValueMember = "IdProductor"
        Me.CboProductor.VisualStyle = C1.Win.C1List.VisualStyle.System
        Me.CboProductor.PropBag = resources.GetString("CboProductor.PropBag")
        '
        'TxtNotasCata
        '
        Me.TxtNotasCata.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.TxtNotasCata.Location = New System.Drawing.Point(376, 94)
        Me.TxtNotasCata.Multiline = True
        Me.TxtNotasCata.Name = "TxtNotasCata"
        Me.TxtNotasCata.Size = New System.Drawing.Size(205, 139)
        Me.TxtNotasCata.TabIndex = 137
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(377, 72)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(103, 15)
        Me.Label18.TabIndex = 136
        Me.Label18.Text = "Notas de Cata :"
        '
        'TxtEmbalaje
        '
        Me.TxtEmbalaje.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.TxtEmbalaje.Location = New System.Drawing.Point(81, 209)
        Me.TxtEmbalaje.Name = "TxtEmbalaje"
        Me.TxtEmbalaje.Size = New System.Drawing.Size(230, 23)
        Me.TxtEmbalaje.TabIndex = 131
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(6, 213)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 15)
        Me.Label10.TabIndex = 130
        Me.Label10.Text = "Embalaje  :"
        '
        'TxtAltitud
        '
        Me.TxtAltitud.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.TxtAltitud.Location = New System.Drawing.Point(81, 166)
        Me.TxtAltitud.Name = "TxtAltitud"
        Me.TxtAltitud.Size = New System.Drawing.Size(230, 23)
        Me.TxtAltitud.TabIndex = 129
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(3, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 15)
        Me.Label7.TabIndex = 128
        Me.Label7.Text = "Altitud      :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(2, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 15)
        Me.Label6.TabIndex = 126
        Me.Label6.Text = "Comarca   :"
        '
        'BtnAgregarProductor
        '
        Me.BtnAgregarProductor.FlatAppearance.BorderSize = 0
        Me.BtnAgregarProductor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregarProductor.Image = Global.Remisiones.My.Resources.Resources.CirculoPlus48
        Me.BtnAgregarProductor.Location = New System.Drawing.Point(317, 70)
        Me.BtnAgregarProductor.Name = "BtnAgregarProductor"
        Me.BtnAgregarProductor.Size = New System.Drawing.Size(32, 32)
        Me.BtnAgregarProductor.TabIndex = 125
        Me.BtnAgregarProductor.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.FlatAppearance.BorderSize = 0
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BtnBuscar.Image = Global.Remisiones.My.Resources.Resources.Lupa32
        Me.BtnBuscar.Location = New System.Drawing.Point(317, 22)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(32, 32)
        Me.BtnBuscar.TabIndex = 119
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(2, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Productor :"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.DgvPlantillos)
        Me.TabPage2.Controls.Add(Me.Panel3)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(587, 256)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Plantillos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DgvPlantillos
        '
        Me.DgvPlantillos.AllowUserToAddRows = False
        Me.DgvPlantillos.AllowUserToDeleteRows = False
        Me.DgvPlantillos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.DgvPlantillos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPlantillos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColCodigo, Me.ColPlantillo})
        Me.DgvPlantillos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvPlantillos.Location = New System.Drawing.Point(3, 33)
        Me.DgvPlantillos.Name = "DgvPlantillos"
        Me.DgvPlantillos.Size = New System.Drawing.Size(525, 220)
        Me.DgvPlantillos.TabIndex = 227
        '
        'ColCodigo
        '
        Me.ColCodigo.HeaderText = "Codigo"
        Me.ColCodigo.Name = "ColCodigo"
        Me.ColCodigo.Width = 60
        '
        'ColPlantillo
        '
        Me.ColPlantillo.HeaderText = "Plantillo"
        Me.ColPlantillo.Name = "ColPlantillo"
        Me.ColPlantillo.Width = 210
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(525, 30)
        Me.Panel3.TabIndex = 226
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(5, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(144, 15)
        Me.Label11.TabIndex = 224
        Me.Label11.Text = "Plantillos de la Finca :"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnArriba)
        Me.Panel1.Controls.Add(Me.BtnAbajo)
        Me.Panel1.Controls.Add(Me.BtnEliminarfila)
        Me.Panel1.Controls.Add(Me.BtnNuevaFila)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(528, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(56, 250)
        Me.Panel1.TabIndex = 225
        '
        'BtnArriba
        '
        Me.BtnArriba.FlatAppearance.BorderSize = 0
        Me.BtnArriba.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnArriba.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.BtnArriba.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnArriba.Image = Global.Remisiones.My.Resources.Resources.up
        Me.BtnArriba.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnArriba.Location = New System.Drawing.Point(3, 10)
        Me.BtnArriba.Name = "BtnArriba"
        Me.BtnArriba.Size = New System.Drawing.Size(58, 53)
        Me.BtnArriba.TabIndex = 219
        Me.BtnArriba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnArriba.UseVisualStyleBackColor = True
        '
        'BtnAbajo
        '
        Me.BtnAbajo.FlatAppearance.BorderSize = 0
        Me.BtnAbajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAbajo.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.BtnAbajo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnAbajo.Image = Global.Remisiones.My.Resources.Resources.down
        Me.BtnAbajo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAbajo.Location = New System.Drawing.Point(3, 71)
        Me.BtnAbajo.Name = "BtnAbajo"
        Me.BtnAbajo.Size = New System.Drawing.Size(58, 53)
        Me.BtnAbajo.TabIndex = 220
        Me.BtnAbajo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAbajo.UseVisualStyleBackColor = True
        '
        'BtnEliminarfila
        '
        Me.BtnEliminarfila.FlatAppearance.BorderSize = 0
        Me.BtnEliminarfila.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminarfila.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.BtnEliminarfila.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnEliminarfila.Image = Global.Remisiones.My.Resources.Resources.Eliminar48
        Me.BtnEliminarfila.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnEliminarfila.Location = New System.Drawing.Point(3, 193)
        Me.BtnEliminarfila.Name = "BtnEliminarfila"
        Me.BtnEliminarfila.Size = New System.Drawing.Size(58, 53)
        Me.BtnEliminarfila.TabIndex = 222
        Me.BtnEliminarfila.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEliminarfila.UseVisualStyleBackColor = True
        '
        'BtnNuevaFila
        '
        Me.BtnNuevaFila.FlatAppearance.BorderSize = 0
        Me.BtnNuevaFila.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevaFila.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.BtnNuevaFila.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnNuevaFila.Image = Global.Remisiones.My.Resources.Resources.exit48
        Me.BtnNuevaFila.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnNuevaFila.Location = New System.Drawing.Point(3, 132)
        Me.BtnNuevaFila.Name = "BtnNuevaFila"
        Me.BtnNuevaFila.Size = New System.Drawing.Size(58, 53)
        Me.BtnNuevaFila.TabIndex = 221
        Me.BtnNuevaFila.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnNuevaFila.UseVisualStyleBackColor = True
        '
        'TxtCodfinca
        '
        Me.TxtCodfinca.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.TxtCodfinca.Location = New System.Drawing.Point(575, 40)
        Me.TxtCodfinca.Name = "TxtCodfinca"
        Me.TxtCodfinca.Size = New System.Drawing.Size(13, 23)
        Me.TxtCodfinca.TabIndex = 138
        Me.TxtCodfinca.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(496, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 15)
        Me.Label4.TabIndex = 120
        Me.Label4.Text = "Código     :"
        Me.Label4.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CmdNuevo)
        Me.Panel2.Controls.Add(Me.BtnSalir)
        Me.Panel2.Controls.Add(Me.ButtonGuardar)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.TxtCodfinca)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 355)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(595, 68)
        Me.Panel2.TabIndex = 225
        '
        'CmdNuevo
        '
        Me.CmdNuevo.FlatAppearance.BorderSize = 0
        Me.CmdNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdNuevo.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.CmdNuevo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.CmdNuevo.Image = Global.Remisiones.My.Resources.Resources.CirculoPlus48
        Me.CmdNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CmdNuevo.Location = New System.Drawing.Point(3, 0)
        Me.CmdNuevo.Name = "CmdNuevo"
        Me.CmdNuevo.Size = New System.Drawing.Size(75, 67)
        Me.CmdNuevo.TabIndex = 213
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
        Me.BtnSalir.Location = New System.Drawing.Point(200, 0)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 66)
        Me.BtnSalir.TabIndex = 215
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'ButtonGuardar
        '
        Me.ButtonGuardar.FlatAppearance.BorderSize = 0
        Me.ButtonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGuardar.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.ButtonGuardar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.ButtonGuardar.Image = Global.Remisiones.My.Resources.Resources.Save4811
        Me.ButtonGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonGuardar.Location = New System.Drawing.Point(102, 0)
        Me.ButtonGuardar.Name = "ButtonGuardar"
        Me.ButtonGuardar.Size = New System.Drawing.Size(75, 67)
        Me.ButtonGuardar.TabIndex = 214
        Me.ButtonGuardar.Text = "Guardar"
        Me.ButtonGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonGuardar.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.TextBox4.Location = New System.Drawing.Point(81, 206)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(230, 23)
        Me.TextBox4.TabIndex = 131
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(6, 210)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 15)
        Me.Label12.TabIndex = 130
        Me.Label12.Text = "Embalaje :"
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.TextBox5.Location = New System.Drawing.Point(81, 170)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(230, 23)
        Me.TextBox5.TabIndex = 129
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(3, 173)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 15)
        Me.Label13.TabIndex = 128
        Me.Label13.Text = "Altitud :"
        '
        'C1Combo3
        '
        Me.C1Combo3.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.C1Combo3.Caption = ""
        Me.C1Combo3.CaptionHeight = 17
        Me.C1Combo3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.C1Combo3.ColumnCaptionHeight = 17
        Me.C1Combo3.ColumnFooterHeight = 17
        Me.C1Combo3.ContentHeight = 15
        Me.C1Combo3.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1Combo3.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.C1Combo3.DropDownWidth = 400
        Me.C1Combo3.EditorBackColor = System.Drawing.SystemColors.Window
        Me.C1Combo3.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1Combo3.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.C1Combo3.EditorHeight = 15
        Me.C1Combo3.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.C1Combo3.Images.Add(CType(resources.GetObject("C1Combo3.Images"), System.Drawing.Image))
        Me.C1Combo3.ItemHeight = 15
        Me.C1Combo3.Location = New System.Drawing.Point(81, 135)
        Me.C1Combo3.MatchEntryTimeout = CType(2000, Long)
        Me.C1Combo3.MaxDropDownItems = CType(5, Short)
        Me.C1Combo3.MaxLength = 32767
        Me.C1Combo3.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.C1Combo3.Name = "C1Combo3"
        Me.C1Combo3.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1Combo3.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.C1Combo3.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1Combo3.Size = New System.Drawing.Size(230, 21)
        Me.C1Combo3.TabIndex = 127
        Me.C1Combo3.PropBag = resources.GetString("C1Combo3.PropBag")
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(2, 138)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 15)
        Me.Label14.TabIndex = 126
        Me.Label14.Text = "Comarca :"
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.TextBox6.Location = New System.Drawing.Point(81, 58)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(230, 23)
        Me.TextBox6.TabIndex = 124
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(3, 61)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 15)
        Me.Label15.TabIndex = 123
        Me.Label15.Text = "Finca :"
        '
        'C1Combo4
        '
        Me.C1Combo4.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.C1Combo4.Caption = ""
        Me.C1Combo4.CaptionHeight = 17
        Me.C1Combo4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.C1Combo4.ColumnCaptionHeight = 17
        Me.C1Combo4.ColumnFooterHeight = 17
        Me.C1Combo4.ContentHeight = 15
        Me.C1Combo4.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1Combo4.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.C1Combo4.DropDownWidth = 400
        Me.C1Combo4.EditorBackColor = System.Drawing.SystemColors.Window
        Me.C1Combo4.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1Combo4.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.C1Combo4.EditorHeight = 15
        Me.C1Combo4.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.C1Combo4.Images.Add(CType(resources.GetObject("C1Combo4.Images"), System.Drawing.Image))
        Me.C1Combo4.ItemHeight = 15
        Me.C1Combo4.Location = New System.Drawing.Point(81, 97)
        Me.C1Combo4.MatchEntryTimeout = CType(2000, Long)
        Me.C1Combo4.MaxDropDownItems = CType(5, Short)
        Me.C1Combo4.MaxLength = 32767
        Me.C1Combo4.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.C1Combo4.Name = "C1Combo4"
        Me.C1Combo4.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1Combo4.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.C1Combo4.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1Combo4.Size = New System.Drawing.Size(206, 21)
        Me.C1Combo4.TabIndex = 122
        Me.C1Combo4.PropBag = resources.GetString("C1Combo4.PropBag")
        '
        'C1Combo5
        '
        Me.C1Combo5.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.C1Combo5.Caption = ""
        Me.C1Combo5.CaptionHeight = 17
        Me.C1Combo5.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.C1Combo5.ColumnCaptionHeight = 17
        Me.C1Combo5.ColumnFooterHeight = 17
        Me.C1Combo5.ContentHeight = 15
        Me.C1Combo5.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1Combo5.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.C1Combo5.DropDownWidth = 400
        Me.C1Combo5.EditorBackColor = System.Drawing.SystemColors.Window
        Me.C1Combo5.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1Combo5.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.C1Combo5.EditorHeight = 15
        Me.C1Combo5.Images.Add(CType(resources.GetObject("C1Combo5.Images"), System.Drawing.Image))
        Me.C1Combo5.ItemHeight = 15
        Me.C1Combo5.Location = New System.Drawing.Point(5, 21)
        Me.C1Combo5.MatchEntryTimeout = CType(2000, Long)
        Me.C1Combo5.MaxDropDownItems = CType(5, Short)
        Me.C1Combo5.MaxLength = 32767
        Me.C1Combo5.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.C1Combo5.Name = "C1Combo5"
        Me.C1Combo5.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1Combo5.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.C1Combo5.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1Combo5.Size = New System.Drawing.Size(179, 21)
        Me.C1Combo5.TabIndex = 118
        Me.C1Combo5.PropBag = resources.GetString("C1Combo5.PropBag")
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(3, 3)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(106, 15)
        Me.Label16.TabIndex = 120
        Me.Label16.Text = "Código de finca"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(2, 100)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(76, 15)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Productor :"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.PictureBox2.Image = Global.Remisiones.My.Resources.Resources.Mundi
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(71, 70)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 212
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(595, 71)
        Me.PictureBox1.TabIndex = 210
        Me.PictureBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.Remisiones.My.Resources.Resources.CirculoPlus48
        Me.Button3.Location = New System.Drawing.Point(289, 90)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(32, 32)
        Me.Button3.TabIndex = 125
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = Global.Remisiones.My.Resources.Resources.Teclado32
        Me.Button4.Location = New System.Drawing.Point(192, 16)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(32, 32)
        Me.Button4.TabIndex = 121
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Image = Global.Remisiones.My.Resources.Resources.Lupa32
        Me.Button5.Location = New System.Drawing.Point(230, 16)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(32, 32)
        Me.Button5.TabIndex = 119
        Me.Button5.UseVisualStyleBackColor = True
        '
        'FrmFincaPlantillo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(595, 423)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BtnEliminarMuni)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CboMunicipio)
        Me.Controls.Add(Me.CboDepartamento)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FrmFincaPlantillo"
        Me.Text = "FrmFincaPlantillo"
        CType(Me.CboMunicipio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboDepartamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.CboFinca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboComarca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboProductor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DgvPlantillos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.C1Combo3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Combo4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Combo5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnEliminarMuni As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboMunicipio As C1.Win.C1List.C1Combo
    Friend WithEvents CboDepartamento As C1.Win.C1List.C1Combo
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ButtonGuardar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmdNuevo As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnAgregarProductor As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtAltitud As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtEmbalaje As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents C1Combo3 As C1.Win.C1List.C1Combo
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents C1Combo4 As C1.Win.C1List.C1Combo
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents C1Combo5 As C1.Win.C1List.C1Combo
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TxtNotasCata As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TxtCodfinca As System.Windows.Forms.TextBox
    Friend WithEvents CboProductor As C1.Win.C1List.C1Combo
    Friend WithEvents CboComarca As C1.Win.C1List.C1Combo
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnArriba As System.Windows.Forms.Button
    Friend WithEvents BtnAbajo As System.Windows.Forms.Button
    Friend WithEvents BtnEliminarfila As System.Windows.Forms.Button
    Friend WithEvents BtnNuevaFila As System.Windows.Forms.Button
    Friend WithEvents DgvPlantillos As System.Windows.Forms.DataGridView
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ColCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColPlantillo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CboFinca As C1.Win.C1List.C1Combo
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
