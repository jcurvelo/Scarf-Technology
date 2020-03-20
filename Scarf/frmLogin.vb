Public Class frmLogin
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If txtUsuario.Text = "admin" Then
            If txtClave.Text = "tiburoncin" Then
                frmMenu.Visible = True
                Me.Visible = False
            Else
                MessageBox.Show("Error en la clave")
            End If
        Else
            MessageBox.Show("Error en el usuario")
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
