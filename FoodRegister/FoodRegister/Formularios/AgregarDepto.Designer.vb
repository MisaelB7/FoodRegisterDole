﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AgregarDepto
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
        Me.txtNombreDepartamento = New System.Windows.Forms.TextBox()
        Me.lblDepto = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.dataListado = New System.Windows.Forms.DataGridView()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnFormEmpleados = New System.Windows.Forms.Button()
        CType(Me.dataListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNombreDepartamento
        '
        Me.txtNombreDepartamento.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNombreDepartamento.Location = New System.Drawing.Point(168, 52)
        Me.txtNombreDepartamento.Name = "txtNombreDepartamento"
        Me.txtNombreDepartamento.Size = New System.Drawing.Size(162, 30)
        Me.txtNombreDepartamento.TabIndex = 4
        '
        'lblDepto
        '
        Me.lblDepto.AutoSize = True
        Me.lblDepto.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDepto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDepto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDepto.Location = New System.Drawing.Point(12, 53)
        Me.lblDepto.Name = "lblDepto"
        Me.lblDepto.Size = New System.Drawing.Size(150, 25)
        Me.lblDepto.TabIndex = 3
        Me.lblDepto.Text = "Departamento:"
        Me.lblDepto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.lblTitulo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTitulo.Location = New System.Drawing.Point(248, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(269, 25)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "Registro de Departamentos"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnBorrar.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBorrar.ForeColor = System.Drawing.Color.White
        Me.btnBorrar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnBorrar.Location = New System.Drawing.Point(639, 46)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(83, 38)
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
        Me.btnRegistrar.Location = New System.Drawing.Point(440, 46)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(109, 38)
        Me.btnRegistrar.TabIndex = 9
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'dataListado
        '
        Me.dataListado.AllowUserToOrderColumns = True
        Me.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataListado.Location = New System.Drawing.Point(12, 110)
        Me.dataListado.Name = "dataListado"
        Me.dataListado.RowTemplate.Height = 25
        Me.dataListado.Size = New System.Drawing.Size(318, 288)
        Me.dataListado.TabIndex = 11
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnEditar.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnEditar.Location = New System.Drawing.Point(555, 46)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(78, 38)
        Me.btnEditar.TabIndex = 12
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnBuscar.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnBuscar.Location = New System.Drawing.Point(336, 46)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(98, 38)
        Me.btnBuscar.TabIndex = 13
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnFormEmpleados
        '
        Me.btnFormEmpleados.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnFormEmpleados.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnFormEmpleados.ForeColor = System.Drawing.Color.White
        Me.btnFormEmpleados.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnFormEmpleados.Location = New System.Drawing.Point(599, 110)
        Me.btnFormEmpleados.Name = "btnFormEmpleados"
        Me.btnFormEmpleados.Size = New System.Drawing.Size(123, 38)
        Me.btnFormEmpleados.TabIndex = 14
        Me.btnFormEmpleados.Text = "Empleados"
        Me.btnFormEmpleados.UseVisualStyleBackColor = False
        '
        'AgregarDepto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 419)
        Me.Controls.Add(Me.btnFormEmpleados)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.dataListado)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.txtNombreDepartamento)
        Me.Controls.Add(Me.lblDepto)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "AgregarDepto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AgregarDepto"
        CType(Me.dataListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNombreDepartamento As TextBox
    Friend WithEvents lblDepto As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents dataListado As DataGridView
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnFormEmpleados As Button
End Class
