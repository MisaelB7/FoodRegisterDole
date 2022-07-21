<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarEmpleado
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
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.txtCCosto = New System.Windows.Forms.TextBox()
        Me.lblCCosto = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtApellidoEmpleado = New System.Windows.Forms.TextBox()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.txtIdentidad = New System.Windows.Forms.TextBox()
        Me.lblIdentidad = New System.Windows.Forms.Label()
        Me.lblDepto = New System.Windows.Forms.Label()
        Me.lblContrato = New System.Windows.Forms.Label()
        Me.cmbDepartamento = New System.Windows.Forms.ComboBox()
        Me.cbmContrato = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnBuscar.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnBuscar.Location = New System.Drawing.Point(528, 46)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(98, 38)
        Me.btnBuscar.TabIndex = 20
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnEditar.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnEditar.Location = New System.Drawing.Point(643, 46)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(78, 38)
        Me.btnEditar.TabIndex = 19
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnBorrar.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBorrar.ForeColor = System.Drawing.Color.White
        Me.btnBorrar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnBorrar.Location = New System.Drawing.Point(643, 96)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(83, 38)
        Me.btnBorrar.TabIndex = 18
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnRegistrar.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRegistrar.ForeColor = System.Drawing.Color.White
        Me.btnRegistrar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnRegistrar.Location = New System.Drawing.Point(528, 96)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(109, 38)
        Me.btnRegistrar.TabIndex = 17
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'txtCCosto
        '
        Me.txtCCosto.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtCCosto.Location = New System.Drawing.Point(116, 52)
        Me.txtCCosto.Name = "txtCCosto"
        Me.txtCCosto.Size = New System.Drawing.Size(162, 30)
        Me.txtCCosto.TabIndex = 16
        '
        'lblCCosto
        '
        Me.lblCCosto.AutoSize = True
        Me.lblCCosto.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCCosto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCCosto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCCosto.Location = New System.Drawing.Point(17, 53)
        Me.lblCCosto.Name = "lblCCosto"
        Me.lblCCosto.Size = New System.Drawing.Size(93, 25)
        Me.lblCCosto.TabIndex = 15
        Me.lblCCosto.Text = "C. Costo:"
        Me.lblCCosto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.lblTitulo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTitulo.Location = New System.Drawing.Point(253, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(269, 25)
        Me.lblTitulo.TabIndex = 14
        Me.lblTitulo.Text = "Registro de Departamentos"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombreEmpleado
        '
        Me.txtNombreEmpleado.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(116, 108)
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(162, 30)
        Me.txtNombreEmpleado.TabIndex = 22
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNombre.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNombre.Location = New System.Drawing.Point(17, 109)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(92, 25)
        Me.lblNombre.TabIndex = 21
        Me.lblNombre.Text = "Nombre:"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtApellidoEmpleado
        '
        Me.txtApellidoEmpleado.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtApellidoEmpleado.Location = New System.Drawing.Point(116, 164)
        Me.txtApellidoEmpleado.Name = "txtApellidoEmpleado"
        Me.txtApellidoEmpleado.Size = New System.Drawing.Size(162, 30)
        Me.txtApellidoEmpleado.TabIndex = 24
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblApellido.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblApellido.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblApellido.Location = New System.Drawing.Point(17, 165)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(92, 25)
        Me.lblApellido.TabIndex = 23
        Me.lblApellido.Text = "Apellido:"
        Me.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtIdentidad.Location = New System.Drawing.Point(116, 224)
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(162, 30)
        Me.txtIdentidad.TabIndex = 26
        '
        'lblIdentidad
        '
        Me.lblIdentidad.AutoSize = True
        Me.lblIdentidad.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblIdentidad.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblIdentidad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblIdentidad.Location = New System.Drawing.Point(17, 225)
        Me.lblIdentidad.Name = "lblIdentidad"
        Me.lblIdentidad.Size = New System.Drawing.Size(102, 25)
        Me.lblIdentidad.TabIndex = 25
        Me.lblIdentidad.Text = "Identidad:"
        Me.lblIdentidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDepto
        '
        Me.lblDepto.AutoSize = True
        Me.lblDepto.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDepto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDepto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDepto.Location = New System.Drawing.Point(17, 279)
        Me.lblDepto.Name = "lblDepto"
        Me.lblDepto.Size = New System.Drawing.Size(150, 25)
        Me.lblDepto.TabIndex = 27
        Me.lblDepto.Text = "Departamento:"
        Me.lblDepto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblContrato
        '
        Me.lblContrato.AutoSize = True
        Me.lblContrato.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblContrato.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblContrato.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblContrato.Location = New System.Drawing.Point(17, 336)
        Me.lblContrato.Name = "lblContrato"
        Me.lblContrato.Size = New System.Drawing.Size(141, 25)
        Me.lblContrato.TabIndex = 28
        Me.lblContrato.Text = "Tipo Contrato:"
        Me.lblContrato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbDepartamento
        '
        Me.cmbDepartamento.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbDepartamento.FormattingEnabled = True
        Me.cmbDepartamento.Location = New System.Drawing.Point(173, 278)
        Me.cmbDepartamento.Name = "cmbDepartamento"
        Me.cmbDepartamento.Size = New System.Drawing.Size(162, 31)
        Me.cmbDepartamento.TabIndex = 29
        '
        'cbmContrato
        '
        Me.cbmContrato.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbmContrato.FormattingEnabled = True
        Me.cbmContrato.Location = New System.Drawing.Point(173, 330)
        Me.cbmContrato.Name = "cbmContrato"
        Me.cbmContrato.Size = New System.Drawing.Size(162, 31)
        Me.cbmContrato.TabIndex = 30
        '
        'AgregarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 419)
        Me.Controls.Add(Me.cbmContrato)
        Me.Controls.Add(Me.cmbDepartamento)
        Me.Controls.Add(Me.lblContrato)
        Me.Controls.Add(Me.lblDepto)
        Me.Controls.Add(Me.txtIdentidad)
        Me.Controls.Add(Me.lblIdentidad)
        Me.Controls.Add(Me.txtApellidoEmpleado)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.txtNombreEmpleado)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.txtCCosto)
        Me.Controls.Add(Me.lblCCosto)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "AgregarEmpleado"
        Me.Text = "AgregarEmpleado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents txtCCosto As TextBox
    Friend WithEvents lblCCosto As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents txtNombreEmpleado As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtApellidoEmpleado As TextBox
    Friend WithEvents lblApellido As Label
    Friend WithEvents txtIdentidad As TextBox
    Friend WithEvents lblIdentidad As Label
    Friend WithEvents lblDepto As Label
    Friend WithEvents lblContrato As Label
    Friend WithEvents cmbDepartamento As ComboBox
    Friend WithEvents cbmContrato As ComboBox
End Class
