<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtConsultStockMax = New System.Windows.Forms.TextBox()
        Me.txtConsultDescripcion = New System.Windows.Forms.TextBox()
        Me.txtConsultPrecio = New System.Windows.Forms.TextBox()
        Me.txtConsultStockMin = New System.Windows.Forms.TextBox()
        Me.txtConsultStockAct = New System.Windows.Forms.TextBox()
        Me.txtConsultCodigo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnConsultActu = New System.Windows.Forms.Button()
        Me.btnProdConsult = New System.Windows.Forms.Button()
        Me.btnConsultElim = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnConsultGrab = New System.Windows.Forms.Button()
        Me.lblMaximo = New System.Windows.Forms.Label()
        Me.lblMinimo = New System.Windows.Forms.Label()
        Me.lblActual = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtConsultStockMax
        '
        Me.txtConsultStockMax.Location = New System.Drawing.Point(452, 183)
        Me.txtConsultStockMax.Name = "txtConsultStockMax"
        Me.txtConsultStockMax.Size = New System.Drawing.Size(100, 20)
        Me.txtConsultStockMax.TabIndex = 102
        '
        'txtConsultDescripcion
        '
        Me.txtConsultDescripcion.Location = New System.Drawing.Point(145, 185)
        Me.txtConsultDescripcion.Name = "txtConsultDescripcion"
        Me.txtConsultDescripcion.Size = New System.Drawing.Size(100, 20)
        Me.txtConsultDescripcion.TabIndex = 101
        '
        'txtConsultPrecio
        '
        Me.txtConsultPrecio.Location = New System.Drawing.Point(145, 213)
        Me.txtConsultPrecio.Name = "txtConsultPrecio"
        Me.txtConsultPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtConsultPrecio.TabIndex = 100
        '
        'txtConsultStockMin
        '
        Me.txtConsultStockMin.Location = New System.Drawing.Point(452, 234)
        Me.txtConsultStockMin.Name = "txtConsultStockMin"
        Me.txtConsultStockMin.Size = New System.Drawing.Size(100, 20)
        Me.txtConsultStockMin.TabIndex = 99
        '
        'txtConsultStockAct
        '
        Me.txtConsultStockAct.Location = New System.Drawing.Point(452, 208)
        Me.txtConsultStockAct.Name = "txtConsultStockAct"
        Me.txtConsultStockAct.Size = New System.Drawing.Size(100, 20)
        Me.txtConsultStockAct.TabIndex = 98
        '
        'txtConsultCodigo
        '
        Me.txtConsultCodigo.Location = New System.Drawing.Point(144, 128)
        Me.txtConsultCodigo.Name = "txtConsultCodigo"
        Me.txtConsultCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtConsultCodigo.TabIndex = 97
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(146, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(407, 60)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "Consulta Producto"
        '
        'btnConsultActu
        '
        Me.btnConsultActu.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnConsultActu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultActu.Location = New System.Drawing.Point(196, 321)
        Me.btnConsultActu.Name = "btnConsultActu"
        Me.btnConsultActu.Size = New System.Drawing.Size(142, 40)
        Me.btnConsultActu.TabIndex = 95
        Me.btnConsultActu.Text = "Actualizar"
        Me.btnConsultActu.UseVisualStyleBackColor = False
        '
        'btnProdConsult
        '
        Me.btnProdConsult.BackColor = System.Drawing.Color.YellowGreen
        Me.btnProdConsult.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProdConsult.Location = New System.Drawing.Point(250, 115)
        Me.btnProdConsult.Name = "btnProdConsult"
        Me.btnProdConsult.Size = New System.Drawing.Size(104, 33)
        Me.btnProdConsult.TabIndex = 94
        Me.btnProdConsult.Text = "Consultar"
        Me.btnProdConsult.UseVisualStyleBackColor = False
        '
        'btnConsultElim
        '
        Me.btnConsultElim.BackColor = System.Drawing.Color.Crimson
        Me.btnConsultElim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultElim.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnConsultElim.Location = New System.Drawing.Point(440, 322)
        Me.btnConsultElim.Name = "btnConsultElim"
        Me.btnConsultElim.Size = New System.Drawing.Size(143, 40)
        Me.btnConsultElim.TabIndex = 93
        Me.btnConsultElim.Text = "Eliminar"
        Me.btnConsultElim.UseVisualStyleBackColor = False
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(10, 18)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegresar.TabIndex = 92
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'btnConsultGrab
        '
        Me.btnConsultGrab.BackColor = System.Drawing.Color.Gold
        Me.btnConsultGrab.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultGrab.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnConsultGrab.Location = New System.Drawing.Point(26, 355)
        Me.btnConsultGrab.Name = "btnConsultGrab"
        Me.btnConsultGrab.Size = New System.Drawing.Size(143, 40)
        Me.btnConsultGrab.TabIndex = 91
        Me.btnConsultGrab.Text = "Grabar"
        Me.btnConsultGrab.UseVisualStyleBackColor = False
        '
        'lblMaximo
        '
        Me.lblMaximo.AutoSize = True
        Me.lblMaximo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaximo.Location = New System.Drawing.Point(334, 183)
        Me.lblMaximo.Name = "lblMaximo"
        Me.lblMaximo.Size = New System.Drawing.Size(112, 20)
        Me.lblMaximo.TabIndex = 90
        Me.lblMaximo.Text = "Stock Máximo:"
        '
        'lblMinimo
        '
        Me.lblMinimo.AutoSize = True
        Me.lblMinimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinimo.Location = New System.Drawing.Point(337, 237)
        Me.lblMinimo.Name = "lblMinimo"
        Me.lblMinimo.Size = New System.Drawing.Size(108, 20)
        Me.lblMinimo.TabIndex = 89
        Me.lblMinimo.Text = "Stock Mínimo:"
        '
        'lblActual
        '
        Me.lblActual.AutoSize = True
        Me.lblActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActual.Location = New System.Drawing.Point(312, 208)
        Me.lblActual.Name = "lblActual"
        Me.lblActual.Size = New System.Drawing.Size(134, 20)
        Me.lblActual.TabIndex = 88
        Me.lblActual.Text = "Existencia Actual:"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.Location = New System.Drawing.Point(81, 211)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(57, 20)
        Me.lblPrecio.TabIndex = 87
        Me.lblPrecio.Text = "Precio:"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(46, 183)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(96, 20)
        Me.lblDescripcion.TabIndex = 86
        Me.lblDescripcion.Text = "Descripción:"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(75, 126)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(63, 20)
        Me.lblCodigo.TabIndex = 85
        Me.lblCodigo.Text = "Código:"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(564, 384)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(104, 23)
        Me.Button4.TabIndex = 124
        Me.Button4.Text = "Salir"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'frmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(680, 412)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.txtConsultStockMax)
        Me.Controls.Add(Me.txtConsultDescripcion)
        Me.Controls.Add(Me.txtConsultPrecio)
        Me.Controls.Add(Me.txtConsultStockMin)
        Me.Controls.Add(Me.txtConsultStockAct)
        Me.Controls.Add(Me.txtConsultCodigo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnConsultActu)
        Me.Controls.Add(Me.btnProdConsult)
        Me.Controls.Add(Me.btnConsultElim)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnConsultGrab)
        Me.Controls.Add(Me.lblMaximo)
        Me.Controls.Add(Me.lblMinimo)
        Me.Controls.Add(Me.lblActual)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblCodigo)
        Me.Name = "frmProductos"
        Me.Text = "frmProductos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtConsultStockMax As System.Windows.Forms.TextBox
    Friend WithEvents txtConsultDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtConsultPrecio As System.Windows.Forms.TextBox
    Friend WithEvents txtConsultStockMin As System.Windows.Forms.TextBox
    Friend WithEvents txtConsultStockAct As System.Windows.Forms.TextBox
    Friend WithEvents txtConsultCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnConsultActu As System.Windows.Forms.Button
    Friend WithEvents btnProdConsult As System.Windows.Forms.Button
    Friend WithEvents btnConsultElim As System.Windows.Forms.Button
    Friend WithEvents btnRegresar As System.Windows.Forms.Button
    Friend WithEvents btnConsultGrab As System.Windows.Forms.Button
    Friend WithEvents lblMaximo As System.Windows.Forms.Label
    Friend WithEvents lblMinimo As System.Windows.Forms.Label
    Friend WithEvents lblActual As System.Windows.Forms.Label
    Friend WithEvents lblPrecio As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
