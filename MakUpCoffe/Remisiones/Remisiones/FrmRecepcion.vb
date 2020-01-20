Public Class FrmRecepcion
    Public MiConexion As New SqlClient.SqlConnection(Conexion), Año As String, Mes As String, Dia As String, ConsecutivoFacturaSerie As Boolean = False
    Public CodigoNotaPeso As String
    Delegate Sub delegado(ByVal data As String)
    Private Sub FrmRecepcion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim sql As String, ComandoUpdate As New SqlClient.SqlCommand
        Dim SqlProductos As String, SqlString As String, Ruta As String, LeeArchivo As String, i As Integer

        DataSet.Reset()
        '*CARGO LOS DATOS DE LA EMPRESA
        sql = "SELECT * FROM DatosEmpresa"
        DataAdapter = New SqlClient.SqlDataAdapter(sql, MiConexion)
        DataAdapter.Fill(DataSet, "DatosEmpresa")
        If Not DataSet.Tables("DatosEmpresa").Rows.Count = 0 Then
            ConsecutivoFacturaSerie = DataSet.Tables("DatosEmpresa").Rows(0)("ConsecutivoFacSerie")
        End If

        'CARGO LAS SERIES EN CASO DE QUE LA EMPRESA PERMITA ESE DATO
        If Me.ConsecutivoFacturaSerie = True Then
            Me.CmbSerie.Visible = True
            SqlString = "SELECT DISTINCT Serie FROM ConsecutivoSerie ORDER BY Serie DESC"
            DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
            DataAdapter.Fill(DataSet, "ConsecutivoSerie")
            If Not DataSet.Tables("ConsecutivoSerie").Rows.Count = 0 Then
                Me.CmbSerie.DataSource = DataSet.Tables("ConsecutivoSerie")
                Me.CmbSerie.Text = DataSet.Tables("ConsecutivoSerie").Rows(0)("Serie")
            End If
        End If
        'cargo las placas
        CargarPlacas()
        Me.CboPlaca.Text = ""

        '//////////////////////////CARGO LAS BODEGAS////////////////////////////////////////////////////////////////////
        SqlString = "SELECT   Cod_Bodega, Nombre_Bodega  FROM  Bodegas"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "Bodegas")
        Me.CboCodigoBodega.DataSource = DataSet.Tables("Bodegas")
        If Not DataSet.Tables("Bodegas").Rows.Count = 0 Then
            Me.CboCodigoBodega.Text = DataSet.Tables("Bodegas").Rows(0)("Nombre_Bodega")
        End If
        Me.CboCodigoBodega.Columns(0).Caption = "Codigo"
        Me.CboCodigoBodega.Columns(1).Caption = "Nombre Bodega"

        '//////////////////////////CARGO LOS CONDUCTORES/////////////////////////////////////////////////////////////////
        CargoConductores()
        Me.CboConductor.Text = ""

        '//////////////////////////CARGO LOS PRODUCTORES /////////////////////////////////////////////////////////////////
        CargarProductor()
        Me.CboProductor.Text = ""
        '//////////////////////////CARGO RECIBIMOS DE /////////////////////////////////////////////////////////////////
        SqlString = "SELECT DISTINCT RecibimosDe   FROM    Recepcion   WHERE  (Activo = 1)"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "RecibimosDe")
        Me.CboRecibimosde.DataSource = DataSet.Tables("RecibimosDe")

        '///////////////////////////////CARGO EL DETALLE DE PESADAS/////////////////////////////////////////////////////
        LimpiarGridPesada()

        Me.DTPFecha.Text = Format(Now, "dd/MM/yyyy")
        Año = Microsoft.VisualBasic.DateAndTime.Year(Now)
        Mes = Microsoft.VisualBasic.DateAndTime.Month(Now)
        Dia = Microsoft.VisualBasic.DateAndTime.Day(Now)
        Me.CboTipoPesada.SelectedIndex = 1
        Me.CboCalidad.SelectedIndex = 1
        Me.CboEstado.SelectedIndex = 1

        SqlString = "SELECT IdImperfeccion, Imperfeccion, activa,Porcentaje FROM Imperfeccion WHERE (activa = 1)"
        MiConexion.Open()
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "Imperfecciones")
        If Not DataSet.Tables("Imperfecciones").Rows.Count = 0 Then
            Me.BindingImperfeccion.DataSource = DataSet.Tables("Imperfecciones")
            Me.TDGImperfeccion.DataSource = Me.BindingImperfeccion
            Me.TDGImperfeccion.Splits.Item(0).DisplayColumns(0).Visible = False
            Me.TDGImperfeccion.Splits.Item(0).DisplayColumns(0).Locked = True
            Me.TDGImperfeccion.Splits.Item(0).DisplayColumns(1).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            Me.TDGImperfeccion.Splits.Item(0).DisplayColumns(1).Locked = True
            Me.TDGImperfeccion.Splits.Item(0).DisplayColumns(1).Width = 95
            Me.TDGImperfeccion.Splits.Item(0).DisplayColumns(2).Visible = False
            Me.TDGImperfeccion.Splits.Item(0).DisplayColumns(3).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            Me.TDGImperfeccion.Splits.Item(0).DisplayColumns(3).Width = 63
            Me.TDGImperfeccion.Columns(3).Caption = "%"
        End If
        MiConexion.Close()

        SqlString = "SELECT IdVariedad, Variedad  FROM  Variedad"
        MiConexion.Open()
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "Variedades")
        If Not DataSet.Tables("Variedades").Rows.Count = 0 Then
            Me.CboVariedad.DataSource = DataSet.Tables("Variedades")
        End If
        MiConexion.Close()
    End Sub
    Private Sub LimpiarGridPesada()
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim sql As String, ComandoUpdate As New SqlClient.SqlCommand

        sql = "SELECT  id_Eventos As Linea, Cod_Productos, Descripcion_Producto, Calidad, Estado, QQ As Saco, Cantidad, PesoKg, Tara, PesoNetoLb, PesoNetoKg, Precio  FROM Detalle_Recepcion  WHERE (NumeroRecepcion = N'-100000')"
        DataAdapter = New SqlClient.SqlDataAdapter(sql, MiConexion)
        DataAdapter.Fill(DataSet, "DetalleRecepcion")
        Me.BindingDetalle.DataSource = DataSet.Tables("DetalleRecepcion")
        Me.TrueDBDetalleNP.DataSource = Me.BindingDetalle

        Me.TrueDBDetalleNP.Columns(0).Caption = "N°"
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(0).Width = 90
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(0).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(0).Locked = True

        Me.TrueDBDetalleNP.Columns(1).Caption = "CODVARIEDAD"
        'Me.TxtNombreProducto.Splits.Item(0).DisplayColumns(1).Button = True
        'Me.TxtNombreProducto.Splits.Item(0).DisplayColumns(1).Width = 63
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(1).Visible = False

        Me.TrueDBDetalleNP.Columns(2).Caption = "VARIEDAD"
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(2).Width = 300
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(2).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(2).Locked = True

        Me.TrueDBDetalleNP.Columns(3).Caption = "CALIDAD"
        'Me.TxtNombreProducto.Splits.Item(0).DisplayColumns(3).Width = 50
        'Me.TxtNombreProducto.Splits.Item(0).DisplayColumns(3).Locked = True
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns("CALIDAD").Visible = False

        Me.TrueDBDetalleNP.Columns(4).Caption = "ESTADO"
        'Me.TxtNombreProducto.Splits.Item(0).DisplayColumns(4).Width = 50
        'Me.TxtNombreProducto.Splits.Item(0).DisplayColumns(4).Locked = True
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns("ESTADO").Visible = False

        Me.TrueDBDetalleNP.Columns(5).Caption = "SACOS"
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(5).Width = 95
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(5).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(5).Locked = True


        Me.TrueDBDetalleNP.Columns(6).Caption = "PESO/lb"
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(6).Width = 95
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(6).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(6).Locked = True

        Me.TrueDBDetalleNP.Columns(7).Caption = "PESO/kg"
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(7).Width = 94
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(7).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(7).Locked = True


        Me.TrueDBDetalleNP.Columns(8).Caption = "TARA/lb"
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(8).Width = 95
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(8).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(8).Locked = True

        Me.TrueDBDetalleNP.Columns(9).Caption = "P.NETO/lb"
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(9).Width = 95
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(9).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(9).Locked = True

        Me.TrueDBDetalleNP.Columns(10).Caption = "P.NETO/kg"
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(10).Width = 95
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(10).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(10).Locked = True

        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(11).Width = 93
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(11).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(11).Locked = True
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(11).Visible = False

    End Sub
    Private Sub CargarPlacas()
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim sql As String, ComandoUpdate As New SqlClient.SqlCommand, SqlString As String

        SqlString = "SELECT   IdVehiculo, Placa FROM Vehiculo WHERE(Activo = 1)"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "Vehiculo")
        If Not DataSet.Tables("Vehiculo").Rows.Count = 0 Then
            Me.CboPlaca.DataSource = DataSet.Tables("Vehiculo")
            Me.CboPlaca.Text = DataSet.Tables("Vehiculo").Rows(DataSet.Tables("Vehiculo").Rows.Count - 1)("Placa")
        End If

    End Sub
    Private Sub CargarProductor()
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim sql As String, ComandoUpdate As New SqlClient.SqlCommand
        Dim SqlString As String

        SqlString = "SELECT  Cod_Proveedor, Nombre_Proveedor + ' ' + Apellido_Proveedor AS Nombre, IdProductor   FROM  Proveedor ORDER BY IdProductor DESC"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "Productores")
        Me.CboProductor.DataSource = DataSet.Tables("Productores")
        If DataSet.Tables("Productores").Rows.Count = 0 Then
            If Not IsDBNull(DataSet.Tables("Productores").Rows(0)("Nombre")) Then
                Me.CboProductor.Text = DataSet.Tables("Productores").Rows(0)("Nombre")
                Me.CboProductor.DisplayMember = "IdProductor"
                Me.CboProductor.SelectedValue = "Nombre"
            End If
        End If
        Me.CboProductor.Splits.Item(0).DisplayColumns(0).Visible = False
        Me.CboProductor.Splits.Item(0).DisplayColumns(2).Visible = False
    End Sub

    Private Sub CargoConductores()
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim sql As String, SqlProductos As String, SqlString As String

        SqlString = "SELECT Codigo, Nombre, Cedula, Licencia, Activo, ListaNegra, RazonListaNegra  FROM  Conductor  WHERE (Activo = 1) ORDER BY Codigo DESC"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "Conductor")
        Me.CboConductor.DataSource = DataSet.Tables("Conductor")
        If Not DataSet.Tables("Conductor").Rows.Count = 0 Then
            If Not IsDBNull(DataSet.Tables("Conductor").Rows(0)("Nombre")) Then
                Me.CboConductor.Text = DataSet.Tables("Conductor").Rows(0)("Nombre")
            End If
        Else
            Me.CboConductor.Text = ""
        End If
        Me.CboConductor.Columns(0).Caption = "Codigo"
    End Sub
    Private Sub Siguiente()
        If Me.TrueDBDetalleNP.RowCount <> 0 Then
            Dim Iposicion As Double
            Iposicion = Me.TrueDBDetalleNP.RowCount
            Me.TrueDBDetalleNP.Row = Iposicion
            'Me.TrueDBGridComponentes.Columns(1).Text = Me.CboCodigoProducto.Columns(0).Text
            'Me.TrueDBGridComponentes.Columns(2).Text = Me.CboCodigoProducto.Columns(1).Text
            Me.TrueDBDetalleNP.Col = 5
        End If

    End Sub

    Private Sub FrmRecepcion_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Button10_Click(sender, e)
    End Sub
    Private Sub CmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LimpiaRecepcion()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.LblHora.Text = Date.Now.ToLongTimeString
    End Sub

    Private Sub CboConductor_TextChanged_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboConductor.TextChanged

        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim sql As String, ComandoUpdate As New SqlClient.SqlCommand 'iResultado As Integer
        Dim SqlProductos As String, SqlString As String, Codigo As String
        '//////////////////////////CARGO LOS CONDUCTORES////////////////////////////////////////////////////////////////////
        SqlString = "SELECT Codigo, Nombre, Cedula, Licencia, Activo, ListaNegra, RazonListaNegra FROM Conductor WHERE (Activo = 1) AND (Nombre =N'" & Me.CboConductor.Text & "')"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "Conductor")
        If Not DataSet.Tables("Conductor").Rows.Count = 0 Then
            Me.TxtCedulaConductor.Text = DataSet.Tables("Conductor").Rows(0)("Cedula")
        Else
            Me.TxtCedulaConductor.Text = ""
        End If
        Me.CboConductor.Columns(0).Caption = "Codigo"
    End Sub

    Private Sub CboPlaca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboPlaca.TextChanged
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim sql As String, ComandoUpdate As New SqlClient.SqlCommand 'iResultado As Integer
        Dim SqlProductos As String, SqlString As String, Codigo As String

        SqlString = "SELECT  IdVehiculo, Placa, Marca, Modelo, Color, TipoVehiculo, Activo FROM Vehiculo WHERE(Activo = 1) AND (Placa = '" & Me.CboPlaca.Text & "')"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "Placas")
        If Not DataSet.Tables("Placas").Rows.Count = 0 Then
            If Not IsDBNull(DataSet.Tables("Placas").Rows(0)("Marca")) Then
                Me.TxtMarca.Text = DataSet.Tables("Placas").Rows(0)("Marca")
            End If

            If Not IsDBNull(DataSet.Tables("Placas").Rows(0)("Modelo")) Then
                Me.TxtModelo.Text = DataSet.Tables("Placas").Rows(0)("Modelo")
            End If

            If Not IsDBNull(DataSet.Tables("Placas").Rows(0)("Color")) Then
                Me.TxtColor.Text = DataSet.Tables("Placas").Rows(0)("Color")
            End If
        Else
            Me.TxtMarca.Text = ""
            Me.TxtModelo.Text = ""
            Me.TxtColor.Text = ""
        End If
    End Sub
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Forms.FrmPuertos.ShowDialog()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.sp.Close()
        Me.LblEstado.Text = "DESCONECTADO"
        Me.LblEstado.ForeColor = Color.Black
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

        SqlString = "SELECT  id_Eventos, NumeroRecepcion, Fecha, TipoRecepcion, Cod_Productos, Descripcion_Producto, Codigo_Beams, Cantidad, Unidad_Medida  FROM Detalle_Recepcion WHERE (NumeroRecepcion = '" & Me.TxtNumeroEnsamble.Text & "') AND (Fecha = CONVERT(DATETIME, '" & Fecha & "', 102)) AND (TipoRecepcion = '" & Me.CboTipoPesada.Text & "') ORDER BY Cod_Productos DESC"
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

        ArepRecepcion.LblLote.Text = Me.Año & "-" & Me.Mes & "-" & Me.Dia & "-" & Me.TxtCodProductor.Text
        ArepRecepcion.LblNotas.Text = Me.txtobservaciones.Text
        ArepRecepcion.LblOrden.Text = Me.TxtNumeroEnsamble.Text
        ArepRecepcion.LblFechaOrden.Text = Format(CDate(Me.DTPFecha.Text), "dd/MM/yyyy")
        ArepRecepcion.LblTipoCompra.Text = Me.CboTipoPesada.Text
        'ArepRecepcion.LblCodProveedor.Text = Me.CboCodigoProveedor.Text
        ArepRecepcion.LblNombres.Text = Me.TxtRConacafe.Text
        'ArepRecepcion.LblApellidos.Text = Me.txtapellido.Text
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

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim SQLProveedor As String, Sql As String
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim StrSqlUpdate As String, ComandoUpdate As New SqlClient.SqlCommand, iResultado As Integer
        Dim Resultado As String, Posicion As Double, CodigoLinea As String = ""
        Dim CodigoIngreso As String = "", SqlString As String = "", Fecha As String

        Resultado = MsgBox("¿Esta Seguro de Eliminar el Ingreso?", MsgBoxStyle.YesNo, "Sistema de Facturacion")

        If Resultado <> 6 Then
            Exit Sub
        End If

        Posicion = Me.BindingDetalle.Position
        If Not IsDBNull(Me.BindingDetalle.Item(Posicion)("Linea")) Then
            CodigoLinea = Me.BindingDetalle.Item(Posicion)("Linea")
        End If

        Fecha = Format(CDate(Me.DTPFecha.Text), "yyyy-MM-dd")

        SQLProveedor = "SELECT  *  FROM Detalle_Recepcion WHERE (NumeroRecepcion = '" & Me.TxtNumeroEnsamble.Text & "') AND (Fecha = CONVERT(DATETIME, '" & Fecha & "', 102)) AND (TipoRecepcion = '" & Me.CboTipoPesada.Text & "') AND (id_Eventos = " & CodigoLinea & ")"
        DataAdapter = New SqlClient.SqlDataAdapter(SQLProveedor, MiConexion)
        DataAdapter.Fill(DataSet, "Deducciones")
        If Not DataSet.Tables("Deducciones").Rows.Count = 0 Then
            '///////////SI EXISTE EL USUARIO LO ACTUALIZO////////////////
            MiConexion.Close()
            StrSqlUpdate = "DELETE FROM [Detalle_Recepcion] WHERE (NumeroRecepcion = '" & Me.TxtNumeroEnsamble.Text & "') AND (Fecha = CONVERT(DATETIME, '" & Fecha & "', 102)) AND (TipoRecepcion = '" & Me.CboTipoPesada.Text & "') AND (id_Eventos = " & CodigoLinea & ")"
            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(StrSqlUpdate, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            MiConexion.Close()
        End If

        '///////////////////////////////CARGO EL DETALLE DE COMPRAS////////////////////////
        Sql = "SELECT  id_Eventos As Linea, Cod_Productos, Descripcion_Producto, Calidad, Estado, Cantidad, PesoKg, Tara, PesoNetoLb, PesoNetoKg, QQ As Saco, Precio  FROM Detalle_Recepcion   WHERE (NumeroRecepcion = '" & Me.TxtNumeroEnsamble.Text & "') AND (Fecha = CONVERT(DATETIME, '" & Fecha & "', 102)) AND (TipoRecepcion = '" & Me.CboTipoPesada.Text & "') "
        DataAdapter = New SqlClient.SqlDataAdapter(Sql, MiConexion)
        DataAdapter.Fill(DataSet, "DetalleRecepcion")
        Me.BindingDetalle.DataSource = DataSet.Tables("DetalleRecepcion")
        Me.TrueDBDetalleNP.DataSource = Me.BindingDetalle
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(0).Width = 40
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(0).Locked = True
        Me.TrueDBDetalleNP.Columns(0).Caption = "Psda"

        Me.TrueDBDetalleNP.Columns(1).Caption = "Código"
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(1).Button = True
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(1).Width = 63
        Me.TrueDBDetalleNP.Columns(2).Caption = "Descripción"
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(2).Width = 200
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(2).Locked = True
        Me.TrueDBDetalleNP.Columns(3).Caption = "Calidad"
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(3).Width = 50
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(3).Locked = True
        Me.TrueDBDetalleNP.Columns(4).Caption = "Estado"
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(4).Width = 50
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(4).Locked = True
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(5).Width = 75
        Me.TrueDBDetalleNP.Columns(5).Caption = "PesoLb"
        'Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(4).Locked = True
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(6).Width = 85
        'Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(2).Button = True
        'Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(3).Button = True
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(7).Width = 75
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(7).Locked = True
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(8).Width = 75
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(9).Width = 75
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(10).Width = 50
        Me.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(11).Width = 75

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
        Posicion = Me.TrueDBDetalleNP.Row
        Me.TrueDBDetalleNP.Columns(5).Text = Pesada
        'Me.LblPeso.Text = Pesada & " Kg"
        My.Application.DoEvents()
        GrabaLecturaPeso(Pesada, True)
        'Me.BindingDetalle.Position = Posicion + 1
        Me.TrueDBDetalleNP.Row = Posicion + 1
    End Sub

    Private Sub CmdPesada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPesada.Click
        Dim Pesada As Double, Posicion As Double
        Posicion = Me.TrueDBDetalleNP.Row
        FrmTeclado.ShowDialog()
        Pesada = FrmTeclado.Numero
        Me.LblPeso.Text = Pesada & " Kg"
        Me.TrueDBDetalleNP.Columns(6).Text = Pesada
        My.Application.DoEvents()
        GrabaLecturaPeso(Pesada, False)
        GrabaImperfeccion()
        Me.TrueDBDetalleNP.Row = Posicion + 1
    End Sub
    Public Sub GrabaImperfeccion()
        Dim count As Integer = Me.TDGImperfeccion.RowCount, i As Integer
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter, StrSqlSelect As String
        Dim StrSqlInsert As String, StrSqlUpdate As String, NumeroEnsamble As String
        Dim ComandoUpdate As New SqlClient.SqlCommand, iResultado As Integer

        If CmbSerie.Visible = True Then
            NumeroEnsamble = Me.CmbSerie.Text & "-" & Me.TxtNumeroEnsamble.Text
        Else
            NumeroEnsamble = Me.TxtNumeroEnsamble.Text
        End If

        StrSqlSelect = "SELECT IdDetalleImperfeccion, NumeroRecepcion, Imperfeccion, Porcentaje  FROM  DetalleImperfeccion  WHERE (NumeroRecepcion = N'" & NumeroEnsamble & "')"
        DataAdapter = New SqlClient.SqlDataAdapter(StrSqlSelect, MiConexion)
        DataAdapter.Fill(DataSet, "DetalleImperfeccion")

        i = 0
        Do While count > i
            If Not DataSet.Tables("DetalleImperfeccion").Rows.Count = 0 Then
                StrSqlInsert = " INSERT INTO [dbo].[DetalleImperfeccion]([NumeroRecepcion],[Imperfeccion],[Porcentaje])" & _
               " VALUES ('" & NumeroEnsamble & "','" & Me.TDGImperfeccion.Item(i)("Imperfeccion") & "', '" & Me.TDGImperfeccion.Item(i)("%") & "')"
                MiConexion.Open()
                ComandoUpdate = New SqlClient.SqlCommand(StrSqlInsert, MiConexion)
                iResultado = ComandoUpdate.ExecuteNonQuery
                MiConexion.Close()
            Else
                StrSqlUpdate = " UPDATE [dbo].[DetalleImperfeccion] SET [NumeroRecepcion] = '" & NumeroEnsamble & "' ,[Imperfeccion] = '" & Me.TDGImperfeccion.Item(i)("Imperfeccion") & "' ,[Porcentaje] ='" & Me.TDGImperfeccion.Item(i)("%") & "'  WHERE  (IdDetalleImperfeccion = '" & Me.TDGImperfeccion.Item(i)("IdDetalleImperfeccion") & "')"
                MiConexion.Open()
                ComandoUpdate = New SqlClient.SqlCommand(StrSqlUpdate, MiConexion)
                iResultado = ComandoUpdate.ExecuteNonQuery
                MiConexion.Close()
            End If
            i = i + 1
        Loop

        'Do While Registros > i
        '    If Me.TDGridDetalleRecibos.Item(i)("Aplicar") = True Then
        '        '____________________________________________
        '        'CONTADOR PARA VER CUANTOS VERDADEROS SON 
        '        '____________________________________________
        '        ContaTrue = ContaTrue + 1

        '        PesoBruto = Me.TDGridDetalleRecibos.Item(i)("PesoNeto") + PesoBruto
        '        valorCor = Me.TDGridDetalleRecibos.Item(i)("ValorBrutoC$") + valorCor
        '        ValorDol = Me.TDGridDetalleRecibos.Item(i)("ValorBruto$") + ValorDol
        '        i = i + 1
        '    Else
        '        i = i + 1
        '    End If
        'Loop
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Quien = "BusquedaProductor"
        My.Forms.FrmConsultas.Text = "Consulta Productor Recepción"
        My.Forms.FrmConsultas.ShowDialog()
        If My.Forms.FrmConsultas.Codigo <> "- - - - - 0 - - - - -" Then
            Me.TxtCodProductor.Text = FrmConsultas.Codigo
        End If
    End Sub

    Private Sub BtnNuevoRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevoRec.Click
        LimpiaRecepcion()
    End Sub

    Private Sub BtnGuardarRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardarRec.Click
        Dim NumeroEnsamble As String
        If CmbSerie.Visible = True Then
            NumeroEnsamble = Me.CmbSerie.Text & "-" & Me.TxtNumeroEnsamble.Text
        Else
            NumeroEnsamble = Me.TxtNumeroEnsamble.Text
        End If

        If VerificacionNotasdePeso() = True Then
            GrabaRecepcion(NumeroEnsamble, False, 1)
            GrabaImperfeccion()
            LimpiaRecepcion()
        Else
            Exit Sub
        End If
    End Sub
    Public Function VerificacionNotasdePeso() As Boolean
        If Me.CboPlaca.Text.Trim() = "" Then
            MsgBox("Para poder continuar con la acción de guardado por favor seleccione una Placa de vehiculo", MsgBoxStyle.Exclamation, "Verificación de datos")
            Return False
        ElseIf Me.CboConductor.Text.Trim() = "" Then
            MsgBox("Para poder continuar con la acción de guardado por favor seleccione un Conductor del vehiculo", MsgBoxStyle.Exclamation, "Verificación de datos")
            Return False
        ElseIf Me.CboProductor.Text.Trim() = "" Then
            MsgBox("Para poder continuar con la acción de guardado por favor seleccione un Productor", MsgBoxStyle.Exclamation, "Verificación de datos")
            Return False
        ElseIf Me.CboRecibimosde.Text.Trim() = "" Then
            MsgBox("Para poder continuar con la acción de guardado por favor seleccione o digite de quien Recibió el Café", MsgBoxStyle.Exclamation, "Verificación de datos")
            Return False
        ElseIf Me.CboFinca.Text.Trim() = "" Then
            MsgBox("Para poder continuar con la acción de guardado por favor seleccione una Finca", MsgBoxStyle.Exclamation, "Verificación de datos")
            Return False
        ElseIf Me.CboPlantillo.Text.Trim() = "" Then
            MsgBox("Para poder continuar con la acción de guardado por favor seleccione un Plantillo", MsgBoxStyle.Exclamation, "Verificación de datos")
            Return False
        ElseIf Me.CboCalidad.Text.Trim() = "" Then
            MsgBox("Para poder continuar con la acción de guardado por favor seleccione la Calidad del Café", MsgBoxStyle.Exclamation, "Verificación de datos")
            Return False
        ElseIf Me.CboVariedad.Text.Trim() = "" Then
            MsgBox("Para poder continuar con la acción de guardado por favor seleccione la Variedad del Café", MsgBoxStyle.Exclamation, "Verificación de datos")
            Return False
        ElseIf Me.CboCodigoBodega.Text.Trim() = "" Then
            MsgBox("Para poder continuar con la acción de guardado por favor seleccione la Bodega", MsgBoxStyle.Exclamation, "Verificación de datos")
            Return False
        ElseIf Me.BindingDetalle.Count = 0 Then
            MsgBox("Para poder continuar con la acción de guardado por favor debe Realizar Pesadas", MsgBoxStyle.Exclamation, "Verificación de datos")
            Return False
        Else
            Return True
        End If
    End Function

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

        SqlString = "SELECT  id_Eventos, NumeroRecepcion, Fecha, TipoRecepcion, Cod_Productos, Descripcion_Producto, Codigo_Beams, Cantidad, Unidad_Medida  FROM Detalle_Recepcion WHERE (NumeroRecepcion = '" & Me.TxtNumeroEnsamble.Text & "') AND (Fecha = CONVERT(DATETIME, '" & Fecha & "', 102)) AND (TipoRecepcion = '" & Me.CboTipoPesada.Text & "') ORDER BY Cod_Productos DESC"
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

        ArepRecepcion.LblLote.Text = Me.Año & "-" & Me.Mes & "-" & Me.Dia & "-" & Me.TxtCodProductor.Text
        ArepRecepcion.LblNotas.Text = Me.txtobservaciones.Text
        ArepRecepcion.LblOrden.Text = Me.TxtNumeroEnsamble.Text
        ArepRecepcion.LblFechaOrden.Text = Format(CDate(Me.DTPFecha.Text), "dd/MM/yyyy")
        ArepRecepcion.LblTipoCompra.Text = Me.CboTipoPesada.Text
        'ArepRecepcion.LblCodProveedor.Text = Me.CboCodigoProveedor.Text
        ArepRecepcion.LblNombres.Text = Me.TxtRConacafe.Text
        'ArepRecepcion.LblApellidos.Text = Me.txtapellido.Text
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
        Me.CboPlantillo.Text = "SELECCIONAR"
    End Sub

    Private Sub BtnBuscarRecep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscarRecep.Click
        Quien = "RecepcionBusqueda"
        My.Forms.FrmConsultas.Text = "Consulta Recibo"
        My.Forms.FrmConsultas.ShowDialog()
        If My.Forms.FrmConsultas.Codigo <> "- - - - - 0 - - - - -" Then
            CodigoNotaPeso = FrmConsultas.Codigo
            If CodigoNotaPeso.Length > 6 Then
                Me.TxtNumeroEnsamble.Text = CodigoNotaPeso.Substring(2)
                Me.CmbSerie.Text = CodigoNotaPeso.Substring(1, 1)
            Else
                Me.TxtNumeroEnsamble.Text = CodigoNotaPeso
            End If
        End If
    End Sub

    Private Sub TxtNumeroEnsamble_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNumeroEnsamble.TextChanged
        Dim StrSqlSelect As String, Sql As String, i As Integer, Numero As String
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter, NumeroEnsamble As String

        If CmbSerie.Visible = True Then
            NumeroEnsamble = Me.CmbSerie.Text & "-" & Me.TxtNumeroEnsamble.Text
        Else
            NumeroEnsamble = Me.TxtNumeroEnsamble.Text
        End If

        StrSqlSelect = "SELECT     NumeroRecepcion, TipoRecepcion, Fecha, Cod_Proveedor, Cod_SubProveedor, Conductor, Id_identificacion, Id_Placa, Cod_Bodega, Observaciones, SubTotal, Telefono, Cancelar, Peso, Lote, Contabilizado,   FechaHora, RecibimosDe, IdFinca, Calidad, Fermentado, Moho, Estado, Idvariedad, IdPlantillo, TipoPesada, Seleccion, Activo FROM  Recepcion   WHERE (NumeroRecepcion = N'" & NumeroEnsamble & "')  "
        DataAdapter = New SqlClient.SqlDataAdapter(StrSqlSelect, MiConexion)
        DataAdapter.Fill(DataSet, "SeleccionRecep")

        If DataSet.Tables("SeleccionRecep").Rows.Count > 0 Then
            If Not IsDBNull(DataSet.Tables("SeleccionRecep").Rows(0)("TipoRecepcion")) Then
                CboTipoRecepcion.Text = DataSet.Tables("SeleccionRecep").Rows(0)("TipoRecepcion")
            End If
            If Not IsDBNull(DataSet.Tables("SeleccionRecep").Rows(0)("TipoRecepcion")) Then
                CboTipoRecepcion.Text = DataSet.Tables("SeleccionRecep").Rows(0)("TipoRecepcion")
            End If
            If Not IsDBNull(DataSet.Tables("SeleccionRecep").Rows(0)("Fecha")) Then
                DTPFecha.Text = DataSet.Tables("SeleccionRecep").Rows(0)("Fecha")
            End If
            Timer1.Stop()
            If Not IsDBNull(DataSet.Tables("SeleccionRecep").Rows(0)("FechaHora")) Then
                LblHora.Text = CStr(DataSet.Tables("SeleccionRecep").Rows(0)("FechaHora")).Substring(11)
            End If
            If Not IsDBNull(DataSet.Tables("SeleccionRecep").Rows(0)("NumeroRecepcion")) Then
                Numero = Len(DataSet.Tables("SeleccionRecep").Rows(0)("NumeroRecepcion"))
                If Numero > 6 Then
                    Me.CmbSerie.Text = CStr(DataSet.Tables("SeleccionRecep").Rows(0)("NumeroRecepcion")).Substring(0, 1)
                Else
                    Me.CmbSerie.Enabled = False
                    Me.CmbSerie.Visible = False
                End If
            End If
            If Not IsDBNull(DataSet.Tables("SeleccionRecep").Rows(0)("Cod_Proveedor")) Then
                Me.CboProductor.SelectedValue = DataSet.Tables("SeleccionRecep").Rows(0)("Cod_Proveedor")
            End If
            If Not IsDBNull(DataSet.Tables("SeleccionRecep").Rows(0)("Conductor")) Then
                Me.CboConductor.Text = DataSet.Tables("SeleccionRecep").Rows(0)("Conductor")
            End If
            If Not IsDBNull(DataSet.Tables("SeleccionRecep").Rows(0)("Id_Placa")) Then
                Me.CboPlaca.Text = DataSet.Tables("SeleccionRecep").Rows(0)("Id_Placa")
            End If
            If Not IsDBNull(DataSet.Tables("SeleccionRecep").Rows(0)("IdFinca")) Then
                Me.CboFinca.SelectedValue = DataSet.Tables("SeleccionRecep").Rows(0)("IdFinca")
            End If
            If Not IsDBNull(DataSet.Tables("SeleccionRecep").Rows(0)("IdPlantillo")) Then
                Me.CboPlantillo.SelectedValue = DataSet.Tables("SeleccionRecep").Rows(0)("IdPlantillo")
            End If
            If Not IsDBNull(DataSet.Tables("SeleccionRecep").Rows(0)("Cod_Bodega")) Then
                Me.CboCodigoBodega.SelectedValue = DataSet.Tables("SeleccionRecep").Rows(0)("Cod_Bodega")
            End If
            If Not IsDBNull(DataSet.Tables("SeleccionRecep").Rows(0)("Observaciones")) Then
                Me.txtobservaciones.Text = DataSet.Tables("SeleccionRecep").Rows(0)("Observaciones")
            End If
            If Not IsDBNull(DataSet.Tables("SeleccionRecep").Rows(0)("RecibimosDe")) Then
                Me.CboRecibimosde.Text = DataSet.Tables("SeleccionRecep").Rows(0)("RecibimosDe")
            End If
            If Not IsDBNull(DataSet.Tables("SeleccionRecep").Rows(0)("Calidad")) Then
                Me.CboCalidad.Text = DataSet.Tables("SeleccionRecep").Rows(0)("Calidad")
            End If
            If Not IsDBNull(DataSet.Tables("SeleccionRecep").Rows(0)("Fermentado")) Then
                Me.CheckFermento.Checked = DataSet.Tables("SeleccionRecep").Rows(0)("Fermentado")
            End If
            If Not IsDBNull(DataSet.Tables("SeleccionRecep").Rows(0)("Moho")) Then
                Me.CheckMohoso.Checked = DataSet.Tables("SeleccionRecep").Rows(0)("Moho")
            End If
            If Not IsDBNull(DataSet.Tables("SeleccionRecep").Rows(0)("Estado")) Then
                Me.CboEstado.Text = DataSet.Tables("SeleccionRecep").Rows(0)("Estado")
            End If
            If Not IsDBNull(DataSet.Tables("SeleccionRecep").Rows(0)("Idvariedad")) Then
                Me.CboVariedad.SelectedValue = DataSet.Tables("SeleccionRecep").Rows(0)("Idvariedad")
            End If
            If Not IsDBNull(DataSet.Tables("SeleccionRecep").Rows(0)("IdPlantillo")) Then
                Me.CboPlantillo.SelectedValue = DataSet.Tables("SeleccionRecep").Rows(0)("IdPlantillo")
            End If
            If Not IsDBNull(DataSet.Tables("SeleccionRecep").Rows(0)("TipoPesada")) Then
                Me.CboTipoPesada.Text = DataSet.Tables("SeleccionRecep").Rows(0)("TipoPesada")
            End If

            StrSqlSelect = "SELECT  IdDetalleImperfeccion, NumeroRecepcion, Imperfeccion, Porcentaje  FROM  DetalleImperfeccion   WHERE  (NumeroRecepcion = N'" & NumeroEnsamble & "')"
            MiConexion.Close()
            MiConexion.Open()
            DataAdapter = New SqlClient.SqlDataAdapter(StrSqlSelect, MiConexion)
            DataAdapter.Fill(DataSet, "Imperfecciones")
            If Not DataSet.Tables("Imperfecciones").Rows.Count = 0 Then
                Me.BindingImperfeccion.DataSource = DataSet.Tables("Imperfecciones")
                Me.TDGImperfeccion.DataSource = Me.BindingImperfeccion
                Me.TDGImperfeccion.Splits.Item(0).DisplayColumns(0).Visible = False
                Me.TDGImperfeccion.Splits.Item(0).DisplayColumns(0).Locked = True
                Me.TDGImperfeccion.Splits.Item(0).DisplayColumns(1).Visible = False
                Me.TDGImperfeccion.Splits.Item(0).DisplayColumns(1).Locked = True
                Me.TDGImperfeccion.Splits.Item(0).DisplayColumns(2).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                Me.TDGImperfeccion.Splits.Item(0).DisplayColumns(2).Width = 95
                Me.TDGImperfeccion.Splits.Item(0).DisplayColumns(3).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                Me.TDGImperfeccion.Splits.Item(0).DisplayColumns(3).Width = 63
                Me.TDGImperfeccion.Columns(3).Caption = "%"
            End If
            MiConexion.Close()
        End If
    End Sub

    Private Sub BtnRecpSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRecpSalir.Click

        Me.Close()
    End Sub

    Private Sub BtnBusPlaca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBusPlaca.Click
        Quien = "ConsultaPlacaRecepción"
        My.Forms.FrmConsultas.Text = "Consulta Placa Recepción"
        My.Forms.FrmConsultas.ShowDialog()
        If My.Forms.FrmConsultas.Codigo <> "- - - - - 0 - - - - -" Then
            Me.CboPlaca.Text = FrmConsultas.Codigo
        End If
    End Sub

    Private Sub txtid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim sql As String, ComandoUpdate As New SqlClient.SqlCommand 'iResultado As Integer
        Dim SqlProductos As String, SqlString As String, Ruta As String, LeeArchivo As String

        'SqlProductos = "SELECT Cod_Productos, Descripcion_Producto FROM Productos WHERE (Tipo_Producto <> 'Servicio') AND (Tipo_Producto <> 'Descuento') AND (Cod_Productos = '" & Me.TxtCodProducto.Text & "')"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlProductos, MiConexion)
        DataAdapter.Fill(DataSet, "ListaProductos")
        If Not DataSet.Tables("ListaProductos").Rows.Count = 0 Then
            Me.TrueDBDetalleNP.Text = DataSet.Tables("ListaProductos").Rows(0)("Descripcion_Producto")
        End If
    End Sub

    Private Sub BtnTclCodProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmTeclado.ShowDialog()
        If FrmTeclado.Numero <> 0 Then
            ''Me.TxtCodProducto.Text = FrmTeclado.Numero
        End If
    End Sub

    Private Sub BtnBusConductor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBusConductor.Click
        Quien = "ConsultaConductorRecepcion"
        My.Forms.FrmConsultas.Text = "Consulta Conductor Recepcion"
        My.Forms.FrmConsultas.ShowDialog()
        If My.Forms.FrmConsultas.Codigo <> "- - - - - 0 - - - - -" Then
            Me.CboConductor.Text = FrmConsultas.Codigo
        End If
    End Sub

    Private Sub BtnConsProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Quien = "ConsultaProductoRecepcion"
        My.Forms.FrmConsultas.Text = "Consulta Producto Recepcion"
        My.Forms.FrmConsultas.ShowDialog()
        If My.Forms.FrmConsultas.Codigo <> "- - - - - 0 - - - - -" Then
            'Me.TxtCodProducto.Text = FrmConsultas.Codigo
        End If
    End Sub
    Private Sub BtnVehiculoAgre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVehiculoAgre.Click
        My.Forms.FrmVehiculo.Llamada = "RecepcionAgre"
        My.Forms.FrmVehiculo.ShowDialog()
        CargarPlacas()
    End Sub

    Private Sub BtnAgreConductor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgreConductor.Click
        My.Forms.FrmConductor.Llamada = "RecepcionConductor"
        My.Forms.FrmConductor.ShowDialog()
        CargoConductores()
    End Sub

    Private Sub CboProductor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboProductor.TextChanged
        Dim SqlProveedor As String, DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim StrSqlSelect As String
        Me.TxtCodProductor.Text = ""

        SqlProveedor = "SELECT Cod_Proveedor, Nombre_Proveedor + ' ' + Apellido_Proveedor AS Nombre, CedulaProveedor ,IdProductor FROM   Proveedor  WHERE     (Nombre_Proveedor + ' ' + Apellido_Proveedor = N'" & Me.CboProductor.Text & "')"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlProveedor, MiConexion)
        DataAdapter.Fill(DataSet, "Proveedor")
        If Not DataSet.Tables("Proveedor").Rows.Count = 0 Then

            If Not IsDBNull(DataSet.Tables("Proveedor").Rows(0)("CedulaProveedor")) Then
                Me.TxtCedulaProductor.Text = DataSet.Tables("Proveedor").Rows(0)("CedulaProveedor")
            End If

            If Not IsDBNull(DataSet.Tables("Proveedor").Rows(0)("Cod_Proveedor")) Then
                Me.TxtCodProductor.Text = DataSet.Tables("Proveedor").Rows(0)("Cod_Proveedor")
                StrSqlSelect = "SELECT DISTINCT RecibimosDe, Cod_Proveedor  FROM   Recepcion WHERE   (Cod_Proveedor = N'" & DataSet.Tables("Proveedor").Rows(0)("Cod_Proveedor") & "') AND (Activo = 1)"
                DataAdapter = New SqlClient.SqlDataAdapter(StrSqlSelect, MiConexion)
                DataAdapter.Fill(DataSet, "RecibimosDeUn")
                Me.CboRecibimosde.DataSource = DataSet.Tables("RecibimosDeUn")
                Me.CboRecibimosde.Splits.Item(0).DisplayColumns(1).Visible = False
                If Not DataSet.Tables("RecibimosDeUn").Rows.Count = 0 Then
                    If Not IsDBNull(DataSet.Tables("RecibimosDeUn").Rows(0)("RecibimosDe")) Then
                        Me.CboRecibimosde.Text = DataSet.Tables("RecibimosDeUn").Rows(0)("RecibimosDe")
                    End If
                Else
                    Me.CboRecibimosde.Text = ""
                End If

                '////////////////////////////////////////////////BUSCO FINCAS RELACIONADAS CON EL PRODUCTOR ///////////////////////////////////

                If Not IsDBNull(DataSet.Tables("Proveedor").Rows(0)("IdProductor")) Then
                    CargarFinca()
                End If
            End If
        Else
            Me.TxtCedulaProductor.Text = ""
            Me.TxtCodProductor.Text = ""
        End If
    End Sub

    Private Sub CargarFinca()
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim StrSqlSelect As String
        StrSqlSelect = "SELECT   IdFinca, IdProductor, NomFinca, IdComarca, Altitud, NotasdeCata, Emblaje, FechaActualizacion, Activo   FROM   Finca   WHERE   (Activo = 1)   ORDER BY IdFinca DESC"
        DataAdapter = New SqlClient.SqlDataAdapter(StrSqlSelect, MiConexion)
        DataAdapter.Fill(DataSet, "ListaFinca")
        Me.CboFinca.DataSource = DataSet.Tables("ListaFinca")
        Me.CboFinca.Splits.Item(0).DisplayColumns(0).Visible = False
        Me.CboFinca.Splits.Item(0).DisplayColumns(2).Visible = False
        If Not DataSet.Tables("ListaFinca").Rows.Count = 0 Then
            If Not IsDBNull(DataSet.Tables("ListaFinca").Rows(0)("NomFinca")) Then
                Me.CboFinca.Text = DataSet.Tables("ListaFinca").Rows(0)("NomFinca")
            End If
        Else
            Me.CboFinca.Text = ""
        End If
    End Sub

    Private Sub CboFinca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboFinca.TextChanged
        Dim SqlProveedor As String, DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim StrSqlSelect As String

        SqlProveedor = "SELECT   Plantillo.IdPlantillo, Plantillo.Plantillo, Plantillo.IdVariedad, Plantillo.Activo, Finca.NomFinca  FROM   Plantillo INNER JOIN     Finca ON Plantillo.IdFinca = Finca.IdFinca WHERE (Plantillo.Activo = 1) AND (Finca.NomFinca = '" & Me.CboFinca.Text & "')"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlProveedor, MiConexion)
        DataAdapter.Fill(DataSet, "PlantillosFincas")
        Me.CboPlantillo.DataSource = DataSet.Tables("PlantillosFincas")
        If Not DataSet.Tables("PlantillosFincas").Rows.Count = 0 Then
            If Not IsDBNull(DataSet.Tables("PlantillosFincas").Rows(0)("Plantillo")) Then
                Me.CboPlantillo.Text = DataSet.Tables("PlantillosFincas").Rows(0)("Plantillo")
            End If
        End If
        Me.CboPlantillo.Splits.Item(0).DisplayColumns(0).Visible = False
    End Sub

    Private Sub BtnAgreProductor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgreProductor.Click
        My.Forms.FrmProveedores.Llamada = "RecepcionProductores"
        My.Forms.FrmProveedores.ShowDialog()
        CargarProductor()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Quien = "BusquedaProductor"
        My.Forms.FrmConsultas.Text = "Consulta Productor"
        My.Forms.FrmConsultas.ShowDialog()
        If My.Forms.FrmConsultas.Codigo <> "- - - - - 0 - - - - -" Then
            Me.CboProductor.Text = FrmConsultas.Descripcion
        End If
    End Sub

    Private Sub CboTipoPesada_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboTipoPesada.SelectedIndexChanged
        If Me.CboTipoPesada.Text = "PESADA BASCULA" Then
            Me.BtnPesada.Enabled = False
            Me.BtnPesada.Visible = False
        ElseIf Me.CboTipoPesada.Text = "PESADA MANUAL" Then
            Me.BtnPesada.Enabled = True
            Me.BtnPesada.Visible = True
        End If
    End Sub

    Private Sub BtnAgreFinca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgreFinca.Click
        My.Forms.FrmFincaPlantillo.Llamada = "RecepcionFincas"
        My.Forms.FrmFincaPlantillo.ShowDialog()
        CargarFinca()
    End Sub

    Private Sub CboEstado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboEstado.SelectedIndexChanged
        If Me.CboEstado.Text = "OREADO" Then
            Me.TxtHumedad.Text = "0.00"
        ElseIf Me.CboEstado.Text = "MOJADO" Then
            Me.TxtHumedad.Text = "0.14"
        ElseIf Me.CboEstado.Text = "HUMEDO" Then
            Me.TxtHumedad.Text = "0.08"
        End If
    End Sub

    Private Sub TDGImperfeccion_ColEdit(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles TDGImperfeccion.ColEdit
        Dim Posicion As Integer = Me.TDGImperfeccion.Row

        If Me.TDGImperfeccion.Col <> 3 Then
            Exit Sub
        Else
            FrmTeclado.ShowDialog()
            If FrmTeclado.Numero > 100 Then
                MsgBox("El número no puede ser mayor a 100%", MsgBoxStyle.Exclamation, "Notas de peso")
                Me.TDGImperfeccion.Columns("%").Text = "0.00"
                sumagriddistribucion()
                Me.TDGImperfeccion.Row = Me.TDGImperfeccion.Row + 1
            Else
                Me.TDGImperfeccion.Columns("%").Text = FrmTeclado.Numero
                sumagriddistribucion()
                If CDbl(Me.TxtImperfec.Text) > 100 Then
                    MsgBox("El número total de imperfeccion no puede ser mayor a 100%", MsgBoxStyle.Exclamation, "Notas de peso")
                    Me.TDGImperfeccion.Columns("%").Text = "0.00"
                    sumagriddistribucion()
                End If
            End If
        End If
    End Sub
    Private Sub TDGImperfeccion_AfterColUpdate(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles TDGImperfeccion.AfterColUpdate
        sumagriddistribucion()
    End Sub

    Public Sub sumagriddistribucion()
        Dim Registros As Double, TotalProcentaje As Double, i As Integer
        Registros = Me.TDGImperfeccion.RowCount
        i = 0
        Do While Registros > i
            If IsDBNull(Me.TDGImperfeccion.Item(i)(3)) = True Or Me.TDGImperfeccion.Item(i)(3).ToString().Trim() = "" Then
                Me.TDGImperfeccion.Item(i)(3) = 0.0
            End If
            TotalProcentaje = Me.TDGImperfeccion.Item(i)(3) + TotalProcentaje
            i = i + 1
        Loop
        Me.TxtImperfec.Text = TotalProcentaje
    End Sub

    Private Sub TDGImperfeccion_BeforeColUpdate(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColUpdateEventArgs) Handles TDGImperfeccion.BeforeColUpdate
    End Sub
End Class