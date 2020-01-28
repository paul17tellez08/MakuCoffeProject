Public Class FrmTranslado
    Public CodigoNotaPeso As String
    Public MiConexion As New SqlClient.SqlConnection(Conexion)
    Private Sub FrmTranslado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim sql As String, ComandoUpdate As New SqlClient.SqlCommand
        Dim SqlProductos As String, SqlString As String, Ruta As String, LeeArchivo As String, i As Integer

        SqlString = "SELECT   Cod_Bodega, Nombre_Bodega  FROM  Bodegas"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "Bodegas")
        Me.CboBodegaOrigen.DataSource = DataSet.Tables("Bodegas")
        If Not DataSet.Tables("Bodegas").Rows.Count = 0 Then
            Me.CboBodegaOrigen.Text = DataSet.Tables("Bodegas").Rows(0)("Cod_Bodega")
        End If
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Quien = "RecepcionBusqueda"
        My.Forms.FrmConsultas.Text = "Consulta Recibo"
        My.Forms.FrmConsultas.ShowDialog()
        If My.Forms.FrmConsultas.Codigo <> "- - - - - 0 - - - - -" Then
            Me.TxtNumeroEnsamble.Text = FrmConsultas.Codigo
        End If
    End Sub

    Private Sub CboBodegaOrigen_ValueMemberChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboBodegaOrigen.ValueMemberChanged
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim sql As String, ComandoUpdate As New SqlClient.SqlCommand
        Dim SqlProductos As String, SqlString As String, Ruta As String, LeeArchivo As String, i As Integer

        SqlString = "SELECT Cod_Bodega, Nombre_Bodega  FROM  Bodegas WHERE (NOT (Cod_Bodega = N'" & Me.CboBodegaOrigen.Text & "'))  "
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "Bodegas")
        Me.CboBodegaDestino.DataSource = DataSet.Tables("Bodegas")
        If Not DataSet.Tables("Bodegas").Rows.Count = 0 Then
            Me.CboBodegaDestino.Text = DataSet.Tables("Bodegas").Rows(0)("Cod_Bodega")
        End If
    End Sub
End Class