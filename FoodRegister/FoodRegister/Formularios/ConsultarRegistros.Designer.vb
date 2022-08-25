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
        Me.dataListado = New System.Windows.Forms.DataGridView()
        Me.DTPFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.DTPFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtCCosto = New System.Windows.Forms.TextBox()
        Me.lblCCosto = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbDepartamento = New System.Windows.Forms.ComboBox()
        Me.lblDepto = New System.Windows.Forms.Label()
        CType(Me.dataListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataListado
        '
        Me.dataListado.AllowUserToOrderColumns = True
        Me.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataListado.Location = New System.Drawing.Point(12, 100)
        Me.dataListado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dataListado.Name = "dataListado"
        Me.dataListado.ReadOnly = True
        Me.dataListado.RowHeadersWidth = 51
        Me.dataListado.RowTemplate.Height = 25
        Me.dataListado.Size = New System.Drawing.Size(1119, 306)
        Me.dataListado.TabIndex = 12
        '
        'DTPFechaInicio
        '
        Me.DTPFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaInicio.Location = New System.Drawing.Point(166, 25)
        Me.DTPFechaInicio.Name = "DTPFechaInicio"
        Me.DTPFechaInicio.Size = New System.Drawing.Size(112, 27)
        Me.DTPFechaInicio.TabIndex = 13
        '
        'DTPFechaFinal
        '
        Me.DTPFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaFinal.Location = New System.Drawing.Point(166, 66)
        Me.DTPFechaFinal.Name = "DTPFechaFinal"
        Me.DTPFechaFinal.Size = New System.Drawing.Size(112, 27)
        Me.DTPFechaFinal.TabIndex = 14
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnBuscar.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnBuscar.Location = New System.Drawing.Point(990, 14)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(112, 51)
        Me.btnBuscar.TabIndex = 21
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtCCosto
        '
        Me.txtCCosto.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtCCosto.Location = New System.Drawing.Point(488, 16)
        Me.txtCCosto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCCosto.Name = "txtCCosto"
        Me.txtCCosto.Size = New System.Drawing.Size(185, 36)
        Me.txtCCosto.TabIndex = 24
        '
        'lblCCosto
        '
        Me.lblCCosto.AutoSize = True
        Me.lblCCosto.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCCosto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCCosto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCCosto.Location = New System.Drawing.Point(291, 23)
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
        Me.Label1.Location = New System.Drawing.Point(47, 19)
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
        Me.Label2.Location = New System.Drawing.Point(47, 63)
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
        Me.cmbDepartamento.Location = New System.Drawing.Point(488, 60)
        Me.cmbDepartamento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbDepartamento.Name = "cmbDepartamento"
        Me.cmbDepartamento.Size = New System.Drawing.Size(343, 37)
        Me.cmbDepartamento.TabIndex = 31
        '
        'lblDepto
        '
        Me.lblDepto.AutoSize = True
        Me.lblDepto.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDepto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDepto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDepto.Location = New System.Drawing.Point(290, 60)
        Me.lblDepto.Name = "lblDepto"
        Me.lblDepto.Size = New System.Drawing.Size(192, 33)
        Me.lblDepto.TabIndex = 30
        Me.lblDepto.Text = "Departamento:"
        Me.lblDepto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ConsultarRegistros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1143, 449)
        Me.Controls.Add(Me.cmbDepartamento)
        Me.Controls.Add(Me.lblDepto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCCosto)
        Me.Controls.Add(Me.lblCCosto)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.DTPFechaFinal)
        Me.Controls.Add(Me.DTPFechaInicio)
        Me.Controls.Add(Me.dataListado)
        Me.Name = "ConsultarRegistros"
        Me.Text = "ConsultarRegistros"
        CType(Me.dataListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dataListado As DataGridView
    Friend WithEvents DTPFechaInicio As DateTimePicker
    Friend WithEvents DTPFechaFinal As DateTimePicker
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtCCosto As TextBox
    Friend WithEvents lblCCosto As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbDepartamento As ComboBox
    Friend WithEvents lblDepto As Label
End Class
