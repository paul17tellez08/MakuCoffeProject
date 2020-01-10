Public Class FrmRecepcion
    Public MiConexion As New SqlClient.SqlConnection(Conexion), A�o As String, Mes As String, Dia As String, ConsecutivoFacturaSerie As Boolean = False
    Public CodigoRecepcion As String
    Delegate Sub delegado(ByVal data As String)
    Private Sub Siguiente()
        If Me.TrueDBGridComponentes.RowCount <> 0 Then
            Dim Iposicion As Double
            Iposicion = Me.TrueDBGridComponentes.RowCount
            Me.TrueDBGridComponentes.Row = Iposicion
            Me.TrueDBGridComponentes.Columns(1).Text = Me.CboCodigoProducto.Columns(0).Text
            Me.TrueDBGridComponentes.Columns(2).Text = Me.CboCodigoProducto.Columns(1).Text
            Me.TrueDBGridComponentes.Col = 5
        End If

    End Sub

    Private Sub FrmRecepcion_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Button10_Click(sender, e)
    End Sub


    Private Sub FrmRecepcion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim sql As String, ComandoUpdate As New SqlClient.SqlCommand 'iResultado As Integer
        Dim SqlProductos As String, SqlString As String, Ruta As String, LeeArchivo As String

        Me.CboTipoRecepcion.SelectedItem = 1
        DataSet.Reset()

        sql = "SELECT  IdProductor, Nombre_Proveedor +' '+ Apellido_Proveedor as Productor  FROM    Proveedor"
        DataAdapter = New SqlClient.SqlDataAdapter(sql, MiConexion)
        DataAdapter.Fill(DataSet, "ListaProveedores")

        Me.CboCodigoProveedor.DataSource = DataSet.Tables("ListaProveedores")
        Me.CboCodigoProveedor.Splits.Item(0).DisplayColumns(0).Visible = False

        '///PARA QUE SIRVE ESTA VALIDACIONES
        'If Quien = "Recepcion" Then
        '    Me.CboTipoRecepcion.Text = "Recepcion"
        '    sql = "SELECT  IdProductor, Nombre_Proveedor +' '+ Apellido_Proveedor  FROM    Proveedor"
        '    DataAdapter = New SqlClient.SqlDataAdapter(sql, MiConexion)
        '    DataAdapter.Fill(DataSet, "ListaProveedores")

        '    Me.CboCodigoProveedor.DataSource = DataSet.Tables("ListaProveedores")

        '    Me.CboCodigoProveedor.Columns(0).Caption = "Codigo"
        '    Me.CboCodigoProveedor.Columns(1).Caption = "Proveedor"
        '    Me.CboCodigoProveedor.Columns(2).Caption = "Origen"

        'ElseIf Quien = "SalidaBascula" Then
        '    Me.CboTipoRecepcion.Text = "Salidabascula"

        '    sql = "SELECT * FROM Clientes"
        '    DataAdapter = New SqlClient.SqlDataAdapter(sql, MiConexion)
        '    DataAdapter.Fill(DataSet, "ListaClientes")
        '    Me.CboCodigoProveedor.DataSource = DataSet.Tables("ListaClientes")

        '    Me.CboCodigoProveedor.Columns(0).Caption = "Codigo"
        '    Me.CboCodigoProveedor.Columns(1).Caption = "Clientes"
        '    Me.CboCodigoProveedor.Columns(2).Caption = "Origen"

        'ElseIf Quien = "Repesaje" Then
        '    Me.CboTipoRecepcion.Text = "Repesaje"

        '    sql = "SELECT * FROM Proveedor"
        '    DataAdapter = New SqlClient.SqlDataAdapter(sql, MiConexion)
        '    DataAdapter.Fill(DataSet, "ListaProveedores")
        '    Me.CboCodigoProveedor.DataSource = DataSet.Tables("ListaProveedores")

        '    Me.CboCodigoProveedor.Columns(0).Caption = "Codigo"
        '    Me.CboCodigoProveedor.Columns(1).Caption = "Proveedor"
        '    Me.CboCodigoProveedor.Columns(2).Caption = "Origen"
        'End If
        MiConexion.Open()

        sql = "SELECT * FROM DatosEmpresa"
        DataAdapter = New SqlClient.SqlDataAdapter(sql, MiConexion)
        DataAdapter.Fill(DataSet, "DatosEmpresa")
        If Not DataSet.Tables("DatosEmpresa").Rows.Count = 0 Then
            ConsecutivoFacturaSerie = DataSet.Tables("DatosEmpresa").Rows(0)("ConsecutivoFacSerie")
        End If

        SqlProductos = "SELECT Cod_Productos, Descripcion_Producto FROM Productos WHERE (Tipo_Producto <> 'Servicio') AND (Tipo_Producto <> 'Descuento')"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlProductos, MiConexion)
        DataAdapter.Fill(DataSet, "ListaProductos")
        If Not DataSet.Tables("ListaProductos").Rows.Count = 0 Then
            Me.CboCodigoProducto.DataSource = DataSet.Tables("ListaProductos")
            Me.CboCodigoProducto.Text = DataSet.Tables("ListaProductos").Rows(0)("Descripcion_Producto")
        End If

        Me.CboCodigoProducto.Splits(0).DisplayColumns(1).Width = 400

        '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        '//////////////////////////CARGO LAS BODEGAS////////////////////////////////////////////////////////////////////
        '////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        SqlString = "SELECT  * FROM   Bodegas"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "Bodegas")
        Me.CboCodigoBodega.DataSource = DataSet.Tables("Bodegas")
        If Not DataSet.Tables("Bodegas").Rows.Count = 0 Then
            Me.CboCodigoBodega.Text = DataSet.Tables("Bodegas").Rows(0)("Cod_Bodega")
        End If
        Me.CboCodigoBodega.Columns(0).Caption = "Codigo"
        Me.CboCodigoBodega.Columns(1).Caption = "Nombre Bodega"

        '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        '//////////////////////////CARGO LAS BODEGAS////////////////////////////////////////////////////////////////////
        '////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        SqlString = "SELECT Placa, Marca, TipoVehiculo FROM Vehiculo WHERE(Activo = 1)"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "Placa")
        Me.CboPlaca.DataSource = DataSet.Tables("Placa")
        If Not DataSet.Tables("Placa").Rows.Count = 0 Then
            Me.CboPlaca.Text = DataSet.Tables("Placa").Rows(0)("Placa")
        End If
        Me.CboPlaca.Columns(0).Caption = "Placa"
        'Me.CboCodigoBodega.Columns(1).Caption = "Placa"

        '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        '//////////////////////////CARGO LOS CONDUCTORES////////////////////////////////////////////////////////////////////
        '////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        SqlString = "SELECT Codigo, Nombre, Cedula, Licencia, Activo, ListaNegra, RazonListaNegra FROM Conductor WHERE (Activo = 1)"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "Conductor")
        Me.CboConductor.DataSource = DataSet.Tables("Conductor")
        If Not DataSet.Tables("Conductor").Rows.Count = 0 Then
            Me.CboConductor.Text = DataSet.Tables("Conductor").Rows(0)("Nombre")
        End If
        Me.CboConductor.Columns(0).Caption = "Codigo"
        'Me.CboCodigoBodega.Columns(1).Caption = "Placa"

        MiConexion.Close()

        ''////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ''///////////////////////CARGO LOS SERIES////////////////////////////////////////////////////////////////////////////////////////
        ''//////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        SqlString = "SELECT DISTINCT Serie FROM ConsecutivoSerie ORDER BY Serie DESC"
        MiConexion.Open()
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "ConsecutivoSerie")
        CmbSerie.DataSource = DataSet.Tables("ConsecutivoSerie")
        If Not DataSet.Tables("ConsecutivoSerie").Rows.Count = 0 Then
            Me.CmbSerie.Text = DataSet.Tables("ConsecutivoSerie").Rows(0)("Serie")
        End If
        MiConexion.Close()
        If Me.ConsecutivoFacturaSerie = True Then
            Me.CmbSerie.Visible = True
        End If

        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        '///////////////////////////////CARGO EL DETALLE DE COMPRAS/////////////////////////////////////////////////////////////////
        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        sql = "SELECT  id_Eventos As Linea, Cod_Productos, Descripcion_Producto, Calidad, Estado, Cantidad, PesoKg, Tara, PesoNetoLb, PesoNetoKg, QQ As Saco, Precio  FROM Detalle_Recepcion  WHERE (NumeroRecepcion = N'-100000')"
        DataAdapter = New SqlClient.SqlDataAdapter(sql, MiConexion)
        DataAdapter.Fill(DataSet, "DetalleRecepcion")
        Me.BindingDetalle.DataSource = DataSet.Tables("DetalleRecepcion")
        Me.TrueDBGridComponentes.DataSource = Me.BindingDetalle
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(0).Width = 40
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(0).Locked = True
        Me.TrueDBGridComponentes.Columns(0).Caption = "Psda"

        Me.TrueDBGridComponentes.Columns(1).Caption = "C�digo"
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(1).Button = True
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(1).Width = 63
        Me.TrueDBGridComponentes.Columns(2).Caption = "Descripci�n"
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(2).Width = 300
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(2).Locked = True
        Me.TrueDBGridComponentes.Columns(3).Caption = "Calidad"
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(3).Width = 50
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(3).Locked = True
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns("Calidad").Visible = False
        Me.TrueDBGridComponentes.Columns(4).Caption = "Estado"
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(4).Width = 50
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(4).Locked = True
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns("Estado").Visible = False

        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(5).Width = 75
        Me.TrueDBGridComponentes.Columns(5).Caption = "PesoLb"
        'Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(4).Locked = True
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(6).Width = 85
        'Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(2).Button = True
        'Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(3).Button = True
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(7).Width = 75
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(7).Locked = True
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(8).Width = 75
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(9).Width = 75
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(10).Width = 50
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(11).Width = 75

        Me.DTPFecha.Text = Format(Now, "dd/MM/yyyy")
        A�o = Microsoft.VisualBasic.DateAndTime.Year(Now)
        Mes = Microsoft.VisualBasic.DateAndTime.Month(Now)
        Dia = Microsoft.VisualBasic.DateAndTime.Day(Now)
    End Sub

    Private Sub CmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdNuevo.Click
        LimpiaRecepcion()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.LblHora.Text = Date.Now.ToLongTimeString
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        '////////////////////////////////////////////////////////////////////////////////////////////////////
        '/////////////////////////////GRABO ENCABEZADO DE RECEPCION /////////////////////////////////////////////
        '//////////////////////////////////////////////////////////////////////////////////////////////////////////7
        If Me.BindingDetalle.Count <> 0 Then
            GrabaRecepcion(Me.TxtNumeroEnsamble.Text)
            LimpiaRecepcion()
        Else
            MsgBox("Seleccione Productos para poder Grabar", MsgBoxStyle.Critical, "Zeus Inventario")
        End If

        If Me.CboTipoRecepcion.Text = "RePesaje" Then
            Me.Close()
        End If
    End Sub

    Private Sub CboConductor_TextChanged_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboConductor.TextChanged

        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim sql As String, ComandoUpdate As New SqlClient.SqlCommand 'iResultado As Integer
        Dim SqlProductos As String, SqlString As String, Codigo As String

        '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        '//////////////////////////CARGO LOS CONDUCTORES////////////////////////////////////////////////////////////////////
        '////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        Codigo = Me.CboConductor.Columns("Codigo").Text
        SqlString = "SELECT Codigo, Nombre, Cedula, Licencia, Activo, ListaNegra, RazonListaNegra FROM Conductor WHERE (Activo = 1) AND (Codigo = '" & Codigo & "')"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "Conductor")
        If Not DataSet.Tables("Conductor").Rows.Count = 0 Then
            Me.TxtCedula.Text = DataSet.Tables("Conductor").Rows(0)("Cedula")
        End If
        Me.CboConductor.Columns(0).Caption = "Codigo"
        'Me.CboCodigoBodega.Columns(1).Caption = "Placa"

        MiConexion.Close()
    End Sub

    Private Sub CboPlaca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboPlaca.TextChanged
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim sql As String, ComandoUpdate As New SqlClient.SqlCommand 'iResultado As Integer
        Dim SqlProductos As String, SqlString As String, Codigo As String

        '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        '//////////////////////////CARGO LAS BODEGAS////////////////////////////////////////////////////////////////////
        '////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        SqlString = "SELECT Placa, Marca, TipoVehiculo FROM Vehiculo WHERE(Activo = 1) AND (Placa = '" & Me.CboPlaca.Text & "')"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "Placa")
        If Not DataSet.Tables("Placa").Rows.Count = 0 Then
            Me.TxtMarca.Text = DataSet.Tables("Placa").Rows(0)("Marca")
        End If
        Me.CboPlaca.Columns(0).Caption = "Placa"
    End Sub

    Private Sub CboCodigoProveedor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCodigoProveedor.TextChanged
        Dim SqlProveedor As String, DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim StrSqlSelect As String


        SqlProveedor = "SELECT  * FROM Proveedor  WHERE (IdProductor = '" & Me.CboCodigoProveedor.Text & "')"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlProveedor, MiConexion)
        DataAdapter.Fill(DataSet, "Proveedor")
        If Not DataSet.Tables("Proveedor").Rows.Count = 0 Then
            Me.txtnombre.Text = DataSet.Tables("Proveedor").Rows(0)("Nombre_Proveedor")
            If Not IsDBNull(DataSet.Tables("Proveedor").Rows(0)("Apellido_Proveedor")) Then
                Me.txtnombre.Text = DataSet.Tables("Proveedor").Rows(0)("Nombre_Proveedor") & " " & DataSet.Tables("Proveedor").Rows(0)("Apellido_Proveedor")
            End If
            '////////////////////////////////////////////////BUSCO DATOS DEL CONDUCTOR ///////////////////////////////////

            StrSqlSelect = "SELECT  IdFinca, IdProductor, NomFinca, IdComarca, Altitud, NotasdeCata, Emblaje, FechaActualizacion, Activo  FROM   Finca   WHERE   (IdProductor = '" & Me.CboCodigoProveedor.Text & "')"
            DataAdapter = New SqlClient.SqlDataAdapter(StrSqlSelect, MiConexion)
            DataAdapter.Fill(DataSet, "ListaFinca")
            Me.CboFinca.DataSource = DataSet.Tables("ListaFinca")
            Me.CboFinca.Splits.Item(0).DisplayColumns(0).Visible = False
            Me.CboFinca.Splits.Item(0).DisplayColumns(1).Visible = False
            Me.CboFinca.Splits.Item(0).DisplayColumns(3).Visible = False
            Me.CboFinca.Splits.Item(0).DisplayColumns(4).Visible = False
            Me.CboFinca.Splits.Item(0).DisplayColumns(5).Visible = False
            Me.CboFinca.Splits.Item(0).DisplayColumns(6).Visible = False
            Me.CboFinca.Splits.Item(0).DisplayColumns(7).Visible = False
            Me.CboFinca.Splits.Item(0).DisplayColumns(8).Visible = False
            Me.CboFinca.Text = "SELECCIONE"

            SqlProveedor = "SELECT DISTINCT Conductor, Id_identificacion, Id_Placa, Cod_Bodega, Observaciones, SubTotal, Telefono,Cod_SubProveedor  FROM Recepcion WHERE (Cod_Proveedor = '" & Me.CboCodigoProveedor.Text & "') ORDER BY Conductor"
            DataAdapter = New SqlClient.SqlDataAdapter(SqlProveedor, MiConexion)
            DataAdapter.Fill(DataSet, "Datos")
            If Not DataSet.Tables("Datos").Rows.Count = 0 Then
                If Not IsDBNull(DataSet.Tables("Datos").Rows(0)("Conductor")) Then
                    Me.CboConductor.Text = DataSet.Tables("Datos").Rows(0)("Conductor")
                End If
                If Not IsDBNull(DataSet.Tables("Datos").Rows(0)("Id_identificacion")) Then
                    Me.txtid.Text = DataSet.Tables("Datos").Rows(0)("Id_identificacion")
                End If

                If Not IsDBNull(DataSet.Tables("Datos").Rows(0)("Id_Placa")) Then
                    Me.CboPlaca.Text = DataSet.Tables("Datos").Rows(0)("Id_Placa")
                End If
                If Not IsDBNull(DataSet.Tables("Datos").Rows(0)("Cod_SubProveedor")) Then
                    'CodigoSubProveedor = DataSet.Tables("Datos").Rows(0)("Cod_SubProveedor")
                End If
            End If


        End If

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        My.Forms.FrmPuertos.ShowDialog()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.sp.Close()
        Me.LblEstado.Text = "DESCONECTADO"
        Me.LblEstado.ForeColor = Color.Black
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim SQL As New DataDynamics.ActiveReports.DataSources.SqlDBDataSource, SqlString As String
        Dim ArepRecepcion As New ArepRecepcion, CodigoProducto As String, Sqldatos As String, RutaLogo As String
        Dim oDataRow As DataRow, Fecha As String, Registros As Double, i As Double, Buscar_Fila() As DataRow, Criterios As String = ""
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter, Posicion As Double = 0, DescripcionAnterior As String = ""


        Fecha = Format(CDate(Me.DTPFecha.Text), "yyyy-MM-dd")


        '*******************************************************************************************************************************
        '/////////////////////////AGREGO UNA CONSULTA QUE NUNCA TENDRA REGISTROS PARA PODER AGREGARLOS /////////////////////////////////
        '*******************************************************************************************************************************
        SqlString = "SELECT  id_Eventos, NumeroRecepcion, Fecha, TipoRecepcion, Cod_Productos, Descripcion_Producto, Codigo_Beams, Cantidad, Unidad_Medida  FROM Detalle_Recepcion WHERE (NumeroRecepcion = '-100000') AND (Fecha = CONVERT(DATETIME, '2013-10-12 00:00:00', 102)) AND (TipoRecepcion = N'Recepcion') ORDER BY Cantidad"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "Reporte")

        SqlString = "SELECT  id_Eventos, NumeroRecepcion, Fecha, TipoRecepcion, Cod_Productos, Descripcion_Producto, Codigo_Beams, Cantidad, Unidad_Medida  FROM Detalle_Recepcion WHERE (NumeroRecepcion = '" & Me.TxtNumeroEnsamble.Text & "') AND (Fecha = CONVERT(DATETIME, '" & Fecha & "', 102)) AND (TipoRecepcion = '" & Me.CboTipoRecepcion.Text & "') ORDER BY Cod_Productos DESC"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "Recepcion")
        Registros = DataSet.Tables("Recepcion").Rows.Count
        i = 0

        Do While Registros > i

            CodigoProducto = DataSet.Tables("Recepcion").Rows(i)("Cod_Productos")

            '//////////////////////////////////////////BUSCO SI NO EXISTE PARA AGREGAR UNO NUEVO ///////////////////////////
            Criterios = "Cod_Productos= '" & CodigoProducto & "'"
            Buscar_Fila = DataSet.Tables("Reporte").Select(Criterios)
            If Buscar_Fila.Length = 0 Then
                oDataRow = DataSet.Tables("Reporte").NewRow
                oDataRow("id_Eventos") = DataSet.Tables("Recepcion").Rows(i)("id_Eventos")
                oDataRow("NumeroRecepcion") = DataSet.Tables("Recepcion").Rows(i)("NumeroRecepcion")
                oDataRow("Fecha") = DataSet.Tables("Recepcion").Rows(i)("Fecha")
                oDataRow("TipoRecepcion") = DataSet.Tables("Recepcion").Rows(i)("TipoRecepcion")
                oDataRow("Cod_Productos") = DataSet.Tables("Recepcion").Rows(i)("Cod_Productos")
                oDataRow("Descripcion_Producto") = DataSet.Tables("Recepcion").Rows(i)("Descripcion_Producto")
                oDataRow("Codigo_Beams") = DataSet.Tables("Recepcion").Rows(i)("Codigo_Beams")
                oDataRow("Cantidad") = DataSet.Tables("Recepcion").Rows(i)("Cantidad")
                oDataRow("Unidad_Medida") = DataSet.Tables("Recepcion").Rows(i)("id_Eventos") & "-" & DataSet.Tables("Recepcion").Rows(i)("Cantidad") & "Lb"
                DataSet.Tables("Reporte").Rows.Add(oDataRow)
            Else
                Posicion = DataSet.Tables("Reporte").Rows.IndexOf(Buscar_Fila(0))
                DescripcionAnterior = DataSet.Tables("Reporte").Rows(Posicion)("Unidad_Medida")
                DataSet.Tables("Reporte").Rows(Posicion)("Unidad_Medida") = DescripcionAnterior & " , " & DataSet.Tables("Recepcion").Rows(i)("id_Eventos") & "-" & DataSet.Tables("Recepcion").Rows(i)("Cantidad") & "Lb"
                DataSet.Tables("Reporte").Rows(Posicion)("Cantidad") = DataSet.Tables("Reporte").Rows(Posicion)("Cantidad") + DataSet.Tables("Recepcion").Rows(i)("Cantidad")
            End If

            i = i + 1
        Loop


        Sqldatos = "SELECT * FROM DatosEmpresa"
        DataAdapter = New SqlClient.SqlDataAdapter(Sqldatos, MiConexion)
        DataAdapter.Fill(DataSet, "DatosEmpresa")

        If Not DataSet.Tables("DatosEmpresa").Rows.Count = 0 Then


            ArepRecepcion.LblEncabezado.Text = DataSet.Tables("DatosEmpresa").Rows(0)("Nombre_Empresa")
            ArepRecepcion.LblDireccion.Text = DataSet.Tables("DatosEmpresa").Rows(0)("Direccion_Empresa")

            If Not IsDBNull(DataSet.Tables("DatosEmpresa").Rows(0)("Numero_Ruc")) Then
                ArepRecepcion.LblRuc.Text = "Numero RUC " & DataSet.Tables("DatosEmpresa").Rows(0)("Numero_Ruc")
            End If
            If Not IsDBNull(DataSet.Tables("DatosEmpresa").Rows(0)("Ruta_Logo")) Then
                RutaLogo = DataSet.Tables("DatosEmpresa").Rows(0)("Ruta_Logo")
                If Dir(RutaLogo) <> "" Then
                    ArepRecepcion.ImgLogo.Image = New System.Drawing.Bitmap(RutaLogo)
                End If

            End If
        End If

        ArepRecepcion.LblLote.Text = Me.A�o & "-" & Me.Mes & "-" & Me.Dia & "-" & Me.CboCodigoProveedor.Text
        ArepRecepcion.LblNotas.Text = Me.txtobservaciones.Text
        ArepRecepcion.LblOrden.Text = Me.TxtNumeroEnsamble.Text
        ArepRecepcion.LblFechaOrden.Text = Format(CDate(Me.DTPFecha.Text), "dd/MM/yyyy")
        ArepRecepcion.LblTipoCompra.Text = Me.CboTipoRecepcion.Text
        'ArepRecepcion.LblCodProveedor.Text = Me.CboCodigoProveedor.Text
        ArepRecepcion.LblNombres.Text = Me.txtnombre.Text
        ArepRecepcion.LblApellidos.Text = Me.txtapellido.Text
        'ArepRecepcion.LblBodegas.Text = Me.CboCodigoBodega.Columns(0).Text + " " + Me.CboCodigoBodega.Columns(1).Text
        'ArepRecepcion.LblNombres.Text = Me.txtnombre.Text
        'ArepRecepcion.LblBodegas.Text = Me.CboCodigoBodega.Columns(0).Text + " " + Me.CboCodigoBodega.Columns(1).Text
        'ArepRecepcion.LblPila.Text = Me.txtapellido.Text
        'ArepRecepcion.LblConductor.Text = Me.CboConductor.Text
        'ArepRecepcion.LblCedula.Text = Me.txtid.Text
        'ArepRecepcion.LblPlaca.Text = Me.txtplaca.Text

        Dim ViewerForm As New FrmViewer()
        ViewerForm.arvMain.Document = ArepRecepcion.Document
        My.Application.DoEvents()

        ArepRecepcion.DataSource = DataSet.Tables("Reporte")
        ArepRecepcion.Run(False)
        ViewerForm.Show()

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim SQLProveedor As String, Sql As String
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim StrSqlUpdate As String, ComandoUpdate As New SqlClient.SqlCommand, iResultado As Integer
        Dim Resultado As String, Posicion As Double, CodigoLinea As String = ""
        Dim CodigoIngreso As String = "", SqlString As String = "", Fecha As String

        Resultado = MsgBox("�Esta Seguro de Eliminar el Ingreso?", MsgBoxStyle.YesNo, "Sistema de Facturacion")

        If Resultado <> 6 Then
            Exit Sub
        End If

        Posicion = Me.BindingDetalle.Position
        If Not IsDBNull(Me.BindingDetalle.Item(Posicion)("Linea")) Then
            CodigoLinea = Me.BindingDetalle.Item(Posicion)("Linea")
        End If

        Fecha = Format(CDate(Me.DTPFecha.Text), "yyyy-MM-dd")

        SQLProveedor = "SELECT  *  FROM Detalle_Recepcion WHERE (NumeroRecepcion = '" & Me.TxtNumeroEnsamble.Text & "') AND (Fecha = CONVERT(DATETIME, '" & Fecha & "', 102)) AND (TipoRecepcion = '" & Me.CboTipoRecepcion.Text & "') AND (id_Eventos = " & CodigoLinea & ")"
        DataAdapter = New SqlClient.SqlDataAdapter(SQLProveedor, MiConexion)
        DataAdapter.Fill(DataSet, "Deducciones")
        If Not DataSet.Tables("Deducciones").Rows.Count = 0 Then
            '///////////SI EXISTE EL USUARIO LO ACTUALIZO////////////////
            MiConexion.Close()
            StrSqlUpdate = "DELETE FROM [Detalle_Recepcion] WHERE (NumeroRecepcion = '" & Me.TxtNumeroEnsamble.Text & "') AND (Fecha = CONVERT(DATETIME, '" & Fecha & "', 102)) AND (TipoRecepcion = '" & Me.CboTipoRecepcion.Text & "') AND (id_Eventos = " & CodigoLinea & ")"
            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(StrSqlUpdate, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            MiConexion.Close()
        End If



        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        '///////////////////////////////CARGO EL DETALLE DE COMPRAS/////////////////////////////////////////////////////////////////
        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        Sql = "SELECT  id_Eventos As Linea, Cod_Productos, Descripcion_Producto, Calidad, Estado, Cantidad, PesoKg, Tara, PesoNetoLb, PesoNetoKg, QQ As Saco, Precio  FROM Detalle_Recepcion   WHERE (NumeroRecepcion = '" & Me.TxtNumeroEnsamble.Text & "') AND (Fecha = CONVERT(DATETIME, '" & Fecha & "', 102)) AND (TipoRecepcion = '" & Me.CboTipoRecepcion.Text & "') "
        DataAdapter = New SqlClient.SqlDataAdapter(Sql, MiConexion)
        DataAdapter.Fill(DataSet, "DetalleRecepcion")
        Me.BindingDetalle.DataSource = DataSet.Tables("DetalleRecepcion")
        Me.TrueDBGridComponentes.DataSource = Me.BindingDetalle
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(0).Width = 40
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(0).Locked = True
        Me.TrueDBGridComponentes.Columns(0).Caption = "Psda"

        Me.TrueDBGridComponentes.Columns(1).Caption = "C�digo"
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(1).Button = True
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(1).Width = 63
        Me.TrueDBGridComponentes.Columns(2).Caption = "Descripci�n"
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(2).Width = 200
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(2).Locked = True
        Me.TrueDBGridComponentes.Columns(3).Caption = "Calidad"
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(3).Width = 50
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(3).Locked = True
        Me.TrueDBGridComponentes.Columns(4).Caption = "Estado"
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(4).Width = 50
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(4).Locked = True
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(5).Width = 75
        Me.TrueDBGridComponentes.Columns(5).Caption = "PesoLb"
        'Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(4).Locked = True
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(6).Width = 85
        'Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(2).Button = True
        'Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(3).Button = True
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(7).Width = 75
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(7).Locked = True
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(8).Width = 75
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(9).Width = 75
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(10).Width = 50
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(11).Width = 75

    End Sub

    Private Sub sp_DataReceived(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles sp.DataReceived
        Dim s As String '= sp.ReadExisting, Pesada As Double

        Dim escribeport3 As New delegado(AddressOf Me.mostar)



        s = sp.ReadLine


        If Len(s) = 19 Then
            If Mid(s, 1, 5) <> "GROSS" Then
                Exit Sub
            End If
        End If

        Select Case Mid(s, 1, 4)
            Case "TARA" : Exit Sub
            Case "NETO" : Exit Sub
            Case "TEL:2263-5025" : Exit Sub
            Case "" : Exit Sub

        End Select

        If Len(s) > 5 Then
            s = SoloNumeros(s)


            If s = "2263-5025" Then  ''''SOBRE PASA EL " Then  SOLO EMTRIDES---
                Exit Sub
            End If


            If s <> "" Then
                Me.Invoke(escribeport3, s)
            End If

        End If

    End Sub


    Sub mostar(ByVal d As String)
        Dim Posicion As Double
        Dim Cadena As String, Pesada As Double, PesoEntero As Double, PesoDecimal As Double

        'Cadena = Mid(d, 7, Len(d))
        'Pesada = CDbl(Cadena)
        Cadena = d
        Pesada = SoloNumeros(Cadena)
        '-------------------------------SI SE ACTIVA EL REDONDEO CAMBIO LA PESADA
        If Me.ChkTaraSaco.Checked = True Then
            PesoEntero = Int(Pesada)
            PesoDecimal = Format(Pesada - PesoEntero, "##0.00")
            'If PesoDecimal >= 0.01 And PesoDecimal <= 0.4 Then
            '    PesoDecimal = 0
            'ElseIf PesoDecimal >= 0.41 And PesoDecimal <= 0.5 Then
            '    'PesoDecimal = 0.5
            'ElseIf PesoDecimal >= 0.51 And PesoDecimal <= 0.9 Then
            '    PesoDecimal = 0.5
            'ElseIf PesoDecimal >= 0.91 And PesoDecimal <= 0.99 Then
            '    'PesoDecimal = 1
            'End If

            Pesada = PesoEntero + PesoDecimal
        End If

        'Posicion = Me.BindingDetalle.Position
        Posicion = Me.TrueDBGridComponentes.Row
        Me.TrueDBGridComponentes.Columns(5).Text = Pesada
        'Me.LblPeso.Text = Pesada & " Kg"
        My.Application.DoEvents()
        GrabaLecturaPeso(Pesada)
        'Me.BindingDetalle.Position = Posicion + 1
        Me.TrueDBGridComponentes.Row = Posicion + 1
    End Sub

    Private Sub CmdPesada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPesada.Click
        Dim Pesada As Double, Posicion As Double



        Posicion = Me.TrueDBGridComponentes.Row

        FrmTeclado.ShowDialog()
        Pesada = FrmTeclado.Numero
        Me.LblPeso.Text = Pesada & " Kg"
        'Pesada = 100

        Me.TrueDBGridComponentes.Columns(5).Text = Pesada
        My.Application.DoEvents()
        GrabaLecturaPeso(Pesada)
        Me.TrueDBGridComponentes.Row = Posicion + 1



        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(0).Width = 40
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(0).Locked = True
        Me.TrueDBGridComponentes.Columns(0).Caption = "Psda"
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns("Precio").Visible = False
        Me.TrueDBGridComponentes.Columns(1).Caption = "C�digo"
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(1).Button = False
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(1).Locked = True
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(1).Width = 63
        Me.TrueDBGridComponentes.Columns(2).Caption = "Descripci�n"
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(2).Width = 200
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(2).Locked = True
        Me.TrueDBGridComponentes.Columns(3).Caption = "Categ"
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(3).Width = 50
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(3).Locked = True
        Me.TrueDBGridComponentes.Columns(4).Caption = "Estado"
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(4).Width = 50
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(4).Locked = True
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(5).Width = 75
        Me.TrueDBGridComponentes.Columns(5).Caption = "PesoLb"
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns("Cantidad").Locked = True
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(6).Locked = True
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(6).Width = 85
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(0).Button = False
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(7).Width = 75
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(7).Locked = True
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(8).Width = 75
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(8).Locked = True
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(9).Width = 75
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(9).Locked = True
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(10).Width = 50
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(10).Locked = True
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(11).Width = 75
        Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(11).Locked = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If Quien = "Recepcion" Then
            Quien = "CodigoProveedor"
        ElseIf Quien = "SalidaBascula" Then
            Quien = "CodigoCliente"
        ElseIf Quien = "Repesaje" Then
            Quien = "CodigoProveedor"
        End If
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmTeclado.ShowDialog()
        If FrmTeclado.Numero <> 0 Then
            Me.CboCodigoProveedor.Text = FrmTeclado.Numero
        End If
    End Sub

    Private Sub CboCodigoProducto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CboCodigoBodega_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCodigoBodega.TextChanged

    End Sub

    Private Sub C1Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Quien = "Vehiculo"
    End Sub

    Private Sub C1Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Quien = "Conductor"
    End Sub

    Private Sub C1Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Quien = "CodigoProductos"
    End Sub

    Private Sub GroupBox7_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscarCodProv.Enter

    End Sub

    Private Sub BubbleBar1_ButtonClick(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ClickEventArgs)

    End Sub

    Private Sub BubbleButton6_Click(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ClickEventArgs) Handles Bbtn.Click

    End Sub

    Private Sub BbtnNew_Click(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ClickEventArgs) Handles BbtnNew.Click
        LimpiaRecepcion()
    End Sub

    Private Sub lblbdega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblbdega.Click

    End Sub

    Private Sub lbldatosre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbldatosre.Click

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox6_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox6.Enter

    End Sub

    Private Sub TrueDBGridComponentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrueDBGridComponentes.Click

    End Sub

    Private Sub txtapellido_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtapellido.TextChanged

    End Sub

    Private Sub BtnNuevoRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevoRec.Click
        LimpiaRecepcion()
    End Sub

    Private Sub BtnGuardarRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardarRec.Click
        If Me.BindingDetalle.Count <> 0 Then
            GrabaRecepcion(Me.TxtNumeroEnsamble.Text)
            LimpiaRecepcion()
        Else
            MsgBox("Seleccione Productos para poder Grabar", MsgBoxStyle.Critical, "Zeus Inventario")
        End If

        If Me.CboTipoRecepcion.Text = "RePesaje" Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnConectarRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConectarRec.Click
        My.Forms.FrmPuertos.ShowDialog()
    End Sub

    Private Sub BtnDisconectRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDisconectRec.Click
        Me.sp.Close()
        Me.LblEstado.Text = "DESCONECTADO"
        Me.LblEstado.ForeColor = Color.Black
    End Sub

    Private Sub BtnImpriRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImpriRec.Click
        Dim SQL As New DataDynamics.ActiveReports.DataSources.SqlDBDataSource, SqlString As String
        Dim ArepRecepcion As New ArepRecepcion, CodigoProducto As String, Sqldatos As String, RutaLogo As String
        Dim oDataRow As DataRow, Fecha As String, Registros As Double, i As Double, Buscar_Fila() As DataRow, Criterios As String = ""
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter, Posicion As Double = 0, DescripcionAnterior As String = ""


        Fecha = Format(CDate(Me.DTPFecha.Text), "yyyy-MM-dd")


        '*******************************************************************************************************************************
        '/////////////////////////AGREGO UNA CONSULTA QUE NUNCA TENDRA REGISTROS PARA PODER AGREGARLOS /////////////////////////////////
        '*******************************************************************************************************************************
        SqlString = "SELECT  id_Eventos, NumeroRecepcion, Fecha, TipoRecepcion, Cod_Productos, Descripcion_Producto, Codigo_Beams, Cantidad, Unidad_Medida  FROM Detalle_Recepcion WHERE (NumeroRecepcion = '-100000') AND (Fecha = CONVERT(DATETIME, '2013-10-12 00:00:00', 102)) AND (TipoRecepcion = N'Recepcion') ORDER BY Cantidad"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "Reporte")

        SqlString = "SELECT  id_Eventos, NumeroRecepcion, Fecha, TipoRecepcion, Cod_Productos, Descripcion_Producto, Codigo_Beams, Cantidad, Unidad_Medida  FROM Detalle_Recepcion WHERE (NumeroRecepcion = '" & Me.TxtNumeroEnsamble.Text & "') AND (Fecha = CONVERT(DATETIME, '" & Fecha & "', 102)) AND (TipoRecepcion = '" & Me.CboTipoRecepcion.Text & "') ORDER BY Cod_Productos DESC"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "Recepcion")
        Registros = DataSet.Tables("Recepcion").Rows.Count
        i = 0

        Do While Registros > i

            CodigoProducto = DataSet.Tables("Recepcion").Rows(i)("Cod_Productos")

            '//////////////////////////////////////////BUSCO SI NO EXISTE PARA AGREGAR UNO NUEVO ///////////////////////////
            Criterios = "Cod_Productos= '" & CodigoProducto & "'"
            Buscar_Fila = DataSet.Tables("Reporte").Select(Criterios)
            If Buscar_Fila.Length = 0 Then
                oDataRow = DataSet.Tables("Reporte").NewRow
                oDataRow("id_Eventos") = DataSet.Tables("Recepcion").Rows(i)("id_Eventos")
                oDataRow("NumeroRecepcion") = DataSet.Tables("Recepcion").Rows(i)("NumeroRecepcion")
                oDataRow("Fecha") = DataSet.Tables("Recepcion").Rows(i)("Fecha")
                oDataRow("TipoRecepcion") = DataSet.Tables("Recepcion").Rows(i)("TipoRecepcion")
                oDataRow("Cod_Productos") = DataSet.Tables("Recepcion").Rows(i)("Cod_Productos")
                oDataRow("Descripcion_Producto") = DataSet.Tables("Recepcion").Rows(i)("Descripcion_Producto")
                oDataRow("Codigo_Beams") = DataSet.Tables("Recepcion").Rows(i)("Codigo_Beams")
                oDataRow("Cantidad") = DataSet.Tables("Recepcion").Rows(i)("Cantidad")
                oDataRow("Unidad_Medida") = DataSet.Tables("Recepcion").Rows(i)("id_Eventos") & "-" & DataSet.Tables("Recepcion").Rows(i)("Cantidad") & "Lb"
                DataSet.Tables("Reporte").Rows.Add(oDataRow)
            Else
                Posicion = DataSet.Tables("Reporte").Rows.IndexOf(Buscar_Fila(0))
                DescripcionAnterior = DataSet.Tables("Reporte").Rows(Posicion)("Unidad_Medida")
                DataSet.Tables("Reporte").Rows(Posicion)("Unidad_Medida") = DescripcionAnterior & " , " & DataSet.Tables("Recepcion").Rows(i)("id_Eventos") & "-" & DataSet.Tables("Recepcion").Rows(i)("Cantidad") & "Lb"
                DataSet.Tables("Reporte").Rows(Posicion)("Cantidad") = DataSet.Tables("Reporte").Rows(Posicion)("Cantidad") + DataSet.Tables("Recepcion").Rows(i)("Cantidad")
            End If

            i = i + 1
        Loop

        Sqldatos = "SELECT * FROM DatosEmpresa"
        DataAdapter = New SqlClient.SqlDataAdapter(Sqldatos, MiConexion)
        DataAdapter.Fill(DataSet, "DatosEmpresa")

        If Not DataSet.Tables("DatosEmpresa").Rows.Count = 0 Then

            ArepRecepcion.LblEncabezado.Text = DataSet.Tables("DatosEmpresa").Rows(0)("Nombre_Empresa")
            ArepRecepcion.LblDireccion.Text = DataSet.Tables("DatosEmpresa").Rows(0)("Direccion_Empresa")

            If Not IsDBNull(DataSet.Tables("DatosEmpresa").Rows(0)("Numero_Ruc")) Then
                ArepRecepcion.LblRuc.Text = "Numero RUC " & DataSet.Tables("DatosEmpresa").Rows(0)("Numero_Ruc")
            End If
            If Not IsDBNull(DataSet.Tables("DatosEmpresa").Rows(0)("Ruta_Logo")) Then
                RutaLogo = DataSet.Tables("DatosEmpresa").Rows(0)("Ruta_Logo")
                If Dir(RutaLogo) <> "" Then
                    ArepRecepcion.ImgLogo.Image = New System.Drawing.Bitmap(RutaLogo)
                End If
            End If
        End If

        ArepRecepcion.LblLote.Text = Me.A�o & "-" & Me.Mes & "-" & Me.Dia & "-" & Me.CboCodigoProveedor.Text
        ArepRecepcion.LblNotas.Text = Me.txtobservaciones.Text
        ArepRecepcion.LblOrden.Text = Me.TxtNumeroEnsamble.Text
        ArepRecepcion.LblFechaOrden.Text = Format(CDate(Me.DTPFecha.Text), "dd/MM/yyyy")
        ArepRecepcion.LblTipoCompra.Text = Me.CboTipoRecepcion.Text
        'ArepRecepcion.LblCodProveedor.Text = Me.CboCodigoProveedor.Text
        ArepRecepcion.LblNombres.Text = Me.txtnombre.Text
        ArepRecepcion.LblApellidos.Text = Me.txtapellido.Text
        'ArepRecepcion.LblBodegas.Text = Me.CboCodigoBodega.Columns(0).Text + " " + Me.CboCodigoBodega.Columns(1).Text
        'ArepRecepcion.LblNombres.Text = Me.txtnombre.Text
        'ArepRecepcion.LblBodegas.Text = Me.CboCodigoBodega.Columns(0).Text + " " + Me.CboCodigoBodega.Columns(1).Text
        'ArepRecepcion.LblPila.Text = Me.txtapellido.Text
        'ArepRecepcion.LblConductor.Text = Me.CboConductor.Text
        'ArepRecepcion.LblCedula.Text = Me.txtid.Text
        'ArepRecepcion.LblPlaca.Text = Me.txtplaca.Text

        Dim ViewerForm As New FrmViewer()
        ViewerForm.arvMain.Document = ArepRecepcion.Document
        My.Application.DoEvents()

        ArepRecepcion.DataSource = DataSet.Tables("Reporte")
        ArepRecepcion.Run(False)
        ViewerForm.Show()

    End Sub

    Private Sub BtnTikectRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTikectRec.Click

    End Sub


    Private Sub CboFinca_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboFinca.SelectedValueChanged
        Dim StrSqlSelect As String, Sql As String
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter


        StrSqlSelect = "SELECT  IdPlantillo, Plantillo, IdFinca, IdVariedad, Activo   FROM    Plantillo   WHERE     (IdFinca = '" & Me.CboFinca.SelectedValue & "')"
        DataAdapter = New SqlClient.SqlDataAdapter(StrSqlSelect, MiConexion)
        DataAdapter.Fill(DataSet, "ListaPlantillos")
        Me.CboPlantillo.DataSource = DataSet.Tables("ListaPlantillos")
        Me.CboPlantillo.Splits.Item(0).DisplayColumns(0).Visible = False
        Me.CboPlantillo.Splits.Item(0).DisplayColumns(2).Visible = False
        Me.CboPlantillo.Splits.Item(0).DisplayColumns(3).Visible = False
        Me.CboPlantillo.Splits.Item(0).DisplayColumns(4).Visible = False
        Me.CboPlantillo.Text = "SELECCIONE"
    End Sub

    Private Sub CboTipoRecepcion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboTipoRecepcion.SelectedIndexChanged

    End Sub

    Private Sub BtnBuscarRecep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscarRecep.Click
        Quien = "RecepcionBusqueda"
        My.Forms.FrmConsultas.Text = "Consulta Recibo"
        My.Forms.FrmConsultas.ShowDialog()
        If My.Forms.FrmConsultas.Codigo <> "- - - - - 0 - - - - - " Then
            CodigoRecepcion = FrmConsultas.Codigo
            Me.TxtNumeroEnsamble.Text = CodigoRecepcion.Substring(2)
        End If
    End Sub

    Private Sub TxtNumeroEnsamble_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNumeroEnsamble.TextChanged
        Dim StrSqlSelect As String, Sql As String, i As Integer
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter


        StrSqlSelect = "SELECT  NumeroRecepcion, TipoRecepcion, Fecha, Cod_Proveedor, Cod_SubProveedor, Conductor, Id_identificacion, Id_Placa, Cod_Bodega, Observaciones, SubTotal, Telefono, Cancelar, Activo, Seleccion, Peso, Lote,  Contabilizado, FechaHora  FROM  Recepcion  WHERE      (NumeroRecepcion = N'" & CodigoRecepcion & "')  "
        DataAdapter = New SqlClient.SqlDataAdapter(StrSqlSelect, MiConexion)
        DataAdapter.Fill(DataSet, "SeleccionRecep")
        If DataSet.Tables("SeleccionRecep").Rows.Count > 0 Then

            If Not IsDBNull(DataSet.Tables("SeleccionRecep").Rows(0)("TipoRecepcion")) Then
                If DataSet.Tables("SeleccionRecep").Rows(0)("TipoRecepcion") = "PESADA MANUAL" Then
                    Me.CboTipoRecepcion.SelectedItem = 1
                ElseIf DataSet.Tables("SeleccionRecep").Rows(0)("TipoRecepcion") = "PESADA AUTOMATICA" Then
                    Me.CboTipoRecepcion.SelectedItem = 2
                End If
            End If
            If Not IsDBNull(DataSet.Tables("SeleccionRecep").Rows(0)("Fecha")) Then
                DTPFecha.Text = DataSet.Tables("SeleccionRecep").Rows(0)("Fecha")
            End If
            Timer1.Stop()
            If Not IsDBNull(DataSet.Tables("SeleccionRecep").Rows(0)("FechaHora")) Then
                LblHora.Text = CStr(DataSet.Tables("SeleccionRecep").Rows(0)("FechaHora")).Substring(11)
            End If
            If Not IsDBNull(DataSet.Tables("SeleccionRecep").Rows(0)("FechaHora")) Then
                LblHora.Text = CStr(DataSet.Tables("SeleccionRecep").Rows(0)("FechaHora")).Substring(11)
            End If
            If Not IsDBNull(DataSet.Tables("SeleccionRecep").Rows(0)("NumeroRecepcion")) Then
                Me.CmbSerie.Text = CStr(DataSet.Tables("SeleccionRecep").Rows(0)("NumeroRecepcion")).Substring(0, 2)
            End If
            If Not IsDBNull(DataSet.Tables("SeleccionRecep").Rows(0)("Cod_Proveedor")) Then
                Me.CboCodigoProveedor.SelectedValue = DataSet.Tables("SeleccionRecep").Rows(0)("Cod_Proveedor")
            End If
            If Not IsDBNull(DataSet.Tables("SeleccionRecep").Rows(0)("TrueDBGridComponentes")) Then
                Me.CboFinca.SelectedValue = DataSet.Tables("SeleccionRecep").Rows(0)("TrueDBGridComponentes")
            End If
        End If
    End Sub

    Private Sub BtnRecpSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRecpSalir.Click
        Me.Close()
    End Sub
End Class