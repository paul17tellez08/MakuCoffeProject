<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestRibon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TestRibon))
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem
        Me.SliderItem1 = New DevComponents.DotNetBar.SliderItem
        Me.RadialMenu1 = New DevComponents.DotNetBar.RadialMenu
        Me.RadialMenuItem1 = New DevComponents.DotNetBar.RadialMenuItem
        Me.RadialMenuItem2 = New DevComponents.DotNetBar.RadialMenuItem
        Me.RadialMenuItem3 = New DevComponents.DotNetBar.RadialMenuItem
        Me.RadialMenuItem4 = New DevComponents.DotNetBar.RadialMenuItem
        Me.BubbleBar1 = New DevComponents.DotNetBar.BubbleBar
        Me.BubbleBarTab1 = New DevComponents.DotNetBar.BubbleBarTab(Me.components)
        Me.BubbleButton1 = New DevComponents.DotNetBar.BubbleButton
        Me.BubbleButton2 = New DevComponents.DotNetBar.BubbleButton
        Me.BubbleButton3 = New DevComponents.DotNetBar.BubbleButton
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonItem1
        '
        Me.ButtonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SliderItem1})
        Me.ButtonItem1.Text = "New Button"
        '
        'SliderItem1
        '
        Me.SliderItem1.Name = "SliderItem1"
        Me.SliderItem1.Text = "SliderItem1"
        Me.SliderItem1.Value = 0
        '
        'RadialMenu1
        '
        Me.RadialMenu1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.RadialMenuItem1, Me.RadialMenuItem2, Me.RadialMenuItem3, Me.RadialMenuItem4})
        Me.RadialMenu1.Location = New System.Drawing.Point(513, 109)
        Me.RadialMenu1.Name = "RadialMenu1"
        Me.RadialMenu1.Size = New System.Drawing.Size(28, 28)
        Me.RadialMenu1.Symbol = ""
        Me.RadialMenu1.TabIndex = 0
        Me.RadialMenu1.Text = "RadialMenu1"
        '
        'RadialMenuItem1
        '
        Me.RadialMenuItem1.Name = "RadialMenuItem1"
        Me.RadialMenuItem1.Text = "Item 1"
        '
        'RadialMenuItem2
        '
        Me.RadialMenuItem2.Name = "RadialMenuItem2"
        Me.RadialMenuItem2.Text = "Item 2"
        '
        'RadialMenuItem3
        '
        Me.RadialMenuItem3.Name = "RadialMenuItem3"
        Me.RadialMenuItem3.Text = "Item 3"
        '
        'RadialMenuItem4
        '
        Me.RadialMenuItem4.Name = "RadialMenuItem4"
        Me.RadialMenuItem4.Text = "Item 4"
        '
        'BubbleBar1
        '
        Me.BubbleBar1.Alignment = DevComponents.DotNetBar.eBubbleButtonAlignment.Bottom
        Me.BubbleBar1.AntiAlias = True
        '
        '
        '
        Me.BubbleBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.BubbleBar1.ButtonBackAreaStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BubbleBar1.ButtonBackAreaStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.BubbleBar1.ButtonBackAreaStyle.BorderBottomWidth = 1
        Me.BubbleBar1.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BubbleBar1.ButtonBackAreaStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.BubbleBar1.ButtonBackAreaStyle.BorderLeftWidth = 1
        Me.BubbleBar1.ButtonBackAreaStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.BubbleBar1.ButtonBackAreaStyle.BorderRightWidth = 1
        Me.BubbleBar1.ButtonBackAreaStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.BubbleBar1.ButtonBackAreaStyle.BorderTopWidth = 1
        Me.BubbleBar1.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.BubbleBar1.ButtonBackAreaStyle.PaddingBottom = 3
        Me.BubbleBar1.ButtonBackAreaStyle.PaddingLeft = 3
        Me.BubbleBar1.ButtonBackAreaStyle.PaddingRight = 3
        Me.BubbleBar1.ButtonBackAreaStyle.PaddingTop = 3
        Me.BubbleBar1.ImageSizeNormal = New System.Drawing.Size(24, 24)
        Me.BubbleBar1.Location = New System.Drawing.Point(329, 249)
        Me.BubbleBar1.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBar1.Name = "BubbleBar1"
        Me.BubbleBar1.SelectedTab = Me.BubbleBarTab1
        Me.BubbleBar1.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        Me.BubbleBar1.Size = New System.Drawing.Size(351, 67)
        Me.BubbleBar1.TabIndex = 1
        Me.BubbleBar1.Tabs.Add(Me.BubbleBarTab1)
        Me.BubbleBar1.Text = "BubbleBar1"
        '
        'BubbleBarTab1
        '
        Me.BubbleBarTab1.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.BubbleBarTab1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.BubbleBarTab1.Buttons.AddRange(New DevComponents.DotNetBar.BubbleButton() {Me.BubbleButton1, Me.BubbleButton2, Me.BubbleButton3})
        Me.BubbleBarTab1.DarkBorderColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BubbleBarTab1.LightBorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BubbleBarTab1.Name = "BubbleBarTab1"
        Me.BubbleBarTab1.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue
        Me.BubbleBarTab1.Text = "BubbleBarTab1"
        Me.BubbleBarTab1.TextColor = System.Drawing.Color.Black
        '
        'BubbleButton1
        '
        Me.BubbleButton1.Image = CType(resources.GetObject("BubbleButton1.Image"), System.Drawing.Image)
        Me.BubbleButton1.ImageLarge = CType(resources.GetObject("BubbleButton1.ImageLarge"), System.Drawing.Image)
        Me.BubbleButton1.Name = "BubbleButton1"
        '
        'BubbleButton2
        '
        Me.BubbleButton2.Image = CType(resources.GetObject("BubbleButton2.Image"), System.Drawing.Image)
        Me.BubbleButton2.ImageLarge = CType(resources.GetObject("BubbleButton2.ImageLarge"), System.Drawing.Image)
        Me.BubbleButton2.Name = "BubbleButton2"
        '
        'BubbleButton3
        '
        Me.BubbleButton3.Image = CType(resources.GetObject("BubbleButton3.Image"), System.Drawing.Image)
        Me.BubbleButton3.ImageLarge = CType(resources.GetObject("BubbleButton3.ImageLarge"), System.Drawing.Image)
        Me.BubbleButton3.Name = "BubbleButton3"
        '
        'TestRibon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1085, 531)
        Me.Controls.Add(Me.BubbleBar1)
        Me.Controls.Add(Me.RadialMenu1)
        Me.Name = "TestRibon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "TestRibon"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents SliderItem1 As DevComponents.DotNetBar.SliderItem
    Friend WithEvents RadialMenu1 As DevComponents.DotNetBar.RadialMenu
    Friend WithEvents RadialMenuItem1 As DevComponents.DotNetBar.RadialMenuItem
    Friend WithEvents RadialMenuItem2 As DevComponents.DotNetBar.RadialMenuItem
    Friend WithEvents RadialMenuItem3 As DevComponents.DotNetBar.RadialMenuItem
    Friend WithEvents RadialMenuItem4 As DevComponents.DotNetBar.RadialMenuItem
    Friend WithEvents BubbleBar1 As DevComponents.DotNetBar.BubbleBar
    Friend WithEvents BubbleBarTab1 As DevComponents.DotNetBar.BubbleBarTab
    Friend WithEvents BubbleButton1 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents BubbleButton2 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents BubbleButton3 As DevComponents.DotNetBar.BubbleButton
End Class
