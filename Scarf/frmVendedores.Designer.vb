<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVendedores
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
        Me.txtVendNombre = New System.Windows.Forms.TextBox()
        Me.txtVendApellido = New System.Windows.Forms.TextBox()
        Me.txtVendCorreo = New System.Windows.Forms.TextBox()
        Me.txtVendSexo = New System.Windows.Forms.TextBox()
        Me.txtVendCodigo = New System.Windows.Forms.TextBox()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.lblMinimo = New System.Windows.Forms.Label()
        Me.lblActual = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblMaximo = New System.Windows.Forms.Label()
        Me.txtVendDireccion = New System.Windows.Forms.TextBox()
        Me.txtVendCiudad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtVendTfl = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtVendEstado = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtVendEdoCivil = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtVendCargo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtVendCelular = New System.Windows.Forms.TextBox()
        Me.txtVendCedula = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnVendActualizar = New System.Windows.Forms.Button()
        Me.btnVendEliminar = New System.Windows.Forms.Button()
        Me.btnVendGrabar = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtVendNombre
        '
        Me.txtVendNombre.Location = New System.Drawing.Point(96, 191)
        Me.txtVendNombre.Name = "txtVendNombre"
        Me.txtVendNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtVendNombre.TabIndex = 101
        '
        'txtVendApellido
        '
        Me.txtVendApellido.Location = New System.Drawing.Point(96, 219)
        Me.txtVendApellido.Name = "txtVendApellido"
        Me.txtVendApellido.Size = New System.Drawing.Size(100, 20)
        Me.txtVendApellido.TabIndex = 100
        '
        'txtVendCorreo
        '
        Me.txtVendCorreo.Location = New System.Drawing.Point(349, 217)
        Me.txtVendCorreo.Name = "txtVendCorreo"
        Me.txtVendCorreo.Size = New System.Drawing.Size(100, 20)
        Me.txtVendCorreo.TabIndex = 99
        '
        'txtVendSexo
        '
        Me.txtVendSexo.Location = New System.Drawing.Point(96, 277)
        Me.txtVendSexo.Name = "txtVendSexo"
        Me.txtVendSexo.Size = New System.Drawing.Size(100, 20)
        Me.txtVendSexo.TabIndex = 98
        '
        'txtVendCodigo
        '
        Me.txtVendCodigo.Location = New System.Drawing.Point(96, 143)
        Me.txtVendCodigo.Name = "txtVendCodigo"
        Me.txtVendCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtVendCodigo.TabIndex = 97
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(12, 12)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegresar.TabIndex = 92
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'lblMinimo
        '
        Me.lblMinimo.AutoSize = True
        Me.lblMinimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinimo.Location = New System.Drawing.Point(17, 303)
        Me.lblMinimo.Name = "lblMinimo"
        Me.lblMinimo.Size = New System.Drawing.Size(73, 20)
        Me.lblMinimo.TabIndex = 89
        Me.lblMinimo.Text = "Edo.Civil:"
        '
        'lblActual
        '
        Me.lblActual.AutoSize = True
        Me.lblActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActual.Location = New System.Drawing.Point(38, 275)
        Me.lblActual.Name = "lblActual"
        Me.lblActual.Size = New System.Drawing.Size(49, 20)
        Me.lblActual.TabIndex = 88
        Me.lblActual.Text = "Sexo:"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.Location = New System.Drawing.Point(18, 219)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(69, 20)
        Me.lblPrecio.TabIndex = 87
        Me.lblPrecio.Text = "Apellido:"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(18, 191)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(69, 20)
        Me.lblDescripcion.TabIndex = 86
        Me.lblDescripcion.Text = "Nombre:"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(24, 143)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(63, 20)
        Me.lblCodigo.TabIndex = 85
        Me.lblCodigo.Text = "Código:"
        '
        'lblMaximo
        '
        Me.lblMaximo.AutoSize = True
        Me.lblMaximo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaximo.Location = New System.Drawing.Point(461, 193)
        Me.lblMaximo.Name = "lblMaximo"
        Me.lblMaximo.Size = New System.Drawing.Size(79, 20)
        Me.lblMaximo.TabIndex = 90
        Me.lblMaximo.Text = "Dirección:"
        '
        'txtVendDireccion
        '
        Me.txtVendDireccion.Location = New System.Drawing.Point(549, 193)
        Me.txtVendDireccion.Name = "txtVendDireccion"
        Me.txtVendDireccion.Size = New System.Drawing.Size(100, 20)
        Me.txtVendDireccion.TabIndex = 102
        '
        'txtVendCiudad
        '
        Me.txtVendCiudad.Location = New System.Drawing.Point(549, 221)
        Me.txtVendCiudad.Name = "txtVendCiudad"
        Me.txtVendCiudad.Size = New System.Drawing.Size(100, 20)
        Me.txtVendCiudad.TabIndex = 105
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(479, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "Ciudad:"
        '
        'txtVendTfl
        '
        Me.txtVendTfl.Location = New System.Drawing.Point(349, 191)
        Me.txtVendTfl.Name = "txtVendTfl"
        Me.txtVendTfl.Size = New System.Drawing.Size(100, 20)
        Me.txtVendTfl.TabIndex = 109
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(218, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 20)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "Tlf del vendedor:"
        '
        'txtVendEstado
        '
        Me.txtVendEstado.Location = New System.Drawing.Point(549, 247)
        Me.txtVendEstado.Name = "txtVendEstado"
        Me.txtVendEstado.Size = New System.Drawing.Size(100, 20)
        Me.txtVendEstado.TabIndex = 107
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(476, 247)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 20)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "Estado:"
        '
        'txtVendEdoCivil
        '
        Me.txtVendEdoCivil.Location = New System.Drawing.Point(96, 303)
        Me.txtVendEdoCivil.Name = "txtVendEdoCivil"
        Me.txtVendEdoCivil.Size = New System.Drawing.Size(100, 20)
        Me.txtVendEdoCivil.TabIndex = 111
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(282, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 20)
        Me.Label6.TabIndex = 110
        Me.Label6.Text = "Correo:"
        '
        'txtVendCargo
        '
        Me.txtVendCargo.Location = New System.Drawing.Point(95, 329)
        Me.txtVendCargo.Name = "txtVendCargo"
        Me.txtVendCargo.Size = New System.Drawing.Size(100, 20)
        Me.txtVendCargo.TabIndex = 113
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(33, 329)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 20)
        Me.Label7.TabIndex = 112
        Me.Label7.Text = "Cargo:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(282, 243)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 20)
        Me.Label9.TabIndex = 117
        Me.Label9.Text = "Celular:"
        '
        'txtVendCelular
        '
        Me.txtVendCelular.Location = New System.Drawing.Point(349, 243)
        Me.txtVendCelular.Name = "txtVendCelular"
        Me.txtVendCelular.Size = New System.Drawing.Size(100, 20)
        Me.txtVendCelular.TabIndex = 116
        '
        'txtVendCedula
        '
        Me.txtVendCedula.Location = New System.Drawing.Point(95, 247)
        Me.txtVendCedula.Name = "txtVendCedula"
        Me.txtVendCedula.Size = New System.Drawing.Size(100, 20)
        Me.txtVendCedula.TabIndex = 114
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(28, 245)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 20)
        Me.Label8.TabIndex = 115
        Me.Label8.Text = "Cédula:"
        '
        'btnVendActualizar
        '
        Me.btnVendActualizar.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnVendActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVendActualizar.Location = New System.Drawing.Point(301, 302)
        Me.btnVendActualizar.Name = "btnVendActualizar"
        Me.btnVendActualizar.Size = New System.Drawing.Size(348, 40)
        Me.btnVendActualizar.TabIndex = 168
        Me.btnVendActualizar.Text = "Actualizar"
        Me.btnVendActualizar.UseVisualStyleBackColor = False
        '
        'btnVendEliminar
        '
        Me.btnVendEliminar.BackColor = System.Drawing.Color.Crimson
        Me.btnVendEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVendEliminar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnVendEliminar.Location = New System.Drawing.Point(301, 303)
        Me.btnVendEliminar.Name = "btnVendEliminar"
        Me.btnVendEliminar.Size = New System.Drawing.Size(348, 40)
        Me.btnVendEliminar.TabIndex = 167
        Me.btnVendEliminar.Text = "Eliminar"
        Me.btnVendEliminar.UseVisualStyleBackColor = False
        '
        'btnVendGrabar
        '
        Me.btnVendGrabar.BackColor = System.Drawing.Color.Gold
        Me.btnVendGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVendGrabar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnVendGrabar.Location = New System.Drawing.Point(301, 302)
        Me.btnVendGrabar.Name = "btnVendGrabar"
        Me.btnVendGrabar.Size = New System.Drawing.Size(348, 40)
        Me.btnVendGrabar.TabIndex = 166
        Me.btnVendGrabar.Text = "Grabar"
        Me.btnVendGrabar.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.YellowGreen
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(202, 130)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(104, 40)
        Me.Button5.TabIndex = 169
        Me.Button5.Text = "Consultar"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label1.Location = New System.Drawing.Point(212, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 60)
        Me.Label1.TabIndex = 170
        Me.Label1.Text = "Vendedores"
        '
        'frmVendedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(661, 394)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btnVendActualizar)
        Me.Controls.Add(Me.btnVendEliminar)
        Me.Controls.Add(Me.btnVendGrabar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtVendCelular)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtVendCedula)
        Me.Controls.Add(Me.txtVendCargo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtVendEdoCivil)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtVendTfl)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtVendEstado)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtVendCiudad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtVendDireccion)
        Me.Controls.Add(Me.txtVendNombre)
        Me.Controls.Add(Me.txtVendApellido)
        Me.Controls.Add(Me.txtVendCorreo)
        Me.Controls.Add(Me.txtVendSexo)
        Me.Controls.Add(Me.txtVendCodigo)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.lblMaximo)
        Me.Controls.Add(Me.lblMinimo)
        Me.Controls.Add(Me.lblActual)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblCodigo)
        Me.Name = "frmVendedores"
        Me.Text = "frmVendedores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtVendNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtVendApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtVendCorreo As System.Windows.Forms.TextBox
    Friend WithEvents txtVendSexo As System.Windows.Forms.TextBox
    Friend WithEvents txtVendCodigo As System.Windows.Forms.TextBox
    Friend WithEvents btnRegresar As System.Windows.Forms.Button
    Friend WithEvents lblMinimo As System.Windows.Forms.Label
    Friend WithEvents lblActual As System.Windows.Forms.Label
    Friend WithEvents lblPrecio As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents lblMaximo As System.Windows.Forms.Label
    Friend WithEvents txtVendDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtVendCiudad As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtVendTfl As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtVendEstado As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtVendEdoCivil As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtVendCargo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtVendCelular As System.Windows.Forms.TextBox
    Friend WithEvents txtVendCedula As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnVendActualizar As System.Windows.Forms.Button
    Friend WithEvents btnVendEliminar As System.Windows.Forms.Button
    Friend WithEvents btnVendGrabar As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
