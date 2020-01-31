<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRecepcion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRecepcion))
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ChkTaraSaco = New System.Windows.Forms.CheckBox
        Me.lbldatosre = New System.Windows.Forms.Label
        Me.DTPFecha = New System.Windows.Forms.Label
        Me.LblHora = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Button13 = New System.Windows.Forms.Button
        Me.BtnAgreProductor = New System.Windows.Forms.Button
        Me.BtnAgrePlantillo = New System.Windows.Forms.Button
        Me.CboFinca = New C1.Win.C1List.C1Combo
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.CboPlantillo = New C1.Win.C1List.C1Combo
        Me.TxtCodProductor = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.CboRecibimosde = New C1.Win.C1List.C1Combo
        Me.Label21 = New System.Windows.Forms.Label
        Me.CboProductor = New C1.Win.C1List.C1Combo
        Me.TxtCedulaProductor = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.BtnAgreFinca = New System.Windows.Forms.Button
        Me.TxtRemision = New System.Windows.Forms.TextBox
        Me.lblproveedor = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.TxtRConacafe = New System.Windows.Forms.TextBox
        Me.lblnombre = New System.Windows.Forms.Label
        Me.datosprov = New System.Windows.Forms.Label
        Me.BtnBuscarCodProv = New System.Windows.Forms.GroupBox
        Me.lblbdega = New System.Windows.Forms.Label
        Me.CmbSerie = New C1.Win.C1List.C1Combo
        Me.BtnBuscarRecep = New System.Windows.Forms.Button
        Me.TxtNumeroEnsamble = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.LblEstado = New System.Windows.Forms.Label
        Me.CboTipoPesada = New System.Windows.Forms.ComboBox
        Me.CboTipoRecepcion = New System.Windows.Forms.ComboBox
        Me.lbltipo = New System.Windows.Forms.Label
        Me.LblSucursal = New System.Windows.Forms.Label
        Me.txtsubtotal = New System.Windows.Forms.TextBox
        Me.sp = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtobservaciones = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TxtColor = New System.Windows.Forms.TextBox
        Me.TxtModelo = New System.Windows.Forms.TextBox
        Me.BtnAgreConductor = New System.Windows.Forms.Button
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.BtnVehiculoAgre = New System.Windows.Forms.Button
        Me.BtnBusConductor = New System.Windows.Forms.Button
        Me.BtnBusPlaca = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtMarca = New System.Windows.Forms.TextBox
        Me.CboPlaca = New C1.Win.C1List.C1Combo
        Me.Label34 = New System.Windows.Forms.Label
        Me.TxtCedulaConductor = New System.Windows.Forms.TextBox
        Me.CboConductor = New C1.Win.C1List.C1Combo
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Button6 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CboEstado = New System.Windows.Forms.ComboBox
        Me.CboCalidad = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.CboVariedad = New C1.Win.C1List.C1Combo
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxtHumedad = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtImperfec = New System.Windows.Forms.TextBox
        Me.CboCodigoBodega = New C1.Win.C1List.C1Combo
        Me.BtnPesada = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.BtnEnviarPatio = New System.Windows.Forms.Button
        Me.BtnNuevoRec = New System.Windows.Forms.Button
        Me.BtnTikectRec = New System.Windows.Forms.Button
        Me.BtnGuardarRec = New System.Windows.Forms.Button
        Me.BtnRecpSalir = New System.Windows.Forms.Button
        Me.BtnDisconectRec = New System.Windows.Forms.Button
        Me.BtnImpriRec = New System.Windows.Forms.Button
        Me.BtnConectarRec = New System.Windows.Forms.Button
        Me.CheckMohoso = New System.Windows.Forms.CheckBox
        Me.CheckFermento = New System.Windows.Forms.CheckBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.TDGImperfeccion = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.TrueDBDetalleNP = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.BindingDetalle = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingImperfeccion = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox6.SuspendLayout()
        CType(Me.CboFinca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboPlantillo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboRecibimosde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboProductor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BtnBuscarCodProv.SuspendLayout()
        CType(Me.CmbSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CboPlaca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboConductor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CboVariedad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboCodigoBodega, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.TDGImperfeccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrueDBDetalleNP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingImperfeccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(4, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 15)
        Me.Label7.TabIndex = 248
        Me.Label7.Text = "Variedad Café   :  "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(4, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 15)
        Me.Label6.TabIndex = 182
        Me.Label6.Text = "Calidad             :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(358, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Bodega   :"
        '
        'ChkTaraSaco
        '
        Me.ChkTaraSaco.AutoSize = True
        Me.ChkTaraSaco.Checked = True
        Me.ChkTaraSaco.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkTaraSaco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ChkTaraSaco.ForeColor = System.Drawing.Color.White
        Me.ChkTaraSaco.Location = New System.Drawing.Point(1000, 160)
        Me.ChkTaraSaco.Name = "ChkTaraSaco"
        Me.ChkTaraSaco.Size = New System.Drawing.Size(162, 24)
        Me.ChkTaraSaco.TabIndex = 239
        Me.ChkTaraSaco.Text = "Calcular Tara Saco"
        Me.ChkTaraSaco.UseVisualStyleBackColor = True
        Me.ChkTaraSaco.Visible = False
        '
        'lbldatosre
        '
        Me.lbldatosre.AutoSize = True
        Me.lbldatosre.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldatosre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.lbldatosre.Location = New System.Drawing.Point(22, 4)
        Me.lbldatosre.Name = "lbldatosre"
        Me.lbldatosre.Size = New System.Drawing.Size(154, 15)
        Me.lbldatosre.TabIndex = 176
        Me.lbldatosre.Text = "DATOS DE RECEPCIÓN"
        '
        'DTPFecha
        '
        Me.DTPFecha.AutoSize = True
        Me.DTPFecha.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.DTPFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.DTPFecha.Location = New System.Drawing.Point(7, 23)
        Me.DTPFecha.Name = "DTPFecha"
        Me.DTPFecha.Size = New System.Drawing.Size(83, 15)
        Me.DTPFecha.TabIndex = 182
        Me.DTPFecha.Text = "20/10/2017"
        '
        'LblHora
        '
        Me.LblHora.AutoSize = True
        Me.LblHora.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.LblHora.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.LblHora.Location = New System.Drawing.Point(106, 23)
        Me.LblHora.Name = "LblHora"
        Me.LblHora.Size = New System.Drawing.Size(94, 15)
        Me.LblHora.TabIndex = 181
        Me.LblHora.Text = "10:23:55 p.m."
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.GroupBox6.Controls.Add(Me.Button13)
        Me.GroupBox6.Controls.Add(Me.BtnAgreProductor)
        Me.GroupBox6.Controls.Add(Me.BtnAgrePlantillo)
        Me.GroupBox6.Controls.Add(Me.CboFinca)
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.CboPlantillo)
        Me.GroupBox6.Controls.Add(Me.TxtCodProductor)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.CboRecibimosde)
        Me.GroupBox6.Controls.Add(Me.Label21)
        Me.GroupBox6.Controls.Add(Me.CboProductor)
        Me.GroupBox6.Controls.Add(Me.TxtCedulaProductor)
        Me.GroupBox6.Controls.Add(Me.Label20)
        Me.GroupBox6.Controls.Add(Me.BtnAgreFinca)
        Me.GroupBox6.Controls.Add(Me.TxtRemision)
        Me.GroupBox6.Controls.Add(Me.lblproveedor)
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.Controls.Add(Me.TxtRConacafe)
        Me.GroupBox6.Controls.Add(Me.lblnombre)
        Me.GroupBox6.Controls.Add(Me.datosprov)
        Me.GroupBox6.Location = New System.Drawing.Point(3, 343)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(805, 132)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        '
        'Button13
        '
        Me.Button13.FlatAppearance.BorderSize = 0
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Image = Global.Remisiones.My.Resources.Resources.Lupa321
        Me.Button13.Location = New System.Drawing.Point(421, 44)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(32, 30)
        Me.Button13.TabIndex = 5
        Me.Button13.UseVisualStyleBackColor = True
        '
        'BtnAgreProductor
        '
        Me.BtnAgreProductor.FlatAppearance.BorderSize = 0
        Me.BtnAgreProductor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgreProductor.Image = Global.Remisiones.My.Resources.Resources.icons8_plus_36
        Me.BtnAgreProductor.Location = New System.Drawing.Point(421, 11)
        Me.BtnAgreProductor.Name = "BtnAgreProductor"
        Me.BtnAgreProductor.Size = New System.Drawing.Size(32, 30)
        Me.BtnAgreProductor.TabIndex = 4
        Me.BtnAgreProductor.UseVisualStyleBackColor = True
        '
        'BtnAgrePlantillo
        '
        Me.BtnAgrePlantillo.Enabled = False
        Me.BtnAgrePlantillo.FlatAppearance.BorderSize = 0
        Me.BtnAgrePlantillo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgrePlantillo.Image = Global.Remisiones.My.Resources.Resources.icons8_plus_36
        Me.BtnAgrePlantillo.Location = New System.Drawing.Point(762, 96)
        Me.BtnAgrePlantillo.Name = "BtnAgrePlantillo"
        Me.BtnAgrePlantillo.Size = New System.Drawing.Size(32, 30)
        Me.BtnAgrePlantillo.TabIndex = 11
        Me.BtnAgrePlantillo.UseVisualStyleBackColor = True
        Me.BtnAgrePlantillo.Visible = False
        '
        'CboFinca
        '
        Me.CboFinca.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.CboFinca.Caption = ""
        Me.CboFinca.CaptionHeight = 17
        Me.CboFinca.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CboFinca.ColumnCaptionHeight = 17
        Me.CboFinca.ColumnFooterHeight = 17
        Me.CboFinca.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.CboFinca.ContentHeight = 18
        Me.CboFinca.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.CboFinca.DisplayMember = "NomFinca"
        Me.CboFinca.EditorBackColor = System.Drawing.SystemColors.Window
        Me.CboFinca.EditorFont = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.CboFinca.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.CboFinca.EditorHeight = 18
        Me.CboFinca.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.CboFinca.Images.Add(CType(resources.GetObject("CboFinca.Images"), System.Drawing.Image))
        Me.CboFinca.ItemHeight = 15
        Me.CboFinca.Location = New System.Drawing.Point(566, 72)
        Me.CboFinca.MatchEntryTimeout = CType(2000, Long)
        Me.CboFinca.MaxDropDownItems = CType(5, Short)
        Me.CboFinca.MaxLength = 32767
        Me.CboFinca.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CboFinca.Name = "CboFinca"
        Me.CboFinca.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CboFinca.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.CboFinca.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CboFinca.Size = New System.Drawing.Size(190, 24)
        Me.CboFinca.TabIndex = 8
        Me.CboFinca.ValueMember = "IdFinca"
        Me.CboFinca.PropBag = resources.GetString("CboFinca.PropBag")
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(4, 110)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(104, 15)
        Me.Label19.TabIndex = 264
        Me.Label19.Text = "Recibimos de  :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(466, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 15)
        Me.Label11.TabIndex = 187
        Me.Label11.Text = "Finca            :"
        '
        'CboPlantillo
        '
        Me.CboPlantillo.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.CboPlantillo.Caption = ""
        Me.CboPlantillo.CaptionHeight = 17
        Me.CboPlantillo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CboPlantillo.ColumnCaptionHeight = 17
        Me.CboPlantillo.ColumnFooterHeight = 17
        Me.CboPlantillo.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.CboPlantillo.ContentHeight = 18
        Me.CboPlantillo.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.CboPlantillo.DisplayMember = "Plantillo"
        Me.CboPlantillo.EditorBackColor = System.Drawing.SystemColors.Window
        Me.CboPlantillo.EditorFont = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.CboPlantillo.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.CboPlantillo.EditorHeight = 18
        Me.CboPlantillo.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.CboPlantillo.Images.Add(CType(resources.GetObject("CboPlantillo.Images"), System.Drawing.Image))
        Me.CboPlantillo.ItemHeight = 15
        Me.CboPlantillo.Location = New System.Drawing.Point(566, 101)
        Me.CboPlantillo.MatchEntryTimeout = CType(2000, Long)
        Me.CboPlantillo.MaxDropDownItems = CType(5, Short)
        Me.CboPlantillo.MaxLength = 32767
        Me.CboPlantillo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CboPlantillo.Name = "CboPlantillo"
        Me.CboPlantillo.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CboPlantillo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.CboPlantillo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CboPlantillo.Size = New System.Drawing.Size(190, 24)
        Me.CboPlantillo.TabIndex = 9
        Me.CboPlantillo.ValueMember = "IdPlantillo"
        Me.CboPlantillo.PropBag = resources.GetString("CboPlantillo.PropBag")
        '
        'TxtCodProductor
        '
        Me.TxtCodProductor.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodProductor.Location = New System.Drawing.Point(115, 47)
        Me.TxtCodProductor.Name = "TxtCodProductor"
        Me.TxtCodProductor.ReadOnly = True
        Me.TxtCodProductor.Size = New System.Drawing.Size(300, 23)
        Me.TxtCodProductor.TabIndex = 1
        Me.TxtCodProductor.Text = " "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(466, 106)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 15)
        Me.Label12.TabIndex = 190
        Me.Label12.Text = "Plantillo       :"
        '
        'CboRecibimosde
        '
        Me.CboRecibimosde.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.CboRecibimosde.AlternatingRows = True
        Me.CboRecibimosde.Caption = ""
        Me.CboRecibimosde.CaptionHeight = 17
        Me.CboRecibimosde.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CboRecibimosde.ColumnCaptionHeight = 17
        Me.CboRecibimosde.ColumnFooterHeight = 17
        Me.CboRecibimosde.ContentHeight = 18
        Me.CboRecibimosde.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.CboRecibimosde.DisplayMember = "RecibimosDe"
        Me.CboRecibimosde.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.CboRecibimosde.DropDownWidth = 185
        Me.CboRecibimosde.EditorBackColor = System.Drawing.SystemColors.Window
        Me.CboRecibimosde.EditorFont = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.CboRecibimosde.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.CboRecibimosde.EditorHeight = 18
        Me.CboRecibimosde.Images.Add(CType(resources.GetObject("CboRecibimosde.Images"), System.Drawing.Image))
        Me.CboRecibimosde.ItemHeight = 35
        Me.CboRecibimosde.Location = New System.Drawing.Point(115, 103)
        Me.CboRecibimosde.MatchEntryTimeout = CType(2000, Long)
        Me.CboRecibimosde.MaxDropDownItems = CType(5, Short)
        Me.CboRecibimosde.MaximumSize = New System.Drawing.Size(300, 100)
        Me.CboRecibimosde.MaxLength = 32767
        Me.CboRecibimosde.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CboRecibimosde.Name = "CboRecibimosde"
        Me.CboRecibimosde.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CboRecibimosde.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.CboRecibimosde.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CboRecibimosde.Size = New System.Drawing.Size(300, 24)
        Me.CboRecibimosde.TabIndex = 3
        Me.CboRecibimosde.PropBag = resources.GetString("CboRecibimosde.PropBag")
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(5, 81)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(102, 15)
        Me.Label21.TabIndex = 272
        Me.Label21.Text = "Cedula            :"
        '
        'CboProductor
        '
        Me.CboProductor.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.CboProductor.AlternatingRows = True
        Me.CboProductor.Caption = ""
        Me.CboProductor.CaptionHeight = 17
        Me.CboProductor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CboProductor.ColumnCaptionHeight = 17
        Me.CboProductor.ColumnFooterHeight = 17
        Me.CboProductor.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.CboProductor.ContentHeight = 18
        Me.CboProductor.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.CboProductor.DisplayMember = "Nombre"
        Me.CboProductor.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.CboProductor.DropDownWidth = 185
        Me.CboProductor.EditorBackColor = System.Drawing.SystemColors.Window
        Me.CboProductor.EditorFont = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.CboProductor.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.CboProductor.EditorHeight = 18
        Me.CboProductor.Images.Add(CType(resources.GetObject("CboProductor.Images"), System.Drawing.Image))
        Me.CboProductor.ItemHeight = 35
        Me.CboProductor.Location = New System.Drawing.Point(115, 17)
        Me.CboProductor.MatchEntryTimeout = CType(2000, Long)
        Me.CboProductor.MaxDropDownItems = CType(5, Short)
        Me.CboProductor.MaximumSize = New System.Drawing.Size(300, 100)
        Me.CboProductor.MaxLength = 32767
        Me.CboProductor.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CboProductor.Name = "CboProductor"
        Me.CboProductor.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CboProductor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.CboProductor.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CboProductor.Size = New System.Drawing.Size(300, 24)
        Me.CboProductor.TabIndex = 0
        Me.CboProductor.ValueMember = "Cod_Proveedor"
        Me.CboProductor.PropBag = resources.GetString("CboProductor.PropBag")
        '
        'TxtCedulaProductor
        '
        Me.TxtCedulaProductor.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCedulaProductor.Location = New System.Drawing.Point(115, 75)
        Me.TxtCedulaProductor.Name = "TxtCedulaProductor"
        Me.TxtCedulaProductor.ReadOnly = True
        Me.TxtCedulaProductor.Size = New System.Drawing.Size(300, 23)
        Me.TxtCedulaProductor.TabIndex = 2
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(5, 22)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(105, 15)
        Me.Label20.TabIndex = 270
        Me.Label20.Text = "Por Cuenta de :"
        '
        'BtnAgreFinca
        '
        Me.BtnAgreFinca.FlatAppearance.BorderSize = 0
        Me.BtnAgreFinca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgreFinca.Image = Global.Remisiones.My.Resources.Resources.icons8_plus_36
        Me.BtnAgreFinca.Location = New System.Drawing.Point(762, 66)
        Me.BtnAgreFinca.Name = "BtnAgreFinca"
        Me.BtnAgreFinca.Size = New System.Drawing.Size(30, 30)
        Me.BtnAgreFinca.TabIndex = 10
        Me.BtnAgreFinca.UseVisualStyleBackColor = True
        '
        'TxtRemision
        '
        Me.TxtRemision.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.TxtRemision.Location = New System.Drawing.Point(566, 17)
        Me.TxtRemision.Name = "TxtRemision"
        Me.TxtRemision.Size = New System.Drawing.Size(190, 23)
        Me.TxtRemision.TabIndex = 6
        '
        'lblproveedor
        '
        Me.lblproveedor.AutoSize = True
        Me.lblproveedor.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.lblproveedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.lblproveedor.Location = New System.Drawing.Point(6, 49)
        Me.lblproveedor.Name = "lblproveedor"
        Me.lblproveedor.Size = New System.Drawing.Size(105, 15)
        Me.lblproveedor.TabIndex = 2
        Me.lblproveedor.Text = "Código           : "
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(463, 20)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(95, 15)
        Me.Label18.TabIndex = 268
        Me.Label18.Text = "Remision No :"
        '
        'TxtRConacafe
        '
        Me.TxtRConacafe.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.TxtRConacafe.Location = New System.Drawing.Point(566, 45)
        Me.TxtRConacafe.Name = "TxtRConacafe"
        Me.TxtRConacafe.Size = New System.Drawing.Size(190, 23)
        Me.TxtRConacafe.TabIndex = 7
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.lblnombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.lblnombre.Location = New System.Drawing.Point(464, 47)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(95, 15)
        Me.lblnombre.TabIndex = 174
        Me.lblnombre.Text = "R. Conacafe  :"
        '
        'datosprov
        '
        Me.datosprov.AutoSize = True
        Me.datosprov.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.datosprov.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.datosprov.Location = New System.Drawing.Point(5, 1)
        Me.datosprov.Name = "datosprov"
        Me.datosprov.Size = New System.Drawing.Size(157, 15)
        Me.datosprov.TabIndex = 25
        Me.datosprov.Text = "INFORMACIÓN GENERAL"
        '
        'BtnBuscarCodProv
        '
        Me.BtnBuscarCodProv.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BtnBuscarCodProv.Controls.Add(Me.lblbdega)
        Me.BtnBuscarCodProv.Controls.Add(Me.CmbSerie)
        Me.BtnBuscarCodProv.Controls.Add(Me.BtnBuscarRecep)
        Me.BtnBuscarCodProv.Controls.Add(Me.TxtNumeroEnsamble)
        Me.BtnBuscarCodProv.Controls.Add(Me.Label15)
        Me.BtnBuscarCodProv.Controls.Add(Me.LblEstado)
        Me.BtnBuscarCodProv.Controls.Add(Me.CboTipoPesada)
        Me.BtnBuscarCodProv.Location = New System.Drawing.Point(216, -2)
        Me.BtnBuscarCodProv.Name = "BtnBuscarCodProv"
        Me.BtnBuscarCodProv.Size = New System.Drawing.Size(775, 42)
        Me.BtnBuscarCodProv.TabIndex = 0
        Me.BtnBuscarCodProv.TabStop = False
        '
        'lblbdega
        '
        Me.lblbdega.AutoSize = True
        Me.lblbdega.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.lblbdega.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.lblbdega.Location = New System.Drawing.Point(307, 16)
        Me.lblbdega.Name = "lblbdega"
        Me.lblbdega.Size = New System.Drawing.Size(93, 15)
        Me.lblbdega.TabIndex = 6
        Me.lblbdega.Text = "Nota Peso # :"
        '
        'CmbSerie
        '
        Me.CmbSerie.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.CmbSerie.Caption = ""
        Me.CmbSerie.CaptionHeight = 17
        Me.CmbSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CmbSerie.ColumnCaptionHeight = 17
        Me.CmbSerie.ColumnFooterHeight = 17
        Me.CmbSerie.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.CmbSerie.ContentHeight = 15
        Me.CmbSerie.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.CmbSerie.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.CmbSerie.DropDownWidth = 100
        Me.CmbSerie.EditorBackColor = System.Drawing.SystemColors.Window
        Me.CmbSerie.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSerie.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.CmbSerie.EditorHeight = 15
        Me.CmbSerie.Images.Add(CType(resources.GetObject("CmbSerie.Images"), System.Drawing.Image))
        Me.CmbSerie.ItemHeight = 15
        Me.CmbSerie.Location = New System.Drawing.Point(410, 13)
        Me.CmbSerie.MatchEntryTimeout = CType(2000, Long)
        Me.CmbSerie.MaxDropDownItems = CType(5, Short)
        Me.CmbSerie.MaxLength = 32767
        Me.CmbSerie.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CmbSerie.Name = "CmbSerie"
        Me.CmbSerie.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CmbSerie.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.CmbSerie.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CmbSerie.Size = New System.Drawing.Size(53, 21)
        Me.CmbSerie.TabIndex = 3
        Me.CmbSerie.Visible = False
        Me.CmbSerie.PropBag = resources.GetString("CmbSerie.PropBag")
        '
        'BtnBuscarRecep
        '
        Me.BtnBuscarRecep.FlatAppearance.BorderSize = 0
        Me.BtnBuscarRecep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscarRecep.Image = Global.Remisiones.My.Resources.Resources.Lupa321
        Me.BtnBuscarRecep.Location = New System.Drawing.Point(588, 8)
        Me.BtnBuscarRecep.Name = "BtnBuscarRecep"
        Me.BtnBuscarRecep.Size = New System.Drawing.Size(36, 30)
        Me.BtnBuscarRecep.TabIndex = 5
        Me.BtnBuscarRecep.UseVisualStyleBackColor = True
        '
        'TxtNumeroEnsamble
        '
        Me.TxtNumeroEnsamble.Enabled = False
        Me.TxtNumeroEnsamble.Location = New System.Drawing.Point(474, 14)
        Me.TxtNumeroEnsamble.Name = "TxtNumeroEnsamble"
        Me.TxtNumeroEnsamble.Size = New System.Drawing.Size(103, 20)
        Me.TxtNumeroEnsamble.TabIndex = 4
        Me.TxtNumeroEnsamble.Text = "- - - - - 0 - - - - -"
        Me.TxtNumeroEnsamble.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(7, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(111, 15)
        Me.Label15.TabIndex = 265
        Me.Label15.Text = "Tipo de pesada :"
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstado.ForeColor = System.Drawing.Color.BlanchedAlmond
        Me.LblEstado.Location = New System.Drawing.Point(650, 16)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(118, 15)
        Me.LblEstado.TabIndex = 238
        Me.LblEstado.Text = "DESCONECTADO"
        '
        'CboTipoPesada
        '
        Me.CboTipoPesada.BackColor = System.Drawing.Color.White
        Me.CboTipoPesada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoPesada.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.CboTipoPesada.FormattingEnabled = True
        Me.CboTipoPesada.Items.AddRange(New Object() {"PESADA BASCULA", "PESADA MANUAL"})
        Me.CboTipoPesada.Location = New System.Drawing.Point(120, 11)
        Me.CboTipoPesada.Name = "CboTipoPesada"
        Me.CboTipoPesada.Size = New System.Drawing.Size(171, 23)
        Me.CboTipoPesada.TabIndex = 1
        '
        'CboTipoRecepcion
        '
        Me.CboTipoRecepcion.BackColor = System.Drawing.Color.White
        Me.CboTipoRecepcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoRecepcion.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboTipoRecepcion.FormattingEnabled = True
        Me.CboTipoRecepcion.Items.AddRange(New Object() {"RECEPCION", "SALIDA BASCULA", "REPESAJE"})
        Me.CboTipoRecepcion.Location = New System.Drawing.Point(1094, 131)
        Me.CboTipoRecepcion.Name = "CboTipoRecepcion"
        Me.CboTipoRecepcion.Size = New System.Drawing.Size(10, 23)
        Me.CboTipoRecepcion.TabIndex = 239
        Me.CboTipoRecepcion.Visible = False
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.lbltipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.lbltipo.Location = New System.Drawing.Point(997, 134)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(94, 15)
        Me.lbltipo.TabIndex = 25
        Me.lbltipo.Text = "Tipo Ingreso :"
        Me.lbltipo.Visible = False
        '
        'LblSucursal
        '
        Me.LblSucursal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblSucursal.AutoSize = True
        Me.LblSucursal.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.LblSucursal.ForeColor = System.Drawing.Color.White
        Me.LblSucursal.Location = New System.Drawing.Point(51, -105)
        Me.LblSucursal.Name = "LblSucursal"
        Me.LblSucursal.Size = New System.Drawing.Size(181, 15)
        Me.LblSucursal.TabIndex = 185
        Me.LblSucursal.Text = "RECEPCION DE PRODUCTOS"
        '
        'txtsubtotal
        '
        Me.txtsubtotal.BackColor = System.Drawing.Color.White
        Me.txtsubtotal.Enabled = False
        Me.txtsubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsubtotal.Location = New System.Drawing.Point(828, 10)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.Size = New System.Drawing.Size(155, 26)
        Me.txtsubtotal.TabIndex = 226
        Me.txtsubtotal.Text = "0.00"
        '
        'sp
        '
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'txtobservaciones
        '
        Me.txtobservaciones.BackColor = System.Drawing.Color.White
        Me.txtobservaciones.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.txtobservaciones.Location = New System.Drawing.Point(121, 103)
        Me.txtobservaciones.Multiline = True
        Me.txtobservaciones.Name = "txtobservaciones"
        Me.txtobservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtobservaciones.Size = New System.Drawing.Size(521, 24)
        Me.txtobservaciones.TabIndex = 183
        Me.txtobservaciones.Text = " "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(4, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 15)
        Me.Label1.TabIndex = 184
        Me.Label1.Text = "Observación      :"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.TxtColor)
        Me.GroupBox2.Controls.Add(Me.TxtModelo)
        Me.GroupBox2.Controls.Add(Me.BtnAgreConductor)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.BtnVehiculoAgre)
        Me.GroupBox2.Controls.Add(Me.BtnBusConductor)
        Me.GroupBox2.Controls.Add(Me.BtnBusPlaca)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TxtMarca)
        Me.GroupBox2.Controls.Add(Me.CboPlaca)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.Controls.Add(Me.TxtCedulaConductor)
        Me.GroupBox2.Controls.Add(Me.CboConductor)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 268)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(988, 77)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'TxtColor
        '
        Me.TxtColor.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.TxtColor.Location = New System.Drawing.Point(428, 46)
        Me.TxtColor.Name = "TxtColor"
        Me.TxtColor.ReadOnly = True
        Me.TxtColor.Size = New System.Drawing.Size(174, 23)
        Me.TxtColor.TabIndex = 6
        '
        'TxtModelo
        '
        Me.TxtModelo.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.TxtModelo.Location = New System.Drawing.Point(428, 16)
        Me.TxtModelo.Name = "TxtModelo"
        Me.TxtModelo.ReadOnly = True
        Me.TxtModelo.Size = New System.Drawing.Size(174, 23)
        Me.TxtModelo.TabIndex = 5
        '
        'BtnAgreConductor
        '
        Me.BtnAgreConductor.FlatAppearance.BorderSize = 0
        Me.BtnAgreConductor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgreConductor.Image = Global.Remisiones.My.Resources.Resources.icons8_plus_36
        Me.BtnAgreConductor.Location = New System.Drawing.Point(913, 12)
        Me.BtnAgreConductor.Name = "BtnAgreConductor"
        Me.BtnAgreConductor.Size = New System.Drawing.Size(32, 30)
        Me.BtnAgreConductor.TabIndex = 9
        Me.BtnAgreConductor.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(366, 51)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(50, 15)
        Me.Label17.TabIndex = 262
        Me.Label17.Text = "Color :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(362, 23)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 15)
        Me.Label16.TabIndex = 260
        Me.Label16.Text = "Modelo :"
        '
        'BtnVehiculoAgre
        '
        Me.BtnVehiculoAgre.FlatAppearance.BorderSize = 0
        Me.BtnVehiculoAgre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVehiculoAgre.Image = Global.Remisiones.My.Resources.Resources.icons8_plus_36
        Me.BtnVehiculoAgre.Location = New System.Drawing.Point(283, 12)
        Me.BtnVehiculoAgre.Name = "BtnVehiculoAgre"
        Me.BtnVehiculoAgre.Size = New System.Drawing.Size(32, 30)
        Me.BtnVehiculoAgre.TabIndex = 3
        Me.BtnVehiculoAgre.UseVisualStyleBackColor = True
        '
        'BtnBusConductor
        '
        Me.BtnBusConductor.FlatAppearance.BorderSize = 0
        Me.BtnBusConductor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBusConductor.Image = Global.Remisiones.My.Resources.Resources.Lupa321
        Me.BtnBusConductor.Location = New System.Drawing.Point(949, 13)
        Me.BtnBusConductor.Name = "BtnBusConductor"
        Me.BtnBusConductor.Size = New System.Drawing.Size(36, 30)
        Me.BtnBusConductor.TabIndex = 10
        Me.BtnBusConductor.UseVisualStyleBackColor = True
        '
        'BtnBusPlaca
        '
        Me.BtnBusPlaca.FlatAppearance.BorderSize = 0
        Me.BtnBusPlaca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBusPlaca.Image = Global.Remisiones.My.Resources.Resources.Lupa321
        Me.BtnBusPlaca.Location = New System.Drawing.Point(321, 12)
        Me.BtnBusPlaca.Name = "BtnBusPlaca"
        Me.BtnBusPlaca.Size = New System.Drawing.Size(32, 30)
        Me.BtnBusPlaca.TabIndex = 4
        Me.BtnBusPlaca.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(11, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 15)
        Me.Label8.TabIndex = 246
        Me.Label8.Text = "DATOS DEL VEHICULO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(6, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 15)
        Me.Label5.TabIndex = 248
        Me.Label5.Text = "Marca        :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(6, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 15)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Placa         :"
        '
        'TxtMarca
        '
        Me.TxtMarca.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.TxtMarca.Location = New System.Drawing.Point(103, 46)
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.ReadOnly = True
        Me.TxtMarca.Size = New System.Drawing.Size(174, 23)
        Me.TxtMarca.TabIndex = 2
        '
        'CboPlaca
        '
        Me.CboPlaca.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.CboPlaca.Caption = ""
        Me.CboPlaca.CaptionHeight = 17
        Me.CboPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CboPlaca.ColumnCaptionHeight = 17
        Me.CboPlaca.ColumnFooterHeight = 17
        Me.CboPlaca.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.CboPlaca.ContentHeight = 18
        Me.CboPlaca.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.CboPlaca.DisplayMember = "Placa"
        Me.CboPlaca.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.CboPlaca.DropDownWidth = 185
        Me.CboPlaca.EditorBackColor = System.Drawing.SystemColors.Window
        Me.CboPlaca.EditorFont = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.CboPlaca.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.CboPlaca.EditorHeight = 18
        Me.CboPlaca.Images.Add(CType(resources.GetObject("CboPlaca.Images"), System.Drawing.Image))
        Me.CboPlaca.ItemHeight = 35
        Me.CboPlaca.Location = New System.Drawing.Point(103, 17)
        Me.CboPlaca.MatchEntryTimeout = CType(2000, Long)
        Me.CboPlaca.MaxDropDownItems = CType(5, Short)
        Me.CboPlaca.MaximumSize = New System.Drawing.Size(300, 100)
        Me.CboPlaca.MaxLength = 32767
        Me.CboPlaca.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CboPlaca.Name = "CboPlaca"
        Me.CboPlaca.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CboPlaca.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.CboPlaca.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CboPlaca.Size = New System.Drawing.Size(174, 24)
        Me.CboPlaca.TabIndex = 1
        Me.CboPlaca.ValueMember = "IdVehiculo"
        Me.CboPlaca.PropBag = resources.GetString("CboPlaca.PropBag")
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label34.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label34.Location = New System.Drawing.Point(610, 52)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(82, 15)
        Me.Label34.TabIndex = 242
        Me.Label34.Text = "Cedula       :"
        '
        'TxtCedulaConductor
        '
        Me.TxtCedulaConductor.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.TxtCedulaConductor.Location = New System.Drawing.Point(693, 44)
        Me.TxtCedulaConductor.Name = "TxtCedulaConductor"
        Me.TxtCedulaConductor.ReadOnly = True
        Me.TxtCedulaConductor.Size = New System.Drawing.Size(216, 26)
        Me.TxtCedulaConductor.TabIndex = 8
        '
        'CboConductor
        '
        Me.CboConductor.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.CboConductor.AlternatingRows = True
        Me.CboConductor.Caption = ""
        Me.CboConductor.CaptionHeight = 17
        Me.CboConductor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CboConductor.ColumnCaptionHeight = 17
        Me.CboConductor.ColumnFooterHeight = 17
        Me.CboConductor.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.CboConductor.ContentHeight = 18
        Me.CboConductor.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.CboConductor.DisplayMember = "Nombre"
        Me.CboConductor.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.CboConductor.DropDownWidth = 275
        Me.CboConductor.EditorBackColor = System.Drawing.SystemColors.Window
        Me.CboConductor.EditorFont = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.CboConductor.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.CboConductor.EditorHeight = 18
        Me.CboConductor.Images.Add(CType(resources.GetObject("CboConductor.Images"), System.Drawing.Image))
        Me.CboConductor.ItemHeight = 35
        Me.CboConductor.Location = New System.Drawing.Point(693, 16)
        Me.CboConductor.MatchEntryTimeout = CType(2000, Long)
        Me.CboConductor.MaxDropDownItems = CType(5, Short)
        Me.CboConductor.MaxLength = 32767
        Me.CboConductor.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CboConductor.Name = "CboConductor"
        Me.CboConductor.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CboConductor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.CboConductor.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CboConductor.Size = New System.Drawing.Size(216, 24)
        Me.CboConductor.TabIndex = 7
        Me.CboConductor.ValueMember = "Codigo"
        Me.CboConductor.PropBag = resources.GetString("CboConductor.PropBag")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(608, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 15)
        Me.Label4.TabIndex = 239
        Me.Label4.Text = "Conductor :"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.lbldatosre)
        Me.GroupBox3.Controls.Add(Me.DTPFecha)
        Me.GroupBox3.Controls.Add(Me.LblHora)
        Me.GroupBox3.Location = New System.Drawing.Point(3, -2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(207, 42)
        Me.GroupBox3.TabIndex = 222
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Button6)
        Me.GroupBox4.Controls.Add(Me.txtsubtotal)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 227)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(988, 42)
        Me.GroupBox4.TabIndex = 224
        Me.GroupBox4.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(700, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(122, 15)
        Me.Label14.TabIndex = 267
        Me.Label14.Text = "PESO NETO (APO) :"
        '
        'Button6
        '
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Button6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Button6.Image = Global.Remisiones.My.Resources.Resources.BorrarFila28
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(6, 9)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(140, 30)
        Me.Button6.TabIndex = 227
        Me.Button6.Text = "ELIMINAR FILA"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.CboEstado)
        Me.GroupBox1.Controls.Add(Me.CboCalidad)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.CboVariedad)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TxtHumedad)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TxtImperfec)
        Me.GroupBox1.Controls.Add(Me.CboCodigoBodega)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.LblSucursal)
        Me.GroupBox1.Controls.Add(Me.BtnPesada)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtobservaciones)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 474)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(805, 133)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'CboEstado
        '
        Me.CboEstado.BackColor = System.Drawing.Color.White
        Me.CboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboEstado.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.CboEstado.FormattingEnabled = True
        Me.CboEstado.Items.AddRange(New Object() {"OREADO", "MOJADO", "HUMEDO"})
        Me.CboEstado.Location = New System.Drawing.Point(430, 48)
        Me.CboEstado.Name = "CboEstado"
        Me.CboEstado.Size = New System.Drawing.Size(159, 23)
        Me.CboEstado.TabIndex = 3
        '
        'CboCalidad
        '
        Me.CboCalidad.BackColor = System.Drawing.Color.White
        Me.CboCalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCalidad.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.CboCalidad.FormattingEnabled = True
        Me.CboCalidad.Items.AddRange(New Object() {"PRIMERA PERGAMINO", "SEGUNDA PERGAMINO", "OTRO"})
        Me.CboCalidad.Location = New System.Drawing.Point(121, 19)
        Me.CboCalidad.Name = "CboCalidad"
        Me.CboCalidad.Size = New System.Drawing.Size(231, 23)
        Me.CboCalidad.TabIndex = 0
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(7, 4)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(157, 15)
        Me.Label22.TabIndex = 274
        Me.Label22.Text = "INFORMACIÓN GENERAL"
        '
        'CboVariedad
        '
        Me.CboVariedad.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.CboVariedad.AlternatingRows = True
        Me.CboVariedad.Caption = ""
        Me.CboVariedad.CaptionHeight = 17
        Me.CboVariedad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CboVariedad.ColumnCaptionHeight = 17
        Me.CboVariedad.ColumnFooterHeight = 17
        Me.CboVariedad.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.CboVariedad.ContentHeight = 18
        Me.CboVariedad.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.CboVariedad.DisplayMember = "Variedad"
        Me.CboVariedad.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.CboVariedad.DropDownWidth = 185
        Me.CboVariedad.EditorBackColor = System.Drawing.SystemColors.Window
        Me.CboVariedad.EditorFont = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.CboVariedad.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.CboVariedad.EditorHeight = 18
        Me.CboVariedad.Images.Add(CType(resources.GetObject("CboVariedad.Images"), System.Drawing.Image))
        Me.CboVariedad.ItemHeight = 35
        Me.CboVariedad.Location = New System.Drawing.Point(121, 49)
        Me.CboVariedad.MatchEntryTimeout = CType(2000, Long)
        Me.CboVariedad.MaxDropDownItems = CType(5, Short)
        Me.CboVariedad.MaxLength = 32767
        Me.CboVariedad.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CboVariedad.Name = "CboVariedad"
        Me.CboVariedad.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CboVariedad.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.CboVariedad.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CboVariedad.Size = New System.Drawing.Size(231, 24)
        Me.CboVariedad.TabIndex = 1
        Me.CboVariedad.Text = " "
        Me.CboVariedad.ValueMember = "IdVariedad"
        Me.CboVariedad.PropBag = resources.GetString("CboVariedad.PropBag")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(359, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 15)
        Me.Label9.TabIndex = 253
        Me.Label9.Text = "Estado   :"
        '
        'TxtHumedad
        '
        Me.TxtHumedad.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHumedad.Location = New System.Drawing.Point(593, 47)
        Me.TxtHumedad.Name = "TxtHumedad"
        Me.TxtHumedad.ReadOnly = True
        Me.TxtHumedad.Size = New System.Drawing.Size(49, 25)
        Me.TxtHumedad.TabIndex = 4
        Me.TxtHumedad.Text = " 0.00"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(362, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(163, 15)
        Me.Label10.TabIndex = 254
        Me.Label10.Text = "% Total de Imperfección :"
        '
        'TxtImperfec
        '
        Me.TxtImperfec.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtImperfec.Location = New System.Drawing.Point(533, 75)
        Me.TxtImperfec.Name = "TxtImperfec"
        Me.TxtImperfec.ReadOnly = True
        Me.TxtImperfec.Size = New System.Drawing.Size(109, 25)
        Me.TxtImperfec.TabIndex = 5
        Me.TxtImperfec.Text = " 0.00"
        '
        'CboCodigoBodega
        '
        Me.CboCodigoBodega.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.CboCodigoBodega.AlternatingRows = True
        Me.CboCodigoBodega.Caption = ""
        Me.CboCodigoBodega.CaptionHeight = 17
        Me.CboCodigoBodega.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CboCodigoBodega.ColumnCaptionHeight = 17
        Me.CboCodigoBodega.ColumnFooterHeight = 17
        Me.CboCodigoBodega.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.CboCodigoBodega.ContentHeight = 18
        Me.CboCodigoBodega.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.CboCodigoBodega.DisplayMember = "Nombre_Bodega"
        Me.CboCodigoBodega.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.CboCodigoBodega.DropDownWidth = 185
        Me.CboCodigoBodega.EditorBackColor = System.Drawing.SystemColors.Window
        Me.CboCodigoBodega.EditorFont = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.CboCodigoBodega.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.CboCodigoBodega.EditorHeight = 18
        Me.CboCodigoBodega.Enabled = False
        Me.CboCodigoBodega.Images.Add(CType(resources.GetObject("CboCodigoBodega.Images"), System.Drawing.Image))
        Me.CboCodigoBodega.ItemHeight = 35
        Me.CboCodigoBodega.Location = New System.Drawing.Point(429, 19)
        Me.CboCodigoBodega.MatchEntryTimeout = CType(2000, Long)
        Me.CboCodigoBodega.MaxDropDownItems = CType(5, Short)
        Me.CboCodigoBodega.MaxLength = 32767
        Me.CboCodigoBodega.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CboCodigoBodega.Name = "CboCodigoBodega"
        Me.CboCodigoBodega.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CboCodigoBodega.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.CboCodigoBodega.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CboCodigoBodega.Size = New System.Drawing.Size(214, 24)
        Me.CboCodigoBodega.TabIndex = 2
        Me.CboCodigoBodega.Text = " "
        Me.CboCodigoBodega.ValueMember = "Cod_Bodega"
        Me.CboCodigoBodega.PropBag = resources.GetString("CboCodigoBodega.PropBag")
        '
        'BtnPesada
        '
        Me.BtnPesada.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPesada.Enabled = False
        Me.BtnPesada.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnPesada.FlatAppearance.BorderSize = 3
        Me.BtnPesada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPesada.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPesada.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnPesada.Image = Global.Remisiones.My.Resources.Resources.Pesaje32
        Me.BtnPesada.Location = New System.Drawing.Point(648, 19)
        Me.BtnPesada.Name = "BtnPesada"
        Me.BtnPesada.Size = New System.Drawing.Size(151, 107)
        Me.BtnPesada.TabIndex = 6
        Me.BtnPesada.Text = " PESADA"
        Me.BtnPesada.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPesada.UseVisualStyleBackColor = True
        Me.BtnPesada.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Controls.Add(Me.BtnEnviarPatio)
        Me.GroupBox5.Controls.Add(Me.BtnNuevoRec)
        Me.GroupBox5.Controls.Add(Me.BtnTikectRec)
        Me.GroupBox5.Controls.Add(Me.BtnGuardarRec)
        Me.GroupBox5.Controls.Add(Me.BtnRecpSalir)
        Me.GroupBox5.Controls.Add(Me.BtnDisconectRec)
        Me.GroupBox5.Controls.Add(Me.BtnImpriRec)
        Me.GroupBox5.Controls.Add(Me.BtnConectarRec)
        Me.GroupBox5.Location = New System.Drawing.Point(2, 606)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(989, 76)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Button1.Image = Global.Remisiones.My.Resources.Resources.up
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(561, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 66)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Procesar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnEnviarPatio
        '
        Me.BtnEnviarPatio.FlatAppearance.BorderSize = 0
        Me.BtnEnviarPatio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEnviarPatio.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnviarPatio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnEnviarPatio.Image = Global.Remisiones.My.Resources.Resources.trolley_48d
        Me.BtnEnviarPatio.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnEnviarPatio.Location = New System.Drawing.Point(761, 8)
        Me.BtnEnviarPatio.Name = "BtnEnviarPatio"
        Me.BtnEnviarPatio.Size = New System.Drawing.Size(112, 66)
        Me.BtnEnviarPatio.TabIndex = 7
        Me.BtnEnviarPatio.Text = "Transladar"
        Me.BtnEnviarPatio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEnviarPatio.UseVisualStyleBackColor = True
        '
        'BtnNuevoRec
        '
        Me.BtnNuevoRec.FlatAppearance.BorderSize = 0
        Me.BtnNuevoRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevoRec.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevoRec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnNuevoRec.Image = Global.Remisiones.My.Resources.Resources.CirculoPlus48
        Me.BtnNuevoRec.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnNuevoRec.Location = New System.Drawing.Point(8, 7)
        Me.BtnNuevoRec.Name = "BtnNuevoRec"
        Me.BtnNuevoRec.Size = New System.Drawing.Size(75, 66)
        Me.BtnNuevoRec.TabIndex = 0
        Me.BtnNuevoRec.Text = "Nuevo"
        Me.BtnNuevoRec.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnNuevoRec.UseVisualStyleBackColor = True
        '
        'BtnTikectRec
        '
        Me.BtnTikectRec.Enabled = False
        Me.BtnTikectRec.FlatAppearance.BorderSize = 0
        Me.BtnTikectRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTikectRec.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTikectRec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnTikectRec.Image = Global.Remisiones.My.Resources.Resources.Tikect48
        Me.BtnTikectRec.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnTikectRec.Location = New System.Drawing.Point(457, 7)
        Me.BtnTikectRec.Name = "BtnTikectRec"
        Me.BtnTikectRec.Size = New System.Drawing.Size(75, 66)
        Me.BtnTikectRec.TabIndex = 4
        Me.BtnTikectRec.Text = "Ticket"
        Me.BtnTikectRec.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnTikectRec.UseVisualStyleBackColor = True
        '
        'BtnGuardarRec
        '
        Me.BtnGuardarRec.FlatAppearance.BorderSize = 0
        Me.BtnGuardarRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardarRec.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardarRec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnGuardarRec.Image = Global.Remisiones.My.Resources.Resources.Save4811
        Me.BtnGuardarRec.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnGuardarRec.Location = New System.Drawing.Point(110, 8)
        Me.BtnGuardarRec.Name = "BtnGuardarRec"
        Me.BtnGuardarRec.Size = New System.Drawing.Size(75, 66)
        Me.BtnGuardarRec.TabIndex = 1
        Me.BtnGuardarRec.Text = "Guardar"
        Me.BtnGuardarRec.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnGuardarRec.UseVisualStyleBackColor = True
        '
        'BtnRecpSalir
        '
        Me.BtnRecpSalir.FlatAppearance.BorderSize = 0
        Me.BtnRecpSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRecpSalir.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRecpSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnRecpSalir.Image = Global.Remisiones.My.Resources.Resources.exit48
        Me.BtnRecpSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnRecpSalir.Location = New System.Drawing.Point(891, 8)
        Me.BtnRecpSalir.Name = "BtnRecpSalir"
        Me.BtnRecpSalir.Size = New System.Drawing.Size(75, 66)
        Me.BtnRecpSalir.TabIndex = 6
        Me.BtnRecpSalir.Text = "Salir"
        Me.BtnRecpSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnRecpSalir.UseVisualStyleBackColor = True
        '
        'BtnDisconectRec
        '
        Me.BtnDisconectRec.Enabled = False
        Me.BtnDisconectRec.FlatAppearance.BorderSize = 0
        Me.BtnDisconectRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDisconectRec.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDisconectRec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnDisconectRec.Image = Global.Remisiones.My.Resources.Resources.disconexion48
        Me.BtnDisconectRec.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnDisconectRec.Location = New System.Drawing.Point(321, 8)
        Me.BtnDisconectRec.Name = "BtnDisconectRec"
        Me.BtnDisconectRec.Size = New System.Drawing.Size(108, 66)
        Me.BtnDisconectRec.TabIndex = 3
        Me.BtnDisconectRec.Text = "Desconectar"
        Me.BtnDisconectRec.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnDisconectRec.UseVisualStyleBackColor = True
        '
        'BtnImpriRec
        '
        Me.BtnImpriRec.FlatAppearance.BorderSize = 0
        Me.BtnImpriRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnImpriRec.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImpriRec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnImpriRec.Image = Global.Remisiones.My.Resources.Resources.Print48
        Me.BtnImpriRec.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnImpriRec.Location = New System.Drawing.Point(667, 8)
        Me.BtnImpriRec.Name = "BtnImpriRec"
        Me.BtnImpriRec.Size = New System.Drawing.Size(75, 65)
        Me.BtnImpriRec.TabIndex = 5
        Me.BtnImpriRec.Text = "Reporte"
        Me.BtnImpriRec.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnImpriRec.UseVisualStyleBackColor = True
        '
        'BtnConectarRec
        '
        Me.BtnConectarRec.Enabled = False
        Me.BtnConectarRec.FlatAppearance.BorderSize = 0
        Me.BtnConectarRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConectarRec.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConectarRec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnConectarRec.Image = Global.Remisiones.My.Resources.Resources.conexion48
        Me.BtnConectarRec.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnConectarRec.Location = New System.Drawing.Point(220, 7)
        Me.BtnConectarRec.Name = "BtnConectarRec"
        Me.BtnConectarRec.Size = New System.Drawing.Size(75, 66)
        Me.BtnConectarRec.TabIndex = 2
        Me.BtnConectarRec.Text = "Conectar"
        Me.BtnConectarRec.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnConectarRec.UseVisualStyleBackColor = True
        '
        'CheckMohoso
        '
        Me.CheckMohoso.AutoSize = True
        Me.CheckMohoso.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.CheckMohoso.ForeColor = System.Drawing.Color.White
        Me.CheckMohoso.Location = New System.Drawing.Point(8, 37)
        Me.CheckMohoso.Name = "CheckMohoso"
        Me.CheckMohoso.Size = New System.Drawing.Size(63, 19)
        Me.CheckMohoso.TabIndex = 0
        Me.CheckMohoso.Text = "Moho"
        Me.CheckMohoso.UseVisualStyleBackColor = True
        '
        'CheckFermento
        '
        Me.CheckFermento.AutoSize = True
        Me.CheckFermento.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.CheckFermento.ForeColor = System.Drawing.Color.White
        Me.CheckFermento.Location = New System.Drawing.Point(87, 37)
        Me.CheckFermento.Name = "CheckFermento"
        Me.CheckFermento.Size = New System.Drawing.Size(87, 19)
        Me.CheckFermento.TabIndex = 1
        Me.CheckFermento.Text = "Fermento"
        Me.CheckFermento.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.GroupBox7.Controls.Add(Me.Label13)
        Me.GroupBox7.Controls.Add(Me.CheckMohoso)
        Me.GroupBox7.Controls.Add(Me.CheckFermento)
        Me.GroupBox7.Location = New System.Drawing.Point(810, 537)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(181, 69)
        Me.GroupBox7.TabIndex = 4
        Me.GroupBox7.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(2, 8)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(181, 17)
        Me.Label13.TabIndex = 273
        Me.Label13.Text = "              Daño             "
        '
        'TDGImperfeccion
        '
        Me.TDGImperfeccion.AllowColMove = False
        Me.TDGImperfeccion.Caption = "% Imperfecciones"
        Me.TDGImperfeccion.CaptionHeight = 17
        Me.TDGImperfeccion.ExpandColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.TDGImperfeccion.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.TDGImperfeccion.GroupByCaption = "Drag a column header here to group by that column"
        Me.TDGImperfeccion.Images.Add(CType(resources.GetObject("TDGImperfeccion.Images"), System.Drawing.Image))
        Me.TDGImperfeccion.Location = New System.Drawing.Point(811, 349)
        Me.TDGImperfeccion.Name = "TDGImperfeccion"
        Me.TDGImperfeccion.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.TDGImperfeccion.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.TDGImperfeccion.PreviewInfo.ZoomFactor = 75
        Me.TDGImperfeccion.PrintInfo.PageSettings = CType(resources.GetObject("TDGImperfeccion.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.TDGImperfeccion.RowHeight = 23
        Me.TDGImperfeccion.RowSubDividerColor = System.Drawing.Color.White
        Me.TDGImperfeccion.Size = New System.Drawing.Size(180, 208)
        Me.TDGImperfeccion.TabIndex = 266
        Me.TDGImperfeccion.Text = "C1TrueDBGrid1"
        Me.TDGImperfeccion.PropBag = resources.GetString("TDGImperfeccion.PropBag")
        '
        'TrueDBDetalleNP
        '
        Me.TrueDBDetalleNP.AllowAddNew = True
        Me.TrueDBDetalleNP.AllowColMove = False
        Me.TrueDBDetalleNP.AllowDelete = True
        Me.TrueDBDetalleNP.AlternatingRows = True
        Me.TrueDBDetalleNP.Caption = "LISTADOS DE PESADAS"
        Me.TrueDBDetalleNP.CaptionHeight = 17
        Me.TrueDBDetalleNP.CollapseColor = System.Drawing.Color.DimGray
        Me.TrueDBDetalleNP.GroupByCaption = "Drag a column header here to group by that column"
        Me.TrueDBDetalleNP.Images.Add(CType(resources.GetObject("TrueDBDetalleNP.Images"), System.Drawing.Image))
        Me.TrueDBDetalleNP.Location = New System.Drawing.Point(4, 41)
        Me.TrueDBDetalleNP.Name = "TrueDBDetalleNP"
        Me.TrueDBDetalleNP.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.TrueDBDetalleNP.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.TrueDBDetalleNP.PreviewInfo.ZoomFactor = 75
        Me.TrueDBDetalleNP.PrintInfo.PageSettings = CType(resources.GetObject("TrueDBDetalleNP.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.TrueDBDetalleNP.Size = New System.Drawing.Size(987, 185)
        Me.TrueDBDetalleNP.TabIndex = 0
        Me.TrueDBDetalleNP.Text = "C1TrueDBGrid1"
        Me.TrueDBDetalleNP.PropBag = resources.GetString("TrueDBDetalleNP.PropBag")
        '
        'FrmRecepcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(997, 683)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.CboTipoRecepcion)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.ChkTaraSaco)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TDGImperfeccion)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lbltipo)
        Me.Controls.Add(Me.TrueDBDetalleNP)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.BtnBuscarCodProv)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRecepcion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notas de peso"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.CboFinca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboPlantillo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboRecibimosde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboProductor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BtnBuscarCodProv.ResumeLayout(False)
        Me.BtnBuscarCodProv.PerformLayout()
        CType(Me.CmbSerie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.CboPlaca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboConductor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CboVariedad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboCodigoBodega, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.TDGImperfeccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrueDBDetalleNP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingImperfeccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TrueDBDetalleNP As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents lbldatosre As System.Windows.Forms.Label
    Friend WithEvents DTPFecha As System.Windows.Forms.Label
    Friend WithEvents LblHora As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents datosprov As System.Windows.Forms.Label
    Friend WithEvents TxtRConacafe As System.Windows.Forms.TextBox
    Friend WithEvents lblnombre As System.Windows.Forms.Label
    Friend WithEvents lblproveedor As System.Windows.Forms.Label
    Friend WithEvents BtnBuscarCodProv As System.Windows.Forms.GroupBox
    Friend WithEvents BtnBuscarRecep As System.Windows.Forms.Button
    Friend WithEvents TxtNumeroEnsamble As System.Windows.Forms.TextBox
    Friend WithEvents CboTipoPesada As System.Windows.Forms.ComboBox
    Friend WithEvents lbltipo As System.Windows.Forms.Label
    Friend WithEvents lblbdega As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents txtsubtotal As System.Windows.Forms.TextBox
    Friend WithEvents BindingDetalle As System.Windows.Forms.BindingSource
    Friend WithEvents sp As System.IO.Ports.SerialPort
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtobservaciones As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents TxtCedulaConductor As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CboPlaca As C1.Win.C1List.C1Combo
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LblEstado As System.Windows.Forms.Label
    Friend WithEvents ChkTaraSaco As System.Windows.Forms.CheckBox
    Friend WithEvents CmbSerie As C1.Win.C1List.C1Combo
    Friend WithEvents BtnPesada As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CboConductor As C1.Win.C1List.C1Combo
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CboCodigoBodega As C1.Win.C1List.C1Combo
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BtnNuevoRec As System.Windows.Forms.Button
    Friend WithEvents BtnGuardarRec As System.Windows.Forms.Button
    Friend WithEvents BtnDisconectRec As System.Windows.Forms.Button
    Friend WithEvents BtnConectarRec As System.Windows.Forms.Button
    Friend WithEvents BtnImpriRec As System.Windows.Forms.Button
    Friend WithEvents BtnRecpSalir As System.Windows.Forms.Button
    Friend WithEvents BtnTikectRec As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtHumedad As System.Windows.Forms.TextBox
    Friend WithEvents TxtImperfec As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CboPlantillo As C1.Win.C1List.C1Combo
    Friend WithEvents CboFinca As C1.Win.C1List.C1Combo
    Public WithEvents LblSucursal As System.Windows.Forms.Label
    Friend WithEvents BtnBusConductor As System.Windows.Forms.Button
    Friend WithEvents BtnBusPlaca As System.Windows.Forms.Button
    Friend WithEvents TxtCodProductor As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents CboTipoRecepcion As System.Windows.Forms.ComboBox
    Friend WithEvents TDGImperfeccion As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents BtnVehiculoAgre As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TxtRemision As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents CboRecibimosde As C1.Win.C1List.C1Combo
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents BtnAgreFinca As System.Windows.Forms.Button
    Friend WithEvents BtnAgreConductor As System.Windows.Forms.Button
    Friend WithEvents CboProductor As C1.Win.C1List.C1Combo
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents BtnAgreProductor As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TxtCedulaProductor As System.Windows.Forms.TextBox
    Friend WithEvents CboVariedad As C1.Win.C1List.C1Combo
    Friend WithEvents BindingImperfeccion As System.Windows.Forms.BindingSource
    Friend WithEvents CheckMohoso As System.Windows.Forms.CheckBox
    Friend WithEvents CheckFermento As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents BtnAgrePlantillo As System.Windows.Forms.Button
    Friend WithEvents TxtColor As System.Windows.Forms.TextBox
    Friend WithEvents TxtModelo As System.Windows.Forms.TextBox
    Friend WithEvents TxtMarca As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents CboCalidad As System.Windows.Forms.ComboBox
    Friend WithEvents CboEstado As System.Windows.Forms.ComboBox
    Friend WithEvents BtnEnviarPatio As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
