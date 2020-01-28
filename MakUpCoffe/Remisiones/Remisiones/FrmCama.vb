Public Class FrmCama
    Public MiConexion As New SqlClient.SqlConnection(Conexion)

    Private Sub FrmCama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim SqlUsuarios As String
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter

        SqlUsuarios = "SELECT  IdCama, NombreCama, Niveles, Activa  FROM  Cama "
        DataAdapter = New SqlClient.SqlDataAdapter(SqlUsuarios, MiConexion)
        DataAdapter.Fill(DataSet, "ListaCamas")
        If Not DataSet.Tables("ListaCamas").Rows.Count = 0 Then
            Me.CboCodigoCama.DataSource = DataSet.Tables("ListaCamas")
        End If
    End Sub

    Private Sub CboCodigoCama_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCodigoCama.TextChanged
        Dim SqlUsuarios As String
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter

        SqlUsuarios = "SELECT  IdCama, NombreCama, Niveles, Activa FROM Cama WHERE (IdCama = '" & Me.CboCodigoCama.Text & "')"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlUsuarios, MiConexion)
        DataAdapter.Fill(DataSet, "BuscaCamas")
        If Not DataSet.Tables("BuscaCamas").Rows.Count = 0 Then

            If Not IsDBNull(DataSet.Tables("BuscaCamas").Rows(0)("NombreCama")) Then
                Me.TxtCama.Text = DataSet.Tables("BuscaCamas").Rows(0)("NombreCama")
            End If

            If Not IsDBNull(DataSet.Tables("BuscaCamas").Rows(0)("Niveles")) Then
                Me.TxtNiveles.Text = DataSet.Tables("BuscaCamas").Rows(0)("Niveles")
            End If

            If Not IsDBNull(DataSet.Tables("BuscaCamas").Rows(0)("Activa")) Then
                Me.CheckActivo.Checked = DataSet.Tables("BuscaCamas").Rows(0)("Activa")
            End If
        Else
            Me.TxtCama.Text = ""
            Me.TxtNiveles.Text = ""
            Me.CheckActivo.Checked = True
        End If
    End Sub

    Private Sub TxtNiveles_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNiveles.KeyPress
        'e.Handled = Not IsNumeric(e.KeyChar)
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub C1Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button2.Click
        Dim Codigocama As String
        Quien = "CamaBusqueda"
        My.Forms.FrmConsultas.Text = "Consulta Cama"
        My.Forms.FrmConsultas.ShowDialog()
        If My.Forms.FrmConsultas.Codigo <> "- - - - - 0 - - - - -" Then
            Me.CboCodigoCama.Text = FrmConsultas.Codigo
        End If
    End Sub
    Private Sub Limpiar()
        Dim SqlUsuarios As String
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        SqlUsuarios = "SELECT IdCama, NombreCama, Niveles, Activa  FROM Cama"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlUsuarios, MiConexion)
        DataAdapter.Fill(DataSet, "ListaCama")
        If Not DataSet.Tables("ListaCama").Rows.Count = 0 Then
            Me.CboCodigoCama.DataSource = DataSet.Tables("ListaCama")
        End If

        Me.CboCodigoCama.Text = ""
        Me.TxtCama.Text = ""
        Me.TxtNiveles.Text = ""
        Me.CheckActivo.Checked = True
    End Sub

    Private Sub ButtonNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNuevo.Click

    End Sub

    Private Sub ButtonGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGrabar.Click
        Dim StrCamas As String, SqlUsuarios As String
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim StrSqlUpdate As String, ComandoUpdate As New SqlClient.SqlCommand, iResultado As Integer
        Dim Tipo As String

        StrCamas = "SELECT IdCama, NombreCama, Niveles, Activa   FROM  Cama   WHERE (IdCama = '" & Me.CboCodigoCama.Text & "')"
        DataAdapter = New SqlClient.SqlDataAdapter(StrCamas, MiConexion)
        DataAdapter.Fill(DataSet, "Camas")

        If Not DataSet.Tables("Camas").Rows.Count = 0 Then
            '///////////SI EXISTE EL USUARIO LO ACTUALIZO////////////////
            StrSqlUpdate = "UPDATE [dbo].[Cama] SET [NombreCama] = '" & Me.TxtCama.Text & "'  ,[Niveles] = '" & Me.TxtNiveles.Text & "'   ,[Activa] = '" & Me.CheckActivo.Checked & "'" & _
                           "WHERE [IdCama] = '" & Me.CboCodigoCama.Text & "' "
            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(StrSqlUpdate, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            If iResultado = 1 Then
                MsgBox("Actalizado con exito", MsgBoxStyle.Information, "Camas")
                Limpiar()
            End If
            MiConexion.Close()
        Else
            '/////////SI NO EXISTE LO AGREGO COMO NUEVO/////////////////
            'Nivel = Me.TxtNivel.Text
            StrSqlUpdate = "INSERT INTO [dbo].[Cama]([NombreCama] ,[Niveles] ,[Activa])" & _
                           "VALUES('" & Me.TxtCama.Text & "','" & Me.TxtNiveles.Text & "','" & Me.CheckActivo.Checked & "')"
            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(StrSqlUpdate, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            If iResultado = 1 Then
                MsgBox("Guardado con exito", MsgBoxStyle.Information, "Camas")
                Limpiar()
            End If
            MiConexion.Close()
        End If
    End Sub


    Private Sub ButtonBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBorrar.Click
        Dim strusuario As String, SqlUsuarios As String
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Dim StrSqlUpdate As String, ComandoUpdate As New SqlClient.SqlCommand, iResultado As Integer
        Dim Resultado As String

        Resultado = MsgBox("¿Esta Seguro de Eliminar esta cama?", MsgBoxStyle.OkCancel, "Camas")
        If Not Resultado = "1" Then
            Exit Sub
        End If

        strusuario = "SELECT IdCama, NombreCama, Niveles, Activa  FROM Cama   WHERE (IdCama = '" & Me.CboCodigoCama.Text & "')"
        DataAdapter = New SqlClient.SqlDataAdapter(strusuario, MiConexion)
        DataAdapter.Fill(DataSet, "Usuario")
        If Not DataSet.Tables("Usuario").Rows.Count = 0 Then
            '///////////SI EXISTE EL USUARIO LO ACTUALIZO////////////////
            StrSqlUpdate = "DELETE FROM [Cama] " & _
                           "WHERE [IdCama] = '" & Me.CboCodigoCama.Text & "' "
            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(StrSqlUpdate, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            If iResultado = 0 Then
                MsgBox("La cama se elimino correctamente", MsgBoxStyle.Information, "Camas")
            End If
            MiConexion.Close()
        End If

        SqlUsuarios = "SELECT IdCama, NombreCama, Niveles, Activa  FROM Cama"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlUsuarios, MiConexion)
        DataAdapter.Fill(DataSet, "ListaCama")
        If Not DataSet.Tables("ListaCama").Rows.Count = 0 Then
            Me.CboCodigoCama.DataSource = DataSet.Tables("ListaCama")
        End If
        Limpiar()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Close()
    End Sub
End Class