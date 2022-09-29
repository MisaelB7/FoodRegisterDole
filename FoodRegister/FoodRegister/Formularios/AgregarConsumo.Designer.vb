<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarConsumo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarConsumo))
        Me.txtIdentidad = New System.Windows.Forms.TextBox()
        Me.lblIdentidad = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bntMenu = New System.Windows.Forms.Button()
        Me.titulo = New System.Windows.Forms.Label()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtIdentidad.Location = New System.Drawing.Point(184, 125)
        Me.txtIdentidad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(185, 36)
        Me.txtIdentidad.TabIndex = 0
        '
        'lblIdentidad
        '
        Me.lblIdentidad.AutoSize = True
        Me.lblIdentidad.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblIdentidad.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblIdentidad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblIdentidad.Location = New System.Drawing.Point(29, 125)
        Me.lblIdentidad.Name = "lblIdentidad"
        Me.lblIdentidad.Size = New System.Drawing.Size(132, 33)
        Me.lblIdentidad.TabIndex = 6
        Me.lblIdentidad.Text = "Identidad:"
        Me.lblIdentidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPrecio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPrecio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPrecio.Location = New System.Drawing.Point(419, 125)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(97, 33)
        Me.lblPrecio.TabIndex = 8
        Me.lblPrecio.Text = "Precio:"
        Me.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPrecio
        '
        Me.txtPrecio.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPrecio.Location = New System.Drawing.Point(537, 122)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(185, 36)
        Me.txtPrecio.TabIndex = 1
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnRegistrar.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRegistrar.ForeColor = System.Drawing.Color.White
        Me.btnRegistrar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnRegistrar.Location = New System.Drawing.Point(314, 232)
        Me.btnRegistrar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(141, 51)
        Me.btnRegistrar.TabIndex = 2
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
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
        Me.Panel1.TabIndex = 33
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
        'titulo
        '
        Me.titulo.AutoSize = True
        Me.titulo.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.titulo.ForeColor = System.Drawing.SystemColors.Control
        Me.titulo.Location = New System.Drawing.Point(241, 13)
        Me.titulo.Name = "titulo"
        Me.titulo.Size = New System.Drawing.Size(275, 33)
        Me.titulo.TabIndex = 6
        Me.titulo.Text = "Registro de Consumo"
        Me.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'AgregarConsumo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 373)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.lblIdentidad)
        Me.Controls.Add(Me.txtIdentidad)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "AgregarConsumo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consumo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtIdentidad As TextBox
    Friend WithEvents lblIdentidad As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents bntMenu As Button
    Friend WithEvents titulo As Label
    Friend WithEvents logo As PictureBox
End Class
