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
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.TxtCodProductor = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.CboProductor = New C1.Win.C1List.C1Combo
        Me.TxtCedulaProductor = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Button8 = New System.Windows.Forms.Button
        Me.CboRecibimosde = New C1.Win.C1List.C1Combo
        Me.TxtRemision = New System.Windows.Forms.TextBox
        Me.lblproveedor = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.CboPlantillo = New C1.Win.C1List.C1Combo
        Me.CboFinca = New C1.Win.C1List.C1Combo
        Me.Label11 = New System.Windows.Forms.Label
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
        Me.LblPeso = New System.Windows.Forms.Label
        Me.txtsubtotal = New System.Windows.Forms.TextBox
        Me.sp = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtobservaciones = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
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
        Me.CboCalidad = New C1.Win.C1List.C1Combo
        Me.CboVariedad = New C1.Win.C1List.C1Combo
        Me.CboEstado = New C1.Win.C1List.C1Combo
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxtHumedad = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.BtnBsquedaProductor = New System.Windows.Forms.Button
        Me.TxtImperfec = New System.Windows.Forms.TextBox
        Me.CboCodigoBodega = New C1.Win.C1List.C1Combo
        Me.CmdPesada = New System.Windows.Forms.Button
        Me.BubbleBtn = New DevComponents.DotNetBar.BubbleBarTab(Me.components)
        Me.BbtnNew = New DevComponents.DotNetBar.BubbleButton
        Me.BubbleButton2 = New DevComponents.DotNetBar.BubbleButton
        Me.BbtnSave = New DevComponents.DotNetBar.BubbleButton
        Me.BbtnConect = New DevComponents.DotNetBar.BubbleButton
        Me.BbtnDisConect = New DevComponents.DotNetBar.BubbleButton
        Me.Bbtn = New DevComponents.DotNetBar.BubbleButton
        Me.BubbleButton7 = New DevComponents.DotNetBar.BubbleButton
        Me.BubbleButton8 = New DevComponents.DotNetBar.BubbleButton
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.BtnNuevoRec = New System.Windows.Forms.Button
        Me.BtnTikectRec = New System.Windows.Forms.Button
        Me.BtnGuardarRec = New System.Windows.Forms.Button
        Me.BtnRecpSalir = New System.Windows.Forms.Button
        Me.BtnDisconectRec = New System.Windows.Forms.Button
        Me.BtnImpriRec = New System.Windows.Forms.Button
        Me.BtnConectarRec = New System.Windows.Forms.Button
        Me.TDGImperfeccion = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.TxtNombreProducto = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.BindingDetalle = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingImperfeccion = New System.Windows.Forms.BindingSource(Me.components)
        Me.CheckMohoso = New System.Windows.Forms.CheckBox
        Me.CheckFermento = New System.Windows.Forms.CheckBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox6.SuspendLayout()
        CType(Me.CboProductor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboRecibimosde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboPlantillo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboFinca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BtnBuscarCodProv.SuspendLayout()
        CType(Me.CmbSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CboPlaca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboConductor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CboCalidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboVariedad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboCodigoBodega, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.TDGImperfeccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNombreProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingImperfeccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(4, 49)
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
        Me.Label6.Location = New System.Drawing.Point(4, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 15)
        Me.Label6.TabIndex = 182
        Me.Label6.Text = "Calidad             :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(358, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 15)
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
        Me.lbldatosre.Size = New System.Drawing.Size(156, 15)
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
        Me.DTPFecha.Size = New System.Drawing.Size(85, 15)
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
        Me.LblHora.Size = New System.Drawing.Size(95, 15)
        Me.LblHora.TabIndex = 181
        Me.LblHora.Text = "10:23:55 p.m."
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.GroupBox6.Controls.Add(Me.Button13)
        Me.GroupBox6.Controls.Add(Me.Button5)
        Me.GroupBox6.Controls.Add(Me.Button3)
        Me.GroupBox6.Controls.Add(Me.TxtCodProductor)
        Me.GroupBox6.Controls.Add(Me.Label21)
        Me.GroupBox6.Controls.Add(Me.CboProductor)
        Me.GroupBox6.Controls.Add(Me.TxtCedulaProductor)
        Me.GroupBox6.Controls.Add(Me.Label20)
        Me.GroupBox6.Controls.Add(Me.Button8)
        Me.GroupBox6.Controls.Add(Me.CboRecibimosde)
        Me.GroupBox6.Controls.Add(Me.TxtRemision)
        Me.GroupBox6.Controls.Add(Me.lblproveedor)
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.CboPlantillo)
        Me.GroupBox6.Controls.Add(Me.CboFinca)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.TxtRConacafe)
        Me.GroupBox6.Controls.Add(Me.lblnombre)
        Me.GroupBox6.Controls.Add(Me.datosprov)
        Me.GroupBox6.Location = New System.Drawing.Point(3, 343)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(805, 132)
        Me.GroupBox6.TabIndex = 222
        Me.GroupBox6.TabStop = False
        '
        'Button13
        '
        Me.Button13.FlatAppearance.BorderSize = 0
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Image = Global.Remisiones.My.Resources.Resources.Lupa321
        Me.Button13.Location = New System.Drawing.Point(762, 68)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(36, 30)
        Me.Button13.TabIndex = 271
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Image = Global.Remisiones.My.Resources.Resources.icons8_plus_36
        Me.Button5.Location = New System.Drawing.Point(764, 39)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(32, 30)
        Me.Button5.TabIndex = 273
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.Remisiones.My.Resources.Resources.icons8_plus_36
        Me.Button3.Location = New System.Drawing.Point(299, 96)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(32, 30)
        Me.Button3.TabIndex = 270
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TxtCodProductor
        '
        Me.TxtCodProductor.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodProductor.Location = New System.Drawing.Point(451, 73)
        Me.TxtCodProductor.Name = "TxtCodProductor"
        Me.TxtCodProductor.Size = New System.Drawing.Size(300, 23)
        Me.TxtCodProductor.TabIndex = 256
        Me.TxtCodProductor.Text = " "
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(342, 106)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(98, 15)
        Me.Label21.TabIndex = 272
        Me.Label21.Text = "Cedula           :"
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
        Me.CboProductor.DisplayMember = "Placa"
        Me.CboProductor.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.CboProductor.DropDownWidth = 185
        Me.CboProductor.EditorBackColor = System.Drawing.SystemColors.Window
        Me.CboProductor.EditorFont = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.CboProductor.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.CboProductor.EditorHeight = 18
        Me.CboProductor.Images.Add(CType(resources.GetObject("CboProductor.Images"), System.Drawing.Image))
        Me.CboProductor.ItemHeight = 35
        Me.CboProductor.Location = New System.Drawing.Point(451, 44)
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
        Me.CboProductor.TabIndex = 271
        Me.CboProductor.ValueMember = "IdVehiculo"
        Me.CboProductor.PropBag = resources.GetString("CboProductor.PropBag")
        '
        'TxtCedulaProductor
        '
        Me.TxtCedulaProductor.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCedulaProductor.Location = New System.Drawing.Point(451, 100)
        Me.TxtCedulaProductor.Name = "TxtCedulaProductor"
        Me.TxtCedulaProductor.Size = New System.Drawing.Size(300, 23)
        Me.TxtCedulaProductor.TabIndex = 271
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(341, 49)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(102, 15)
        Me.Label20.TabIndex = 270
        Me.Label20.Text = "Por Cuenta de :"
        '
        'Button8
        '
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Image = Global.Remisiones.My.Resources.Resources.icons8_plus_36
        Me.Button8.Location = New System.Drawing.Point(299, 66)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(32, 30)
        Me.Button8.TabIndex = 264
        Me.Button8.UseVisualStyleBackColor = True
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
        Me.CboRecibimosde.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.CboRecibimosde.ContentHeight = 18
        Me.CboRecibimosde.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.CboRecibimosde.DisplayMember = "Placa"
        Me.CboRecibimosde.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.CboRecibimosde.DropDownWidth = 185
        Me.CboRecibimosde.EditorBackColor = System.Drawing.SystemColors.Window
        Me.CboRecibimosde.EditorFont = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.CboRecibimosde.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.CboRecibimosde.EditorHeight = 18
        Me.CboRecibimosde.Images.Add(CType(resources.GetObject("CboRecibimosde.Images"), System.Drawing.Image))
        Me.CboRecibimosde.ItemHeight = 35
        Me.CboRecibimosde.Location = New System.Drawing.Point(451, 15)
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
        Me.CboRecibimosde.TabIndex = 265
        Me.CboRecibimosde.ValueMember = "IdVehiculo"
        Me.CboRecibimosde.PropBag = resources.GetString("CboRecibimosde.PropBag")
        '
        'TxtRemision
        '
        Me.TxtRemision.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.TxtRemision.Location = New System.Drawing.Point(123, 16)
        Me.TxtRemision.Name = "TxtRemision"
        Me.TxtRemision.Size = New System.Drawing.Size(174, 23)
        Me.TxtRemision.TabIndex = 269
        '
        'lblproveedor
        '
        Me.lblproveedor.AutoSize = True
        Me.lblproveedor.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.lblproveedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.lblproveedor.Location = New System.Drawing.Point(342, 76)
        Me.lblproveedor.Name = "lblproveedor"
        Me.lblproveedor.Size = New System.Drawing.Size(100, 15)
        Me.lblproveedor.TabIndex = 2
        Me.lblproveedor.Text = "Código          : "
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(341, 21)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(99, 15)
        Me.Label19.TabIndex = 264
        Me.Label19.Text = "Recibimos de :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(4, 19)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(95, 15)
        Me.Label18.TabIndex = 268
        Me.Label18.Text = "Remision No :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(7, 106)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 15)
        Me.Label12.TabIndex = 190
        Me.Label12.Text = "Plantillo       :"
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
        Me.CboPlantillo.Location = New System.Drawing.Point(123, 101)
        Me.CboPlantillo.MatchEntryTimeout = CType(2000, Long)
        Me.CboPlantillo.MaxDropDownItems = CType(5, Short)
        Me.CboPlantillo.MaxLength = 32767
        Me.CboPlantillo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CboPlantillo.Name = "CboPlantillo"
        Me.CboPlantillo.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CboPlantillo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.CboPlantillo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CboPlantillo.Size = New System.Drawing.Size(174, 24)
        Me.CboPlantillo.TabIndex = 189
        Me.CboPlantillo.ValueMember = "IdPlantillo"
        Me.CboPlantillo.PropBag = resources.GetString("CboPlantillo.PropBag")
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
        Me.CboFinca.Location = New System.Drawing.Point(123, 72)
        Me.CboFinca.MatchEntryTimeout = CType(2000, Long)
        Me.CboFinca.MaxDropDownItems = CType(5, Short)
        Me.CboFinca.MaxLength = 32767
        Me.CboFinca.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CboFinca.Name = "CboFinca"
        Me.CboFinca.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CboFinca.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.CboFinca.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CboFinca.Size = New System.Drawing.Size(174, 24)
        Me.CboFinca.TabIndex = 188
        Me.CboFinca.ValueMember = "IdFinca"
        Me.CboFinca.PropBag = resources.GetString("CboFinca.PropBag")
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(7, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 15)
        Me.Label11.TabIndex = 187
        Me.Label11.Text = "Finca            :"
        '
        'TxtRConacafe
        '
        Me.TxtRConacafe.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.TxtRConacafe.Location = New System.Drawing.Point(123, 43)
        Me.TxtRConacafe.Name = "TxtRConacafe"
        Me.TxtRConacafe.Size = New System.Drawing.Size(174, 23)
        Me.TxtRConacafe.TabIndex = 178
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.lblnombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.lblnombre.Location = New System.Drawing.Point(5, 46)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(93, 15)
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
        Me.datosprov.Size = New System.Drawing.Size(160, 15)
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
        Me.BtnBuscarCodProv.TabIndex = 221
        Me.BtnBuscarCodProv.TabStop = False
        '
        'lblbdega
        '
        Me.lblbdega.AutoSize = True
        Me.lblbdega.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.lblbdega.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.lblbdega.Location = New System.Drawing.Point(307, 16)
        Me.lblbdega.Name = "lblbdega"
        Me.lblbdega.Size = New System.Drawing.Size(90, 15)
        Me.lblbdega.TabIndex = 12
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
        Me.CmbSerie.TabIndex = 212
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
        Me.BtnBuscarRecep.TabIndex = 180
        Me.BtnBuscarRecep.UseVisualStyleBackColor = True
        '
        'TxtNumeroEnsamble
        '
        Me.TxtNumeroEnsamble.Enabled = False
        Me.TxtNumeroEnsamble.Location = New System.Drawing.Point(474, 14)
        Me.TxtNumeroEnsamble.Name = "TxtNumeroEnsamble"
        Me.TxtNumeroEnsamble.Size = New System.Drawing.Size(103, 20)
        Me.TxtNumeroEnsamble.TabIndex = 177
        Me.TxtNumeroEnsamble.Text = "- - - - - 0 - - - - - "
        Me.TxtNumeroEnsamble.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(7, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(110, 15)
        Me.Label15.TabIndex = 265
        Me.Label15.Text = "Tipo de pesada :"
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.LblEstado.ForeColor = System.Drawing.Color.BlanchedAlmond
        Me.LblEstado.Location = New System.Drawing.Point(650, 16)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(113, 15)
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
        Me.CboTipoPesada.TabIndex = 179
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
        'LblPeso
        '
        Me.LblPeso.AutoSize = True
        Me.LblPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPeso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.LblPeso.Location = New System.Drawing.Point(997, 187)
        Me.LblPeso.Name = "LblPeso"
        Me.LblPeso.Size = New System.Drawing.Size(49, 24)
        Me.LblPeso.TabIndex = 228
        Me.LblPeso.Text = "0.00"
        Me.LblPeso.Visible = False
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
        Me.txtobservaciones.Location = New System.Drawing.Point(121, 100)
        Me.txtobservaciones.Name = "txtobservaciones"
        Me.txtobservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtobservaciones.Size = New System.Drawing.Size(521, 23)
        Me.txtobservaciones.TabIndex = 183
        Me.txtobservaciones.Text = " "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(4, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 15)
        Me.Label1.TabIndex = 184
        Me.Label1.Text = "Observación      :"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.Button2)
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
        Me.GroupBox2.TabIndex = 237
        Me.GroupBox2.TabStop = False
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.TextBox4.Location = New System.Drawing.Point(428, 46)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(174, 23)
        Me.TextBox4.TabIndex = 272
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.TextBox3.Location = New System.Drawing.Point(428, 16)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(174, 23)
        Me.TextBox3.TabIndex = 271
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.Remisiones.My.Resources.Resources.icons8_plus_36
        Me.Button2.Location = New System.Drawing.Point(915, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(32, 30)
        Me.Button2.TabIndex = 270
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(366, 51)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 15)
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
        Me.Label16.Size = New System.Drawing.Size(61, 15)
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
        Me.BtnVehiculoAgre.TabIndex = 257
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
        Me.BtnBusConductor.TabIndex = 256
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
        Me.BtnBusPlaca.TabIndex = 257
        Me.BtnBusPlaca.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(11, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 15)
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
        Me.Label3.Size = New System.Drawing.Size(79, 15)
        Me.Label3.TabIndex = 247
        Me.Label3.Text = "Placa         :"
        '
        'TxtMarca
        '
        Me.TxtMarca.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.TxtMarca.Location = New System.Drawing.Point(103, 46)
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.ReadOnly = True
        Me.TxtMarca.Size = New System.Drawing.Size(174, 23)
        Me.TxtMarca.TabIndex = 244
        '
        'CboPlaca
        '
        Me.CboPlaca.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.CboPlaca.AlternatingRows = True
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
        Me.CboPlaca.TabIndex = 243
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
        Me.TxtCedulaConductor.TabIndex = 241
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
        Me.CboConductor.TabIndex = 240
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
        Me.Label4.Size = New System.Drawing.Size(81, 15)
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
        Me.Label14.Size = New System.Drawing.Size(123, 15)
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
        Me.GroupBox1.Controls.Add(Me.CboCalidad)
        Me.GroupBox1.Controls.Add(Me.CboVariedad)
        Me.GroupBox1.Controls.Add(Me.CboEstado)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TxtHumedad)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.BtnBsquedaProductor)
        Me.GroupBox1.Controls.Add(Me.TxtImperfec)
        Me.GroupBox1.Controls.Add(Me.CboCodigoBodega)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.LblSucursal)
        Me.GroupBox1.Controls.Add(Me.CmdPesada)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtobservaciones)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 474)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(805, 133)
        Me.GroupBox1.TabIndex = 240
        Me.GroupBox1.TabStop = False
        '
        'CboCalidad
        '
        Me.CboCalidad.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.CboCalidad.AlternatingRows = True
        Me.CboCalidad.Caption = ""
        Me.CboCalidad.CaptionHeight = 17
        Me.CboCalidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CboCalidad.ColumnCaptionHeight = 17
        Me.CboCalidad.ColumnFooterHeight = 17
        Me.CboCalidad.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.CboCalidad.ContentHeight = 18
        Me.CboCalidad.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.CboCalidad.DisplayMember = "Nombre_Bodega"
        Me.CboCalidad.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.CboCalidad.DropDownWidth = 185
        Me.CboCalidad.EditorBackColor = System.Drawing.SystemColors.Window
        Me.CboCalidad.EditorFont = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.CboCalidad.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.CboCalidad.EditorHeight = 18
        Me.CboCalidad.Images.Add(CType(resources.GetObject("CboCalidad.Images"), System.Drawing.Image))
        Me.CboCalidad.ItemHeight = 35
        Me.CboCalidad.Location = New System.Drawing.Point(121, 15)
        Me.CboCalidad.MatchEntryTimeout = CType(2000, Long)
        Me.CboCalidad.MaxDropDownItems = CType(5, Short)
        Me.CboCalidad.MaxLength = 32767
        Me.CboCalidad.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CboCalidad.Name = "CboCalidad"
        Me.CboCalidad.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CboCalidad.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.CboCalidad.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CboCalidad.Size = New System.Drawing.Size(197, 24)
        Me.CboCalidad.TabIndex = 272
        Me.CboCalidad.Text = " "
        Me.CboCalidad.ValueMember = "Cod_Bodega"
        Me.CboCalidad.PropBag = resources.GetString("CboCalidad.PropBag")
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
        Me.CboVariedad.DisplayMember = "Nombre_Bodega"
        Me.CboVariedad.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.CboVariedad.DropDownWidth = 185
        Me.CboVariedad.EditorBackColor = System.Drawing.SystemColors.Window
        Me.CboVariedad.EditorFont = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.CboVariedad.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.CboVariedad.EditorHeight = 18
        Me.CboVariedad.Images.Add(CType(resources.GetObject("CboVariedad.Images"), System.Drawing.Image))
        Me.CboVariedad.ItemHeight = 35
        Me.CboVariedad.Location = New System.Drawing.Point(121, 43)
        Me.CboVariedad.MatchEntryTimeout = CType(2000, Long)
        Me.CboVariedad.MaxDropDownItems = CType(5, Short)
        Me.CboVariedad.MaxLength = 32767
        Me.CboVariedad.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CboVariedad.Name = "CboVariedad"
        Me.CboVariedad.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CboVariedad.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.CboVariedad.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CboVariedad.Size = New System.Drawing.Size(197, 24)
        Me.CboVariedad.TabIndex = 271
        Me.CboVariedad.Text = " "
        Me.CboVariedad.ValueMember = "Cod_Bodega"
        Me.CboVariedad.PropBag = resources.GetString("CboVariedad.PropBag")
        '
        'CboEstado
        '
        Me.CboEstado.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.CboEstado.AlternatingRows = True
        Me.CboEstado.Caption = ""
        Me.CboEstado.CaptionHeight = 17
        Me.CboEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CboEstado.ColumnCaptionHeight = 17
        Me.CboEstado.ColumnFooterHeight = 17
        Me.CboEstado.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.CboEstado.ContentHeight = 18
        Me.CboEstado.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.CboEstado.DisplayMember = "Nombre_Bodega"
        Me.CboEstado.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.CboEstado.DropDownWidth = 185
        Me.CboEstado.EditorBackColor = System.Drawing.SystemColors.Window
        Me.CboEstado.EditorFont = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.CboEstado.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.CboEstado.EditorHeight = 18
        Me.CboEstado.Images.Add(CType(resources.GetObject("CboEstado.Images"), System.Drawing.Image))
        Me.CboEstado.ItemHeight = 35
        Me.CboEstado.Location = New System.Drawing.Point(446, 43)
        Me.CboEstado.MatchEntryTimeout = CType(2000, Long)
        Me.CboEstado.MaxDropDownItems = CType(5, Short)
        Me.CboEstado.MaxLength = 32767
        Me.CboEstado.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CboEstado.Name = "CboEstado"
        Me.CboEstado.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CboEstado.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.CboEstado.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CboEstado.Size = New System.Drawing.Size(142, 24)
        Me.CboEstado.TabIndex = 267
        Me.CboEstado.Text = " "
        Me.CboEstado.ValueMember = "Cod_Bodega"
        Me.CboEstado.PropBag = resources.GetString("CboEstado.PropBag")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(359, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 15)
        Me.Label9.TabIndex = 253
        Me.Label9.Text = "Estado   :"
        '
        'TxtHumedad
        '
        Me.TxtHumedad.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHumedad.Location = New System.Drawing.Point(593, 42)
        Me.TxtHumedad.Name = "TxtHumedad"
        Me.TxtHumedad.Size = New System.Drawing.Size(49, 25)
        Me.TxtHumedad.TabIndex = 252
        Me.TxtHumedad.Text = " 0.00"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(361, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(165, 15)
        Me.Label10.TabIndex = 254
        Me.Label10.Text = "% Total de Imperfección :"
        '
        'BtnBsquedaProductor
        '
        Me.BtnBsquedaProductor.BackColor = System.Drawing.Color.Transparent
        Me.BtnBsquedaProductor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.BtnBsquedaProductor.FlatAppearance.BorderSize = 0
        Me.BtnBsquedaProductor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBsquedaProductor.Image = Global.Remisiones.My.Resources.Resources.Lupa32
        Me.BtnBsquedaProductor.Location = New System.Drawing.Point(648, 10)
        Me.BtnBsquedaProductor.Name = "BtnBsquedaProductor"
        Me.BtnBsquedaProductor.Size = New System.Drawing.Size(30, 30)
        Me.BtnBsquedaProductor.TabIndex = 171
        Me.BtnBsquedaProductor.UseVisualStyleBackColor = False
        '
        'TxtImperfec
        '
        Me.TxtImperfec.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtImperfec.Location = New System.Drawing.Point(593, 70)
        Me.TxtImperfec.Name = "TxtImperfec"
        Me.TxtImperfec.Size = New System.Drawing.Size(49, 25)
        Me.TxtImperfec.TabIndex = 251
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
        Me.CboCodigoBodega.Images.Add(CType(resources.GetObject("CboCodigoBodega.Images"), System.Drawing.Image))
        Me.CboCodigoBodega.ItemHeight = 35
        Me.CboCodigoBodega.Location = New System.Drawing.Point(446, 14)
        Me.CboCodigoBodega.MatchEntryTimeout = CType(2000, Long)
        Me.CboCodigoBodega.MaxDropDownItems = CType(5, Short)
        Me.CboCodigoBodega.MaxLength = 32767
        Me.CboCodigoBodega.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CboCodigoBodega.Name = "CboCodigoBodega"
        Me.CboCodigoBodega.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CboCodigoBodega.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.CboCodigoBodega.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CboCodigoBodega.Size = New System.Drawing.Size(197, 24)
        Me.CboCodigoBodega.TabIndex = 250
        Me.CboCodigoBodega.Text = " "
        Me.CboCodigoBodega.ValueMember = "Cod_Bodega"
        Me.CboCodigoBodega.PropBag = resources.GetString("CboCodigoBodega.PropBag")
        '
        'CmdPesada
        '
        Me.CmdPesada.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdPesada.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CmdPesada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdPesada.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPesada.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.CmdPesada.Image = Global.Remisiones.My.Resources.Resources.Pesaje32
        Me.CmdPesada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdPesada.Location = New System.Drawing.Point(687, 14)
        Me.CmdPesada.Name = "CmdPesada"
        Me.CmdPesada.Size = New System.Drawing.Size(112, 112)
        Me.CmdPesada.TabIndex = 245
        Me.CmdPesada.Text = " PESADA"
        Me.CmdPesada.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdPesada.UseVisualStyleBackColor = True
        Me.CmdPesada.Visible = False
        '
        'BubbleBtn
        '
        Me.BubbleBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BubbleBtn.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BubbleBtn.Buttons.AddRange(New DevComponents.DotNetBar.BubbleButton() {Me.BbtnNew, Me.BubbleButton2, Me.BbtnSave, Me.BbtnConect, Me.BbtnDisConect, Me.Bbtn, Me.BubbleButton7, Me.BubbleButton8})
        Me.BubbleBtn.DarkBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BubbleBtn.LightBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BubbleBtn.Name = "BubbleBtn"
        Me.BubbleBtn.Text = "ACCIONES"
        Me.BubbleBtn.TextColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(3, Byte), Integer))
        '
        'BbtnNew
        '
        Me.BbtnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BbtnNew.Image = Global.Remisiones.My.Resources.Resources.CirculoPlus48
        Me.BbtnNew.ImageLarge = Global.Remisiones.My.Resources.Resources.CirculPlus68
        Me.BbtnNew.Name = "BbtnNew"
        Me.BbtnNew.TooltipText = "Nuevo"
        '
        'BubbleButton2
        '
        Me.BubbleButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BubbleButton2.Enabled = False
        Me.BubbleButton2.Name = "BubbleButton2"
        Me.BubbleButton2.Shortcut = DevComponents.DotNetBar.eShortcut.CtrlN
        Me.BubbleButton2.Visible = False
        '
        'BbtnSave
        '
        Me.BbtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BbtnSave.Image = Global.Remisiones.My.Resources.Resources.Save4821
        Me.BbtnSave.ImageLarge = Global.Remisiones.My.Resources.Resources.Save68
        Me.BbtnSave.Name = "BbtnSave"
        Me.BbtnSave.TooltipText = "Guardar"
        '
        'BbtnConect
        '
        Me.BbtnConect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BbtnConect.Image = Global.Remisiones.My.Resources.Resources.conexion48
        Me.BbtnConect.ImageLarge = Global.Remisiones.My.Resources.Resources.conexion68
        Me.BbtnConect.Name = "BbtnConect"
        Me.BbtnConect.TooltipText = "Conectar"
        '
        'BbtnDisConect
        '
        Me.BbtnDisConect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BbtnDisConect.Image = Global.Remisiones.My.Resources.Resources.disconexion48
        Me.BbtnDisConect.ImageLarge = Global.Remisiones.My.Resources.Resources.disconexion681
        Me.BbtnDisConect.Name = "BbtnDisConect"
        Me.BbtnDisConect.TooltipText = "Desconectar"
        '
        'Bbtn
        '
        Me.Bbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bbtn.Image = Global.Remisiones.My.Resources.Resources.Tikect48
        Me.Bbtn.ImageLarge = Global.Remisiones.My.Resources.Resources.Tikect68
        Me.Bbtn.Name = "Bbtn"
        '
        'BubbleButton7
        '
        Me.BubbleButton7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BubbleButton7.Image = Global.Remisiones.My.Resources.Resources.Print48
        Me.BubbleButton7.ImageLarge = Global.Remisiones.My.Resources.Resources.Print68
        Me.BubbleButton7.Name = "BubbleButton7"
        '
        'BubbleButton8
        '
        Me.BubbleButton8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BubbleButton8.Image = Global.Remisiones.My.Resources.Resources.exit48
        Me.BubbleButton8.ImageLarge = Global.Remisiones.My.Resources.Resources.exit68
        Me.BubbleButton8.Name = "BubbleButton8"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
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
        Me.GroupBox5.TabIndex = 240
        Me.GroupBox5.TabStop = False
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
        Me.BtnNuevoRec.TabIndex = 246
        Me.BtnNuevoRec.Text = "Nuevo"
        Me.BtnNuevoRec.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnNuevoRec.UseVisualStyleBackColor = True
        '
        'BtnTikectRec
        '
        Me.BtnTikectRec.FlatAppearance.BorderSize = 0
        Me.BtnTikectRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTikectRec.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTikectRec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnTikectRec.Image = Global.Remisiones.My.Resources.Resources.Tikect48
        Me.BtnTikectRec.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnTikectRec.Location = New System.Drawing.Point(614, 7)
        Me.BtnTikectRec.Name = "BtnTikectRec"
        Me.BtnTikectRec.Size = New System.Drawing.Size(75, 66)
        Me.BtnTikectRec.TabIndex = 252
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
        Me.BtnGuardarRec.Location = New System.Drawing.Point(158, 7)
        Me.BtnGuardarRec.Name = "BtnGuardarRec"
        Me.BtnGuardarRec.Size = New System.Drawing.Size(75, 66)
        Me.BtnGuardarRec.TabIndex = 247
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
        Me.BtnRecpSalir.Location = New System.Drawing.Point(901, 7)
        Me.BtnRecpSalir.Name = "BtnRecpSalir"
        Me.BtnRecpSalir.Size = New System.Drawing.Size(75, 66)
        Me.BtnRecpSalir.TabIndex = 251
        Me.BtnRecpSalir.Text = "Salir"
        Me.BtnRecpSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnRecpSalir.UseVisualStyleBackColor = True
        '
        'BtnDisconectRec
        '
        Me.BtnDisconectRec.FlatAppearance.BorderSize = 0
        Me.BtnDisconectRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDisconectRec.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDisconectRec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnDisconectRec.Image = Global.Remisiones.My.Resources.Resources.disconexion48
        Me.BtnDisconectRec.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnDisconectRec.Location = New System.Drawing.Point(443, 7)
        Me.BtnDisconectRec.Name = "BtnDisconectRec"
        Me.BtnDisconectRec.Size = New System.Drawing.Size(106, 66)
        Me.BtnDisconectRec.TabIndex = 248
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
        Me.BtnImpriRec.Location = New System.Drawing.Point(762, 7)
        Me.BtnImpriRec.Name = "BtnImpriRec"
        Me.BtnImpriRec.Size = New System.Drawing.Size(75, 65)
        Me.BtnImpriRec.TabIndex = 250
        Me.BtnImpriRec.Text = "Imprimir"
        Me.BtnImpriRec.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnImpriRec.UseVisualStyleBackColor = True
        '
        'BtnConectarRec
        '
        Me.BtnConectarRec.FlatAppearance.BorderSize = 0
        Me.BtnConectarRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConectarRec.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConectarRec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnConectarRec.Image = Global.Remisiones.My.Resources.Resources.conexion48
        Me.BtnConectarRec.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnConectarRec.Location = New System.Drawing.Point(309, 7)
        Me.BtnConectarRec.Name = "BtnConectarRec"
        Me.BtnConectarRec.Size = New System.Drawing.Size(75, 66)
        Me.BtnConectarRec.TabIndex = 249
        Me.BtnConectarRec.Text = "Conectar"
        Me.BtnConectarRec.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnConectarRec.UseVisualStyleBackColor = True
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
        'TxtNombreProducto
        '
        Me.TxtNombreProducto.AllowAddNew = True
        Me.TxtNombreProducto.AllowColMove = False
        Me.TxtNombreProducto.AllowDelete = True
        Me.TxtNombreProducto.AlternatingRows = True
        Me.TxtNombreProducto.Caption = "LISTADOS DE PESADAS"
        Me.TxtNombreProducto.CaptionHeight = 17
        Me.TxtNombreProducto.CollapseColor = System.Drawing.Color.DimGray
        Me.TxtNombreProducto.GroupByCaption = "Drag a column header here to group by that column"
        Me.TxtNombreProducto.Images.Add(CType(resources.GetObject("TxtNombreProducto.Images"), System.Drawing.Image))
        Me.TxtNombreProducto.Location = New System.Drawing.Point(4, 41)
        Me.TxtNombreProducto.Name = "TxtNombreProducto"
        Me.TxtNombreProducto.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.TxtNombreProducto.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.TxtNombreProducto.PreviewInfo.ZoomFactor = 75
        Me.TxtNombreProducto.PrintInfo.PageSettings = CType(resources.GetObject("TxtNombreProducto.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.TxtNombreProducto.Size = New System.Drawing.Size(987, 185)
        Me.TxtNombreProducto.TabIndex = 224
        Me.TxtNombreProducto.Text = "C1TrueDBGrid1"
        Me.TxtNombreProducto.PropBag = resources.GetString("TxtNombreProducto.PropBag")
        '
        'CheckMohoso
        '
        Me.CheckMohoso.AutoSize = True
        Me.CheckMohoso.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.CheckMohoso.ForeColor = System.Drawing.Color.White
        Me.CheckMohoso.Location = New System.Drawing.Point(8, 43)
        Me.CheckMohoso.Name = "CheckMohoso"
        Me.CheckMohoso.Size = New System.Drawing.Size(61, 19)
        Me.CheckMohoso.TabIndex = 267
        Me.CheckMohoso.Text = "Moho"
        Me.CheckMohoso.UseVisualStyleBackColor = True
        '
        'CheckFermento
        '
        Me.CheckFermento.AutoSize = True
        Me.CheckFermento.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.CheckFermento.ForeColor = System.Drawing.Color.White
        Me.CheckFermento.Location = New System.Drawing.Point(87, 43)
        Me.CheckFermento.Name = "CheckFermento"
        Me.CheckFermento.Size = New System.Drawing.Size(85, 19)
        Me.CheckFermento.TabIndex = 268
        Me.CheckFermento.Text = "Fermento"
        Me.CheckFermento.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.GroupBox7.Controls.Add(Me.Label13)
        Me.GroupBox7.Controls.Add(Me.CheckMohoso)
        Me.GroupBox7.Controls.Add(Me.CheckFermento)
        Me.GroupBox7.Location = New System.Drawing.Point(810, 523)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(181, 83)
        Me.GroupBox7.TabIndex = 255
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
        Me.Label13.Size = New System.Drawing.Size(180, 17)
        Me.Label13.TabIndex = 273
        Me.Label13.Text = "              Daño             "
        '
        'FrmRecepcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(997, 683)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.LblPeso)
        Me.Controls.Add(Me.CboTipoRecepcion)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.ChkTaraSaco)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TDGImperfeccion)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lbltipo)
        Me.Controls.Add(Me.TxtNombreProducto)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.BtnBuscarCodProv)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRecepcion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nota de peso oficial"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.CboProductor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboRecibimosde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboPlantillo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboFinca, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.CboCalidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboVariedad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboCodigoBodega, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.TDGImperfeccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNombreProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingImperfeccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtNombreProducto As C1.Win.C1TrueDBGrid.C1TrueDBGrid
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
    Friend WithEvents LblPeso As System.Windows.Forms.Label
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
    Friend WithEvents CmdPesada As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CboConductor As C1.Win.C1List.C1Combo
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CboCodigoBodega As C1.Win.C1List.C1Combo
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BubbleBtn As DevComponents.DotNetBar.BubbleBarTab
    Friend WithEvents BbtnNew As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents BubbleButton2 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents BbtnSave As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents BbtnConect As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents BbtnDisConect As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents Bbtn As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents BubbleButton7 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents BubbleButton8 As DevComponents.DotNetBar.BubbleButton
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
    Friend WithEvents CboEstado As C1.Win.C1List.C1Combo
    Friend WithEvents BtnVehiculoAgre As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TxtRemision As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents CboRecibimosde As C1.Win.C1List.C1Combo
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CboProductor As C1.Win.C1List.C1Combo
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TxtCedulaProductor As System.Windows.Forms.TextBox
    Friend WithEvents CboVariedad As C1.Win.C1List.C1Combo
    Friend WithEvents CboCalidad As C1.Win.C1List.C1Combo
    Friend WithEvents BindingImperfeccion As System.Windows.Forms.BindingSource
    Friend WithEvents CheckMohoso As System.Windows.Forms.CheckBox
    Friend WithEvents CheckFermento As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents BtnBsquedaProductor As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtMarca As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
