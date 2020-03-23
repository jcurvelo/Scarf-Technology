Imports MySql.Data.MySqlClient '<-EL AMIGUITO DE SIEMPRE

Public Class frmLogin
    'HACE CLICK EN INGRESAR
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        fConexionBD.fConexionBD() 'LLAMAMOS LA CONEXION

        Try 'INTENTAMOS...

            'EL SQL QUE NECESITAMOS. LLAMAMOS DE UNA VEZ AL USUARIO Y SU CONTRASEÑA
            sSqlLogin = "SELECT * FROM acceso WHERE login_acceso='" & txtUsuario.Text & "' AND clave_acceso='" & txtClave.Text & "';"

            'AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAHHHHHHHHHH
            cmdLogin = New MySqlCommand
            cmdLogin.Connection = fConexionBD.sConexionBD
            cmdLogin.CommandText = sSqlLogin
            cmdLogin.CommandType = CommandType.Text

            'LLAMAMOS AL EJECUTOR DE LA LECTURA. SAAASH, WAAAASH, PLINK *SONIDOS DE ESPADA MATANDO UN LIBRO*
            idrConsultaSqlLogin = cmdLogin.ExecuteReader()

            While idrConsultaSqlLogin.Read() 'MIENTRAS EL AMIGUITO LEE...
                'ASIGNAMOS LOS DATOOOS. LAS VARIABLES ESTAN EN MODVARIABLES ¬_¬
                sLogin = idrConsultaSqlLogin("login_acceso")
                sClave = idrConsultaSqlLogin("clave_acceso")
                iCodigo_Usuario = idrConsultaSqlLogin("codigo_usuario_usuario")
                sTipo_Usuario = idrConsultaSqlLogin("nivel_acceso")
            End While

            'SI ESTA BIEN EL USUARIO Y LA CONTRASEÑA...
            If sLogin = txtUsuario.Text And sClave = txtClave.Text Then
                'LE DAMOS PLAY BABY!
                frmMenu.Visible = True
                Me.Visible = False
            Else 'SI NO...
                MessageBox.Show("Datos invalidos. Asegurese de que introduce los datos correctos")
                If txtUsuario.Text = "" Then
                    txtUsuario.Focus() 'ENFOCAMOS LO QUE PUEDA FALTAR
                Else
                    txtClave.Focus() 'LO DE ARRIBA
                End If
            End If
        Catch ex As MySqlException
            MessageBox.Show("Error! " & ex.Message.ToString) 'POR EL AMOR DE DIOS, QUE NO TENGA QUE SALIR ESTO!
        End Try

    End Sub

    'CLICK EN SALIR
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close() 'CERRAMOS
    End Sub
End Class

'HECHO POR JUAN CURVELO Y ANGEL ARANGUREN!