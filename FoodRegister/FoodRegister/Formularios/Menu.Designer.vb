<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.btnDeptos = New System.Windows.Forms.Button()
        Me.btnEmpleados = New System.Windows.Forms.Button()
        Me.btnConsumo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDeptos
        '
        Me.btnDeptos.Location = New System.Drawing.Point(349, 67)
        Me.btnDeptos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDeptos.Name = "btnDeptos"
        Me.btnDeptos.Size = New System.Drawing.Size(160, 47)
        Me.btnDeptos.TabIndex = 0
        Me.btnDeptos.Text = "departamentos"
        Me.btnDeptos.UseVisualStyleBackColor = True
        '
        'btnEmpleados
        '
        Me.btnEmpleados.Location = New System.Drawing.Point(349, 201)
        Me.btnEmpleados.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEmpleados.Name = "btnEmpleados"
        Me.btnEmpleados.Size = New System.Drawing.Size(160, 47)
        Me.btnEmpleados.TabIndex = 1
        Me.btnEmpleados.Text = "empleados"
        Me.btnEmpleados.UseVisualStyleBackColor = True
        '
        'btnConsumo
        '
        Me.btnConsumo.Location = New System.Drawing.Point(349, 298)
        Me.btnConsumo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnConsumo.Name = "btnConsumo"
        Me.btnConsumo.Size = New System.Drawing.Size(160, 47)
        Me.btnConsumo.TabIndex = 2
        Me.btnConsumo.Text = "Consumo"
        Me.btnConsumo.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 600)
        Me.Controls.Add(Me.btnConsumo)
        Me.Controls.Add(Me.btnEmpleados)
        Me.Controls.Add(Me.btnDeptos)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDeptos As Button
    Friend WithEvents btnEmpleados As Button
    Friend WithEvents btnConsumo As Button
End Class
