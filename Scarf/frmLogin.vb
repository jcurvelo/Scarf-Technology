Imports MySql.Data.MySqlClient

Public Class frmLogin
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        fConexionBD.fConexionBD()

        Try
            sSqlLogin = "SELECT * FROM acceso WHERE login_acceso='" & txtUsuario.Text & "' AND clave_acceso='" & txtClave.Text & "';"
            cmdLogin = New MySqlCommand
            cmdLogin.Connection = fConexionBD.sConexionBD
            cmdLogin.CommandText = sSqlLogin
            cmdLogin.CommandType = CommandType.Text

            idrConsultaSqlLogin = cmdLogin.ExecuteReader()
            Dim iNroRegistos As Integer = idrConsultaSqlLogin.RecordsAffected
            While idrConsultaSqlLogin.Read()
                'Se realiza la consulta y se asigna los resultados
                sLogin = idrConsultaSqlLogin("login_acceso")
                sClave = idrConsultaSqlLogin("clave_acceso")
                icodigo_Usuario = idrConsultaSqlLogin("codigo_usuario_usuario")
                sTipo_Usuario = idrConsultaSqlLogin("nivel_acceso")
            End While

            If sLogin = txtUsuario.Text And sClave = txtClave.Text Then
                frmMenu.Visible = True
                Me.Visible = False
            Else
                MessageBox.Show("Datos invalidos. Asegurese de que introduce los datos correctos")
                If txtUsuario.Text = "" Then
                    txtUsuario.Focus()
                Else
                    txtClave.Focus()
                End If
            End If
        Catch ex As MySqlException
            MessageBox.Show("Error! " & ex.Message.ToString)
        End Try

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UsernameLabel_Click(sender As Object, e As EventArgs) Handles UsernameLabel.Click

    End Sub
End Class
