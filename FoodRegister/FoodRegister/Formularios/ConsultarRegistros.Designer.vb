<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultarRegistros
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultarRegistros))
        Me.dataListado = New System.Windows.Forms.DataGridView()
        Me.DTPFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.DTPFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtIdentidad = New System.Windows.Forms.TextBox()
        Me.lblCCosto = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbDepartamento = New System.Windows.Forms.ComboBox()
        Me.lblDepto = New System.Windows.Forms.Label()
        Me.txtCCosto = New System.Windows.Forms.TextBox()
        Me.lblIdentidad = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bntMenu = New System.Windows.Forms.Button()
        Me.titulo = New System.Windows.Forms.Label()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        CType(Me.dataListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataListado
        '
        Me.dataListado.AllowUserToAddRows = False
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
        Me.dataListado.ColumnHeadersHeight = 35
        Me.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataListado.EnableHeadersVisualStyles = False
        Me.dataListado.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dataListado.Location = New System.Drawing.Point(12, 225)
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
        Me.dataListado.RowHeadersWidth = 51
        Me.dataListado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(213, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Bahnschrift", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dataListado.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dataListado.RowTemplate.Height = 25
        Me.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataListado.Size = New System.Drawing.Size(1251, 306)
        Me.dataListado.TabIndex = 12
        '
        'DTPFechaInicio
        '
        Me.DTPFechaInicio.CalendarFont = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DTPFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaInicio.Location = New System.Drawing.Point(144, 137)
        Me.DTPFechaInicio.Name = "DTPFechaInicio"
        Me.DTPFechaInicio.Size = New System.Drawing.Size(185, 27)
        Me.DTPFechaInicio.TabIndex = 0
        '
        'DTPFechaFinal
        '
        Me.DTPFechaFinal.CalendarFont = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DTPFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaFinal.Location = New System.Drawing.Point(144, 178)
        Me.DTPFechaFinal.Name = "DTPFechaFinal"
        Me.DTPFechaFinal.Size = New System.Drawing.Size(185, 27)
        Me.DTPFechaFinal.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnBuscar.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnBuscar.Location = New System.Drawing.Point(1121, 125)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(141, 51)
        Me.btnBuscar.TabIndex = 21
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtIdentidad.Location = New System.Drawing.Point(543, 134)
        Me.txtIdentidad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.PlaceholderText = "0101199900001"
        Me.txtIdentidad.Size = New System.Drawing.Size(185, 36)
        Me.txtIdentidad.TabIndex = 2
        '
        'lblCCosto
        '
        Me.lblCCosto.AutoSize = True
        Me.lblCCosto.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCCosto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCCosto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCCosto.Location = New System.Drawing.Point(802, 137)
        Me.lblCCosto.Name = "lblCCosto"
        Me.lblCCosto.Size = New System.Drawing.Size(119, 33)
        Me.lblCCosto.TabIndex = 23
        Me.lblCCosto.Text = "C. Costo:"
        Me.lblCCosto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(25, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 33)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "F  Inicio:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(25, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 33)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "F  Final:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbDepartamento
        '
        Me.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepartamento.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbDepartamento.FormattingEnabled = True
        Me.cmbDepartamento.Location = New System.Drawing.Point(543, 180)
        Me.cmbDepartamento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbDepartamento.Name = "cmbDepartamento"
        Me.cmbDepartamento.Size = New System.Drawing.Size(185, 37)
        Me.cmbDepartamento.TabIndex = 4
        '
        'lblDepto
        '
        Me.lblDepto.AutoSize = True
        Me.lblDepto.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDepto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDepto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDepto.Location = New System.Drawing.Point(345, 180)
        Me.lblDepto.Name = "lblDepto"
        Me.lblDepto.Size = New System.Drawing.Size(192, 33)
        Me.lblDepto.TabIndex = 30
        Me.lblDepto.Text = "Departamento:"
        Me.lblDepto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCCosto
        '
        Me.txtCCosto.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtCCosto.Location = New System.Drawing.Point(927, 134)
        Me.txtCCosto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCCosto.Name = "txtCCosto"
        Me.txtCCosto.PlaceholderText = "10100101"
        Me.txtCCosto.Size = New System.Drawing.Size(185, 36)
        Me.txtCCosto.TabIndex = 3
        '
        'lblIdentidad
        '
        Me.lblIdentidad.AutoSize = True
        Me.lblIdentidad.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblIdentidad.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblIdentidad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblIdentidad.Location = New System.Drawing.Point(345, 137)
        Me.lblIdentidad.Name = "lblIdentidad"
        Me.lblIdentidad.Size = New System.Drawing.Size(132, 33)
        Me.lblIdentidad.TabIndex = 32
        Me.lblIdentidad.Text = "Identidad:"
        Me.lblIdentidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Panel1.Size = New System.Drawing.Size(1274, 64)
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
        Me.titulo.Location = New System.Drawing.Point(515, 16)
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
        Me.logo.Location = New System.Drawing.Point(1167, 0)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(96, 64)
        Me.logo.TabIndex = 5
        Me.logo.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(802, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 33)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Total:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTotal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTotal.Location = New System.Drawing.Point(927, 184)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(65, 33)
        Me.lblTotal.TabIndex = 36
        Me.lblTotal.Text = "Lps."
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ConsultarRegistros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1274, 544)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtCCosto)
        Me.Controls.Add(Me.lblIdentidad)
        Me.Controls.Add(Me.cmbDepartamento)
        Me.Controls.Add(Me.lblDepto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIdentidad)
        Me.Controls.Add(Me.lblCCosto)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.DTPFechaFinal)
        Me.Controls.Add(Me.DTPFechaInicio)
        Me.Controls.Add(Me.dataListado)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ConsultarRegistros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ConsultarRegistros"
        CType(Me.dataListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dataListado As DataGridView
    Friend WithEvents DTPFechaInicio As DateTimePicker
    Friend WithEvents DTPFechaFinal As DateTimePicker
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtIdentidad As TextBox
    Friend WithEvents lblCCosto As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbDepartamento As ComboBox
    Friend WithEvents lblDepto As Label
    Friend WithEvents txtCCosto As TextBox
    Friend WithEvents lblIdentidad As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents bntMenu As Button
    Friend WithEvents titulo As Label
    Friend WithEvents logo As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotal As Label
End Class
