Public Class FrmConductor
    Public MiConexion As New SqlClient.SqlConnection(Conexion), Llamada As String, Nombre As String, Cedula As String
    Public Sub LimpiaConductor()
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim sql As String, ComandoUpdate As New SqlClient.SqlCommand 'iResultado As Integer
        Dim SqlProductos As String, SqlString As String, Ruta As String, LeeArchivo As String

        '//////////////////////////CARGO LOS CONDUCTORES//////////////////////////////////////////
        SqlString = "SELECT Codigo, Nombre, Cedula, Licencia, Activo, ListaNegra, RazonListaNegra FROM Conductor "
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "Conductor")
        Me.CboCodigoConductor.DataSource = DataSet.Tables("Conductor")
        Me.CboCodigoConductor.Columns(0).Caption = "Codigo"
        Me.TxtCedula.Text = ""
        Me.TxtLicencia.Text = ""
        Me.TxtMotivo.Text = ""
        Me.TxtNombre.Text = ""
        Me.CboCodigoConductor.Text = ""
        CheckActivo.Checked = True
        CheckListaNegra.Checked = False
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Close()
    End Sub

    Private Sub FrmConductor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim sql As String, ComandoUpdate As New SqlClient.SqlCommand 'iResultado As Integer
        Dim SqlProductos As String, SqlString As String, Ruta As String, LeeArchivo As String

        '//////////////////////////CARGO LOS CONDUCTORES////////////////////////////////////////////////////////////////////
        SqlString = "SELECT Codigo, Nombre, Cedula, Licencia, Activo, ListaNegra, RazonListaNegra FROM Conductor "
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "Conductor")
        Me.CboCodigoConductor.DataSource = DataSet.Tables("Conductor")
        If Llamada = "RecepcionConductor" Then
            LimpiaConductor()
            ButtonBorrar.Enabled = False
        End If
    End Sub
    Private Sub CboCodigoConductor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCodigoConductor.TextChanged

        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim sql As String, ComandoUpdate As New SqlClient.SqlCommand 'iResultado As Integer
        Dim SqlProductos As String, SqlString As String, Codigo As String

        '//////////////////////////CARGO LOS CONDUCTORES//////////////////////////////////////////////////////
        Codigo = Me.CboCodigoConductor.Text
        SqlString = "SELECT Codigo, Nombre, Cedula, Licencia, Activo, ListaNegra, RazonListaNegra FROM Conductor WHERE (Codigo = '" & Codigo & "')"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(DataSet, "Conductor")
        If Not DataSet.Tables("Conductor").Rows.Count = 0 Then

            If Not IsDBNull(DataSet.Tables("Conductor").Rows(0)("Nombre")) Then
                Me.TxtNombre.Text = DataSet.Tables("Conductor").Rows(0)("Nombre")
            End If

            If Not IsDBNull(DataSet.Tables("Conductor").Rows(0)("Cedula")) Then
                Me.TxtCedula.Text = DataSet.Tables("Conductor").Rows(0)("Cedula")
            End If

            If Not IsDBNull(DataSet.Tables("Conductor").Rows(0)("Licencia")) Then
                Me.TxtLicencia.Text = DataSet.Tables("Conductor").Rows(0)("Licencia")
            End If

            CheckActivo.Checked = DataSet.Tables("Conductor").Rows(0)("Activo")
            CheckListaNegra.Checked = DataSet.Tables("Conductor").Rows(0)("ListaNegra")

            If Not IsDBNull(DataSet.Tables("Conductor").Rows(0)("RazonListaNegra")) Then
                Me.TxtMotivo.Text = DataSet.Tables("Conductor").Rows(0)("RazonListaNegra")
            End If
        Else
            Me.TxtNombre.Text = ""
            Me.TxtCedula.Text = ""
            Me.TxtLicencia.Text = ""
            Me.TxtMotivo.Text = ""
            CheckActivo.Checked = True
            CheckListaNegra.Checked = False
        End If
    End Sub

    Private Sub ButtonNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNuevo.Click
        LimpiaConductor()
    End Sub

    Private Sub ButtonGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGrabar.Click
        Dim SQLString As String, Activo As Double
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim StrSqlUpdate As String, ComandoUpdate As New SqlClient.SqlCommand, iResultado As Integer
        Dim ListaNegra As Double

        SQLString = "SELECT  Codigo, Nombre, Cedula, Activo FROM Conductor WHERE (Activo = 1) AND (Codigo = '" & Me.CboCodigoConductor.Columns(0).Text & "')"
        DataAdapter = New SqlClient.SqlDataAdapter(SQLString, MiConexion)
        DataAdapter.Fill(DataSet, "Clientes")
        If Not DataSet.Tables("Clientes").Rows.Count = 0 Then
            '///////////SI EXISTE EL USUARIO LO ACTUALIZO////////////////
            StrSqlUpdate = "UPDATE [Conductor]  SET [Nombre] = '" & Me.TxtNombre.Text & "',[Cedula] = '" & Me.TxtCedula.Text & "',[Licencia] = '" & Me.TxtLicencia.Text & "'  ,[Activo] = '" & CheckActivo.Checked & "',[ListaNegra] = '" & CheckListaNegra.Checked & "',[RazonListaNegra]= '" & Me.TxtMotivo.Text & "'  WHERE (Activo = 1) AND (Codigo = '" & Me.CboCodigoConductor.Text & "')"
            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(StrSqlUpdate, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            If iResultado = 1 Then
                MsgBox("CONDUCTOR ACTUALIZADO CON EXITO", MsgBoxStyle.Exclamation, "Vehiculo")
                MiConexion.Close()
                LimpiaConductor()
            Else
                MsgBox("ALGO SALIO MAL ASEGURESE QUE LA INFORMACION ESTA CORRECTA, CONTACTESE CON SOPORTE", MsgBoxStyle.Exclamation, "Vehiculo")
                MiConexion.Close()
                Exit Sub
            End If
            MiConexion.Close()
        Else
            '/////////SI NO EXISTE LO AGREGO COMO NUEVO/////////////////
            StrSqlUpdate = "INSERT INTO [dbo].[Conductor]([Nombre],[Cedula],[Licencia],[Activo],[ListaNegra],[RazonListaNegra]) VALUES ('" & Me.TxtNombre.Text & "' ,'" & Me.TxtCedula.Text & "', '" & Me.TxtLicencia.Text & "', '" & CheckActivo.Checked & "','" & CheckListaNegra.Checked & "', '" & Me.TxtMotivo.Text & "') "
            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(StrSqlUpdate, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            If iResultado = 1 Then
                MsgBox("CONDUCTOR GUARDADO CON EXITO", MsgBoxStyle.Exclamation, "Vehiculo")
                MiConexion.Close()
                If Llamada = "RecepcionConductor" Then
                    Me.Close()
                    Exit Sub
                End If
                LimpiaConductor()
            Else
                MsgBox("ALGO SALIO MAL ASEGURESE QUE LA INFORMACION ESTA CORRECTA, CONTACTESE CON SOPORTE", MsgBoxStyle.Exclamation, "Vehiculo")
                MiConexion.Close()
                Exit Sub
            End If
        End If
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

        SQLString = "SELECT  Codigo, Nombre, Cedula, Licencia, Activo, ListaNegra, RazonListaNegra   FROM   Conductor  WHERE  (Codigo = '" & Me.CboCodigoConductor.Text & "')"
        DataAdapter = New SqlClient.SqlDataAdapter(SQLString, MiConexion)
        DataAdapter.Fill(DataSet, "Conductores")
        If Not DataSet.Tables("Conductores").Rows.Count = 0 Then
            '--------------------SI EXISTE EL CONDUCTOR LO ACTUALIZO--------------------
            '---------------ANTES DE BORRAR VERIFICO SI EXISTE PLACAS PARA LA RECEPCION ---------------------
            SQLString = "SELECT * FROM  Recepcion  WHERE (Conductor = N'" & Me.TxtNombre.Text & "')"
            DataAdapter = New SqlClient.SqlDataAdapter(SQLString, MiConexion)
            DataAdapter.Fill(DataSet, "ConsultaRec")
            If Not DataSet.Tables("ConsultaRec").Rows.Count = 0 Then
                MsgBox("EXISTEN REGISTROS DE NOTAS DE PESO CON EL CONDUCTOR : " & Me.TxtNombre.Text & "", MsgBoxStyle.Critical, "Vehiculo")
                Exit Sub
            End If

            StrSqlUpdate = "DELETE FROM [dbo].[Conductor] WHERE(Nombre = N'" & Me.TxtNombre.Text & "')"
            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(StrSqlUpdate, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            If iResultado = 1 Then
                MsgBox("VEHICULO ELIMINADO CON EXITO", MsgBoxStyle.Exclamation, "Vehiculo")
                MiConexion.Close()
               LimpiaConductor()
            Else
                MsgBox("ALGO SALIO MAL ASEGURESE QUE LA INFORMACION ESTA CORRECTA, CONTACTESE CON SOPORTE", MsgBoxStyle.Exclamation, "Vehiculo")
                MiConexion.Close()
                Exit Sub
            End If
            MiConexion.Close()
        End If
    End Sub

    Private Sub C1Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button2.Click
        Quien = "ConsultaConductorRecepcion"
        My.Forms.FrmConsultas.Text = "Consulta Conductor Recepcion"
        My.Forms.FrmConsultas.ShowDialog()
        If My.Forms.FrmConsultas.Codigo <> "- - - - - 0 - - - - - " Then
            Me.CboCodigoConductor.Text = FrmConsultas.Codigo
        End If
    End Sub

    Private Sub CheckListaNegra_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckListaNegra.CheckedChanged
        If CheckListaNegra.Checked = False Then
            Me.TxtMotivo.Visible = False
            Me.Label4.Visible = False
        Else
            Me.TxtMotivo.Visible = True
            Me.Label4.Visible = True
            Me.TxtMotivo.Text = ""
        End If
    End Sub

    Private Sub DatosConductor()
        If Llamada = "RecepcionConductor" Then
            If Llamada = "RecepcionAgre" Then
                Dim SQlLastRegister As String
                Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
                Dim ComandoUpdate As New SqlClient.SqlCommand, iResultado As Integer
                SQlLastRegister = "SELECT Codigo, Nombre, Cedula, Licencia, Activo, ListaNegra, RazonListaNegra  FROM  Conductor  WHERE (Activo = 1) ORDER BY Codigo DESC"
                DataAdapter = New SqlClient.SqlDataAdapter(SQlLastRegister, MiConexion)
                DataAdapter.Fill(DataSet, "ConductorLast")
                If Not DataSet.Tables("ConductorLast").Rows.Count = 0 Then
                    Nombre = DataSet.Tables("ConductorLast").Rows(0)("Nombre")
                    Cedula = DataSet.Tables("ConductorLast").Rows(0)("Cedula")
                End If
            End If
        End If
    End Sub
End Class