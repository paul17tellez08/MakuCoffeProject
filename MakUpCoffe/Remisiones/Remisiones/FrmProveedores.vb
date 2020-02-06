Public Class FrmProveedores
    Public MiConexion As New SqlClient.SqlConnection(Conexion)
    Public Llamada As String
    Private Sub FrmProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Sql As String = "SELECT * FROM Proveedor"
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter(Sql, MiConexion)
        DataAdapter.Fill(DataSet, "ListaProveedores")
        Me.CboCodigoProveedor.DataSource = DataSet.Tables("ListaProveedores")

        If Llamada = "RecepcionProductores" Then
            Me.ButtonBorrar.Enabled = False
        End If
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Close()
    End Sub

    Private Sub CmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdNuevo.Click
        Me.CboCodigoProveedor.Text = ""
    End Sub

    Private Sub CmdGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdGrabar.Click
        Dim SQLProveedor As String
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim StrSqlUpdate As String, ComandoUpdate As New SqlClient.SqlCommand, iResultado As Integer, Reintegro As Double, Exonerado As Double, Exclusivo As Double

        SQLProveedor = "SELECT  * FROM  Proveedor WHERE (Cod_Proveedor = '" & Me.CboCodigoProveedor.Text & "')"
        DataAdapter = New SqlClient.SqlDataAdapter(SQLProveedor, MiConexion)
        DataAdapter.Fill(DataSet, "Proveedores")
        If Not DataSet.Tables("Proveedores").Rows.Count = 0 Then
            '///////////SI EXISTE EL USUARIO LO ACTUALIZO////////////////
            StrSqlUpdate = "UPDATE [Proveedor] SET [Nombre_Proveedor] = '" & Me.TxtNombre.Text & "',[Apellido_Proveedor] = '" & Me.TxtApellido.Text & "',[Direccion_Proveedor] = '" & Me.TxtDireccion.Text & "',[Telefono] = '" & Me.TxtTelefono.Text & "',[Cod_Cuenta_Pagar] = '" & Me.TxtCtaxPagar.Text & "',[Cod_Cuenta_Cobrar] = '" & Me.TxtCtaxPagar.Text & "',[Merma] = '" & Me.TxtMerma.Text & "',[CedulaProveedor]= '" & Me.txtCedula.Text & "' WHERE Cod_Proveedor= '" & Me.CboCodigoProveedor.Text & "'"
            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(StrSqlUpdate, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            If iResultado = 1 Then
                MsgBox("PRODUCTOR ACTUALIZADO CON EXITO", MsgBoxStyle.Exclamation, "PRODUCTOR")
                MiConexion.Close()
                CmdNuevo_Click(sender, e)
            End If
            MiConexion.Close()
        Else
            '/////////SI NO EXISTE LO AGREGO COMO NUEVO/////////////////
            StrSqlUpdate = "INSERT INTO [Proveedor] ([Cod_Proveedor],[Nombre_Proveedor],[Apellido_Proveedor],[Direccion_Proveedor],[Telefono],[Cod_Cuenta_Pagar],[Cod_Cuenta_Cobrar],[Merma],[CedulaProveedor]) " & _
                               "VALUES ('" & Me.CboCodigoProveedor.Text & "','" & Me.TxtNombre.Text & "','" & Me.TxtApellido.Text & "','" & Me.TxtDireccion.Text & "','" & Me.TxtTelefono.Text & "','" & Me.TxtCtaxPagar.Text & "','" & Me.TxtCtaxCobrar.Text & "','" & Me.TxtMerma.Text & "','" & Me.txtCedula.Text & "')"
            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(StrSqlUpdate, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            If iResultado = 1 Then
                MsgBox("PRODUCTOR GUARDADO CON EXITO", MsgBoxStyle.Exclamation, "PRODUCTOR")
                MiConexion.Close()
                If Llamada = "RecepcionProductores" Then
                    Me.Close()
                End If
                CmdNuevo_Click(sender, e)
            End If
            MiConexion.Close()
        End If
        SQLProveedor = "SELECT        Cod_Proveedor, Nombre_Proveedor + ' ' + Apellido_Proveedor AS Nombre  FROM            Proveedor"
        DataAdapter = New SqlClient.SqlDataAdapter(SQLProveedor, MiConexion)
        DataAdapter.Fill(DataSet, "ListaProveedores")
        If Not DataSet.Tables("ListaProveedores").Rows.Count = 0 Then
            Me.CboCodigoProveedor.DataSource = DataSet.Tables("ListaProveedores")
        End If
        Me.CboCodigoProveedor.Text = ""
    End Sub

    Private Sub ButtonBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBorrar.Click
        Dim SQLProveedor As String
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim StrSqlUpdate As String, ComandoUpdate As New SqlClient.SqlCommand, iResultado As Integer
        Dim Resultado As String

        Resultado = MsgBox("¿Esta Seguro de Eliminar el Usuario?", MsgBoxStyle.OkCancel , "Sistema de Facturacion")

        If Not Resultado = "1" Then
            Exit Sub
        End If


        SQLProveedor = "SELECT TOP (100) PERCENT dbo.Proveedor.* FROM Proveedor WHERE (Cod_Proveedor = '" & Me.CboCodigoProveedor.Text & "') ORDER BY Cod_Proveedor"
        DataAdapter = New SqlClient.SqlDataAdapter(SQLProveedor, MiConexion)
        DataAdapter.Fill(DataSet, "Proveedores")
        If Not DataSet.Tables("Proveedores").Rows.Count = 0 Then
            '///////////SI EXISTE EL USUARIO LO ACTUALIZO////////////////


            StrSqlUpdate = "DELETE FROM [Proveedor] WHERE (Cod_Proveedor = '" & Me.CboCodigoProveedor.Text & "')"
            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(StrSqlUpdate, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            MiConexion.Close()


        End If

        SQLProveedor = "SELECT TOP (100) PERCENT dbo.Proveedor.* FROM Proveedor"
        DataAdapter = New SqlClient.SqlDataAdapter(SQLProveedor, MiConexion)
        DataAdapter.Fill(DataSet, "ListaProveedores")
        If Not DataSet.Tables("ListaProveedores").Rows.Count = 0 Then
            Me.CboCodigoProveedor.DataSource = DataSet.Tables("ListaProveedores")
        End If

        Me.CboCodigoProveedor.Text = ""
    End Sub

    Private Sub CboCodigoProveedor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCodigoProveedor.TextChanged
        Dim SqlProveedor As String, DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim SqlString As String

        SqlProveedor = "SELECT  * FROM Proveedor  WHERE (Cod_Proveedor = '" & Me.CboCodigoProveedor.Text & "')"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlProveedor, MiConexion)
        DataAdapter.Fill(DataSet, "Proveedor")
        If Not DataSet.Tables("Proveedor").Rows.Count = 0 Then
            Me.TxtNombre.Text = DataSet.Tables("Proveedor").Rows(0)("Nombre_Proveedor")
            If Not IsDBNull(DataSet.Tables("Proveedor").Rows(0)("Apellido_Proveedor")) Then
                Me.TxtApellido.Text = DataSet.Tables("Proveedor").Rows(0)("Apellido_Proveedor")
            End If
            If Not IsDBNull(DataSet.Tables("Proveedor").Rows(0)("Direccion_Proveedor")) Then
                Me.TxtDireccion.Text = DataSet.Tables("Proveedor").Rows(0)("Direccion_Proveedor")
            End If
            If Not IsDBNull(DataSet.Tables("Proveedor").Rows(0)("Telefono")) Then
                Me.TxtTelefono.Text = DataSet.Tables("Proveedor").Rows(0)("Telefono")
            End If
            If Not IsDBNull(DataSet.Tables("Proveedor").Rows(0)("Merma")) Then
                Me.TxtMerma.Text = DataSet.Tables("Proveedor").Rows(0)("Merma")
            End If
            If Not IsDBNull(DataSet.Tables("Proveedor").Rows(0)("Cod_Cuenta_Cobrar")) Then
                Me.TxtCtaxCobrar.Text = DataSet.Tables("Proveedor").Rows(0)("Cod_Cuenta_Cobrar")
            End If
            If Not IsDBNull(DataSet.Tables("Proveedor").Rows(0)("Cod_Cuenta_Pagar")) Then
                Me.TxtCtaxPagar.Text = DataSet.Tables("Proveedor").Rows(0)("Cod_Cuenta_Pagar")
            End If
            If Not IsDBNull(DataSet.Tables("Proveedor").Rows(0)("CedulaProveedor")) Then
                Me.txtCedula.Text = DataSet.Tables("Proveedor").Rows(0)("CedulaProveedor")
            End If

            'If Not IsDBNull(DataSet.Tables("Proveedor").Rows(0)("Reintegro")) Then
            '    If DataSet.Tables("Proveedor").Rows(0)("Reintegro") = True Then
            '        Me.ChkReintegro.Checked = True
            '    Else
            '        Me.ChkReintegro.Checked = False
            '    End If
            'Else
            '    Me.ChkReintegro.Checked = False
            'End If

            'If Not IsDBNull(DataSet.Tables("Proveedor").Rows(0)("Exonerado")) Then
            '    If DataSet.Tables("Proveedor").Rows(0)("Exonerado") = True Then
            '        Me.ChkExonerado.Checked = True
            '    Else
            '        Me.ChkExonerado.Checked = False
            '    End If
            'Else
            '    Me.ChkExonerado.Checked = False
            'End If

            'If Not IsDBNull(DataSet.Tables("Proveedor").Rows(0)("Exclusivo")) Then
            '    If DataSet.Tables("Proveedor").Rows(0)("Exclusivo") = True Then
            '        Me.ChkExclusivo.Checked = True
            '    Else
            '        Me.ChkExclusivo.Checked = False
            '    End If
            'Else
            '    Me.ChkExclusivo.Checked = False
            'End If
        Else
            Me.TxtNombre.Text = ""
            Me.TxtApellido.Text = ""
            Me.TxtDireccion.Text = ""
            Me.TxtTelefono.Text = ""
            Me.TxtMerma.Text = ""
            Me.TxtCtaxCobrar.Text = ""
            Me.TxtCtaxPagar.Text = ""
            Me.txtCedula.Text = ""
        End If
    End Sub

    Private Sub BtnConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsulta.Click
        Quien = "BusquedaProductor"
        My.Forms.FrmConsultas.Text = "Consulta Productor"
        My.Forms.FrmConsultas.ShowDialog()
        If My.Forms.FrmConsultas.Codigo <> "- - - - - 0 - - - - - " Then
            Me.CboCodigoProveedor.Text = FrmConsultas.Codigo
        End If
    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub
End Class