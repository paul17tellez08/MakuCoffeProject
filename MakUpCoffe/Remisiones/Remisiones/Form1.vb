Imports C1.Win.C1Ribbon
Imports System.Threading
Public Class MDIParent1
    Public IdLugarAcopio As Integer, MiConexion As New SqlClient.SqlConnection(Conexion), LugarAcopio As String
    Private oHebra As Thread
    Private Sub MDIParent1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Dim MyRuta As String, SqlString As String, Ruta As String
        Dim fileReader As String = ""

        'Ruta = My.Application.Info.DirectoryPath & "\Cosecha.txt"
        'If Dir(Ruta) <> "" Then
        '    fileReader = My.Computer.FileSystem.ReadAllText(Ruta)
        '    CodigoCosecha = fileReader
        'Else
        '    MsgBox("No Existe el Archivo Cosecha", MsgBoxStyle.Critical, "Sistema PuntoRevision")
        'End If
    End Sub

    Private Sub MDIParent1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        '/////////////////////////Cierro las herabas abiertas/////////////////
        If Not (oHebra Is Nothing) Then
            If oHebra.IsAlive Then
                oHebra.Abort()
            End If
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Ruta As String, LeeArchivo As String, SqlString As String
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim ctl As Control, ctlMDI As MdiClient

        For Each ctl In Me.Controls
            Try
                ctlMDI = CType(ctl, MdiClient)
                ctlMDI.BackColor = Me.BackColor
            Catch exc As InvalidCastException
            End Try
        Next


        'Ruta = My.Application.Info.DirectoryPath & "\Localidad.txt"
        'LeeArchivo = ""
        'If Dir(Ruta) <> "" Then
        '    LeeArchivo = Trim(My.Computer.FileSystem.ReadAllText(Ruta))
        'Else
        '    MsgBox("No Existe el Archivo Localidad", MsgBoxStyle.Critical, "Sistema PuntoRevision")
        'End If

        ''LeeArchivo = LeeArchivo.Replace(" "c, String.Empty)
        'LeeArchivo = Mid(LeeArchivo, 1, 3)

        ''//////////////////////////////////////////////////////////BUSCO LOCALIDAD ///////////////////////////////////////////////////
        'SqlString = "SELECT  * FROM LugarAcopio WHERE (CodLugarAcopio = '" & LeeArchivo & "') AND (Activo = 1)"
        'DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        'DataAdapter.Fill(DataSet, "Localidad")
        'If DataSet.Tables("Localidad").Rows.Count = 0 Then
        '    MsgBox("No Existe esta Localidad o No Esta Activo", MsgBoxStyle.Critical, "Sistema PuntoRevision")
        '    Exit Sub
        'Else
        '    IdLugarAcopio = DataSet.Tables("Localidad").Rows(0)("IdLugarAcopio")
        '    LugarAcopio = DataSet.Tables("Localidad").Rows(0)("NomLugarAcopio")
        'End If

        'CreaCortePrecios(IdLugarAcopio, Now)
        'oHebra = New Thread(AddressOf CrearCorteSubProceso)
        'oHebra.Start()
    End Sub
    Private Sub CrearCorteSubProceso()
        Dim SqlString As String, DataAdapter As New SqlClient.SqlDataAdapter, DataSet As New DataSet
        Dim ContLocalidad As Double, i As Double, idLocalidad As Double

        SqlString = "SELECT  * FROM LugarAcopio WHERE (IdRegion = '" & IdRegionUsuario & "') AND (Activo = 1)"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "Localidad")
        ContLocalidad = DataSet.Tables("Localidad").Rows.Count
        Do While ContLocalidad > i
            idLocalidad = DataSet.Tables("Localidad").Rows(i)("IdLugarAcopio")
            CreaCortePrecios(idLocalidad, Now)
            i = i + 1
        Loop
        oHebra.Abort()
    End Sub
    Private Sub RibbonExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonExit.Click
        Me.Close()
    End Sub

    Private Sub RibbonButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonButton1.Click
         Me.Close()
    End Sub

    Private Sub RibbonButton30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Forms.FrmUsuarios.MdiParent = Me
        My.Forms.FrmUsuarios.Show()
    End Sub

    Private Sub RbtonRecepción_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtonRecepción.Click
        Quien = "Calidad-Categoria"
        'My.Forms.FrmRecepcion.MdiParent = Me
        My.Forms.FrmRecepcion.Show()
    End Sub
    Private Sub RbtnVehiculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtnVehiculo.Click
        My.Forms.FrmVehiculo.MdiParent = Me
        My.Forms.FrmVehiculo.Show()
    End Sub

    Private Sub RbtnConductor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtnConductor.Click
        My.Forms.FrmConductor.MdiParent = Me
        My.Forms.FrmConductor.Show()
    End Sub

    Private Sub RbtnProveedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtnProveedores.Click
        My.Forms.FrmProveedores.MdiParent = Me
        My.Forms.FrmProveedores.Show()
    End Sub

    Private Sub RibbonButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonButton3.Click
        My.Forms.FrmComarMunici().MdiParent = Me
        My.Forms.FrmComarMunici().Show()
    End Sub

    Private Sub RibbonButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonButton2.Click
        My.Forms.FrmFincaPlantillo().MdiParent = Me
        My.Forms.FrmFincaPlantillo().Show()
    End Sub

    Private Sub RibonUsuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibonUsuarios.Click
        My.Forms.FrmUsuarios().MdiParent = Me
        My.Forms.FrmUsuarios().Show()
    End Sub

    Private Sub RibbonButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonButton4.Click
        Quien = "Calidad-Categoria"
        My.Forms.FrmRecepcion.Show()
    End Sub
End Class
