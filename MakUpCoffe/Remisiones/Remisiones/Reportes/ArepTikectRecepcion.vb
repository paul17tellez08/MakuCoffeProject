Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class ArepTikectRecepcion 
    Public SqlConsulta As String
    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format
        'Dim rpt As New ArepSubReporte()
        'Dim childDataSource As New DataDynamics.ActiveReports.DataSources.OleDBDataSource()
        'childDataSource.ConnectionString = "Provider=SQLOLEDB.1;" & Conexion
        'childDataSource.SQL = SqlConsulta
        'rpt.DataSource = childDataSource
        'Me.SubReport1.Report = rpt
    End Sub
End Class
