Public Class FrmFincaPlantillo
    Public MiConexion As New SqlClient.SqlConnection(Conexion)
    Public StrSqlUpdate As String, ComandoUpdate As New SqlClient.SqlCommand, iResultado As Integer, StrSqlInsert As String, StrSqlSelect As String
    Public DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
    Public Buscado As Boolean = False

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub BtnArriba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnArriba.Click
        Dim PosicionInicial As Integer
        If Not Me.DgvPlantillos.Rows.Count = 0 Then
            PosicionInicial = Me.DgvPlantillos.CurrentRow.Index()
            If PosicionInicial = 0 Then
                MsgBox("ESTE ES EL LIMITE SUPERIOR", MsgBoxStyle.Critical, "Municipios y Comarcas")
            Else
                DgvPlantillos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                DgvPlantillos.CurrentCell = DgvPlantillos.Rows(PosicionInicial - 1).Cells(0)
            End If
        End If
    End Sub

    Private Sub BtnAbajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboProductor.ValueMemberChanged, BtnAbajo.Click

        Dim PosicionInicial As Integer
        If Me.DgvPlantillos.Rows.Count > 0 Then
            PosicionInicial = DgvPlantillos.CurrentRow.Index()
        Else
            Exit Sub
        End If

        If PosicionInicial = DgvPlantillos.Rows.Count - 1 Then
            MsgBox("ESTE ES EL LIMITE INFERIOR", MsgBoxStyle.Critical, "Municipios y Comarcas")
        Else
            DgvPlantillos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DgvPlantillos.CurrentCell = DgvPlantillos.Rows(PosicionInicial + 1).Cells(0)
        End If
    End Sub

    Private Sub BtnNuevaFila_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevaFila.Click
        Dim temp_string As String = "0,"
        Dim temp_Array() As String = temp_string.Split(",")
        

        DgvPlantillos.Rows.Add(temp_Array)
        DgvPlantillos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgvPlantillos.CurrentCell = DgvPlantillos.Rows(DgvPlantillos.Rows.Count - 1).Cells(0)
        Me.DgvPlantillos.Rows(DgvPlantillos.CurrentRow.Index()).Cells(2).Value = 1
    End Sub

    Private Sub BtnEliminarfila_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminarfila.Click
        If Me.DgvPlantillos.Rows.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("Desea eliminar esta comarca?", "Comarcas", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (result = MsgBoxResult.Yes) Then
                If Me.DgvPlantillos.Rows(DgvPlantillos.CurrentRow.Index()).Cells(0).Value = 0 Then
                    Me.DgvPlantillos.Rows.RemoveAt(DgvPlantillos.CurrentRow.Index())
                Else
                    StrSqlUpdate = " UPDATE [dbo].[Comarca] SET [Activo] = 0 WHERE (IdComarca = '" & Me.DgvPlantillos.Rows.Item(DgvPlantillos.CurrentRow.Index()).Cells("CodComarca").Value & "')"
                    MiConexion.Open()
                    ComandoUpdate = New SqlClient.SqlCommand(StrSqlUpdate, MiConexion)
                    iResultado = ComandoUpdate.ExecuteNonQuery
                    MiConexion.Close()
                    Me.DgvPlantillos.Rows.RemoveAt(DgvPlantillos.CurrentRow.Index())
                End If
            End If
        End If

    End Sub

    Private Sub TxtCodfinca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCodfinca.TextChanged
        'If Buscado = False Then
        '    If Me.TxtCodfinca.Text = "" Then
        '        BuscaFinca("0", 1)
        '    Else
        '        BuscaFinca(Me.TxtCodfinca.Text, 1)
        '    End If
        'End If
    End Sub

    Private Sub BuscaFinca(ByVal IdFinca As String, ByVal Tipo As Integer)
        Dim i As Integer = 0
        Buscado = True
        StrSqlSelect = "SELECT  IdFinca, IdProductor, NomFinca, IdComarca, Altitud, NotasdeCata, Emblaje, FechaActualizacion FROM Finca WHERE (IdFinca = '" & IdFinca & "')"
        DataAdapter = New SqlClient.SqlDataAdapter(StrSqlSelect, MiConexion)
        DataAdapter.Fill(DataSet, "DatosFincas")

        If DataSet.Tables("DatosFincas").Rows.Count = 0 Then
            LimpiarPantalla()
        Else

            If Tipo = 1 Then
                Me.CboFinca.SelectedValue = CInt(Me.TxtCodfinca.Text)
            ElseIf (Tipo = 2) Then
                Me.TxtCodfinca.Text = CStr(Me.CboFinca.SelectedValue)
            End If
            Me.CboProductor.SelectedValue = DataSet.Tables("DatosFincas").Rows(0)("IdProductor")
            Me.CboComarca.SelectedValue = DataSet.Tables("DatosFincas").Rows(0)("IdComarca")
            Me.TxtAltitud.Text = DataSet.Tables("DatosFincas").Rows(0)("Altitud")
            Me.TxtNotasCata.Text = DataSet.Tables("DatosFincas").Rows(0)("NotasdeCata")
            Me.TxtEmbalaje.Text = DataSet.Tables("DatosFincas").Rows(0)("Emblaje")


            StrSqlSelect = "SELECT  IdPlantillo, Plantillo, IdFinca, IdVariedad, Activo    FROM    Plantillo   WHERE    (IdFinca = '" & IdFinca & "') AND (Activo = 1)"
            DataAdapter = New SqlClient.SqlDataAdapter(StrSqlSelect, MiConexion)
            DataAdapter.Fill(DataSet, "DatosPlatillos")

            If DataSet.Tables("DatosPlatillos").Rows.Count = 0 Then

            Else
                Do While DataSet.Tables("DatosPlatillos").Rows.Count > i

                    DgvPlantillos.Rows.Add()
                    Me.DgvPlantillos.Rows(i).Cells(0).Value = DataSet.Tables("DatosPlatillos").Rows(i)("IdPlantillo")
                    Me.DgvPlantillos.Rows(i).Cells(1).Value = DataSet.Tables("DatosPlatillos").Rows(i)("Plantillo")
                    Me.DgvPlantillos.Rows(i).Cells(2).Value = DataSet.Tables("DatosPlatillos").Rows(i)("IdVariedad")

                    i = i + 1
                Loop

            End If




            Buscado = False
        End If
        DataSet.Tables("DatosFincas").Reset()
    End Sub
    Private Sub FrmFincaPlantillo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim DataSet As New DataSet
        Dim ColumVariedad As New DataGridViewComboBoxColumn()
        Dim DataSet1 As New DataSet, DataAdapter1 As New SqlClient.SqlDataAdapter


        StrSqlSelect = "SELECT  IdProductor, Nombre_Proveedor + ' ' + Apellido_Proveedor AS Nombre   FROM  Proveedor"
        DataAdapter = New SqlClient.SqlDataAdapter(StrSqlSelect, MiConexion)
        DataAdapter.Fill(DataSet, "ListaProveedores")
        Me.CboProductor.DataSource = DataSet.Tables("ListaProveedores")
        Me.CboProductor.Splits.Item(0).DisplayColumns(0).Visible = False

        StrSqlSelect = "SELECT IdComarca, Comarca  FROM  Comarca"
        DataAdapter = New SqlClient.SqlDataAdapter(StrSqlSelect, MiConexion)
        DataAdapter.Fill(DataSet, "ListaComarcas")
        Me.CboComarca.DataSource = DataSet.Tables("ListaComarcas")
        Me.CboComarca.Splits.Item(0).DisplayColumns(0).Visible = False
        Me.CboComarca.Text = "SELECCIONE"

        StrSqlSelect = "SELECT IdFinca,NomFinca FROM Finca"
        DataAdapter = New SqlClient.SqlDataAdapter(StrSqlSelect, MiConexion)
        DataAdapter.Fill(DataSet, "ListaFinca")
        Me.CboFinca.DataSource = DataSet.Tables("ListaFinca")
        Me.CboFinca.Splits.Item(0).DisplayColumns(0).Visible = False
        Me.CboFinca.Text = "SELECCIONE"

        StrSqlSelect = "SELECT IdVariedad, Variedad  FROM  Variedad"
        DataAdapter1 = New SqlClient.SqlDataAdapter(StrSqlSelect, MiConexion)
        DataAdapter1.Fill(DataSet1, "ListaVariedad")
        ColumVariedad.DataSource = DataSet1.Tables("ListaVariedad")
        ColumVariedad.Name = "Variedad"
        ColumVariedad.DisplayMember = "Variedad"
        ColumVariedad.ValueMember = "IdVariedad"
        Me.DgvPlantillos.Columns.Add(ColumVariedad)


    End Sub

    Private Sub LimpiarPantalla()
        Me.TxtAltitud.Text = ""
        Me.TxtEmbalaje.Text = ""
        Me.TxtNotasCata.Text = ""
        Me.CboProductor.Text = "SELECCIONE"
        Me.CboComarca.Text = "SELECCIONE"
        'Me.CboFinca.Text = ""
        Buscado = False
    End Sub

    Private Sub BtnAgregarProductor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Forms.FrmProveedores.ShowDialog()
    End Sub

    Private Sub BtnArriba_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        My.Forms.FrmConsultas.ShowDialog()
    End Sub

    Private Sub DgvPlantillos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvPlantillos.CellContentClick

    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub ButtonGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGuardar.Click

        Dim Count As Integer = DgvPlantillos.Rows.Count, i As Integer = 0
        Dim DataSet1 As New DataSet, DataAdapter1 As New SqlClient.SqlDataAdapter
        StrSqlSelect = "SELECT  IdFinca, IdProductor, NomFinca, IdComarca, Altitud, NotasdeCata, Emblaje, FechaActualizacion FROM Finca WHERE (IdFinca = '" & CboFinca.SelectedValue & "')"
        DataAdapter1 = New SqlClient.SqlDataAdapter(StrSqlSelect, MiConexion)
        DataAdapter1.Fill(DataSet1, "DatosFincas2")


        If DataSet1.Tables("DatosFincas2").Rows.Count = 0 Then
            StrSqlInsert = " INSERT INTO [dbo].[Finca]([IdProductor],[NomFinca]  ,[IdComarca],[Altitud] ,[NotasdeCata]   ,[Emblaje],[FechaActualizacion],Activo) " & _
                   " VALUES ('" & Me.CboProductor.SelectedValue & "','" & Me.CboFinca.Text & "','" & Me.CboComarca.SelectedValue & "','" & Me.TxtAltitud.Text & "','" & Me.TxtNotasCata.Text & "','" & Me.TxtEmbalaje.Text & "','" & Format(Now, "dd/MM/yyyy") & "',1)"
            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(StrSqlInsert, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            If iResultado = 1 Then
                MsgBox("FINCA GUARDADA CON EXITO", MsgBoxStyle.Exclamation, "Remision")
            Else
                MsgBox("ALGO SALIO MAL ASEGURESE QUE LA INFORMACION ESTA CORRECTA, CONTACTESE CON SOPORTE", MsgBoxStyle.Exclamation, "Remision")
            End If
            MiConexion.Close()
        Else
            StrSqlUpdate = "UPDATE [dbo].[Finca] SET [IdProductor] = '" & Me.CboProductor.SelectedValue & "'  ,[NomFinca] ='" & Me.CboFinca.Text & "' ,[IdComarca] ='" & Me.CboComarca.SelectedValue & "',[Altitud] = '" & Me.TxtAltitud.Text & "' ,[NotasdeCata] ='" & Me.TxtNotasCata.Text & "',[Emblaje] ='" & Me.TxtEmbalaje.Text & "',[FechaActualizacion] ='" & Format(Now, "dd/MM/yyyy") & "',[Activo]=1   WHERE   (IdFinca = '" & Me.TxtCodfinca.Text & "') "
            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(StrSqlUpdate, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            MiConexion.Close()
            MsgBox("FINCA ACTULIZADA CON EXITO", MsgBoxStyle.Exclamation, "Remision")
        End If

        StrSqlSelect = "SELECT IdFinca, IdProductor, NomFinca, IdComarca, Altitud, NotasdeCata, Emblaje, FechaActualizacion, Activo  FROM Finca  ORDER BY IdFinca DESC"
        DataAdapter = New SqlClient.SqlDataAdapter(StrSqlSelect, MiConexion)
        DataAdapter.Fill(DataSet, "ListaFincaDESC")

        Do While Count > i
            If Me.DgvPlantillos.Rows(i).Cells(0).Value = 0 Then
                StrSqlInsert = " INSERT INTO [dbo].[Plantillo]([Plantillo] ,[IdFinca],[IdVariedad],[Activo])" & _
               " VALUES ('" & Me.DgvPlantillos.Rows(i).Cells(1).Value & "','" & DataSet.Tables("ListaFincaDESC").Rows(0)("IdFinca") & "','" & Me.DgvPlantillos.Rows(i).Cells(2).Value & "',1)"
                MiConexion.Open()
                ComandoUpdate = New SqlClient.SqlCommand(StrSqlInsert, MiConexion)
                iResultado = ComandoUpdate.ExecuteNonQuery
                MiConexion.Close()
                'MsgBox("REMISION GUARDADA CON EXITO", MsgBoxStyle.Exclamation, "Remision")
            Else
                StrSqlUpdate = " UPDATE [dbo].[Plantillo] SET [Plantillo] ='" & Me.DgvPlantillos.Rows(i).Cells(1).Value & "'  ,[IdFinca] = '" & DataSet.Tables("ListaFincaDESC").Rows(0)("IdFinca") & "'  ,[IdVariedad] ='" & Me.DgvPlantillos.Rows(i).Cells(2).Value & "'  ,[Activo] = 1  WHERE  (IdPlantillo = '" & Me.DgvPlantillos.Rows(i).Cells(0).Value & "')"
                MiConexion.Open()
                ComandoUpdate = New SqlClient.SqlCommand(StrSqlUpdate, MiConexion)
                iResultado = ComandoUpdate.ExecuteNonQuery
                MiConexion.Close()
                Me.DgvPlantillos.Rows.RemoveAt(DgvPlantillos.CurrentRow.Index())
            End If
            i = i + 1
        Loop
    End Sub

    Private Sub CboFinca_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboFinca.SelectedValueChanged
        If Buscado = False Then
            BuscaFinca(CStr(Me.CboFinca.SelectedValue), 2)
        End If
    End Sub

    Private Sub TxtCodfinca_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodfinca.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub CboFinca_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboFinca.KeyPress
        'If (e.KeyChar = (Convert.ToChar(Keys.Enter))) Then

        'End If
    End Sub
End Class