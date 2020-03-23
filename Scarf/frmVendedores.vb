Imports MySql.Data.MySqlClient '<- SI NO SE LLAMA NADA SIRVE

Public Class frmVendedores
    'VARIABLES PARA LOS DATOS
    Dim codigo, nombre, apellido, sexo, edoCivil, cargo, cedula, tlf, correo, celular, direccion, ciudad, estado As String

    'SE CARGA EL FORMULARIO
    Private Sub frmVendedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'INVISIBLE LOS BOTONES
        btnVendActualizar.Visible = False
        btnVendGrabar.Visible = False
        btnVendEliminar.Visible = False

        'DESHABILITA LOS DATOS!
        fFormularios.fOcultar(Me, False)

        'PERO HABILITA ETE QUE TA QUI
        txtVendCodigo.Enabled = True

        'HABILITAMOS EL BOTON QUE CORRESPONDE A LA OPCIÓN SELECCIONADA
        If sLocation = "Vendedores-Grabar" Then
            btnVendGrabar.Visible = True
        ElseIf sLocation = "Vendedores-Actualizar" Then
            btnVendActualizar.Visible = True
        ElseIf sLocation = "Vendedores-Eliminar" Then
            btnVendEliminar.Visible = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        fConexionBD.fConexionBD()
        Try
            sSqlConsultar = "SELECT * FROM vendedores WHERE codigo_vendedor=" & txtVendCodigo.Text & ";"

            cmdConsultar = New MySqlCommand
            cmdConsultar.Connection = fConexionBD.sConexionBD
            cmdConsultar.CommandText = sSqlConsultar
            cmdConsultar.CommandType = CommandType.Text

            idrConsultaSqlConsultar = cmdConsultar.ExecuteReader()

            While idrConsultaSqlConsultar.Read()

                codigo = idrConsultaSqlConsultar("codigo_vendedor")
                nombre = idrConsultaSqlConsultar("nombres_vendedor")
                apellido = idrConsultaSqlConsultar("apellidos_vendedor")
                sexo = idrConsultaSqlConsultar("sexo_vendedor")
                edoCivil = idrConsultaSqlConsultar("edo_civil_vendedor")
                cargo = idrConsultaSqlConsultar("cargo_vendedor")
                cedula = idrConsultaSqlConsultar("cedula_usuario")
                tlf = idrConsultaSqlConsultar("tlf_vendedor")
                correo = idrConsultaSqlConsultar("email_vendedor")
                celular = idrConsultaSqlConsultar("celular_vendedor")
                direccion = idrConsultaSqlConsultar("direccion_vendedor")
                ciudad = idrConsultaSqlConsultar("ciudad_vendedor")
                estado = idrConsultaSqlConsultar("estado_vendedor")
            End While
            If codigo = txtVendCodigo.Text And sLocation IsNot "Vendedores-Grabar" Then
                    txtVendCodigo.Text = codigo
                    txtVendNombre.Text = nombre
                    txtVendApellido.Text = apellido
                    txtVendSexo.Text = sexo
                    txtVendEdoCivil.Text = edoCivil
                    txtVendCargo.Text = cargo
                    txtVendCedula.Text = cedula
                    txtVendTfl.Text = tlf
                    txtVendCorreo.Text = correo
                    txtVendCelular.Text = celular
                    txtVendDireccion.Text = direccion
                    txtVendCiudad.Text = ciudad
                    txtVendEstado.Text = estado

                    If sLocation = "Vendedores-Actualizar" Then
                        fFormularios.fOcultar(Me, True)
                    End If
                ElseIf sLocation = "Vendedores-Grabar" Then
                    If txtVendCodigo.Text = codigo Then
                        MessageBox.Show("Vendedor ya registrado")
                    Else
                        MessageBox.Show("Codigo Disponible")
                        fFormularios.fOcultar(Me, True)
                    End If
                Else
                    MessageBox.Show("Vendedor no encontrado")
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
End Class