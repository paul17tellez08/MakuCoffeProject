Public Class FrmPuertos

    Private Sub FrmPuertos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lista.Items.Clear()
        consola.Text = ""

        For Each s As String In My.Computer.Ports.SerialPortNames
            lista.Items.Add(s)
        Next
    End Sub

    Private Sub lista_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lista.SelectedIndexChanged
        Try

            FrmRecepcion.sp.Close()
            consola.AppendText("Puerto " & FrmRecepcion.sp.PortName & " Cerrado" & vbCrLf)
            FrmRecepcion.sp.PortName = lista.SelectedItem
            consola.AppendText("Abriendo Puerto : " & FrmRecepcion.sp.PortName & vbCrLf)
            FrmRecepcion.sp.Open()
            'sp3.Open()
            'consola.AppendText("Puerto : " & sp.PortName & " Abierto" & vbCrLf)
            FrmRecepcion.LblEstado.Text = "CONECTADO"
            FrmRecepcion.LblEstado.ForeColor = Color.Brown
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FrmRecepcion.LblEstado.Text = "DESCONECT"
            FrmRecepcion.LblEstado.ForeColor = Color.Black
        End Try
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Me.Close()
    End Sub

    Sub mostar(ByVal d As String)
        Dim Cadena As String, Pesada As Double
        'FrmPuertos.consola.AppendText("El Puerto 3 Recibe : " & d)
        Cadena = Mid(d, 4, 10)
        Pesada = CDbl(Cadena)
        'Me.TrueDBGridComponentes.Columns(3).Text = Pesada
    End Sub

    Private Sub consola_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles consola.TextChanged

    End Sub
End Class