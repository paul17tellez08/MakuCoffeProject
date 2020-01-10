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
        Me.TxtCodProducto = New System.Windows.Forms.TextBox
        Me.ChkTaraSaco = New System.Windows.Forms.CheckBox
        Me.lbldatosre = New System.Windows.Forms.Label
        Me.DTPFecha = New System.Windows.Forms.Label
        Me.LblHora = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.TxtCodProductor = New System.Windows.Forms.TextBox
        Me.BtnTclCodProv = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.CboPlantillo = New C1.Win.C1List.C1Combo
        Me.CboFinca = New C1.Win.C1List.C1Combo
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtnombre = New System.Windows.Forms.TextBox
        Me.lblnombre = New System.Windows.Forms.Label
        Me.datosprov = New System.Windows.Forms.Label
        Me.lblproveedor = New System.Windows.Forms.Label
        Me.BtnBsquedaProductor = New System.Windows.Forms.Button
        Me.BtnBuscarCodProv = New System.Windows.Forms.GroupBox
        Me.lblbdega = New System.Windows.Forms.Label
        Me.CmbSerie = New C1.Win.C1List.C1Combo
        Me.BtnBuscarRecep = New System.Windows.Forms.Button
        Me.TxtNumeroEnsamble = New System.Windows.Forms.TextBox
        Me.CboTipoRecepcion = New System.Windows.Forms.ComboBox
        Me.LblEstado = New System.Windows.Forms.Label
        Me.lbltipo = New System.Windows.Forms.Label
        Me.LblSucursal = New System.Windows.Forms.Label
        Me.LblPeso = New System.Windows.Forms.Label
        Me.txtsubtotal = New System.Windows.Forms.TextBox
        Me.Eventos = New System.Windows.Forms.GroupBox
        Me.CmdNuevo = New System.Windows.Forms.Button
        Me.Button10 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.txtapellido = New System.Windows.Forms.TextBox
        Me.Button11 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button12 = New System.Windows.Forms.Button
        Me.sp = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtobservaciones = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BtnBusConductor = New System.Windows.Forms.Button
        Me.BtnBusPlaca = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtMarca = New System.Windows.Forms.TextBox
        Me.CboPlaca = New C1.Win.C1List.C1Combo
        Me.Label34 = New System.Windows.Forms.Label
        Me.TxtCedula = New System.Windows.Forms.TextBox
        Me.CboConductor = New C1.Win.C1List.C1Combo
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.CmdPesada = New System.Windows.Forms.Button
        Me.TxtNombreProducto = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.BindingDetalle = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnTclCodProd = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CboDano = New C1.Win.C1List.C1Combo
        Me.CboImperfeccion = New C1.Win.C1List.C1Combo
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.BtnConsProducto = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxtHumedad = New System.Windows.Forms.TextBox
        Me.TxtImperfec = New System.Windows.Forms.TextBox
        Me.CboCodigoBodega = New C1.Win.C1List.C1Combo
        Me.BubbleBtn = New DevComponents.DotNetBar.BubbleBarTab(Me.components)
        Me.BbtnNew = New DevComponents.DotNetBar.BubbleButton
        Me.BubbleButton2 = New DevComponents.DotNetBar.BubbleButton
        Me.BbtnSave = New DevComponents.DotNetBar.BubbleButton
        Me.BbtnConect = New DevComponents.DotNetBar.BubbleButton
        Me.BbtnDisConect = New DevComponents.DotNetBar.BubbleButton
        Me.Bbtn = New DevComponents.DotNetBar.BubbleButton
        Me.BubbleButton7 = New DevComponents.DotNetBar.BubbleButton
        Me.BubbleButton8 = New DevComponents.DotNetBar.BubbleButton
        Me.BtnNuevoRec = New System.Windows.Forms.Button
        Me.BtnGuardarRec = New System.Windows.Forms.Button
        Me.BtnDisconectRec = New System.Windows.Forms.Button
        Me.BtnConectarRec = New System.Windows.Forms.Button
        Me.BtnImpriRec = New System.Windows.Forms.Button
        Me.BtnRecpSalir = New System.Windows.Forms.Button
        Me.BtnTikectRec = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.GroupBox6.SuspendLayout()
        CType(Me.CboPlantillo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboFinca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BtnBuscarCodProv.SuspendLayout()
        CType(Me.CmbSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Eventos.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CboPlaca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboConductor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.TxtNombreProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CboDano, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboImperfeccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboCodigoBodega, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(7, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 15)
        Me.Label7.TabIndex = 248
        Me.Label7.Text = "Nombre producto   :  "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(7, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 15)
        Me.Label6.TabIndex = 182
        Me.Label6.Text = "Cod. de producto   :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(8, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Bodega                   :"
        '
        'TxtCodProducto
        '
        Me.TxtCodProducto.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.TxtCodProducto.Location = New System.Drawing.Point(152, 21)
        Me.TxtCodProducto.Name = "TxtCodProducto"
        Me.TxtCodProducto.Size = New System.Drawing.Size(213, 26)
        Me.TxtCodProducto.TabIndex = 234
        Me.TxtCodProducto.Text = " "
        '
        'ChkTaraSaco
        '
        Me.ChkTaraSaco.AutoSize = True
        Me.ChkTaraSaco.Checked = True
        Me.ChkTaraSaco.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkTaraSaco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ChkTaraSaco.ForeColor = System.Drawing.Color.White
        Me.ChkTaraSaco.Location = New System.Drawing.Point(594, 12)
        Me.ChkTaraSaco.Name = "ChkTaraSaco"
        Me.ChkTaraSaco.Size = New System.Drawing.Size(162, 24)
        Me.ChkTaraSaco.TabIndex = 239
        Me.ChkTaraSaco.Text = "Calcular Tara Saco"
        Me.ChkTaraSaco.UseVisualStyleBackColor = True
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
        Me.GroupBox6.Controls.Add(Me.TxtCodProductor)
        Me.GroupBox6.Controls.Add(Me.BtnTclCodProv)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.CboPlantillo)
        Me.GroupBox6.Controls.Add(Me.CboFinca)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.txtnombre)
        Me.GroupBox6.Controls.Add(Me.lblnombre)
        Me.GroupBox6.Controls.Add(Me.datosprov)
        Me.GroupBox6.Controls.Add(Me.lblproveedor)
        Me.GroupBox6.Controls.Add(Me.BtnBsquedaProductor)
        Me.GroupBox6.Location = New System.Drawing.Point(4, 292)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(385, 146)
        Me.GroupBox6.TabIndex = 222
        Me.GroupBox6.TabStop = False
        '
        'TxtCodProductor
        '
        Me.TxtCodProductor.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.TxtCodProductor.Location = New System.Drawing.Point(94, 24)
        Me.TxtCodProductor.Name = "TxtCodProductor"
        Me.TxtCodProductor.Size = New System.Drawing.Size(195, 26)
        Me.TxtCodProductor.TabIndex = 256
        Me.TxtCodProductor.Text = " "
        '
        'BtnTclCodProv
        '
        Me.BtnTclCodProv.FlatAppearance.BorderSize = 0
        Me.BtnTclCodProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTclCodProv.Image = Global.Remisiones.My.Resources.Resources.Teclado32
        Me.BtnTclCodProv.Location = New System.Drawing.Point(295, 16)
        Me.BtnTclCodProv.Name = "BtnTclCodProv"
        Me.BtnTclCodProv.Size = New System.Drawing.Size(39, 36)
        Me.BtnTclCodProv.TabIndex = 255
        Me.BtnTclCodProv.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(7, 119)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 15)
        Me.Label12.TabIndex = 190
        Me.Label12.Text = "Plantillo :"
        '
        'CboPlantillo
        '
        Me.CboPlantillo.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.CboPlantillo.Caption = ""
        Me.CboPlantillo.CaptionHeight = 17
        Me.CboPlantillo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CboPlantillo.ColumnCaptionHeight = 17
        Me.CboPlantillo.ColumnFooterHeight = 17
        Me.CboPlantillo.ContentHeight = 21
        Me.CboPlantillo.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.CboPlantillo.DisplayMember = "Plantillo"
        Me.CboPlantillo.EditorBackColor = System.Drawing.SystemColors.Window
        Me.CboPlantillo.EditorFont = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.CboPlantillo.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.CboPlantillo.EditorHeight = 21
        Me.CboPlantillo.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.CboPlantillo.Images.Add(CType(resources.GetObject("CboPlantillo.Images"), System.Drawing.Image))
        Me.CboPlantillo.ItemHeight = 15
        Me.CboPlantillo.Location = New System.Drawing.Point(94, 112)
        Me.CboPlantillo.MatchEntryTimeout = CType(2000, Long)
        Me.CboPlantillo.MaxDropDownItems = CType(5, Short)
        Me.CboPlantillo.MaxLength = 32767
        Me.CboPlantillo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CboPlantillo.Name = "CboPlantillo"
        Me.CboPlantillo.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CboPlantillo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.CboPlantillo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CboPlantillo.Size = New System.Drawing.Size(287, 27)
        Me.CboPlantillo.TabIndex = 189
        Me.CboPlantillo.Text = "SELECCIONAR"
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
        Me.CboFinca.ContentHeight = 21
        Me.CboFinca.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.CboFinca.DisplayMember = "NomFinca"
        Me.CboFinca.EditorBackColor = System.Drawing.SystemColors.Window
        Me.CboFinca.EditorFont = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.CboFinca.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.CboFinca.EditorHeight = 21
        Me.CboFinca.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.CboFinca.Images.Add(CType(resources.GetObject("CboFinca.Images"), System.Drawing.Image))
        Me.CboFinca.ItemHeight = 15
        Me.CboFinca.Location = New System.Drawing.Point(94, 81)
        Me.CboFinca.MatchEntryTimeout = CType(2000, Long)
        Me.CboFinca.MaxDropDownItems = CType(5, Short)
        Me.CboFinca.MaxLength = 32767
        Me.CboFinca.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CboFinca.Name = "CboFinca"
        Me.CboFinca.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CboFinca.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.CboFinca.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CboFinca.Size = New System.Drawing.Size(287, 27)
        Me.CboFinca.TabIndex = 188
        Me.CboFinca.Text = "SELECCIONAR"
        Me.CboFinca.ValueMember = "IdFinca"
        Me.CboFinca.PropBag = resources.GetString("CboFinca.PropBag")
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(6, 87)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 15)
        Me.Label11.TabIndex = 187
        Me.Label11.Text = "Finca      :"
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.txtnombre.Location = New System.Drawing.Point(94, 54)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(287, 23)
        Me.txtnombre.TabIndex = 178
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.lblnombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.lblnombre.Location = New System.Drawing.Point(5, 54)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(73, 15)
        Me.lblnombre.TabIndex = 174
        Me.lblnombre.Text = "Nombre  : "
        '
        'datosprov
        '
        Me.datosprov.AutoSize = True
        Me.datosprov.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.datosprov.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.datosprov.Location = New System.Drawing.Point(5, 1)
        Me.datosprov.Name = "datosprov"
        Me.datosprov.Size = New System.Drawing.Size(162, 15)
        Me.datosprov.TabIndex = 25
        Me.datosprov.Text = "DATOS DEL PRODUCTOR"
        '
        'lblproveedor
        '
        Me.lblproveedor.AutoSize = True
        Me.lblproveedor.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.lblproveedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.lblproveedor.Location = New System.Drawing.Point(6, 27)
        Me.lblproveedor.Name = "lblproveedor"
        Me.lblproveedor.Size = New System.Drawing.Size(72, 15)
        Me.lblproveedor.TabIndex = 2
        Me.lblproveedor.Text = "Código   : "
        '
        'BtnBsquedaProductor
        '
        Me.BtnBsquedaProductor.BackColor = System.Drawing.Color.Transparent
        Me.BtnBsquedaProductor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.BtnBsquedaProductor.FlatAppearance.BorderSize = 0
        Me.BtnBsquedaProductor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBsquedaProductor.Image = Global.Remisiones.My.Resources.Resources.Lupa32
        Me.BtnBsquedaProductor.Location = New System.Drawing.Point(337, 16)
        Me.BtnBsquedaProductor.Name = "BtnBsquedaProductor"
        Me.BtnBsquedaProductor.Size = New System.Drawing.Size(39, 36)
        Me.BtnBsquedaProductor.TabIndex = 171
        Me.BtnBsquedaProductor.UseVisualStyleBackColor = False
        '
        'BtnBuscarCodProv
        '
        Me.BtnBuscarCodProv.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BtnBuscarCodProv.Controls.Add(Me.lblbdega)
        Me.BtnBuscarCodProv.Controls.Add(Me.CmbSerie)
        Me.BtnBuscarCodProv.Controls.Add(Me.BtnBuscarRecep)
        Me.BtnBuscarCodProv.Controls.Add(Me.TxtNumeroEnsamble)
        Me.BtnBuscarCodProv.Controls.Add(Me.CboTipoRecepcion)
        Me.BtnBuscarCodProv.Controls.Add(Me.LblEstado)
        Me.BtnBuscarCodProv.Controls.Add(Me.lbltipo)
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
        Me.lblbdega.Location = New System.Drawing.Point(298, 16)
        Me.lblbdega.Name = "lblbdega"
        Me.lblbdega.Size = New System.Drawing.Size(99, 15)
        Me.lblbdega.TabIndex = 12
        Me.lblbdega.Text = "Nº Recepción :"
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
        Me.CmbSerie.Location = New System.Drawing.Point(403, 13)
        Me.CmbSerie.MatchEntryTimeout = CType(2000, Long)
        Me.CmbSerie.MaxDropDownItems = CType(5, Short)
        Me.CmbSerie.MaxLength = 32767
        Me.CmbSerie.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CmbSerie.Name = "CmbSerie"
        Me.CmbSerie.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CmbSerie.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.CmbSerie.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CmbSerie.Size = New System.Drawing.Size(72, 21)
        Me.CmbSerie.TabIndex = 212
        Me.CmbSerie.Visible = False
        Me.CmbSerie.PropBag = resources.GetString("CmbSerie.PropBag")
        '
        'BtnBuscarRecep
        '
        Me.BtnBuscarRecep.FlatAppearance.BorderSize = 0
        Me.BtnBuscarRecep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscarRecep.Image = Global.Remisiones.My.Resources.Resources.Lupa321
        Me.BtnBuscarRecep.Location = New System.Drawing.Point(598, 8)
        Me.BtnBuscarRecep.Name = "BtnBuscarRecep"
        Me.BtnBuscarRecep.Size = New System.Drawing.Size(36, 30)
        Me.BtnBuscarRecep.TabIndex = 180
        Me.BtnBuscarRecep.UseVisualStyleBackColor = True
        '
        'TxtNumeroEnsamble
        '
        Me.TxtNumeroEnsamble.Enabled = False
        Me.TxtNumeroEnsamble.Location = New System.Drawing.Point(484, 13)
        Me.TxtNumeroEnsamble.Name = "TxtNumeroEnsamble"
        Me.TxtNumeroEnsamble.Size = New System.Drawing.Size(103, 20)
        Me.TxtNumeroEnsamble.TabIndex = 177
        Me.TxtNumeroEnsamble.Text = "- - - - - 0 - - - - - "
        Me.TxtNumeroEnsamble.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CboTipoRecepcion
        '
        Me.CboTipoRecepcion.BackColor = System.Drawing.Color.White
        Me.CboTipoRecepcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoRecepcion.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.CboTipoRecepcion.FormattingEnabled = True
        Me.CboTipoRecepcion.Items.AddRange(New Object() {"PESADA MANUAL", "PESADA AUTOMATICA"})
        Me.CboTipoRecepcion.Location = New System.Drawing.Point(101, 12)
        Me.CboTipoRecepcion.Name = "CboTipoRecepcion"
        Me.CboTipoRecepcion.Size = New System.Drawing.Size(188, 23)
        Me.CboTipoRecepcion.TabIndex = 179
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
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.lbltipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.lbltipo.Location = New System.Drawing.Point(6, 16)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(94, 15)
        Me.lbltipo.TabIndex = 25
        Me.lbltipo.Text = "Tipo Ingreso :"
        '
        'LblSucursal
        '
        Me.LblSucursal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblSucursal.AutoSize = True
        Me.LblSucursal.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.LblSucursal.ForeColor = System.Drawing.Color.White
        Me.LblSucursal.Location = New System.Drawing.Point(37, 1)
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
        Me.LblPeso.Location = New System.Drawing.Point(773, 12)
        Me.LblPeso.Name = "LblPeso"
        Me.LblPeso.Size = New System.Drawing.Size(49, 24)
        Me.LblPeso.TabIndex = 228
        Me.LblPeso.Text = "0.00"
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
        'Eventos
        '
        Me.Eventos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Eventos.Controls.Add(Me.CmdNuevo)
        Me.Eventos.Controls.Add(Me.Button10)
        Me.Eventos.Controls.Add(Me.Button9)
        Me.Eventos.Controls.Add(Me.Button7)
        Me.Eventos.Controls.Add(Me.txtapellido)
        Me.Eventos.Controls.Add(Me.Button11)
        Me.Eventos.Controls.Add(Me.Button4)
        Me.Eventos.Controls.Add(Me.Button12)
        Me.Eventos.Location = New System.Drawing.Point(997, 2)
        Me.Eventos.Name = "Eventos"
        Me.Eventos.Size = New System.Drawing.Size(90, 10)
        Me.Eventos.TabIndex = 229
        Me.Eventos.TabStop = False
        Me.Eventos.Visible = False
        '
        'CmdNuevo
        '
        Me.CmdNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.CmdNuevo.Image = CType(resources.GetObject("CmdNuevo.Image"), System.Drawing.Image)
        Me.CmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdNuevo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CmdNuevo.Location = New System.Drawing.Point(13, 14)
        Me.CmdNuevo.Name = "CmdNuevo"
        Me.CmdNuevo.Size = New System.Drawing.Size(114, 56)
        Me.CmdNuevo.TabIndex = 229
        Me.CmdNuevo.Text = "Nuevo"
        Me.CmdNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdNuevo.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Image = CType(resources.GetObject("Button10.Image"), System.Drawing.Image)
        Me.Button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button10.Location = New System.Drawing.Point(13, 197)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(114, 56)
        Me.Button10.TabIndex = 215
        Me.Button10.Text = "Des-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Conectar"
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Image = CType(resources.GetObject("Button9.Image"), System.Drawing.Image)
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.Location = New System.Drawing.Point(15, 456)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(114, 55)
        Me.Button9.TabIndex = 231
        Me.Button9.Text = "Salir"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(13, 73)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(114, 56)
        Me.Button7.TabIndex = 179
        Me.Button7.Text = "Grabar"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.UseVisualStyleBackColor = True
        '
        'txtapellido
        '
        Me.txtapellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapellido.Location = New System.Drawing.Point(0, 402)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(136, 24)
        Me.txtapellido.TabIndex = 185
        Me.txtapellido.Visible = False
        '
        'Button11
        '
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Image = CType(resources.GetObject("Button11.Image"), System.Drawing.Image)
        Me.Button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button11.Location = New System.Drawing.Point(13, 135)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(114, 56)
        Me.Button11.TabIndex = 214
        Me.Button11.Text = "Conectar"
        Me.Button11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(14, 341)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(114, 55)
        Me.Button4.TabIndex = 230
        Me.Button4.Text = "Reporte"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'Button12
        '
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Image = CType(resources.GetObject("Button12.Image"), System.Drawing.Image)
        Me.Button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button12.Location = New System.Drawing.Point(13, 265)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(114, 57)
        Me.Button12.TabIndex = 232
        Me.Button12.Text = "Ticket"
        Me.Button12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button12.UseVisualStyleBackColor = True
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
        Me.txtobservaciones.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.txtobservaciones.Location = New System.Drawing.Point(152, 175)
        Me.txtobservaciones.Multiline = True
        Me.txtobservaciones.Name = "txtobservaciones"
        Me.txtobservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtobservaciones.Size = New System.Drawing.Size(387, 79)
        Me.txtobservaciones.TabIndex = 183
        Me.txtobservaciones.Text = " "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(7, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 15)
        Me.Label1.TabIndex = 184
        Me.Label1.Text = "Observación           :"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.BtnBusConductor)
        Me.GroupBox2.Controls.Add(Me.BtnBusPlaca)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TxtMarca)
        Me.GroupBox2.Controls.Add(Me.CboPlaca)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.Controls.Add(Me.TxtCedula)
        Me.GroupBox2.Controls.Add(Me.CboConductor)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 441)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(384, 154)
        Me.GroupBox2.TabIndex = 237
        Me.GroupBox2.TabStop = False
        '
        'BtnBusConductor
        '
        Me.BtnBusConductor.FlatAppearance.BorderSize = 0
        Me.BtnBusConductor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBusConductor.Image = Global.Remisiones.My.Resources.Resources.Lupa321
        Me.BtnBusConductor.Location = New System.Drawing.Point(337, 82)
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
        Me.BtnBusPlaca.Location = New System.Drawing.Point(339, 19)
        Me.BtnBusPlaca.Name = "BtnBusPlaca"
        Me.BtnBusPlaca.Size = New System.Drawing.Size(36, 30)
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
        Me.Label8.Size = New System.Drawing.Size(155, 15)
        Me.Label8.TabIndex = 246
        Me.Label8.Text = "DETALLES TRANSPORTE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(6, 59)
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
        Me.Label3.Location = New System.Drawing.Point(6, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 15)
        Me.Label3.TabIndex = 247
        Me.Label3.Text = "Placa         :"
        '
        'TxtMarca
        '
        Me.TxtMarca.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMarca.Location = New System.Drawing.Point(93, 53)
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.Size = New System.Drawing.Size(282, 26)
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
        Me.CboPlaca.ContentHeight = 21
        Me.CboPlaca.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.CboPlaca.DisplayMember = "Placa"
        Me.CboPlaca.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.CboPlaca.DropDownWidth = 185
        Me.CboPlaca.EditorBackColor = System.Drawing.SystemColors.Window
        Me.CboPlaca.EditorFont = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.CboPlaca.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.CboPlaca.EditorHeight = 21
        Me.CboPlaca.Images.Add(CType(resources.GetObject("CboPlaca.Images"), System.Drawing.Image))
        Me.CboPlaca.ItemHeight = 35
        Me.CboPlaca.Location = New System.Drawing.Point(93, 21)
        Me.CboPlaca.MatchEntryTimeout = CType(2000, Long)
        Me.CboPlaca.MaxDropDownItems = CType(5, Short)
        Me.CboPlaca.MaximumSize = New System.Drawing.Size(300, 100)
        Me.CboPlaca.MaxLength = 32767
        Me.CboPlaca.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CboPlaca.Name = "CboPlaca"
        Me.CboPlaca.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CboPlaca.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.CboPlaca.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CboPlaca.Size = New System.Drawing.Size(240, 27)
        Me.CboPlaca.TabIndex = 243
        Me.CboPlaca.ValueMember = "IdVehiculo"
        Me.CboPlaca.PropBag = resources.GetString("CboPlaca.PropBag")
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label34.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label34.Location = New System.Drawing.Point(5, 121)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(82, 15)
        Me.Label34.TabIndex = 242
        Me.Label34.Text = "Cedula       :"
        '
        'TxtCedula
        '
        Me.TxtCedula.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.TxtCedula.Location = New System.Drawing.Point(93, 116)
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(282, 26)
        Me.TxtCedula.TabIndex = 241
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
        Me.CboConductor.ContentHeight = 21
        Me.CboConductor.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.CboConductor.DisplayMember = "Nombre"
        Me.CboConductor.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.CboConductor.DropDownWidth = 275
        Me.CboConductor.EditorBackColor = System.Drawing.SystemColors.Window
        Me.CboConductor.EditorFont = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.CboConductor.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.CboConductor.EditorHeight = 21
        Me.CboConductor.Images.Add(CType(resources.GetObject("CboConductor.Images"), System.Drawing.Image))
        Me.CboConductor.ItemHeight = 35
        Me.CboConductor.Location = New System.Drawing.Point(93, 84)
        Me.CboConductor.MatchEntryTimeout = CType(2000, Long)
        Me.CboConductor.MaxDropDownItems = CType(5, Short)
        Me.CboConductor.MaxLength = 32767
        Me.CboConductor.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CboConductor.Name = "CboConductor"
        Me.CboConductor.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CboConductor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.CboConductor.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CboConductor.Size = New System.Drawing.Size(240, 27)
        Me.CboConductor.TabIndex = 240
        Me.CboConductor.ValueMember = "Codigo"
        Me.CboConductor.PropBag = resources.GetString("CboConductor.PropBag")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(5, 91)
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
        Me.GroupBox4.Controls.Add(Me.Button6)
        Me.GroupBox4.Controls.Add(Me.LblPeso)
        Me.GroupBox4.Controls.Add(Me.txtsubtotal)
        Me.GroupBox4.Controls.Add(Me.ChkTaraSaco)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 246)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(988, 42)
        Me.GroupBox4.TabIndex = 224
        Me.GroupBox4.TabStop = False
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
        'CmdPesada
        '
        Me.CmdPesada.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdPesada.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CmdPesada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdPesada.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPesada.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.CmdPesada.Image = Global.Remisiones.My.Resources.Resources.Pesaje32
        Me.CmdPesada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdPesada.Location = New System.Drawing.Point(152, 258)
        Me.CmdPesada.Name = "CmdPesada"
        Me.CmdPesada.Size = New System.Drawing.Size(387, 38)
        Me.CmdPesada.TabIndex = 245
        Me.CmdPesada.Text = " PESADA"
        Me.CmdPesada.UseVisualStyleBackColor = True
        '
        'TxtNombreProducto
        '
        Me.TxtNombreProducto.AllowAddNew = True
        Me.TxtNombreProducto.AllowColMove = False
        Me.TxtNombreProducto.AllowDelete = True
        Me.TxtNombreProducto.AlternatingRows = True
        Me.TxtNombreProducto.Caption = "LISTADOS DE PRODUCTOS"
        Me.TxtNombreProducto.CaptionHeight = 20
        Me.TxtNombreProducto.CollapseColor = System.Drawing.Color.DimGray
        Me.TxtNombreProducto.GroupByCaption = "Drag a column header here to group by that column"
        Me.TxtNombreProducto.Images.Add(CType(resources.GetObject("TxtNombreProducto.Images"), System.Drawing.Image))
        Me.TxtNombreProducto.Location = New System.Drawing.Point(4, 41)
        Me.TxtNombreProducto.Name = "TxtNombreProducto"
        Me.TxtNombreProducto.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.TxtNombreProducto.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.TxtNombreProducto.PreviewInfo.ZoomFactor = 75
        Me.TxtNombreProducto.PrintInfo.PageSettings = CType(resources.GetObject("TxtNombreProducto.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.TxtNombreProducto.Size = New System.Drawing.Size(987, 205)
        Me.TxtNombreProducto.TabIndex = 224
        Me.TxtNombreProducto.Text = "C1TrueDBGrid1"
        Me.TxtNombreProducto.PropBag = resources.GetString("TxtNombreProducto.PropBag")
        '
        'BtnTclCodProd
        '
        Me.BtnTclCodProd.FlatAppearance.BorderSize = 0
        Me.BtnTclCodProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTclCodProd.Image = Global.Remisiones.My.Resources.Resources.Teclado32
        Me.BtnTclCodProd.Location = New System.Drawing.Point(371, 13)
        Me.BtnTclCodProd.Name = "BtnTclCodProd"
        Me.BtnTclCodProd.Size = New System.Drawing.Size(39, 36)
        Me.BtnTclCodProd.TabIndex = 185
        Me.BtnTclCodProd.Text = " "
        Me.BtnTclCodProd.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.CboDano)
        Me.GroupBox1.Controls.Add(Me.CboImperfeccion)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.BtnConsProducto)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TxtHumedad)
        Me.GroupBox1.Controls.Add(Me.TxtImperfec)
        Me.GroupBox1.Controls.Add(Me.CboCodigoBodega)
        Me.GroupBox1.Controls.Add(Me.BtnTclCodProd)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.LblSucursal)
        Me.GroupBox1.Controls.Add(Me.CmdPesada)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtobservaciones)
        Me.GroupBox1.Controls.Add(Me.TxtCodProducto)
        Me.GroupBox1.Location = New System.Drawing.Point(395, 293)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(596, 302)
        Me.GroupBox1.TabIndex = 240
        Me.GroupBox1.TabStop = False
        '
        'CboDano
        '
        Me.CboDano.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.CboDano.Caption = ""
        Me.CboDano.CaptionHeight = 17
        Me.CboDano.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CboDano.ColumnCaptionHeight = 17
        Me.CboDano.ColumnFooterHeight = 17
        Me.CboDano.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.CboDano.ContentHeight = 21
        Me.CboDano.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.CboDano.DisplayMember = "Dano"
        Me.CboDano.EditorBackColor = System.Drawing.SystemColors.Window
        Me.CboDano.EditorFont = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.CboDano.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.CboDano.EditorHeight = 21
        Me.CboDano.Images.Add(CType(resources.GetObject("CboDano.Images"), System.Drawing.Image))
        Me.CboDano.ItemHeight = 15
        Me.CboDano.Location = New System.Drawing.Point(389, 144)
        Me.CboDano.MatchEntryTimeout = CType(2000, Long)
        Me.CboDano.MaxDropDownItems = CType(5, Short)
        Me.CboDano.MaxLength = 32767
        Me.CboDano.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CboDano.Name = "CboDano"
        Me.CboDano.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CboDano.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.CboDano.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CboDano.Size = New System.Drawing.Size(150, 27)
        Me.CboDano.TabIndex = 264
        Me.CboDano.ValueMember = "IdDano"
        Me.CboDano.PropBag = resources.GetString("CboDano.PropBag")
        '
        'CboImperfeccion
        '
        Me.CboImperfeccion.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.CboImperfeccion.Caption = ""
        Me.CboImperfeccion.CaptionHeight = 17
        Me.CboImperfeccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CboImperfeccion.ColumnCaptionHeight = 17
        Me.CboImperfeccion.ColumnFooterHeight = 17
        Me.CboImperfeccion.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.CboImperfeccion.ContentHeight = 21
        Me.CboImperfeccion.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.CboImperfeccion.DisplayMember = "Imperfeccion"
        Me.CboImperfeccion.EditorBackColor = System.Drawing.SystemColors.Window
        Me.CboImperfeccion.EditorFont = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.CboImperfeccion.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.CboImperfeccion.EditorHeight = 21
        Me.CboImperfeccion.Images.Add(CType(resources.GetObject("CboImperfeccion.Images"), System.Drawing.Image))
        Me.CboImperfeccion.ItemHeight = 15
        Me.CboImperfeccion.Location = New System.Drawing.Point(389, 112)
        Me.CboImperfeccion.MatchEntryTimeout = CType(2000, Long)
        Me.CboImperfeccion.MaxDropDownItems = CType(5, Short)
        Me.CboImperfeccion.MaxLength = 32767
        Me.CboImperfeccion.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CboImperfeccion.Name = "CboImperfeccion"
        Me.CboImperfeccion.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CboImperfeccion.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.CboImperfeccion.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CboImperfeccion.Size = New System.Drawing.Size(150, 27)
        Me.CboImperfeccion.TabIndex = 263
        Me.CboImperfeccion.ValueMember = "IdImperfeccion"
        Me.CboImperfeccion.PropBag = resources.GetString("CboImperfeccion.PropBag")
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(152, 51)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(387, 26)
        Me.TextBox3.TabIndex = 260
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(284, 152)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 15)
        Me.Label13.TabIndex = 259
        Me.Label13.Text = "Daño              :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(282, 118)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(101, 15)
        Me.Label14.TabIndex = 258
        Me.Label14.Text = "Imperfección  :"
        '
        'BtnConsProducto
        '
        Me.BtnConsProducto.FlatAppearance.BorderSize = 0
        Me.BtnConsProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConsProducto.Image = Global.Remisiones.My.Resources.Resources.Lupa321
        Me.BtnConsProducto.Location = New System.Drawing.Point(414, 13)
        Me.BtnConsProducto.Name = "BtnConsProducto"
        Me.BtnConsProducto.Size = New System.Drawing.Size(39, 36)
        Me.BtnConsProducto.TabIndex = 255
        Me.BtnConsProducto.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(10, 150)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(130, 15)
        Me.Label10.TabIndex = 254
        Me.Label10.Text = "% Imperfección      :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(9, 118)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 15)
        Me.Label9.TabIndex = 253
        Me.Label9.Text = "% Humedad            :"
        '
        'TxtHumedad
        '
        Me.TxtHumedad.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.TxtHumedad.Location = New System.Drawing.Point(152, 114)
        Me.TxtHumedad.Name = "TxtHumedad"
        Me.TxtHumedad.Size = New System.Drawing.Size(115, 26)
        Me.TxtHumedad.TabIndex = 252
        Me.TxtHumedad.Text = " 0.00"
        '
        'TxtImperfec
        '
        Me.TxtImperfec.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.TxtImperfec.Location = New System.Drawing.Point(152, 144)
        Me.TxtImperfec.Name = "TxtImperfec"
        Me.TxtImperfec.Size = New System.Drawing.Size(115, 26)
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
        Me.CboCodigoBodega.ContentHeight = 21
        Me.CboCodigoBodega.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.CboCodigoBodega.DisplayMember = "Nombre_Bodega"
        Me.CboCodigoBodega.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.CboCodigoBodega.DropDownWidth = 185
        Me.CboCodigoBodega.EditorBackColor = System.Drawing.SystemColors.Window
        Me.CboCodigoBodega.EditorFont = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.CboCodigoBodega.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.CboCodigoBodega.EditorHeight = 21
        Me.CboCodigoBodega.Images.Add(CType(resources.GetObject("CboCodigoBodega.Images"), System.Drawing.Image))
        Me.CboCodigoBodega.ItemHeight = 35
        Me.CboCodigoBodega.Location = New System.Drawing.Point(152, 82)
        Me.CboCodigoBodega.MatchEntryTimeout = CType(2000, Long)
        Me.CboCodigoBodega.MaxDropDownItems = CType(5, Short)
        Me.CboCodigoBodega.MaxLength = 32767
        Me.CboCodigoBodega.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CboCodigoBodega.Name = "CboCodigoBodega"
        Me.CboCodigoBodega.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CboCodigoBodega.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.CboCodigoBodega.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CboCodigoBodega.Size = New System.Drawing.Size(387, 27)
        Me.CboCodigoBodega.TabIndex = 250
        Me.CboCodigoBodega.Text = " "
        Me.CboCodigoBodega.ValueMember = "Cod_Bodega"
        Me.CboCodigoBodega.PropBag = resources.GetString("CboCodigoBodega.PropBag")
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
        'BtnNuevoRec
        '
        Me.BtnNuevoRec.FlatAppearance.BorderSize = 0
        Me.BtnNuevoRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevoRec.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevoRec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnNuevoRec.Image = Global.Remisiones.My.Resources.Resources.CirculoPlus48
        Me.BtnNuevoRec.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnNuevoRec.Location = New System.Drawing.Point(8, 12)
        Me.BtnNuevoRec.Name = "BtnNuevoRec"
        Me.BtnNuevoRec.Size = New System.Drawing.Size(75, 67)
        Me.BtnNuevoRec.TabIndex = 246
        Me.BtnNuevoRec.Text = "Nuevo"
        Me.BtnNuevoRec.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnNuevoRec.UseVisualStyleBackColor = True
        '
        'BtnGuardarRec
        '
        Me.BtnGuardarRec.FlatAppearance.BorderSize = 0
        Me.BtnGuardarRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardarRec.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardarRec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnGuardarRec.Image = Global.Remisiones.My.Resources.Resources.Save4811
        Me.BtnGuardarRec.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnGuardarRec.Location = New System.Drawing.Point(158, 12)
        Me.BtnGuardarRec.Name = "BtnGuardarRec"
        Me.BtnGuardarRec.Size = New System.Drawing.Size(75, 67)
        Me.BtnGuardarRec.TabIndex = 247
        Me.BtnGuardarRec.Text = "Guardar"
        Me.BtnGuardarRec.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnGuardarRec.UseVisualStyleBackColor = True
        '
        'BtnDisconectRec
        '
        Me.BtnDisconectRec.FlatAppearance.BorderSize = 0
        Me.BtnDisconectRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDisconectRec.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDisconectRec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnDisconectRec.Image = Global.Remisiones.My.Resources.Resources.disconexion48
        Me.BtnDisconectRec.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnDisconectRec.Location = New System.Drawing.Point(443, 13)
        Me.BtnDisconectRec.Name = "BtnDisconectRec"
        Me.BtnDisconectRec.Size = New System.Drawing.Size(106, 67)
        Me.BtnDisconectRec.TabIndex = 248
        Me.BtnDisconectRec.Text = "Desconectar"
        Me.BtnDisconectRec.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnDisconectRec.UseVisualStyleBackColor = True
        '
        'BtnConectarRec
        '
        Me.BtnConectarRec.FlatAppearance.BorderSize = 0
        Me.BtnConectarRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConectarRec.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConectarRec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnConectarRec.Image = Global.Remisiones.My.Resources.Resources.conexion48
        Me.BtnConectarRec.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnConectarRec.Location = New System.Drawing.Point(309, 12)
        Me.BtnConectarRec.Name = "BtnConectarRec"
        Me.BtnConectarRec.Size = New System.Drawing.Size(75, 67)
        Me.BtnConectarRec.TabIndex = 249
        Me.BtnConectarRec.Text = "Conectar"
        Me.BtnConectarRec.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnConectarRec.UseVisualStyleBackColor = True
        '
        'BtnImpriRec
        '
        Me.BtnImpriRec.FlatAppearance.BorderSize = 0
        Me.BtnImpriRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnImpriRec.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImpriRec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnImpriRec.Image = Global.Remisiones.My.Resources.Resources.Print48
        Me.BtnImpriRec.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnImpriRec.Location = New System.Drawing.Point(762, 11)
        Me.BtnImpriRec.Name = "BtnImpriRec"
        Me.BtnImpriRec.Size = New System.Drawing.Size(75, 67)
        Me.BtnImpriRec.TabIndex = 250
        Me.BtnImpriRec.Text = "Imprimir"
        Me.BtnImpriRec.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnImpriRec.UseVisualStyleBackColor = True
        '
        'BtnRecpSalir
        '
        Me.BtnRecpSalir.FlatAppearance.BorderSize = 0
        Me.BtnRecpSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRecpSalir.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRecpSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnRecpSalir.Image = Global.Remisiones.My.Resources.Resources.exit48
        Me.BtnRecpSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnRecpSalir.Location = New System.Drawing.Point(901, 12)
        Me.BtnRecpSalir.Name = "BtnRecpSalir"
        Me.BtnRecpSalir.Size = New System.Drawing.Size(75, 67)
        Me.BtnRecpSalir.TabIndex = 251
        Me.BtnRecpSalir.Text = "Salir"
        Me.BtnRecpSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnRecpSalir.UseVisualStyleBackColor = True
        '
        'BtnTikectRec
        '
        Me.BtnTikectRec.FlatAppearance.BorderSize = 0
        Me.BtnTikectRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTikectRec.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTikectRec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnTikectRec.Image = Global.Remisiones.My.Resources.Resources.Tikect48
        Me.BtnTikectRec.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnTikectRec.Location = New System.Drawing.Point(614, 12)
        Me.BtnTikectRec.Name = "BtnTikectRec"
        Me.BtnTikectRec.Size = New System.Drawing.Size(75, 67)
        Me.BtnTikectRec.TabIndex = 252
        Me.BtnTikectRec.Text = "Ticket"
        Me.BtnTikectRec.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnTikectRec.UseVisualStyleBackColor = True
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
        Me.GroupBox5.Location = New System.Drawing.Point(5, 595)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(986, 84)
        Me.GroupBox5.TabIndex = 240
        Me.GroupBox5.TabStop = False
        '
        'FrmRecepcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(998, 682)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Eventos)
        Me.Controls.Add(Me.TxtNombreProducto)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.BtnBuscarCodProv)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRecepcion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recepción"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.CboPlantillo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboFinca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BtnBuscarCodProv.ResumeLayout(False)
        Me.BtnBuscarCodProv.PerformLayout()
        CType(Me.CmbSerie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Eventos.ResumeLayout(False)
        Me.Eventos.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.CboPlaca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboConductor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.TxtNombreProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CboDano, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboImperfeccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboCodigoBodega, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtNombreProducto As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents lbldatosre As System.Windows.Forms.Label
    Friend WithEvents DTPFecha As System.Windows.Forms.Label
    Friend WithEvents LblHora As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents datosprov As System.Windows.Forms.Label
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents lblnombre As System.Windows.Forms.Label
    Friend WithEvents lblproveedor As System.Windows.Forms.Label
    Friend WithEvents BtnBsquedaProductor As System.Windows.Forms.Button
    Friend WithEvents BtnBuscarCodProv As System.Windows.Forms.GroupBox
    Friend WithEvents BtnBuscarRecep As System.Windows.Forms.Button
    Friend WithEvents TxtNumeroEnsamble As System.Windows.Forms.TextBox
    Friend WithEvents CboTipoRecepcion As System.Windows.Forms.ComboBox
    Friend WithEvents lbltipo As System.Windows.Forms.Label
    Friend WithEvents lblbdega As System.Windows.Forms.Label
    Friend WithEvents LblPeso As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents txtsubtotal As System.Windows.Forms.TextBox
    Friend WithEvents Eventos As System.Windows.Forms.GroupBox
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents CmdNuevo As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents BindingDetalle As System.Windows.Forms.BindingSource
    Friend WithEvents sp As System.IO.Ports.SerialPort
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtobservaciones As System.Windows.Forms.TextBox
    Friend WithEvents TxtCodProducto As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents TxtCedula As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtMarca As System.Windows.Forms.TextBox
    Friend WithEvents CboPlaca As C1.Win.C1List.C1Combo
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LblEstado As System.Windows.Forms.Label
    Friend WithEvents txtapellido As System.Windows.Forms.TextBox
    Friend WithEvents ChkTaraSaco As System.Windows.Forms.CheckBox
    Friend WithEvents CmbSerie As C1.Win.C1List.C1Combo
    Friend WithEvents CmdPesada As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnTclCodProd As System.Windows.Forms.Button
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
    Friend WithEvents BtnTclCodProv As System.Windows.Forms.Button
    Public WithEvents LblSucursal As System.Windows.Forms.Label
    Friend WithEvents BtnBusConductor As System.Windows.Forms.Button
    Friend WithEvents BtnBusPlaca As System.Windows.Forms.Button
    Friend WithEvents BtnConsProducto As System.Windows.Forms.Button
    Friend WithEvents TxtCodProductor As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents CboDano As C1.Win.C1List.C1Combo
    Friend WithEvents CboImperfeccion As C1.Win.C1List.C1Combo
End Class
