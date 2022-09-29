<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AgregarEmpleado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarEmpleado))
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.txtCCosto = New System.Windows.Forms.TextBox()
        Me.lblCCosto = New System.Windows.Forms.Label()
        Me.txtNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtApellidoEmpleado = New System.Windows.Forms.TextBox()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.txtIdentidad = New System.Windows.Forms.TextBox()
        Me.lblIdentidad = New System.Windows.Forms.Label()
        Me.lblDepto = New System.Windows.Forms.Label()
        Me.lblContrato = New System.Windows.Forms.Label()
        Me.cmbDepartamento = New System.Windows.Forms.ComboBox()
        Me.cmbContrato = New System.Windows.Forms.ComboBox()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.titulo = New System.Windows.Forms.Label()
        Me.bntMenu = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnBuscar.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnBuscar.Location = New System.Drawing.Point(201, 288)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(141, 51)
        Me.btnBuscar.TabIndex = 8
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.DarkRed
        Me.btnEditar.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnEditar.Location = New System.Drawing.Point(424, 288)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(141, 51)
        Me.btnEditar.TabIndex = 9
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.Color.DarkRed
        Me.btnBorrar.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBorrar.ForeColor = System.Drawing.Color.White
        Me.btnBorrar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnBorrar.Location = New System.Drawing.Point(597, 288)
        Me.btnBorrar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(141, 51)
        Me.btnBorrar.TabIndex = 10
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnRegistrar.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRegistrar.ForeColor = System.Drawing.Color.White
        Me.btnRegistrar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnRegistrar.Location = New System.Drawing.Point(19, 288)
        Me.btnRegistrar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(141, 51)
        Me.btnRegistrar.TabIndex = 7
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'txtCCosto
        '
        Me.txtCCosto.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtCCosto.Location = New System.Drawing.Point(553, 210)
        Me.txtCCosto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCCosto.Name = "txtCCosto"
        Me.txtCCosto.PlaceholderText = "10100101"
        Me.txtCCosto.Size = New System.Drawing.Size(185, 36)
        Me.txtCCosto.TabIndex = 6
        '
        'lblCCosto
        '
        Me.lblCCosto.AutoSize = True
        Me.lblCCosto.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCCosto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCCosto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCCosto.Location = New System.Drawing.Point(424, 213)
        Me.lblCCosto.Name = "lblCCosto"
        Me.lblCCosto.Size = New System.Drawing.Size(119, 33)
        Me.lblCCosto.TabIndex = 15
        Me.lblCCosto.Text = "C. Costo:"
        Me.lblCCosto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNombreEmpleado
        '
        Me.txtNombreEmpleado.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(157, 85)
        Me.txtNombreEmpleado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        Me.txtNombreEmpleado.PlaceholderText = "Juan"
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(185, 36)
        Me.txtNombreEmpleado.TabIndex = 1
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNombre.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNombre.Location = New System.Drawing.Point(19, 88)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(118, 33)
        Me.lblNombre.TabIndex = 21
        Me.lblNombre.Text = "Nombre:"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtApellidoEmpleado
        '
        Me.txtApellidoEmpleado.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtApellidoEmpleado.Location = New System.Drawing.Point(553, 85)
        Me.txtApellidoEmpleado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtApellidoEmpleado.Name = "txtApellidoEmpleado"
        Me.txtApellidoEmpleado.PlaceholderText = "Ortega"
        Me.txtApellidoEmpleado.Size = New System.Drawing.Size(185, 36)
        Me.txtApellidoEmpleado.TabIndex = 2
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblApellido.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblApellido.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblApellido.Location = New System.Drawing.Point(424, 88)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(119, 33)
        Me.lblApellido.TabIndex = 23
        Me.lblApellido.Text = "Apellido:"
        Me.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtIdentidad.Location = New System.Drawing.Point(157, 210)
        Me.txtIdentidad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.PlaceholderText = "0101199900001"
        Me.txtIdentidad.Size = New System.Drawing.Size(185, 36)
        Me.txtIdentidad.TabIndex = 5
        '
        'lblIdentidad
        '
        Me.lblIdentidad.AutoSize = True
        Me.lblIdentidad.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblIdentidad.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblIdentidad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblIdentidad.Location = New System.Drawing.Point(19, 213)
        Me.lblIdentidad.Name = "lblIdentidad"
        Me.lblIdentidad.Size = New System.Drawing.Size(132, 33)
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
        Me.lblDepto.Location = New System.Drawing.Point(424, 154)
        Me.lblDepto.Name = "lblDepto"
        Me.lblDepto.Size = New System.Drawing.Size(91, 33)
        Me.lblDepto.TabIndex = 27
        Me.lblDepto.Text = "Depto:"
        Me.lblDepto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblContrato
        '
        Me.lblContrato.AutoSize = True
        Me.lblContrato.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblContrato.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblContrato.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblContrato.Location = New System.Drawing.Point(19, 154)
        Me.lblContrato.Name = "lblContrato"
        Me.lblContrato.Size = New System.Drawing.Size(126, 33)
        Me.lblContrato.TabIndex = 28
        Me.lblContrato.Text = "Contrato:"
        Me.lblContrato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbDepartamento
        '
        Me.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepartamento.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbDepartamento.FormattingEnabled = True
        Me.cmbDepartamento.Items.AddRange(New Object() {"Seleccionar"})
        Me.cmbDepartamento.Location = New System.Drawing.Point(555, 150)
        Me.cmbDepartamento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbDepartamento.Name = "cmbDepartamento"
        Me.cmbDepartamento.Size = New System.Drawing.Size(185, 37)
        Me.cmbDepartamento.TabIndex = 4
        '
        'cmbContrato
        '
        Me.cmbContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbContrato.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbContrato.FormattingEnabled = True
        Me.cmbContrato.ItemHeight = 29
        Me.cmbContrato.Location = New System.Drawing.Point(157, 150)
        Me.cmbContrato.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbContrato.Name = "cmbContrato"
        Me.cmbContrato.Size = New System.Drawing.Size(185, 37)
        Me.cmbContrato.TabIndex = 3
        '
        'logo
        '
        Me.logo.BackColor = System.Drawing.Color.Transparent
        Me.logo.BackgroundImage = Global.FoodRegister.My.Resources.Resources.Dole_2018
        Me.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.logo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.logo.Location = New System.Drawing.Point(644, 0)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(96, 64)
        Me.logo.TabIndex = 5
        Me.logo.TabStop = False
        '
        'titulo
        '
        Me.titulo.AutoSize = True
        Me.titulo.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.titulo.ForeColor = System.Drawing.SystemColors.Control
        Me.titulo.Location = New System.Drawing.Point(196, 13)
        Me.titulo.Name = "titulo"
        Me.titulo.Size = New System.Drawing.Size(347, 33)
        Me.titulo.TabIndex = 6
        Me.titulo.Text = "Registro de Departamentos"
        Me.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bntMenu
        '
        Me.bntMenu.BackColor = System.Drawing.Color.DarkRed
        Me.bntMenu.FlatAppearance.BorderSize = 0
        Me.bntMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.bntMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bntMenu.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bntMenu.ForeColor = System.Drawing.Color.Transparent
        Me.bntMenu.Image = CType(resources.GetObject("bntMenu.Image"), System.Drawing.Image)
        Me.bntMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bntMenu.Location = New System.Drawing.Point(0, 0)
        Me.bntMenu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bntMenu.Name = "bntMenu"
        Me.bntMenu.Size = New System.Drawing.Size(83, 64)
        Me.bntMenu.TabIndex = 11
        Me.bntMenu.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Controls.Add(Me.bntMenu)
        Me.Panel1.Controls.Add(Me.titulo)
        Me.Panel1.Controls.Add(Me.logo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(752, 64)
        Me.Panel1.TabIndex = 31
        '
        'AgregarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 373)
        Me.Controls.Add(Me.cmbContrato)
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
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "AgregarEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empleados"
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents txtCCosto As TextBox
    Friend WithEvents lblCCosto As Label
    Friend WithEvents txtNombreEmpleado As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtApellidoEmpleado As TextBox
    Friend WithEvents lblApellido As Label
    Friend WithEvents txtIdentidad As TextBox
    Friend WithEvents lblIdentidad As Label
    Friend WithEvents lblDepto As Label
    Friend WithEvents lblContrato As Label
    Friend WithEvents cmbDepartamento As ComboBox
    Friend WithEvents cmbContrato As ComboBox
    Friend WithEvents logo As PictureBox
    Friend WithEvents titulo As Label
    Friend WithEvents bntMenu As Button
    Friend WithEvents Panel1 As Panel
End Class
