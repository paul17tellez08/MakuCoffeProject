Public Class FrmComarMunici
    Public MiConexion As New SqlClient.SqlConnection(Conexion)
    Public StrSqlUpdate As String, ComandoUpdate As New SqlClient.SqlCommand, iResultado As Integer, StrSqlInsert As String
    Private Sub FrmComarMunici_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Sql As String = "SELECT    IdDepartamento, Departamento  FROM Departamentos "
        Dim DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter(Sql, MiConexion)
        DataAdapter.Fill(DataSet, "ListaDepartamento")
        Me.CboDepartamento.DisplayMember = "Departamento"
        Me.CboDepartamento.DataSource = DataSet.Tables("ListaDepartamento")
        'Me.CboDepartamento.SelectedValue = DataSet.Tables("ListaDepartamento").Rows(DataSet.Tables("ListaDepartamento").Rows.Count - 1)("IdDepartamento")
        Me.CboDepartamento.Splits.Item(0).DisplayColumns(0).Visible = False
        Me.CboDepartamento.Text = "SELECCIONE"
    End Sub
    Private Sub CboDepartamento_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboDepartamento.SelectedValueChanged
        Dim SqlString As String, texto As String
        Dim Dataset As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        'Dim aList As New List(Of String)(New String() {""})
        'Me.CboMunicipio.DataSource = aList

        Me.CboMunicipio.DataSource = Nothing
        SqlString = "SELECT  IdMunicipio, Municipio, IdDepartamento  FROM  Municipio  WHERE (IdDepartamento = '" & Me.CboDepartamento.SelectedValue & "')AND (Activo = 1) "
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(Dataset, "Municipio")
        DgvComarcas.Rows.Clear()
        ' Me.CboMunicipio.ResetText()

        If Dataset.Tables("Municipio").Rows.Count = 0 Then
            MsgBox("No existen municipios para este departamento", MsgBoxStyle.Exclamation, "Municipios y Comarcas")
            Me.CboMunicipio.Text = "NO MUNICIPIO"
            Exit Sub
        Else
            Me.CboMunicipio.Text = "SELECCIONE"
            Me.CboMunicipio.DataSource = Dataset.Tables("Municipio")
            'Me.CboMunicipio.SelectedValue = Dataset.Tables("Municipio").Rows(0)("IdMunicipio")
            Me.CboMunicipio.Splits.Item(0).DisplayColumns(0).Visible = False
            Me.CboMunicipio.Splits.Item(0).DisplayColumns(2).Visible = False
            Me.CboMunicipio.Splits.Item(0).DisplayColumns(0).Width = 30
            Me.CboMunicipio.Splits.Item(0).DisplayColumns(1).Width = 150
            Me.CboMunicipio.Text = "SELECCIONE"
        End If
    End Sub
    Private Sub CboMunicipio_SelectedValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboMunicipio.SelectedValueChanged
        Dim SqlString As String
        Dim Dataset As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter, Registros As Integer, i As Integer
        SqlString = "SELECT  Comarca.IdComarca,Comarca.Comarca, Comarca.Activo FROM  Comarca INNER JOIN Municipio ON Comarca.IdMunicipio = Municipio.IdMunicipio WHERE  (Comarca.IdMunicipio = '" & Me.CboMunicipio.SelectedValue & "')AND (Comarca.Activo = 1)"
        DataAdapter = New SqlClient.SqlDataAdapter(SqlString, MiConexion)
        DataAdapter.Fill(Dataset, "ListaComarca")
        Registros = Dataset.Tables("ListaComarca").Rows.Count
        DgvComarcas.Rows.Clear()
        If CboMunicipio.Text = "SELECCIONE" Then
            Exit Sub
        Else
            If Registros = 0 Then
                MsgBox("No Existen comarcas para este municipio", MsgBoxStyle.Exclamation, "Municipios y Comarcas")
                Exit Sub
            Else
                Me.BinListComarca.DataSource = Dataset.Tables("ListaComarca")
                Do While Registros > i
                    DgvComarcas.Rows.Add(Me.BinListComarca.Item(i)("IdComarca"), Me.BinListComarca.Item(i)("Comarca"), Me.BinListComarca.Item(i)("Activo"))
                    i = i + 1
                Loop
            End If
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnArriba.Click
        'Dim PosicionInicial As Integer
        'PosicionInicial = DgvComarcas.CurrentRow.Index()
        'If PosicionInicial = 0 Then

        '    MsgBox("ESTE ES EL LIMITE SUPERIOR", MsgBoxStyle.Critical, "Municipios y Comarcas")
        'Else
        '    DgvComarcas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        '    DgvComarcas.CurrentCell = DgvComarcas.Rows(PosicionInicial - 1).Cells(0)
        'End If
    End Sub

    Private Sub BtnAbajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAbajo.Click
        'Dim PosicionInicial As Integer
        'PosicionInicial = DgvComarcas.CurrentRow.Index()
        'If PosicionInicial = DgvComarcas.Rows.Count - 1 Then
        '    MsgBox("ESTE ES EL LIMITE INFERIOR", MsgBoxStyle.Critical, "Municipios y Comarcas")
        'Else
        '    DgvComarcas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        '    DgvComarcas.CurrentCell = DgvComarcas.Rows(PosicionInicial + 1).Cells(0)
        'End If
    End Sub
    Private Sub BtnNuevaFila_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevaFila.Click
        'Dim temp_string As String = "0,"
        'Dim temp_Array() As String = temp_string.Split(",")
        'DgvComarcas.Rows.Add(temp_Array)
        'DgvComarcas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        'DgvComarcas.CurrentCell = DgvComarcas.Rows(DgvComarcas.Rows.Count - 1).Cells(0)
        'Me.DgvComarcas.Rows(DgvComarcas.CurrentRow.Index()).Cells(2).Value = 1
    End Sub

    Private Sub BtnEliminarfila_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminarfila.Click
        'Dim result As DialogResult = MessageBox.Show("Desea eliminar esta comarca?", "Comarcas", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'If (result = MsgBoxResult.Yes) Then
        '    If Me.DgvComarcas.Rows(DgvComarcas.CurrentRow.Index()).Cells(0).Value = 0 Then
        '        Me.DgvComarcas.Rows.RemoveAt(DgvComarcas.CurrentRow.Index())
        '    Else
        '        StrSqlUpdate = " UPDATE [dbo].[Comarca] SET [Activo] = 0 WHERE (IdComarca = '" & Me.DgvComarcas.Rows.Item(DgvComarcas.CurrentRow.Index()).Cells("CodComarca").Value & "')"
        '        MiConexion.Open()
        '        ComandoUpdate = New SqlClient.SqlCommand(StrSqlUpdate, MiConexion)
        '        iResultado = ComandoUpdate.ExecuteNonQuery
        '        MiConexion.Close()
        '        Me.DgvComarcas.Rows.RemoveAt(DgvComarcas.CurrentRow.Index())
        '    End If
        'End If
   End Sub
    Private Sub ButtonGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGuardar.Click
        Dim Count As Integer, i As Integer
        Count = Me.DgvComarcas.Rows.Count

        If Me.CboMunicipio.SelectedValue = Nothing Then
            StrSqlInsert = "INSERT INTO [dbo].[Municipio]([Municipio],[IdDepartamento],[Activo])" & _
                          " VALUES ('" & Me.CboMunicipio.Text & "','" & Me.CboDepartamento.SelectedValue & "',1)"
            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(StrSqlInsert, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            MiConexion.Close()
        Else
            StrSqlUpdate = " UPDATE [dbo].[Municipio] SET [Municipio] = '" & Me.CboMunicipio.Text & "',[IdDepartamento] = '" & Me.CboDepartamento.SelectedValue & "',[Activo] = 1  WHERE (IdMunicipio = '" & Me.CboMunicipio.SelectedValue & "')"
            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(StrSqlUpdate, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            MiConexion.Close()
        End If

        Do While Count - 1 > i
            If Me.DgvComarcas.Rows(DgvComarcas.CurrentRow.Index()).Cells(0).Value = 0 Then
                Me.DgvComarcas.Rows.RemoveAt(DgvComarcas.CurrentRow.Index())
                StrSqlInsert = " INSERT INTO [dbo].[Comarca]([Comarca],[IdMunicipio],[Activo]) " & _
               " VALUES ('" & Me.DgvComarcas.Rows(i).Cells(1).Value & "','" & Me.CboMunicipio.SelectedValue & "','" & Me.DgvComarcas.Rows(i).Cells(2).Value & "')"
                MiConexion.Close()
                MiConexion.Open()
                ComandoUpdate = New SqlClient.SqlCommand(StrSqlInsert, MiConexion)
                iResultado = ComandoUpdate.ExecuteNonQuery
                MiConexion.Close()
                'MsgBox("REMISION GUARDADA CON EXITO", MsgBoxStyle.Exclamation, "Remision")
            Else
                StrSqlUpdate = " UPDATE [dbo].[Comarca] SET [Activo] = 0 WHERE (IdComarca = '" & Me.DgvComarcas.Rows.Item(DgvComarcas.CurrentRow.Index()).Cells("CodComarca").Value & "')"
                MiConexion.Open()
                ComandoUpdate = New SqlClient.SqlCommand(StrSqlUpdate, MiConexion)
                iResultado = ComandoUpdate.ExecuteNonQuery
                MiConexion.Close()
                Me.DgvComarcas.Rows.RemoveAt(DgvComarcas.CurrentRow.Index())
            End If
            i = i + 1
        Loop
    End Sub

    Private Sub BtnEliminarMuni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminarMuni.Click

        Dim result As DialogResult = MessageBox.Show("Desea eliminar este Municipio?", "Municipio", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = MsgBoxResult.Yes) Then

            If Not Me.CboMunicipio.Text = "NO MUNICIPIO" Or Me.CboMunicipio.Text = "SELECCIONE" Then
                StrSqlUpdate = " UPDATE [dbo].[Municipio] SET [Municipio] = '" & Me.CboMunicipio.Text & "',[IdDepartamento] = '" & Me.CboDepartamento.SelectedValue & "',[Activo] = 0  WHERE (IdMunicipio = '" & Me.CboMunicipio.SelectedValue & "')"
                MiConexion.Open()
                ComandoUpdate = New SqlClient.SqlCommand(StrSqlUpdate, MiConexion)
                iResultado = ComandoUpdate.ExecuteNonQuery
                MiConexion.Close()
                NuevaComarca()
            End If
        End If
    End Sub
    Public Sub NuevaComarca()
        Me.CboDepartamento.Text = "SELECCIONE"
        Me.CboMunicipio.Text = ""
        DgvComarcas.Rows.Clear()
    End Sub

    Private Sub CmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdNuevo.Click
        NuevaComarca()
    End Sub
End Class