<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarDepto))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtNombreDepartamento = New System.Windows.Forms.TextBox()
        Me.lblDepto = New System.Windows.Forms.Label()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bntMenu = New System.Windows.Forms.Button()
        Me.titulo = New System.Windows.Forms.Label()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.dataListado = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNombreDepartamento
        '
        Me.txtNombreDepartamento.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNombreDepartamento.Location = New System.Drawing.Point(218, 99)
        Me.txtNombreDepartamento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNombreDepartamento.Name = "txtNombreDepartamento"
        Me.txtNombreDepartamento.Size = New System.Drawing.Size(185, 36)
        Me.txtNombreDepartamento.TabIndex = 4
        '
        'lblDepto
        '
        Me.lblDepto.AutoSize = True
        Me.lblDepto.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDepto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDepto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDepto.Location = New System.Drawing.Point(12, 102)
        Me.lblDepto.Name = "lblDepto"
        Me.lblDepto.Size = New System.Drawing.Size(192, 33)
        Me.lblDepto.TabIndex = 3
        Me.lblDepto.Text = "Departamento:"
        Me.lblDepto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.Color.DarkRed
        Me.btnBorrar.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBorrar.ForeColor = System.Drawing.Color.White
        Me.btnBorrar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnBorrar.Location = New System.Drawing.Point(218, 260)
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
        Me.btnRegistrar.Location = New System.Drawing.Point(218, 179)
        Me.btnRegistrar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(141, 51)
        Me.btnRegistrar.TabIndex = 9
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.DarkRed
        Me.btnEditar.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnEditar.Location = New System.Drawing.Point(36, 260)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(141, 51)
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
        Me.btnBuscar.Location = New System.Drawing.Point(36, 179)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(141, 51)
        Me.btnBuscar.TabIndex = 13
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
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
        Me.Panel1.TabIndex = 34
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
        Me.titulo.Location = New System.Drawing.Point(188, 16)
        Me.titulo.Name = "titulo"
        Me.titulo.Size = New System.Drawing.Size(347, 33)
        Me.titulo.TabIndex = 6
        Me.titulo.Text = "Registro de Departamentos"
        Me.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'logo
        '
        Me.logo.BackColor = System.Drawing.Color.Transparent
        Me.logo.BackgroundImage = Global.FoodRegister.My.Resources.Resources.Dole_2018
        Me.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.logo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.logo.Location = New System.Drawing.Point(644, 3)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(96, 64)
        Me.logo.TabIndex = 5
        Me.logo.TabStop = False
        '
        'dataListado
        '
        Me.dataListado.AllowUserToDeleteRows = False
        Me.dataListado.AllowUserToResizeRows = False
        Me.dataListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataListado.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.dataListado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dataListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Bahnschrift", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataListado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataListado.ColumnHeadersHeight = 50
        Me.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataListado.EnableHeadersVisualStyles = False
        Me.dataListado.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dataListado.Location = New System.Drawing.Point(437, 89)
        Me.dataListado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dataListado.Name = "dataListado"
        Me.dataListado.ReadOnly = True
        Me.dataListado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataListado.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dataListado.RowHeadersVisible = False
        Me.dataListado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(213, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Bahnschrift", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dataListado.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dataListado.RowTemplate.Height = 25
        Me.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataListado.Size = New System.Drawing.Size(303, 258)
        Me.dataListado.TabIndex = 35
        '
        'AgregarDepto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 373)
        Me.Controls.Add(Me.dataListado)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.txtNombreDepartamento)
        Me.Controls.Add(Me.lblDepto)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "AgregarDepto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AgregarDepto"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNombreDepartamento As TextBox
    Friend WithEvents lblDepto As Label
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents bntMenu As Button
    Friend WithEvents titulo As Label
    Friend WithEvents logo As PictureBox
    Friend WithEvents dataListado As DataGridView
End Class
