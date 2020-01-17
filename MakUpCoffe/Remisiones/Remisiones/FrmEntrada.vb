Public Class FrmEntrada
    Public MiConexion As New SqlClient.SqlConnection
    Private Sub FrmEntrada_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim fileReader As String, Ruta As String
        Dim Dataset As New DataSet, DataAdapter As New SqlClient.SqlDataAdapter
        Ruta = My.Application.Info.DirectoryPath & "\SysInfo.txt"
        fileReader = My.Computer.FileSystem.ReadAllText(Ruta)
        Conexion = fileReader
        MiConexion = New SqlClient.SqlConnection(Conexion)

        '////////////////////Declaro las Consultas a Utilizar/////////////////////////////////////////////////
        Dim strSQL As String = "SELECT Usuario FROM Usuarios"

        '/////////////////////////Declaro las variables de Conexion//////////////////////////////////////// 
        Dim DRUsuarios As SqlClient.SqlDataReader
        Dim DTUsuarios As New DataTable
        Dim CmUsuarios As SqlClient.SqlCommand

        '///////////////////Establecemos Conexion con la Base de Datos///////////////////////////////////////
        CmUsuarios = New SqlClient.SqlCommand(strSQL, MiConexion)

        '////////////////Abrimos Conexion con la Base de Datos////////////////////////////
        MiConexion.Open()

        '///////Ejecutamos la Sentencias SQL////////////////////////////////////////////
        DRUsuarios = CmUsuarios.ExecuteReader()

        '///////Cargamos los Resultados en el Objeto Table////////////////////////////////////////
        DTUsuarios.Load(DRUsuarios, LoadOption.OverwriteChanges)
        Me.CboUsuario.DataSource = DTUsuarios
        CmUsuarios = Nothing

        If DTUsuarios.Rows.Count = 0 Then
            Me.Hide()
            My.Forms.MDIParent1.ShowDialog()
            Me.Close()
        End If
        MiConexion.Close()
    End Sub

    Private Sub cmdEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FrmEntrada_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        'cmdEntrar.PerformClick()
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If (e.KeyChar = (Convert.ToChar(Keys.Enter))) Then
            PictureBox1_Click_1(sender, e)
        End If
    End Sub

    Private Sub CboUsuario_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboUsuario.KeyPress
        If (e.KeyChar = (Convert.ToChar(Keys.Enter))) Then
            PictureBox1_Click_1(sender, e)
        End If
    End Sub

    Private Sub PicSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicSalir.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim DataSetUsuario As New DataSet
        Dim DataAdapterUsuario As New SqlClient.SqlDataAdapter
        Dim SqlUsuario As String
        Dim Contraseña As String, Usuario As String, BDContraseña As String, NivelUsuario As String
        Dim BodegaUsuario As String, TipoFactura As String, TipoFacturaUsu As String, CodVendedorUsu As String
        Dim CodClienteUsu As String, SerieFacturaUsu As String

        If Me.CboUsuario.Text = "" Then
            MsgBox("Seleccione un Usuario", MsgBoxStyle.Critical, "Sistema Facturacion")
            Exit Sub
        End If

        If Not Me.txtPassword.Text = "" Then
            Contraseña = Me.txtPassword.Text
            Usuario = Me.CboUsuario.Text
            NombreUsuario = Me.CboUsuario.Text

            MiConexion.Open()
            SqlUsuario = "SELECT Usuario, Contraseña, Nivel, Bodega, TipoFactura, CodVendedor, CodCliente, SerieFactura FROM Usuarios  WHERE (Usuario = '" & Usuario & "')"

            DataAdapterUsuario = New SqlClient.SqlDataAdapter(SqlUsuario, MiConexion)
            DataAdapterUsuario.Fill(DataSetUsuario, "Usuarios")
            If Not DataSetUsuario.Tables("Usuarios").Rows.Count = 0 Then

                BDContraseña = DataSetUsuario.Tables("Usuarios").Rows(0)("Contraseña")
                NivelUsuario = DataSetUsuario.Tables("Usuarios").Rows(0)("Nivel")
                BodegaUsuario = DataSetUsuario.Tables("Usuarios").Rows(0)("Bodega")
                TipoFacturaUsu = DataSetUsuario.Tables("Usuarios").Rows(0)("TipoFactura")
                CodVendedorUsu = DataSetUsuario.Tables("Usuarios").Rows(0)("CodVendedor")
                CodClienteUsu = DataSetUsuario.Tables("Usuarios").Rows(0)("CodCliente")
                SerieFacturaUsu = DataSetUsuario.Tables("Usuarios").Rows(0)("SerieFactura")

                If BDContraseña = Contraseña Then
                    MiConexion.Close()
                    Me.Hide()
                    My.Forms.MDIParent1.ShowDialog()
                    Me.Close()
                Else
                    MsgBox("Contraseña Incorrecta", MsgBoxStyle.Exclamation, "Sistema Facturacion")
                    MiConexion.Close()
                    Exit Sub
                End If
            End If
            MiConexion.Close()
        Else
            MsgBox("Digite la Contraseña", MsgBoxStyle.Critical, "Sistema Facturacion")
            Exit Sub
        End If
    End Sub

    Private Sub PictureBox1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseHover
        PictureBox1.Image = My.Resources.buttonpress()
        Label5.BackColor = Color.FromArgb(88, 47, 47)
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Image = My.Resources.buttonlog()
        Label5.BackColor = Color.FromArgb(61, 30, 30)
    End Sub

    Private Sub PicSalir_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicSalir.MouseHover
        PicSalir.Image = My.Resources.buttonpress()
        Label4.BackColor = Color.FromArgb(88, 47, 47)
    End Sub

    Private Sub PicSalir_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicSalir.MouseLeave
        PicSalir.Image = My.Resources.buttonlog()
        Label4.BackColor = Color.FromArgb(61, 30, 30)
    End Sub

    Private Sub Label5_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.MouseHover
        PictureBox1.Image = My.Resources.buttonpress()
        Label5.BackColor = Color.FromArgb(88, 47, 47)
    End Sub
    Private Sub Label5_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.MouseLeave
        PictureBox1.Image = My.Resources.buttonlog()
        Label5.BackColor = Color.FromArgb(61, 30, 30)
    End Sub
    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        PictureBox1_Click_1(sender, e)
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Me.Close()
    End Sub

    Private Sub Label4_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.MouseHover
        PicSalir.Image = My.Resources.buttonpress()
        Label4.BackColor = Color.FromArgb(88, 47, 47)
    End Sub

    Private Sub Label4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.MouseLeave
        PicSalir.Image = My.Resources.buttonlog()
        Label4.BackColor = Color.FromArgb(61, 30, 30)
    End Sub
End Class