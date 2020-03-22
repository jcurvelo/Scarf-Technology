Public Class frmProductos

    Private Sub lbltxtCodigo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub lblCodigo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnConsultActu.Visible = False
        btnConsultGrab.Visible = False
        btnConsultElim.Visible = False

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub

    Private Sub btnConsultElim_Click(sender As Object, e As EventArgs) Handles btnConsultElim.Click

    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        sLocacion = "Menu"
        frmMenu.Visible = True
        Me.Visible = False
    End Sub
End Class