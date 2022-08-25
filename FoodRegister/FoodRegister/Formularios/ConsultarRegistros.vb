Public Class ConsultarRegistros
    Dim conexion As New conexion()
    Dim dt As New DataTable()
    Dim sql As String
    Private Sub ConsultarRegistros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarConsumos()

        llenarCombo()


    End Sub

    Private Sub txtCCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCCosto.KeyPress
        detectarEspacios(sender, e)
        detectarNumeros(sender, e)
    End Sub
    Private Sub llenarCombo()
        sql = "select * From Departamentos Order By idDepartamento"
        conexion.llenarComboboxEmpleados(Sql, cmbDepartamento)
    End Sub
    Private Sub mostrarConsumos()
        Try
            Dim func As New conexion
            dt = func.mostrarConsumo
            If dt.Rows.Count <> 0 Then
                dataListado.DataSource = dt
                dataListado.ColumnHeadersVisible = True
            Else
                dataListado.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub buscarConsumosFechas()
        Dim fechaInicial, fechaFinal As Date
        fechaFinal = Format(DTPFechaFinal.Value, "yyyy/MM/dd")
        fechaInicial = Format(DTPFechaInicio.Value, "yyyy/MM/dd")
        Try

            dt = conexion.bucarConsumo(fechaInicial, fechaFinal)

            If dt.Rows.Count <> 0 Then
                dataListado.DataSource = dt
                conexion.conexion.Close()
                dataListado.CurrentCell = dataListado.Item(0, 0)
            Else
                dataListado.DataSource = Nothing
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub buscarConsumosID()
        Dim fechaInicial, fechaFinal As Date
        fechaFinal = Format(DTPFechaFinal.Value, "yyyy/MM/dd")
        fechaInicial = Format(DTPFechaInicio.Value, "yyyy/MM/dd")
        Dim ccosto = txtCCosto.Text
        Try

            dt = conexion.bucarConsumoID(fechaInicial, fechaFinal, ccosto)

            If dt.Rows.Count <> 0 Then
                dataListado.DataSource = dt
                conexion.conexion.Close()
                dataListado.CurrentCell = dataListado.Item(0, 0)
            Else
                dataListado.DataSource = Nothing
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub buscarConsumosDepto()
        Dim fechaInicial, fechaFinal As Date
        fechaFinal = Format(DTPFechaFinal.Value, "yyyy/MM/dd")
        fechaInicial = Format(DTPFechaInicio.Value, "yyyy/MM/dd")
        Dim idDepto As Object = cmbDepartamento.SelectedValue
        Dim departamento = Convert.ToString(idDepto)
        Try

            dt = conexion.bucarConsumoDepto(fechaInicial, fechaFinal, departamento)

            If dt.Rows.Count <> 0 Then
                dataListado.DataSource = dt
                conexion.conexion.Close()
                dataListado.CurrentCell = dataListado.Item(0, 0)
            Else
                dataListado.DataSource = Nothing
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtCCosto.Text <> "" Then
            buscarConsumosID()
        ElseIf cmbDepartamento.Text <> "Seleccione.." Then
            buscarConsumosDepto()
        Else
            buscarConsumosFechas()
        End If
    End Sub

    Private Sub cmbDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartamento.SelectedIndexChanged
        If cmbDepartamento.Text <> "Seleccione.." Then
            txtCCosto.Clear()
            txtCCosto.Enabled = False
        Else
            txtCCosto.Enabled = True
        End If
    End Sub

    Private Sub txtNombreEmpleado_TextChanged(sender As Object, e As EventArgs) Handles txtCCosto.TextChanged
        If txtCCosto.Text <> "" Then
            cmbDepartamento.Enabled = False
        Else
            cmbDepartamento.Enabled = True
        End If
    End Sub

    Private Sub detectarNumeros(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) _
                     AndAlso Not Char.IsControl(e.KeyChar) _
                     AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub detectarEspacios(sender As Object, e As KeyPressEventArgs)
        If Char.IsSeparator(e.KeyChar) Then
            'Que anule la entrada de texto y aparezca un msgbox.
            MessageBox.Show("No se permiten los espacios.", "Error!")
            e.Handled = True
        End If
    End Sub
End Class