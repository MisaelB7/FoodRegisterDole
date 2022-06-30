<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class registroEmpleado
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registroEmpleado))
        Me.lblTitulo = New System.Windows.Forms.Label()
<<<<<<< Updated upstream:FoodRegister/FoodRegister/Form1.Designer.vb
=======
        Me.lblNombreEmpleado = New System.Windows.Forms.Label()
        Me.lblApellidoEmpleados = New System.Windows.Forms.Label()
        Me.lblIdentidadEmpleado = New System.Windows.Forms.Label()
        Me.lblCentroDeCosto = New System.Windows.Forms.Label()
        Me.lblDepartamento = New System.Windows.Forms.Label()
        Me.lblCargo = New System.Windows.Forms.Label()
        Me.cmbPuesto = New System.Windows.Forms.ComboBox()
        Me.txtNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.txtApellidoEmpleados = New System.Windows.Forms.TextBox()
        Me.txtIdentidad = New System.Windows.Forms.TextBox()
        Me.txtCentroCosto = New System.Windows.Forms.TextBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.cmbDepto = New System.Windows.Forms.ComboBox()
>>>>>>> Stashed changes:FoodRegister/FoodRegister/Formularios/AgregarEmpleado.Designer.vb
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        resources.ApplyResources(Me.lblTitulo, "lblTitulo")
        Me.lblTitulo.Name = "lblTitulo"
        '
<<<<<<< Updated upstream:FoodRegister/FoodRegister/Form1.Designer.vb
=======
        'lblNombreEmpleado
        '
        resources.ApplyResources(Me.lblNombreEmpleado, "lblNombreEmpleado")
        Me.lblNombreEmpleado.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNombreEmpleado.Name = "lblNombreEmpleado"
        '
        'lblApellidoEmpleados
        '
        resources.ApplyResources(Me.lblApellidoEmpleados, "lblApellidoEmpleados")
        Me.lblApellidoEmpleados.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblApellidoEmpleados.Name = "lblApellidoEmpleados"
        '
        'lblIdentidadEmpleado
        '
        resources.ApplyResources(Me.lblIdentidadEmpleado, "lblIdentidadEmpleado")
        Me.lblIdentidadEmpleado.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblIdentidadEmpleado.Name = "lblIdentidadEmpleado"
        '
        'lblCentroDeCosto
        '
        resources.ApplyResources(Me.lblCentroDeCosto, "lblCentroDeCosto")
        Me.lblCentroDeCosto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCentroDeCosto.Name = "lblCentroDeCosto"
        '
        'lblDepartamento
        '
        resources.ApplyResources(Me.lblDepartamento, "lblDepartamento")
        Me.lblDepartamento.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDepartamento.Name = "lblDepartamento"
        '
        'lblCargo
        '
        resources.ApplyResources(Me.lblCargo, "lblCargo")
        Me.lblCargo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCargo.Name = "lblCargo"
        '
        'cmbPuesto
        '
        resources.ApplyResources(Me.cmbPuesto, "cmbPuesto")
        Me.cmbPuesto.FormattingEnabled = True
        Me.cmbPuesto.Name = "cmbPuesto"
        '
        'txtNombreEmpleado
        '
        resources.ApplyResources(Me.txtNombreEmpleado, "txtNombreEmpleado")
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        '
        'txtApellidoEmpleados
        '
        resources.ApplyResources(Me.txtApellidoEmpleados, "txtApellidoEmpleados")
        Me.txtApellidoEmpleados.Name = "txtApellidoEmpleados"
        '
        'txtIdentidad
        '
        resources.ApplyResources(Me.txtIdentidad, "txtIdentidad")
        Me.txtIdentidad.Name = "txtIdentidad"
        '
        'txtCentroCosto
        '
        resources.ApplyResources(Me.txtCentroCosto, "txtCentroCosto")
        Me.txtCentroCosto.Name = "txtCentroCosto"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(68, Byte), Integer))
        resources.ApplyResources(Me.btnRegistrar, "btnRegistrar")
        Me.btnRegistrar.ForeColor = System.Drawing.Color.White
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(55, Byte), Integer))
        resources.ApplyResources(Me.btnBorrar, "btnBorrar")
        Me.btnBorrar.ForeColor = System.Drawing.Color.White
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'cmbDepto
        '
        resources.ApplyResources(Me.cmbDepto, "cmbDepto")
        Me.cmbDepto.FormattingEnabled = True
        Me.cmbDepto.Name = "cmbDepto"
        '
>>>>>>> Stashed changes:FoodRegister/FoodRegister/Formularios/AgregarEmpleado.Designer.vb
        'registroEmpleado
        '
        Me.AllowDrop = True
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
<<<<<<< Updated upstream:FoodRegister/FoodRegister/Form1.Designer.vb
=======
        Me.Controls.Add(Me.cmbDepto)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.txtCentroCosto)
        Me.Controls.Add(Me.txtIdentidad)
        Me.Controls.Add(Me.txtApellidoEmpleados)
        Me.Controls.Add(Me.txtNombreEmpleado)
        Me.Controls.Add(Me.cmbPuesto)
        Me.Controls.Add(Me.lblCargo)
        Me.Controls.Add(Me.lblDepartamento)
        Me.Controls.Add(Me.lblCentroDeCosto)
        Me.Controls.Add(Me.lblIdentidadEmpleado)
        Me.Controls.Add(Me.lblApellidoEmpleados)
        Me.Controls.Add(Me.lblNombreEmpleado)
>>>>>>> Stashed changes:FoodRegister/FoodRegister/Formularios/AgregarEmpleado.Designer.vb
        Me.Controls.Add(Me.lblTitulo)
        Me.MaximizeBox = False
        Me.Name = "registroEmpleado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
<<<<<<< Updated upstream:FoodRegister/FoodRegister/Form1.Designer.vb
=======
    Friend WithEvents lblNombreEmpleado As Label
    Friend WithEvents lblApellidoEmpleados As Label
    Friend WithEvents lblIdentidadEmpleado As Label
    Friend WithEvents lblCentroDeCosto As Label
    Friend WithEvents lblDepartamento As Label
    Friend WithEvents lblCargo As Label
    Friend WithEvents cmbPuesto As ComboBox
    Friend WithEvents txtNombreEmpleado As TextBox
    Friend WithEvents txtApellidoEmpleados As TextBox
    Friend WithEvents txtIdentidad As TextBox
    Friend WithEvents txtCentroCosto As TextBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents cmbDepto As ComboBox
>>>>>>> Stashed changes:FoodRegister/FoodRegister/Formularios/AgregarEmpleado.Designer.vb
End Class
