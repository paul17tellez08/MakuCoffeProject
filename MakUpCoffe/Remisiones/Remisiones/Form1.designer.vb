<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
    Inherits C1.Win.C1Ribbon.C1RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIParent1))
        Me.C1Ribbon1 = New C1.Win.C1Ribbon.C1Ribbon
        Me.RibbonApplicationMenu1 = New C1.Win.C1Ribbon.RibbonApplicationMenu
        Me.RbnSalir = New C1.Win.C1Ribbon.RibbonButton
        Me.Productos = New C1.Win.C1Ribbon.RibbonButton
        Me.Proveedores = New C1.Win.C1Ribbon.RibbonButton
        Me.Configuracion = New C1.Win.C1Ribbon.RibbonButton
        Me.RibbonSeparator1 = New C1.Win.C1Ribbon.RibbonSeparator
        Me.RibbonExit = New C1.Win.C1Ribbon.RibbonButton
        Me.RibbonConfigToolBar1 = New C1.Win.C1Ribbon.RibbonConfigToolBar
        Me.RibbonQat1 = New C1.Win.C1Ribbon.RibbonQat
        Me.RibbonTab1 = New C1.Win.C1Ribbon.RibbonTab
        Me.RibbonGroup4 = New C1.Win.C1Ribbon.RibbonGroup
        Me.RibbonButton1 = New C1.Win.C1Ribbon.RibbonButton
        Me.RibbonTab2 = New C1.Win.C1Ribbon.RibbonTab
        Me.RibbonGroup6 = New C1.Win.C1Ribbon.RibbonGroup
        Me.RbtonRecepción = New C1.Win.C1Ribbon.RibbonButton
        Me.RibbonTab3 = New C1.Win.C1Ribbon.RibbonTab
        Me.RibbonGroup1 = New C1.Win.C1Ribbon.RibbonGroup
        Me.RbtnVehiculo = New C1.Win.C1Ribbon.RibbonButton
        Me.RbtnConductor = New C1.Win.C1Ribbon.RibbonButton
        Me.RbtnProveedores = New C1.Win.C1Ribbon.RibbonButton
        Me.RibbonButton3 = New C1.Win.C1Ribbon.RibbonButton
        Me.RibbonButton2 = New C1.Win.C1Ribbon.RibbonButton
        Me.C1StatusBar1 = New C1.Win.C1Ribbon.C1StatusBar
        Me.RibbonLabel1 = New C1.Win.C1Ribbon.RibbonLabel
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1StatusBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1Ribbon1
        '
        Me.C1Ribbon1.ApplicationMenuHolder = Me.RibbonApplicationMenu1
        Me.C1Ribbon1.ConfigToolBarHolder = Me.RibbonConfigToolBar1
        Me.C1Ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.C1Ribbon1.Name = "C1Ribbon1"
        Me.C1Ribbon1.QatHolder = Me.RibbonQat1
        Me.C1Ribbon1.Size = New System.Drawing.Size(1150, 142)
        Me.C1Ribbon1.TabIndex = 0
        Me.C1Ribbon1.Tabs.Add(Me.RibbonTab1)
        Me.C1Ribbon1.Tabs.Add(Me.RibbonTab2)
        Me.C1Ribbon1.Tabs.Add(Me.RibbonTab3)
        '
        'RibbonApplicationMenu1
        '
        Me.RibbonApplicationMenu1.BottomPaneItems.Add(Me.RbnSalir)
        Me.RibbonApplicationMenu1.ID = "RibbonApplicationMenu1"
        Me.RibbonApplicationMenu1.LargeImage = Global.Remisiones.My.Resources.Resources.logoMakupCoffeSF
        Me.RibbonApplicationMenu1.LeftPaneItems.Add(Me.Productos)
        Me.RibbonApplicationMenu1.LeftPaneItems.Add(Me.Proveedores)
        Me.RibbonApplicationMenu1.LeftPaneItems.Add(Me.Configuracion)
        Me.RibbonApplicationMenu1.LeftPaneItems.Add(Me.RibbonSeparator1)
        Me.RibbonApplicationMenu1.LeftPaneItems.Add(Me.RibbonExit)
        '
        'RbnSalir
        '
        Me.RbnSalir.ID = "RbnSalir"
        Me.RbnSalir.Text = "Salir"
        '
        'Productos
        '
        Me.Productos.ID = "Productos"
        Me.Productos.LargeImage = CType(resources.GetObject("Productos.LargeImage"), System.Drawing.Image)
        Me.Productos.Text = "Productos"
        '
        'Proveedores
        '
        Me.Proveedores.ID = "Proveedores"
        Me.Proveedores.LargeImage = CType(resources.GetObject("Proveedores.LargeImage"), System.Drawing.Image)
        Me.Proveedores.Text = "Proveedores"
        '
        'Configuracion
        '
        Me.Configuracion.ID = "Configuracion"
        Me.Configuracion.LargeImage = CType(resources.GetObject("Configuracion.LargeImage"), System.Drawing.Image)
        Me.Configuracion.Text = "Configuracion"
        '
        'RibbonSeparator1
        '
        Me.RibbonSeparator1.ID = "RibbonSeparator1"
        '
        'RibbonExit
        '
        Me.RibbonExit.ID = "RibbonExit"
        Me.RibbonExit.LargeImage = CType(resources.GetObject("RibbonExit.LargeImage"), System.Drawing.Image)
        Me.RibbonExit.Text = "S&alir"
        '
        'RibbonConfigToolBar1
        '
        Me.RibbonConfigToolBar1.ID = "RibbonConfigToolBar1"
        '
        'RibbonQat1
        '
        Me.RibbonQat1.ID = "RibbonQat1"
        '
        'RibbonTab1
        '
        Me.RibbonTab1.Groups.Add(Me.RibbonGroup4)
        Me.RibbonTab1.ID = "RibbonTab1"
        Me.RibbonTab1.Text = "Accesos"
        '
        'RibbonGroup4
        '
        Me.RibbonGroup4.ID = "RibbonGroup4"
        Me.RibbonGroup4.Image = Global.Remisiones.My.Resources.Resources.exit48
        Me.RibbonGroup4.Items.Add(Me.RibbonButton1)
        Me.RibbonGroup4.Text = "Salir"
        '
        'RibbonButton1
        '
        Me.RibbonButton1.ID = "RibbonButton1"
        Me.RibbonButton1.LargeImage = Global.Remisiones.My.Resources.Resources.exit48
        Me.RibbonButton1.SmallImage = CType(resources.GetObject("RibbonButton1.SmallImage"), System.Drawing.Image)
        Me.RibbonButton1.Text = "Salir"
        Me.RibbonButton1.TextImageRelation = C1.Win.C1Ribbon.TextImageRelation.ImageAboveText
        '
        'RibbonTab2
        '
        Me.RibbonTab2.Groups.Add(Me.RibbonGroup6)
        Me.RibbonTab2.ID = "RibbonTab2"
        Me.RibbonTab2.Text = "Recepción"
        '
        'RibbonGroup6
        '
        Me.RibbonGroup6.ID = "RibbonGroup6"
        Me.RibbonGroup6.Items.Add(Me.RbtonRecepción)
        Me.RibbonGroup6.Text = "Recepción"
        '
        'RbtonRecepción
        '
        Me.RbtonRecepción.ID = "RbtonRecepción"
        Me.RbtonRecepción.LargeImage = CType(resources.GetObject("RbtonRecepción.LargeImage"), System.Drawing.Image)
        Me.RbtonRecepción.SmallImage = CType(resources.GetObject("RbtonRecepción.SmallImage"), System.Drawing.Image)
        Me.RbtonRecepción.Text = "Recepción-Cafe"
        Me.RbtonRecepción.TextImageRelation = C1.Win.C1Ribbon.TextImageRelation.ImageAboveText
        '
        'RibbonTab3
        '
        Me.RibbonTab3.Groups.Add(Me.RibbonGroup1)
        Me.RibbonTab3.ID = "RibbonTab3"
        Me.RibbonTab3.Text = "Catálogos"
        '
        'RibbonGroup1
        '
        Me.RibbonGroup1.ID = "RibbonGroup1"
        Me.RibbonGroup1.Image = CType(resources.GetObject("RibbonGroup1.Image"), System.Drawing.Image)
        Me.RibbonGroup1.Items.Add(Me.RbtnVehiculo)
        Me.RibbonGroup1.Items.Add(Me.RbtnConductor)
        Me.RibbonGroup1.Items.Add(Me.RbtnProveedores)
        Me.RibbonGroup1.Items.Add(Me.RibbonButton3)
        Me.RibbonGroup1.Items.Add(Me.RibbonButton2)
        Me.RibbonGroup1.Text = "Catálogo"
        '
        'RbtnVehiculo
        '
        Me.RbtnVehiculo.ID = "RbtnVehiculo"
        Me.RbtnVehiculo.LargeImage = CType(resources.GetObject("RbtnVehiculo.LargeImage"), System.Drawing.Image)
        Me.RbtnVehiculo.SmallImage = CType(resources.GetObject("RbtnVehiculo.SmallImage"), System.Drawing.Image)
        Me.RbtnVehiculo.Text = "Vehiculo"
        Me.RbtnVehiculo.TextImageRelation = C1.Win.C1Ribbon.TextImageRelation.ImageAboveText
        '
        'RbtnConductor
        '
        Me.RbtnConductor.ID = "RbtnConductor"
        Me.RbtnConductor.LargeImage = CType(resources.GetObject("RbtnConductor.LargeImage"), System.Drawing.Image)
        Me.RbtnConductor.SmallImage = CType(resources.GetObject("RbtnConductor.SmallImage"), System.Drawing.Image)
        Me.RbtnConductor.Text = "Conductor"
        Me.RbtnConductor.TextImageRelation = C1.Win.C1Ribbon.TextImageRelation.ImageAboveText
        '
        'RbtnProveedores
        '
        Me.RbtnProveedores.ID = "RbtnProveedores"
        Me.RbtnProveedores.LargeImage = CType(resources.GetObject("RbtnProveedores.LargeImage"), System.Drawing.Image)
        Me.RbtnProveedores.SmallImage = CType(resources.GetObject("RbtnProveedores.SmallImage"), System.Drawing.Image)
        Me.RbtnProveedores.Text = "Proveedores"
        Me.RbtnProveedores.TextImageRelation = C1.Win.C1Ribbon.TextImageRelation.ImageAboveText
        '
        'RibbonButton3
        '
        Me.RibbonButton3.ID = "RibbonButton3"
        Me.RibbonButton3.LargeImage = CType(resources.GetObject("RibbonButton3.LargeImage"), System.Drawing.Image)
        Me.RibbonButton3.SmallImage = CType(resources.GetObject("RibbonButton3.SmallImage"), System.Drawing.Image)
        Me.RibbonButton3.Text = "Municipio y Comarca"
        Me.RibbonButton3.TextImageRelation = C1.Win.C1Ribbon.TextImageRelation.ImageAboveText
        '
        'RibbonButton2
        '
        Me.RibbonButton2.ID = "RibbonButton2"
        Me.RibbonButton2.LargeImage = CType(resources.GetObject("RibbonButton2.LargeImage"), System.Drawing.Image)
        Me.RibbonButton2.SmallImage = CType(resources.GetObject("RibbonButton2.SmallImage"), System.Drawing.Image)
        Me.RibbonButton2.Text = "Finca y Plantillos"
        Me.RibbonButton2.TextImageRelation = C1.Win.C1Ribbon.TextImageRelation.ImageAboveText
        '
        'C1StatusBar1
        '
        Me.C1StatusBar1.Location = New System.Drawing.Point(0, 526)
        Me.C1StatusBar1.Name = "C1StatusBar1"
        Me.C1StatusBar1.RightPaneItems.Add(Me.RibbonLabel1)
        Me.C1StatusBar1.Size = New System.Drawing.Size(1150, 22)
        Me.C1StatusBar1.TabIndex = 1
        '
        'RibbonLabel1
        '
        Me.RibbonLabel1.ID = "RibbonLabel1"
        Me.RibbonLabel1.Text = "Version  1.01"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1150, 548)
        Me.Controls.Add(Me.C1StatusBar1)
        Me.Controls.Add(Me.C1Ribbon1)
        Me.IsMdiContainer = True
        Me.Name = "MDIParent1"
        Me.Text = "Sistema de Recepcion"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2007Silver
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1StatusBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents C1Ribbon1 As C1.Win.C1Ribbon.C1Ribbon
    Friend WithEvents RibbonApplicationMenu1 As C1.Win.C1Ribbon.RibbonApplicationMenu
    Friend WithEvents RibbonConfigToolBar1 As C1.Win.C1Ribbon.RibbonConfigToolBar
    Friend WithEvents RibbonQat1 As C1.Win.C1Ribbon.RibbonQat
    Friend WithEvents RibbonTab1 As C1.Win.C1Ribbon.RibbonTab
    Friend WithEvents Productos As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents C1StatusBar1 As C1.Win.C1Ribbon.C1StatusBar
    Friend WithEvents RibbonGroup4 As C1.Win.C1Ribbon.RibbonGroup
    Friend WithEvents RibbonButton1 As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RibbonSeparator1 As C1.Win.C1Ribbon.RibbonSeparator
    Friend WithEvents RibbonExit As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents Proveedores As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents Configuracion As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RbnSalir As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RibbonTab2 As C1.Win.C1Ribbon.RibbonTab
    Friend WithEvents RibbonGroup6 As C1.Win.C1Ribbon.RibbonGroup
    Friend WithEvents RbtonRecepción As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RibbonLabel1 As C1.Win.C1Ribbon.RibbonLabel
    Friend WithEvents RibbonTab3 As C1.Win.C1Ribbon.RibbonTab
    Friend WithEvents RibbonGroup1 As C1.Win.C1Ribbon.RibbonGroup
    Friend WithEvents RbtnVehiculo As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RbtnConductor As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RbtnProveedores As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RibbonButton2 As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RibbonButton3 As C1.Win.C1Ribbon.RibbonButton

End Class
