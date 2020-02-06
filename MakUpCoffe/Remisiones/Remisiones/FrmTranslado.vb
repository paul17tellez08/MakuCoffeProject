Public Class FrmTranslado
    Public CodigoNotaPeso As String, PesoNeto As Double, CodigoTraza As String, LimpiarNota As Boolean
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

        SqlString = "SELECT IdCama, NombreCama  FROM  Cama WHERE (Activa = 1)"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "Cama")
        Me.CboCama.DataSource = DataSet.Tables("Cama")
        If Not DataSet.Tables("Cama").Rows.Count = 0 Then
            Me.CboCama.Text = DataSet.Tables("Cama").Rows(0)("NombreCama")
        End If

        Me.DTPFecha.Text = Format(Now, "dd/MM/yyyy")
        Timer1.Start()
        '///////////////////CARGO DESDE LA NOTA DE PESO///////////////////////
        If Quien = "Transladar-Recepcion-Patio" Then
            Me.TxtNumeroEnsamble.Enabled = False
            Me.BtnConsulta.Enabled = False
            Me.BtnConsulta.Visible = False
            Me.TxtNumeroEnsamble.Text = CodigoNotaPeso
        ElseIf Quien = "Cama" Then
            GBBodegas.Visible = False
            'Me.Label1.Visible = False
            'Me.CboBodegaOrigen.Visible = False
            'Me.CboBodegaDestino.Visible = False
            'Me.Label15.Visible = False
        ElseIf Quien = "Translado" Then
            GbCamaInfo.Visible = False
        End If
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsulta.Click
        Quien = "RecepcionBusquedaCama"
        My.Forms.FrmConsultas.Text = "Consulta Translado"
        My.Forms.FrmConsultas.ShowDialog()
        If My.Forms.FrmConsultas.Codigo <> "- - - - - 0 - - - - -" Then
            Me.TxtNumeroEnsamble.Text = FrmConsultas.Codigo
        End If
    End Sub

    Private Sub TxtNumeroEnsamble_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNumeroEnsamble.TextChanged

        Dim StrSqlSelect As String, Sql As String, i As Integer, SqlString As String
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter, NumeroEnsamble As String

        StrSqlSelect = "SELECT Recepcion.FechaHora, Recepcion.Id_Placa, Vehiculo.Modelo, Recepcion.Conductor, Conductor.Cedula, Recepcion.RecibimosDe, Proveedor.Nombre_Proveedor + ' ' + Proveedor.Apellido_Proveedor AS PorCuentade,Recepcion.Cod_Proveedor, Recepcion.Cod_Bodega, Recepcion.Calidad, Variedad.Variedad , Recepcion.Estado FROM  Recepcion INNER JOIN Variedad ON Recepcion.Idvariedad = Variedad.IdVariedad INNER JOIN  Vehiculo ON Recepcion.Id_Placa = Vehiculo.Placa INNER JOIN Conductor ON Recepcion.Conductor = Conductor.Nombre INNER JOIN Proveedor ON Recepcion.Cod_Proveedor = Proveedor.Cod_Proveedor WHERE  (Recepcion.NumeroRecepcion = N'" & Me.TxtNumeroEnsamble.Text & "')"
        DataAdapter = New SqlClient.SqlDataAdapter(StrSqlSelect, MiConexion)
        DataAdapter.Fill(DataSet, "SeleccionRecep")
        If DataSet.Tables("SeleccionRecep").Rows.Count > 0 Then
            If Not IsDBNull(DataSet.Tables("SeleccionRecep").Rows(0)("FechaHora")) Then
                Me.LblFechaHora.Text = DataSet.Tables("SeleccionRecep").Rows(0)("FechaHora")
            Else
                Me.LblFechaHora.Text = "-----------"
            End If
            If Not IsDBNull(DataSet.Tables("SeleccionRecep").Rows(0)("Id_Placa")) Then
                Me.LblPlaca.Text = DataSet.Tables("SeleccionRecep").Rows(0)("Id_Placa")
            Else
                Me.LblPlaca.Text = "-----------"
            End If
            If Not IsDBNull(DataSet.Tables("SeleccionRecep").Rows(0)("Modelo")) Then
                Me.LblModelo.Text = DataSet.Tables("SeleccionRecep").Rows(0)("Modelo")
            Else
                Me.LblModelo.Text = "-----------"
            End If
            If Not IsDBNull(DataSet.Tables("SeleccionRecep").Rows(0)("Conductor")) Then
                Me.LblConductor.Text = DataSet.Tables("SeleccionRecep").Rows(0)("Conductor")
            Else
                Me.LblConductor.Text = "-----------"
            End If
            If Not IsDBNull(DataSet.Tables("SeleccionRecep").Rows(0)("Cedula")) Then
                Me.LblCedulaConductor.Text = DataSet.Tables("SeleccionRecep").Rows(0)("Cedula")
            Else
                Me.LblCedulaConductor.Text = "-----------"
            End If
            If Not IsDBNull(DataSet.Tables("SeleccionRecep").Rows(0)("RecibimosDe")) Then
                Me.LblRecibimosde.Text = DataSet.Tables("SeleccionRecep").Rows(0)("RecibimosDe")
            Else
                Me.LblRecibimosde.Text = "-----------"
            End If
            If Not IsDBNull(DataSet.Tables("SeleccionRecep").Rows(0)("PorCuentade")) Then
                Me.LblPorcunetade.Text = DataSet.Tables("SeleccionRecep").Rows(0)("PorCuentade")
            Else
                Me.LblPorcunetade.Text = "-----------"
            End If
            If Not IsDBNull(DataSet.Tables("SeleccionRecep").Rows(0)("Cod_Proveedor")) Then
                Me.LblCodigo.Text = DataSet.Tables("SeleccionRecep").Rows(0)("Cod_Proveedor")
            Else
                Me.LblCodigo.Text = "-----------"
            End If
            If Not IsDBNull(DataSet.Tables("SeleccionRecep").Rows(0)("Cod_Bodega")) Then
                Me.CboBodegaOrigen.SelectedValue = DataSet.Tables("SeleccionRecep").Rows(0)("Cod_Bodega")
            Else
                Me.CboBodegaOrigen.Text = "-----------"
            End If
            If Not IsDBNull(DataSet.Tables("SeleccionRecep").Rows(0)("Calidad")) Then
                Me.LblCalidad.Text = DataSet.Tables("SeleccionRecep").Rows(0)("Calidad")
            Else
                Me.LblCalidad.Text = "-----------"
            End If
            If Not IsDBNull(DataSet.Tables("SeleccionRecep").Rows(0)("Variedad")) Then
                Me.LblVariedad.Text = DataSet.Tables("SeleccionRecep").Rows(0)("Variedad")
            Else
                Me.LblVariedad.Text = "-----------"
            End If
            If Not IsDBNull(DataSet.Tables("SeleccionRecep").Rows(0)("Estado")) Then
                Me.LblEstado.Text = DataSet.Tables("SeleccionRecep").Rows(0)("Estado")
            Else
                Me.LblEstado.Text = "-----------"
            End If

            SqlString = "SELECT   SUM(Detalle_Recepcion.Cantidad) AS PesoBruto, SUM(Detalle_Recepcion.Tara) AS Tara, Recepcion.Estado, SUM(Detalle_Recepcion.PesoNetoLb) AS Pesoneto, SUM(Detalle_Recepcion.QQ) AS Sacos FROM  Recepcion INNER JOIN   Variedad ON Recepcion.Idvariedad = Variedad.IdVariedad INNER JOIN   Detalle_Recepcion ON Recepcion.NumeroRecepcion = Detalle_Recepcion.NumeroRecepcion GROUP BY Recepcion.NumeroRecepcion, Recepcion.FechaHora, Recepcion.RecibimosDe, Variedad.Variedad, Recepcion.Estado HAVING (Recepcion.NumeroRecepcion = N'" & Me.TxtNumeroEnsamble.Text & "')  "
            DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
            DataAdapter.Fill(DataSet, "Totales")

            If DataSet.Tables("Totales").Rows.Count > 0 Then
                If Not IsDBNull(DataSet.Tables("Totales").Rows(0)("PesoBruto")) Then
                    Me.LblPesoBruto.Text = DataSet.Tables("Totales").Rows(0)("PesoBruto")
                Else
                    Me.LblPesoBruto.Text = "-----------"
                End If
                If Not IsDBNull(DataSet.Tables("Totales").Rows(0)("Tara")) Then
                    Me.LblTara.Text = DataSet.Tables("Totales").Rows(0)("Tara")
                Else
                    Me.LblTara.Text = "-----------"
                End If
                If Not IsDBNull(DataSet.Tables("Totales").Rows(0)("Pesoneto")) Then
                    PesoNeto = DataSet.Tables("Totales").Rows(0)("Pesoneto")
                    Me.LblPesoNeto.Text = DataSet.Tables("Totales").Rows(0)("Pesoneto")
                    Me.TxtPesoTransladar.Text = PesoNeto
                Else
                    Me.LblPesoNeto.Text = "-----------"
                End If
                If Not IsDBNull(DataSet.Tables("Totales").Rows(0)("Sacos")) Then
                    Me.LblTotalSaco.Text = DataSet.Tables("Totales").Rows(0)("Sacos")
                Else
                    Me.LblTotalSaco.Text = "-----------"
                End If
            End If
        Else
            Me.LblFechaHora.Text = "-----------"
            Me.LblPlaca.Text = "-----------"
            Me.LblModelo.Text = "-----------"
            Me.LblConductor.Text = "-----------"
            Me.LblCedulaConductor.Text = "-----------"
            Me.LblRecibimosde.Text = "-----------"
            Me.LblPorcunetade.Text = "-----------"
            Me.LblCodigo.Text = "-----------"
            Me.CboBodegaOrigen.Text = "-----------"
            Me.LblCalidad.Text = "-----------"
            Me.LblVariedad.Text = "-----------"
            Me.LblEstado.Text = "-----------"
            Me.LblPesoBruto.Text = "-----------"
            Me.LblTara.Text = "-----------"
            Me.LblPesoNeto.Text = "-----------"
            Me.LblTotalSaco.Text = "-----------"
        End If

        StrSqlSelect = "SELECT  IdDetalleCama, NumeroRecepcion, IdCama, FechaHora, CodProveedor, NumeroTraza, Nivel, PesoEnviado  FROM    DetalleCama WHERE        (NumeroRecepcion = N'" & Me.TxtNumeroEnsamble.Text & "')   ORDER BY FechaHora DESC "
        DataAdapter = New SqlClient.SqlDataAdapter(StrSqlSelect, MiConexion)
        DataAdapter.Fill(DataSet, "DetalleCama")

        If DataSet.Tables("DetalleCama").Rows.Count > 0 Then
            If Not IsDBNull(DataSet.Tables("DetalleCama").Rows(0)("Nivel")) Then
                Me.TxtNivelActual.Text = DataSet.Tables("DetalleCama").Rows(0)("Nivel")
            Else
                Me.TxtNivelActual.Text = "No asignado"
            End If
            If Not IsDBNull(DataSet.Tables("DetalleCama").Rows(0)("IdCama")) Then
                Me.CboCama.SelectedValue = DataSet.Tables("DetalleCama").Rows(0)("IdCama")
            Else
                Me.CboCama.SelectedIndex = 0
            End If
            If Not IsDBNull(DataSet.Tables("DetalleCama").Rows(0)("NumeroTraza")) Then
                CodigoTraza = DataSet.Tables("DetalleCama").Rows(0)("NumeroTraza")
            Else
                CodigoTraza = ""
            End If
        Else
            Me.TxtNivelActual.Text = "No asignado"
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.LblHora.Text = Date.Now.ToLongTimeString
    End Sub

    Private Sub CboBodegaOrigen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboBodegaOrigen.SelectedIndexChanged

    End Sub

    Private Sub FrmTranslado_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.TxtNumeroEnsamble.Text = "- - - - - 0 - - - - -"
    End Sub

    Private Sub CboBodegaOrigen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboBodegaOrigen.TextChanged
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim sql As String, ComandoUpdate As New SqlClient.SqlCommand
        Dim SqlProductos As String, SqlString As String, Ruta As String, LeeArchivo As String, i As Integer

        SqlString = "SELECT Cod_Bodega, Nombre_Bodega  FROM  Bodegas WHERE (NOT (Nombre_Bodega = N'" & Me.CboBodegaOrigen.Text & "'))"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "Bodegas1")
        Me.CboBodegaDestino.DataSource = DataSet.Tables("Bodegas1")
        If Not DataSet.Tables("Bodegas1").Rows.Count = 0 Then
            If Quien = "Transladar-Recepcion-Patio" Then
                Me.CboBodegaDestino.SelectedValue = DataSet.Tables("Bodegas1").Rows(0)("Cod_Bodega")
            ElseIf Quien = "Cama" Then
                Me.CboBodegaDestino.SelectedValue = DataSet.Tables("Bodegas1").Rows(1)("Cod_Bodega")
            End If
        End If
    End Sub

    Private Sub CboCama_ValueMemberChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCama.ValueMemberChanged

    End Sub

    Private Sub BtnNuevoRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevoRec.Click
        Me.TxtNumeroEnsamble.Text = "- - - - - 0 - - - - -"
    End Sub

    Private Sub CboCama_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCama.TextChanged
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim sql As String, ComandoUpdate As New SqlClient.SqlCommand, SqlString As String


        SqlString = "SELECT IdCama, NombreCama, Niveles, Activa   FROM  Cama WHERE (Activa = 1) AND (NombreCama = '" & Me.CboCama.Text & "' )"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "NivelesCama")
        Me.CmbNivel.Items.Clear()
        If Not DataSet.Tables("NivelesCama").Rows.Count = 0 Then
            For i As Integer = 1 To DataSet.Tables("NivelesCama").Rows(0)("Niveles")
                Me.CmbNivel.Items.Add("Nivel " & i)
            Next i
            Me.CmbNivel.SelectedIndex = 0
            For Each Item As String In CmbNivel.Items
                If Item.ToString = Me.TxtNivelActual.Text Then
                    CmbNivel.Items.RemoveAt(CmbNivel.SelectedIndex)
                    Me.CmbNivel.SelectedIndex = 0
                    Exit Sub
                End If
            Next
        End If
    End Sub

    Private Sub BtnRecpSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRecpSalir.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPesoTransladar.Click
        FrmTeclado.ShowDialog()
        If FrmTeclado.Numero > PesoNeto Then
            MsgBox("El Peso a Transladar no puede ser mayor al peso neto de la Nota de Peso", MsgBoxStyle.Information, "Translado de Bodegas")
            Me.TxtPesoTransladar.Text = "0.00"
            Exit Sub
        Else
            Me.TxtPesoTransladar.Text = FrmTeclado.Numero
        End If
    End Sub

    Private Sub BtnEnviarPatio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEnviarPatio.Click

        Dim StrSqlSelect As String, Sql As String, i As Integer, SqlString As String, Fecha As Date
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter, NumeroEnsamble As String
        Dim StrSqlUpdate As String, ComandoUpdate As New SqlClient.SqlCommand, iResultado As Integer

        Fecha = Format(CDate(FrmRecepcion.DTPFecha.Text), "dd/MM/yyyy") & " " & Format(CDate(FrmRecepcion.LblHora.Text).Now, "HH:mm:ss")
        CodigoTraza = Me.LblCodigo.Text & "-E" & CStr(Me.CmbNivel.SelectedIndex + 1)

        StrSqlSelect = "SELECT  IdDetalleCama, NumeroRecepcion, IdCama, FechaHora, CodProveedor, NumeroTraza, Nivel, PesoEnviado  FROM    DetalleCama WHERE (NumeroRecepcion = N'" & Me.TxtNumeroEnsamble.Text & "') AND (IdCama = '" & Me.CboCama.SelectedValue & "') AND (Nivel = '" & Me.CmbNivel.Text & "')  ORDER BY FechaHora DESC "
        DataAdapter = New SqlClient.SqlDataAdapter(StrSqlSelect, MiConexion)
        DataAdapter.Fill(DataSet, "DetalleCamaGuardar")

        If DataSet.Tables("DetalleCamaGuardar").Rows.Count = 0 Then
            SqlString = "INSERT INTO [dbo].[DetalleCama]([NumeroRecepcion],[IdCama],[FechaHora],[CodProveedor],[NumeroTraza],[Nivel],[PesoEnviado])" & _
                        "VALUES ('" & Me.TxtNumeroEnsamble.Text & "', '" & Me.CboCama.SelectedValue & "', '" & Format(CDate(Fecha), "dd/MM/yyyy HH:mm:ss") & "','" & Me.LblCodigo.Text & "','" & CodigoTraza & "' , '" & Me.CmbNivel.Text & "','" & Me.TxtPesoTransladar.Text & "' )"
            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(SqlString, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            If iResultado = 1 Then
                MsgBox("Transaladado con exito", MsgBoxStyle.Information, "Camas")
                MiConexion.Close()
                If Quien = "Transladar-Recepcion-Patio" Then
                    ActualizarNotaPeso()
                    ImprimirTikect()
                    LimpiarNota = True
                    Me.Close()
                    Exit Sub
                ElseIf Quien = "RecepcionBusquedaCama" Then
                    ImprimirTikect()
                    Me.Close()
                    Exit Sub
                End If
                MiConexion.Close()
                Limpiar()
            End If
        Else
            If Quien = "Translado" Then
                ActualizarNotaPeso()
                Me.Close()
                Exit Sub
            End If
        End If
    End Sub
    Public Sub ActualizarNotaPeso()
        Dim StrSqlSelect As String, Sql As String, i As Integer, SqlString As String, Fecha As Date
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter, NumeroEnsamble As String
        Dim StrSqlUpdate As String, ComandoUpdate As New SqlClient.SqlCommand, iResultado As Integer

        StrSqlUpdate = "UPDATE [dbo].[Recepcion]SET [Cod_Bodega] ='" & Me.CboBodegaDestino.SelectedValue & "'" & _
                               "WHERE (NumeroRecepcion = '" & Me.TxtNumeroEnsamble.Text & "')"
        MiConexion.Close()
        MiConexion.Open()
        ComandoUpdate = New SqlClient.SqlCommand(StrSqlUpdate, MiConexion)
        iResultado = ComandoUpdate.ExecuteNonQuery
        MiConexion.Close()
    End Sub

    Public Sub Limpiar()
        TxtNumeroEnsamble.Text = ""
        TxtPesoTransladar.Text = "0.00"
        TxtNivelActual.Text = ""
    End Sub


    Public Sub ImprimirTikect()
        Dim StrSqlSelect As String, Sql As String, RutaLogo As String
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim ArepTrazabilidad As New ArepTrazabilidad

        Sql = "SELECT * FROM DatosEmpresa"
        DataAdapter = New SqlClient.SqlDataAdapter(Sql, MiConexion)
        DataAdapter.Fill(DataSet, "DatosEmpresa")

        'Fecha = Format(CDate(Now), "yyyy-MM-dd")
        'Hora = Format(CDate(Date.Now.ToLongTimeString), "HH:mm:ss")

        If Not DataSet.Tables("DatosEmpresa").Rows.Count = 0 Then
            If Not IsDBNull(DataSet.Tables("DatosEmpresa").Rows(0)("Ruta_Logo")) Then
                RutaLogo = DataSet.Tables("DatosEmpresa").Rows(0)("Ruta_Logo")
                If Dir(RutaLogo) <> "" Then
                    ArepTrazabilidad.ImgLogo.Image = New System.Drawing.Bitmap(RutaLogo)
                End If
            End If
        End If
        ArepTrazabilidad.ArepLblFecha.Text = Me.DTPFecha.Text & " " & Me.LblHora.Text
        ArepTrazabilidad.ArepLblVariedad.Text = Me.LblVariedad.Text
        ArepTrazabilidad.ArepLblCodigoTraza.Text = Me.CodigoTraza
        ArepTrazabilidad.Barcode1.Text = Me.CodigoTraza
        ArepTrazabilidad.ArepLblPesoNeto.Text = Me.TxtPesoTransladar.Text
        ArepTrazabilidad.ArepLblCama.Text = Me.CboCama.Text
        ArepTrazabilidad.ArepLblNivel.Text = Me.CmbNivel.Text
       
        Dim ViewerForm As New FrmViewer()
        ViewerForm.arvMain.Document = ArepTrazabilidad.Document
        My.Application.DoEvents()

        'ArepTrazabilidad.DataSource = DataSet.Tables("Reporte")
        ArepTrazabilidad.Run(False)
        ViewerForm.Show()

    End Sub
End Class