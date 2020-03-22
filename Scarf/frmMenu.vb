Public Class frmMenu
    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sLocation = "Menu"
    End Sub

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
End Class