Imports MySql.Data.MySqlClient

Public Class frmClientes
    Dim nombre, apellido, sexo, edoCivil, cedula, tlf, correo, celular, direccion, ciudad, estado As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        fConexionBD.fConexionBD()
        Try
            sSqlConsultar = "SELECT * FROM clientes WHERE cedula_cliente=" & txtCliCedula.Text & ";"

            cmdConsultar = New MySqlCommand
            cmdConsultar.Connection = fConexionBD.sConexionBD
            cmdConsultar.CommandText = sSqlConsultar
            cmdConsultar.CommandType = CommandType.Text

            idrConsultaSqlConsultar = cmdConsultar.ExecuteReader()

            While idrConsultaSqlConsultar.Read()
                '    Dim codigo, nombre, apellido, edoCivil, cargo, cedula, tlf, correo, celular, direccion, ciudad, estado As String

                nombre = idrConsultaSqlConsultar("nombres_cliente")
                apellido = idrConsultaSqlConsultar("apellidos_cliente")
                sexo = idrConsultaSqlConsultar("sexo_cliente")
                edoCivil = idrConsultaSqlConsultar("edo_civil_cliente")
                cedula = idrConsultaSqlConsultar("cedula_cliente")
                tlf = idrConsultaSqlConsultar("tlf_cliente")
                correo = idrConsultaSqlConsultar("email_cliente")
                celular = idrConsultaSqlConsultar("celular_cliente")
                direccion = idrConsultaSqlConsultar("direccion_cliente")
                ciudad = idrConsultaSqlConsultar("ciudad_cliente")
                estado = idrConsultaSqlConsultar("estado_cliente")
            End While
            If cedula = txtCliCedula.Text And sLocation IsNot "Clientes-Grabar" Then
                txtCliNombre.Text = nombre
                txtCliApellido.Text = apellido
                txtCliSexo.Text = sexo
                txtCliEdoCivil.Text = edoCivil
                txtCliCedula.Text = cedula
                txtCliTlf.Text = tlf
                txtCliCorreo.Text = correo
                txtCliCelular.Text = celular
                txtCliDireccion.Text = direccion
                txtCliCiudad.Text = ciudad
                txtCliEstado.Text = estado

                If sLocation = "Clientes-Actualizar" Then
                    fFormularios.fOcultar(Me, True)
                End If
            ElseIf sLocation = "Clientes-Grabar" Then
                If txtCliCedula.Text = cedula Then
                    MessageBox.Show("Cliente ya registrado")
                Else
                    fFormularios.fOcultar(Me, True)
                End If
            Else
                MessageBox.Show("Cliente no encontrado")
            End If

        Catch ex As MySqlException
            MessageBox.Show("Error!" & ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        sLocation = "Menu"
        frmMenu.Visible = True
        Me.Close()
    End Sub

    Private Sub frmClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnCliActualizar.Visible = False
        btnCliGrabar.Visible = False
        btnCliEliminar.Visible = False

        fFormularios.fOcultar(Me, False)

        txtCliCedula.Enabled = True

        If sLocation = "Clientes-Grabar" Then
            btnCliGrabar.Visible = True
        ElseIf sLocation = "Clientes-Actualizar" Then
            btnCliActualizar.Visible = True
        ElseIf sLocation = "Clientes-Eliminar" Then
            btnCliEliminar.Visible = True
        End If
    End Sub
End Class