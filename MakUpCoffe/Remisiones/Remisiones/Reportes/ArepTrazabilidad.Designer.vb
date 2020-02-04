<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ArepTrazabilidad 
    Inherits DataDynamics.ActiveReports.ActiveReport3 

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
        End If
        MyBase.Dispose(disposing)
    End Sub
    
    'NOTE: The following procedure is required by the ActiveReports Designer
    'It can be modified using the ActiveReports Designer.
    'Do not modify it using the code editor.
    Private WithEvents PageHeader1 As DataDynamics.ActiveReports.PageHeader
    Private WithEvents Detail1 As DataDynamics.ActiveReports.Detail
    Private WithEvents PageFooter1 As DataDynamics.ActiveReports.PageFooter
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ArepTrazabilidad))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.ImgLogo = New DataDynamics.ActiveReports.Picture
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.Barcode1 = New DataDynamics.ActiveReports.Barcode
        Me.Label2 = New DataDynamics.ActiveReports.Label
        Me.Label3 = New DataDynamics.ActiveReports.Label
        Me.Label4 = New DataDynamics.ActiveReports.Label
        Me.ArepLblFecha = New DataDynamics.ActiveReports.Label
        Me.Label6 = New DataDynamics.ActiveReports.Label
        Me.Label7 = New DataDynamics.ActiveReports.Label
        Me.Shape1 = New DataDynamics.ActiveReports.Shape
        Me.Label8 = New DataDynamics.ActiveReports.Label
        Me.ArepLblCodigoTraza = New DataDynamics.ActiveReports.Label
        Me.ArepLblVariedad = New DataDynamics.ActiveReports.Label
        Me.ArepLblPesoNeto = New DataDynamics.ActiveReports.Label
        Me.ArepLblCama = New DataDynamics.ActiveReports.Label
        Me.ArepLblNivel = New DataDynamics.ActiveReports.Label
        CType(Me.ImgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArepLblFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArepLblCodigoTraza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArepLblVariedad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArepLblPesoNeto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArepLblCama, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArepLblNivel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Shape1, Me.ImgLogo, Me.Label1, Me.Barcode1, Me.Label2, Me.Label3, Me.Label4, Me.ArepLblFecha, Me.Label6, Me.Label7, Me.Label8, Me.ArepLblCodigoTraza, Me.ArepLblVariedad, Me.ArepLblPesoNeto, Me.ArepLblCama, Me.ArepLblNivel})
        Me.PageHeader1.Height = 2.03125!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Height = 0.0!
        Me.Detail1.Name = "Detail1"
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0.25!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'ImgLogo
        '
        Me.ImgLogo.Border.BottomColor = System.Drawing.Color.Black
        Me.ImgLogo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ImgLogo.Border.LeftColor = System.Drawing.Color.Black
        Me.ImgLogo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ImgLogo.Border.RightColor = System.Drawing.Color.Black
        Me.ImgLogo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ImgLogo.Border.TopColor = System.Drawing.Color.Black
        Me.ImgLogo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ImgLogo.Height = 0.4375!
        Me.ImgLogo.Image = Nothing
        Me.ImgLogo.ImageData = Nothing
        Me.ImgLogo.Left = 0.0!
        Me.ImgLogo.LineWeight = 0.0!
        Me.ImgLogo.Name = "ImgLogo"
        Me.ImgLogo.Top = 0.0625!
        Me.ImgLogo.Width = 1.1875!
        '
        'Label1
        '
        Me.Label1.Border.BottomColor = System.Drawing.Color.Black
        Me.Label1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.LeftColor = System.Drawing.Color.Black
        Me.Label1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.RightColor = System.Drawing.Color.Black
        Me.Label1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.TopColor = System.Drawing.Color.Black
        Me.Label1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Height = 0.25!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 1.375!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 12pt; font-fam" & _
            "ily: Lucida Sans; "
        Me.Label1.Text = "TIKECT DE TRAZABILIDAD"
        Me.Label1.Top = 0.0625!
        Me.Label1.Width = 2.125!
        '
        'Barcode1
        '
        Me.Barcode1.Border.BottomColor = System.Drawing.Color.Black
        Me.Barcode1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Barcode1.Border.LeftColor = System.Drawing.Color.Black
        Me.Barcode1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Barcode1.Border.RightColor = System.Drawing.Color.Black
        Me.Barcode1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Barcode1.Border.TopColor = System.Drawing.Color.Black
        Me.Barcode1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Barcode1.Direction = DataDynamics.ActiveReports.BarCodeDirection.TopToBottom
        Me.Barcode1.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.Barcode1.Height = 1.9375!
        Me.Barcode1.Left = 3.875!
        Me.Barcode1.Name = "Barcode1"
        Me.Barcode1.Text = "Barcode1"
        Me.Barcode1.Top = 0.0625!
        Me.Barcode1.Width = 0.375!
        '
        'Label2
        '
        Me.Label2.Border.BottomColor = System.Drawing.Color.Black
        Me.Label2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Border.LeftColor = System.Drawing.Color.Black
        Me.Label2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Border.RightColor = System.Drawing.Color.Black
        Me.Label2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Border.TopColor = System.Drawing.Color.Black
        Me.Label2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Height = 0.1875!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.0!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 8.25pt; font-fam" & _
            "ily: Lucida Sans; "
        Me.Label2.Text = "Codigo Traza :"
        Me.Label2.Top = 0.75!
        Me.Label2.Width = 1.0!
        '
        'Label3
        '
        Me.Label3.Border.BottomColor = System.Drawing.Color.Black
        Me.Label3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Border.LeftColor = System.Drawing.Color.Black
        Me.Label3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Border.RightColor = System.Drawing.Color.Black
        Me.Label3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Border.TopColor = System.Drawing.Color.Black
        Me.Label3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Height = 0.1875!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 0.0!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 8.25pt; font-fam" & _
            "ily: Lucida Sans; "
        Me.Label3.Text = "Variedad :"
        Me.Label3.Top = 1.0!
        Me.Label3.Width = 1.0!
        '
        'Label4
        '
        Me.Label4.Border.BottomColor = System.Drawing.Color.Black
        Me.Label4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Border.LeftColor = System.Drawing.Color.Black
        Me.Label4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Border.RightColor = System.Drawing.Color.Black
        Me.Label4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Border.TopColor = System.Drawing.Color.Black
        Me.Label4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Height = 0.1875!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 0.0!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 8.25pt; font-fam" & _
            "ily: Lucida Sans; "
        Me.Label4.Text = "Peso Neto :"
        Me.Label4.Top = 1.25!
        Me.Label4.Width = 1.0!
        '
        'ArepLblFecha
        '
        Me.ArepLblFecha.Border.BottomColor = System.Drawing.Color.Black
        Me.ArepLblFecha.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ArepLblFecha.Border.LeftColor = System.Drawing.Color.Black
        Me.ArepLblFecha.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ArepLblFecha.Border.RightColor = System.Drawing.Color.Black
        Me.ArepLblFecha.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ArepLblFecha.Border.TopColor = System.Drawing.Color.Black
        Me.ArepLblFecha.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ArepLblFecha.Height = 0.1875!
        Me.ArepLblFecha.HyperLink = Nothing
        Me.ArepLblFecha.Left = 1.375!
        Me.ArepLblFecha.Name = "ArepLblFecha"
        Me.ArepLblFecha.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Lucida Sans; "
        Me.ArepLblFecha.Text = "Fecha y Hora"
        Me.ArepLblFecha.Top = 0.3125!
        Me.ArepLblFecha.Width = 2.125!
        '
        'Label6
        '
        Me.Label6.Border.BottomColor = System.Drawing.Color.Black
        Me.Label6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label6.Border.LeftColor = System.Drawing.Color.Black
        Me.Label6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label6.Border.RightColor = System.Drawing.Color.Black
        Me.Label6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label6.Border.TopColor = System.Drawing.Color.Black
        Me.Label6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label6.Height = 0.1875!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 0.0!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "color: White; ddo-char-set: 0; text-align: center; font-weight: bold; background-" & _
            "color: #404040; font-size: 9pt; font-family: Lucida Sans; "
        Me.Label6.Text = "C A M A"
        Me.Label6.Top = 1.5!
        Me.Label6.Width = 3.82!
        '
        'Label7
        '
        Me.Label7.Border.BottomColor = System.Drawing.Color.Black
        Me.Label7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label7.Border.LeftColor = System.Drawing.Color.Black
        Me.Label7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label7.Border.RightColor = System.Drawing.Color.Black
        Me.Label7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label7.Border.TopColor = System.Drawing.Color.Black
        Me.Label7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label7.Height = 0.1875!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 0.0625!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 8.25pt; font-fam" & _
            "ily: Lucida Sans; "
        Me.Label7.Text = "Cama :"
        Me.Label7.Top = 1.75!
        Me.Label7.Width = 0.5!
        '
        'Shape1
        '
        Me.Shape1.Border.BottomColor = System.Drawing.Color.Black
        Me.Shape1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Border.LeftColor = System.Drawing.Color.Black
        Me.Shape1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Border.RightColor = System.Drawing.Color.Black
        Me.Shape1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Border.TopColor = System.Drawing.Color.Black
        Me.Shape1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Height = 0.4375!
        Me.Shape1.Left = 0.0!
        Me.Shape1.Name = "Shape1"
        Me.Shape1.RoundingRadius = 10.0!
        Me.Shape1.Style = DataDynamics.ActiveReports.ShapeType.RoundRect
        Me.Shape1.Top = 1.5625!
        Me.Shape1.Width = 3.8125!
        '
        'Label8
        '
        Me.Label8.Border.BottomColor = System.Drawing.Color.Black
        Me.Label8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label8.Border.LeftColor = System.Drawing.Color.Black
        Me.Label8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label8.Border.RightColor = System.Drawing.Color.Black
        Me.Label8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label8.Border.TopColor = System.Drawing.Color.Black
        Me.Label8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label8.Height = 0.1875!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 2.125!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 8.25pt; font-fam" & _
            "ily: Lucida Sans; "
        Me.Label8.Text = "Nivel :"
        Me.Label8.Top = 1.75!
        Me.Label8.Width = 0.5!
        '
        'ArepLblCodigoTraza
        '
        Me.ArepLblCodigoTraza.Border.BottomColor = System.Drawing.Color.Black
        Me.ArepLblCodigoTraza.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ArepLblCodigoTraza.Border.LeftColor = System.Drawing.Color.Black
        Me.ArepLblCodigoTraza.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ArepLblCodigoTraza.Border.RightColor = System.Drawing.Color.Black
        Me.ArepLblCodigoTraza.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ArepLblCodigoTraza.Border.TopColor = System.Drawing.Color.Black
        Me.ArepLblCodigoTraza.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ArepLblCodigoTraza.Height = 0.1875!
        Me.ArepLblCodigoTraza.HyperLink = Nothing
        Me.ArepLblCodigoTraza.Left = 1.125!
        Me.ArepLblCodigoTraza.Name = "ArepLblCodigoTraza"
        Me.ArepLblCodigoTraza.Style = "ddo-char-set: 0; font-size: 9pt; font-family: Lucida Sans; "
        Me.ArepLblCodigoTraza.Text = ""
        Me.ArepLblCodigoTraza.Top = 0.75!
        Me.ArepLblCodigoTraza.Width = 2.5!
        '
        'ArepLblVariedad
        '
        Me.ArepLblVariedad.Border.BottomColor = System.Drawing.Color.Black
        Me.ArepLblVariedad.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ArepLblVariedad.Border.LeftColor = System.Drawing.Color.Black
        Me.ArepLblVariedad.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ArepLblVariedad.Border.RightColor = System.Drawing.Color.Black
        Me.ArepLblVariedad.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ArepLblVariedad.Border.TopColor = System.Drawing.Color.Black
        Me.ArepLblVariedad.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ArepLblVariedad.Height = 0.1875!
        Me.ArepLblVariedad.HyperLink = Nothing
        Me.ArepLblVariedad.Left = 1.125!
        Me.ArepLblVariedad.Name = "ArepLblVariedad"
        Me.ArepLblVariedad.Style = "ddo-char-set: 0; font-size: 9pt; font-family: Lucida Sans; "
        Me.ArepLblVariedad.Text = ""
        Me.ArepLblVariedad.Top = 1.0!
        Me.ArepLblVariedad.Width = 2.5!
        '
        'ArepLblPesoNeto
        '
        Me.ArepLblPesoNeto.Border.BottomColor = System.Drawing.Color.Black
        Me.ArepLblPesoNeto.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ArepLblPesoNeto.Border.LeftColor = System.Drawing.Color.Black
        Me.ArepLblPesoNeto.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ArepLblPesoNeto.Border.RightColor = System.Drawing.Color.Black
        Me.ArepLblPesoNeto.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ArepLblPesoNeto.Border.TopColor = System.Drawing.Color.Black
        Me.ArepLblPesoNeto.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ArepLblPesoNeto.Height = 0.1875!
        Me.ArepLblPesoNeto.HyperLink = Nothing
        Me.ArepLblPesoNeto.Left = 1.125!
        Me.ArepLblPesoNeto.Name = "ArepLblPesoNeto"
        Me.ArepLblPesoNeto.Style = "ddo-char-set: 0; font-size: 9pt; font-family: Lucida Sans; "
        Me.ArepLblPesoNeto.Text = ""
        Me.ArepLblPesoNeto.Top = 1.25!
        Me.ArepLblPesoNeto.Width = 2.5!
        '
        'ArepLblCama
        '
        Me.ArepLblCama.Border.BottomColor = System.Drawing.Color.Black
        Me.ArepLblCama.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ArepLblCama.Border.LeftColor = System.Drawing.Color.Black
        Me.ArepLblCama.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ArepLblCama.Border.RightColor = System.Drawing.Color.Black
        Me.ArepLblCama.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ArepLblCama.Border.TopColor = System.Drawing.Color.Black
        Me.ArepLblCama.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ArepLblCama.Height = 0.1875!
        Me.ArepLblCama.HyperLink = Nothing
        Me.ArepLblCama.Left = 0.625!
        Me.ArepLblCama.Name = "ArepLblCama"
        Me.ArepLblCama.Style = "ddo-char-set: 0; font-size: 9pt; font-family: Lucida Sans; "
        Me.ArepLblCama.Text = ""
        Me.ArepLblCama.Top = 1.75!
        Me.ArepLblCama.Width = 1.375!
        '
        'ArepLblNivel
        '
        Me.ArepLblNivel.Border.BottomColor = System.Drawing.Color.Black
        Me.ArepLblNivel.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ArepLblNivel.Border.LeftColor = System.Drawing.Color.Black
        Me.ArepLblNivel.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ArepLblNivel.Border.RightColor = System.Drawing.Color.Black
        Me.ArepLblNivel.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ArepLblNivel.Border.TopColor = System.Drawing.Color.Black
        Me.ArepLblNivel.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ArepLblNivel.Height = 0.1875!
        Me.ArepLblNivel.HyperLink = Nothing
        Me.ArepLblNivel.Left = 2.75!
        Me.ArepLblNivel.Name = "ArepLblNivel"
        Me.ArepLblNivel.Style = "ddo-char-set: 0; font-size: 9pt; font-family: Lucida Sans; "
        Me.ArepLblNivel.Text = ""
        Me.ArepLblNivel.Top = 1.75!
        Me.ArepLblNivel.Width = 0.8125!
        '
        'ArepTrazabilidad
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 4.322917!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.ImgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArepLblFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArepLblCodigoTraza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArepLblVariedad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArepLblPesoNeto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArepLblCama, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArepLblNivel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents ImgLogo As DataDynamics.ActiveReports.Picture
    Friend WithEvents Label1 As DataDynamics.ActiveReports.Label
    Friend WithEvents Barcode1 As DataDynamics.ActiveReports.Barcode
    Friend WithEvents Label2 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label3 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label4 As DataDynamics.ActiveReports.Label
    Friend WithEvents ArepLblFecha As DataDynamics.ActiveReports.Label
    Friend WithEvents Label6 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label7 As DataDynamics.ActiveReports.Label
    Friend WithEvents Shape1 As DataDynamics.ActiveReports.Shape
    Friend WithEvents Label8 As DataDynamics.ActiveReports.Label
    Friend WithEvents ArepLblCodigoTraza As DataDynamics.ActiveReports.Label
    Friend WithEvents ArepLblVariedad As DataDynamics.ActiveReports.Label
    Friend WithEvents ArepLblPesoNeto As DataDynamics.ActiveReports.Label
    Friend WithEvents ArepLblCama As DataDynamics.ActiveReports.Label
    Friend WithEvents ArepLblNivel As DataDynamics.ActiveReports.Label
End Class 
