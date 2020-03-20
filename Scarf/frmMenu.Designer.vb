<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mnuOpcionesSistema = New System.Windows.Forms.MenuStrip()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnProdConsult = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnProdAgr = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnProdModif = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnProdElim = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnVendConsult = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnVendAgr = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnVendModif = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnVendElim = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnClientConsult = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnClientAgr = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnClientModif = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnClientElim = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.mnuOpcionesSistema.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuOpcionesSistema
        '
        Me.mnuOpcionesSistema.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.VendedoresToolStripMenuItem, Me.ClientesToolStripMenuItem})
        Me.mnuOpcionesSistema.Location = New System.Drawing.Point(0, 0)
        Me.mnuOpcionesSistema.Name = "mnuOpcionesSistema"
        Me.mnuOpcionesSistema.Size = New System.Drawing.Size(800, 24)
        Me.mnuOpcionesSistema.TabIndex = 0
        Me.mnuOpcionesSistema.Text = "MenuStrip1"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnProdConsult, Me.btnProdAgr, Me.btnProdModif, Me.btnProdElim})
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'VendedoresToolStripMenuItem
        '
        Me.VendedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnVendConsult, Me.btnVendAgr, Me.btnVendModif, Me.btnVendElim})
        Me.VendedoresToolStripMenuItem.Name = "VendedoresToolStripMenuItem"
        Me.VendedoresToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.VendedoresToolStripMenuItem.Text = "Vendedores"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnClientConsult, Me.btnClientAgr, Me.btnClientModif, Me.btnClientElim})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'btnProdConsult
        '
        Me.btnProdConsult.Name = "btnProdConsult"
        Me.btnProdConsult.Size = New System.Drawing.Size(180, 22)
        Me.btnProdConsult.Text = "Consultar"
        '
        'btnProdAgr
        '
        Me.btnProdAgr.Name = "btnProdAgr"
        Me.btnProdAgr.Size = New System.Drawing.Size(180, 22)
        Me.btnProdAgr.Text = "Agregar"
        '
        'btnProdModif
        '
        Me.btnProdModif.Name = "btnProdModif"
        Me.btnProdModif.Size = New System.Drawing.Size(180, 22)
        Me.btnProdModif.Text = "Modificar"
        '
        'btnProdElim
        '
        Me.btnProdElim.Name = "btnProdElim"
        Me.btnProdElim.Size = New System.Drawing.Size(180, 22)
        Me.btnProdElim.Text = "Eliminar"
        '
        'btnVendConsult
        '
        Me.btnVendConsult.Name = "btnVendConsult"
        Me.btnVendConsult.Size = New System.Drawing.Size(180, 22)
        Me.btnVendConsult.Text = "Consultar"
        '
        'btnVendAgr
        '
        Me.btnVendAgr.Name = "btnVendAgr"
        Me.btnVendAgr.Size = New System.Drawing.Size(180, 22)
        Me.btnVendAgr.Text = "Agregar"
        '
        'btnVendModif
        '
        Me.btnVendModif.Name = "btnVendModif"
        Me.btnVendModif.Size = New System.Drawing.Size(180, 22)
        Me.btnVendModif.Text = "Modificar"
        '
        'btnVendElim
        '
        Me.btnVendElim.Name = "btnVendElim"
        Me.btnVendElim.Size = New System.Drawing.Size(180, 22)
        Me.btnVendElim.Text = "Eliminar"
        '
        'btnClientConsult
        '
        Me.btnClientConsult.Name = "btnClientConsult"
        Me.btnClientConsult.Size = New System.Drawing.Size(180, 22)
        Me.btnClientConsult.Text = "Consultar"
        '
        'btnClientAgr
        '
        Me.btnClientAgr.Name = "btnClientAgr"
        Me.btnClientAgr.Size = New System.Drawing.Size(180, 22)
        Me.btnClientAgr.Text = "Agregar"
        '
        'btnClientModif
        '
        Me.btnClientModif.Name = "btnClientModif"
        Me.btnClientModif.Size = New System.Drawing.Size(180, 22)
        Me.btnClientModif.Text = "Modificar"
        '
        'btnClientElim
        '
        Me.btnClientElim.Name = "btnClientElim"
        Me.btnClientElim.Size = New System.Drawing.Size(180, 22)
        Me.btnClientElim.Text = "Eliminar"
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.Location = New System.Drawing.Point(583, 415)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(205, 23)
        Me.btnCerrarSesion.TabIndex = 1
        Me.btnCerrarSesion.Text = "Cerrar Sesión"
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Fugaz One", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lblTitulo.Location = New System.Drawing.Point(98, 164)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(609, 94)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "Scraf Technology"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnCerrarSesion)
        Me.Controls.Add(Me.mnuOpcionesSistema)
        Me.MainMenuStrip = Me.mnuOpcionesSistema
        Me.Name = "frmMenu"
        Me.Text = "frmMenu"
        Me.mnuOpcionesSistema.ResumeLayout(False)
        Me.mnuOpcionesSistema.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuOpcionesSistema As MenuStrip
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnProdConsult As ToolStripMenuItem
    Friend WithEvents btnProdAgr As ToolStripMenuItem
    Friend WithEvents btnProdModif As ToolStripMenuItem
    Friend WithEvents btnProdElim As ToolStripMenuItem
    Friend WithEvents VendedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnVendConsult As ToolStripMenuItem
    Friend WithEvents btnVendAgr As ToolStripMenuItem
    Friend WithEvents btnVendModif As ToolStripMenuItem
    Friend WithEvents btnVendElim As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnClientConsult As ToolStripMenuItem
    Friend WithEvents btnClientAgr As ToolStripMenuItem
    Friend WithEvents btnClientModif As ToolStripMenuItem
    Friend WithEvents btnClientElim As ToolStripMenuItem
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents lblTitulo As Label
End Class
