Public Class FrmConsultas
    Public DataSet As New DataSet, TipoEnsamble As String, CodIva As String, TipoCompra As String, CodCajero As String, Nombres As String, Apellidos As String
    Public MiConexion As New SqlClient.SqlConnection(Conexion), Codigo As String, Descripcion As String, TipoProducto As String, CodComponente As Double, Precio As Double
    ' Public MiconexionContabilidad As New SqlClient.SqlConnection(ConexionContabilidad), Cantidad As Double, CodProducto As String, Fecha As Date, FechaHora As Date
    Public DescripcionImpuestos As String, TasaImpuestos As Double, TipoImpuesto As String, CodigoCliente As String, Tipo As String, CodigoProveedor As String, NumFactura As String

    Private Sub C1TrueDBGrid1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FrmConsultas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim DataAdapter As New SqlClient.SqlDataAdapter, SQlProductos As String
        Select Case Quien
            Case "RecepcionBusqueda"

                SQlProductos = "SELECT Recepcion.NumeroRecepcion, Recepcion.Fecha, Recepcion.TipoRecepcion, Proveedor.Nombre_Proveedor + '' + Proveedor.Apellido_Proveedor AS Productor, Recepcion.Conductor, Recepcion.Id_Placa AS Placa, Recepcion.Cod_Bodega AS Bodega, Recepcion.Observaciones, Recepcion.SubTotal, Recepcion.Lote, Recepcion.Peso, Recepcion.Activo  FROM Recepcion INNER JOIN Proveedor ON Recepcion.Cod_Proveedor = Proveedor.IdProductor WHERE (Recepcion.Activo = 1) "
                MiConexion.Open()
                DataAdapter = New SqlClient.SqlDataAdapter(SQlProductos, MiConexion)
                DataSet.Reset()
                DataAdapter.Fill(DataSet, "Consultas")
                Me.BindingConsultas.DataSource = DataSet.Tables("Consultas")
                Me.TrueDBGridConsultas.DataSource = Me.BindingConsultas
                'Me.TrueDBGridConsultas.Columns(0).Caption = "Còdigo"
                'Me.TrueDBGridConsultas.Columns(1).Caption = "Finca"
                'Me.TrueDBGridConsultas.Columns(2).Caption = "Vigencia"
                'Me.TrueDBGridConsultas.Splits.Item(0).DisplayColumns(1).Width = 300
                MiConexion.Close()
        End Select
    End Sub

    Private Sub BtnPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPagar.Click
        Dim Posicion As Integer
        Codigo = "- - - - - 0 - - - - - "
        Select Case Quien
            Case "RecepcionBusqueda"
                Posicion = Me.BindingConsultas.Position
                Codigo = Me.BindingConsultas.Item(Posicion)("NumeroRecepcion")
        End Select
        If Codigo = "---0---" Then
            MsgBox("Seleccione Codigo para Continuar", MsgBoxStyle.Critical, "MakuCoffe")
        Else
            Me.Close()
        End If

    End Sub
End Class
