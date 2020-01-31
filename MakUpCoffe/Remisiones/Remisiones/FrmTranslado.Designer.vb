<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTranslado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTranslado))
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CboBodegaDestino = New System.Windows.Forms.ComboBox
        Me.CboBodegaOrigen = New System.Windows.Forms.ComboBox
        Me.GbinfoNota = New System.Windows.Forms.GroupBox
        Me.LblFechaHora = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.LblTotalSaco = New System.Windows.Forms.Label
        Me.LblPesoNeto = New System.Windows.Forms.Label
        Me.LblEstado = New System.Windows.Forms.Label
        Me.LblTara = New System.Windows.Forms.Label
        Me.LblPesoBruto = New System.Windows.Forms.Label
        Me.LblVariedad = New System.Windows.Forms.Label
        Me.LblCalidad = New System.Windows.Forms.Label
        Me.LblCodigo = New System.Windows.Forms.Label
        Me.LblPorcunetade = New System.Windows.Forms.Label
        Me.LblRecibimosde = New System.Windows.Forms.Label
        Me.LblCedulaConductor = New System.Windows.Forms.Label
        Me.LblConductor = New System.Windows.Forms.Label
        Me.LblModelo = New System.Windows.Forms.Label
        Me.LblPlaca = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblbdega = New System.Windows.Forms.Label
        Me.TxtNumeroEnsamble = New System.Windows.Forms.TextBox
        Me.GbEncabezado = New System.Windows.Forms.GroupBox
        Me.BtnConsulta = New System.Windows.Forms.Button
        Me.DTPFecha = New System.Windows.Forms.Label
        Me.LblHora = New System.Windows.Forms.Label
        Me.GbCamaInfo = New System.Windows.Forms.GroupBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.TxtNivelActual = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.CmbNivel = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxtPesoTransladar = New System.Windows.Forms.TextBox
        Me.CboCama = New C1.Win.C1List.C1Combo
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.BtnNuevoRec = New System.Windows.Forms.Button
        Me.BtnEnviarPatio = New System.Windows.Forms.Button
        Me.BtnRecpSalir = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GbinfoNota.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GbEncabezado.SuspendLayout()
        Me.GbCamaInfo.SuspendLayout()
        CType(Me.CboCama, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(373, 11)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(113, 15)
        Me.Label15.TabIndex = 266
        Me.Label15.Text = "Bodega Destino :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(23, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 15)
        Me.Label1.TabIndex = 267
        Me.Label1.Text = "Bodega Origen :"
        '
        'CboBodegaDestino
        '
        Me.CboBodegaDestino.BackColor = System.Drawing.Color.White
        Me.CboBodegaDestino.DisplayMember = "Nombre_Bodega"
        Me.CboBodegaDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboBodegaDestino.Enabled = False
        Me.CboBodegaDestino.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.CboBodegaDestino.FormattingEnabled = True
        Me.CboBodegaDestino.Items.AddRange(New Object() {"PESADA BASCULA", "PESADA MANUAL"})
        Me.CboBodegaDestino.Location = New System.Drawing.Point(376, 30)
        Me.CboBodegaDestino.Name = "CboBodegaDestino"
        Me.CboBodegaDestino.Size = New System.Drawing.Size(214, 23)
        Me.CboBodegaDestino.TabIndex = 268
        Me.CboBodegaDestino.ValueMember = "Cod_Bodega"
        '
        'CboBodegaOrigen
        '
        Me.CboBodegaOrigen.BackColor = System.Drawing.Color.White
        Me.CboBodegaOrigen.DisplayMember = "Nombre_Bodega"
        Me.CboBodegaOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboBodegaOrigen.Enabled = False
        Me.CboBodegaOrigen.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.CboBodegaOrigen.FormattingEnabled = True
        Me.CboBodegaOrigen.Items.AddRange(New Object() {"PESADA BASCULA", "PESADA MANUAL"})
        Me.CboBodegaOrigen.Location = New System.Drawing.Point(26, 29)
        Me.CboBodegaOrigen.Name = "CboBodegaOrigen"
        Me.CboBodegaOrigen.Size = New System.Drawing.Size(214, 23)
        Me.CboBodegaOrigen.TabIndex = 269
        Me.CboBodegaOrigen.ValueMember = "Cod_Bodega"
        '
        'GbinfoNota
        '
        Me.GbinfoNota.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.GbinfoNota.Controls.Add(Me.LblFechaHora)
        Me.GbinfoNota.Controls.Add(Me.Label21)
        Me.GbinfoNota.Controls.Add(Me.LblTotalSaco)
        Me.GbinfoNota.Controls.Add(Me.LblPesoNeto)
        Me.GbinfoNota.Controls.Add(Me.LblEstado)
        Me.GbinfoNota.Controls.Add(Me.LblTara)
        Me.GbinfoNota.Controls.Add(Me.LblPesoBruto)
        Me.GbinfoNota.Controls.Add(Me.LblVariedad)
        Me.GbinfoNota.Controls.Add(Me.LblCalidad)
        Me.GbinfoNota.Controls.Add(Me.LblCodigo)
        Me.GbinfoNota.Controls.Add(Me.LblPorcunetade)
        Me.GbinfoNota.Controls.Add(Me.LblRecibimosde)
        Me.GbinfoNota.Controls.Add(Me.LblCedulaConductor)
        Me.GbinfoNota.Controls.Add(Me.LblConductor)
        Me.GbinfoNota.Controls.Add(Me.LblModelo)
        Me.GbinfoNota.Controls.Add(Me.LblPlaca)
        Me.GbinfoNota.Controls.Add(Me.Label14)
        Me.GbinfoNota.Controls.Add(Me.Label16)
        Me.GbinfoNota.Controls.Add(Me.Label17)
        Me.GbinfoNota.Controls.Add(Me.Label18)
        Me.GbinfoNota.Controls.Add(Me.Label19)
        Me.GbinfoNota.Controls.Add(Me.Label13)
        Me.GbinfoNota.Controls.Add(Me.Label12)
        Me.GbinfoNota.Controls.Add(Me.Label11)
        Me.GbinfoNota.Controls.Add(Me.Label10)
        Me.GbinfoNota.Controls.Add(Me.Label8)
        Me.GbinfoNota.Controls.Add(Me.Label7)
        Me.GbinfoNota.Controls.Add(Me.Label6)
        Me.GbinfoNota.Controls.Add(Me.Label5)
        Me.GbinfoNota.Controls.Add(Me.Label4)
        Me.GbinfoNota.Controls.Add(Me.Label2)
        Me.GbinfoNota.Location = New System.Drawing.Point(5, 99)
        Me.GbinfoNota.Name = "GbinfoNota"
        Me.GbinfoNota.Size = New System.Drawing.Size(616, 116)
        Me.GbinfoNota.TabIndex = 270
        Me.GbinfoNota.TabStop = False
        '
        'LblFechaHora
        '
        Me.LblFechaHora.AutoSize = True
        Me.LblFechaHora.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaHora.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.LblFechaHora.Location = New System.Drawing.Point(82, 21)
        Me.LblFechaHora.Name = "LblFechaHora"
        Me.LblFechaHora.Size = New System.Drawing.Size(71, 12)
        Me.LblFechaHora.TabIndex = 305
        Me.LblFechaHora.Text = "-----------"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.White
        Me.Label21.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(5, 21)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(67, 12)
        Me.Label21.TabIndex = 304
        Me.Label21.Text = "Fecha       :"
        '
        'LblTotalSaco
        '
        Me.LblTotalSaco.AutoSize = True
        Me.LblTotalSaco.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalSaco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.LblTotalSaco.Location = New System.Drawing.Point(542, 97)
        Me.LblTotalSaco.Name = "LblTotalSaco"
        Me.LblTotalSaco.Size = New System.Drawing.Size(71, 12)
        Me.LblTotalSaco.TabIndex = 303
        Me.LblTotalSaco.Text = "-----------"
        '
        'LblPesoNeto
        '
        Me.LblPesoNeto.AutoSize = True
        Me.LblPesoNeto.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPesoNeto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.LblPesoNeto.Location = New System.Drawing.Point(542, 79)
        Me.LblPesoNeto.Name = "LblPesoNeto"
        Me.LblPesoNeto.Size = New System.Drawing.Size(71, 12)
        Me.LblPesoNeto.TabIndex = 302
        Me.LblPesoNeto.Text = "-----------"
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.LblEstado.Location = New System.Drawing.Point(542, 59)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(71, 12)
        Me.LblEstado.TabIndex = 301
        Me.LblEstado.Text = "-----------"
        '
        'LblTara
        '
        Me.LblTara.AutoSize = True
        Me.LblTara.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTara.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.LblTara.Location = New System.Drawing.Point(542, 40)
        Me.LblTara.Name = "LblTara"
        Me.LblTara.Size = New System.Drawing.Size(71, 12)
        Me.LblTara.TabIndex = 300
        Me.LblTara.Text = "-----------"
        '
        'LblPesoBruto
        '
        Me.LblPesoBruto.AutoSize = True
        Me.LblPesoBruto.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPesoBruto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.LblPesoBruto.Location = New System.Drawing.Point(542, 21)
        Me.LblPesoBruto.Name = "LblPesoBruto"
        Me.LblPesoBruto.Size = New System.Drawing.Size(71, 12)
        Me.LblPesoBruto.TabIndex = 299
        Me.LblPesoBruto.Text = "-----------"
        '
        'LblVariedad
        '
        Me.LblVariedad.AutoSize = True
        Me.LblVariedad.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVariedad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.LblVariedad.Location = New System.Drawing.Point(309, 97)
        Me.LblVariedad.Name = "LblVariedad"
        Me.LblVariedad.Size = New System.Drawing.Size(71, 12)
        Me.LblVariedad.TabIndex = 298
        Me.LblVariedad.Text = "-----------"
        '
        'LblCalidad
        '
        Me.LblCalidad.AutoSize = True
        Me.LblCalidad.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCalidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.LblCalidad.Location = New System.Drawing.Point(309, 79)
        Me.LblCalidad.Name = "LblCalidad"
        Me.LblCalidad.Size = New System.Drawing.Size(71, 12)
        Me.LblCalidad.TabIndex = 297
        Me.LblCalidad.Text = "-----------"
        '
        'LblCodigo
        '
        Me.LblCodigo.AutoSize = True
        Me.LblCodigo.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.LblCodigo.Location = New System.Drawing.Point(309, 59)
        Me.LblCodigo.Name = "LblCodigo"
        Me.LblCodigo.Size = New System.Drawing.Size(71, 12)
        Me.LblCodigo.TabIndex = 296
        Me.LblCodigo.Text = "-----------"
        '
        'LblPorcunetade
        '
        Me.LblPorcunetade.AutoSize = True
        Me.LblPorcunetade.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPorcunetade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.LblPorcunetade.Location = New System.Drawing.Point(309, 40)
        Me.LblPorcunetade.Name = "LblPorcunetade"
        Me.LblPorcunetade.Size = New System.Drawing.Size(71, 12)
        Me.LblPorcunetade.TabIndex = 295
        Me.LblPorcunetade.Text = "-----------"
        '
        'LblRecibimosde
        '
        Me.LblRecibimosde.AutoSize = True
        Me.LblRecibimosde.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRecibimosde.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.LblRecibimosde.Location = New System.Drawing.Point(309, 21)
        Me.LblRecibimosde.Name = "LblRecibimosde"
        Me.LblRecibimosde.Size = New System.Drawing.Size(71, 12)
        Me.LblRecibimosde.TabIndex = 294
        Me.LblRecibimosde.Text = "-----------"
        '
        'LblCedulaConductor
        '
        Me.LblCedulaConductor.AutoSize = True
        Me.LblCedulaConductor.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCedulaConductor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.LblCedulaConductor.Location = New System.Drawing.Point(82, 97)
        Me.LblCedulaConductor.Name = "LblCedulaConductor"
        Me.LblCedulaConductor.Size = New System.Drawing.Size(71, 12)
        Me.LblCedulaConductor.TabIndex = 293
        Me.LblCedulaConductor.Text = "-----------"
        '
        'LblConductor
        '
        Me.LblConductor.AutoSize = True
        Me.LblConductor.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConductor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.LblConductor.Location = New System.Drawing.Point(82, 79)
        Me.LblConductor.Name = "LblConductor"
        Me.LblConductor.Size = New System.Drawing.Size(71, 12)
        Me.LblConductor.TabIndex = 292
        Me.LblConductor.Text = "-----------"
        '
        'LblModelo
        '
        Me.LblModelo.AutoSize = True
        Me.LblModelo.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblModelo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.LblModelo.Location = New System.Drawing.Point(82, 60)
        Me.LblModelo.Name = "LblModelo"
        Me.LblModelo.Size = New System.Drawing.Size(71, 12)
        Me.LblModelo.TabIndex = 290
        Me.LblModelo.Text = "-----------"
        '
        'LblPlaca
        '
        Me.LblPlaca.AutoSize = True
        Me.LblPlaca.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPlaca.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.LblPlaca.Location = New System.Drawing.Point(82, 40)
        Me.LblPlaca.Name = "LblPlaca"
        Me.LblPlaca.Size = New System.Drawing.Size(71, 12)
        Me.LblPlaca.TabIndex = 289
        Me.LblPlaca.Text = "-----------"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(460, 97)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 12)
        Me.Label14.TabIndex = 288
        Me.Label14.Text = "Total Saco  :"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(460, 79)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 12)
        Me.Label16.TabIndex = 287
        Me.Label16.Text = "Peso Neto   :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(460, 59)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(73, 12)
        Me.Label17.TabIndex = 286
        Me.Label17.Text = "Estado       :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(460, 40)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(73, 12)
        Me.Label18.TabIndex = 285
        Me.Label18.Text = "Tara          :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(460, 21)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 12)
        Me.Label19.TabIndex = 284
        Me.Label19.Text = "Peso Bruto :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(208, 97)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 12)
        Me.Label13.TabIndex = 283
        Me.Label13.Text = "Variedad café :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(208, 79)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 12)
        Me.Label12.TabIndex = 282
        Me.Label12.Text = "Calidad café   :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(208, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 12)
        Me.Label11.TabIndex = 281
        Me.Label11.Text = "Codigo          :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(208, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 12)
        Me.Label10.TabIndex = 280
        Me.Label10.Text = "Por Cuenta de :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(4, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 12)
        Me.Label8.TabIndex = 278
        Me.Label8.Text = "Cedula      :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(4, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 12)
        Me.Label7.TabIndex = 277
        Me.Label7.Text = "Conductor :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(4, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 12)
        Me.Label6.TabIndex = 276
        Me.Label6.Text = "Modelo     :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(208, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 12)
        Me.Label5.TabIndex = 275
        Me.Label5.Text = "Recibimos de :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(5, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 12)
        Me.Label4.TabIndex = 270
        Me.Label4.Text = "Placa        :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(6, -1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 15)
        Me.Label2.TabIndex = 274
        Me.Label2.Text = "DATOS NOTA DE PESO"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.CboBodegaOrigen)
        Me.GroupBox1.Controls.Add(Me.CboBodegaDestino)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(618, 58)
        Me.GroupBox1.TabIndex = 271
        Me.GroupBox1.TabStop = False
        '
        'lblbdega
        '
        Me.lblbdega.AutoSize = True
        Me.lblbdega.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.lblbdega.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.lblbdega.Location = New System.Drawing.Point(7, 16)
        Me.lblbdega.Name = "lblbdega"
        Me.lblbdega.Size = New System.Drawing.Size(90, 15)
        Me.lblbdega.TabIndex = 273
        Me.lblbdega.Text = "Nota Peso # :"
        '
        'TxtNumeroEnsamble
        '
        Me.TxtNumeroEnsamble.Enabled = False
        Me.TxtNumeroEnsamble.Location = New System.Drawing.Point(106, 14)
        Me.TxtNumeroEnsamble.Name = "TxtNumeroEnsamble"
        Me.TxtNumeroEnsamble.ReadOnly = True
        Me.TxtNumeroEnsamble.Size = New System.Drawing.Size(128, 20)
        Me.TxtNumeroEnsamble.TabIndex = 272
        Me.TxtNumeroEnsamble.Text = "- - - - - 0 - - - - -"
        Me.TxtNumeroEnsamble.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GbEncabezado
        '
        Me.GbEncabezado.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.GbEncabezado.Controls.Add(Me.BtnConsulta)
        Me.GbEncabezado.Controls.Add(Me.DTPFecha)
        Me.GbEncabezado.Controls.Add(Me.LblHora)
        Me.GbEncabezado.Controls.Add(Me.lblbdega)
        Me.GbEncabezado.Controls.Add(Me.TxtNumeroEnsamble)
        Me.GbEncabezado.Location = New System.Drawing.Point(3, 0)
        Me.GbEncabezado.Name = "GbEncabezado"
        Me.GbEncabezado.Size = New System.Drawing.Size(619, 42)
        Me.GbEncabezado.TabIndex = 275
        Me.GbEncabezado.TabStop = False
        '
        'BtnConsulta
        '
        Me.BtnConsulta.FlatAppearance.BorderSize = 0
        Me.BtnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConsulta.Image = Global.Remisiones.My.Resources.Resources.Lupa321
        Me.BtnConsulta.Location = New System.Drawing.Point(240, 8)
        Me.BtnConsulta.Name = "BtnConsulta"
        Me.BtnConsulta.Size = New System.Drawing.Size(32, 30)
        Me.BtnConsulta.TabIndex = 274
        Me.BtnConsulta.UseVisualStyleBackColor = True
        '
        'DTPFecha
        '
        Me.DTPFecha.AutoSize = True
        Me.DTPFecha.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.DTPFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.DTPFecha.Location = New System.Drawing.Point(427, 16)
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
        Me.LblHora.Location = New System.Drawing.Point(517, 16)
        Me.LblHora.Name = "LblHora"
        Me.LblHora.Size = New System.Drawing.Size(95, 15)
        Me.LblHora.TabIndex = 181
        Me.LblHora.Text = "10:23:55 p.m."
        '
        'GbCamaInfo
        '
        Me.GbCamaInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.GbCamaInfo.Controls.Add(Me.Label23)
        Me.GbCamaInfo.Controls.Add(Me.TxtNivelActual)
        Me.GbCamaInfo.Controls.Add(Me.Label22)
        Me.GbCamaInfo.Controls.Add(Me.CmbNivel)
        Me.GbCamaInfo.Controls.Add(Me.Label9)
        Me.GbCamaInfo.Controls.Add(Me.TxtPesoTransladar)
        Me.GbCamaInfo.Controls.Add(Me.CboCama)
        Me.GbCamaInfo.Controls.Add(Me.Label20)
        Me.GbCamaInfo.Controls.Add(Me.Label3)
        Me.GbCamaInfo.Location = New System.Drawing.Point(3, 218)
        Me.GbCamaInfo.Name = "GbCamaInfo"
        Me.GbCamaInfo.Size = New System.Drawing.Size(619, 113)
        Me.GbCamaInfo.TabIndex = 275
        Me.GbCamaInfo.TabStop = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(28, 65)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(107, 15)
        Me.Label23.TabIndex = 312
        Me.Label23.Text = "Nivel Actual     :"
        '
        'TxtNivelActual
        '
        Me.TxtNivelActual.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.TxtNivelActual.Location = New System.Drawing.Point(27, 82)
        Me.TxtNivelActual.Name = "TxtNivelActual"
        Me.TxtNivelActual.ReadOnly = True
        Me.TxtNivelActual.Size = New System.Drawing.Size(214, 23)
        Me.TxtNivelActual.TabIndex = 311
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(378, 64)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(140, 15)
        Me.Label22.TabIndex = 310
        Me.Label22.Text = "Nivel a Transladar    :"
        '
        'CmbNivel
        '
        Me.CmbNivel.BackColor = System.Drawing.Color.White
        Me.CmbNivel.DisplayMember = "Nombre_Bodega"
        Me.CmbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbNivel.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.CmbNivel.FormattingEnabled = True
        Me.CmbNivel.Location = New System.Drawing.Point(376, 82)
        Me.CmbNivel.Name = "CmbNivel"
        Me.CmbNivel.Size = New System.Drawing.Size(214, 23)
        Me.CmbNivel.TabIndex = 309
        Me.CmbNivel.ValueMember = "Cod_Bodega"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(377, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(141, 15)
        Me.Label9.TabIndex = 308
        Me.Label9.Text = "Peso  a Transladar    :"
        '
        'TxtPesoTransladar
        '
        Me.TxtPesoTransladar.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.TxtPesoTransladar.Location = New System.Drawing.Point(376, 38)
        Me.TxtPesoTransladar.Name = "TxtPesoTransladar"
        Me.TxtPesoTransladar.Size = New System.Drawing.Size(214, 23)
        Me.TxtPesoTransladar.TabIndex = 307
        Me.TxtPesoTransladar.Text = "0.00"
        '
        'CboCama
        '
        Me.CboCama.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.CboCama.Caption = ""
        Me.CboCama.CaptionHeight = 17
        Me.CboCama.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CboCama.ColumnCaptionHeight = 17
        Me.CboCama.ColumnFooterHeight = 17
        Me.CboCama.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.CboCama.ContentHeight = 18
        Me.CboCama.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.CboCama.DisplayMember = "NombreCama"
        Me.CboCama.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.CboCama.DropDownWidth = 185
        Me.CboCama.EditorBackColor = System.Drawing.SystemColors.Window
        Me.CboCama.EditorFont = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.CboCama.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.CboCama.EditorHeight = 18
        Me.CboCama.Images.Add(CType(resources.GetObject("CboCama.Images"), System.Drawing.Image))
        Me.CboCama.ItemHeight = 35
        Me.CboCama.Location = New System.Drawing.Point(26, 37)
        Me.CboCama.MatchEntryTimeout = CType(2000, Long)
        Me.CboCama.MaxDropDownItems = CType(5, Short)
        Me.CboCama.MaximumSize = New System.Drawing.Size(300, 100)
        Me.CboCama.MaxLength = 32767
        Me.CboCama.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CboCama.Name = "CboCama"
        Me.CboCama.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.CboCama.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.CboCama.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CboCama.Size = New System.Drawing.Size(214, 24)
        Me.CboCama.TabIndex = 305
        Me.CboCama.ValueMember = "IdCama"
        Me.CboCama.PropBag = resources.GetString("CboCama.PropBag")
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(28, 18)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(66, 15)
        Me.Label20.TabIndex = 304
        Me.Label20.Text = "Cama     :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 15)
        Me.Label3.TabIndex = 274
        Me.Label3.Text = "DATOS CAMA"
        '
        'BtnNuevoRec
        '
        Me.BtnNuevoRec.FlatAppearance.BorderSize = 0
        Me.BtnNuevoRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevoRec.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevoRec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnNuevoRec.Image = Global.Remisiones.My.Resources.Resources.CirculoPlus48
        Me.BtnNuevoRec.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnNuevoRec.Location = New System.Drawing.Point(4, 336)
        Me.BtnNuevoRec.Name = "BtnNuevoRec"
        Me.BtnNuevoRec.Size = New System.Drawing.Size(96, 66)
        Me.BtnNuevoRec.TabIndex = 278
        Me.BtnNuevoRec.Text = "Nuevo"
        Me.BtnNuevoRec.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnNuevoRec.UseVisualStyleBackColor = True
        '
        'BtnEnviarPatio
        '
        Me.BtnEnviarPatio.FlatAppearance.BorderSize = 0
        Me.BtnEnviarPatio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEnviarPatio.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnviarPatio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnEnviarPatio.Image = Global.Remisiones.My.Resources.Resources.trolley_48d
        Me.BtnEnviarPatio.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnEnviarPatio.Location = New System.Drawing.Point(422, 336)
        Me.BtnEnviarPatio.Name = "BtnEnviarPatio"
        Me.BtnEnviarPatio.Size = New System.Drawing.Size(87, 66)
        Me.BtnEnviarPatio.TabIndex = 277
        Me.BtnEnviarPatio.Text = "Translado"
        Me.BtnEnviarPatio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEnviarPatio.UseVisualStyleBackColor = True
        '
        'BtnRecpSalir
        '
        Me.BtnRecpSalir.FlatAppearance.BorderSize = 0
        Me.BtnRecpSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRecpSalir.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRecpSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BtnRecpSalir.Image = Global.Remisiones.My.Resources.Resources.exit48
        Me.BtnRecpSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnRecpSalir.Location = New System.Drawing.Point(531, 336)
        Me.BtnRecpSalir.Name = "BtnRecpSalir"
        Me.BtnRecpSalir.Size = New System.Drawing.Size(87, 66)
        Me.BtnRecpSalir.TabIndex = 276
        Me.BtnRecpSalir.Text = "Salir"
        Me.BtnRecpSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnRecpSalir.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'FrmTranslado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(631, 411)
        Me.Controls.Add(Me.BtnNuevoRec)
        Me.Controls.Add(Me.BtnEnviarPatio)
        Me.Controls.Add(Me.BtnRecpSalir)
        Me.Controls.Add(Me.GbCamaInfo)
        Me.Controls.Add(Me.GbEncabezado)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GbinfoNota)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(647, 450)
        Me.MinimumSize = New System.Drawing.Size(647, 450)
        Me.Name = "FrmTranslado"
        Me.Text = "FrmTranslado"
        Me.GbinfoNota.ResumeLayout(False)
        Me.GbinfoNota.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GbEncabezado.ResumeLayout(False)
        Me.GbEncabezado.PerformLayout()
        Me.GbCamaInfo.ResumeLayout(False)
        Me.GbCamaInfo.PerformLayout()
        CType(Me.CboCama, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboBodegaDestino As System.Windows.Forms.ComboBox
    Friend WithEvents CboBodegaOrigen As System.Windows.Forms.ComboBox
    Friend WithEvents GbinfoNota As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblbdega As System.Windows.Forms.Label
    Friend WithEvents TxtNumeroEnsamble As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GbEncabezado As System.Windows.Forms.GroupBox
    Friend WithEvents DTPFecha As System.Windows.Forms.Label
    Friend WithEvents LblHora As System.Windows.Forms.Label
    Friend WithEvents GbCamaInfo As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnEnviarPatio As System.Windows.Forms.Button
    Friend WithEvents BtnRecpSalir As System.Windows.Forms.Button
    Friend WithEvents BtnNuevoRec As System.Windows.Forms.Button
    Friend WithEvents BtnConsulta As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents LblTotalSaco As System.Windows.Forms.Label
    Friend WithEvents LblPesoNeto As System.Windows.Forms.Label
    Friend WithEvents LblEstado As System.Windows.Forms.Label
    Friend WithEvents LblTara As System.Windows.Forms.Label
    Friend WithEvents LblPesoBruto As System.Windows.Forms.Label
    Friend WithEvents LblVariedad As System.Windows.Forms.Label
    Friend WithEvents LblCalidad As System.Windows.Forms.Label
    Friend WithEvents LblCodigo As System.Windows.Forms.Label
    Friend WithEvents LblPorcunetade As System.Windows.Forms.Label
    Friend WithEvents LblRecibimosde As System.Windows.Forms.Label
    Friend WithEvents LblCedulaConductor As System.Windows.Forms.Label
    Friend WithEvents LblConductor As System.Windows.Forms.Label
    Friend WithEvents LblModelo As System.Windows.Forms.Label
    Friend WithEvents LblPlaca As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents CboCama As C1.Win.C1List.C1Combo
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LblFechaHora As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtPesoTransladar As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents CmbNivel As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TxtNivelActual As System.Windows.Forms.TextBox
End Class
