Imports MySql.Data.MySqlClient '<- SI NO SE LLAMA NADA SIRVE

Public Class frmClientes
    'VARIABLES PARA LOS DATOS
    Dim nombre, apellido, sexo, edoCivil, cedula, tlf, correo, celular, direccion, ciudad, estado As String

    'EL BOTÓN DE CONSULTAAAAAR
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'ESTABLECER CONEXION
        fConexionBD.fConexionBD()
        Try
            'EL SQL QUE SE USARÁ
            sSqlConsultar = "SELECT * FROM clientes WHERE cedula_cliente=" & txtCliCedula.Text & ";"

            'VISUAL BASIC ES RARO
            cmdConsultar = New MySqlCommand
            cmdConsultar.Connection = fConexionBD.sConexionBD
            cmdConsultar.CommandText = sSqlConsultar
            cmdConsultar.CommandType = CommandType.Text

            'LO DE ARRIBA
            idrConsultaSqlConsultar = cmdConsultar.ExecuteReader()

            'ITERAR ENTRE LOS DATOS ENCONTRADOS
            While idrConsultaSqlConsultar.Read()

                'ASIGNAR LOS DATOS A LAS VARIABLES
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

            'VER SI EXISTE Y SI ESTAMOS EN EL MENÚ CORRECTO
            If cedula = txtCliCedula.Text And sLocation IsNot "Clientes-Grabar" Then

                'ASIGNACIOOOOOOOOOOÓN A LOOOOOOOS TEXTBOOOOOOOOX
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

                'AQUI VIENE LO RARO. ESTO ES PARA SABER EN QUÉ OPCIÓN ESTAMOS Y 
                'CAMBIAR EL ESTADO DE LOS TEXTBOX DEPENDIENDO DE ELLO

                If sLocation = "Clientes-Actualizar" Then '¿ESTAMOS EN ACTUALIZAR?
                    fFormularios.fOcultar(Me, True) 'HABILITAMOS LOS TEXTBOX
                End If
            ElseIf sLocation = "Clientes-Grabar" Then '>¿ESTAMOS EN AGREGAR NUEVO CLIENTE?
                If txtCliCedula.Text = cedula Then '>¿YA EXISTE LA CEDULA EN LA BD?
                    MessageBox.Show("Cliente ya registrado") '>PUES PUEDES AGREGAR ALGO QUE YA EXISTE
                Else '>¿QUE NO ES ASÍ?
                    fFormularios.fOcultar(Me, True) '>ORLAE, AGREGA NUEVOS
                End If
            Else
                MessageBox.Show("Cliente no encontrado") '>ESAS SON PURAS MENTIRAS, ESA NOCHE YO NO ANDABA AHÍ
            End If

        Catch ex As MySqlException
            MessageBox.Show("Error!" & ex.Message.ToString) 'SI ESTO LE SALE A UN USUARIO NORMAL ESTARÁ SUPER CONFUNDIDO
        End Try
    End Sub

    'BOTON DE REGRESAR
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        sLocation = "Menu" 'VAMONO AL MENÚ
        frmMenu.Visible = True 'PONLO VISIBLE
        Me.Close() 'Y CERREMOS ESTO
    End Sub

    'CUANDO CARGA EL FORMULARIO. CHAN CHAN CHAAAAAAAAAAAAN
    Private Sub frmClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '---------------PONER INVISIBLE LOS BOTONES---------------
        btnCliActualizar.Visible = False
        btnCliGrabar.Visible = False
        btnCliEliminar.Visible = False

        'DESHABILITAR TEXTBOX
        fFormularios.fOcultar(Me, False)

        'PERO DEJAR SOLO ESTE HABILITADO
        txtCliCedula.Enabled = True

        'MOSTRAR SOLO EL BOTÓN QUE HAGA FALTA
        If sLocation = "Clientes-Grabar" Then
            btnCliGrabar.Visible = True
        ElseIf sLocation = "Clientes-Actualizar" Then
            btnCliActualizar.Visible = True
        ElseIf sLocation = "Clientes-Eliminar" Then
            btnCliEliminar.Visible = True
        End If
    End Sub
End Class

'HECHO POR JUAN CURVELO Y ANGEL ARANGUREN!