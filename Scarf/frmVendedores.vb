Imports MySql.Data.MySqlClient

Public Class frmVendedores
    Dim codigo, nombre, apellido, sexo, edoCivil, cargo, cedula, tlf, correo, celular, direccion, ciudad, estado As String

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVendDireccion.TextChanged

    End Sub

    Private Sub frmVendedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnVendActualizar.Visible = False
        btnVendGrabar.Visible = False
        btnVendEliminar.Visible = False

        fFormularios.fOcultar(Me, False)

        txtVendCodigo.Enabled = True

        If sLocation = "Vendedores-Grabar" Then
            btnVendGrabar.Visible = True
        ElseIf sLocation = "Vendedores-Actualizar" Then
            btnVendActualizar.Visible = True
        ElseIf sLocation = "Vendedores-Eliminar" Then
            btnVendEliminar.Visible = True
        End If
    End Sub

    Private Sub lblCodigo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCodigo.Click

    End Sub

    Private Sub lblDescripcion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDescripcion.Click

    End Sub

    Private Sub lblPrecio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPrecio.Click

    End Sub

    Private Sub lblActual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblActual.Click

    End Sub

    Private Sub lblMinimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMinimo.Click

    End Sub

    Private Sub lblMaximo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMaximo.Click

    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVendSexo.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVendCorreo.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVendApellido.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVendNombre.TextChanged

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVendCiudad.TextChanged

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVendEstado.TextChanged

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVendTfl.TextChanged

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub TextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVendEdoCivil.TextChanged

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
                '    Dim codigo, nombre, apellido, edoCivil, cargo, cedula, tlf, correo, celular, direccion, ciudad, estado As String

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

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVendCargo.TextChanged

    End Sub

    Private Sub TextBox12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVendCedula.TextChanged

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub TextBox13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVendCelular.TextChanged

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub TextBox14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox15_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVendCodigo.TextChanged

    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        sLocation = "Menu"
        frmMenu.Visible = True
        Me.Close()
    End Sub
End Class