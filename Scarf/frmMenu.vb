Public Class frmMenu
    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sLocation = "Menu"
    End Sub
    '-----------------------------------------------------------------------------
    '-----------------------------------------------------------------------------
    '----------------------------------Productos----------------------------------
    '-----------------------------------------------------------------------------
    '-----------------------------------------------------------------------------
    Private Sub btnProdConsult_Click(sender As Object, e As EventArgs) Handles btnProdConsult.Click
        sLocation = "Productos-Consultar"
        frmProductos.Visible = True
        Me.Visible = False
    End Sub

    Private Sub btnProdAgr_Click(sender As Object, e As EventArgs) Handles btnProdAgr.Click
        sLocation = "Productos-Grabar"
        frmProductos.Visible = True
        Me.Visible = False
    End Sub

    Private Sub btnProdModif_Click(sender As Object, e As EventArgs) Handles btnProdModif.Click
        sLocation = "Productos-Actualizar"
        frmProductos.Visible = True
        Me.Visible = False
    End Sub

    Private Sub btnProdElim_Click(sender As Object, e As EventArgs) Handles btnProdElim.Click
        sLocation = "Productos-Eliminar"
        frmProductos.Visible = True
        Me.Visible = False
    End Sub
    '-----------------------------------------------------------------------------
    '-----------------------------------------------------------------------------
    '----------------------------------Vendedores---------------------------------
    '-----------------------------------------------------------------------------
    '-----------------------------------------------------------------------------
    Private Sub btnVendConsult_Click(sender As Object, e As EventArgs) Handles btnVendConsult.Click
        sLocation = "Vendedores-Consultar"
        frmVendedores.Visible = True
        Me.Visible = False
    End Sub

    Private Sub btnVendAgr_Click(sender As Object, e As EventArgs) Handles btnVendAgr.Click
        sLocation = "Vendedores-Grabar"
        frmVendedores.Visible = True
        Me.Visible = False
    End Sub

    Private Sub btnVendModif_Click(sender As Object, e As EventArgs) Handles btnVendModif.Click
        sLocation = "Vendedores-Actualizar"
        frmVendedores.Visible = True
        Me.Visible = False
    End Sub

    Private Sub btnVendElim_Click(sender As Object, e As EventArgs) Handles btnVendElim.Click
        sLocation = "Vendedores-Eliminar"
        frmVendedores.Visible = True
        Me.Visible = False
    End Sub
    '-----------------------------------------------------------------------------
    '-----------------------------------------------------------------------------
    '----------------------------------Clientes-----------------------------------
    '-----------------------------------------------------------------------------
    '-----------------------------------------------------------------------------
    Private Sub btnClientConsult_Click(sender As Object, e As EventArgs) Handles btnClientConsult.Click
        sLocation = "Clientes-Consultar"
        frmClientes.Visible = True
        Me.Visible = False
    End Sub

    Private Sub btnClientAgr_Click(sender As Object, e As EventArgs) Handles btnClientAgr.Click
        sLocation = "Clientes-Grabar"
        frmClientes.Visible = True
        Me.Visible = False
    End Sub

    Private Sub btnClientModif_Click(sender As Object, e As EventArgs) Handles btnClientModif.Click
        sLocation = "Clientes-Actualizar"
        frmClientes.Visible = True
        Me.Visible = False
    End Sub

    Private Sub btnClientElim_Click(sender As Object, e As EventArgs) Handles btnClientElim.Click
        sLocation = "Clientes-Eliminar"
        frmClientes.Visible = True
        Me.Visible = False
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        frmLogin.Visible = True
        Me.Visible = False
    End Sub
End Class
