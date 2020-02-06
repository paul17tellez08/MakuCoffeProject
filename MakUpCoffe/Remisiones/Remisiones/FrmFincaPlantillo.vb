Public Class FrmFincaPlantillo
    Public MiConexion As New SqlClient.SqlConnection(Conexion)
    Public StrSqlUpdate As String, ComandoUpdate As New SqlClient.SqlCommand, iResultado As Integer, StrSqlInsert As String, StrSqlSelect As String
    Public DataSet As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter, Llamada As String
    Private Sub FrmFincaPlantillo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim DataSet As New DataSet
        Dim ColumVariedad As New DataGridViewComboBoxColumn()
        Dim DataSet1 As New DataSet, DataAdapter1 As New SqlClient.SqlDataAdapter

        If Llamada = "RecepcionFincas" Then
            Me.ButtonBorrar.Enabled = False
            Me.ButtonBorrar.Visible = False
            Me.BtnAgregarProductor.Enabled = False
            Me.BtnAgregarProductor.Visible = False
        End If

        StrSqlSelect = "SELECT  IdProductor, Nombre_Proveedor + ' ' + Apellido_Proveedor AS Nombre   FROM  Proveedor"
        DataAdapter = New SqlClient.SqlDataAdapter(StrSqlSelect, MiConexion)
        DataAdapter.Fill(DataSet, "ListaProveedores")
        Me.CboProductor.DataSource = DataSet.Tables("ListaProveedores")
        Me.CboProductor.DisplayMember = "Nombre"

        StrSqlSelect = "SELECT IdComarca, Comarca  FROM  Comarca"
        DataAdapter = New SqlClient.SqlDataAdapter(StrSqlSelect, MiConexion)
        DataAdapter.Fill(DataSet, "ListaComarcas")
        Me.CboComarca.DataSource = DataSet.Tables("ListaComarcas")
        Me.CboComarca.Splits.Item(0).DisplayColumns(0).Visible = False

        CargarFincas()
        LimpiarPantalla()

    End Sub
    Private Sub CargarFincas()

        Dim DataSet As New DataSet
        Dim ColumVariedad As New DataGridViewComboBoxColumn()
        Dim DataAdapter1 As New SqlClient.SqlDataAdapter

        StrSqlSelect = "SELECT   IdFinca,NomFinca  FROM   Finca   WHERE   (Activo = 1)   ORDER BY IdFinca DESC"
        DataAdapter = New SqlClient.SqlDataAdapter(StrSqlSelect, MiConexion)
        DataAdapter.Fill(DataSet, "ListaFinca")
        Me.CboFinca.DataSource = DataSet.Tables("ListaFinca")
        If Not DataSet.Tables("ListaFinca").Rows.Count = 0 Then
            If Not IsDBNull(DataSet.Tables("ListaFinca").Rows(0)("NomFinca")) Then
                Me.CboFinca.Text = DataSet.Tables("ListaFinca").Rows(0)("NomFinca")
            End If
        End If
        Me.CboFinca.Splits.Item(0).DisplayColumns(0).Visible = False
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
    Private Sub LimpiarPantalla()
        Me.CboFinca.Text = ""
        Me.TxtAltitud.Text = ""
        Me.TxtEmbalaje.Text = ""
        Me.TxtNotasCata.Text = ""
        Me.CboProductor.Text = ""
        Me.CboComarca.Text = ""
        Me.DgvPlantillos.Rows.Clear()
    End Sub

    Private Sub BtnAgregarProductor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Forms.FrmProveedores.ShowDialog()
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        My.Forms.FrmConsultas.ShowDialog()
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub ButtonGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGuardar.Click
        Dim Count As Integer = DgvPlantillos.Rows.Count, i As Integer = 0, CodigoFinca As Integer
        Dim DataSet1 As New DataSet, DataAdapter1 As New SqlClient.SqlDataAdapter

        StrSqlSelect = "SELECT  IdFinca, IdProductor, NomFinca, IdComarca, Altitud, NotasdeCata, Emblaje, FechaActualizacion FROM Finca WHERE (IdFinca = N'" & Me.CboFinca.SelectedValue & "')"
        DataAdapter1 = New SqlClient.SqlDataAdapter(StrSqlSelect, MiConexion)
        DataAdapter1.Fill(DataSet1, "DatosFincas2")

        If DataSet1.Tables("DatosFincas2").Rows.Count = 0 Then
            StrSqlInsert = " INSERT INTO [dbo].[Finca]([IdProductor],[NomFinca],[IdComarca],[Altitud],[NotasdeCata],[Emblaje],[FechaActualizacion],Activo) " & _
                   " VALUES ('" & Me.CboProductor.SelectedValue & "','" & Me.CboFinca.Text & "','" & Me.CboComarca.SelectedValue & "','" & Me.TxtAltitud.Text & "','" & Me.TxtNotasCata.Text & "','" & Me.TxtEmbalaje.Text & "','" & Format(Now, "dd/MM/yyyy") & "','" & CheckActivo.Checked & "')"
            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(StrSqlInsert, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery

            If iResultado = 1 Then
                MsgBox("FINCA GUARDADA CON EXITO", MsgBoxStyle.Exclamation, "Finca")
                StrSqlSelect = "SELECT IdFinca, Activo   FROM Finca  WHERE (Activo = 1)ORDER BY IdFinca DESC"
                DataAdapter = New SqlClient.SqlDataAdapter(StrSqlSelect, MiConexion)
                DataAdapter.Fill(DataSet, "ListaFincaDESC")
                If Not DataSet.Tables("ListaFincaDESC").Rows.Count = 0 Then
                    CodigoFinca = DataSet.Tables("ListaFincaDESC").Rows(0)("IdFinca")
                Else
                    MsgBox("ALGO SALIO MAL ASEGURESE QUE LA INFORMACION ESTA CORRECTA, CONTACTESE CON SOPORTE", MsgBoxStyle.Exclamation, "Finca")
                End If
            End If
            MiConexion.Close()
        Else
            StrSqlUpdate = "UPDATE [dbo].[Finca] SET [IdProductor] = '" & Me.CboProductor.SelectedValue & "'  ,[NomFinca] ='" & Me.CboFinca.Text & "' ,[IdComarca] ='" & Me.CboComarca.SelectedValue & "',[Altitud] = '" & Me.TxtAltitud.Text & "' ,[NotasdeCata] ='" & Me.TxtNotasCata.Text & "',[Emblaje] ='" & Me.TxtEmbalaje.Text & "',[FechaActualizacion] ='" & Format(Now, "dd/MM/yyyy") & "',[Activo]='" & Me.CheckActivo.Checked & "'   WHERE   (IdFinca = '" & Me.CboFinca.SelectedValue & "') "
            MiConexion.Open()
            ComandoUpdate = New SqlClient.SqlCommand(StrSqlUpdate, MiConexion)
            iResultado = ComandoUpdate.ExecuteNonQuery
            MiConexion.Close()
            If iResultado = 1 Then
                MsgBox("FINCA ACTULIZADA CON EXITO", MsgBoxStyle.Exclamation, "Finca")
                CodigoFinca = Me.CboFinca.SelectedValue
            Else
                MsgBox("ALGO SALIO MAL ASEGURESE QUE LA INFORMACION ESTA CORRECTA, CONTACTESE CON SOPORTE", MsgBoxStyle.Exclamation, "Finca")
            End If
        End If


        Do While Count > i
            If Me.DgvPlantillos.Rows(i).Cells(0).Value = 0 Then
                StrSqlInsert = " INSERT INTO [dbo].[Plantillo]([Plantillo] ,[IdFinca],[IdVariedad],[Activo])" & _
               " VALUES ('" & Me.DgvPlantillos.Rows(i).Cells(1).Value & "','" & CodigoFinca & "',1,1)"
                MiConexion.Open()
                ComandoUpdate = New SqlClient.SqlCommand(StrSqlInsert, MiConexion)
                iResultado = ComandoUpdate.ExecuteNonQuery
                MiConexion.Close()
            Else
                StrSqlUpdate = " UPDATE [dbo].[Plantillo] SET [Plantillo] ='" & Me.DgvPlantillos.Rows(i).Cells(1).Value & "'  ,[IdFinca] = '" & CodigoFinca & "'  ,[IdVariedad] = 1  ,[Activo] = 1  WHERE  (IdPlantillo = '" & Me.DgvPlantillos.Rows(i).Cells(0).Value & "')"
                MiConexion.Open()
                ComandoUpdate = New SqlClient.SqlCommand(StrSqlUpdate, MiConexion)
                iResultado = ComandoUpdate.ExecuteNonQuery
                MiConexion.Close()
            End If
            i = i + 1
        Loop
        If Llamada = "RecepcionFincas" Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtCodfinca_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub CboFinca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboFinca.TextChanged
        Dim i As Integer = 0

        Dim DataSet As New DataSet
        Dim ColumVariedad As New DataGridViewComboBoxColumn()
        Dim DataAdapter1 As New SqlClient.SqlDataAdapter

        StrSqlSelect = "SELECT  IdFinca, IdProductor, NomFinca, IdComarca, Altitud, NotasdeCata, Emblaje, FechaActualizacion,Activo    FROM Finca WHERE (NomFinca = N'" & Me.CboFinca.Text & "')"
        DataAdapter = New SqlClient.SqlDataAdapter(StrSqlSelect, MiConexion)
        DataAdapter.Fill(DataSet, "DatosFincas")
        If Not DataSet.Tables("DatosFincas").Rows.Count = 0 Then
            Me.LbPlantillo.Text = "Plantillos de la Finca : " & Me.CboFinca.Text & ""

            If Not IsDBNull(DataSet.Tables("DatosFincas").Rows(0)("IdProductor")) Then
                Me.CboProductor.SelectedValue = DataSet.Tables("DatosFincas").Rows(0)("IdProductor")
            End If

            If Not IsDBNull(DataSet.Tables("DatosFincas").Rows(0)("IdComarca")) Then
                Me.CboComarca.SelectedValue = DataSet.Tables("DatosFincas").Rows(0)("IdComarca")
            End If

            If Not IsDBNull(DataSet.Tables("DatosFincas").Rows(0)("Altitud")) Then
                Me.TxtAltitud.Text = DataSet.Tables("DatosFincas").Rows(0)("Altitud")
            End If

            If Not IsDBNull(DataSet.Tables("DatosFincas").Rows(0)("NotasdeCata")) Then
                Me.TxtNotasCata.Text = DataSet.Tables("DatosFincas").Rows(0)("NotasdeCata")
            End If

            If Not IsDBNull(DataSet.Tables("DatosFincas").Rows(0)("Emblaje")) Then
                Me.TxtEmbalaje.Text = DataSet.Tables("DatosFincas").Rows(0)("Emblaje")
            End If

            If Not IsDBNull(DataSet.Tables("DatosFincas").Rows(0)("Activo")) Then
                Me.CheckActivo.Checked = DataSet.Tables("DatosFincas").Rows(0)("Activo")
            End If

            If Not IsDBNull(DataSet.Tables("DatosFincas").Rows(0)("IdFinca")) Then
                StrSqlSelect = "SELECT  IdPlantillo, Plantillo, IdFinca, IdVariedad, Activo    FROM    Plantillo   WHERE    (IdFinca = '" & DataSet.Tables("DatosFincas").Rows(0)("IdFinca") & "') AND (Activo = 1)"
                DataAdapter = New SqlClient.SqlDataAdapter(StrSqlSelect, MiConexion)
                DataAdapter.Fill(DataSet, "DatosPlatillos")
                If Not DataSet.Tables("DatosPlatillos").Rows.Count = 0 Then
                    Do While DataSet.Tables("DatosPlatillos").Rows.Count > i
                        DgvPlantillos.Rows.Add()
                        Me.DgvPlantillos.Rows(i).Cells(0).Value = DataSet.Tables("DatosPlatillos").Rows(i)("IdPlantillo")
                        Me.DgvPlantillos.Rows(i).Cells(1).Value = DataSet.Tables("DatosPlatillos").Rows(i)("Plantillo")
                        i = i + 1
                    Loop
                Else
                    Me.DgvPlantillos.Rows.Clear()
                End If
            End If
        Else
            Me.CboProductor.SelectedValue = 0
            Me.CboComarca.SelectedValue = 0
            Me.TxtAltitud.Text = ""
            Me.TxtNotasCata.Text = ""
            Me.TxtEmbalaje.Text = ""
            Me.CheckActivo.Checked = True
        End If
    End Sub

    Private Sub CmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdNuevo.Click
        LimpiarPantalla()
    End Sub
End Class