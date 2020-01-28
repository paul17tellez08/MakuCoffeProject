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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTranslado))
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CboBodegaDestino = New System.Windows.Forms.ComboBox
        Me.CboBodegaOrigen = New System.Windows.Forms.ComboBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblbdega = New System.Windows.Forms.Label
        Me.TxtNumeroEnsamble = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button13 = New System.Windows.Forms.Button
        Me.DTPFecha = New System.Windows.Forms.Label
        Me.LblHora = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.BtnNuevoRec = New System.Windows.Forms.Button
        Me.BtnEnviarPatio = New System.Windows.Forms.Button
        Me.BtnRecpSalir = New System.Windows.Forms.Button
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(332, 12)
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
        Me.Label1.Location = New System.Drawing.Point(3, 11)
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
        Me.CboBodegaDestino.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.CboBodegaDestino.FormattingEnabled = True
        Me.CboBodegaDestino.Items.AddRange(New Object() {"PESADA BASCULA", "PESADA MANUAL"})
        Me.CboBodegaDestino.Location = New System.Drawing.Point(333, 30)
        Me.CboBodegaDestino.Name = "CboBodegaDestino"
        Me.CboBodegaDestino.Size = New System.Drawing.Size(171, 23)
        Me.CboBodegaDestino.TabIndex = 268
        Me.CboBodegaDestino.ValueMember = "Cod_Bodega"
        '
        'CboBodegaOrigen
        '
        Me.CboBodegaOrigen.BackColor = System.Drawing.Color.White
        Me.CboBodegaOrigen.DisplayMember = "Nombre_Bodega"
        Me.CboBodegaOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboBodegaOrigen.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.CboBodegaOrigen.FormattingEnabled = True
        Me.CboBodegaOrigen.Items.AddRange(New Object() {"PESADA BASCULA", "PESADA MANUAL"})
        Me.CboBodegaOrigen.Location = New System.Drawing.Point(6, 29)
        Me.CboBodegaOrigen.Name = "CboBodegaOrigen"
        Me.CboBodegaOrigen.Size = New System.Drawing.Size(171, 23)
        Me.CboBodegaOrigen.TabIndex = 269
        Me.CboBodegaOrigen.ValueMember = "Cod_Bodega"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Location = New System.Drawing.Point(5, 107)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(510, 116)
        Me.GroupBox4.TabIndex = 270
        Me.GroupBox4.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(6, -1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 15)
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
        Me.GroupBox1.Location = New System.Drawing.Point(3, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(512, 58)
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
        Me.TxtNumeroEnsamble.Size = New System.Drawing.Size(128, 20)
        Me.TxtNumeroEnsamble.TabIndex = 272
        Me.TxtNumeroEnsamble.Text = "- - - - - 0 - - - - -"
        Me.TxtNumeroEnsamble.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.Button13)
        Me.GroupBox3.Controls.Add(Me.DTPFecha)
        Me.GroupBox3.Controls.Add(Me.LblHora)
        Me.GroupBox3.Controls.Add(Me.lblbdega)
        Me.GroupBox3.Controls.Add(Me.TxtNumeroEnsamble)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(513, 42)
        Me.GroupBox3.TabIndex = 275
        Me.GroupBox3.TabStop = False
        '
        'Button13
        '
        Me.Button13.FlatAppearance.BorderSize = 0
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Image = Global.Remisiones.My.Resources.Resources.Lupa321
        Me.Button13.Location = New System.Drawing.Point(240, 8)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(32, 30)
        Me.Button13.TabIndex = 274
        Me.Button13.UseVisualStyleBackColor = True
        '
        'DTPFecha
        '
        Me.DTPFecha.AutoSize = True
        Me.DTPFecha.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.DTPFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.DTPFecha.Location = New System.Drawing.Point(321, 16)
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
        Me.LblHora.Location = New System.Drawing.Point(411, 16)
        Me.LblHora.Name = "LblHora"
        Me.LblHora.Size = New System.Drawing.Size(95, 15)
        Me.LblHora.TabIndex = 181
        Me.LblHora.Text = "10:23:55 p.m."
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 227)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(510, 123)
        Me.GroupBox2.TabIndex = 275
        Me.GroupBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 15)
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
        Me.BtnNuevoRec.Location = New System.Drawing.Point(4, 357)
        Me.BtnNuevoRec.Name = "BtnNuevoRec"
        Me.BtnNuevoRec.Size = New System.Drawing.Size(75, 66)
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
        Me.BtnEnviarPatio.Location = New System.Drawing.Point(329, 357)
        Me.BtnEnviarPatio.Name = "BtnEnviarPatio"
        Me.BtnEnviarPatio.Size = New System.Drawing.Size(88, 66)
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
        Me.BtnRecpSalir.Location = New System.Drawing.Point(434, 356)
        Me.BtnRecpSalir.Name = "BtnRecpSalir"
        Me.BtnRecpSalir.Size = New System.Drawing.Size(75, 66)
        Me.BtnRecpSalir.TabIndex = 276
        Me.BtnRecpSalir.Text = "Salir"
        Me.BtnRecpSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnRecpSalir.UseVisualStyleBackColor = True
        '
        'FrmTranslado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(521, 427)
        Me.Controls.Add(Me.BtnNuevoRec)
        Me.Controls.Add(Me.BtnEnviarPatio)
        Me.Controls.Add(Me.BtnRecpSalir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(537, 466)
        Me.MinimumSize = New System.Drawing.Size(537, 466)
        Me.Name = "FrmTranslado"
        Me.Text = "FrmTranslado"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboBodegaDestino As System.Windows.Forms.ComboBox
    Friend WithEvents CboBodegaOrigen As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblbdega As System.Windows.Forms.Label
    Friend WithEvents TxtNumeroEnsamble As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DTPFecha As System.Windows.Forms.Label
    Friend WithEvents LblHora As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnEnviarPatio As System.Windows.Forms.Button
    Friend WithEvents BtnRecpSalir As System.Windows.Forms.Button
    Friend WithEvents BtnNuevoRec As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
End Class
