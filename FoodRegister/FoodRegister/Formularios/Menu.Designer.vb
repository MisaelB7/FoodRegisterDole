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
        Me.components = New System.ComponentModel.Container()
        Me.btnEmpleados = New System.Windows.Forms.Button()
        Me.btnConsumo = New System.Windows.Forms.Button()
        Me.btnConsultas = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.titulo = New System.Windows.Forms.Label()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.lblReloj = New System.Windows.Forms.Label()
        Me.btnDeptos = New System.Windows.Forms.Button()
        Me.reloj = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEmpleados
        '
        Me.btnEmpleados.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEmpleados.Image = Global.FoodRegister.My.Resources.Resources.employee
        Me.btnEmpleados.Location = New System.Drawing.Point(436, 228)
        Me.btnEmpleados.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEmpleados.Name = "btnEmpleados"
        Me.btnEmpleados.Size = New System.Drawing.Size(160, 115)
        Me.btnEmpleados.TabIndex = 3
        Me.btnEmpleados.Text = "Empleados"
        Me.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEmpleados.UseVisualStyleBackColor = True
        '
        'btnConsumo
        '
        Me.btnConsumo.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnConsumo.Image = Global.FoodRegister.My.Resources.Resources.carrito_de_compras
        Me.btnConsumo.Location = New System.Drawing.Point(436, 83)
        Me.btnConsumo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnConsumo.Name = "btnConsumo"
        Me.btnConsumo.Size = New System.Drawing.Size(160, 115)
        Me.btnConsumo.TabIndex = 1
        Me.btnConsumo.Text = "Consumo"
        Me.btnConsumo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnConsumo.UseVisualStyleBackColor = True
        '
        'btnConsultas
        '
        Me.btnConsultas.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnConsultas.Image = Global.FoodRegister.My.Resources.Resources.search
        Me.btnConsultas.Location = New System.Drawing.Point(156, 228)
        Me.btnConsultas.Name = "btnConsultas"
        Me.btnConsultas.Size = New System.Drawing.Size(160, 115)
        Me.btnConsultas.TabIndex = 2
        Me.btnConsultas.Text = "Registros"
        Me.btnConsultas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnConsultas.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Controls.Add(Me.titulo)
        Me.Panel1.Controls.Add(Me.logo)
        Me.Panel1.Controls.Add(Me.lblReloj)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(752, 64)
        Me.Panel1.TabIndex = 4
        '
        'titulo
        '
        Me.titulo.AutoSize = True
        Me.titulo.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.titulo.ForeColor = System.Drawing.SystemColors.Control
        Me.titulo.Location = New System.Drawing.Point(338, 16)
        Me.titulo.Name = "titulo"
        Me.titulo.Size = New System.Drawing.Size(80, 33)
        Me.titulo.TabIndex = 6
        Me.titulo.Text = "Menu"
        '
        'logo
        '
        Me.logo.BackColor = System.Drawing.Color.Transparent
        Me.logo.BackgroundImage = Global.FoodRegister.My.Resources.Resources.Dole_2018
        Me.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.logo.Location = New System.Drawing.Point(644, 0)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(96, 64)
        Me.logo.TabIndex = 5
        Me.logo.TabStop = False
        '
        'lblReloj
        '
        Me.lblReloj.AutoSize = True
        Me.lblReloj.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblReloj.ForeColor = System.Drawing.SystemColors.Control
        Me.lblReloj.Location = New System.Drawing.Point(12, 16)
        Me.lblReloj.Name = "lblReloj"
        Me.lblReloj.Size = New System.Drawing.Size(76, 33)
        Me.lblReloj.TabIndex = 0
        Me.lblReloj.Text = "Reloj"
        '
        'btnDeptos
        '
        Me.btnDeptos.BackColor = System.Drawing.SystemColors.Control
        Me.btnDeptos.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDeptos.Image = Global.FoodRegister.My.Resources.Resources.maletin
        Me.btnDeptos.Location = New System.Drawing.Point(156, 83)
        Me.btnDeptos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDeptos.Name = "btnDeptos"
        Me.btnDeptos.Size = New System.Drawing.Size(160, 115)
        Me.btnDeptos.TabIndex = 0
        Me.btnDeptos.Text = "Departamentos"
        Me.btnDeptos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDeptos.UseVisualStyleBackColor = False
        '
        'reloj
        '
        Me.reloj.Enabled = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(752, 373)
        Me.Controls.Add(Me.btnDeptos)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnConsultas)
        Me.Controls.Add(Me.btnConsumo)
        Me.Controls.Add(Me.btnEmpleados)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEmpleados As Button
    Friend WithEvents btnConsumo As Button
    Friend WithEvents btnConsultas As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnDeptos As Button
    Friend WithEvents reloj As Timer
    Friend WithEvents lblReloj As Label
    Friend WithEvents logo As PictureBox
    Friend WithEvents titulo As Label
End Class
