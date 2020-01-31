Public Class FrmRecepcion
    Public MiConexion As New SqlClient.SqlConnection(Conexion), Año As String, Mes As String, Dia As String, ConsecutivoSerieActivo As Boolean = False
    '/////////////VARIABLES A LIMPIAR/////////////
    Public CodigoNotaPeso As String, IdProductor As Integer = 0, ActualizarSerie As Boolean = False, TotalPesoLb As Double, TotalPesoKG As Double
    Public Departamento As String, Municipio As String, Comarca As String, PesoBrutoLb As Double = 0, TaraLb As Double = 0, CantidaSacos As Integer
    Delegate Sub delegado(ByVal data As String)
    Private Sub Compra()

        Dim ComandoUpdate As New SqlClient.SqlCommand
        Dim ConsecutivoCompra As Double, NumeroCompra As String, iPosicion As Double, Registros As Double
        Dim CodigoProducto As String, PrecioUnitario As Double, Descuento As Double, PrecioFOB As Double, PrecioCosto As Double, Cantidad As Double
        Dim PrecioNeto As Double, Importe As Double
        Dim StrSqlUpdate As String, iResultado As Integer, SqlString As String
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim Fecha As String, MontoIva As Double, Sql As String




        ConsecutivoCompra = BuscaConsecutivo("Compra")
        NumeroCompra = Format(ConsecutivoCompra, "0000#")
        Fecha = Format(CDate(Me.DTPFecha.Text), "yyyy-MM-dd")


        '////////////////////////////////////////////////////////////////////////////////////////////////////
        '/////////////////////////////GRABO EL ENCABEZADO DE LA COMPRA /////////////////////////////////////////////
        '//////////////////////////////////////////////////////////////////////////////////////////////////////////7
        GrabaEncabezadoCompras(NumeroCompra, CDate(Me.DTPFecha.Text), "Mercancia Recibida", Me.TxtCodProductor.Text, Me.CboCodigoBodega.Text, Me.CboProductor.Text, "-", CDate(Me.DTPFecha.Text), 0, 0, 0, 0, "Cordobas", "Procesado por Bascula " & Me.TxtNumeroEnsamble.Text)


        '////////////////////////////////////////////////////////////////////////////////////////////////////
        '/////////////////////////////GRABO EL DETALLE DE LA COMPRA /////////////////////////////////////////////
        '//////////////////////////////////////////////////////////////////////////////////////////////////////////

        Sql = "SELECT  Cod_Productos, Descripcion_Producto, SUM(Cantidad) AS Cantidad, SUM(Precio) AS Precio, SUM(PesoKg) AS PesoKg, SUM(Tara) AS Tara, SUM(PesoNetoLb) AS PesoNetoLb, SUM(PesoNetoKg) AS PesoNetoKg, SUM(QQ) AS QQ  FROM Detalle_Recepcion GROUP BY NumeroRecepcion, TipoRecepcion, Cod_Productos, Descripcion_Producto " & _
              "HAVING (NumeroRecepcion = '" & Me.TxtNumeroEnsamble.Text & "') AND (TipoRecepcion = 'Recepcion')"
        DataAdapter = New SqlClient.SqlDataAdapter(Sql, MiConexion)
        DataAdapter.Fill(DataSet, "DetalleRecepcion")


        Registros = DataSet.Tables("DetalleRecepcion").Rows.Count
        iPosicion = 0

        Do While iPosicion < Registros
            CodigoProducto = DataSet.Tables("DetalleRecepcion").Rows(iPosicion)("Cod_Productos")

            'If Not IsDBNull(Me.BindingDetalle.Item(iPosicion)("Descuento")) Then
            '    Descuento = Me.BindingDetalle.Item(iPosicion)("Descuento")
            'End If
            PrecioFOB = 0 'Me.BindingDetalle.Item(iPosicion)("FOB")
            PrecioCosto = 0 'Me.BindingDetalle.Item(iPosicion)("Precio_Costo")
            Descuento = 0
            If Not IsDBNull(DataSet.Tables("DetalleRecepcion").Rows(iPosicion)("PesoNetoKg")) Then
                Cantidad = DataSet.Tables("DetalleRecepcion").Rows(iPosicion)("PesoNetoKg")
                PrecioUnitario = 0 'PrecioCosto / Cantidad
            End If
            PrecioNeto = PrecioUnitario * Cantidad
            Importe = PrecioCosto - Descuento

            GrabaDetalleCompraLiquidacion(NumeroCompra, CodigoProducto, PrecioUnitario, Descuento, PrecioUnitario, Importe, Cantidad, "Cordobas", CDate(Me.DTPFecha.Text))
            ExistenciasCostos(CodigoProducto, Cantidad, PrecioUnitario, "Mercancia Recibida", Me.CboCodigoBodega.Text, CDate(Me.DTPFecha.Text), "Cordobas")


            iPosicion = iPosicion + 1
        Loop

        MiConexion.Close()

        StrSqlUpdate = "UPDATE [Recepcion] SET [Numero_Compra] = '" & NumeroCompra & "' ,[Tipo_Compra] = 'Mercancia Recibida' ,[Fecha_Compra] = '" & CDate(Me.DTPFecha.Text) & "' ,[Procesado] = 1 WHERE  (NumeroRecepcion = '" & Me.TxtNumeroEnsamble.Text & "') AND (TipoRecepcion = 'Recepcion')"
        MiConexion.Open()
        ComandoUpdate = New SqlClient.SqlCommand(StrSqlUpdate, MiConexion)
        iResultado = ComandoUpdate.ExecuteNonQuery
        MiConexion.Close()

        MsgBox("Se ha Procesado con la Compra " & NumeroCompra, MsgBoxStyle.Information, "Zeus Facturacion")



    End Sub
    Public Sub ExistenciasCostos(ByVal CodigoProductos As String, ByVal CantidadCompra As Double, ByVal PrecioCompra As Double, ByVal Tipo As String, ByVal CodBodega As String, ByVal Fecha As Date, ByVal TipoMoneda As String)
        Dim SqlString As String, DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter, CodigoBodega As String, iPosicionFila As Double
        Dim MiConexion As New SqlClient.SqlConnection(Conexion), Existencia As Double, CostoPromedio As Double, Costo As Double
        Dim SqlUpdate As String, ComandoUpdate As New SqlClient.SqlCommand, iResultado As Integer, ExistenciaBodega As Double, ExistenciaTotal As Double
        Dim TasaCambio As String, CostoPromedioDolar As Double

        DataSet.Reset()
        'SqlString = "SELECT *  FROM Productos WHERE (Cod_Productos = '" & CodigoProductos & "')"
        SqlString = "SELECT SUM(Cantidad) AS Cantidad, AVG(Precio_Neto) AS PrecioNeto, SUM(Cantidad * Precio_Neto) AS Costo_Promedio, Cod_Producto FROM Detalle_Compras GROUP BY Cod_Producto  " & _
                    "HAVING  (Cod_Producto = '" & CodigoProductos & "')"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "Consulta")
        Existencia = 0
        Costo = 0
        If Not DataSet.Tables("Consulta").Rows.Count = 0 Then
            'If Not IsDBNull(DataSet.Tables("Consulta").Rows(0)("Existencia_Unidades")) Then
            '    'Existencia = DataSet.Tables("Consulta").Rows(0)("Existencia_Unidades")
            'End If
            If Not IsDBNull(DataSet.Tables("Consulta").Rows(0)("Costo_Promedio")) Then
                Costo = DataSet.Tables("Consulta").Rows(0)("Costo_Promedio")
            End If
        End If



        DataSet.Tables("Consulta").Clear()
        'SqlString = "SELECT Cod_Bodegas, Cod_Productos, Existencia  FROM DetalleBodegas WHERE (Cod_Bodegas = '" & CodBodega & "') AND (Cod_Productos = '" & CodigoProductos & "')"
        SqlString = "SELECT Cod_Bodegas, Cod_Productos, Existencia  FROM DetalleBodegas WHERE (Cod_Productos = '" & CodigoProductos & "')"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "Consulta")

        'If Not DataSet.Tables("Consulta").Rows.Count = 0 Then
        '    If Not IsDBNull(DataSet.Tables("Consulta").Rows(0)("Existencia")) Then
        '        'ExistenciaBodega = DataSet.Tables("Consulta").Rows(0)("Existencia")
        '    End If
        'End If
        Existencia = 0
        iPosicionFila = 0
        Do While iPosicionFila < (DataSet.Tables("Consulta").Rows.Count)
            My.Application.DoEvents()
            CodigoBodega = DataSet.Tables("Consulta").Rows(iPosicionFila)("Cod_Bodegas")
            Existencia = Existencia + BuscaExistenciaBodega(CodigoProductos, CodigoBodega)

            iPosicionFila = iPosicionFila + 1
        Loop

        '////////////////////777LA EXISTENCIA YA TIENE ACUMULADO TODO INCLUSIVE LA COMPRA O VENTA/////////////////
        ExistenciaBodega = BuscaExistenciaBodega(CodigoProductos, CodBodega)


        Select Case Tipo
            Case "Mercancia Recibida"
                '///////////////////////////FORMULA DE COMPRA PROMEDIO////////////////////////////////////////////////////////////////
                ' CostoPromedio= ((Existencia*Costo)+(PrecioCompra*CantidadCompra))/(Existencia+CantidadComprada)
                '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                '///////////////////LA VARIABLE EXISTENCIA TIENE TAMBIEN ACUMULADA LA COMPRA ACTUAL////////////////////////////////////
                'Existencia + CantidadCompra
                Existencia = Math.Abs(Existencia - CantidadCompra)
                TasaCambio = BuscaTasaCambio(Fecha)

                If TasaCambio = 0 Then
                    MsgBox("la Tasa de Cambio es Cero", MsgBoxStyle.Critical, "Zeus Facturacion")
                End If

                If (Existencia + CantidadCompra) <> 0 Then
                    If TipoMoneda = "Cordobas" Then
                        'CostoPromedio = Format(((Existencia * Costo) + (PrecioCompra * CantidadCompra)) / (Existencia + CantidadCompra), "##,##0.00")
                        CostoPromedio = (Costo / (Existencia + CantidadCompra))
                        CostoPromedioDolar = Format(CostoPromedio / TasaCambio, "##,##0.00")
                    Else
                        CostoPromedioDolar = Format(((Existencia * Costo) + (PrecioCompra * CantidadCompra)) / (Existencia + CantidadCompra), "##,##0.000")
                        CostoPromedio = Format(CostoPromedioDolar * TasaCambio, "##,##0.00")
                    End If
                End If

                ExistenciaTotal = Existencia + CantidadCompra



                '///////////////////////////////////////ACTUALIZO LA EXISTENCIA DE PRODUCTOS////////////////////////////////////////////////////////////////
                SqlUpdate = "UPDATE [Productos] SET [Existencia_Unidades] = " & ExistenciaTotal & ",[Costo_Promedio] = " & CostoPromedio & " ,[Costo_Promedio_Dolar] = " & CostoPromedioDolar & ", [Ultimo_Precio_Compra] = " & PrecioCompra & " ,[Existencia_Dinero] = " & ExistenciaTotal * CostoPromedio & ",[Existencia_DineroDolar] = " & ExistenciaTotal * CostoPromedioDolar & " " & _
                            "WHERE (Cod_Productos = '" & CodigoProductos & "')"
                MiConexion.Open()
                ComandoUpdate = New SqlClient.SqlCommand(SqlUpdate, MiConexion)
                iResultado = ComandoUpdate.ExecuteNonQuery
                MiConexion.Close()


                '////////////////////////////////////////////ACTUALIZO LA EXISTENCIA DE LA BODEGA////////////////////////////////////////////////////////
                SqlUpdate = "UPDATE [DetalleBodegas] SET [Existencia] = " & ExistenciaBodega & " " & _
                            "WHERE (Cod_Bodegas = '" & CodBodega & "') AND (Cod_Productos = '" & CodigoProductos & "') "
                MiConexion.Open()
                ComandoUpdate = New SqlClient.SqlCommand(SqlUpdate, MiConexion)
                iResultado = ComandoUpdate.ExecuteNonQuery
                MiConexion.Close()



            Case "Devolucion de Compra"
                '///////////////////////////FORMULA DE COMPRA PROMEDIO////////////////////////////////////////////////////////////////
                ' CostoPromedio= ((Existencia*Costo)+(PrecioCompra*CantidadCompra))/(Existencia+CantidadComprada)
                '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                '///////////////////LA VARIABLE EXISTENCIA TIENE TAMBIEN ACUMULADA LA DEVOLUCION ACTUAL////////////////////////////////////
                'Existencia + CantidadCompra
                Existencia = Math.Abs(Existencia + CantidadCompra)

                If (Existencia - CantidadCompra) <> 0 Then
                    CostoPromedio = Format(((Existencia * Costo) - (PrecioCompra * CantidadCompra)) / (Existencia - CantidadCompra), "##,##0.00")
                Else
                    CostoPromedio = 0
                End If

                ExistenciaTotal = Existencia - CantidadCompra
                '///////////////////////////////////////ACTUALIZO LA EXISTENCIA DE PRODUCTOS////////////////////////////////////////////////////////////////
                SqlUpdate = "UPDATE [Productos] SET [Existencia_Unidades] = " & ExistenciaTotal & ",[Costo_Promedio] = " & CostoPromedio & " ,[Ultimo_Precio_Compra] = " & PrecioCompra & " ,[Existencia_Dinero] = " & ExistenciaTotal * CostoPromedio & " " & _
                            "WHERE (Cod_Productos = '" & CodigoProductos & "')"
                MiConexion.Open()
                ComandoUpdate = New SqlClient.SqlCommand(SqlUpdate, MiConexion)
                iResultado = ComandoUpdate.ExecuteNonQuery
                MiConexion.Close()


                '////////////////////////////////////////////ACTUALIZO LA EXISTENCIA DE LA BODEGA////////////////////////////////////////////////////////
                SqlUpdate = "UPDATE [DetalleBodegas] SET [Existencia] = " & ExistenciaBodega & " " & _
                            "WHERE (Cod_Bodegas = '" & CodBodega & "') AND (Cod_Productos = '" & CodigoProductos & "') "
                MiConexion.Open()
                ComandoUpdate = New SqlClient.SqlCommand(SqlUpdate, MiConexion)
                iResultado = ComandoUpdate.ExecuteNonQuery
                MiConexion.Close()
            Case "Factura"

                '///////////////////LA VARIABLE EXISTENCIA TIENE TAMBIEN ACUMULADA LA FACTURA ACTUAL////////////////////////////////////
                'Existencia + CantidadCompra
                Existencia = Math.Abs(Existencia + CantidadCompra)

                ExistenciaTotal = Existencia - CantidadCompra



                '///////////////////////////////////////ACTUALIZO LA EXISTENCIA DE PRODUCTOS////////////////////////////////////////////////////////////////
                SqlUpdate = "UPDATE [Productos] SET [Existencia_Unidades] = " & ExistenciaTotal & " ,[Ultimo_Precio_Venta] = " & PrecioCompra & " ,[Existencia_Dinero] = " & ExistenciaTotal * Costo & " " & _
                            "WHERE (Cod_Productos = '" & CodigoProductos & "')"
                MiConexion.Open()
                ComandoUpdate = New SqlClient.SqlCommand(SqlUpdate, MiConexion)
                iResultado = ComandoUpdate.ExecuteNonQuery
                MiConexion.Close()


                '////////////////////////////////////////////ACTUALIZO LA EXISTENCIA DE LA BODEGA////////////////////////////////////////////////////////
                SqlUpdate = "UPDATE [DetalleBodegas] SET [Existencia] = " & ExistenciaBodega & " " & _
                            "WHERE (Cod_Bodegas = '" & CodBodega & "') AND (Cod_Productos = '" & CodigoProductos & "') "
                MiConexion.Open()
                ComandoUpdate = New SqlClient.SqlCommand(SqlUpdate, MiConexion)
                iResultado = ComandoUpdate.ExecuteNonQuery
                MiConexion.Close()

            Case "Devolucion de Venta"
                '///////////////////LA VARIABLE EXISTENCIA TIENE TAMBIEN ACUMULADA LA FACTURA ACTUAL////////////////////////////////////
                'Existencia + CantidadCompra
                Existencia = Math.Abs(Existencia - CantidadCompra)

                ExistenciaTotal = Existencia + CantidadCompra



                '///////////////////////////////////////ACTUALIZO LA EXISTENCIA DE PRODUCTOS////////////////////////////////////////////////////////////////
                SqlUpdate = "UPDATE [Productos] SET [Existencia_Unidades] = " & ExistenciaTotal & " ,[Ultimo_Precio_Venta] = " & PrecioCompra & " ,[Existencia_Dinero] = " & ExistenciaTotal * Costo & " " & _
                            "WHERE (Cod_Productos = '" & CodigoProductos & "')"
                MiConexion.Open()
                ComandoUpdate = New SqlClient.SqlCommand(SqlUpdate, MiConexion)
                iResultado = ComandoUpdate.ExecuteNonQuery
                MiConexion.Close()


                '////////////////////////////////////////////ACTUALIZO LA EXISTENCIA DE LA BODEGA////////////////////////////////////////////////////////
                SqlUpdate = "UPDATE [DetalleBodegas] SET [Existencia] = " & ExistenciaBodega & " " & _
                            "WHERE (Cod_Bodegas = '" & CodBodega & "') AND (Cod_Productos = '" & CodigoProductos & "') "
                MiConexion.Open()
                ComandoUpdate = New SqlClient.SqlCommand(SqlUpdate, MiConexion)
                iResultado = ComandoUpdate.ExecuteNonQuery
                MiConexion.Close()
        End Select



    End Sub







    Private Sub FrmRecepcion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim sql As String, ComandoUpdate As New SqlClient.SqlCommand
        Dim SqlProductos As String, SqlString As String, Ruta As String, LeeArchivo As String, i As Integer

        DataSet.Reset()
        'CARGO LOS DATOS DE LA EMPRESA
        sql = "SELECT * FROM DatosEmpresa"
        DataAdapter = New SqlClient.SqlDataAdapter(sql, MiConexion)
        DataAdapter.Fill(DataSet, "DatosEmpresa")
        If Not DataSet.Tables("DatosEmpresa").Rows.Count = 0 Then
            ConsecutivoSerieActivo = DataSet.Tables("DatosEmpresa").Rows(0)("ConsecutivoFacSerie")
        End If
        'CARGO LAS SERIES EN CASO DE QUE LA EMPRESA PERMITA ESE DATO
        If Me.ConsecutivoSerieActivo = True Then
            Me.CmbSerie.Visible = True
            SqlString = "SELECT DISTINCT Serie FROM ConsecutivoSerie ORDER BY Serie DESC"
            DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
            DataAdapter.Fill(DataSet, "ConsecutivoSerie")
            If Not DataSet.Tables("ConsecutivoSerie").Rows.Count = 0 Then
                Me.CmbSerie.DataSource = DataSet.Tables("ConsecutivoSerie")
                Me.CmbSerie.Text = DataSet.Tables("ConsecutivoSerie").Rows(0)("Serie")
            End If
        Else
            Me.CmbSerie.Visible = False
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

        'SqlString = "SELECT DISTINCT RecibimosDe   FROM    Recepcion   WHERE  (Activo = 1)"
        'DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        'DataAdapter.Fill(DataSet, "RecibimosDe")
        'Me.CboRecibimosde.DataSource = DataSet.Tables("RecibimosDe")

        '///////////////////////////////CARGO EL DETALLE DE PESADAS/////////////////////////////////////////////////////
        PegarGridPesada(-7878)

        Me.DTPFecha.Text = Format(Now, "dd/MM/yyyy")
        Año = Microsoft.VisualBasic.DateAndTime.Year(Now)
        Mes = Microsoft.VisualBasic.DateAndTime.Month(Now)
        Dia = Microsoft.VisualBasic.DateAndTime.Day(Now)
        Me.CboTipoPesada.SelectedIndex = 1
        Me.CboCalidad.SelectedIndex = 1
        Me.CboEstado.SelectedIndex = 1

        LimpiarImperfeccion()

        SqlString = "SELECT IdVariedad, Variedad  FROM  Variedad"
        MiConexion.Open()
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "Variedades")
        If Not DataSet.Tables("Variedades").Rows.Count = 0 Then
            Me.CboVariedad.DataSource = DataSet.Tables("Variedades")
        End If
        MiConexion.Close()
    End Sub
    Private Sub LimpiarImperfeccion()
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim sql As String, ComandoUpdate As New SqlClient.SqlCommand
        Dim SqlProductos As String, SqlString As String

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
    End Sub



    Private Sub PegarGridPesada(ByVal NumeroNtPeso As String)
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim sql As String, ComandoUpdate As New SqlClient.SqlCommand


        sql = "SELECT  id_Eventos As Linea,Cod_Productos, Descripcion_Producto, Calidad, Estado, QQ As Saco, Cantidad, PesoKg, Tara, PesoNetoLb, PesoNetoKg, Precio  FROM Detalle_Recepcion  WHERE (NumeroRecepcion = N'" & NumeroNtPeso & "')"
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

        SumaDetalleNotaPeso()
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


            ArepRecepcion.ArepLblNombreEmpresa.Text = DataSet.Tables("DatosEmpresa").Rows(0)("Nombre_Empresa")
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

        ArepRecepcion.LblHora.Text = Me.Año & "-" & Me.Mes & "-" & Me.Dia & "-" & Me.TxtCodProductor.Text
        ' ArepRecepcion.LblNotas.Text = Me.txtobservaciones.Text
        ArepRecepcion.LblOrden.Text = Me.TxtNumeroEnsamble.Text
        ArepRecepcion.LblFechaOrden.Text = Format(CDate(Me.DTPFecha.Text), "dd/MM/yyyy")
        ArepRecepcion.LblTipoCompra.Text = Me.CboTipoPesada.Text
        'ArepRecepcion.LblCodProveedor.Text = Me.CboCodigoProveedor.Text
        'ArepRecepcion.LblNombres.Text = Me.TxtRConacafe.Text
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
        Dim Resultado As String, Posicion As Double, CodigoLinea As String = "", NumeroEnsamble As String
        Dim CodigoIngreso As String = "", SqlString As String = "", Fecha As String

        Resultado = MsgBox("¿Esta Seguro de Eliminar el Ingreso?", MsgBoxStyle.YesNo, "Sistema de Facturacion")

        If Resultado <> 6 Then
            Exit Sub
        End If

        If ConsecutivoSerieActivo = True Then
            NumeroEnsamble = Me.CmbSerie.Text & "-" & Me.TxtNumeroEnsamble.Text
            ConsecutivoSerieActivo = True
        Else
            NumeroEnsamble = Me.TxtNumeroEnsamble.Text
        End If

        Posicion = Me.BindingDetalle.Position
        If Not IsDBNull(Me.BindingDetalle.Item(Posicion)("Linea")) Then
            CodigoLinea = Me.BindingDetalle.Item(Posicion)("Linea")
        End If

        Fecha = Format(CDate(Me.DTPFecha.Text), "yyyy-MM-dd")

        SQLProveedor = "SELECT  *  FROM Detalle_Recepcion WHERE (NumeroRecepcion = '" & Me.TxtNumeroEnsamble.Text & "') AND (Fecha = CONVERT(DATETIME, '" & Fecha & "', 102)) AND (id_Eventos = " & CodigoLinea & ")"
        DataAdapter = New SqlClient.SqlDataAdapter(SQLProveedor, MiConexion)
        DataAdapter.Fill(DataSet, "Deducciones")
        If Not DataSet.Tables("Deducciones").Rows.Count = 0 Then
            '///////////SI EXISTE EL USUARIO LO ACTUALIZO////////////////
            MiConexion.Close()
            StrSqlUpdate = "DELETE FROM [Detalle_Recepcion] WHERE (NumeroRecepcion = '" & Me.TxtNumeroEnsamble.Text & "') AND (Fecha = CONVERT(DATETIME, '" & Fecha & "', 102))  AND (id_Eventos = " & CodigoLinea & ")"
            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(StrSqlUpdate, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            MiConexion.Close()
        End If

        '///////////////////////////////CARGO EL DETALLE DE COMPRAS////////////////////////
        PegarGridPesada(NumeroEnsamble)
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
        Me.TrueDBDetalleNP.Row = Me.TrueDBDetalleNP.RowCount
        If VerificacionNotasdePeso(2) = True Then
            FrmTeclado.ShowDialog()
            Pesada = FrmTeclado.Numero
            If Pesada <> 0 Then
                Me.TrueDBDetalleNP.Columns(6).Text = Pesada
                My.Application.DoEvents()
                GrabaLecturaPeso(Pesada, ConsecutivoSerieActivo)
                SumaDetalleNotaPeso()
                Me.TrueDBDetalleNP.Row = Me.TrueDBDetalleNP.RowCount + 1
            Else
                MsgBox("El Peso no puede ser 0.00 ", MsgBoxStyle.Exclamation, "Notas de Peso")
                Exit Sub
            End If
        End If
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
        LimpiarImperfeccion()
        PegarGridPesada(-7878)
    End Sub
    Public Sub SumaDetalleNotaPeso()

        Dim Registros As Double, i As Integer

        PesoBrutoLb = 0
        TaraLb = 0
        TotalPesoLb = 0
        TotalPesoKG = 0
        CantidaSacos = 0

        Registros = Me.TrueDBDetalleNP.RowCount
        i = 0
        Do While Registros > i
            If IsDBNull(Me.TrueDBDetalleNP.Item(i)(9)) = True Or Me.TrueDBDetalleNP.Item(i)(9).ToString().Trim() = "" Then
                Me.TrueDBDetalleNP.Item(i)(9) = 0.0
            End If

            If IsDBNull(Me.TrueDBDetalleNP.Item(i)(10)) = True Or Me.TrueDBDetalleNP.Item(i)(10).ToString().Trim() = "" Then
                Me.TrueDBDetalleNP.Item(i)(10) = 0.0
            End If

            If IsDBNull(Me.TrueDBDetalleNP.Item(i)(6)) = True Or Me.TrueDBDetalleNP.Item(i)(6).ToString().Trim() = "" Then
                Me.TrueDBDetalleNP.Item(i)(6) = 0.0
            End If

            If IsDBNull(Me.TrueDBDetalleNP.Item(i)(8)) = True Or Me.TrueDBDetalleNP.Item(i)(8).ToString().Trim() = "" Then
                Me.TrueDBDetalleNP.Item(i)(8) = 0.0
            End If

            If IsDBNull(Me.TrueDBDetalleNP.Item(i)(5)) = True Or Me.TrueDBDetalleNP.Item(i)(5).ToString().Trim() = "" Then
                Me.TrueDBDetalleNP.Item(i)(5) = 0.0
            End If

            PesoBrutoLb = Me.TrueDBDetalleNP.Item(i)(6) + PesoBrutoLb
            TaraLb = Me.TrueDBDetalleNP.Item(i)(8) + TaraLb
            TotalPesoLb = Me.TrueDBDetalleNP.Item(i)(9) + TotalPesoLb
            TotalPesoKG = Me.TrueDBDetalleNP.Item(i)(10) + TotalPesoKG
            CantidaSacos = Me.TrueDBDetalleNP.Item(i)(5) + CantidaSacos
            i = i + 1
        Loop
        Me.txtsubtotal.Text = TotalPesoLb
    End Sub

    Private Sub BtnGuardarRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardarRec.Click
        Dim NumeroEnsamble As String
        If ConsecutivoSerieActivo = True Then
            NumeroEnsamble = Me.CmbSerie.Text & "-" & Me.TxtNumeroEnsamble.Text
            ConsecutivoSerieActivo = True
        Else
            NumeroEnsamble = Me.TxtNumeroEnsamble.Text
        End If

        If VerificacionNotasdePeso(1) = True Then
            GrabaRecepcion(NumeroEnsamble, ActualizarSerie, 1)
            GrabaImperfeccion(NumeroEnsamble)
            LimpiaRecepcion()
            LimpiarImperfeccion()
            PegarGridPesada(-7878)
        Else
            Exit Sub
        End If
    End Sub
    Public Function VerificacionNotasdePeso(ByVal Tipo As Integer) As Boolean
        'tipo = 1 cuando se hace va a guardar desde el boton guardar 
        'tipo = 2 cuando se guarda desde el boton pesada
        If Me.CboPlaca.Text.Trim() = "" Then
            MsgBox("Para poder continuar con la acción por favor seleccione una Placa de vehiculo", MsgBoxStyle.Exclamation, "Verificación de datos")
            Return False
        ElseIf Me.CboConductor.Text.Trim() = "" Then
            MsgBox("Para poder continuar con la acción por favor seleccione un Conductor del vehiculo", MsgBoxStyle.Exclamation, "Verificación de datos")
            Return False
        ElseIf Me.CboProductor.Text.Trim() = "" Then
            MsgBox("Para poder continuar con la acción por favor seleccione un Productor", MsgBoxStyle.Exclamation, "Verificación de datos")
            Return False
        ElseIf Me.CboRecibimosde.Text.Trim() = "" Then
            MsgBox("Para poder continuar con la acción por favor seleccione o digite de quien Recibió el Café", MsgBoxStyle.Exclamation, "Verificación de datos")
            Return False
        ElseIf Me.CboFinca.Text.Trim() = "" Then
            MsgBox("Para poder continuar con la acción por favor seleccione una Finca", MsgBoxStyle.Exclamation, "Verificación de datos")
            Return False
        ElseIf Me.CboPlantillo.Text.Trim() = "" Then
            MsgBox("Para poder continuar con la acción por favor seleccione un Plantillo", MsgBoxStyle.Exclamation, "Verificación de datos")
            Return False
        ElseIf Me.CboCalidad.Text.Trim() = "" Then
            MsgBox("Para poder continuar con la acción por favor seleccione la Calidad del Café", MsgBoxStyle.Exclamation, "Verificación de datos")
            Return False
        ElseIf Me.CboVariedad.Text.Trim() = "" Then
            MsgBox("Para poder continuar con la acción por favor seleccione la Variedad del Café", MsgBoxStyle.Exclamation, "Verificación de datos")
            Return False
        ElseIf Me.CboCodigoBodega.Text.Trim() = "" Then
            MsgBox("Para poder continuar con la acción por favor seleccione la Bodega", MsgBoxStyle.Exclamation, "Verificación de datos")
            Return False
        ElseIf Me.BindingDetalle.Count = 0 Then
            If Tipo = 1 Then
                MsgBox("Para poder continuar con la acción por favor debe Realizar Pesadas", MsgBoxStyle.Exclamation, "Verificación de datos")
                Return False
            ElseIf Tipo = 2 Then
                Return True
            End If
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
        Dim SQL As New DataDynamics.ActiveReports.DataSources.SqlDBDataSource, SqlString As String, Hora As Date
        Dim ArepRecepcion As New ArepRecepcion, CodigoProducto As String, Sqldatos As String, RutaLogo As String
        Dim TPesoneto As Double = 0, TTara As Double = 0, TPBruto As Double = 0
        Dim oDataRow As DataRow, Fecha As String, Registros As Double, i As Double, Buscar_Fila() As DataRow, Criterios As String = ""
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter, Posicion As Double = 0, DescripcionAnterior As String = ""


        '*******************************************************************************************************************************
        '/////////////////////////AGREGO UNA CONSULTA QUE NUNCA TENDRA REGISTROS PARA PODER AGREGARLOS /////////////////////////////////
        '*******************************************************************************************************************************
        Sqldatos = "SELECT * FROM DatosEmpresa"
        DataAdapter = New SqlClient.SqlDataAdapter(Sqldatos, MiConexion)
        DataAdapter.Fill(DataSet, "DatosEmpresa")

        If Not DataSet.Tables("DatosEmpresa").Rows.Count = 0 Then

            ArepRecepcion.ArepLblNombreEmpresa.Text = DataSet.Tables("DatosEmpresa").Rows(0)("Nombre_Empresa")

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

        SqlString = "SELECT ROW_NUMBER() OVER(ORDER BY  FechaHora asc) AS No, Recepcion.NumeroRecepcion, Recepcion.FechaHora, Recepcion.RecibimosDe, Variedad.Variedad, SUM(Detalle_Recepcion.Cantidad) AS PesoBruto, SUM(Detalle_Recepcion.Tara) AS Tara, Recepcion.Estado,                           SUM(Detalle_Recepcion.PesoNetoLb) AS Pesoneto  FROM            Recepcion INNER JOIN                          Variedad ON Recepcion.Idvariedad = Variedad.IdVariedad INNER JOIN                          Detalle_Recepcion ON Recepcion.NumeroRecepcion = Detalle_Recepcion.NumeroRecepcion GROUP BY Recepcion.NumeroRecepcion, Recepcion.FechaHora, Recepcion.RecibimosDe, Variedad.Variedad, Recepcion.Estado  HAVING        (Recepcion.FechaHora BETWEEN CONVERT(DATETIME, '" & Fecha & " 00:00:00', 102) AND CONVERT(DATETIME, '" & Fecha & " 23:59:59', 102)) ORDER BY Recepcion.NumeroRecepcion "
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "Reporte")

        Registros = DataSet.Tables("Reporte").Rows.Count
        i = 0
        Do While Registros > i
            TPesoneto = DataSet.Tables("Recepcion").Rows(i)("Fecha") + TPesoneto
            TTara = DataSet.Tables("Recepcion").Rows(i)("Fecha") + TTara
            TPBruto = DataSet.Tables("Recepcion").Rows(i)("Fecha") + TPBruto
        Loop

        Fecha = Format(CDate(Now), "dd/MM/yyyy")
        Hora = Format(CDate(Date.Now.ToLongTimeString), "HH:mm:ss")

        ArepRecepcion.LblHora.Text = Hora
        ArepRecepcion.LblFechaOrden.Text = Fecha
        ArepRecepcion.LblOrden.Text = Me.TxtNumeroEnsamble.Text
        ArepRecepcion.LblTipoCompra.Text = Me.CboTipoPesada.Text

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

        StrSqlSelect = "SELECT    Plantillo.IdPlantillo, Plantillo.Plantillo, Plantillo.IdFinca, Plantillo.IdVariedad, Plantillo.Activo, Departamentos.Departamento, Municipio.Municipio, Comarca.Comarca FROM    Municipio INNER JOIN     Comarca ON Municipio.IdMunicipio = Comarca.IdMunicipio INNER JOIN     Plantillo INNER JOIN      Finca ON Plantillo.IdFinca = Finca.IdFinca ON Comarca.IdComarca = Finca.IdComarca INNER JOIN    Departamentos ON Municipio.IdDepartamento = Departamentos.IdDepartamento WHERE  (Plantillo.IdFinca = '" & Me.CboFinca.SelectedValue & "')"
        DataAdapter = New SqlClient.SqlDataAdapter(StrSqlSelect, MiConexion)
        DataAdapter.Fill(DataSet, "ListaPlantillos")
        Me.CboPlantillo.DataSource = DataSet.Tables("ListaPlantillos")

        If Not DataSet.Tables("ListaPlantillos").Rows.Count = 0 Then
            If Not IsDBNull(DataSet.Tables("ListaPlantillos").Rows(0)("IdPlantillo")) Then
                Me.CboPlantillo.SelectedValue = DataSet.Tables("ListaPlantillos").Rows(0)("IdPlantillo")
            End If
            If Not IsDBNull(DataSet.Tables("ListaPlantillos").Rows(0)("Departamento")) Then
                Departamento = DataSet.Tables("ListaPlantillos").Rows(0)("Departamento")
            End If
            If Not IsDBNull(DataSet.Tables("ListaPlantillos").Rows(0)("Municipio")) Then
                Municipio = DataSet.Tables("ListaPlantillos").Rows(0)("Municipio")
            End If
            If Not IsDBNull(DataSet.Tables("ListaPlantillos").Rows(0)("Comarca")) Then
                Comarca = DataSet.Tables("ListaPlantillos").Rows(0)("Comarca")
            End If
        End If

        Me.CboPlantillo.Splits.Item(0).DisplayColumns(0).Visible = False
        Me.CboPlantillo.Columns(1).Caption = "SELECCIONE UN PLANTILLO"
        Me.CboPlantillo.Splits.Item(0).DisplayColumns(2).Visible = False
        Me.CboPlantillo.Splits.Item(0).DisplayColumns(3).Visible = False
        Me.CboPlantillo.Splits.Item(0).DisplayColumns(4).Visible = False
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

        If ConsecutivoSerieActivo = True Then
            NumeroEnsamble = Me.CmbSerie.Text & "-" & Me.TxtNumeroEnsamble.Text
            ConsecutivoSerieActivo = True
        Else
            NumeroEnsamble = Me.TxtNumeroEnsamble.Text
        End If

        StrSqlSelect = "SELECT     NumeroRecepcion, TipoRecepcion, Fecha, Cod_Proveedor, Cod_SubProveedor, Conductor, Id_identificacion, Id_Placa, Cod_Bodega, Observaciones, SubTotal, Telefono, Cancelar, Peso, Lote, Contabilizado,   FechaHora, RecibimosDe, IdFinca, Calidad, Fermentado, Moho, Estado, Idvariedad, IdPlantillo, TipoPesada, Seleccion,CodRemision, CodConacafe, Activo FROM  Recepcion   WHERE (NumeroRecepcion = N'" & NumeroEnsamble & "')  "
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
            If Not IsDBNull(DataSet.Tables("SeleccionRecep").Rows(0)("CodRemision")) Then
                Me.TxtRemision.Text = DataSet.Tables("SeleccionRecep").Rows(0)("CodRemision")
            End If
            If Not IsDBNull(DataSet.Tables("SeleccionRecep").Rows(0)("CodConacafe")) Then
                Me.TxtRConacafe.Text = DataSet.Tables("SeleccionRecep").Rows(0)("CodConacafe")
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
            PegarGridPesada(NumeroEnsamble)
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
            Me.CboConductor.SelectedValue = FrmConsultas.Codigo
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

                StrSqlSelect = "SELECT DISTINCT RecibimosDe, Cod_Proveedor  FROM   Recepcion WHERE   (Cod_Proveedor = N'" & DataSet.Tables("Proveedor").Rows(0)("Cod_Proveedor") & "')"
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
                    IdProductor = DataSet.Tables("Proveedor").Rows(0)("IdProductor")
                    CargarFinca(IdProductor)
                End If
            End If
        Else
            Me.TxtCedulaProductor.Text = ""
            Me.TxtCodProductor.Text = ""
            StrSqlSelect = "SELECT DISTINCT RecibimosDe FROM   Recepcion WHERE   (Cod_Proveedor = N'-98989')"
            DataAdapter = New SqlClient.SqlDataAdapter(StrSqlSelect, MiConexion)
            DataAdapter.Fill(DataSet, "RecibimosDeUn")
            Me.CboRecibimosde.DataSource = DataSet.Tables("RecibimosDeUn")
            CargarFinca(-999)
        End If
    End Sub

    Private Sub CargarFinca(ByVal IdProductor As Integer)
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim StrSqlSelect As String
        StrSqlSelect = "SELECT   Finca.IdFinca, Finca.IdProductor, Finca.NomFinca   FROM   Finca INNER JOIN   Proveedor ON Finca.IdProductor = Proveedor.IdProductor   WHERE  (Finca.Activo = 1) AND (Finca.IdProductor = '" & IdProductor & "') ORDER BY Finca.IdFinca DESC"
        DataAdapter = New SqlClient.SqlDataAdapter(StrSqlSelect, MiConexion)
        DataAdapter.Fill(DataSet, "ListaFinca")
        Me.CboFinca.DataSource = DataSet.Tables("ListaFinca")
        Me.CboFinca.Splits.Item(0).DisplayColumns(0).Visible = False
        Me.CboFinca.Splits.Item(0).DisplayColumns(1).Visible = False
        If Not DataSet.Tables("ListaFinca").Rows.Count = 0 Then
            If Not IsDBNull(DataSet.Tables("ListaFinca").Rows(0)("NomFinca")) Then
                Me.CboFinca.Text = DataSet.Tables("ListaFinca").Rows(0)("NomFinca")
            End If
        Else
            Me.CboFinca.Text = ""
        End If
    End Sub

    'Private Sub CboFinca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim SqlProveedor As String, DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
    '    Dim StrSqlSelect As String

    '    SqlProveedor = "SELECT   Plantillo.IdPlantillo, Plantillo.Plantillo, Plantillo.IdVariedad, Plantillo.Activo, Finca.NomFinca  FROM   Plantillo INNER JOIN     Finca ON Plantillo.IdFinca = Finca.IdFinca WHERE (Plantillo.Activo = 1) AND (Finca.NomFinca = '" & Me.CboFinca.Text & "')"
    '    DataAdapter = New SqlClient.SqlDataAdapter(SqlProveedor, MiConexion)
    '    DataAdapter.Fill(DataSet, "PlantillosFincas")
    '    Me.CboPlantillo.DataSource = DataSet.Tables("PlantillosFincas")
    '    If Not DataSet.Tables("PlantillosFincas").Rows.Count = 0 Then
    '        If Not IsDBNull(DataSet.Tables("PlantillosFincas").Rows(0)("Plantillo")) Then
    '            Me.CboPlantillo.Text = DataSet.Tables("PlantillosFincas").Rows(0)("Plantillo")
    '        End If
    '    End If
    '    Me.CboPlantillo.Splits.Item(0).DisplayColumns(0).Visible = False
    'End Sub

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
            Me.BtnConectarRec.Enabled = False
            Me.BtnDisconectRec.Enabled = True
        ElseIf Me.CboTipoPesada.Text = "PESADA MANUAL" Then
            Me.BtnPesada.Enabled = True
            Me.BtnPesada.Visible = True
            Me.BtnConectarRec.Enabled = True
            Me.BtnDisconectRec.Enabled = False
        End If
    End Sub

    Private Sub BtnAgreFinca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgreFinca.Click
        My.Forms.FrmFincaPlantillo.Llamada = "RecepcionFincas"
        My.Forms.FrmFincaPlantillo.ShowDialog()
        CargarFinca(IdProductor)
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
                SumaGridImperfeccion()
                Me.TDGImperfeccion.Row = Me.TDGImperfeccion.Row + 1
            Else
                Me.TDGImperfeccion.Columns("%").Text = FrmTeclado.Numero
                SumaGridImperfeccion()
                If CDbl(Me.TxtImperfec.Text) > 100 Then
                    MsgBox("El número total de imperfeccion no puede ser mayor a 100%", MsgBoxStyle.Exclamation, "Notas de peso")
                    Me.TDGImperfeccion.Columns("%").Text = "0.00"
                    SumaGridImperfeccion()
                End If
            End If
        End If
    End Sub
    Private Sub TDGImperfeccion_AfterColUpdate(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles TDGImperfeccion.AfterColUpdate
        SumaGridImperfeccion()
    End Sub

    Public Sub SumaGridImperfeccion()
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

    Private Sub BtnTikectRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTikectRec.Click
        Dim SQL As New DataDynamics.ActiveReports.DataSources.SqlDBDataSource, SqlString As String, Sqldatos As String
        Dim ArepTikectRecepcion As New ArepTikectRecepcion, NumeroNotaPes As String, RutaLogo As String
        Dim Fecha As String, Criterios As String = "", StrImperfeccion As String, ArepSubReporte As New ArepSubReporte
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter, Posicion As Double = 0, DescripcionAnterior As String = ""

        If Not TxtNumeroEnsamble.Text = "- - - - - 0 - - - - -" Then

            Sqldatos = "SELECT * FROM DatosEmpresa"
            DataAdapter = New SqlClient.SqlDataAdapter(Sqldatos, MiConexion)
            DataAdapter.Fill(DataSet, "DatosEmpresa")
            If Not DataSet.Tables("DatosEmpresa").Rows.Count = 0 Then

                If Not IsDBNull(DataSet.Tables("DatosEmpresa").Rows(0)("Nombre_Empresa")) Then
                    ArepTikectRecepcion.ArepTxtNombreEmpresa.Text = DataSet.Tables("DatosEmpresa").Rows(0)("Nombre_Empresa")
                End If
                If Not IsDBNull(DataSet.Tables("DatosEmpresa").Rows(0)("Ruta_Logo")) Then
                    RutaLogo = DataSet.Tables("DatosEmpresa").Rows(0)("Ruta_Logo")
                    If Dir(RutaLogo) <> "" Then
                        ArepTikectRecepcion.ImgLogo.Image = New System.Drawing.Bitmap(RutaLogo)
                    End If
                End If
            End If
            Fecha = Format(CDate(Me.DTPFecha.Text), "dd/MM/yyyy") & " " & Me.LblHora.Text
            If ConsecutivoSerieActivo = True Then
                NumeroNotaPes = Me.CmbSerie.Text & "-" & Me.TxtNumeroEnsamble.Text
                ConsecutivoSerieActivo = True
            Else
                NumeroNotaPes = Me.TxtNumeroEnsamble.Text
            End If
            ArepTikectRecepcion.ArepTextNumEmsamble.Text = NumeroNotaPes
            ArepTikectRecepcion.ArepTextFecha.Text = Fecha
            ArepTikectRecepcion.ArepTxtPlaca.Text = Me.CboPlaca.Text
            ArepTikectRecepcion.ArepTxtMarca.Text = Me.TxtMarca.Text
            ArepTikectRecepcion.ArepTxtColor.Text = Me.TxtColor.Text
            ArepTikectRecepcion.ArepTxtChofer.Text = Me.CboConductor.Text
            ArepTikectRecepcion.ArepTxtRemision.Text = Me.TxtRemision.Text
            ArepTikectRecepcion.ArepTxtConacafe.Text = Me.TxtRConacafe.Text
            ArepTikectRecepcion.ArepTxtFinca.Text = Me.CboFinca.Text
            ArepTikectRecepcion.ArepTxtPlantillo.Text = Me.CboPlantillo.Text
            ArepTikectRecepcion.ArepTxtDepartam.Text = Departamento
            ArepTikectRecepcion.ArepTxtMunicipo.Text = Municipio
            ArepTikectRecepcion.ArepTxtComarca.Text = Comarca
            ArepTikectRecepcion.ArepTxtRecibimos.Text = Me.TxtRemision.Text
            ArepTikectRecepcion.ArepTxtConacafe.Text = Me.TxtRConacafe.Text
            ArepTikectRecepcion.ArepTxtRecibimos.Text = Me.CboRecibimosde.Text
            ArepTikectRecepcion.ArepTxtCedula.Text = Me.TxtCedulaProductor.Text
            ArepTikectRecepcion.ArepTxtPorCuenta.Text = Me.CboProductor.Text
            ArepTikectRecepcion.ArepTxtPesoBruto.Text = PesoBrutoLb
            ArepTikectRecepcion.ArepTxtHumedad.Text = Me.TxtHumedad.Text
            ArepTikectRecepcion.ArepTxtTara.Text = TaraLb
            ArepTikectRecepcion.ArepTxtPesoNeto.Text = TotalPesoLb
            ArepTikectRecepcion.ArepTxtCantidadSacos.Text = CantidaSacos
            ArepTikectRecepcion.ArepTxtCalidad.Text = Me.CboCalidad.Text
            ArepTikectRecepcion.ArepTxtVariedad.Text = Me.CboVariedad.Text
            ArepTikectRecepcion.ArepTxtImperfeccion.Text = Me.TxtImperfec.Text
            ArepTikectRecepcion.CheckMoho.Checked = Me.CheckMohoso.Checked
            ArepTikectRecepcion.ArepTxtFermento.Checked = Me.CheckFermento.Checked
            ArepTikectRecepcion.ArepTxtObservaciones.Text = Me.txtobservaciones.Text

            StrImperfeccion = "SELECT  id_Eventos As Linea, QQ As Saco,PesoNetoLb FROM Detalle_Recepcion  WHERE (NumeroRecepcion = N'" & NumeroNotaPes & "')"
            'DataAdapter = New SqlClient.SqlDataAdapter(StrImperfeccion, MiConexion)
            'DataAdapter.Fill(DataSet, "DatosPesada")

            SQL.ConnectionString = Conexion
            SQL.SQL = StrImperfeccion

            Dim ViewerForm As New FrmViewer(), i As Integer
            ViewerForm.arvMain.Document = ArepTikectRecepcion.Document
            My.Application.DoEvents()
            ArepTikectRecepcion.DataSource = SQL

            For i = 1 To 4
                If i = 1 Then
                    ArepTikectRecepcion.ArepLblTipo.Visible = True
                    ArepTikectRecepcion.ArepLblTipo.Text = "O R I G I N A L"
                    ArepTikectRecepcion.Run(False)
                    ViewerForm.arvMain.Document.Print(False, False, False)
                    'ViewerForm.Show()
                    My.Application.DoEvents()
                ElseIf i = 2 Then
                    ArepTikectRecepcion.ArepLblTipo.Visible = True
                    ArepTikectRecepcion.ArepLblTipo.Text = "T R A Z A B I L I D A D"
                    ArepTikectRecepcion.Run(False)
                    ' ViewerForm.arvMain.Document.Print(False, False, False)
                    ViewerForm.Show()
                    My.Application.DoEvents()
                ElseIf i = 3 Then
                    ArepTikectRecepcion.ArepLblTipo.Visible = True
                    ArepTikectRecepcion.ArepLblTipo.Text = "C O N T A B I L I D A D"
                    ArepTikectRecepcion.Run(False)
                    ' ViewerForm.arvMain.Document.Print(False, False, False)
                    ViewerForm.Show()
                    My.Application.DoEvents()
                ElseIf i = 4 Then
                    ArepTikectRecepcion.ArepLblTipo.Visible = True
                    ArepTikectRecepcion.ArepLblTipo.Text = "R E C I B I D O R"
                    ArepTikectRecepcion.Run(False)
                    ' ViewerForm.arvMain.Document.Print(False, False, False)
                    ViewerForm.Show()
                    My.Application.DoEvents()
                End If
            Next
        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Compra()
    End Sub
End Class