Imports Excel = Microsoft.Office.Interop

Module Funciones
    Public ActualizarSerie As Double
    '////////////////////// FUNCIONES DE RECEPCIONES //////////////////////////////////////////////////
    Public Sub GrabaEncabezadoCompras(ByVal ConsecutivoCompra As String, ByVal FechaCompra As String, ByVal TipoCompra As String, ByVal CodProveedor As String, ByVal CodBodega As String, ByVal Nombres As String, ByVal Apellidos As String, ByVal FechaVencimiento As String, ByVal SubTotal As Double, ByVal IVA As Double, ByVal Pagado As Double, ByVal Neto As Double, ByVal MonedaCompra As String, ByVal Observaciones As String)
        Dim SqlCompras As String, ComandoUpdate As New SqlClient.SqlCommand, iResultado As Integer
        Dim MiConexion As New SqlClient.SqlConnection(Conexion)
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim Fecha As Date, FechaHora As Date

        Fecha = FechaCompra
        FechaCompra = Format(Fecha, "dd/MM/yyyy")
        Fecha = FechaVencimiento
        FechaVencimiento = Format(Fecha, "dd/MM/yyyy")
        FechaHora = Format(Fecha, "dd/MM/yyyy") & " " & Format(Now, "HH:mm")

        MiConexion.Close()


        If ConsecutivoCompra <> "-----0-----" Then
            '//////////////////////////////////////////////////////////////////////////////////////////////
            '////////////////////////////AGREGO EL ENCABEZADO DE LA COMPRA///////////////////////////////////
            '/////////////////////////////////////////////////////////////////////////////////////////////////
            SqlCompras = "INSERT INTO [Compras] ([Numero_Compra] ,[Fecha_Compra],[Tipo_Compra],[Cod_Proveedor],[Cod_Bodega],[Nombre_Proveedor],[Apellido_Proveedor],[Fecha_Vencimiento],[Observaciones],[SubTotal],[IVA],[Pagado],[NetoPagar],[MontoCredito],[MonedaCompra],[FechaHora]) " & _
            "VALUES ('" & ConsecutivoCompra & "','" & FechaCompra & "','" & TipoCompra & "','" & CodProveedor & "','" & CodBodega & "' , '" & Nombres & "','" & Apellidos & "','" & FechaVencimiento & "','" & Observaciones & "'," & SubTotal & "," & IVA & "," & Pagado & "," & Neto & "," & Neto & ",'" & MonedaCompra & "','" & Format(FechaHora, "dd/MM/yyyy HH:mm") & "')"
            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(SqlCompras, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            MiConexion.Close()

        Else
            '//////////////////////////////////////////////////////////////////////////////////////////////
            '////////////////////////////EDITO EL ENCABEZADO DE LA COMPRA///////////////////////////////////
            '/////////////////////////////////////////////////////////////////////////////////////////////////
            SqlCompras = "UPDATE [Compras]  SET [Cod_Proveedor] = '" & CodProveedor & "',[Nombre_Proveedor] = '" & Nombres & "',[Apellido_Proveedor] = '" & Apellidos & "',[Fecha_Vencimiento] = '" & FechaVencimiento & "' ,[Observaciones] = '" & Observaciones & "',[SubTotal] = " & SubTotal & ",[IVA] = " & IVA & ",[Pagado] = " & Pagado & ",[NetoPagar] = " & Neto & ",[MontoCredito] = " & Neto & ",[MonedaCompra] = '" & MonedaCompra & "', [FechaHora]= '" & Format(FechaHora, "dd/MM/yyyy HH:mm") & "' " & _
                         "WHERE  (Numero_Compra = '" & ConsecutivoCompra & "') AND (Fecha_Compra = CONVERT(DATETIME, '" & FechaCompra & "', 102)) AND (Tipo_Compra = '" & TipoCompra & "')"
            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(SqlCompras, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            MiConexion.Close()
        End If

    End Sub
    Public Function BuscaTasaCambio(ByVal FechaTasa As Date) As Double
        Dim MiConexion As New SqlClient.SqlConnection(Conexion)
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim SQlTasa As String, TasaCambio As Double, Fecha As String

        Fecha = Format(FechaTasa, "yyyy-MM-dd")
        TasaCambio = 0
        SQlTasa = "SELECT  * FROM TasaCambio WHERE (FechaTasa = CONVERT(DATETIME, '" & Fecha & "', 102))"
        DataAdapter = New SqlClient.SqlDataAdapter(SQlTasa, MiConexion)
        My.Application.DoEvents()
        DataAdapter.Fill(DataSet, "TasaCambio")
        If DataSet.Tables("TasaCambio").Rows.Count <> 0 Then
            TasaCambio = DataSet.Tables("TasaCambio").Rows(0)("MontoTasa")
        End If

        'If TasaCambio = 0 Then
        '    TasaCambio = 1
        'End If

        BuscaTasaCambio = TasaCambio
    End Function
    Public Function BuscaExistenciaBodega(ByVal CodigoProducto As String, ByVal CodigoBodega As String) As Double
        Dim MiConexion As New SqlClient.SqlConnection(Conexion)
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter, Fecha As String, UnidadComprada As Double
        Dim SQlInventarioFisico As String, TasaCambio As Double, Existencia As Double = 0, SqlConsulta As String, DevolucionCompra As Double = 0
        Dim UnidadFacturada As Double = 0, DevolucionFactura As Double = 0, TransferenciaEnviada As Double = 0, TransferenciaRecibida As Double = 0
        Dim SalidaBodega As Double = 0, CostoVenta As Double = 0, ImporteFactura As Double = 0
        Dim ImporteCompra As Double, ImporteDevCompra As Double = 0, ImporteVenta As Double = 0, ImporteSalida As Double = 0
        Dim ImporteDevFactura As Double = 0

        '///////////////////////////FORMULA DE COMPRA PROMEDIO////////////////////////////////////////////////////////////////
        ' CostoPromedio= ((Existencia*Costo)+(PrecioCompra*CantidadCompra))/(Existencia+CantidadComprada)
        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        '///////////////////////////BUSCO LA EXISTENCIA SEGUN EL ULTIMO INVENTARIO FISICO////////////////////////////////////////

        CostoVenta = CostoPromedio(CodigoProducto)

        TasaCambio = 0
        SQlInventarioFisico = "SELECT * FROM InventarioFisico WHERE (Cod_Producto = '" & CodigoProducto & "') AND (Activo = 0) AND (CodBodega = '" & CodigoBodega & "') ORDER BY Fecha_Conteo DESC"
        DataAdapter = New SqlClient.SqlDataAdapter(SQlInventarioFisico, MiConexion)
        DataAdapter.Fill(DataSet, "InventarioFisico")
        If DataSet.Tables("InventarioFisico").Rows.Count <> 0 Then
            Existencia = 0
            'Existencia = DataSet.Tables("InventarioFisico").Rows(0)("Cantidad_Contada")

            Fecha = Format(CDate(DataSet.Tables("InventarioFisico").Rows(0)("Fecha_Conteo")), "yyyy-MM-dd")

            '//////////////////////////////////BUSCO EL TOTAL DE LAS COMPRAS////////////////////////////////////////////////////////////////////
            SqlConsulta = "SELECT SUM(Detalle_Compras.Cantidad) AS Cantidad FROM Detalle_Compras INNER JOIN Compras ON Detalle_Compras.Numero_Compra = Compras.Numero_Compra AND Detalle_Compras.Fecha_Compra = Compras.Fecha_Compra AND Detalle_Compras.Tipo_Compra = Compras.Tipo_Compra  " & _
                          "WHERE (Detalle_Compras.Cod_Producto = '" & CodigoProducto & "') AND (Compras.Cod_Bodega = '" & CodigoBodega & "')  GROUP BY Detalle_Compras.Tipo_Compra HAVING  (Detalle_Compras.Tipo_Compra = N'Mercancia Recibida') "
            DataAdapter = New SqlClient.SqlDataAdapter(SqlConsulta, MiConexion)
            DataAdapter.Fill(DataSet, "Compras")
            If DataSet.Tables("Compras").Rows.Count <> 0 Then
                UnidadComprada = DataSet.Tables("Compras").Rows(0)("Cantidad")
            End If

            '//////////////////////////////////BUSCO EL TOTAL DE LAS DEVOLUCION DE COMPRAS////////////////////////////////////////////////////////////////////
            SqlConsulta = "SELECT  SUM(Detalle_Compras.Cantidad) AS Cantidad FROM Detalle_Compras INNER JOIN Compras ON Detalle_Compras.Numero_Compra = Compras.Numero_Compra AND Detalle_Compras.Fecha_Compra = Compras.Fecha_Compra AND Detalle_Compras.Tipo_Compra = Compras.Tipo_Compra " & _
                          "WHERE (Detalle_Compras.Cod_Producto = '" & CodigoProducto & "') AND (Compras.Cod_Bodega = '" & CodigoBodega & "') GROUP BY Detalle_Compras.Tipo_Compra HAVING  (Detalle_Compras.Tipo_Compra = N'Devolucion de Compra')"
            DataAdapter = New SqlClient.SqlDataAdapter(SqlConsulta, MiConexion)
            DataAdapter.Fill(DataSet, "DevolucionCompras")
            If DataSet.Tables("DevolucionCompras").Rows.Count <> 0 Then
                DevolucionCompra = DataSet.Tables("DevolucionCompras").Rows(0)("Cantidad")
            End If

            '////////////////////////////////////BUSCO EL TOTAL DE LAS FACTURAS//////////////////////////////////////////////////////////////////////
            SqlConsulta = "SELECT SUM(Detalle_Facturas.Cantidad) AS Cantidad FROM Detalle_Facturas INNER JOIN Facturas ON Detalle_Facturas.Numero_Factura = Facturas.Numero_Factura AND Detalle_Facturas.Fecha_Factura = Facturas.Fecha_Factura AND Detalle_Facturas.Tipo_Factura = Facturas.Tipo_Factura " & _
                          "WHERE (Detalle_Facturas.Tipo_Factura = 'Factura') AND (Detalle_Facturas.Cod_Producto = '" & CodigoProducto & "') AND (Facturas.Cod_Bodega =  '" & CodigoBodega & "')"
            DataAdapter = New SqlClient.SqlDataAdapter(SqlConsulta, MiConexion)
            DataAdapter.Fill(DataSet, "Facturas")
            If DataSet.Tables("Facturas").Rows.Count <> 0 Then
                If Not IsDBNull(DataSet.Tables("Facturas").Rows(0)("Cantidad")) Then
                    UnidadFacturada = DataSet.Tables("Facturas").Rows(0)("Cantidad")
                    ImporteVenta = DataSet.Tables("Facturas").Rows(0)("Cantidad") * CostoVenta
                Else
                    UnidadFacturada = 0
                    ImporteVenta = 0
                End If
            End If

            '////////////////////////////////////BUSCO EL TOTAL DE LA SALIDA DE BODEGA//////////////////////////////////////////////////////////////////////
            SqlConsulta = "SELECT SUM(Detalle_Facturas.Cantidad) AS Cantidad FROM Detalle_Facturas INNER JOIN Facturas ON Detalle_Facturas.Numero_Factura = Facturas.Numero_Factura AND Detalle_Facturas.Fecha_Factura = Facturas.Fecha_Factura AND Detalle_Facturas.Tipo_Factura = Facturas.Tipo_Factura " & _
                          "WHERE (Detalle_Facturas.Tipo_Factura = 'Salida Bodega') AND (Detalle_Facturas.Cod_Producto = '" & CodigoProducto & "') AND (Facturas.Cod_Bodega =  '" & CodigoBodega & "')"
            DataAdapter = New SqlClient.SqlDataAdapter(SqlConsulta, MiConexion)
            DataAdapter.Fill(DataSet, "SalidaBodega")
            If DataSet.Tables("SalidaBodega").Rows.Count <> 0 Then
                If Not IsDBNull(DataSet.Tables("SalidaBodega").Rows(0)("Cantidad")) Then
                    SalidaBodega = DataSet.Tables("SalidaBodega").Rows(0)("Cantidad")
                    ImporteSalida = DataSet.Tables("SalidaBodega").Rows(0)("Cantidad") * CostoVenta
                Else
                    SalidaBodega = 0
                    ImporteSalida = 0
                End If
            End If

            DataSet.Reset()
            '////////////////////////////////////BUSCO EL TOTAL DE LA DEVOLUCION DE LAS  FACTURAS//////////////////////////////////////////////////////////////////////
            SqlConsulta = "SELECT     SUM(Detalle_Facturas.Cantidad) AS Cantidad FROM Detalle_Facturas INNER JOIN Facturas ON Detalle_Facturas.Numero_Factura = Facturas.Numero_Factura AND Detalle_Facturas.Fecha_Factura = Facturas.Fecha_Factura AND Detalle_Facturas.Tipo_Factura = Facturas.Tipo_Factura  " & _
                          "WHERE  (Detalle_Facturas.Tipo_Factura = 'Devolucion de Venta') AND (Detalle_Facturas.Cod_Producto =  '" & CodigoProducto & "') AND (Facturas.Cod_Bodega = '" & CodigoBodega & "')"
            DataAdapter = New SqlClient.SqlDataAdapter(SqlConsulta, MiConexion)
            DataAdapter.Fill(DataSet, "DevolucionFacturas")
            If DataSet.Tables("DevolucionFacturas").Rows.Count <> 0 Then
                If Not IsDBNull(DataSet.Tables("DevolucionFacturas").Rows(0)("Cantidad")) Then
                    DevolucionFactura = DataSet.Tables("DevolucionFacturas").Rows(0)("Cantidad")

                End If
            End If

            DataSet.Reset()
            '////////////////////////////////////BUSCO EL TOTAL DE TRANSFERENCIAS ENVIADAS  //////////////////////////////////////////////////////////////////////
            SqlConsulta = "SELECT SUM(Detalle_Facturas.Cantidad) AS Cantidad FROM Detalle_Facturas INNER JOIN Facturas ON Detalle_Facturas.Numero_Factura = Facturas.Numero_Factura AND Detalle_Facturas.Fecha_Factura = Facturas.Fecha_Factura AND Detalle_Facturas.Tipo_Factura = Facturas.Tipo_Factura " & _
                          "WHERE (Detalle_Facturas.Tipo_Factura = 'Transferencia Enviada') AND (Detalle_Facturas.Cod_Producto = '" & CodigoProducto & "') AND (Facturas.Su_Referencia = '" & CodigoBodega & "') AND (Facturas.TransferenciaProcesada = 1) "
            DataAdapter = New SqlClient.SqlDataAdapter(SqlConsulta, MiConexion)
            DataAdapter.Fill(DataSet, "DevolucionFacturas")
            If DataSet.Tables("DevolucionFacturas").Rows.Count <> 0 Then
                If Not IsDBNull(DataSet.Tables("DevolucionFacturas").Rows(0)("Cantidad")) Then
                    TransferenciaEnviada = DataSet.Tables("DevolucionFacturas").Rows(0)("Cantidad")
                End If
            End If

            DataSet.Reset()
            '////////////////////////////////////BUSCO EL TOTAL DE TRANSFERENCIAS RECIBIDAS  //////////////////////////////////////////////////////////////////////
            SqlConsulta = "SELECT     SUM(Detalle_Compras.Cantidad) AS Cantidad FROM Compras INNER JOIN Detalle_Compras ON Compras.Numero_Compra = Detalle_Compras.Numero_Compra AND Compras.Fecha_Compra = Detalle_Compras.Fecha_Compra AND Compras.Tipo_Compra = Detalle_Compras.Tipo_Compra " & _
                          "WHERE (Compras.TransferenciaProcesada = 1) AND (Compras.Cod_Bodega = '" & CodigoBodega & "') AND (Detalle_Compras.Cod_Producto = '" & CodigoProducto & "') AND (Compras.Tipo_Compra = 'Transferencia Recibida')"
            DataAdapter = New SqlClient.SqlDataAdapter(SqlConsulta, MiConexion)
            DataAdapter.Fill(DataSet, "TransferenciasRecibidas")
            If DataSet.Tables("TransferenciasRecibidas").Rows.Count <> 0 Then
                If Not IsDBNull(DataSet.Tables("TransferenciasRecibidas").Rows(0)("Cantidad")) Then
                    TransferenciaRecibida = DataSet.Tables("TransferenciasRecibidas").Rows(0)("Cantidad")
                End If
            End If

            'SqlConsulta = "SELECT SUM(Detalle_Facturas.Cantidad) AS Cantidad FROM Detalle_Facturas INNER JOIN Facturas ON Detalle_Facturas.Numero_Factura = Facturas.Numero_Factura AND Detalle_Facturas.Fecha_Factura = Facturas.Fecha_Factura AND Detalle_Facturas.Tipo_Factura = Facturas.Tipo_Factura " & _
            '              "WHERE (Detalle_Facturas.Tipo_Factura = 'Transferencia Enviada') AND (Detalle_Facturas.Cod_Producto = '" & CodigoProducto & "') AND (Facturas.Nuestra_Referencia =  '" & CodigoBodega & "') AND (Facturas.TransferenciaProcesada = 1)"
            'DataAdapter = New SqlClient.SqlDataAdapter(SqlConsulta, MiConexion)
            'DataAdapter.Fill(DataSet, "TransferenciasRecibidas")
            'If DataSet.Tables("TransferenciasRecibidas").Rows.Count <> 0 Then
            '    If Not IsDBNull(DataSet.Tables("TransferenciasRecibidas").Rows(0)("Cantidad")) Then
            '        TransferenciaRecibida = DataSet.Tables("TransferenciasRecibidas").Rows(0)("Cantidad")
            '    End If
            'End If
        Else
            '//////////////////////////////////BUSCO EL TOTAL DE LAS COMPRAS////////////////////////////////////////////////////////////////////
            SqlConsulta = "SELECT SUM(Detalle_Compras.Cantidad) AS Cantidad, SUM(Detalle_Compras.Cantidad * Detalle_Compras.Precio_Neto) AS Importe  FROM Detalle_Compras INNER JOIN Compras ON Detalle_Compras.Numero_Compra = Compras.Numero_Compra AND Detalle_Compras.Fecha_Compra = Compras.Fecha_Compra AND Detalle_Compras.Tipo_Compra = Compras.Tipo_Compra  " & _
                          "WHERE (Detalle_Compras.Cod_Producto = '" & CodigoProducto & "') AND (Compras.Cod_Bodega = '" & CodigoBodega & "')  GROUP BY Detalle_Compras.Tipo_Compra HAVING  (Detalle_Compras.Tipo_Compra = N'Mercancia Recibida') "
            DataAdapter = New SqlClient.SqlDataAdapter(SqlConsulta, MiConexion)
            DataAdapter.Fill(DataSet, "Compras")
            If DataSet.Tables("Compras").Rows.Count <> 0 Then
                UnidadComprada = DataSet.Tables("Compras").Rows(0)("Cantidad")
                ImporteCompra = DataSet.Tables("Compras").Rows(0)("Importe")
            End If

            '//////////////////////////////////BUSCO EL TOTAL DE LAS DEVOLUCION DE COMPRAS////////////////////////////////////////////////////////////////////
            SqlConsulta = "SELECT  SUM(Detalle_Compras.Cantidad) AS Cantidad,SUM(Detalle_Compras.Cantidad * Detalle_Compras.Precio_Neto) AS Importe FROM Detalle_Compras INNER JOIN Compras ON Detalle_Compras.Numero_Compra = Compras.Numero_Compra AND Detalle_Compras.Fecha_Compra = Compras.Fecha_Compra AND Detalle_Compras.Tipo_Compra = Compras.Tipo_Compra " & _
                          "WHERE (Detalle_Compras.Cod_Producto = '" & CodigoProducto & "') AND (Compras.Cod_Bodega = '" & CodigoBodega & "') GROUP BY Detalle_Compras.Tipo_Compra HAVING  (Detalle_Compras.Tipo_Compra = N'Devolucion de Compra')"
            DataAdapter = New SqlClient.SqlDataAdapter(SqlConsulta, MiConexion)
            DataAdapter.Fill(DataSet, "DevolucionCompras")
            If DataSet.Tables("DevolucionCompras").Rows.Count <> 0 Then
                DevolucionCompra = DataSet.Tables("DevolucionCompras").Rows(0)("Cantidad")
                ImporteDevCompra = DataSet.Tables("DevolucionCompras").Rows(0)("Importe")
            End If

            '////////////////////////////////////BUSCO EL TOTAL DE LAS FACTURAS//////////////////////////////////////////////////////////////////////
            SqlConsulta = "SELECT SUM(Detalle_Facturas.Cantidad) AS Cantidad FROM Detalle_Facturas INNER JOIN Facturas ON Detalle_Facturas.Numero_Factura = Facturas.Numero_Factura AND Detalle_Facturas.Fecha_Factura = Facturas.Fecha_Factura AND Detalle_Facturas.Tipo_Factura = Facturas.Tipo_Factura " & _
                          "WHERE (Detalle_Facturas.Tipo_Factura = 'Factura') AND (Detalle_Facturas.Cod_Producto = '" & CodigoProducto & "') AND (Facturas.Cod_Bodega =  '" & CodigoBodega & "')"
            DataAdapter = New SqlClient.SqlDataAdapter(SqlConsulta, MiConexion)
            DataAdapter.Fill(DataSet, "Facturas")
            If DataSet.Tables("Facturas").Rows.Count <> 0 Then
                If Not IsDBNull(DataSet.Tables("Facturas").Rows(0)("Cantidad")) Then
                    UnidadFacturada = DataSet.Tables("Facturas").Rows(0)("Cantidad")
                    ImporteVenta = DataSet.Tables("Facturas").Rows(0)("Cantidad") * CostoVenta
                Else
                    UnidadFacturada = 0
                    ImporteVenta = 0
                End If
            End If

            '////////////////////////////////////BUSCO EL TOTAL DE LA SALIDA DE BODEGA//////////////////////////////////////////////////////////////////////
            SqlConsulta = "SELECT SUM(Detalle_Facturas.Cantidad) AS Cantidad FROM Detalle_Facturas INNER JOIN Facturas ON Detalle_Facturas.Numero_Factura = Facturas.Numero_Factura AND Detalle_Facturas.Fecha_Factura = Facturas.Fecha_Factura AND Detalle_Facturas.Tipo_Factura = Facturas.Tipo_Factura " & _
                          "WHERE (Detalle_Facturas.Tipo_Factura = 'Salida Bodega') AND (Detalle_Facturas.Cod_Producto = '" & CodigoProducto & "') AND (Facturas.Cod_Bodega =  '" & CodigoBodega & "')"
            DataAdapter = New SqlClient.SqlDataAdapter(SqlConsulta, MiConexion)
            DataAdapter.Fill(DataSet, "SalidaBodega")
            If DataSet.Tables("SalidaBodega").Rows.Count <> 0 Then
                If Not IsDBNull(DataSet.Tables("SalidaBodega").Rows(0)("Cantidad")) Then
                    SalidaBodega = DataSet.Tables("SalidaBodega").Rows(0)("Cantidad")
                Else
                    SalidaBodega = 0
                End If
            End If

            DataSet.Reset()
            '////////////////////////////////////BUSCO EL TOTAL DE LA DEVOLUCION DE LAS  FACTURAS//////////////////////////////////////////////////////////////////////
            SqlConsulta = "SELECT     SUM(Detalle_Facturas.Cantidad) AS Cantidad FROM Detalle_Facturas INNER JOIN Facturas ON Detalle_Facturas.Numero_Factura = Facturas.Numero_Factura AND Detalle_Facturas.Fecha_Factura = Facturas.Fecha_Factura AND Detalle_Facturas.Tipo_Factura = Facturas.Tipo_Factura  " & _
                          "WHERE  (Detalle_Facturas.Tipo_Factura = 'Devolucion de Venta') AND (Detalle_Facturas.Cod_Producto =  '" & CodigoProducto & "') AND (Facturas.Cod_Bodega = '" & CodigoBodega & "')"
            DataAdapter = New SqlClient.SqlDataAdapter(SqlConsulta, MiConexion)
            DataAdapter.Fill(DataSet, "DevolucionFacturas")
            If DataSet.Tables("DevolucionFacturas").Rows.Count <> 0 Then
                If Not IsDBNull(DataSet.Tables("DevolucionFacturas").Rows(0)("Cantidad")) Then
                    DevolucionFactura = DataSet.Tables("DevolucionFacturas").Rows(0)("Cantidad")
                    ImporteDevFactura = DataSet.Tables("DevolucionFacturas").Rows(0)("Cantidad") * CostoVenta
                End If
            End If

            DataSet.Reset()
            '////////////////////////////////////BUSCO EL TOTAL DE TRANSFERENCIAS ENVIADAS  //////////////////////////////////////////////////////////////////////
            SqlConsulta = "SELECT SUM(Detalle_Facturas.Cantidad) AS Cantidad FROM Detalle_Facturas INNER JOIN Facturas ON Detalle_Facturas.Numero_Factura = Facturas.Numero_Factura AND Detalle_Facturas.Fecha_Factura = Facturas.Fecha_Factura AND Detalle_Facturas.Tipo_Factura = Facturas.Tipo_Factura " & _
                          "WHERE (Detalle_Facturas.Tipo_Factura = 'Transferencia Enviada') AND (Detalle_Facturas.Cod_Producto = '" & CodigoProducto & "') AND (Facturas.Su_Referencia = '" & CodigoBodega & "') AND (Facturas.TransferenciaProcesada = 1) "
            DataAdapter = New SqlClient.SqlDataAdapter(SqlConsulta, MiConexion)
            DataAdapter.Fill(DataSet, "DevolucionFacturas")
            If DataSet.Tables("DevolucionFacturas").Rows.Count <> 0 Then
                If Not IsDBNull(DataSet.Tables("DevolucionFacturas").Rows(0)("Cantidad")) Then
                    TransferenciaEnviada = DataSet.Tables("DevolucionFacturas").Rows(0)("Cantidad")
                End If
            End If

            DataSet.Reset()
            '////////////////////////////////////BUSCO EL TOTAL DE TRANSFERENCIAS RECIBIDAS  //////////////////////////////////////////////////////////////////////
            SqlConsulta = "SELECT     SUM(Detalle_Compras.Cantidad) AS Cantidad FROM Compras INNER JOIN Detalle_Compras ON Compras.Numero_Compra = Detalle_Compras.Numero_Compra AND Compras.Fecha_Compra = Detalle_Compras.Fecha_Compra AND Compras.Tipo_Compra = Detalle_Compras.Tipo_Compra " & _
                          "WHERE (Compras.TransferenciaProcesada = 1) AND (Compras.Cod_Bodega = '" & CodigoBodega & "') AND (Detalle_Compras.Cod_Producto = '" & CodigoProducto & "') AND (Compras.Tipo_Compra = 'Transferencia Recibida')"
            DataAdapter = New SqlClient.SqlDataAdapter(SqlConsulta, MiConexion)
            DataAdapter.Fill(DataSet, "TransferenciasRecibidas")
            If DataSet.Tables("TransferenciasRecibidas").Rows.Count <> 0 Then
                If Not IsDBNull(DataSet.Tables("TransferenciasRecibidas").Rows(0)("Cantidad")) Then
                    TransferenciaRecibida = DataSet.Tables("TransferenciasRecibidas").Rows(0)("Cantidad")
                End If
            End If

            'SqlConsulta = "SELECT SUM(Detalle_Facturas.Cantidad) AS Cantidad FROM Detalle_Facturas INNER JOIN Facturas ON Detalle_Facturas.Numero_Factura = Facturas.Numero_Factura AND Detalle_Facturas.Fecha_Factura = Facturas.Fecha_Factura AND Detalle_Facturas.Tipo_Factura = Facturas.Tipo_Factura " & _
            '              "WHERE (Detalle_Facturas.Tipo_Factura = 'Transferencia Enviada') AND (Detalle_Facturas.Cod_Producto = '" & CodigoProducto & "') AND (Facturas.Nuestra_Referencia =  '" & CodigoBodega & "') AND (Facturas.TransferenciaProcesada = 1)"
            'DataAdapter = New SqlClient.SqlDataAdapter(SqlConsulta, MiConexion)
            'DataAdapter.Fill(DataSet, "TransferenciasRecibidas")
            'If DataSet.Tables("TransferenciasRecibidas").Rows.Count <> 0 Then
            '    If Not IsDBNull(DataSet.Tables("TransferenciasRecibidas").Rows(0)("Cantidad")) Then
            '        TransferenciaRecibida = DataSet.Tables("TransferenciasRecibidas").Rows(0)("Cantidad")
            '    End If
            'End If
        End If

        Existencia = Existencia + UnidadComprada - DevolucionCompra - UnidadFacturada - SalidaBodega + DevolucionFactura - TransferenciaEnviada + TransferenciaRecibida
        BuscaExistenciaBodega = Existencia
    End Function
    Public Function CostoPromedio(ByVal CodigoProducto As String) As Double
        Dim SqlCompras As String, Iposicion As Double, TotalImporte As Double, CantidadCompra As Double, MonedaCompra As String, Importe As Double, PrecioUnitario As Double, PrecioCostoDolar As Double, PrecioCosto As Double
        Dim MiConexion As New SqlClient.SqlConnection(Conexion), Registros As Double, ImporteD As Double, TotalImporteD As Double
        Dim DataSet As New DataSet, TotalCantidad As Double = 0, CantDevCompra As Double = 0, CantDevVenta As Double = 0, CantVentas As Double = 0, CantSalida As Double = 0
        Dim DataAdapter As New SqlClient.SqlDataAdapter
        Dim TotalCompras As Double = 0, TotalDevCompras As Double = 0, TotalVentas As Double = 0, TotalDevVentas As Double = 0, TotalSalidaBodega As Double = 0, TotalSalidaBodegaD As Double = 0
        Dim TotalComprasD As Double = 0, TotalDevComprasD As Double = 0, TotalVentasD As Double = 0, TotalDevVentasD As Double = 0
        Dim TotalTransEnviada As Double = 0, TotalTransRecibida As Double = 0



        '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        '/////////////////////////////////////////////////////////////////////////BUSCO EL TOTAL DE COMPRAS DOLARES ////////////////////////////////////////////////
        '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        SqlCompras = "SELECT MAX(Detalle_Compras.Numero_Compra) AS Numero_Compra, Detalle_Compras.Cod_Producto, SUM(Detalle_Compras.Cantidad) AS Cantidad, SUM(Detalle_Compras.Precio_Unitario) AS Precio_UnitarioD, SUM(Detalle_Compras.Precio_Unitario * TasaCambio.MontoTasa) AS Precio_Unitario, SUM(Detalle_Compras.Descuento * TasaCambio.MontoTasa) AS Descuento, SUM(Detalle_Compras.Descuento) AS DescuentoD, SUM(Detalle_Compras.Precio_Neto * TasaCambio.MontoTasa) AS Precio_Neto, SUM(Detalle_Compras.Precio_Neto) AS Precio_NetoD, Compras.MonedaCompra, SUM(Detalle_Compras.Precio_Neto * Detalle_Compras.Cantidad * TasaCambio.MontoTasa) AS Importe, SUM(Detalle_Compras.Precio_Neto * Detalle_Compras.Cantidad) AS ImporteD, Compras.Cod_Bodega FROM Detalle_Compras INNER JOIN Compras ON Detalle_Compras.Numero_Compra = Compras.Numero_Compra AND Detalle_Compras.Fecha_Compra = Compras.Fecha_Compra AND Detalle_Compras.Tipo_Compra = Compras.Tipo_Compra INNER JOIN TasaCambio ON Compras.Fecha_Compra = TasaCambio.FechaTasa  " & _
                     "WHERE (Detalle_Compras.Tipo_Compra = 'Mercancia Recibida') GROUP BY Detalle_Compras.Cod_Producto, Compras.MonedaCompra, Compras.Cod_Bodega HAVING (Detalle_Compras.Cod_Producto = '" & CodigoProducto & "') AND (Compras.MonedaCompra = N'Dolares')"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlCompras, MiConexion)
        DataAdapter.Fill(DataSet, "ComprasD")
        Registros = DataSet.Tables("ComprasD").Rows.Count - 1
        Iposicion = 0
        TotalImporte = 0
        ImporteD = 0
        TotalImporteD = 0
        CantidadCompra = 0
        TotalCantidad = 0

        Do While Iposicion < DataSet.Tables("ComprasD").Rows.Count
            MonedaCompra = DataSet.Tables("ComprasD").Rows(Iposicion)("MonedaCompra")
            PrecioUnitario = Trim(DataSet.Tables("ComprasD").Rows(Iposicion)("Precio_Neto"))
            CantidadCompra = Trim(DataSet.Tables("ComprasD").Rows(Iposicion)("Cantidad")) + CantidadCompra
            Importe = Trim(DataSet.Tables("ComprasD").Rows(Iposicion)("Importe"))
            ImporteD = Trim(DataSet.Tables("ComprasD").Rows(Iposicion)("ImporteD"))
            TotalCompras = TotalCompras + Importe
            TotalComprasD = TotalComprasD + ImporteD
            Iposicion = Iposicion + 1
        Loop



        '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        '/////////////////////////////////////////////////////////////////////////BUSCO EL TOTAL DE COMPRAS CORDOBAS ////////////////////////////////////////////////
        '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        'SqlCompras = "SELECT Detalle_Compras.Numero_Compra, Detalle_Compras.Fecha_Compra, Detalle_Compras.Tipo_Compra, Detalle_Compras.Cod_Producto, Detalle_Compras.Cantidad, Detalle_Compras.Precio_Unitario, Detalle_Compras.Descuento, Detalle_Compras.Precio_Neto, Compras.MonedaCompra, Detalle_Compras.Precio_Neto * Detalle_Compras.Cantidad AS Importe, Compras.Cod_Bodega FROM Detalle_Compras INNER JOIN Compras ON Detalle_Compras.Numero_Compra = Compras.Numero_Compra AND Detalle_Compras.Fecha_Compra = Compras.Fecha_Compra AND Detalle_Compras.Tipo_Compra = Compras.Tipo_Compra WHERE (Detalle_Compras.Fecha_Compra <= CONVERT(DATETIME, '" & Format(FechaCompras, "yyyy-MM-dd") & "', 102)) AND (Detalle_Compras.Cod_Producto = '" & CodigoProducto & "') AND (Detalle_Compras.Tipo_Compra = N'Mercancia Recibida') AND (Compras.Cod_Bodega = '" & CodBodega & "')"
        SqlCompras = "SELECT MAX(Detalle_Compras.Numero_Compra) AS Numero_Compra, Detalle_Compras.Cod_Producto, SUM(Detalle_Compras.Cantidad) AS Cantidad, SUM(Detalle_Compras.Precio_Unitario / TasaCambio.MontoTasa) AS Precio_UnitarioD, SUM(Detalle_Compras.Precio_Unitario) AS Precio_Unitario, SUM(Detalle_Compras.Descuento) AS Descuento, SUM(Detalle_Compras.Descuento / TasaCambio.MontoTasa) AS DescuentoD, SUM(Detalle_Compras.Precio_Neto) AS Precio_Neto, SUM(Detalle_Compras.Precio_Neto / TasaCambio.MontoTasa) AS Precio_NetoD, Compras.MonedaCompra, SUM(Detalle_Compras.Precio_Neto * Detalle_Compras.Cantidad) AS Importe, SUM(Detalle_Compras.Precio_Neto * Detalle_Compras.Cantidad / TasaCambio.MontoTasa) AS ImporteD, Compras.Cod_Bodega FROM  Detalle_Compras INNER JOIN Compras ON Detalle_Compras.Numero_Compra = Compras.Numero_Compra AND Detalle_Compras.Fecha_Compra = Compras.Fecha_Compra AND Detalle_Compras.Tipo_Compra = Compras.Tipo_Compra INNER JOIN TasaCambio ON Compras.Fecha_Compra = TasaCambio.FechaTasa " & _
                     "WHERE (Detalle_Compras.Tipo_Compra = N'Mercancia Recibida') GROUP BY Detalle_Compras.Cod_Producto, Compras.MonedaCompra, Compras.Cod_Bodega HAVING (Detalle_Compras.Cod_Producto = '" & CodigoProducto & "') AND (Compras.MonedaCompra <> N'Dolares')"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlCompras, MiConexion)
        DataAdapter.Fill(DataSet, "Compras")
        Registros = DataSet.Tables("Compras").Rows.Count - 1
        Iposicion = 0
        Importe = 0
        ImporteD = 0
        Do While Iposicion < DataSet.Tables("Compras").Rows.Count
            MonedaCompra = DataSet.Tables("Compras").Rows(Iposicion)("MonedaCompra")
            PrecioUnitario = Trim(DataSet.Tables("Compras").Rows(Iposicion)("Precio_Neto"))
            CantidadCompra = Trim(DataSet.Tables("Compras").Rows(Iposicion)("Cantidad")) + CantidadCompra
            Importe = Trim(DataSet.Tables("Compras").Rows(Iposicion)("Importe"))
            ImporteD = Trim(DataSet.Tables("Compras").Rows(Iposicion)("ImporteD"))
            TotalCompras = TotalCompras + Importe
            TotalComprasD = TotalComprasD + ImporteD
            'FechaCompra = Trim(DataSet.Tables("Compras").Rows(Iposicion)("Fecha_Compra"))
            Iposicion = Iposicion + 1
        Loop




        '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        '/////////////////////////////////////////////////////////////////////////BUSCO EL TOTAL DEVOLUCIONES COMPRA DOLARES////////////////////////////////////////////////
        '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        'SqlCompras = "SELECT MAX(Detalle_Compras.Numero_Compra) AS Numero_Compra, MAX(Detalle_Compras.Fecha_Compra) AS Fecha_Compra, Detalle_Compras.Tipo_Compra, Detalle_Compras.Cod_Producto, SUM(Detalle_Compras.Cantidad) AS Cantidad, SUM(Detalle_Compras.Precio_Unitario) AS Precio_Unitario, SUM(Detalle_Compras.Descuento) AS Descuento, SUM(Detalle_Compras.Precio_Neto) AS Precio_Neto, Compras.MonedaCompra, SUM(Detalle_Compras.Precio_Unitario * Detalle_Compras.Cantidad) AS Importe FROM Detalle_Compras INNER JOIN Compras ON Detalle_Compras.Numero_Compra = Compras.Numero_Compra AND Detalle_Compras.Fecha_Compra = Compras.Fecha_Compra AND Detalle_Compras.Tipo_Compra = Compras.Tipo_Compra GROUP BY Detalle_Compras.Tipo_Compra, Detalle_Compras.Cod_Producto, Compras.MonedaCompra HAVING (Detalle_Compras.Cod_Producto = '" & CodigoProducto & "') AND (Detalle_Compras.Tipo_Compra = 'Devolucion de Compra')"
        SqlCompras = "SELECT MAX(Detalle_Compras.Numero_Compra) AS Numero_Compra, Detalle_Compras.Cod_Producto, SUM(Detalle_Compras.Cantidad) AS Cantidad, SUM(Detalle_Compras.Precio_Unitario) AS Precio_UnitarioD, SUM(Detalle_Compras.Precio_Unitario * TasaCambio.MontoTasa) AS Precio_Unitario, SUM(Detalle_Compras.Descuento * TasaCambio.MontoTasa) AS Descuento, SUM(Detalle_Compras.Descuento) AS DescuentoD, SUM(Detalle_Compras.Precio_Neto * TasaCambio.MontoTasa) AS Precio_Neto, SUM(Detalle_Compras.Precio_Neto) AS Precio_NetoD, Compras.MonedaCompra, SUM(Detalle_Compras.Precio_Neto * Detalle_Compras.Cantidad * TasaCambio.MontoTasa) AS Importe, SUM(Detalle_Compras.Precio_Neto * Detalle_Compras.Cantidad) AS ImporteD, Compras.Cod_Bodega FROM Detalle_Compras INNER JOIN Compras ON Detalle_Compras.Numero_Compra = Compras.Numero_Compra AND Detalle_Compras.Fecha_Compra = Compras.Fecha_Compra AND Detalle_Compras.Tipo_Compra = Compras.Tipo_Compra INNER JOIN TasaCambio ON Compras.Fecha_Compra = TasaCambio.FechaTasa  " & _
                     "WHERE (Detalle_Compras.Tipo_Compra = 'Devolucion de Compra') GROUP BY Detalle_Compras.Cod_Producto, Compras.MonedaCompra, Compras.Cod_Bodega HAVING (Detalle_Compras.Cod_Producto = '" & CodigoProducto & "') AND (Compras.MonedaCompra = N'Dolares')"

        DataAdapter = New SqlClient.SqlDataAdapter(SqlCompras, MiConexion)
        DataAdapter.Fill(DataSet, "DevolucionD")
        Registros = DataSet.Tables("DevolucionD").Rows.Count - 1
        Iposicion = 0
        CantDevCompra = 0
        Importe = 0
        ImporteD = 0
        Do While Iposicion < DataSet.Tables("DevolucionD").Rows.Count
            MonedaCompra = DataSet.Tables("DevolucionD").Rows(Iposicion)("MonedaCompra")
            PrecioUnitario = Trim(DataSet.Tables("DevolucionD").Rows(Iposicion)("Precio_Neto"))
            CantDevCompra = Trim(DataSet.Tables("DevolucionD").Rows(Iposicion)("Cantidad")) + CantDevCompra
            Importe = Trim(DataSet.Tables("DevolucionD").Rows(Iposicion)("Importe"))
            ImporteD = Trim(DataSet.Tables("DevolucionD").Rows(Iposicion)("ImporteD"))
            TotalDevCompras = TotalDevCompras + Importe
            TotalDevComprasD = TotalDevComprasD + ImporteD

            Iposicion = Iposicion + 1

        Loop


        '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        '/////////////////////////////////////////////////////////////////////////BUSCO EL TOTAL DE DEVOLUCION COMPRAS CORDOBAS ////////////////////////////////////////////////
        '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        SqlCompras = "SELECT MAX(Detalle_Compras.Numero_Compra) AS Numero_Compra, Detalle_Compras.Cod_Producto, SUM(Detalle_Compras.Cantidad) AS Cantidad, SUM(Detalle_Compras.Precio_Unitario / TasaCambio.MontoTasa) AS Precio_UnitarioD, SUM(Detalle_Compras.Precio_Unitario) AS Precio_Unitario, SUM(Detalle_Compras.Descuento) AS Descuento, SUM(Detalle_Compras.Descuento / TasaCambio.MontoTasa) AS DescuentoD, SUM(Detalle_Compras.Precio_Neto) AS Precio_Neto, SUM(Detalle_Compras.Precio_Neto / TasaCambio.MontoTasa) AS Precio_NetoD, Compras.MonedaCompra, SUM(Detalle_Compras.Precio_Neto * Detalle_Compras.Cantidad) AS Importe, SUM(Detalle_Compras.Precio_Neto * Detalle_Compras.Cantidad / TasaCambio.MontoTasa) AS ImporteD, Compras.Cod_Bodega FROM  Detalle_Compras INNER JOIN Compras ON Detalle_Compras.Numero_Compra = Compras.Numero_Compra AND Detalle_Compras.Fecha_Compra = Compras.Fecha_Compra AND Detalle_Compras.Tipo_Compra = Compras.Tipo_Compra INNER JOIN TasaCambio ON Compras.Fecha_Compra = TasaCambio.FechaTasa " & _
                     "WHERE (Detalle_Compras.Tipo_Compra = 'Devolucion de Compra') GROUP BY Detalle_Compras.Cod_Producto, Compras.MonedaCompra, Compras.Cod_Bodega HAVING (Detalle_Compras.Cod_Producto = '" & CodigoProducto & "') AND (Compras.MonedaCompra <> 'Dolares')"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlCompras, MiConexion)
        DataAdapter.Fill(DataSet, "Devolucion")
        Registros = DataSet.Tables("Devolucion").Rows.Count - 1
        Iposicion = 0
        Importe = 0
        ImporteD = 0
        Do While Iposicion < DataSet.Tables("Devolucion").Rows.Count
            MonedaCompra = DataSet.Tables("Devolucion").Rows(Iposicion)("MonedaCompra")

            PrecioUnitario = Trim(DataSet.Tables("Devolucion").Rows(Iposicion)("Precio_Neto"))
            CantDevCompra = Trim(DataSet.Tables("Devolucion").Rows(Iposicion)("Cantidad")) + CantDevCompra
            Importe = Trim(DataSet.Tables("Devolucion").Rows(Iposicion)("Importe"))
            ImporteD = Trim(DataSet.Tables("Devolucion").Rows(Iposicion)("ImporteD"))
            TotalDevCompras = TotalDevCompras + Importe
            TotalDevComprasD = TotalDevComprasD + ImporteD
            'FechaCompra = Trim(DataSet.Tables("Compras").Rows(Iposicion)("Fecha_Compra"))


            Iposicion = Iposicion + 1

        Loop

        '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        '/////////////////////////////////////////////////////////////////////////BUSCO EL TOTAL DE SALIDA DE BODEGA ////////////////////////////////////////////////
        '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        SqlCompras = "SELECT SUM(Detalle_Facturas.Cantidad) AS Cantidad, SUM(Detalle_Facturas.Cantidad * Detalle_Facturas.Precio_Unitario) AS Costo,SUM(Detalle_Facturas.Cantidad * Detalle_Facturas.Precio_Unitario / TasaCambio.MontoTasa) AS CostoD FROM Detalle_Facturas INNER JOIN Facturas ON Detalle_Facturas.Numero_Factura = Facturas.Numero_Factura AND Detalle_Facturas.Fecha_Factura = Facturas.Fecha_Factura AND Detalle_Facturas.Tipo_Factura = Facturas.Tipo_Factura INNER JOIN TasaCambio ON Facturas.Fecha_Factura = TasaCambio.FechaTasa WHERE (Detalle_Facturas.Cod_Producto = '" & CodigoProducto & "') AND (Detalle_Facturas.Tipo_Factura = 'Salida Bodega') AND (Detalle_Facturas.Cantidad * Detalle_Facturas.Precio_Unitario <> 0)"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlCompras, MiConexion)
        DataAdapter.Fill(DataSet, "Salida")
        Registros = DataSet.Tables("Salida").Rows.Count - 1
        Iposicion = 0
        CantSalida = 0
        Importe = 0
        ImporteD = 0
        Do While Iposicion < DataSet.Tables("Salida").Rows.Count
            If Not IsDBNull(DataSet.Tables("Salida").Rows(Iposicion)("Cantidad")) Then
                CantSalida = Trim(DataSet.Tables("Salida").Rows(Iposicion)("Cantidad"))
                If Not IsDBNull(DataSet.Tables("Salida").Rows(Iposicion)("Costo")) Then
                    Importe = Trim(DataSet.Tables("Salida").Rows(Iposicion)("Costo"))
                    ImporteD = Trim(DataSet.Tables("Salida").Rows(Iposicion)("CostoD"))
                End If
            End If
            TotalSalidaBodega = TotalSalidaBodega + Importe
            TotalSalidaBodegaD = TotalSalidaBodegaD + ImporteD
            Iposicion = Iposicion + 1
        Loop

        '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        '/////////////////////////////////////////////////////////////////////////BUSCO EL TOTAL DE VENTAS EN CORDOBAS Y DOLARES ////////////////////////////////////////////////
        '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        SqlCompras = "SELECT SUM(Detalle_Facturas.Cantidad) AS Cantidad, SUM(Detalle_Facturas.Cantidad * Detalle_Facturas.Costo_Unitario) AS Costo,SUM(Detalle_Facturas.Cantidad * Detalle_Facturas.Costo_Unitario / TasaCambio.MontoTasa) AS CostoD FROM Detalle_Facturas INNER JOIN Facturas ON Detalle_Facturas.Numero_Factura = Facturas.Numero_Factura AND Detalle_Facturas.Fecha_Factura = Facturas.Fecha_Factura AND Detalle_Facturas.Tipo_Factura = Facturas.Tipo_Factura INNER JOIN TasaCambio ON Facturas.Fecha_Factura = TasaCambio.FechaTasa WHERE (Detalle_Facturas.Cod_Producto = '" & CodigoProducto & "') AND (Detalle_Facturas.Tipo_Factura = 'Factura') AND (Detalle_Facturas.Cantidad * Detalle_Facturas.Costo_Unitario <> 0)"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlCompras, MiConexion)
        DataAdapter.Fill(DataSet, "Ventas")
        Registros = DataSet.Tables("Ventas").Rows.Count - 1
        Iposicion = 0
        CantVentas = 0
        Importe = 0
        ImporteD = 0
        Do While Iposicion < DataSet.Tables("Ventas").Rows.Count
            If Not IsDBNull(DataSet.Tables("Ventas").Rows(Iposicion)("Cantidad")) Then
                CantVentas = Trim(DataSet.Tables("Ventas").Rows(Iposicion)("Cantidad"))
            End If
            If Not IsDBNull(DataSet.Tables("Ventas").Rows(Iposicion)("Costo")) Then
                Importe = Trim(DataSet.Tables("Ventas").Rows(Iposicion)("Costo"))
                ImporteD = Trim(DataSet.Tables("Ventas").Rows(Iposicion)("CostoD"))
            End If
            TotalVentas = TotalVentas + Importe
            TotalVentasD = TotalVentasD + ImporteD
            Iposicion = Iposicion + 1
        Loop

        '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        '/////////////////////////////////////////////////////////////////////////BUSCO EL TOTAL DE DEVOLUCIONES VENTAS EN CORDOBAS Y DOLARES ////////////////////////////////////////////////
        '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        SqlCompras = "SELECT SUM(Detalle_Facturas.Cantidad) AS Cantidad, SUM(Detalle_Facturas.Cantidad * Detalle_Facturas.Costo_Unitario) AS Costo,SUM(Detalle_Facturas.Cantidad * Detalle_Facturas.Costo_Unitario / TasaCambio.MontoTasa) AS CostoD FROM Detalle_Facturas INNER JOIN Facturas ON Detalle_Facturas.Numero_Factura = Facturas.Numero_Factura AND Detalle_Facturas.Fecha_Factura = Facturas.Fecha_Factura AND Detalle_Facturas.Tipo_Factura = Facturas.Tipo_Factura INNER JOIN TasaCambio ON Facturas.Fecha_Factura = TasaCambio.FechaTasa WHERE (Detalle_Facturas.Cod_Producto = '" & CodigoProducto & "') AND (Detalle_Facturas.Tipo_Factura = 'Devolucion de Venta') AND (Detalle_Facturas.Cantidad * Detalle_Facturas.Costo_Unitario <> 0)"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlCompras, MiConexion)
        DataAdapter.Fill(DataSet, "DevVentas")
        Registros = DataSet.Tables("DevVentas").Rows.Count - 1
        Iposicion = 0
        CantDevVenta = 0
        Importe = 0
        ImporteD = 0
        Do While Iposicion < DataSet.Tables("DevVentas").Rows.Count
            If Not IsDBNull(DataSet.Tables("DevVentas").Rows(Iposicion)("Cantidad")) Then
                CantDevVenta = Trim(DataSet.Tables("DevVentas").Rows(Iposicion)("Cantidad"))
                Importe = Trim(DataSet.Tables("DevVentas").Rows(Iposicion)("Costo"))
                ImporteD = Trim(DataSet.Tables("DevVentas").Rows(Iposicion)("CostoD"))
            End If

            TotalDevVentas = TotalDevVentas + Importe
            TotalDevVentasD = TotalDevVentasD + ImporteD
            Iposicion = Iposicion + 1
        Loop





        '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        '//////////////////////////////////////////////////////////////////////FORMULA COSTO PROMEDIO /////////////////////////////////////////////////////
        '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        'CostoPromedio =  TotalCompras+TotalDevVenas-TotalVentas-TotalDevCompra
        '                 ------------------------------------------------------
        '                 UnidCompra+UnidadDevVentas-UnidadVentas-UnidadDevCompra


        TotalCantidad = CantidadCompra + CantDevVenta - CantVentas - CantDevCompra - CantSalida
        TotalImporte = TotalCompras + TotalDevVentas - TotalVentas - TotalDevCompras - TotalSalidaBodega
        TotalImporteD = TotalComprasD + TotalDevVentasD - TotalVentasD - TotalDevComprasD - TotalSalidaBodegaD


        If TotalCantidad <> 0 Then
            PrecioCosto = Format(TotalImporte / TotalCantidad, "##,##0.000000")
            PrecioCostoDolar = Format((TotalImporteD / TotalCantidad), "##,##0.000000")
        Else
            'PrecioCosto = PrecioUnitario
            'If PrecioCosto <> 0 Then
            '    PrecioCostoDolar = Format((TotalImporteD / TotalCantidad), "##,##0.000000")
            'Else
            '    PrecioCostoDolar = 0
            'End If
            PrecioCosto = 0
            PrecioCostoDolar = 0

        End If

        CostoPromedio = PrecioCosto
        'CostoPromedioDolar = PrecioCostoDolar

        DataSet.Tables("Compras").Reset()
    End Function



    Public Sub GrabaDetalleCompraLiquidacion(ByVal ConsecutivoCompra As String, ByVal CodProducto As String, ByVal PrecioUnitario As Double, ByVal Descuento As Double, ByVal PrecioNeto As Double, ByVal Importe As Double, ByVal Cantidad As Double, ByVal Moneda As String, ByVal FechaCompra As Date)
        Dim Sqldetalle As String, ComandoUpdate As New SqlClient.SqlCommand, iResultado As Integer, TasaCambio As String
        Dim Fecha As String, MiConexion As New SqlClient.SqlConnection(Conexion), SqlUpdate As String
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter, MonedaCompra As String, MonedaProducto As String, Descripcion As String

        MonedaCompra = Moneda
        MonedaProducto = "Cordobas"
        TasaCambio = 0

        If MonedaCompra = "Cordobas" Then
            If MonedaProducto = "Cordobas" Then
                TasaCambio = 1
            Else
                If BuscaTasaCambio(FechaCompra) <> 0 Then
                    TasaCambio = (1 / BuscaTasaCambio(FechaCompra))
                End If
            End If
        ElseIf MonedaCompra = "Dolares" Then
            If MonedaProducto = "Cordobas" Then
                TasaCambio = BuscaTasaCambio(FechaCompra)
            Else
                TasaCambio = 1
            End If
        End If

        Sqldetalle = "SELECT  *  FROM Productos WHERE (Cod_Productos = '" & CodProducto & "')"
        DataAdapter = New SqlClient.SqlDataAdapter(Sqldetalle, MiConexion)
        DataAdapter.Fill(DataSet, "Consulta")
        If Not DataSet.Tables("Consulta").Rows.Count = 0 Then
            Descripcion = DataSet.Tables("Consulta").Rows(0)("Descripcion_Producto")
        End If


        Fecha = Format(FechaCompra, "yyyy-MM-dd")

        Sqldetalle = "SELECT *  FROM Detalle_Compras WHERE (Numero_Compra = '" & ConsecutivoCompra & "') AND (Fecha_Compra = CONVERT(DATETIME, '" & Fecha & "', 102)) AND (Tipo_Compra = 'Mercancia Recibida') AND (Cod_Producto = '" & CodProducto & "')"
        DataAdapter = New SqlClient.SqlDataAdapter(Sqldetalle, MiConexion)
        DataAdapter.Fill(DataSet, "DetalleCompra")
        If Not DataSet.Tables("DetalleCompra").Rows.Count = 0 Then
            '//////////////////////////////////////////////////////////////////////////////////////////////
            '////////////////////////////EDITO EL DETALLE DE COMPRAS///////////////////////////////////
            '/////////////////////////////////////////////////////////////////////////////////////////////////
            MiConexion.Close()
            SqlUpdate = "UPDATE [Detalle_Compras] SET [Cantidad] = " & Cantidad & " ,[Precio_Unitario] = " & PrecioUnitario & ",[Descuento] = " & Descuento & " ,[Precio_Neto] = " & PrecioNeto & ",[Importe] = " & Importe & ",[TasaCambio] = " & TasaCambio & " " & _
                        "WHERE (Numero_Compra = '" & ConsecutivoCompra & "') AND (Fecha_Compra = CONVERT(DATETIME, '" & Fecha & "', 102)) AND (Tipo_Compra = 'Mercancia Recibida') AND (Cod_Producto = '" & CodProducto & "')"
            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(SqlUpdate, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            MiConexion.Close()

        Else
            MiConexion.Close()
            SqlUpdate = "INSERT INTO [Detalle_Compras] ([Numero_Compra],[Fecha_Compra],[Tipo_Compra],[Cod_Producto],[Descripcion_Producto],[Cantidad],[Precio_Unitario],[Descuento],[Precio_Neto],[Importe],[TasaCambio]) " & _
            "VALUES ('" & ConsecutivoCompra & "','" & Format(FechaCompra, "dd/MM/yyyy") & "','Mercancia Recibida','" & CodProducto & "','" & Descripcion & "' ," & Cantidad & "," & PrecioUnitario & "," & Descuento & " ," & PrecioNeto & "," & Importe & "," & TasaCambio & ")"
            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(SqlUpdate, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            MiConexion.Close()

        End If

    End Sub

    Public Function BuscaConsecutivo(ByVal NombreCampo As String) As Double

        Dim SqlConsecutivo As String, SQlUpdate As String, CodConsecutivo As Double
        Dim MiConexion As New SqlClient.SqlConnection(Conexion)
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim ComandoUpdate As New SqlClient.SqlCommand, iResultado As Integer, FacturaBodega As Boolean = False, CompraBodega As Boolean = False

        '/////////////////////////////////////////////////////////////////////////////////////////
        '///////////////////////BUSCO SI TIENE ACTIVADA LA OPCION DE CONSECUTIVO X BODEGA /////////////////////////////////
        '////////////////////////////////////////////////////////////////////////////////////////
        SqlConsecutivo = "SELECT * FROM  DatosEmpresa"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlConsecutivo, MiConexion)
        DataAdapter.Fill(DataSet, "Configuracion")
        If Not DataSet.Tables("Configuracion").Rows.Count = 0 Then
            If Not IsDBNull(DataSet.Tables("Configuracion").Rows(0)("ConsecutivoFacBodega")) = True Then
                FacturaBodega = True
            End If

            If Not IsDBNull(DataSet.Tables("Configuracion").Rows(0)("ConsecutivoComBodega")) = True Then
                CompraBodega = True
            End If

        End If


        '/////////////////////////////////////////////////////////////////////////////////////////
        '///////////////////////BUSCO EL CONSECUTIVO COMPONENTES/////////////////////////////////
        '////////////////////////////////////////////////////////////////////////////////////////

        SqlConsecutivo = "SELECT  * FROM  Consecutivos"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlConsecutivo, MiConexion)
        DataAdapter.Fill(DataSet, "Consecutivo")
        If Not DataSet.Tables("Consecutivo").Rows.Count = 0 Then
            If Not IsDBNull(DataSet.Tables("Consecutivo").Rows(0)(NombreCampo)) Then
                CodConsecutivo = DataSet.Tables("Consecutivo").Rows(0)(NombreCampo) + 1
            Else
                CodConsecutivo = 1
            End If
            BuscaConsecutivo = CodConsecutivo

            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////
            '////////////////////////////ACTUALIZO EL CONSECUTIVO///////////////////////////////////////////////////
            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            MiConexion.Close()
            SQlUpdate = "UPDATE [Consecutivos]  SET [" & NombreCampo & "] = " & CodConsecutivo & ""
            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(SQlUpdate, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            MiConexion.Close()

        Else
            BuscaConsecutivo = 0
        End If

    End Function





    Public Sub GrabaLecturaPeso(ByVal Peso As Double, ByVal ConsecutivoSerieActivo As Boolean)



        Dim MiConexion As New SqlClient.SqlConnection(Conexion)

        Dim ConsecutivoCompra As Double, NumeroRecepcion As String, Registros As Double, Iposicion As Double
        Dim Linea As Double, CodigoProducto As String, Cantidad As Double, Descripcion As String, CodigoBeams As String, UnidadMedida As String = ""
        Dim CodigoBeamsOrigen As String = "", CodigoRecepcionBin As String = "", SqlConsecutivo As String, Estado As String, SqlString As String
        Dim DataSet As New DataSet, DataAdapterProductos As New SqlClient.SqlDataAdapter, PesoKg As Double, Precio As Double = 0.0, DataAdapter As New SqlClient.SqlDataAdapter
        Dim Tara As Double = 0, TaraSaco As Double = 0, PesoNetoLb As Double = 0, PesoNetoKg As Double = 0, CantidadSacos As Double = 0, LugarAcopio As Integer, SubTotal As Double = 0
        Dim HumedadxDefecto As Double = 0, HumedadReal As Double = 0, Consecutivo As Double, NumeroNotaPeso As String, Cadena As String, CadenaDiv() As String
        Dim ComandoUpdate As New SqlClient.SqlCommand, iResultado As Integer, Calidad As String, Fecha As Date
        Dim FactorSacolb As Double = 0, FactorSacokg As Double = 0, FactorEstado As Double = 0, IdEsdoFisico As Double = 0, IdCalidad As Double = 0, IdTipoLugarAcopio As Double = 0

        '////////////////////////////BUSCO EL CONSECUTIVO DEL RECIBO X  SERIE ///////////////////////////////////
        Fecha = CDate(My.Forms.FrmRecepcion.DTPFecha.Text)

        If ConsecutivoSerieActivo = True Then
            If FrmRecepcion.TxtNumeroEnsamble.Text = "- - - - - 0 - - - - -" Then
                SqlConsecutivo = "SELECT Serie, Recepcion  FROM ConsecutivoSerie  WHERE (Serie = N'" & My.Forms.FrmRecepcion.CmbSerie.Text & "')"
                DataAdapter = New SqlClient.SqlDataAdapter(SqlConsecutivo, MiConexion)
                DataAdapter.Fill(DataSet, "Consecutivo")
                If Not DataSet.Tables("Consecutivo").Rows.Count = 0 Then
                    If Not IsDBNull(DataSet.Tables("Consecutivo").Rows(0)("Recepcion")) Then
                        ConsecutivoCompra = Format(DataSet.Tables("Consecutivo").Rows(0)("Recepcion") + 1, "00000#")
                        NumeroNotaPeso = My.Forms.FrmRecepcion.CmbSerie.Text & "-" & ConsecutivoCompra
                    Else
                        ConsecutivoCompra = 1
                        NumeroNotaPeso = My.Forms.FrmRecepcion.CmbSerie.Text & "-" & Format(1, "00000#")
                    End If
                    '*************************ACTUALIZO EL CONSECUTIVO************************
                Else
                    NumeroNotaPeso = 0
                End If
            Else
                NumeroNotaPeso = My.Forms.FrmRecepcion.CmbSerie.Text & "-" & FrmRecepcion.TxtNumeroEnsamble.Text
            End If
        Else
            If FrmRecepcion.TxtNumeroEnsamble.Text = "- - - - - 0 - - - - -" Then
                SqlConsecutivo = "SELECT NumeroRecepcion, Activo  FROM Recepcion  WHERE  ({ fn LENGTH(NumeroRecepcion) } = 6) ORDER BY NumeroRecepcion DESC"
                DataAdapter = New SqlClient.SqlDataAdapter(SqlConsecutivo, MiConexion)
                DataAdapter.Fill(DataSet, "Consecutivos")
                If Not DataSet.Tables("Consecutivos").Rows.Count = 0 Then
                    If Not IsDBNull(DataSet.Tables("Consecutivos").Rows(0)("NumeroRecepcion")) Then
                        NumeroNotaPeso = Format(DataSet.Tables("Consecutivos").Rows(0)("NumeroRecepcion") + 1, "00000#")
                    End If
                Else
                    NumeroNotaPeso = Format(1, "00000#")
                End If
            Else
                NumeroNotaPeso = My.Forms.FrmRecepcion.TxtNumeroEnsamble.Text
            End If
        End If

        '/////////////////////////////GRABO ENCABEZADO DE RECEPCION /////////////////////////////////////////
        GrabaRecepcion(NumeroNotaPeso, ConsecutivoSerieActivo, 1)
        GrabaImperfeccion(NumeroNotaPeso)
        '///////////////////////////PREGUNTO LOS QUINTALES///////////////////////////////////////////////////
        My.Forms.FrmQQ.ShowDialog()
        CantidadSacos = My.Forms.FrmQQ.QQ

        '/////////////////////////////GRABO EL DETALLE DE LA RECEPCION //////////////////////////////////////
        Registros = FrmRecepcion.BindingDetalle.Count
        Iposicion = FrmRecepcion.BindingDetalle.Position
        If My.Forms.FrmRecepcion.TrueDBDetalleNP.Columns(0).Text = "" Then
            Linea = BuscaLinea(NumeroNotaPeso, CDate(My.Forms.FrmRecepcion.DTPFecha.Text), My.Forms.FrmRecepcion.CboTipoPesada.Text)
        Else
            Linea = FrmRecepcion.TrueDBDetalleNP.Columns(0).Text
        End If

        '/////////////////////////////CONVERTIR DE LIBRAS A KG ////////////////////////////////////////////
        PesoKg = Format((Peso * 0.453592), "##,##0.00")

        '//////////////////////CONSULTO LAS TARAS /////////////////////////////////////////////////////////

        FactorEstado = CDbl(FrmRecepcion.TxtHumedad.Text)

        FactorSacolb = CInt(Math.Ceiling(CantidadSacos * 0.5))
        FactorSacokg = CInt(Math.Ceiling((CantidadSacos * 0.5)) * 0.453592)
        Tara = (Peso * FactorEstado) + FactorSacolb

        PesoNetoLb = Peso - Tara
        PesoNetoKg = PesoNetoLb * 0.453592
        PesoNetoKg = PesoKg - (PesoKg * FactorEstado) - FactorSacokg

        GrabaDetalleRecepcion(NumeroNotaPeso, FrmRecepcion.CboVariedad.SelectedValue, Peso, Linea, Descripcion, Calidad, Estado, Precio, PesoKg, FrmRecepcion.CboTipoRecepcion.Text, Tara, PesoNetoKg, CantidadSacos, Fecha, PesoNetoLb)
        '  ActualizaDetalleRecepcion(NumeroRecepcion, Fecha)

        FrmRecepcion.TrueDBDetalleNP.Columns(0).Text = Linea
        FrmRecepcion.TrueDBDetalleNP.Columns(1).Text = FrmRecepcion.CboVariedad.SelectedValue
        FrmRecepcion.TrueDBDetalleNP.Columns(2).Text = FrmRecepcion.CboVariedad.Text
        FrmRecepcion.TrueDBDetalleNP.Columns(3).Text = FrmRecepcion.CboCalidad.Text
        FrmRecepcion.TrueDBDetalleNP.Columns(4).Text = FrmRecepcion.CboEstado.Text
        FrmRecepcion.TrueDBDetalleNP.Columns(5).Text = CantidadSacos
        FrmRecepcion.TrueDBDetalleNP.Columns(6).Text = Peso
        FrmRecepcion.TrueDBDetalleNP.Columns(7).Text = PesoKg
        FrmRecepcion.TrueDBDetalleNP.Columns(8).Text = Tara
        FrmRecepcion.TrueDBDetalleNP.Columns(9).Text = PesoNetoLb
        FrmRecepcion.TrueDBDetalleNP.Columns(10).Text = PesoNetoKg
        FrmRecepcion.TrueDBDetalleNP.Columns(11).Text = Precio

        If NumeroNotaPeso.Length > 6 Then
            FrmRecepcion.TxtNumeroEnsamble.Text = NumeroNotaPeso.Substring(2)
        Else
            FrmRecepcion.TxtNumeroEnsamble.Text = NumeroNotaPeso
        End If
        ''FrmRecepcion.TxtNumeroRecibo.Text = NumeroRecibo
        'Iposicion = FrmRecepcion.TrueDBDetalleNP.Row
        'FrmRecepcion.TrueDBDetalleNP.Row = FrmRecepcion.TrueDBDetalleNP.Row + 1
        'FrmRecepcion.TrueDBDetalleNP.Columns(1).Text = CodigoProducto
        'FrmRecepcion.TrueDBDetalleNP.Columns(2).Text = Descripcion
        'FrmRecepcion.TrueDBDetalleNP.Col = 5
        'FrmRecepcion.txtsubtotal.Text = TotalRecepcion(FrmRecepcion.TxtNumeroEnsamble.Text, FrmRecepcion.DTPFecha.Text, FrmRecepcion.CboTipoPesada.Text)
        'SubTotal = FrmRecepcion.txtsubtotal.Text
    End Sub

    Public Sub GrabaRecepcion(ByVal ConsecutivoRecepcion As String, ByVal ActualizarSerie As Boolean, ByVal Activo As Integer)

        Dim SqlCompras As String, ComandoUpdate As New SqlClient.SqlCommand, iResultado As Integer
        Dim Fecha As String
        Dim MiConexion As New SqlClient.SqlConnection(Conexion)
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim Subtotal As Double, Lote As String, TipoProceso As String = "", IdLugarAcopio As Double

        If FrmRecepcion.txtsubtotal.Text <> "" Then
            Subtotal = FrmRecepcion.txtsubtotal.Text
        Else
            Subtotal = 0
        End If
        Fecha = Format(CDate(FrmRecepcion.DTPFecha.Text), "dd/MM/yyyy") & " " & FrmRecepcion.LblHora.Text
        MiConexion.Close()
        SqlCompras = "SELECT Recepcion.* FROM Recepcion WHERE (NumeroRecepcion = '" & ConsecutivoRecepcion & "')"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlCompras, MiConexion)
        DataAdapter.Fill(DataSet, "Recepcion")
        If DataSet.Tables("Recepcion").Rows.Count = 0 Then
            '////////////////////////////AGREGO EL ENCABEZADO DE LA COMPRA///////////////////////////////
            SqlCompras = "INSERT INTO [dbo].[Recepcion]([NumeroRecepcion],[TipoRecepcion] ,[Fecha],[Cod_Proveedor],[Cod_SubProveedor],[Conductor],[Id_identificacion],[Id_Placa],[Cod_Bodega],[Observaciones],[SubTotal],[Telefono],[Cancelar],[Peso],[Lote],[Contabilizado],[FechaHora],[RecibimosDe],[IdFinca],[Calidad] ,[Fermentado],[Moho],[Estado],[Idvariedad],[IdPlantillo],[TipoPesada],[Seleccion],[CodRemision],[CodConacafe],[Activo]) " & _
                         "VALUES ('" & ConsecutivoRecepcion & "','Recepcion','" & Format(CDate(Fecha), "dd/MM/yyyy") & "','" & FrmRecepcion.TxtCodProductor.Text & "','Ninguno','" & My.Forms.FrmRecepcion.CboConductor.Text & "' ,'-9999991','" & My.Forms.FrmRecepcion.CboPlaca.Text & "' ,'" & My.Forms.FrmRecepcion.CboCodigoBodega.SelectedValue & "' ,'" & My.Forms.FrmRecepcion.txtobservaciones.Text & "' ,'" & CDbl(Subtotal) & "' ,'12345678' , 0 ,0,'Ninguno', 0, '" & Format(CDate(Fecha), "dd/MM/yyyy HH:mm:ss") & "','" & My.Forms.FrmRecepcion.CboRecibimosde.Text & "','" & My.Forms.FrmRecepcion.CboFinca.SelectedValue & "','" & My.Forms.FrmRecepcion.CboCalidad.Text & "','" & My.Forms.FrmRecepcion.CheckFermento.Checked & "','" & My.Forms.FrmRecepcion.CheckMohoso.Checked & "','" & My.Forms.FrmRecepcion.CboEstado.Text & "','" & My.Forms.FrmRecepcion.CboVariedad.SelectedValue & "','" & My.Forms.FrmRecepcion.CboPlantillo.SelectedValue & "','" & My.Forms.FrmRecepcion.CboTipoPesada.Text & "',0,'" & FrmRecepcion.TxtRemision.Text & "','" & FrmRecepcion.TxtRConacafe.Text & "','" & Activo & "')"
            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(SqlCompras, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            MiConexion.Close()
        Else
            '////////////////////////////EDITO EL ENCABEZADO DE LA COMPRA/////////////////////////////////

            SqlCompras = "UPDATE [dbo].[Recepcion]SET [TipoRecepcion] ='Recepcion' ,[Fecha] ='" & Format(CDate(Fecha), "dd/MM/yyyy") & "',[Cod_Proveedor] ='" & My.Forms.FrmRecepcion.CboProductor.SelectedValue & "',[Cod_SubProveedor] ='Ninguno' ,[Conductor] ='" & My.Forms.FrmRecepcion.CboConductor.Text & "' ,[Id_identificacion] ='-9999991' ,[Id_Placa] ='" & My.Forms.FrmRecepcion.CboPlaca.Text & "'  ,[Cod_Bodega] ='" & My.Forms.FrmRecepcion.CboCodigoBodega.SelectedValue & "' ,[Observaciones] = '" & My.Forms.FrmRecepcion.txtobservaciones.Text & "',[SubTotal] = '" & CDbl(FrmRecepcion.txtsubtotal.Text) & "' ,[Telefono] ='12345678' ,[Cancelar] = '0' ,[Peso] ='0'  ,[Lote] ='Ninguno'  ,[Contabilizado] = '0' ,[FechaHora] ='" & Format(CDate(Fecha), "dd/MM/yyyy HH:mm:ss") & "' ,[RecibimosDe] = '" & My.Forms.FrmRecepcion.CboRecibimosde.Text & "',[IdFinca] = '" & My.Forms.FrmRecepcion.CboFinca.SelectedValue & "',[Calidad] ='" & My.Forms.FrmRecepcion.CboCalidad.Text & "' ,[Fermentado] ='" & My.Forms.FrmRecepcion.CheckFermento.Checked & "' ,[Moho] = '" & My.Forms.FrmRecepcion.CheckMohoso.Checked & "',[Estado] ='" & My.Forms.FrmRecepcion.CboEstado.Text & "' ,[Idvariedad] ='" & My.Forms.FrmRecepcion.CboVariedad.SelectedValue & "' ,[IdPlantillo]= '" & My.Forms.FrmRecepcion.CboPlantillo.SelectedValue & "' ,[TipoPesada] ='" & My.Forms.FrmRecepcion.CboTipoPesada.Text & "' ,[Seleccion] ='0', [CodRemision]='" & FrmRecepcion.TxtRemision.Text & "',[CodConacafe]='" & FrmRecepcion.TxtRConacafe.Text & "' ,[Activo] = '" & Activo & "' " & _
                         "WHERE (NumeroRecepcion = '" & ConsecutivoRecepcion & "')"
            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(SqlCompras, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            MiConexion.Close()
        End If

        If iResultado = 1 And ActualizarSerie = True Then
            MiConexion.Close()
            SqlCompras = "UPDATE [Consecutivos]  SET [Recepcion] = " & ConsecutivoRecepcion & ""
            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(SqlCompras, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            MiConexion.Close()
        End If
    End Sub

    Public Sub GrabaDetalleRecepcion(ByVal ConsecutivoNotaPesa As String, ByVal CodigoProducto As String, ByVal Peso As Double, ByVal Linea As Double, ByVal Descripcion As String, ByVal Calidad As String, ByVal Estado As String, ByVal Precio As Double, ByVal PesoKg As Double, ByVal TipoRecepcion As String, ByVal Taralb As Double, ByVal PesoNetoKg As Double, ByVal QQ As Double, ByVal Fecha As Date, ByVal PesoNetoLb As Double)
        Dim Sqldetalle As String, ComandoUpdate As New SqlClient.SqlCommand, iResultado As Integer
        Dim MiConexion As New SqlClient.SqlConnection(Conexion), SqlUpdate As String
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter

        Sqldetalle = "SELECT Detalle_Recepcion.* FROM Detalle_Recepcion " & _
                     "WHERE (id_Eventos = " & Linea & ") AND (NumeroRecepcion = '" & ConsecutivoNotaPesa & "') AND (Fecha = CONVERT(DATETIME, '" & Format(CDate(Fecha), "yyyy-MM-dd") & "', 102))"
        DataAdapter = New SqlClient.SqlDataAdapter(Sqldetalle, MiConexion)
        DataAdapter.Fill(DataSet, "DetalleRecepcion")
        If Not DataSet.Tables("DetalleRecepcion").Rows.Count = 0 Then
            '////////////////////////////EDITO EL DETALLE DE COMPRAS///////////////////////////////////
            SqlUpdate = "UPDATE [dbo].[Detalle_Recepcion] SET [id_Eventos] ='" & Linea & "',[NumeroRecepcion] ='" & ConsecutivoNotaPesa & "',[TipoRecepcion] ='Recepcion',[Cod_Productos] ='" & FrmRecepcion.CboVariedad.SelectedValue & "',[Descripcion_Producto] ='" & FrmRecepcion.CboVariedad.Text & "',[Cantidad] ='" & Peso & "',[Unidad_Medida] ='Kg' ,[Transferido] = 0 ,[Estado] ='" & FrmRecepcion.CboEstado.Text & "',[Precio] = '0.00' ,[PesoKg] ='" & PesoKg & "',[Tara] ='" & Taralb & "',[PesoNetoLb] =" & PesoNetoLb & ",[PesoNetoKg] =" & PesoNetoKg & " ,[QQ] = " & QQ & ",[Liquidado] = '0',[Codigo_Beams] ='999999',[Codigo_BeamsOrigen] ='999999',[RecepcionBin] ='999999',[Calidad] ='" & FrmRecepcion.CboCalidad.Text & "',[Fecha] = '" & Format(CDate(Fecha), "yyyy-MM-dd") & "' " & _
                        "WHERE (id_Eventos = " & Linea & ") AND (NumeroRecepcion = '" & ConsecutivoNotaPesa & "') AND (Fecha = CONVERT(DATETIME, '" & Format(CDate(Fecha), "yyyy-MM-dd") & "', 102))"
            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(SqlUpdate, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            MiConexion.Close()
        Else
            SqlUpdate = "INSERT INTO [dbo].[Detalle_Recepcion]([id_Eventos],[NumeroRecepcion],[TipoRecepcion],[Cod_Productos],[Descripcion_Producto],[Cantidad],[Unidad_Medida],[Transferido],[Estado],[Precio],[PesoKg],[Tara],[PesoNetoLb],[PesoNetoKg],[QQ],[Liquidado],[Codigo_Beams],[Codigo_BeamsOrigen],[RecepcionBin],[Calidad],[Fecha])" & _
                        "VALUES (" & Linea & ",'" & ConsecutivoNotaPesa & "','Recepcion','" & FrmRecepcion.CboVariedad.SelectedValue & "','" & FrmRecepcion.CboVariedad.Text & "','" & Peso & "','Kg',0,'" & FrmRecepcion.CboEstado.Text & "','0.00'," & PesoKg & ", '" & Taralb & "', " & PesoNetoLb & ", " & PesoNetoKg & ", " & QQ & ",'0','999999','999999','999999','" & FrmRecepcion.CboCalidad.Text & "','" & Format(CDate(Fecha), "yyyy-MM-dd") & "')"
            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(SqlUpdate, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            MiConexion.Close()
        End If
    End Sub

    Public Sub ActualizaDetalleRecepcion(ByVal ConsecutivoRecepcion As String, ByVal Fecha As Date)

        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim Sql As String
        Dim MiConexion As New SqlClient.SqlConnection(Conexion)

        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        '///////////////////////////////CARGO EL DETALLE DE COMPRAS/////////////////////////////////////////////////////////////////
        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        Sql = "SELECT  id_Eventos As Linea, Cod_Productos, Descripcion_Producto, Calidad, Estado, Cantidad, PesoKg, Tara, PesoNetoLb, PesoNetoKg, QQ As Saco, Precio  FROM Detalle_Recepcion  " & _
              "WHERE  (NumeroRecepcion = '" & ConsecutivoRecepcion & "') AND (Fecha = CONVERT(DATETIME, '" & Format(CDate(Fecha), "yyyy-MM-dd") & "', 102))"

        DataAdapter = New SqlClient.SqlDataAdapter(Sql, MiConexion)
        DataAdapter.Fill(DataSet, "DetalleRecepcion")
        My.Forms.FrmRecepcion.BindingDetalle.DataSource = DataSet.Tables("DetalleRecepcion")
        My.Forms.FrmRecepcion.TrueDBDetalleNP.DataSource = My.Forms.FrmRecepcion.BindingDetalle

        My.Forms.FrmRecepcion.TrueDBDetalleNP.Columns(0).Caption = "N∞"
        My.Forms.FrmRecepcion.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(0).Width = 40
        My.Forms.FrmRecepcion.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(0).Locked = True

        My.Forms.FrmRecepcion.TrueDBDetalleNP.Columns(1).Caption = "VARIEDAD"
        'Me.TxtNombreProducto.Splits.Item(0).DisplayColumns(1).Button = True
        'Me.TxtNombreProducto.Splits.Item(0).DisplayColumns(1).Width = 63
        My.Forms.FrmRecepcion.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(1).Visible = False

        My.Forms.FrmRecepcion.TrueDBDetalleNP.Columns(2).Caption = "VARIEDAD"
        My.Forms.FrmRecepcion.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(2).Width = 300
        My.Forms.FrmRecepcion.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(2).Locked = True

        My.Forms.FrmRecepcion.TrueDBDetalleNP.Columns(3).Caption = "CALIDAD"
        'Me.TxtNombreProducto.Splits.Item(0).DisplayColumns(3).Width = 50
        'Me.TxtNombreProducto.Splits.Item(0).DisplayColumns(3).Locked = True
        My.Forms.FrmRecepcion.TrueDBDetalleNP.Splits.Item(0).DisplayColumns("CALIDAD").Visible = False

        My.Forms.FrmRecepcion.TrueDBDetalleNP.Columns(4).Caption = "ESTADO"
        'Me.TxtNombreProducto.Splits.Item(0).DisplayColumns(4).Width = 50
        'Me.TxtNombreProducto.Splits.Item(0).DisplayColumns(4).Locked = True
        My.Forms.FrmRecepcion.TrueDBDetalleNP.Splits.Item(0).DisplayColumns("ESTADO").Visible = False

        My.Forms.FrmRecepcion.TrueDBDetalleNP.Columns(5).Caption = "SACOS"
        My.Forms.FrmRecepcion.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(5).Width = 50

        My.Forms.FrmRecepcion.TrueDBDetalleNP.Columns(6).Caption = "PESO/lb"
        My.Forms.FrmRecepcion.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(6).Width = 75

        My.Forms.FrmRecepcion.TrueDBDetalleNP.Columns(7).Caption = "PESO/kg"
        My.Forms.FrmRecepcion.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(7).Width = 85

        My.Forms.FrmRecepcion.TrueDBDetalleNP.Columns(8).Caption = "TARA/lb"
        My.Forms.FrmRecepcion.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(8).Width = 75
        My.Forms.FrmRecepcion.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(8).Locked = True

        My.Forms.FrmRecepcion.TrueDBDetalleNP.Columns(9).Caption = "P.NETO/lb"
        My.Forms.FrmRecepcion.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(9).Width = 75

        My.Forms.FrmRecepcion.TrueDBDetalleNP.Columns(10).Caption = "P.NETO/kg"
        My.Forms.FrmRecepcion.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(10).Width = 75

        My.Forms.FrmRecepcion.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(11).Width = 75
        My.Forms.FrmRecepcion.TrueDBDetalleNP.Splits.Item(0).DisplayColumns(11).Visible = False
    End Sub

    Public Function ConsecutivoRecepcion() As Double
        '    Dim SqlConsecutivo As String, SQlUpdate As String, CodConsecutivo As Double, BuscaConsecutivo As Double
        '    Dim MiConexion As New SqlClient.SqlConnection(Conexion), SqlString As String
        '    Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        '    Dim ComandoUpdate As New SqlClient.SqlCommand, iResultado As Integer, Numero As Double, Cadena As String, CadenaSplit() As String, IdLugarAcopio As Double = 0

        '    '///////////////////////BUSCO EL CONSECUTIVO COMPONENTES/////////////////////////////////
        '    BuscaConsecutivo = 0
        '    SqlConsecutivo = "SELECT TipoRecepcion, IdLugarAcopio, NumeroRecepcion FROM Recepcion WHERE  (NumeroRecepcion LIKE '%" "%') ORDER BY NumeroRecepcion DESC"
        '    DataAdapter = New SqlClient.SqlDataAdapter(SqlConsecutivo, MiConexion)
        '    DataAdapter.Fill(DataSet, "Consecutivo")
        '    If Not DataSet.Tables("Consecutivo").Rows.Count = 0 Then
        '        Numero = Len(DataSet.Tables("Consecutivo").Rows(0)("NumeroRecepcion"))
        '        If Numero <= 6 Then
        '            CodConsecutivo = DataSet.Tables("Consecutivo").Rows(0)("NumeroRecepcion")
        '            CodConsecutivo = CodConsecutivo + 1
        '        Else
        '            Cadena = DataSet.Tables("Consecutivo").Rows(0)("NumeroRecepcion")
        '            CadenaSplit = Cadena.Split("-")
        '            CodConsecutivo = CadenaSplit(1)
        '            CodConsecutivo = CodConsecutivo + 1
        '        End If
        '    Else
        '        CodConsecutivo = 1
        '    End If
        '    BuscaConsecutivo = CodConsecutivo
        '    Return BuscaConsecutivo
    End Function

    Public Function BuscaLinea(ByVal NumeroRecepcion As String, ByVal FechaRecepcion As Date, ByVal TipoRecepcion As String) As Double
        Dim Sql As String, Fecha As Date
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim MiConexion As New SqlClient.SqlConnection(Conexion), Registros As Double, i As Double, j As Double
        Dim iResultado As Integer, SqlUpdate As String, ComandoUpdate As New SqlClient.SqlCommand, Linea As Double = 0

        Fecha = Format(FechaRecepcion, "yyyy-MM-dd")

        Sql = "SELECT  Detalle_Recepcion.* FROM Detalle_Recepcion WHERE (NumeroRecepcion = '" & NumeroRecepcion & "') AND (Fecha = CONVERT(DATETIME, '" & Format(FechaRecepcion, "yyyy-MM-dd") & "', 102))"
        DataAdapter = New SqlClient.SqlDataAdapter(Sql, MiConexion)
        DataAdapter.Fill(DataSet, "DetalleRecepcion")
        Registros = DataSet.Tables("DetalleRecepcion").Rows.Count
        i = 0
        j = 1
        Do While Registros > i
            '////////////////////////////EDITO EL DETALLE DE COMPRAS///////////////////////////////////
            Linea = DataSet.Tables("DetalleRecepcion").Rows(i)("id_Eventos")
            SqlUpdate = "UPDATE [Detalle_Recepcion]  SET [id_Eventos] = " & j & " " & _
                        "WHERE (NumeroRecepcion = '" & NumeroRecepcion & "') AND (Fecha = CONVERT(DATETIME, '" & Format(FechaRecepcion, "yyyy-MM-dd") & "', 102)) AND (id_Eventos = " & Linea & ")"
            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(SqlUpdate, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            MiConexion.Close()
            i = i + 1
            j = j + 1
        Loop
        BuscaLinea = j
    End Function


    Public Sub GrabaImperfeccion(ByVal NumeroNotaPeso As String)
        Dim count As Integer = FrmRecepcion.TDGImperfeccion.RowCount, i As Integer
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter, StrSqlSelect As String
        Dim StrSqlInsert As String, StrSqlUpdate As String
        Dim ComandoUpdate As New SqlClient.SqlCommand, iResultado As Integer
        Dim MiConexion As New SqlClient.SqlConnection(Conexion)
        MiConexion.Close()

        StrSqlSelect = "SELECT IdDetalleImperfeccion, NumeroRecepcion, Imperfeccion, Porcentaje  FROM  DetalleImperfeccion  WHERE (NumeroRecepcion = N'" & NumeroNotaPeso & "')"
        DataAdapter = New SqlClient.SqlDataAdapter(StrSqlSelect, MiConexion)
        DataAdapter.Fill(DataSet, "DetalleImperfeccion")
        ' DataSet.Tables("DetalleImperfeccion").Reset()
        i = 0
        Do While count > i
            If DataSet.Tables("DetalleImperfeccion").Rows.Count = 0 Then
                StrSqlInsert = " INSERT INTO [dbo].[DetalleImperfeccion]([NumeroRecepcion],[Imperfeccion],[Porcentaje])" & _
               " VALUES ('" & NumeroNotaPeso & "','" & FrmRecepcion.TDGImperfeccion.Item(i)("Imperfeccion") & "', '" & FrmRecepcion.TDGImperfeccion.Item(i)("Porcentaje") & "')"
                MiConexion.Open()
                ComandoUpdate = New SqlClient.SqlCommand(StrSqlInsert, MiConexion)
                iResultado = ComandoUpdate.ExecuteNonQuery
                MiConexion.Close()
            Else
                StrSqlUpdate = " UPDATE [dbo].[DetalleImperfeccion] SET [NumeroRecepcion] = '" & NumeroNotaPeso & "' ,[Imperfeccion] = '" & FrmRecepcion.TDGImperfeccion.Item(i)("Imperfeccion") & "' ,[Porcentaje] ='" & FrmRecepcion.TDGImperfeccion.Item(i)("Porcentaje") & "'  WHERE  (IdDetalleImperfeccion = '" & FrmRecepcion.TDGImperfeccion.Item(i)("IdDetalleImperfeccion") & "')"
                MiConexion.Open()
                ComandoUpdate = New SqlClient.SqlCommand(StrSqlUpdate, MiConexion)
                iResultado = ComandoUpdate.ExecuteNonQuery
                MiConexion.Close()
            End If
            i = i + 1
        Loop
    End Sub

    '//////////////////////////////////////////////////////////////////////////////////////////////////
    '/////////////////////////////////////////////////////////////////////////////////////////////////
    Public Sub CentrarLabes(ByVal l As Label, ByVal panel As Panel)
        l.Location = New System.Drawing.Point((panel.Size.Width / 2) - (l.Size.Width / 2), (panel.Size.Height / 2) - (l.Size.Height / 2))
    End Sub

    Public Sub ActualizaDetalleRemision(ByVal ConsecutivoRemision As String, ByVal TipoRemision As String, ByVal Calidad As String, ByVal EstadoFisico As String, ByVal TipoPesada As String)

        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim Sql As String
        Dim MiConexion As New SqlClient.SqlConnection(Conexion)
        Dim Fecha As String

        'Fecha = Format(CDate(FrmBascula.DTPFecha.Text), "yyyy-MM-dd")

        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        '///////////////////////////////CARGO EL DETALLE DE COMPRAS/////////////////////////////////////////////////////////////////
        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        Sql = "SELECT  id_Eventos As Linea, Cod_Productos, Descripcion_Producto, Calidad, Estado, Cantidad, PesoKg, Tara, PesoNetoLb, PesoNetoKg, QQ As Saco, Precio  FROM Detalle_Pesadas  " & _
              "WHERE  (NumeroRemision = '" & ConsecutivoRemision & "') AND (Fecha = CONVERT(DATETIME, '" & Format(CDate(Fecha), "yyyy-MM-dd") & "', 102)) AND (TipoRemision = '" & TipoRemision & "') AND (Calidad = '" & Calidad & "') AND (Estado = '" & EstadoFisico & "') AND (TipoPesada = '" & TipoPesada & "')"

        DataAdapter = New SqlClient.SqlDataAdapter(Sql, MiConexion)
        DataAdapter.Fill(DataSet, "DetalleRecepcion")
        'My.Forms.FrmBascula.BindingDetalle.DataSource = DataSet.Tables("DetalleRecepcion")
        'My.Forms.FrmBascula.TrueDBGridComponentes.DataSource = My.Forms.FrmBascula.BindingDetalle
        'My.Forms.FrmBascula.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(0).Width = 40
        'My.Forms.FrmBascula.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(0).Locked = True
        'My.Forms.FrmBascula.TrueDBGridComponentes.Columns(0).Caption = "Psda"

        'My.Forms.FrmBascula.TrueDBGridComponentes.Columns(1).Caption = "CÛdigo"
        'My.Forms.FrmBascula.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(1).Button = True
        'My.Forms.FrmBascula.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(1).Width = 63
        'My.Forms.FrmBascula.TrueDBGridComponentes.Columns(2).Caption = "DescripciÛn"
        'My.Forms.FrmBascula.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(2).Width = 200
        'My.Forms.FrmBascula.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(2).Locked = True
        'My.Forms.FrmBascula.TrueDBGridComponentes.Columns(3).Caption = "Categ"
        'My.Forms.FrmBascula.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(3).Width = 50
        'My.Forms.FrmBascula.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(3).Locked = True
        'My.Forms.FrmBascula.TrueDBGridComponentes.Columns(4).Caption = "Estado"
        'My.Forms.FrmBascula.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(4).Width = 50
        'My.Forms.FrmBascula.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(4).Locked = True
        'My.Forms.FrmBascula.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(5).Width = 75
        'My.Forms.FrmBascula.TrueDBGridComponentes.Columns(5).Caption = "PesoLb"
        ''Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(4).Locked = True
        'My.Forms.FrmBascula.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(6).Width = 85
        ''Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(2).Button = True
        ''Me.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(3).Button = True
        'My.Forms.FrmBascula.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(7).Width = 75
        'My.Forms.FrmBascula.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(7).Locked = True
        'My.Forms.FrmBascula.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(8).Width = 75
        'My.Forms.FrmBascula.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(9).Width = 75
        'My.Forms.FrmBascula.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(10).Width = 50
        'My.Forms.FrmBascula.TrueDBGridComponentes.Splits.Item(0).DisplayColumns(11).Width = 75
    End Sub

    Public Function BuscaLineaRemision(ByVal NumeroRemision As String, ByVal FechaRemision As Date, ByVal TipoRemision As String, ByVal Calidad As String, ByVal EstadoFisico As String, ByVal TipoPesada As String) As Double
        Dim Sql As String, Fecha As Date
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim MiConexion As New SqlClient.SqlConnection(Conexion), Registros As Double, i As Double, j As Double
        Dim iResultado As Integer, SqlUpdate As String, ComandoUpdate As New SqlClient.SqlCommand, Linea As Double = 0

        Fecha = Format(FechaRemision, "yyyy-MM-dd")

        Sql = "SELECT  Detalle_Pesadas.* FROM Detalle_Pesadas WHERE (NumeroRemision = '" & NumeroRemision & "')  AND (TipoRemision = '" & TipoRemision & "') AND (Fecha = CONVERT(DATETIME, '" & Format(FechaRemision, "yyyy-MM-dd") & "', 102)) AND (Calidad = '" & Calidad & "') AND (Estado = '" & EstadoFisico & "') AND (TipoPesada = '" & TipoPesada & "')"
        'Sql = "SELECT id_Eventos, NumeroRecepcion, Fecha, TipoRecepcion, Cod_Productos, Descripcion_Producto, Codigo_Beams, Cantidad, Unidad_Medida, Liquidado,  Codigo_BeamsOrigen, RecepcionBin, Transferido, Calidad, Estado, Precio, PesoKg, Tara, PesoNetoLb, PesoNetoKg, QQ, Calidad_Cafe FROM Detalle_Recepcion " & _
        '      "WHERE (NumeroRecepcion = '" & NumeroRecepcion & "') AND (TipoRecepcion = '" & TipoRecepcion & "') AND (Fecha = CONVERT(DATETIME,  '" & Format(Fecha, "yyyy-MM-dd") & "', 102))"
        DataAdapter = New SqlClient.SqlDataAdapter(Sql, MiConexion)
        DataAdapter.Fill(DataSet, "DetalleRemision")
        Registros = DataSet.Tables("DetalleRemision").Rows.Count
        i = 0
        j = 1
        Do While Registros > i
            '//////////////////////////////////////////////////////////////////////////////////////////////
            '////////////////////////////EDITO EL DETALLE DE COMPRAS///////////////////////////////////
            '/////////////////////////////////////////////////////////////////////////////////////////////////
            Linea = DataSet.Tables("DetalleRemision").Rows(i)("id_Eventos")
            SqlUpdate = "UPDATE [Detalle_Pesadas]  SET [id_Eventos] = " & j & " " & _
                        "WHERE (NumeroRemision = '" & NumeroRemision & "') AND (Fecha = CONVERT(DATETIME, '" & Format(FechaRemision, "yyyy-MM-dd") & "', 102)) AND (TipoRemision = '" & TipoRemision & "') AND (id_Eventos = " & Linea & ") AND (Calidad = '" & Calidad & "') AND (Estado = '" & EstadoFisico & "') AND (TipoPesada = '" & TipoPesada & "')"
            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(SqlUpdate, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            MiConexion.Close()


            i = i + 1
            j = j + 1
        Loop
        BuscaLineaRemision = j

    End Function

    Public Function BuscaConsecutivoRemisionManual(ByVal Serie As String, ByVal IdTipoCafe As Double, ByVal IdCosecha As Double, ByVal IdLocalidad As Double, ByVal NumeroRecibo As String) As String
        Dim MiConexion As New SqlClient.SqlConnection(Conexion)
        Dim Sqlstring As String
        Dim DataAdapter As SqlClient.SqlDataAdapter, DataSet As New DataSet
        Dim Consecutivo As Double

        If Serie = "" Then
            Sqlstring = "SELECT   IdLiquidacionPergamino, Codigo, Fecha, Precio, IdEstadoFisico, IdCategoriaImperfeccion, IdEstadoDocumento, IdMoneda, IdMonedaPreecio, IdMunicipio, SincronizadoESC, NumeroReembolso, IdTipoIngreso, IdCosecha,    IdLocalidad, Cod_Proveedor, IdTipoCompra, PrecioAutoriza, TotalDeducciones, ChkRentDef, ChkRent2, ChkRent3, ChkMuncipal, IdTipoCambio, Serie  FROM        LiquidacionPergamino " & _
                         "WHERE (IdCosecha = " & IdCosecha & ") AND (IdLocalidad = " & IdLocalidad & ")  AND (LEN(Codigo) <= 6) AND (Serie = '?')  AND (Codigo = '" & NumeroRecibo & "') ORDER BY Codigo DESC"
        Else
            Sqlstring = "SELECT  IdLiquidacionPergamino, Codigo, Fecha, Precio, IdEstadoFisico, IdCategoriaImperfeccion, IdEstadoDocumento, IdMoneda, IdMonedaPreecio, IdMunicipio, SincronizadoESC, NumeroReembolso, IdTipoIngreso, IdCosecha,    IdLocalidad, Cod_Proveedor, IdTipoCompra, PrecioAutoriza, TotalDeducciones, ChkRentDef, ChkRent2, ChkRent3, ChkMuncipal, IdTipoCambio, Serie  FROM        LiquidacionPergamino " & _
                                    "WHERE (IdCosecha = " & IdCosecha & ") AND (IdLocalidad = " & IdLocalidad & ")   AND (LEN(Codigo) <= 6)AND (Serie = '" & Serie & "') AND (Codigo = '" & NumeroRecibo & "') ORDER BY Codigo DESC"
        End If
        DataAdapter = New SqlClient.SqlDataAdapter(Sqlstring, MiConexion)
        DataAdapter.Fill(DataSet, "Serie")
        If DataSet.Tables("Serie").Rows.Count <> 0 Then
            Consecutivo = DataSet.Tables("Serie").Rows(0)("Codigo")
            BuscaConsecutivoRemisionManual = Format(Consecutivo + 1, "00000#")
        Else
            BuscaConsecutivoRemisionManual = "000000"
        End If

    End Function

    Public Sub GrabaLecturaPesoRemision(ByVal Peso As Double)
        Dim MiConexion As New SqlClient.SqlConnection(Conexion)

        Dim ConsecutivoCompra As Double, NumeroRemision As String, Registros As Double, Iposicion As Double
        Dim Linea As Double, CodigoProducto As String, Cantidad As Double, Descripcion As String, CodigoBeams As String, UnidadMedida As String = ""
        Dim CodigoBeamsOrigen As String = "", CodigoRecepcionBin As String = "", Calidad As String, Estado As String, SqlString As String
        Dim DataSet As New DataSet, DataAdapterProductos As New SqlClient.SqlDataAdapter, PesoKg As Double, Precio As Double, DataAdapter As New SqlClient.SqlDataAdapter
        Dim Tara As Double = 0, PesoNetoLb As Double = 0, PesoNetoKg As Double = 0, QQ As Double = 0, LugarAcopio As Integer, SubTotal As Double = 0
        Dim HumedadxDefecto As Double = 0, HumedadReal As Double = 0, Consecutivo As Double, NumeroRecibo As String, Cadena As String, CadenaDiv() As String
        Dim CodLugarAcopio As Double, IdCategoria As Double


        'SqlString = "SELECT  LugarAcopio.* FROM LugarAcopio WHERE  (IdLugarAcopio = " & FrmBasculan.IdLugarAcopio & " ) AND (Activo = 1)"
        'DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        'DataAdapter.Fill(DataSet, "ConsultaLugarAcopio")
        'If DataSet.Tables("ConsultaLugarAcopio").Rows.Count <> 0 Then
        '    CodLugarAcopio = DataSet.Tables("ConsultaLugarAcopio").Rows(0)("CodLugarAcopio")
        'Else
        '    CodLugarAcopio = FrmBasculan.TxtIdLocalidad.Text
        'End If



        ''////////////////////////////////////////////////////////////////////////////////////////////////////
        ''/////////////////////////////BUSCO EL CONSECUTIVO DE LA COMPRA /////////////////////////////////////////////
        ''//////////////////////////////////////////////////////////////////////////////////////////////////////////7
        'If FrmBasculan.TxtNumeroEnsamble.Text = "-----0-----" Then
        '    Select Case FrmBasculan.CboTipoRecepcion.Text
        '        Case "Recepcion"
        '            ConsecutivoCompra = BuscaConsecutivo("Recepcion", CodLugarAcopio)

        '        Case "RePesaje"
        '            ConsecutivoCompra = BuscaConsecutivo("ReImprime", CodLugarAcopio)
        '        Case "Lote"
        '            ConsecutivoCompra = BuscaConsecutivo("Lote", CodLugarAcopio)
        '    End Select

        '    NumeroRecepcion = CodLugarAcopio & "-" & Format(ConsecutivoCompra, "00000#")
        'Else
        '    NumeroRecepcion = FrmBasculan.TxtNumeroEnsamble.Text
        'End If




        ''////////////////////////////////////////////////////////////////////////////////////////////////////////
        ''/////////////////////////////////BUSCO EL CONSECUTIVO DEL RECIBO ///////////////////////////////////////
        ''/////////////////////////////////////////////////////////////////////////////////////////////////////////
        'If FrmBasculan.TxtNumeroRecibo.Text = "-----0-----" Then
        '    SqlString = "SELECT Codigo FROM ReciboCafePergamino WHERE (IdCosecha = " & FrmBasculan.IdCosecha & ") AND (IdLocalidad = " & FrmBasculan.IdLugarAcopio & ") AND (IdTipoCompra = " & FrmBasculan.IdTipoCompra & ") AND (IdTipoCafe = " & FrmBasculan.IdTipoCafe & ")  AND (LEN(Codigo) > 6) AND (Codigo LIKE '%" & CodLugarAcopio & "%') ORDER BY Codigo DESC"
        '    DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        '    DataAdapter.Fill(DataSet, "NumeroRecibo")
        '    If DataSet.Tables("NumeroRecibo").Rows.Count <> 0 Then
        '        Cadena = DataSet.Tables("NumeroRecibo").Rows(0)("Codigo")
        '        If Len(Cadena) >= 6 Then
        '            CadenaDiv = Cadena.Split("-")
        '            Consecutivo = CadenaDiv(1)
        '            Consecutivo = Consecutivo + 1
        '        End If
        '    Else
        '        Consecutivo = 1
        '    End If

        '    NumeroRecibo = Format(Consecutivo, "00000#")
        '    FrmBasculan.TxtNumeroRecibo.Text = NumeroRecibo

        'Else
        '    NumeroRecibo = FrmBasculan.TxtNumeroRecibo.Text
        'End If


        ''////////////////////////////////////////////////////////////////////////////////////////////////////
        ''/////////////////////////////GRABO ENCABEZADO DE RECEPCION /////////////////////////////////////////////
        ''//////////////////////////////////////////////////////////////////////////////////////////////////////////7
        'GrabaRecepcion(NumeroRecepcion)

        '////////////////////////////////////////////////////////////////////////////////////////////////////
        '/////////////////////////////GRABO EL DETALLE DE LA RECEPCION /////////////////////////////////////////////
        '//////////////////////////////////////////////////////////////////////////////////////////////////////////

        'Registros = FrmRecepcion.BindingDetalle.Count
        'Iposicion = FrmRecepcion.BindingDetalle.Position
        'If My.Forms.FrmRecepcion.TrueDBGridComponentes.Columns(0).Text = "" Then
        '    Linea = BuscaLineaRemision(NumeroRemision, CDate(My.Forms.FrmBascula.DTPFecha.Text), My.Forms.FrmBascula.TxtTipoRemision.Text, FrmBascula.Calidad, FrmBascula.EstadoFisico, FrmBascula.TipoPesada)
        'Else
        '    Linea = FrmBascula.TrueDBGridComponentes.Columns(0).Text
        'End If

        'CodigoProducto = FrmBascula.CboIngresoBascula.Columns(0).Text

        'Descripcion = FrmBascula.CboIngresoBascula.Columns(1).Text

        ''If FrmBasculan.CboCategoria.Text <> "" Then
        ''    Calidad = FrmBasculan.CboCategoria.Text
        ''End If

        ''If FrmBasculan.OptMojado.Checked = True Then
        ''    Estado = "Mojado"
        ''ElseIf FrmBasculan.OptHumedo.Checked = True Then
        ''    Estado = "Humedo"
        ''ElseIf FrmBasculan.OptOreado.Checked = True Then
        ''    Estado = "Oreado"
        ''End If

        'Estado = FrmBasculan.CboEstado.Text

        '/////////////////////////////////////////////////////////////////////////////////////////
        '/////////////////////////CONSULTO EL PRECIO DE VENTA //////////////////////////////////////
        '////////////////////////////////////////////////////////////////////////////////////////////
        'SqlString = "SELECT  Productos.* FROM Productos WHERE (Tipo_Producto <> 'Servicio') AND (Tipo_Producto <> 'Descuento')"
        'DataAdapterProductos = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        'DataAdapterProductos.Fill(DataSet, "Precios")
        'If Not DataSet.Tables("Precios").Rows.Count = 0 Then
        '    Select Case FrmBasculan.CboTipoProducto.Text
        '        Case "A" : Precio = DataSet.Tables("Precios").Rows(0)("Precio_Venta")
        '        Case "B" : Precio = DataSet.Tables("Precios").Rows(0)("Precio_Lista")
        '        Case "C" : Precio = DataSet.Tables("Precios").Rows(0)("Precio_Compra")
        '    End Select

        'End If
        'Precio = PrecioVenta(CodigoProducto, FrmBasculan.IdLugarAcopio, FrmBasculan.CboCategoria.Text, CDate(FrmRecepcion.DTPFecha.Text))
        'Precio = PrecioVenta(FrmRecepcion.IdLugarAcopio, FrmRecepcion.IdCalidad, FrmRecepcion.CboCategoria.Text)
        Precio = 0
        Cantidad = Peso
        '-------------------------------PREGUNTO LOS QUINTALES -----------------------------
        '--------------------------------------------------------------------------------------
        My.Forms.FrmQQ.ShowDialog()
        QQ = My.Forms.FrmQQ.QQ

        '/////////////////////////////CONVERTIR DE LIBRAS A KG //////////////////////////////////////////
        PesoKg = Cantidad
        Cantidad = Format((Cantidad / 46) * 100, "##,##0.00")

        Dim Factor As Double = 0, IdEsdoFisico As Double = 0, IdCalidad As Double = 0, IdTipoLugarAcopio As Double = 0

        'If FrmBascula.TipoPesada = "DetalleRemision" & FrmBascula.Posicion Then
        '////////////////////////////////////////////////////////////////////////////////////////////////////
        '//////////////////////CONSULTO LAS TARAS /////////////////////////////////////////////////////////
        '////////////////////////////////////////////////////////////////////////////////////////////////////
        SqlString = "SELECT FactorTara FROM FactorSaco WHERE  (IdEdoFisico = " & IdEsdoFisico & " )  AND (IdTipoLugarAcopio = " & IdTipoLugarAcopio & ") AND (IdUMedida = 1) AND (IdCalidad = " & IdCalidad & ")"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "Tara")
        If DataSet.Tables("Tara").Rows.Count <> 0 Then
            Factor = DataSet.Tables("Tara").Rows(0)("FactorTara")
        Else
            Factor = 0
        End If

        'Tara = Factor * QQ
        'Else
        'Tara = 0
        'End If

        'If FrmRecepcion.CboTipoCalidad.Text = "AP1ra" Then
        '    Select Case Estado
        '        Case "Mojado" : Tara = 0.46 * QQ
        '        Case "Humedo" : Tara = 0.23 * QQ
        '        Case "Oreado" : Tara = 0.23 * QQ
        '    End Select
        'ElseIf FrmRecepcion.CboTipoCalidad.Text = "AP2da" Then
        '    Select Case Estado
        '        Case "Mojado" : Tara = 0.46 * QQ
        '        Case "Humedo" : Tara = 0.23 * QQ
        '        Case "Oreado" : Tara = 0.23 * QQ
        '    End Select
        'ElseIf FrmRecepcion.CboTipoCalidad.Text = "BROZA" Then
        '    Select Case Estado
        '        Case "Mojado" : Tara = 0.46 * QQ
        '        Case "Humedo" : Tara = 0.23 * QQ
        '        Case "Oreado" : Tara = 0.23 * QQ
        '    End Select
        'ElseIf FrmRecepcion.CboTipoCalidad.Text = "FRUTO" Then
        '    Select Case Estado
        '        Case "Mojado" : Tara = 0.46 * QQ
        '        Case "Humedo" : Tara = 0.23 * QQ
        '        Case "Oreado" : Tara = 0.23 * QQ
        '    End Select
        'ElseIf FrmRecepcion.CboTipoCalidad.Text = "PULPON" Then
        '    Select Case Estado
        '        Case "Mojado" : Tara = 0.46 * QQ
        '        Case "Humedo" : Tara = 0.23 * QQ
        '        Case "Oreado" : Tara = 0.23 * QQ
        '    End Select
        'ElseIf FrmRecepcion.CboTipoCalidad.Text = "MP1ra" Then
        '    Select Case Estado
        '        Case "Mojado" : Tara = 0.46 * QQ
        '        Case "Humedo" : Tara = 0.23 * QQ
        '        Case "Oreado" : Tara = 0.23 * QQ
        '    End Select
        'End If

        PesoNetoKg = Format((PesoKg - Tara), "##,##0.0000")
        PesoNetoLb = Format((PesoNetoKg / 46) * 100, "##,##0.0000")

        '   GrabaDetalleRemision(NumeroRemision, CodigoProducto, Cantidad, Linea, Descripcion, Calidad, Estado, Precio, PesoKg, FrmBascula.TxtTipoRemision.Text, Tara, PesoNetoKg, QQ, FrmBascula.Calidad, FrmBascula.TipoPesada, FrmBascula.DTPRemFechCarga.Value)
        'ActualizaDetalleRemision(NumeroRemision, FrmBascula.TxtTipoRemision.Text, FrmBascula.Calidad, FrmBascula.EstadoFisico, FrmBascula.TipoPesada)



        ''////////////////////////////////////////////BUSCO LA RELACION ENTRE CALIDAD /////////////////////////////////////
        'SqlString = "SELECT  EstadoFisico, Codigo, Descripcion, HumedadInicial, HumedadFinal, HumedadXDefecto  FROM EstadoFisico WHERE (Descripcion = '" & FrmBascula.CboEstado.Text & "')"
        'DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        'DataAdapter.Fill(DataSet, "Consulta")
        'If DataSet.Tables("Consulta").Rows.Count <> 0 Then
        '    HumedadxDefecto = DataSet.Tables("Consulta").Rows(0)("HumedadXDefecto")
        'End If



        'FrmBascula.TxtEqOreado.Text = Format(SubTotal * (1 - (HumedadxDefecto - 42) / 100), "##,##0.00")
        'FrmBascula.TxtOreadoReal.Text = Format(SubTotal * (1 - (HumedadReal - 42) / 100), "##,##0.00")




    End Sub

    Public Sub GrabaDetalleRemision(ByVal ConsecutivoRemision As String, ByVal CodigoProducto As String, ByVal Cantidad As Double, ByVal Linea As Double, ByVal Descripcion As String, ByVal Calidad As String, ByVal Estado As String, ByVal Precio As Double, ByVal PesoKg As Double, ByVal TipoRemision As String, ByVal Tara As Double, ByVal PesoNetoKg As Double, ByVal QQ As Double, ByVal CalidadCafe As String, ByVal TipoPesada As String, ByVal FechaCarga As Date)
        Dim Sqldetalle As String, ComandoUpdate As New SqlClient.SqlCommand, iResultado As Integer
        Dim Fecha As String, MiConexion As New SqlClient.SqlConnection(Conexion), SqlUpdate As String
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter, PesoNetoLb As Double


        PesoNetoLb = Format((PesoNetoKg / 46) * 100, "##,##0.0000")

        ''If FrmRecepcion.CboTipoDocumento.Text = "Recibo Bascula Manual" Then
        ''    Fecha = Format(CDate(FrmRecepcion.DtpFechaManual.Text), "yyyy-MM-dd")
        ''Else
        'Fecha = Format(CDate(FrmBascula.DTPFecha.Text), "yyyy-MM-dd")
        'End If


        Sqldetalle = "SELECT Detalle_Pesadas.* FROM Detalle_Pesadas " & _
                     "WHERE (id_Eventos = " & Linea & ") AND (NumeroRemision = '" & ConsecutivoRemision & "') AND (Fecha = CONVERT(DATETIME, '" & Format(CDate(Fecha), "yyyy-MM-dd") & "', 102)) AND (TipoRemision = '" & TipoRemision & "')  AND (TipoPesada = '" & TipoPesada & "')"
        DataAdapter = New SqlClient.SqlDataAdapter(Sqldetalle, MiConexion)
        DataAdapter.Fill(DataSet, "DetalleRecepcion")
        If Not DataSet.Tables("DetalleRecepcion").Rows.Count = 0 Then
            '//////////////////////////////////////////////////////////////////////////////////////////////
            '////////////////////////////EDITO EL DETALLE DE COMPRAS///////////////////////////////////
            '/////////////////////////////////////////////////////////////////////////////////////////////////
            SqlUpdate = "UPDATE [Detalle_Pesadas] SET [Cod_Productos] = '" & CodigoProducto & "',[Descripcion_Producto] = '" & Descripcion & "',[Cantidad] = " & Cantidad & ",[PesoKg] = " & PesoKg & ", [Calidad] = '" & Calidad & "', [Estado] = '" & Estado & "', [Precio] = " & Precio & ", [Tara] = " & Tara & ", [PesoNetoLb] = " & PesoNetoLb & ", [PesoNetoKg] = " & PesoNetoKg & " , [QQ] = " & QQ & ", [Calidad_Cafe] = '" & CalidadCafe & "', [FechaCarga] = CONVERT(DATETIME, '" & Format(CDate(FechaCarga), "yyyy-MM-dd HH:mm:ss") & "', 102) " & _
                        "WHERE (id_Eventos = " & Linea & ") AND (NumeroRemision = '" & ConsecutivoRemision & "') AND (Fecha = CONVERT(DATETIME, '" & Format(CDate(Fecha), "yyyy-MM-dd") & "', 102)) AND (TipoRemision = '" & TipoRemision & "') AND (TipoPesada = '" & TipoPesada & "') "  'AND (Cod_Productos = '" & CodigoProducto & "')
            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(SqlUpdate, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            MiConexion.Close()

        Else

            'SqlUpdate = "INSERT INTO [Detalle_Pesadas] ([id_Eventos],[NumeroRemision],[Fecha],[TipoRemision],[Cod_Productos],[Descripcion_Producto],[Cantidad],[PesoKg],[Calidad],[Estado],[Precio],[Tara],[PesoNetoLb],[PesoNetoKg],[QQ],[Calidad_Cafe],[TipoPesada],[FechaCarga]) " & _
            '            "VALUES (" & Linea & " ,'" & ConsecutivoRemision & "','" & Format(CDate(Fecha), "dd/MM/yyyy") & "','" & My.Forms.FrmBascula.TxtTipoRemision.Text & "','" & CodigoProducto & "','" & Descripcion & "'," & Cantidad & "," & PesoKg & ", '" & Calidad & "','" & Estado & "', " & Precio & ", " & Tara & ", " & PesoNetoLb & ", " & PesoNetoKg & ", " & QQ & ", '" & CalidadCafe & "', '" & TipoPesada & "', CONVERT(DATETIME, '" & Format(CDate(FechaCarga), "yyyy-MM-dd HH:mm:ss") & "', 102))"
            'MiConexion.Open()
            'ComandoUpdate = New SqlClient.SqlCommand(SqlUpdate, MiConexion)
            'iResultado = ComandoUpdate.ExecuteNonQuery
            'MiConexion.Close()

        End If

    End Sub

    Public Sub CreaCortePrecios(ByVal IdLocalidad As Double, ByVal FechaCorte As Date)
        Dim MiConexion As New SqlClient.SqlConnection(Conexion)
        Dim Sqlstring As String
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim FechaAnterior As Date, i As Double, RegCat As Double, idCategoria As Double, RegCalidad As Double, j As Double, idCalidad As Double
        Dim StrSqlUpdate As String, ComandoUpdate As New SqlClient.SqlCommand, iResultado As Integer, Precio As Double, FechaActualizacion As Date


        FechaAnterior = FechaCorte.AddDays(-1)

        'WHERE    (IdLocalidad = '" & IdLocalidad & "') AND (IdCalidad = " & idCalidad & ") AND (IdRangoImperfeccion = " & idCategoria & ") AND (FechaActualizacion BETWEEN CONVERT(DATETIME, '" & Format(FechaCorte, "yyyy-MM-dd") & " 00:00:00', 102) AND CONVERT(DATETIME, '" & Format(FechaCorte, "yyyy-MM-dd HH:mm:ss") & "', 102)) ORDER BY FechaActualizacion DESC"

        '///////////////////////////////////RECORRO TODAAS LAS CATEGORIAS ////////////////////////////////////////////////////////////
        Sqlstring = "SELECT  IdRangoImperfeccion, IdCosecha, Minimo, Maximo, Nombre, Deduccion FROM RangoImperfeccion   WHERE(IdCosecha = " & CodigoCosecha & ")"
        DataAdapter = New SqlClient.SqlDataAdapter(Sqlstring, MiConexion)
        DataAdapter.Fill(DataSet, "Categoria")
        RegCat = DataSet.Tables("Categoria").Rows.Count
        i = 0

        Do While RegCat > i

            idCategoria = DataSet.Tables("Categoria").Rows(i)("IdRangoImperfeccion")

            '/////////////////////////////////////////RECORRO TODAS LAS CALIDADES ////////////////////////////////////////////////////
            Sqlstring = "SELECT RelacionTipoDocumentoxCalidad.IdCalidad, Calidad.NomCalidad FROM RelacionTipoDocumentoxCalidad INNER JOIN TipoCafe ON RelacionTipoDocumentoxCalidad.IdtipoDocumento = TipoCafe.IdTipoCafe INNER JOIN Calidad ON RelacionTipoDocumentoxCalidad.IdCalidad = Calidad.IdCalidad WHERE( RelacionTipoDocumentoxCalidad.IdtipoDocumento = 1)"
            DataAdapter = New SqlClient.SqlDataAdapter(Sqlstring, MiConexion)
            DataAdapter.Fill(DataSet, "Calidad")
            RegCalidad = DataSet.Tables("Calidad").Rows.Count

            j = 0

            Do While RegCalidad > j

                idCalidad = DataSet.Tables("Calidad").Rows(j)("IdCalidad")

                '//////////////////////////////////////////////////////////////////////////////
                '/////////////VERIFICO SI EXISTE UN CORTE EN LA TABLA DE PRECIOS DE COMPLEMENTOS //////////
                '///////////////////////////////////////////////////////////////////////////////////////
                Sqlstring = "SELECT   IdLocalidad, IdCalidad, IdRangoImperfeccion, Precio, FechaActualizacion  FROM  PrecioComplemento   WHERE    (IdLocalidad = '" & IdLocalidad & "') AND (IdCalidad = " & idCalidad & ") AND (IdRangoImperfeccion = " & idCategoria & ") AND (FechaActualizacion BETWEEN CONVERT(DATETIME, '" & Format(FechaCorte, "yyyy-MM-dd") & " 00:00:00', 102) AND CONVERT(DATETIME, '" & Format(FechaCorte, "yyyy-MM-dd HH:mm:ss") & "', 102)) ORDER BY FechaActualizacion DESC"
                DataAdapter = New SqlClient.SqlDataAdapter(Sqlstring, MiConexion)
                DataAdapter.Fill(DataSet, "PrecioComplemento")
                If DataSet.Tables("PrecioComplemento").Rows.Count = 0 Then
                    '////////////////////////////////SI NO EXISTE PRECIO COMPLEMENTO AGREGO UN NUEVO PRECIO SEGUN EL ULTIMO PRECIO BASE /////////////////
                    Sqlstring = "SELECT   IdPrecioCafe, IdLocalidad, IdCalidad, IdRangoImperfeccion, Precio, FechaActualizacion  FROM  PrecioCafe   WHERE    (IdLocalidad = '" & IdLocalidad & "')  AND (IdCalidad = " & idCalidad & ") AND (IdRangoImperfeccion = " & idCategoria & ") AND (FechaActualizacion BETWEEN CONVERT(DATETIME, '" & Format(FechaCorte, "yyyy-MM-dd") & " 00:00:00', 102) AND CONVERT(DATETIME, '" & Format(FechaCorte, "yyyy-MM-dd") & " 23:59:59', 102)) ORDER BY FechaActualizacion DESC"
                    DataAdapter = New SqlClient.SqlDataAdapter(Sqlstring, MiConexion)
                    DataAdapter.Fill(DataSet, "PrecioCafe")
                    If DataSet.Tables("PrecioCafe").Rows.Count <> 0 Then

                        Precio = DataSet.Tables("PrecioCafe").Rows(0)("Precio")
                        Sqlstring = "INSERT INTO [dbo].[PrecioComplemento]  ([IdCosecha],[IdLocalidad],[IdCalidad],[IdRangoImperfeccion],[Precio],[Corte] ,[FechaActualizacion])  VALUES ( '" & CDbl(CodigoCosecha) & "','" & IdLocalidad & "','" & idCalidad & "','" & idCategoria & "','" & Precio & "','1','" & Format(CDate(FechaCorte), "dd/MM/yyyy 05:00:00") & "')"
                        MiConexion.Open()
                        ComandoUpdate = New SqlClient.SqlCommand(Sqlstring, MiConexion)
                        iResultado = ComandoUpdate.ExecuteNonQuery
                        MiConexion.Close()

                        'Sqlstring = "INSERT INTO [dbo].[PrecioCafe] ([IdLocalidad],[IdCalidad],[IdRangoImperfeccion],[Precio],[Corte],[FechaActualizacion])  VALUES ('" & IdLocalidad & "','" & idCalidad & "','" & idCategoria & "','" & Precio & "','1','" & Format(CDate(FechaCorte), "dd/MM/yyyy 05:00:00") & "')"
                        'MiConexion.Open()
                        'ComandoUpdate = New SqlClient.SqlCommand(Sqlstring, MiConexion)
                        'iResultado = ComandoUpdate.ExecuteNonQuery
                        'MiConexion.Close()

                    End If
                    DataSet.Tables("PrecioCafe").Reset()

                End If

                DataSet.Tables("PrecioComplemento").Reset()


                j = j + 1
            Loop

            i = i + 1
        Loop


    End Sub

    Public Function BuscaConsecutivoLiquidacionManual(ByVal Serie As String, ByVal IdTipoCafe As Double, ByVal IdCosecha As Double, ByVal IdLocalidad As Double, ByVal IdTipoCompra As String, ByVal NumeroRecibo As String) As String
        Dim MiConexion As New SqlClient.SqlConnection(Conexion)
        Dim Sqlstring As String
        Dim DataAdapter As SqlClient.SqlDataAdapter, DataSet As New DataSet
        Dim Consecutivo As Double

        If Serie = "" Then
            Sqlstring = "SELECT   IdLiquidacionPergamino, Codigo, Fecha, Precio, IdEstadoFisico, IdCategoriaImperfeccion, IdEstadoDocumento, IdMoneda, IdMonedaPreecio, IdMunicipio, SincronizadoESC, NumeroReembolso, IdTipoIngreso, IdCosecha,    IdLocalidad, Cod_Proveedor, IdTipoCompra, PrecioAutoriza, TotalDeducciones, ChkRentDef, ChkRent2, ChkRent3, ChkMuncipal, IdTipoCambio, Serie  FROM        LiquidacionPergamino " & _
                         "WHERE (IdCosecha = " & IdCosecha & ") AND (IdLocalidad = " & IdLocalidad & ") AND (IdTipoCompra = " & IdTipoCompra & ") AND (LEN(Codigo) <= 6) AND (Serie = '?')  AND (Codigo = '" & NumeroRecibo & "') ORDER BY Codigo DESC"
        Else
            Sqlstring = "SELECT  IdLiquidacionPergamino, Codigo, Fecha, Precio, IdEstadoFisico, IdCategoriaImperfeccion, IdEstadoDocumento, IdMoneda, IdMonedaPreecio, IdMunicipio, SincronizadoESC, NumeroReembolso, IdTipoIngreso, IdCosecha,    IdLocalidad, Cod_Proveedor, IdTipoCompra, PrecioAutoriza, TotalDeducciones, ChkRentDef, ChkRent2, ChkRent3, ChkMuncipal, IdTipoCambio, Serie  FROM        LiquidacionPergamino " & _
                                    "WHERE (IdCosecha = " & IdCosecha & ") AND (IdLocalidad = " & IdLocalidad & ") AND (IdTipoCompra = " & IdTipoCompra & ")  AND (LEN(Codigo) <= 6)AND (Serie = '" & Serie & "') AND (Codigo = '" & NumeroRecibo & "') ORDER BY Codigo DESC"
        End If
        DataAdapter = New SqlClient.SqlDataAdapter(Sqlstring, MiConexion)
        DataAdapter.Fill(DataSet, "Serie")
        If DataSet.Tables("Serie").Rows.Count <> 0 Then
            Consecutivo = DataSet.Tables("Serie").Rows(0)("Codigo")
            BuscaConsecutivoLiquidacionManual = Format(Consecutivo + 1, "00000#")
        Else
            BuscaConsecutivoLiquidacionManual = "000000"
        End If

    End Function

    Public Function BuscaConsecutivoReciboManual(ByVal Serie As String, ByVal IdTipoCafe As Double, ByVal IdCosecha As Double, ByVal IdLocalidad As Double, ByVal IdTipoCompra As String, ByVal NumeroRecibo As String) As String
        Dim MiConexion As New SqlClient.SqlConnection(Conexion)
        Dim Sqlstring As String
        Dim DataAdapter As SqlClient.SqlDataAdapter, DataSet As New DataSet
        Dim Consecutivo As Double

        If Serie = "" Then
            Sqlstring = "SELECT Codigo, IdTipoCafe, IdCosecha, IdLocalidad, IdDano, IdFinca, IdTipoCompra, IdEstadoDocumento, IdProductor, IdUnidadMedida, IdUsuario, IdLocalidadLiquidacion, SincronizadoECS, FechaSincronizacion, FechaIngresoSistemas, IdPignorado, EsProductorManual, CedulaManual, ProductorManual, FincaManual,  IdCalidad  FROM ReciboCafePergamino " & _
                         "WHERE (IdTipoCafe = " & IdTipoCafe & ") AND (IdCosecha = " & IdCosecha & ") AND (IdLocalidad = " & IdLocalidad & ") AND (IdTipoCompra = " & IdTipoCompra & ") AND (LEN(Codigo) <= 6) AND (Serie = '?')  AND (Codigo = '" & NumeroRecibo & "') ORDER BY Codigo DESC"
        Else
            Sqlstring = "SELECT Codigo, IdTipoCafe, IdCosecha, IdLocalidad, IdDano, IdFinca, IdTipoCompra, IdEstadoDocumento, IdProductor, IdUnidadMedida, IdUsuario, IdLocalidadLiquidacion, SincronizadoECS, FechaIngresoSistemas, IdPignorado, EsProductorManual, CedulaManual, ProductorManual, FincaManual,  IdCalidad  FROM ReciboCafePergamino " & _
                                    "WHERE (IdTipoCafe = " & IdTipoCafe & ") AND (IdCosecha = " & IdCosecha & ") AND (IdLocalidad = " & IdLocalidad & ") AND (IdTipoCompra = " & IdTipoCompra & ")  AND (LEN(Codigo) <= 6)AND (Serie = '" & Serie & "') AND (Codigo = '" & NumeroRecibo & "') ORDER BY Codigo DESC"
        End If
        DataAdapter = New SqlClient.SqlDataAdapter(Sqlstring, MiConexion)
        DataAdapter.Fill(DataSet, "Serie")
        If DataSet.Tables("Serie").Rows.Count <> 0 Then
            Consecutivo = DataSet.Tables("Serie").Rows(0)("Codigo")
            BuscaConsecutivoReciboManual = Format(Consecutivo + 1, "00000#")
        Else
            BuscaConsecutivoReciboManual = "000000"
        End If


    End Function

    Public Function DescripcionTipoIngreso(ByVal Codigo As String) As String
        Dim MiConexion As New SqlClient.SqlConnection(Conexion)
        Dim SqlString As String, DataAdapter As SqlClient.SqlDataAdapter, DataSet As New DataSet, IdTipoDocumento As Double = 0, Numero As Double

        DescripcionTipoIngreso = ""

        SqlString = "SELECT IdTipoIngreso, Descripcion, Code, IdECS FROM TipoIngreso WHERE (Code = '" & Codigo & "')"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "Consulta")
        If DataSet.Tables("Consulta").Rows.Count <> 0 Then
            DescripcionTipoIngreso = DataSet.Tables("Consulta").Rows(0)("Descripcion")
        End If

    End Function

    Public Sub NumeroTecla(ByVal Numeros As Boolean)
        If Numeros = True Then
            FrmTecladoLetras.CmdQ.Text = "1"
            FrmTecladoLetras.CmdW.Text = "2"
            FrmTecladoLetras.CmdE.Text = "3"
            FrmTecladoLetras.CmdR.Text = "4"
            FrmTecladoLetras.CmdT.Text = "5"
            FrmTecladoLetras.CmdY.Text = "6"
            FrmTecladoLetras.CmdU.Text = "7"
            FrmTecladoLetras.CmdI.Text = "8"
            FrmTecladoLetras.CmdO.Text = "9"
            FrmTecladoLetras.CmdP.Text = "0"
            FrmTecladoLetras.CmdA.Text = "!"
            FrmTecladoLetras.CmdS.Text = "@"
            FrmTecladoLetras.CmdD.Text = "#"
            FrmTecladoLetras.CmdF.Text = "$"
            FrmTecladoLetras.CmdG.Text = "/"
            FrmTecladoLetras.CmdH.Text = "+"
            FrmTecladoLetras.CmdJ.Text = "&"
            FrmTecladoLetras.CmdK.Text = "*"
            FrmTecladoLetras.CmdL.Text = "("
            FrmTecladoLetras.Cmd—.Text = ")"
            FrmTecladoLetras.CmdZ.Text = "-"
            FrmTecladoLetras.CmdX.Text = "%"
            FrmTecladoLetras.CmdC.Text = "="
            FrmTecladoLetras.CmdV.Text = "?"
            FrmTecladoLetras.CmdB.Text = "ø"
            FrmTecladoLetras.CmdN.Text = ":"
            FrmTecladoLetras.CmdM.Text = ";"
            FrmTecladoLetras.CmdEspacio.Text = "Espacio"
        ElseIf FrmTecladoLetras.CmdMinusculas.Visible = True Then
            FrmTecladoLetras.CmdQ.Text = "q"
            FrmTecladoLetras.CmdW.Text = "w"
            FrmTecladoLetras.CmdE.Text = "e"
            FrmTecladoLetras.CmdR.Text = "r"
            FrmTecladoLetras.CmdT.Text = "t"
            FrmTecladoLetras.CmdY.Text = "y"
            FrmTecladoLetras.CmdU.Text = "u"
            FrmTecladoLetras.CmdI.Text = "i"
            FrmTecladoLetras.CmdO.Text = "o"
            FrmTecladoLetras.CmdP.Text = "p"
            FrmTecladoLetras.CmdA.Text = "a"
            FrmTecladoLetras.CmdS.Text = "s"
            FrmTecladoLetras.CmdD.Text = "d"
            FrmTecladoLetras.CmdF.Text = "f"
            FrmTecladoLetras.CmdG.Text = "g"
            FrmTecladoLetras.CmdH.Text = "h"
            FrmTecladoLetras.CmdJ.Text = "j"
            FrmTecladoLetras.CmdK.Text = "k"
            FrmTecladoLetras.CmdL.Text = "l"
            FrmTecladoLetras.Cmd—.Text = "Ò"
            FrmTecladoLetras.CmdZ.Text = "z"
            FrmTecladoLetras.CmdX.Text = "x"
            FrmTecladoLetras.CmdC.Text = "c"
            FrmTecladoLetras.CmdV.Text = "v"
            FrmTecladoLetras.CmdB.Text = "b"
            FrmTecladoLetras.CmdN.Text = "n"
            FrmTecladoLetras.CmdM.Text = "m"
            FrmTecladoLetras.CmdEspacio.Text = "Espacio"
        ElseIf FrmTecladoLetras.CmdMayusculas.Visible = True Then
            FrmTecladoLetras.CmdQ.Text = "Q"
            FrmTecladoLetras.CmdW.Text = "W"
            FrmTecladoLetras.CmdE.Text = "E"
            FrmTecladoLetras.CmdR.Text = "R"
            FrmTecladoLetras.CmdT.Text = "T"
            FrmTecladoLetras.CmdY.Text = "Y"
            FrmTecladoLetras.CmdU.Text = "U"
            FrmTecladoLetras.CmdI.Text = "I"
            FrmTecladoLetras.CmdO.Text = "O"
            FrmTecladoLetras.CmdP.Text = "P"
            FrmTecladoLetras.CmdA.Text = "A"
            FrmTecladoLetras.CmdS.Text = "S"
            FrmTecladoLetras.CmdD.Text = "D"
            FrmTecladoLetras.CmdF.Text = "F"
            FrmTecladoLetras.CmdG.Text = "G"
            FrmTecladoLetras.CmdH.Text = "H"
            FrmTecladoLetras.CmdJ.Text = "J"
            FrmTecladoLetras.CmdK.Text = "K"
            FrmTecladoLetras.CmdL.Text = "L"
            FrmTecladoLetras.Cmd—.Text = "—"
            FrmTecladoLetras.CmdZ.Text = "Z"
            FrmTecladoLetras.CmdX.Text = "X"
            FrmTecladoLetras.CmdC.Text = "C"
            FrmTecladoLetras.CmdV.Text = "V"
            FrmTecladoLetras.CmdB.Text = "B"
            FrmTecladoLetras.CmdN.Text = "N"
            FrmTecladoLetras.CmdM.Text = "M"
            FrmTecladoLetras.CmdEspacio.Text = "ESPACIO"

        End If

    End Sub

    Public Sub LetraTecla(ByVal Minusculas As Boolean)
        If Minusculas = True Then
            FrmTecladoLetras.CmdQ.Text = "q"
            FrmTecladoLetras.CmdW.Text = "w"
            FrmTecladoLetras.CmdE.Text = "e"
            FrmTecladoLetras.CmdR.Text = "r"
            FrmTecladoLetras.CmdT.Text = "t"
            FrmTecladoLetras.CmdY.Text = "y"
            FrmTecladoLetras.CmdU.Text = "u"
            FrmTecladoLetras.CmdI.Text = "i"
            FrmTecladoLetras.CmdO.Text = "o"
            FrmTecladoLetras.CmdP.Text = "p"
            FrmTecladoLetras.CmdA.Text = "a"
            FrmTecladoLetras.CmdS.Text = "s"
            FrmTecladoLetras.CmdD.Text = "d"
            FrmTecladoLetras.CmdF.Text = "f"
            FrmTecladoLetras.CmdG.Text = "g"
            FrmTecladoLetras.CmdH.Text = "h"
            FrmTecladoLetras.CmdJ.Text = "j"
            FrmTecladoLetras.CmdK.Text = "k"
            FrmTecladoLetras.CmdL.Text = "l"
            FrmTecladoLetras.Cmd—.Text = "Ò"
            FrmTecladoLetras.CmdZ.Text = "z"
            FrmTecladoLetras.CmdX.Text = "x"
            FrmTecladoLetras.CmdC.Text = "c"
            FrmTecladoLetras.CmdV.Text = "v"
            FrmTecladoLetras.CmdB.Text = "b"
            FrmTecladoLetras.CmdN.Text = "n"
            FrmTecladoLetras.CmdM.Text = "m"
            FrmTecladoLetras.CmdEspacio.Text = "Espacio"
        Else
            FrmTecladoLetras.CmdQ.Text = "Q"
            FrmTecladoLetras.CmdW.Text = "W"
            FrmTecladoLetras.CmdE.Text = "E"
            FrmTecladoLetras.CmdR.Text = "R"
            FrmTecladoLetras.CmdT.Text = "T"
            FrmTecladoLetras.CmdY.Text = "Y"
            FrmTecladoLetras.CmdU.Text = "U"
            FrmTecladoLetras.CmdI.Text = "I"
            FrmTecladoLetras.CmdO.Text = "O"
            FrmTecladoLetras.CmdP.Text = "P"
            FrmTecladoLetras.CmdA.Text = "A"
            FrmTecladoLetras.CmdS.Text = "S"
            FrmTecladoLetras.CmdD.Text = "D"
            FrmTecladoLetras.CmdF.Text = "F"
            FrmTecladoLetras.CmdG.Text = "G"
            FrmTecladoLetras.CmdH.Text = "H"
            FrmTecladoLetras.CmdJ.Text = "J"
            FrmTecladoLetras.CmdK.Text = "K"
            FrmTecladoLetras.CmdL.Text = "L"
            FrmTecladoLetras.Cmd—.Text = "—"
            FrmTecladoLetras.CmdZ.Text = "Z"
            FrmTecladoLetras.CmdX.Text = "X"
            FrmTecladoLetras.CmdC.Text = "C"
            FrmTecladoLetras.CmdV.Text = "V"
            FrmTecladoLetras.CmdB.Text = "B"
            FrmTecladoLetras.CmdN.Text = "N"
            FrmTecladoLetras.CmdM.Text = "M"
            FrmTecladoLetras.CmdEspacio.Text = "ESPACIO"

        End If

    End Sub

    Public Function SoloNumeros(ByVal strCadena As String) As Object
        Dim SoloNumero As String = ""
        Dim index As Integer
        For index = 1 To Len(strCadena)
            If (Mid$(strCadena, index, 1) Like "#") _
                Or Mid$(strCadena, index, 1) = "-" Then
                SoloNumero = SoloNumero & Mid$(strCadena, index, 1)
            End If
        Next
        Return SoloNumero
    End Function

    Public Sub GrabaRecibo(ByVal NumeroRecibo As String, ByVal FechaRecibo As Date)
        Dim SqlString As String
        Dim DataSet As New DataSet, DataAdapter As SqlClient.SqlDataAdapter, StrSqlUpdate As String
        Dim MiConexion As New SqlClient.SqlConnection(Conexion), ComandoUpdate As New SqlClient.SqlCommand, iResultado As Integer
        Dim Serie As String, Sql As String, IdEstadoDocumento As Double

        'If FrmRecepcion.TxtSerie.Text = "" Then
        '    Serie = "?"
        'Else
        '    Serie = FrmRecepcion.TxtSerie.Text
        'End If




        'Sql = "SELECT IdEstadoDocumento, Codigo, Descripcion  FROM EstadoDocumento WHERE (Descripcion = '" & FrmRecepcion.CboEstadoDocumeto.Text & "')"
        'DataAdapter = New SqlClient.SqlDataAdapter(Sql, MiConexion)
        'DataAdapter.Fill(DataSet, "EstadoDocumento")
        'If DataSet.Tables("EstadoDocumento").Rows.Count <> 0 Then
        '    IdEstadoDocumento = DataSet.Tables("EstadoDocumento").Rows(0)("IdEstadoDocumento")
        'Else
        '    IdEstadoDocumento = 293
        'End If

        'If FrmRecepcion.TxtProveedor.Text = "00001" Then
        '    '//////////////////////////////////////////////////////////////////////////////////////////////////////
        '    '///////////////////////////////////////SI EL PRODUCTOR ES MANUAL /////////////////////////////////////
        '    '//////////////////////////////////////////////////////////////////////////////////////////////////////
        '    '/////////////////////////////////////////////////////////////////////////////
        '    '///////////////BUSCO EL ID DEL TIPO DE CAFE ///////////////////////////////////
        '    '////////////////////////////////////////////////////////////////////////////////////////////  (Codigo = '" & NumeroRecibo & "') AND (IdTipoCafe = " & FrmRecepcion.IdTipoCafe & ") AND (IdLocalidad = " & FrmRecepcion.IdLugarAcopio & ") AND (IdTipoCompra = " & FrmRecepcion.IdTipoCompra & ")
        '    SqlString = "SELECT  ReciboCafePergamino.*  FROM ReciboCafePergamino WHERE  (ReciboCafePergamino.IdReciboPergamino = " & FrmRecepcion.IdReciboCafe & ") AND (IdCosecha = " & FrmRecepcion.IdCosecha & ") "
        '    DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        '    DataAdapter.Fill(DataSet, "Consulta")
        '    If DataSet.Tables("Consulta").Rows.Count <> 0 Then
        '        '///////////SI EXISTE EL USUARIO LO ACTUALIZO////////////////
        '        MiConexion.Open()
        '        StrSqlUpdate = "UPDATE [ReciboCafePergamino] SET [Codigo] = '" & NumeroRecibo & "',[Fecha] = CONVERT(DATETIME, '" & Format(FechaRecibo, "yyyy-MM-dd HH:mm") & "', 102),[Observacion] =  '" & FrmRecepcion.Observaciones & "' ,[IdTipoCafe] = " & FrmRecepcion.IdTipoCafe & " ,[IdCosecha] = " & FrmRecepcion.IdCosecha & " ,[IdLocalidad] = " & FrmRecepcion.IdLugarAcopio & " ,[IdDano] = " & FrmRecepcion.IdDaÒo & " ,[IdTipoCompra] = " & FrmRecepcion.IdTipoCompra & " ,[IdLocalidadLiquidacion] = " & FrmRecepcion.CboLiquidarLocalidad.Columns(0).Text & " ,[FechaIngresoSistemas] = CONVERT(DATETIME, '" & Format(FechaRecibo, "yyyy-MM-dd HH:mm") & "', 102), [IdCalidad] = " & FrmRecepcion.IdCalidad & ", [IdTipoIngreso] = " & FrmRecepcion.IdTipoIngreso & " ,[IdRangoImperfeccion]= " & FrmRecepcion.IdRangoImperfeccion & " ,[CedulaManual]= '" & FrmRecepcion.TxtNumeroCedula.Text & "',[EsProductorManual]= 1, [ProductorManual]= '" & FrmRecepcion.txtnombre.Text & "',[FincaManual]= '" & FrmRecepcion.TxtFinca.Text & "',[Serie]= '" & Serie & "',[IdUsuario]= " & IdUsuario & " ,[IdUnidadMedida]= 1 ,[IdPignorado]= " & FrmRecepcion.IdPignorado & ", [IdEstadoDocumento]= " & FrmRecepcion.IdEstadoDocumento & ",  [IdLocalidadRegistro]= " & FrmRecepcion.IdLugarAcopioDefecto & "  WHERE (ReciboCafePergamino.IdReciboPergamino = " & FrmRecepcion.IdReciboCafe & ") AND (IdCosecha = " & FrmRecepcion.IdCosecha & ") "
        '        ComandoUpdate = New SqlClient.SqlCommand(StrSqlUpdate, MiConexion)
        '        iResultado = ComandoUpdate.ExecuteNonQuery
        '        MiConexion.Close()

        '    Else

        '        '[FechaIngresoSistemas]
        '        StrSqlUpdate = "INSERT INTO [ReciboCafePergamino] ([Codigo],[Fecha],[Observacion],[IdTipoCafe],[IdCosecha],[IdLocalidad],[IdDano],[IdTipoCompra],[IdEstadoDocumento],[IdLocalidadLiquidacion],[IdCalidad],[IdTipoIngreso],[IdRangoImperfeccion],[CedulaManual],[ProductorManual],[FincaManual],[Serie],[IdUsuario] ,[IdUnidadMedida],[IdPignorado],[IdLocalidadRegistro],[EsProductorManual],[FechaIngresoSistemas])  " & _
        '                       "VALUES ('" & NumeroRecibo & "' ,CONVERT(DATETIME, '" & Format(FechaRecibo, "yyyy-MM-dd HH:mm") & "', 102) , '" & FrmRecepcion.Observaciones & "' ," & FrmRecepcion.IdTipoCafe & " ," & FrmRecepcion.IdCosecha & "," & FrmRecepcion.IdLugarAcopio & " ," & FrmRecepcion.IdDaÒo & " , " & FrmRecepcion.IdTipoCompra & " ," & FrmRecepcion.IdEstadoDocumento & "," & FrmRecepcion.CboLiquidarLocalidad.Columns(0).Text & " , " & FrmRecepcion.IdCalidad & "," & FrmRecepcion.IdTipoIngreso & "," & FrmRecepcion.IdRangoImperfeccion & ",'" & FrmRecepcion.TxtNumeroCedula.Text & "', '" & FrmRecepcion.txtnombre.Text & "', '" & FrmRecepcion.TxtFinca.Text & "', '" & Serie & "', " & IdUsuario & ",1, " & FrmRecepcion.IdPignorado & ", " & FrmRecepcion.IdLugarAcopioDefecto & ",1, CONVERT(DATETIME, '" & Format(FechaRecibo, "yyyy-MM-dd HH:mm") & "', 102))"
        '        MiConexion.Open()
        '        ComandoUpdate = New SqlClient.SqlCommand(StrSqlUpdate, MiConexion)
        '        iResultado = ComandoUpdate.ExecuteNonQuery
        '        MiConexion.Close()
        '    End If




        'Else
        '    '/////////////////////////////////////////////////////////////////////////////
        '    '///////////////BUSCO EL ID DEL TIPO DE CAFE ///////////////////////////////////
        '    '////////////////////////////////////////////////////////////////////////////////////////////
        '    SqlString = "SELECT  ReciboCafePergamino.*  FROM ReciboCafePergamino WHERE (ReciboCafePergamino.IdReciboPergamino = " & FrmRecepcion.IdReciboCafe & ") AND (IdCosecha = " & FrmRecepcion.IdCosecha & ")"
        '    DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        '    DataAdapter.Fill(DataSet, "Consulta")
        '    If DataSet.Tables("Consulta").Rows.Count <> 0 Then
        '        '///////////SI EXISTE EL USUARIO LO ACTUALIZO////////////////
        '        MiConexion.Open()
        '        StrSqlUpdate = "UPDATE [ReciboCafePergamino] SET [Codigo] = '" & NumeroRecibo & "',[Fecha] = CONVERT(DATETIME, '" & Format(FechaRecibo, "yyyy-MM-dd HH:mm") & "', 102),[Observacion] =  '" & FrmRecepcion.Observaciones & "' ,[IdTipoCafe] = " & FrmRecepcion.IdTipoCafe & " ,[IdCosecha] = " & FrmRecepcion.IdCosecha & " ,[IdLocalidad] = " & FrmRecepcion.IdLugarAcopio & " ,[IdDano] = " & FrmRecepcion.IdDaÒo & " ,[IdFinca] = " & FrmRecepcion.IdFinca & " ,[IdTipoCompra] = " & FrmRecepcion.IdTipoCompra & " ,[IdProductor] = " & FrmRecepcion.IdProductor & " ,[IdLocalidadLiquidacion] = " & FrmRecepcion.CboLiquidarLocalidad.Columns(0).Text & " ,[FechaIngresoSistemas] = CONVERT(DATETIME, '" & Format(FechaRecibo, "yyyy-MM-dd HH:mm") & "', 102), [IdCalidad] = " & FrmRecepcion.IdCalidad & ", [IdTipoIngreso] = " & FrmRecepcion.IdTipoIngreso & " ,[IdRangoImperfeccion]= " & FrmRecepcion.IdRangoImperfeccion & ", [Serie]= '" & Serie & "', [IdUsuario]= " & IdUsuario & " ,[IdUnidadMedida]= 1, [IdPignorado]= " & FrmRecepcion.IdPignorado & ", [IdEstadoDocumento]= " & FrmRecepcion.IdEstadoDocumento & ", [IdLocalidadRegistro]= " & FrmRecepcion.IdLugarAcopioDefecto & ", [EsProductorManual]= 0,  [CedulaManual]= '', [ProductorManual]= '', [FincaManual]= ''  WHERE (ReciboCafePergamino.IdReciboPergamino = " & FrmRecepcion.IdReciboCafe & ") AND (IdCosecha = " & FrmRecepcion.IdCosecha & ") "
        '        ComandoUpdate = New SqlClient.SqlCommand(StrSqlUpdate, MiConexion)
        '        iResultado = ComandoUpdate.ExecuteNonQuery
        '        MiConexion.Close()

        '    Else
        '        StrSqlUpdate = "INSERT INTO [ReciboCafePergamino] ([Codigo],[Fecha],[Observacion],[IdTipoCafe],[IdCosecha],[IdLocalidad],[IdDano],[IdFinca],[IdTipoCompra],[IdEstadoDocumento],[IdProductor],[IdLocalidadLiquidacion],[IdCalidad],[IdTipoIngreso],[IdRangoImperfeccion],[Serie],[IdUsuario] ,[IdUnidadMedida],[IdPignorado], [IdLocalidadRegistro],[EsProductorManual],[FechaIngresoSistemas])  " & _
        '                       "VALUES ('" & NumeroRecibo & "' ,CONVERT(DATETIME, '" & Format(FechaRecibo, "yyyy-MM-dd HH:mm") & "', 102) , '" & FrmRecepcion.Observaciones & "' ," & FrmRecepcion.IdTipoCafe & " ," & FrmRecepcion.IdCosecha & "," & FrmRecepcion.IdLugarAcopio & " ," & FrmRecepcion.IdDaÒo & " , " & FrmRecepcion.IdFinca & " , " & FrmRecepcion.IdTipoCompra & " ," & FrmRecepcion.IdEstadoDocumento & "," & FrmRecepcion.IdProductor & " ," & FrmRecepcion.CboLiquidarLocalidad.Columns(0).Text & " , " & FrmRecepcion.IdCalidad & "," & FrmRecepcion.IdTipoIngreso & "," & FrmRecepcion.IdRangoImperfeccion & ",'" & Serie & "', " & IdUsuario & ",1, " & FrmRecepcion.IdPignorado & "," & FrmRecepcion.IdLugarAcopioDefecto & ",0,CONVERT(DATETIME, '" & Format(FechaRecibo, "yyyy-MM-dd HH:mm") & "', 102))"
        '        MiConexion.Open()
        '        ComandoUpdate = New SqlClient.SqlCommand(StrSqlUpdate, MiConexion)
        '        iResultado = ComandoUpdate.ExecuteNonQuery
        '        MiConexion.Close()
        '    End If
        'End If
    End Sub

    Public Sub GrabaDetalleRecibo(ByVal IdReciboCafe As Double, ByVal CantidadSacos As Double, ByVal Humedad As Double, ByVal Tara As Double, ByVal Imperfeccion As Double, ByVal IdReciboPergamino As Double, ByVal IdTipoSaco As Double, ByVal IdEstadoFisico As Double, ByVal PesoBruto As Double)
        Dim SqlString As String
        Dim DataSet As New DataSet, DataAdapter As SqlClient.SqlDataAdapter, StrSqlUpdate As String
        Dim MiConexion As New SqlClient.SqlConnection(Conexion), ComandoUpdate As New SqlClient.SqlCommand, iResultado As Integer


        '/////////////////////////////////////////////////////////////////////////////
        '///////////////BUSCO EL ID DEL TIPO DE CAFE ///////////////////////////////////
        '////////////////////////////////////////////////////////////////////////////////////////////
        SqlString = "SELECT  DetalleReciboCafePergamino.* FROM DetalleReciboCafePergamino WHERE(IdReciboPergamino = " & IdReciboCafe & ")"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "Consulta")
        If DataSet.Tables("Consulta").Rows.Count <> 0 Then
            '///////////SI EXISTE EL USUARIO LO ACTUALIZO////////////////
            MiConexion.Open()
            StrSqlUpdate = "UPDATE DetalleReciboCafePergamino  SET  [CantidadSacos] = " & CantidadSacos & " ,[Humedad] = " & Humedad & " ,[Tara] = " & Tara & " ,[Imperfeccion] = " & Imperfeccion & " ,[IdReciboPergamino] = " & IdReciboPergamino & ",[IdTipoSaco] = " & IdTipoSaco & ",[IdEdoFisico] = " & IdEstadoFisico & ",[PesoBruto] = " & PesoBruto & "   WHERE(IdReciboPergamino = " & IdReciboCafe & ")"
            ComandoUpdate = New SqlClient.SqlCommand(StrSqlUpdate, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            MiConexion.Close()
        Else
            StrSqlUpdate = "INSERT INTO [DetalleReciboCafePergamino] ([CantidadSacos],[Humedad],[Tara],[Imperfeccion],[IdReciboPergamino],[IdTipoSaco],[IdEdoFisico],[PesoBruto]) " & _
                           "VALUES (" & CantidadSacos & "," & Humedad & " ," & Tara & " ," & Imperfeccion & " ," & IdReciboPergamino & " ," & IdTipoSaco & "," & IdEstadoFisico & "," & PesoBruto & ")"
            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(StrSqlUpdate, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            MiConexion.Close()

        End If






    End Sub

    Public Function ExisteConductor(ByVal CodProveedor As String) As Boolean
        Dim SqlString As String
        Dim MiConexion As New SqlClient.SqlConnection(Conexion)
        Dim DataSet As New DataSet, DataAdapterProductos As New SqlClient.SqlDataAdapter

        'SqlString = "SELECT  *  FROM Conductor WHERE (Codigo = '" & CodProveedor & "')"
        SqlString = "SELECT DISTINCT EmpresaTransporte.Codigo, EmpresaTransporte.NombreEmpresa, Vehiculo.Placa FROM  EmpresaTransporte INNER JOIN VehiculoEmpresaTransporte ON EmpresaTransporte.IdEmpresaTransporte = VehiculoEmpresaTransporte.IdEmpresaTransporte INNER JOIN Vehiculo ON VehiculoEmpresaTransporte.IdVehiculo = Vehiculo.IdVehiculo  " & _
                     "WHERE   (EmpresaTransporte.Codigo = '" & CodProveedor & "')"
        DataAdapterProductos = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapterProductos.Fill(DataSet, "Proveedor")
        If Not DataSet.Tables("Proveedor").Rows.Count = 0 Then
            ExisteConductor = True
        Else
            ExisteConductor = False
        End If

    End Function

    Public Sub ActualizaComboProducto()
        Dim MiConexion As New SqlClient.SqlConnection(Conexion)
        Dim DataSet As New DataSet, DataAdapterProductos As New SqlClient.SqlDataAdapter, SqlProductos As String


        SqlProductos = "SELECT Cod_Productos, Descripcion_Producto FROM Productos"
        DataAdapterProductos = New SqlClient.SqlDataAdapter(SqlProductos, MiConexion)
        DataAdapterProductos.Fill(DataSet, "ListaProductos")
        If Not DataSet.Tables("ListaProductos").Rows.Count = 0 Then
            FrmProductos.CboCodigoProducto.DataSource = DataSet.Tables("ListaProductos")
        End If
    End Sub

    Public Function BuscaConsecutivoCarga(ByVal NombreCampo As String) As Double

        Dim SqlConsecutivo As String, SQlUpdate As String, CodConsecutivo As Double
        Dim MiConexion As New SqlClient.SqlConnection(Conexion)
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim ComandoUpdate As New SqlClient.SqlCommand, iResultado As Integer
        '/////////////////////////////////////////////////////////////////////////////////////////
        '///////////////////////BUSCO EL CONSECUTIVO COMPONENTES/////////////////////////////////
        '////////////////////////////////////////////////////////////////////////////////////////

        SqlConsecutivo = "SELECT  * FROM  Consecutivos"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlConsecutivo, MiConexion)
        DataAdapter.Fill(DataSet, "Consecutivo")
        If Not DataSet.Tables("Consecutivo").Rows.Count = 0 Then
            If Not IsDBNull(DataSet.Tables("Consecutivo").Rows(0)(NombreCampo)) Then
                CodConsecutivo = DataSet.Tables("Consecutivo").Rows(0)(NombreCampo) + 1
            Else
                CodConsecutivo = 1
            End If
            BuscaConsecutivoCarga = CodConsecutivo

            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////
            '////////////////////////////ACTUALIZO EL CONSECUTIVO///////////////////////////////////////////////////
            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            'MiConexion.Close()
            'SQlUpdate = "UPDATE [Consecutivos]  SET [" & NombreCampo & "] = " & CodConsecutivo & ""
            'MiConexion.Open()
            'ComandoUpdate = New SqlClient.SqlCommand(SQlUpdate, MiConexion)
            'iResultado = ComandoUpdate.ExecuteNonQuery
            'MiConexion.Close()

        Else
            BuscaConsecutivoCarga = 0
        End If

    End Function

    Public Sub ActualizaEstadoRecepcion(ByVal NumeroRecepcion As String, ByVal FechaRecepcion As Date, ByVal Activo As Boolean, ByVal NumeroBoleta As String)
        Dim SqlCompras As String, ComandoUpdate As New SqlClient.SqlCommand, iResultado As Integer
        Dim Sql As String
        Dim MiConexion As New SqlClient.SqlConnection(Conexion)
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter


        MiConexion.Close()

        Sql = "SELECT  Recepcion.* FROM Recepcion WHERE (NumeroRecepcion = '" & NumeroRecepcion & "') AND (TipoRecepcion = 'Recepcion')"
        DataAdapter = New SqlClient.SqlDataAdapter(Sql, MiConexion)
        DataAdapter.Fill(DataSet, "DetalleRecepcion")
        If Not DataSet.Tables("DetalleRecepcion").Rows.Count = 0 Then
            '//////////////////////////////////////////////////////////////////////////////////////////////
            '////////////////////////////AGREGO EL ENCABEZADO DE LA COMPRA///////////////////////////////////
            '/////////////////////////////////////////////////////////////////////////////////////////////////

            SqlCompras = "UPDATE [Recepcion] SET [Activo] = '" & Activo & "', [NumeroBoleta] = '" & NumeroBoleta & "' WHERE (NumeroRecepcion = '" & NumeroRecepcion & "') AND (TipoRecepcion = 'Recepcion')"
            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(SqlCompras, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            MiConexion.Close()

        End If

    End Sub

    Public Sub GrabaRegistros(ByVal ConsecutivoRegistro As String, ByVal TipoRegistro As String, ByVal IdConductor As Double, ByVal IdLugarAcopio As Double, ByVal FechaCarga As DateTime, ByVal Placa As String)
        Dim SqlCompras As String, ComandoUpdate As New SqlClient.SqlCommand, iResultado As Integer
        Dim Sql As String
        Dim MiConexion As New SqlClient.SqlConnection(Conexion)
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter

        'Fecha = Format(FrmCarga.DTPFecha.Value, "yyyy-MM-dd")

        '-----------------------BUSCO EL ULTIMO CODIGO DE LLEGADA DE LA PLACA ---------------
        Dim IdTransporte As String = ""
        If TipoRegistro = "Llegada" Then
            IdTransporte = ConsecutivoRegistro
        Else
            Dim Adaptar As New SqlClient.SqlDataAdapter("Select top (1) IdRegistro From Registros Where Placa = '" & Placa & "' and TipoRegistro = 'Llegada' order by IdRegistro DESC ", MiConexion)
            Dim TablaQuery As New DataTable
            Adaptar.Fill(TablaQuery)
            If TablaQuery.Rows.Count > 0 Then
                IdTransporte = TablaQuery.Rows(0)("IdRegistro")
            End If

        End If

        '---------------------------ACTULIZO EL ESTADO DEL VEHICULO -----------------------------------------
        Dim Command As SqlClient.SqlCommand
        If TipoRegistro = "Salida" Then
            Command = New SqlClient.SqlCommand("Update Vehiculo set Posicion ='Disponible' Where Placa ='" & Placa & "' ", MiConexion)
        Else
            Command = New SqlClient.SqlCommand("Update Vehiculo set Posicion ='" & TipoRegistro & "' Where Placa ='" & Placa & "' ", MiConexion)
        End If


        '/////////////////////////////


        MiConexion.Close()

        Sql = "SELECT  *  FROM Registros WHERE (IdRegistro = '" & ConsecutivoRegistro & "') AND (TipoRegistro = '" & TipoRegistro & "') AND (IdLugarAcopio = '" & IdLugarAcopio & "')"
        DataAdapter = New SqlClient.SqlDataAdapter(Sql, MiConexion)
        DataAdapter.Fill(DataSet, "Registros")
        If DataSet.Tables("Registros").Rows.Count = 0 Then
            '//////////////////////////////////////////////////////////////////////////////////////////////
            '////////////////////////////AGREGO EL ENCABEZADO DE LA COMPRA///////////////////////////////////
            '/////////////////////////////////////////////////////////////////////////////////////////////////

            'SqlCompras = "INSERT INTO [Registros] ([IdRegistro],[TipoRegistro],[IdConductor],[IdLugarAcopio],[Fecha],[Placa],[IdTransporte],[NumeroBoleta]) " & _
            '             "VALUES ('" & ConsecutivoRegistro & "','" & TipoRegistro & "'," & IdConductor & "," & IdLugarAcopio & ",'" & Format(FechaCarga, "dd/MM/yyyy HH:mm:ss") & "','" & Placa & "','" & IdTransporte & "','" & My.Forms.FrmRegistros.TxtBoleta.Text & "' )"

            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(SqlCompras, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            MiConexion.Close()

        Else
            '//////////////////////////////////////////////////////////////////////////////////////////////
            '////////////////////////////EDITO EL ENCABEZADO DE LA COMPRA///////////////////////////////////
            '/////////////////////////////////////////////////////////////////////////////////////////////////
            'SqlCompras = "UPDATE [Registros] SET [IdConductor] = " & IdConductor & ",[IdLugarAcopio] = " & IdLugarAcopio & ",[Fecha] = '" & Format(FechaCarga, "yyyy-MM-dd HH:mm:ss") & "' ,[Placa] = '" & Placa & "', [IdTransporte] = '" & IdTransporte & "', [NumeroBoleta] = '" & My.Forms.FrmRegistros.TxtBoleta.Text & "' " & _
            '             "WHERE (IdRegistro = '" & ConsecutivoRegistro & "') AND (TipoRegistro = '" & TipoRegistro & "')"
            'MiConexion.Open()
            'ComandoUpdate = New SqlClient.SqlCommand(SqlCompras, MiConexion)
            'iResultado = ComandoUpdate.ExecuteNonQuery
            'MiConexion.Close()
        End If

    End Sub

    Public Sub GrabaCarga(ByVal ConsecutivoCarga As String, ByVal IdConductor As Double, ByVal IdLugarAcopio As Double, ByVal FechaCarga As DateTime, ByVal Placa As String)
        Dim SqlCompras As String, ComandoUpdate As New SqlClient.SqlCommand, iResultado As Integer
        Dim Sql As String
        Dim MiConexion As New SqlClient.SqlConnection(Conexion)
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter

        'Fecha = Format(FrmCarga.DTPFecha.Value, "yyyy-MM-dd")
        '-----------------------BUSCO EL ULTIMO CODIGO DE LLEGADA DE LA PLACA ---------------
        Dim IdTransporte As String = ""
        Dim Adaptar As New SqlClient.SqlDataAdapter("Select top (1) IdRegistro From Registros Where Placa = '" & Placa & "' and TipoRegistro = 'Llegada' order by IdRegistro DESC ", MiConexion)
        Dim TablaQuery As New DataTable
        Adaptar.Fill(TablaQuery)
        If TablaQuery.Rows.Count > 0 Then
            IdTransporte = TablaQuery.Rows(0)("IdRegistro")
        End If

        '///////////////////////////////////7///////////////////
        '/////////////////////ACTUALIZO EL ESTADO DEL VEHICULO ///////////////
        Dim Command As New SqlClient.SqlCommand("Update Vehiculo set Posicion ='Carga' Where Placa ='" & Placa & "' ", MiConexion)
        MiConexion.Open()
        Command.ExecuteNonQuery()
        MiConexion.Close()

        MiConexion.Close()

        Sql = "SELECT  *  FROM IndiceCarga WHERE (CodCarga = '" & ConsecutivoCarga & "') AND (IdLugarAcopio = " & IdLugarAcopio & ")"
        DataAdapter = New SqlClient.SqlDataAdapter(Sql, MiConexion)
        DataAdapter.Fill(DataSet, "DetalleRecepcion")
        If DataSet.Tables("DetalleRecepcion").Rows.Count = 0 Then
            '//////////////////////////////////////////////////////////////////////////////////////////////
            '////////////////////////////AGREGO EL ENCABEZADO DE LA COMPRA///////////////////////////////////
            '/////////////////////////////////////////////////////////////////////////////////////////////////

            SqlCompras = "INSERT INTO [IndiceCarga] ([CodCarga],[IdConductor],[IdLugarAcopio],[Fecha],[Placa],[IdTransporte]) " & _
                         "VALUES ('" & ConsecutivoCarga & "'," & IdConductor & "," & IdLugarAcopio & ",'" & Format(FechaCarga, "dd/MM/yyyy HH:mm:ss") & "','" & Placa & "','" & IdTransporte & "')"

            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(SqlCompras, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            MiConexion.Close()
        Else
            '//////////////////////////////////////////////////////////////////////////////////////////////
            '////////////////////////////EDITO EL ENCABEZADO DE LA COMPRA///////////////////////////////////
            '/////////////////////////////////////////////////////////////////////////////////////////////////
            SqlCompras = "UPDATE [IndiceCarga] SET [IdConductor] = " & IdConductor & ",[IdLugarAcopio] = " & IdLugarAcopio & ",[Placa] = '" & Placa & "',[IdTransporte] = '" & IdTransporte & "'  " & _
                         "WHERE (CodCarga = '" & ConsecutivoCarga & "') AND (IdLugarAcopio = " & IdLugarAcopio & ")"
            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(SqlCompras, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            MiConexion.Close()
        End If

    End Sub

    Public Sub GrabaDetalleCarga(ByVal ConsecutivoCarga As String, ByVal NumeroRecepcion As String, ByVal FechaRecepcion As Date, ByVal IdLugarAcopio As Double)
        Dim Sqldetalle As String, ComandoUpdate As New SqlClient.SqlCommand, iResultado As Integer
        Dim Fecha As String, MiConexion As New SqlClient.SqlConnection(Conexion), SqlUpdate As String
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter

        Fecha = Format(CDate(FrmRecepcion.DTPFecha.Text), "yyyy-MM-dd")

        Sqldetalle = "SELECT  *  FROM DetalleCarga WHERE (CodCarga = '" & ConsecutivoCarga & "') AND (NumeroRecepcion = '" & NumeroRecepcion & "') AND (TipoRecepcion = 'Recepcion')"
        DataAdapter = New SqlClient.SqlDataAdapter(Sqldetalle, MiConexion)
        DataAdapter.Fill(DataSet, "DetalleRecepcion")
        If Not DataSet.Tables("DetalleRecepcion").Rows.Count = 0 Then
            '//////////////////////////////////////////////////////////////////////////////////////////////
            '////////////////////////////EDITO EL DETALLE DE COMPRAS///////////////////////////////////
            '/////////////////////////////////////////////////////////////////////////////////////////////////
        Else
            SqlUpdate = "INSERT INTO [DetalleCarga] ([CodCarga],[NumeroRecepcion],[IdLugarAcopio],[FechaRecepcion],[TipoRecepcion]) " & _
                        "VALUES ('" & ConsecutivoCarga & "' ,'" & NumeroRecepcion & "'," & IdLugarAcopio & ",'" & Format(FechaRecepcion, "dd/MM/yyyy HH:mm:ss") & "','Recepcion')"
            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(SqlUpdate, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            MiConexion.Close()
        End If
    End Sub

    Public Sub LimpiaRecepcion()
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim Sql As String
        Dim MiConexion As New SqlClient.SqlConnection(Conexion)

        FrmRecepcion.DTPFecha.Text = Format(Now, "dd/MM/yyyy")
        FrmRecepcion.Timer1.Enabled = True
        FrmRecepcion.Timer1.Start()
        FrmRecepcion.TxtNumeroEnsamble.Text = "- - - - - 0 - - - - -"
        FrmRecepcion.txtsubtotal.Text = ""
        FrmRecepcion.CboPlaca.SelectedValue = 0
        FrmRecepcion.CboConductor.SelectedValue = 0
        FrmRecepcion.CboProductor.SelectedValue = 0
        FrmRecepcion.CboCalidad.SelectedIndex = 0
        FrmRecepcion.CboVariedad.SelectedValue = 1
        FrmRecepcion.txtobservaciones.Text = ""
        FrmRecepcion.txtsubtotal.Text = "0.00"
        FrmRecepcion.TxtRConacafe.Text = ""
        FrmRecepcion.TxtRemision.Text = ""
        FrmRecepcion.CheckMohoso.Checked = False
        FrmRecepcion.CheckFermento.Checked = False
        FrmRecepcion.CboRecibimosde.Text = ""
        FrmRecepcion.CboFinca.Text = ""
        FrmRecepcion.Departamento = ""
        FrmRecepcion.Municipio = ""
        FrmRecepcion.Comarca = ""
        FrmRecepcion.CodigoNotaPeso = 0
        FrmRecepcion.IdProductor = "0"
        FrmRecepcion.ActualizarSerie = False
        FrmRecepcion.TotalPesoLb = 0.0
        FrmRecepcion.TotalPesoKG = 0.0
        FrmRecepcion.PesoBrutoLb = 0.0
        FrmRecepcion.TaraLb = 0.0
        FrmRecepcion.CantidaSacos = 0.0
        FrmRecepcion.TxtImperfec.Text = "0.00"

    End Sub

    Public Function TotalRecepcion(ByVal NumeroRecepcion As String, ByVal FechaRecepcion As Date, ByVal TipoRecepcion As String) As Double
        Dim Fecha As String, SqlCompras As String, Registros As Double
        Dim MiConexion As New SqlClient.SqlConnection(Conexion)
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter, i As Double, Total As Double

        Fecha = Format(FechaRecepcion, "yyyy-MM-dd")
        SqlCompras = "SELECT  id_Eventos As Linea, Cod_Productos, Descripcion_Producto, Calidad, Estado, Cantidad, PesoKg, Tara, PesoNetoLb, PesoNetoKg, QQ As Saco, Precio  FROM Detalle_Recepcion WHERE (NumeroRecepcion = '" & NumeroRecepcion & "') AND (Fecha = CONVERT(DATETIME, '" & Fecha & "', 102)) AND (TipoRecepcion = '" & TipoRecepcion & "') "
        DataAdapter = New SqlClient.SqlDataAdapter(SqlCompras, MiConexion)
        DataAdapter.Fill(DataSet, "Recepcion")
        Registros = DataSet.Tables("Recepcion").Rows.Count
        i = 0
        Total = 0
        Do While Registros > i
            Total = Total + DataSet.Tables("Recepcion").Rows(i)("PesoNetoKg")
            i = i + 1
        Loop
        TotalRecepcion = Format(Total, "##,##0.00")
    End Function

    Public Sub AnulaRecepcion(ByVal ConsecutivoRecepcion As String)
        Dim SqlCompras As String, ComandoUpdate As New SqlClient.SqlCommand, iResultado As Integer
        Dim Fecha As String, TipoCompra As String, SqlUpdate As String
        Dim MiConexion As New SqlClient.SqlConnection(Conexion)
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim Subtotal As Double

        TipoCompra = FrmRecepcion.CboTipoPesada.Text
        Fecha = Format(CDate(FrmRecepcion.DTPFecha.Text), "yyyy-MM-dd")

        If FrmRecepcion.txtsubtotal.Text <> "" Then
            Subtotal = FrmRecepcion.txtsubtotal.Text
        Else
            Subtotal = 0
        End If

        MiConexion.Close()

        SqlCompras = "SELECT Recepcion.*, Proveedor.Nombre_Proveedor, SubProveedor.Nombre_Proveedor AS SubProveedor, Bodegas.Nombre_Bodega FROM  Recepcion INNER JOIN Proveedor ON Recepcion.Cod_Proveedor = Proveedor.Cod_Proveedor INNER JOIN SubProveedor ON Recepcion.Cod_SubProveedor = SubProveedor.Cod_Proveedor INNER JOIN Bodegas ON Recepcion.Cod_Bodega = Bodegas.Cod_Bodega  " & _
                      "WHERE (Recepcion.Activo = 1) AND (Recepcion.NumeroRecepcion = '" & FrmRecepcion.TxtNumeroEnsamble.Text & "') AND (Recepcion.Fecha = CONVERT(DATETIME, '" & Fecha & "', 102)) AND (Recepcion.TipoRecepcion = '" & FrmRecepcion.CboTipoPesada.Text & "')"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlCompras, MiConexion)
        DataAdapter.Fill(DataSet, "Recepcion")
        If Not DataSet.Tables("Recepcion").Rows.Count = 0 Then

            '//////////////////////////////////////////////////////////////////////////////////////////////
            '////////////////////////////EDITO EL ENCABEZADO DE LA COMPRA///////////////////////////////////
            '/////////////////////////////////////////////////////////////////////////////////////////////////
            SqlCompras = "UPDATE [Recepcion] SET [Cancelar] = 'True',[Activo] = 'False' " & _
                         "WHERE (NumeroRecepcion = '" & ConsecutivoRecepcion & "') AND (Fecha = CONVERT(DATETIME, '" & Fecha & "', 102)) AND (TipoRecepcion = '" & FrmRecepcion.CboTipoPesada.Text & "')"
            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(SqlCompras, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            MiConexion.Close()
        End If

        '--------------------------------------------------------------------------------------------------------------------------------------
        '----------------------------------------EDITO EL DETALLE DE RECEPCION -----------------------------------------------------------------
        '---------------------------------------------------------------------------------------------------------------------------------------
        MiConexion.Close()

        SqlCompras = "SELECT Detalle_Recepcion.* FROM Detalle_Recepcion " & _
                     "WHERE (NumeroRecepcion = '" & ConsecutivoRecepcion & "') AND (Fecha = CONVERT(DATETIME, '" & Fecha & "', 102)) AND (TipoRecepcion = '" & FrmRecepcion.CboTipoPesada.Text & "') "
        DataAdapter = New SqlClient.SqlDataAdapter(SqlCompras, MiConexion)
        DataAdapter.Fill(DataSet, "DetalleRecepcion")
        If Not DataSet.Tables("DetalleRecepcion").Rows.Count = 0 Then

            '//////////////////////////////////////////////////////////////////////////////////////////////
            '////////////////////////////EDITO EL DETALLE DE COMPRAS///////////////////////////////////
            '/////////////////////////////////////////////////////////////////////////////////////////////////
            SqlUpdate = "UPDATE [Detalle_Recepcion] SET [Cantidad] = 0 " & _
                        "WHERE (NumeroRecepcion = '" & ConsecutivoRecepcion & "') AND (Fecha = CONVERT(DATETIME, '" & Fecha & "', 102)) AND (TipoRecepcion = '" & FrmRecepcion.CboTipoPesada.Text & "') "
            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(SqlUpdate, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            MiConexion.Close()
        End If

    End Sub

    Public Sub CalculaTaraRecepcion()
        Dim MiConexion As New SqlClient.SqlConnection(Conexion)
        Dim IdEsdoFisico As Double, IdCalidad As Double, IdTipoLugarAcopio As Double, Factor As Double, QQ As Double, Tara As Double, PesoNetoKg As Double, PesoNetoLb As Double
        Dim SqlString As String, DataAdapter As New SqlClient.SqlDataAdapter, DataSet As New DataSet, Cantidad As Double, PesoKg As Double
        Dim Registro As Double, i As Double, SubTotal As Double = 0, HumedadxDefecto As Double, HumedadReal As Double
        Dim Categoria As String, Estado As String



        'IdEsdoFisico = My.Forms.FrmRecepcion.IdEstadoFisico
        'IdCalidad = My.Forms.FrmRecepcion.IdCalidad
        'IdTipoLugarAcopio = My.Forms.FrmRecepcion.IdTipoLugarAcopio

        '////////////////////////////////////////////////////////////////////////////////////////////////////
        '//////////////////////CONSULTO LAS TARAS /////////////////////////////////////////////////////////
        '////////////////////////////////////////////////////////////////////////////////////////////////////
        SqlString = "SELECT FactorTara FROM FactorSaco WHERE  (IdEdoFisico = " & IdEsdoFisico & " )  AND (IdTipoLugarAcopio = " & IdTipoLugarAcopio & ") AND (IdUMedida = 1) AND (IdCalidad = " & IdCalidad & ")"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "Tara")
        If DataSet.Tables("Tara").Rows.Count <> 0 Then
            Factor = DataSet.Tables("Tara").Rows(0)("FactorTara")
        Else
            Factor = 0
        End If


        'Categoria = FrmRecepcion.CboCategoria.Text
        'Estado = FrmRecepcion.CboEstado.Text
        Registro = FrmRecepcion.TrueDBDetalleNP.RowCount
        i = 0
        FrmRecepcion.TrueDBDetalleNP.Row = i
        SubTotal = 0
        Do While Registro > i
            If FrmRecepcion.TrueDBDetalleNP.Columns(10).Text = "" Then
                Exit Do
            End If

            QQ = FrmRecepcion.TrueDBDetalleNP.Columns(10).Text
            Tara = Factor * QQ
            PesoKg = FrmRecepcion.TrueDBDetalleNP.Columns(6).Text
            PesoNetoKg = Format((PesoKg - Tara), "##,##0.0000")
            PesoNetoLb = Format((PesoNetoKg / 46) * 100, "##,##0.0000")

            FrmRecepcion.TrueDBDetalleNP.Columns(3).Text = Categoria
            FrmRecepcion.TrueDBDetalleNP.Columns(4).Text = Estado
            FrmRecepcion.TrueDBDetalleNP.Columns(7).Text = Format(Tara, "##,##0.00")
            FrmRecepcion.TrueDBDetalleNP.Columns(8).Text = Format(PesoNetoLb, "##,##0.0000")
            FrmRecepcion.TrueDBDetalleNP.Columns(9).Text = Format(PesoNetoKg, "##,##0.0000")

            SubTotal = PesoNetoKg + SubTotal
            i = i + 1
            FrmRecepcion.TrueDBDetalleNP.Row = i
        Loop


        'HumedadxDefecto = FrmRecepcion.HumedadxDefecto

        'If FrmRecepcion.TxtHumedad.Text <> "" Then
        '    HumedadReal = FrmRecepcion.TxtHumedad.Text
        'Else
        '    HumedadReal = 0
        'End If

        FrmRecepcion.txtsubtotal.Text = Format(SubTotal, "##,##0.00")
        'FrmRecepcion.TxtEqOreado.Text = Format(SubTotal * (1 - (HumedadxDefecto - 42) / 100), "##,##0.00")
        'FrmRecepcion.TxtOreadoReal.Text = Format(SubTotal * (1 - (HumedadReal - 42) / 100), "##,##0.00")

    End Sub

    Public Function PrecioVenta(ByVal IdLugarAcopio As Double, ByVal IdCalidad As Double, ByVal Categoria As String) As Double
        Dim MiConexion As New SqlClient.SqlConnection(Conexion)
        Dim SqlString As String
        Dim Adapter As New SqlClient.SqlDataAdapter, DataSet As New DataSet, Registros As Double, i As Double
        Dim FechaCorte As Date

        FechaCorte = Now
        '//////////////////////////////////CONSULTO LA CALIDAD A ////////////////////////////////////////////////////////////
        SqlString = "SELECT PrecioCafe.IdPrecioCafe, PrecioCafe.IdLocalidad, PrecioCafe.IdCalidad, PrecioCafe.IdRangoImperfeccion, PrecioCafe.Precio, PrecioCafe.FechaActualizacion,  RangoImperfeccion.Nombre FROM PrecioCafe INNER JOIN RangoImperfeccion ON PrecioCafe.IdRangoImperfeccion = RangoImperfeccion.IdRangoImperfeccion WHERE  (PrecioCafe.IdLocalidad = " & IdLugarAcopio & ") AND (PrecioCafe.IdCalidad = " & IdCalidad & ") AND (RangoImperfeccion.Nombre = '" & Categoria & "') AND (FechaActualizacion BETWEEN CONVERT(DATETIME, '" & Format(FechaCorte, "yyyy-MM-dd") & " 00:00:00', 102) AND CONVERT(DATETIME, '" & Format(FechaCorte, "yyyy-MM-dd HH:mm:ss") & "', 102)) ORDER BY RangoImperfeccion.Nombre, PrecioCafe.FechaActualizacion DESC"
        Adapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        Adapter.Fill(DataSet, "ConsultaA")
        PrecioVenta = 0
        If DataSet.Tables("ConsultaA").Rows.Count <> 0 Then
            PrecioVenta = DataSet.Tables("ConsultaA").Rows(0)("Precio")
        Else
            PrecioVenta = 0.0
            'NumCorte = DataSet.Tables("ConsultaA").Rows(0)("Corte")
        End If

    End Function

    Public Sub ExportToExcel(ByVal dtTemp As DataTable, ByVal filepath As String)
        Dim strFileName As String = filepath, Registros As Double
        If System.IO.File.Exists(strFileName) Then
            If (MessageBox.Show("QuerÈs exportar en el archivo existente?", "Export to Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes) Then
                System.IO.File.Delete(strFileName)
            Else
                Return
            End If

        End If
        Dim _excel As New Excel.Excel.Application
        Dim wBook As Excel.Excel.Workbook
        Dim wSheet As Excel.Excel.Worksheet

        wBook = _excel.Workbooks.Add()
        wSheet = wBook.ActiveSheet()

        Dim dt As System.Data.DataTable = dtTemp
        Dim dc As System.Data.DataColumn
        Dim dr As System.Data.DataRow
        Dim colIndex As Integer = 0
        Dim rowIndex As Integer = 0
        Dim rnd As New Random

        For Each dc In dt.Columns
            colIndex = colIndex + 1
            wSheet.Cells(1, colIndex) = dc.ColumnName

            With (wSheet)
                '.Range(.Cells(rowIndex + 1, colIndex), .Cells(rowIndex + 1, colIndex)).Interior.Color = RGB(rnd.Next(255), rnd.Next(255), rnd.Next(255))
                .Range(.Cells(rowIndex + 1, colIndex), .Cells(rowIndex + 1, colIndex)).Interior.Color = RGB(255, 118, 0)
            End With
        Next

        My.Application.DoEvents()
        Registros = dt.Rows.Count
        'FrmConsultaReporte.ProgressBar1.Minimum = 0
        'FrmConsultaReporte.ProgressBar1.Maximum = Registros
        'FrmConsultaReporte.ProgressBar1.Value = 0


        For Each dr In dt.Rows
            rowIndex = rowIndex + 1
            colIndex = 0

            My.Application.DoEvents()
            Registros = dt.Columns.Count
            'FrmConsultaReporte.ProgressBar2.Minimum = 0
            'FrmConsultaReporte.ProgressBar2.Maximum = Registros
            'FrmConsultaReporte.ProgressBar2.Value = 0

            For Each dc In dt.Columns
                colIndex = colIndex + 1
                wSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                With (wSheet)
                    '.Range(.Cells(1, 1), .Cells(1, 2)).Font.ColorIndex = 3
                    '.Range(.Cells(1, 1), .Cells(rowIndex + 1, colIndex)).Interior.Color = 3
                    .Range(.Cells(1, 1), .Cells(1, colIndex)).Font.Size = 12
                    .Range(.Cells(1, 1), .Cells(1, colIndex)).Font.Bold = True
                    .Cells.RowHeight = 35
                    Select Case colIndex
                        Case Is = 4 : .Range(.Cells(rowIndex + 1, colIndex), .Cells(rowIndex + 1, colIndex)).Interior.Color = RGB(204, 255, 204)
                        Case Is > 4 : .Range(.Cells(rowIndex + 1, colIndex), .Cells(rowIndex + 1, colIndex)).Interior.Color = RGB(184, 204, 228)
                    End Select

                End With

                'FrmConsultaReporte.ProgressBar2.Value = FrmConsultaReporte.ProgressBar2.Value + 1

            Next

            'FrmConsultaReporte.ProgressBar1.Value = FrmConsultaReporte.ProgressBar1.Value + 1
        Next
        wSheet.Columns.AutoFit()
        wBook.SaveAs(strFileName)

        ReleaseObject(wSheet)
        wBook.Close(False)
        ReleaseObject(wBook)
        _excel.Quit()
        ReleaseObject(_excel)

        GC.Collect()

        MessageBox.Show("Archivo exportado correctamente")
    End Sub

    Private Sub ReleaseObject(ByVal o As Object)
        Try
            While (System.Runtime.InteropServices.Marshal.ReleaseComObject(o) > 0)
            End While
        Catch
        Finally
            o = Nothing
        End Try
    End Sub

End Module
