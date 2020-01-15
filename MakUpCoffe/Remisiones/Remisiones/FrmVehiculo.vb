Public Class FrmVehiculo
    Public MiConexion As New SqlClient.SqlConnection(Conexion)
    Public Llamada As String, Placa As String, Marca As String, Modelo As String, Color As String

    Private Sub C1Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button2.Click
        Quien = "Vehiculo"
        'My.Forms.FrmConsultas.ShowDialog()
        'Me.CboPlaca.Text = My.Forms.FrmConsultas.Codigo
    End Sub

    Private Sub Vehiculo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim SqlString As String, DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter

        CargarPlacas()

        SqlString = "SELECT DISTINCT Marca FROM Vehiculo WHERE(Activo = 1)"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "Marca")
        If Not DataSet.Tables("Marca").Rows.Count = 0 Then
            Me.CboMarca.DataSource = DataSet.Tables("Marca")
            Me.CboMarca.Text = DataSet.Tables("Marca").Rows(0)("Marca")
        End If

        SqlString = "SELECT DISTINCT Modelo FROM Vehiculo WHERE(Activo = 1)"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "Modelo")
        If Not DataSet.Tables("Modelo").Rows.Count = 0 Then
            Me.CboModelo.DataSource = DataSet.Tables("Modelo")
            Me.CboModelo.Text = DataSet.Tables("Modelo").Rows(0)("Modelo")
        End If

        SqlString = "SELECT DISTINCT TipoVehiculo FROM Vehiculo WHERE(Activo = 1)"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "TipoVehiculo")
        If Not DataSet.Tables("TipoVehiculo").Rows.Count = 0 Then
            Me.CboTipo.DataSource = DataSet.Tables("TipoVehiculo")
            Me.CboTipo.Text = DataSet.Tables("TipoVehiculo").Rows(0)("TipoVehiculo")
        End If

        SqlString = "SELECT DISTINCT Color FROM Vehiculo WHERE(Activo = 1)"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "Color")
        If Not DataSet.Tables("Color").Rows.Count = 0 Then
            Me.CboColor.DataSource = DataSet.Tables("Color")
            Me.CboColor.Text = DataSet.Tables("Color").Rows(0)("Color")
        End If

        If Llamada = "RecepcionAgre" Then
            Me.ButtonBorrar.Enabled = False
            CmdNuevo_Click(sender, e)
        End If
    End Sub
    Private Sub CargarPlacas()
        Dim SqlString As String, DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter

        SqlString = "SELECT Placa FROM Vehiculo"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "Placa")
        If Not DataSet.Tables("Placa").Rows.Count = 0 Then
            Me.CboPlaca.DataSource = DataSet.Tables("Placa")
            Me.CboPlaca.Text = DataSet.Tables("Placa").Rows(0)("Placa")
        End If
    End Sub
    Private Sub CboPlaca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboPlaca.TextChanged
        Dim SqlString As String, DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter, Activo As Boolean

        '////////////////////////////////////////////////BUSCO DATOS DEL CONDUCTOR ///////////////////////////////////
        SqlString = "SELECT   IdVehiculo, Placa, Marca, Modelo, Color, TipoVehiculo, Activo FROM Vehiculo WHERE (Placa = '" & Me.CboPlaca.Text & "')"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "DatosVehiculo")
        If Not DataSet.Tables("DatosVehiculo").Rows.Count = 0 Then

            If Not IsDBNull(DataSet.Tables("DatosVehiculo").Rows(0)("Marca")) Then
                Me.CboMarca.Text = DataSet.Tables("DatosVehiculo").Rows(0)("Marca")
            End If

            If Not IsDBNull(DataSet.Tables("DatosVehiculo").Rows(0)("Modelo")) Then
                Me.CboModelo.Text = DataSet.Tables("DatosVehiculo").Rows(0)("Modelo")
            End If

            If Not IsDBNull(DataSet.Tables("DatosVehiculo").Rows(0)("TipoVehiculo")) Then
                Me.CboTipo.Text = DataSet.Tables("DatosVehiculo").Rows(0)("TipoVehiculo")
            End If

            If Not IsDBNull(DataSet.Tables("DatosVehiculo").Rows(0)("Color")) Then
                Me.CboColor.Text = DataSet.Tables("DatosVehiculo").Rows(0)("Color")
            End If

            If Not IsDBNull(DataSet.Tables("DatosVehiculo").Rows(0)("Activo")) Then
                Me.CheckBox1.Checked = DataSet.Tables("DatosVehiculo").Rows(0)("Activo")
            End If
        Else
        End If
    End Sub

    Private Sub CboMarca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboMarca.TextChanged
        Dim SqlString As String, DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter, Activo As Boolean

        SqlString = "SELECT  DISTINCT  Modelo FROM Vehiculo WHERE (Marca = '" & Me.CboMarca.Text & "')"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "VehiculoModelo")
        If Not DataSet.Tables("VehiculoModelo").Rows.Count = 0 Then
            If Not IsDBNull(DataSet.Tables("VehiculoModelo").Rows(0)("Modelo")) Then
                Me.CboModelo.DataSource = DataSet.Tables("VehiculoModelo")
                Me.CboModelo.Text = DataSet.Tables("VehiculoModelo").Rows(0)("Modelo")
            End If
        End If
    End Sub
    Private Sub CboModelo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboModelo.TextChanged
        Dim SqlString As String, DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter, Activo As Boolean

        SqlString = "SELECT  DISTINCT  TipoVehiculo FROM Vehiculo WHERE (Modelo = '" & Me.CboModelo.Text & "')"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "VehiculoTipo")
        If Not DataSet.Tables("VehiculoTipo").Rows.Count = 0 Then
            If Not IsDBNull(DataSet.Tables("VehiculoTipo").Rows(0)("TipoVehiculo")) Then
                Me.CboTipo.DataSource = DataSet.Tables("VehiculoTipo")
                Me.CboTipo.Text = DataSet.Tables("VehiculoTipo").Rows(0)("TipoVehiculo")
            End If
        End If
    End Sub

    Private Sub CmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdNuevo.Click
        Me.CboPlaca.Text = ""
        Me.CboMarca.Text = ""
        Me.CboModelo.Text = ""
        Me.CboTipo.Text = ""
        Me.CboColor.Text = ""
        Me.CheckBox1.Checked = True
    End Sub

    Private Sub CmdGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdGrabar.Click
        Dim SQLString As String, Activo As Double
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim StrSqlUpdate As String, ComandoUpdate As New SqlClient.SqlCommand, iResultado As Integer

        SQLString = "SELECT  Placa, Marca, TipoVehiculo, Activo FROM Vehiculo WHERE (Placa = '" & Me.CboPlaca.Text & "')"
        DataAdapter = New SqlClient.SqlDataAdapter(SQLString, MiConexion)
        DataAdapter.Fill(DataSet, "Clientes")
        If Not DataSet.Tables("Clientes").Rows.Count = 0 Then
            '///////////SI EXISTE EL USUARIO LO ACTUALIZO////////////////
            'If Llamada = "RecepcionAgre" Then
            '    'MsgBox("NO SE PUEDE ACTUALIZAR LOS DATOS SOLO AGREGAR", MsgBoxStyle.Exclamation, "Vehiculo")
            '    Exit Sub
            'End If
            StrSqlUpdate = "UPDATE [Vehiculo]  SET [Marca] = '" & Me.CboMarca.Text & "',[Modelo] = '" & Me.CboModelo.Text & "',[Color] = '" & Me.CboColor.Text & "',[TipoVehiculo] = '" & Me.CboTipo.Text & "' ,[Activo] = '" & Me.CheckBox1.Checked & "'  WHERE (Placa = '" & Me.CboPlaca.Text & "')"
            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(StrSqlUpdate, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            If iResultado = 1 Then
                MsgBox("VEHICULO ACTUALIZADO CON EXITO", MsgBoxStyle.Exclamation, "Vehiculo")
                MiConexion.Close()
                CargarPlacas()
                CmdNuevo_Click(sender, e)
            Else
                MsgBox("ALGO SALIO MAL ASEGURESE QUE LA INFORMACION ESTA CORRECTA, CONTACTESE CON SOPORTE", MsgBoxStyle.Exclamation, "Vehiculo")
                MiConexion.Close()
                Exit Sub
            End If
        Else
            '/////////SI NO EXISTE LO AGREGO COMO NUEVO/////////////////
            StrSqlUpdate = "INSERT INTO [Vehiculo] ([Placa],[Marca], [Modelo], [Color],[TipoVehiculo],[Activo]) VALUES ('" & Me.CboPlaca.Text & "' ,'" & Me.CboMarca.Text & "','" & Me.CboModelo.Text & "','" & Me.CboColor.Text & "' ,'" & Me.CboTipo.Text & "', '" & Me.CheckBox1.Checked & "') "
            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(StrSqlUpdate, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            If iResultado = 1 Then
                MsgBox("VEHICULO GUARDADO CON EXITO", MsgBoxStyle.Exclamation, "Vehiculo")
                MiConexion.Close()
                If Llamada = "RecepcionAgre" Then
                    Me.Close()
                    Exit Sub
                End If
                CargarPlacas()
                CmdNuevo_Click(sender, e)
            Else
                MsgBox("ALGO SALIO MAL ASEGURESE QUE LA INFORMACION ESTA CORRECTA, CONTACTESE CON SOPORTE", MsgBoxStyle.Exclamation, "Vehiculo")
                MiConexion.Close()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Close()
    End Sub

    Private Sub ButtonBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBorrar.Click
        Dim SQLString As String
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim StrSqlUpdate As String, ComandoUpdate As New SqlClient.SqlCommand, iResultado As Integer
        Dim Resultado As String, StrSQl As String
        Resultado = MsgBox("¿Esta Seguro de Eliminar el Usuario?", MsgBoxStyle.OkCancel, "Sistema de Facturacion")
        If Not Resultado = "1" Then
            Exit Sub
        End If

        SQLString = "SELECT  Placa, Marca, TipoVehiculo, Activo FROM Vehiculo WHERE (Placa = '" & Me.CboPlaca.Text & "')"
        DataAdapter = New SqlClient.SqlDataAdapter(SQLString, MiConexion)
        DataAdapter.Fill(DataSet, "Clientes")
        If Not DataSet.Tables("Clientes").Rows.Count = 0 Then
            '///////////SI EXISTE EL USUARIO LO ACTUALIZO////////////////
            '---------------ANTES DE BORRAR VERIFICO SI EXISTE PLACAS PARA LA RECEPCION ---------------------
            SQLString = "SELECT  NumeroRecepcion FROM Recepcion WHERE  (Id_Placa = '" & Me.CboPlaca.Text & "')"
            DataAdapter = New SqlClient.SqlDataAdapter(SQLString, MiConexion)
            DataAdapter.Fill(DataSet, "ConsultaRec")
            If Not DataSet.Tables("ConsultaRec").Rows.Count = 0 Then
                MsgBox("EXISTEN REGISTROS DE NOTAS DE PESO CON EL VEHICULO : " & Me.CboPlaca.Text & "", MsgBoxStyle.Critical, "Vehiculo")
                Exit Sub
            End If
            StrSqlUpdate = "DELETE FROM [Vehiculo] WHERE (Placa = '" & Me.CboPlaca.Text & "')"
            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(StrSqlUpdate, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            If iResultado = 1 Then
                MsgBox("VEHICULO ELIMINADO CON EXITO", MsgBoxStyle.Exclamation, "Vehiculo")
                MiConexion.Close()
                CargarPlacas()
                CmdNuevo_Click(sender, e)
            Else
                MsgBox("ALGO SALIO MAL ASEGURESE QUE LA INFORMACION ESTA CORRECTA, CONTACTESE CON SOPORTE", MsgBoxStyle.Exclamation, "Vehiculo")
                MiConexion.Close()
                Exit Sub
            End If
            MiConexion.Close()
        End If
    End Sub

    'Private Sub PegarDatosagregados()
    '    If Llamada = "RecepcionAgre" Then
    '        Dim SQlLastRegister As String
    '        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
    '        Dim ComandoUpdate As New SqlClient.SqlCommand, iResultado As Integer

    '        SQlLastRegister = "SELECT  IdVehiculo, Placa, Marca, Modelo, Color, TipoVehiculo, Activo   FROM    Vehiculo   WHERE (Activo = 1) ORDER BY IdVehiculo DESC"
    '        DataAdapter = New SqlClient.SqlDataAdapter(SQlLastRegister, MiConexion)
    '        DataAdapter.Fill(DataSet, "VehiculosLast")
    '        If Not DataSet.Tables("VehiculosLast").Rows.Count = 0 Then
    '            Placa = DataSet.Tables("VehiculosLast").Rows(0)("Placa")
    '            'Marca = DataSet.Tables("VehiculosLast").Rows(0)("Marca")
    '            'Modelo = DataSet.Tables("VehiculosLast").Rows(0)("Modelo")
    '            'Color = DataSet.Tables("VehiculosLast").Rows(0)("Color")
    '        End If
    '    End If
    'End Sub
End Class