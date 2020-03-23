Imports MySql.Data.MySqlClient

Public Class frmProductos

    Dim codigo, descripcion, precio, existenciaAcutal, stockMinimo, stockMaximo As String

    Private Sub frmProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnConsultActu.Visible = False
        btnConsultGrab.Visible = False
        btnConsultElim.Visible = False

        fFormularios.fOcultar(Me, False)

        txtConsultCodigo.Enabled = True

        If sLocation = "Productos-Grabar" Then
            btnConsultGrab.Visible = True
        ElseIf sLocation = "Productos-Actualizar" Then
            btnConsultActu.Visible = True
        ElseIf sLocation = "Productos-Eliminar" Then
            btnConsultElim.Visible = True
        End If
    End Sub

    Private Sub btnProdConsult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProdConsult.Click
        fConexionBD.fConexionBD()
        Try
            sSqlConsultar = "SELECT * FROM productos WHERE codigo_producto='" & txtConsultCodigo.Text & "';"

            cmdConsultar = New MySqlCommand
            cmdConsultar.Connection = fConexionBD.sConexionBD
            cmdConsultar.CommandText = sSqlConsultar
            cmdConsultar.CommandType = CommandType.Text

            idrConsultaSqlConsultar = cmdConsultar.ExecuteReader()

            While idrConsultaSqlConsultar.Read()
                codigo = idrConsultaSqlConsultar("codigo_producto")
                descripcion = idrConsultaSqlConsultar("descripcion_producto")
                precio = idrConsultaSqlConsultar("precio_producto")
                existenciaAcutal = idrConsultaSqlConsultar("stock_actual_producto")
                stockMinimo = idrConsultaSqlConsultar("stock_minimo_producto")
                stockMaximo = idrConsultaSqlConsultar("stock_maximo_producto")
            End While

            If codigo = txtConsultCodigo.Text And sLocation IsNot "Productos-Grabar" Then
                txtConsultDescripcion.Text = descripcion
                txtConsultPrecio.Text = precio
                txtConsultStockAct.Text = existenciaAcutal
                txtConsultStockMin.Text = stockMinimo
                txtConsultStockMax.Text = stockMaximo

                If sLocation = "Productos-Actualizar" Then
                    fFormularios.fOcultar(Me, True)
                End If
            ElseIf sLocation = "Productos-Grabar" Then
                If txtConsultCodigo.Text = codigo Then
                    MessageBox.Show("Producto ya registrado")
                Else
                    MessageBox.Show("Codigo Disponible")
                    fFormularios.fOcultar(Me, True)
                End If
            Else
                MessageBox.Show("Codigo no encontrado")
            End If
        Catch ex As MySqlException
            MessageBox.Show("Error! " & ex.Message.ToString)
        End Try

    End Sub

    Private Sub btnConsultElim_Click(sender As Object, e As EventArgs) Handles btnConsultElim.Click

    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        sLocation = "Menu"
        frmMenu.Visible = True
        Me.Close()
    End Sub
End Class

'HECHO POR JUAN CURVELO Y ANGEL ARANGUREN!