<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCliCelular = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCliCedula = New System.Windows.Forms.TextBox()
        Me.txtCliEdoCivil = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCliTlf = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCliEstado = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCliCiudad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCliDireccion = New System.Windows.Forms.TextBox()
        Me.txtCliNombre = New System.Windows.Forms.TextBox()
        Me.txtCliApellido = New System.Windows.Forms.TextBox()
        Me.txtCliCorreo = New System.Windows.Forms.TextBox()
        Me.txtCliSexo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMaximo = New System.Windows.Forms.Label()
        Me.lblMinimo = New System.Windows.Forms.Label()
        Me.lblActual = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnCliActualizar = New System.Windows.Forms.Button()
        Me.btnCliEliminar = New System.Windows.Forms.Button()
        Me.btnCliGrabar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(270, 201)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 20)
        Me.Label9.TabIndex = 154
        Me.Label9.Text = "Celular:"
        '
        'txtCliCelular
        '
        Me.txtCliCelular.Location = New System.Drawing.Point(337, 201)
        Me.txtCliCelular.Name = "txtCliCelular"
        Me.txtCliCelular.Size = New System.Drawing.Size(100, 20)
        Me.txtCliCelular.TabIndex = 153
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(47, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 20)
        Me.Label8.TabIndex = 152
        Me.Label8.Text = "Cedula:"
        '
        'txtCliCedula
        '
        Me.txtCliCedula.Location = New System.Drawing.Point(114, 128)
        Me.txtCliCedula.Name = "txtCliCedula"
        Me.txtCliCedula.Size = New System.Drawing.Size(100, 20)
        Me.txtCliCedula.TabIndex = 151
        '
        'txtCliEdoCivil
        '
        Me.txtCliEdoCivil.Location = New System.Drawing.Point(114, 253)
        Me.txtCliEdoCivil.Name = "txtCliEdoCivil"
        Me.txtCliEdoCivil.Size = New System.Drawing.Size(100, 20)
        Me.txtCliEdoCivil.TabIndex = 148
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(270, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 20)
        Me.Label6.TabIndex = 147
        Me.Label6.Text = "Correo:"
        '
        'txtCliTlf
        '
        Me.txtCliTlf.Location = New System.Drawing.Point(340, 227)
        Me.txtCliTlf.Name = "txtCliTlf"
        Me.txtCliTlf.Size = New System.Drawing.Size(100, 20)
        Me.txtCliTlf.TabIndex = 146
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(256, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 20)
        Me.Label4.TabIndex = 145
        Me.Label4.Text = "Teléfono:"
        '
        'txtCliEstado
        '
        Me.txtCliEstado.Location = New System.Drawing.Point(550, 227)
        Me.txtCliEstado.Name = "txtCliEstado"
        Me.txtCliEstado.Size = New System.Drawing.Size(100, 20)
        Me.txtCliEstado.TabIndex = 144
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(477, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 20)
        Me.Label5.TabIndex = 143
        Me.Label5.Text = "Estado:"
        '
        'txtCliCiudad
        '
        Me.txtCliCiudad.Location = New System.Drawing.Point(549, 200)
        Me.txtCliCiudad.Name = "txtCliCiudad"
        Me.txtCliCiudad.Size = New System.Drawing.Size(100, 20)
        Me.txtCliCiudad.TabIndex = 142
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(477, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 141
        Me.Label2.Text = "Ciudad:"
        '
        'txtCliDireccion
        '
        Me.txtCliDireccion.Location = New System.Drawing.Point(549, 175)
        Me.txtCliDireccion.Name = "txtCliDireccion"
        Me.txtCliDireccion.Size = New System.Drawing.Size(100, 20)
        Me.txtCliDireccion.TabIndex = 139
        '
        'txtCliNombre
        '
        Me.txtCliNombre.Location = New System.Drawing.Point(114, 175)
        Me.txtCliNombre.Name = "txtCliNombre"
        Me.txtCliNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtCliNombre.TabIndex = 138
        '
        'txtCliApellido
        '
        Me.txtCliApellido.Location = New System.Drawing.Point(114, 201)
        Me.txtCliApellido.Name = "txtCliApellido"
        Me.txtCliApellido.Size = New System.Drawing.Size(100, 20)
        Me.txtCliApellido.TabIndex = 137
        '
        'txtCliCorreo
        '
        Me.txtCliCorreo.Location = New System.Drawing.Point(337, 175)
        Me.txtCliCorreo.Name = "txtCliCorreo"
        Me.txtCliCorreo.Size = New System.Drawing.Size(100, 20)
        Me.txtCliCorreo.TabIndex = 136
        '
        'txtCliSexo
        '
        Me.txtCliSexo.Location = New System.Drawing.Point(114, 227)
        Me.txtCliSexo.Name = "txtCliSexo"
        Me.txtCliSexo.Size = New System.Drawing.Size(100, 20)
        Me.txtCliSexo.TabIndex = 135
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(139, -79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 31)
        Me.Label3.TabIndex = 133
        Me.Label3.Text = "Vendedores"
        '
        'lblMaximo
        '
        Me.lblMaximo.AutoSize = True
        Me.lblMaximo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaximo.Location = New System.Drawing.Point(461, 173)
        Me.lblMaximo.Name = "lblMaximo"
        Me.lblMaximo.Size = New System.Drawing.Size(79, 20)
        Me.lblMaximo.TabIndex = 129
        Me.lblMaximo.Text = "Direccion:"
        '
        'lblMinimo
        '
        Me.lblMinimo.AutoSize = True
        Me.lblMinimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinimo.Location = New System.Drawing.Point(35, 253)
        Me.lblMinimo.Name = "lblMinimo"
        Me.lblMinimo.Size = New System.Drawing.Size(73, 20)
        Me.lblMinimo.TabIndex = 128
        Me.lblMinimo.Text = "Edo.Civil:"
        '
        'lblActual
        '
        Me.lblActual.AutoSize = True
        Me.lblActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActual.Location = New System.Drawing.Point(56, 225)
        Me.lblActual.Name = "lblActual"
        Me.lblActual.Size = New System.Drawing.Size(49, 20)
        Me.lblActual.TabIndex = 127
        Me.lblActual.Text = "Sexo:"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.Location = New System.Drawing.Point(36, 201)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(69, 20)
        Me.lblPrecio.TabIndex = 126
        Me.lblPrecio.Text = "Apellido:"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(36, 175)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(69, 20)
        Me.lblDescripcion.TabIndex = 125
        Me.lblDescripcion.Text = "Nombre:"
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(12, 12)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegresar.TabIndex = 162
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'btnCliActualizar
        '
        Me.btnCliActualizar.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnCliActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCliActualizar.Location = New System.Drawing.Point(312, 274)
        Me.btnCliActualizar.Name = "btnCliActualizar"
        Me.btnCliActualizar.Size = New System.Drawing.Size(337, 40)
        Me.btnCliActualizar.TabIndex = 165
        Me.btnCliActualizar.Text = "Actualizar"
        Me.btnCliActualizar.UseVisualStyleBackColor = False
        '
        'btnCliEliminar
        '
        Me.btnCliEliminar.BackColor = System.Drawing.Color.Crimson
        Me.btnCliEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCliEliminar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCliEliminar.Location = New System.Drawing.Point(312, 275)
        Me.btnCliEliminar.Name = "btnCliEliminar"
        Me.btnCliEliminar.Size = New System.Drawing.Size(337, 40)
        Me.btnCliEliminar.TabIndex = 164
        Me.btnCliEliminar.Text = "Eliminar"
        Me.btnCliEliminar.UseVisualStyleBackColor = False
        '
        'btnCliGrabar
        '
        Me.btnCliGrabar.BackColor = System.Drawing.Color.Gold
        Me.btnCliGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCliGrabar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCliGrabar.Location = New System.Drawing.Point(312, 274)
        Me.btnCliGrabar.Name = "btnCliGrabar"
        Me.btnCliGrabar.Size = New System.Drawing.Size(337, 40)
        Me.btnCliGrabar.TabIndex = 163
        Me.btnCliGrabar.Text = "Grabar"
        Me.btnCliGrabar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label1.Location = New System.Drawing.Point(238, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 60)
        Me.Label1.TabIndex = 167
        Me.Label1.Text = "Clientes"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.YellowGreen
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(228, 115)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 40)
        Me.Button2.TabIndex = 166
        Me.Button2.Text = "Consultar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(681, 338)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnCliActualizar)
        Me.Controls.Add(Me.btnCliEliminar)
        Me.Controls.Add(Me.btnCliGrabar)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCliCelular)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCliCedula)
        Me.Controls.Add(Me.txtCliEdoCivil)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCliTlf)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCliEstado)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCliCiudad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCliDireccion)
        Me.Controls.Add(Me.txtCliNombre)
        Me.Controls.Add(Me.txtCliApellido)
        Me.Controls.Add(Me.txtCliCorreo)
        Me.Controls.Add(Me.txtCliSexo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblMaximo)
        Me.Controls.Add(Me.lblMinimo)
        Me.Controls.Add(Me.lblActual)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Name = "frmClientes"
        Me.Text = "frmClientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCliCelular As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCliCedula As System.Windows.Forms.TextBox
    Friend WithEvents txtCliEdoCivil As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCliTlf As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCliEstado As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCliCiudad As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCliDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtCliNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtCliApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtCliCorreo As System.Windows.Forms.TextBox
    Friend WithEvents txtCliSexo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblMaximo As System.Windows.Forms.Label
    Friend WithEvents lblMinimo As System.Windows.Forms.Label
    Friend WithEvents lblActual As System.Windows.Forms.Label
    Friend WithEvents lblPrecio As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents btnRegresar As System.Windows.Forms.Button
    Friend WithEvents btnCliActualizar As System.Windows.Forms.Button
    Friend WithEvents btnCliEliminar As System.Windows.Forms.Button
    Friend WithEvents btnCliGrabar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
