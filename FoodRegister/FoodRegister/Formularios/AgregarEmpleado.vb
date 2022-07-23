Imports System.ComponentModel
Public Class AgregarEmpleado
    Dim conexion As New conexion()
    Dim dt As New DataTable()
    Dim sql As String

    Private Sub AgregarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "select * From Departamentos Order By Departamento"
        conexion.llenarComboboxEmpleados(sql, cmbDepartamento)

        sql = "select * From TipoContratos"
        conexion.llenarComboboxEmpleados(sql, cmbContrato)
    End Sub

    Private Sub insertarEmpleado()

        Dim idDepto As Object = cmbDepartamento.SelectedValue
        Dim idTipoContrato As Object = cmbContrato.SelectedValue

        Dim departamento As String
        Dim tipocontrato As String

        departamento = Convert.ToString(idDepto)
        Label1.Text = Convert.ToString(idDepto)

        tipocontrato = Convert.ToString(idTipoContrato)
        Label2.Text = Convert.ToString(idTipoContrato)

        Dim idempleado As String = txtCCosto.Text
        Dim nombre As String = StrConv(txtNombreEmpleado.Text, VbStrConv.ProperCase)
        Dim apellido As String = StrConv(txtApellidoEmpleado.Text, VbStrConv.ProperCase)
        Dim nombreApellido = nombre + " " + apellido
        Dim identidad As String = StrConv(txtIdentidad.Text, VbStrConv.ProperCase)
        Dim fkdepartamento = departamento
        Dim fktipocontrato = tipocontrato

        Try
            If conexion.insertarEmpleado(idempleado, nombre, apellido, nombreApellido, identidad, fkdepartamento, fktipocontrato) Then

                MessageBox.Show("Empleado registrado correctamente", "Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al registrar el empleado", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        insertarEmpleado()
    End Sub

    Private Sub editarDepartamento()
        Dim idDepto As Object = cmbDepartamento.SelectedValue
        Dim idTipoContrato As Object = cmbContrato.SelectedValue

        Dim departamento As String
        Dim tipocontrato As String

        departamento = Convert.ToString(idDepto)
        Label1.Text = Convert.ToString(idDepto)

        tipocontrato = Convert.ToString(idTipoContrato)
        Label2.Text = Convert.ToString(idTipoContrato)

        Dim idempleado As String = txtCCosto.Text
        Dim nombre As String = StrConv(txtNombreEmpleado.Text, VbStrConv.ProperCase)
        Dim apellido As String = StrConv(txtApellidoEmpleado.Text, VbStrConv.ProperCase)
        Dim nombreApellido = nombre + " " + apellido
        Dim identidad As String = StrConv(txtIdentidad.Text, VbStrConv.ProperCase)
        Dim fkdepartamento = departamento
        Dim fktipocontrato = tipocontrato

        Try
            If conexion.editarEmpleado(idempleado, nombre, apellido, nombreApellido, identidad, fkdepartamento, fktipocontrato) Then
                MessageBox.Show("Empleado actualizado correctamente", "Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al editar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtCCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCCosto.KeyPress
        If Not Char.IsNumber(e.KeyChar) _
                     AndAlso Not Char.IsControl(e.KeyChar) _
                     AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNombreEmpleado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreEmpleado.KeyPress
        If Not Char.IsLetter(e.KeyChar) _
                     AndAlso Not Char.IsControl(e.KeyChar) _
                     AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtApellidoEmpleado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellidoEmpleado.KeyPress
        If Not Char.IsLetter(e.KeyChar) _
                     AndAlso Not Char.IsControl(e.KeyChar) _
                     AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtIdentidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdentidad.KeyPress
        If Not Char.IsNumber(e.KeyChar) _
                     AndAlso Not Char.IsControl(e.KeyChar) _
                     AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        editarDepartamento()
    End Sub

    Private Sub eliminarEmpleado()

        Dim idempleado = txtCCosto.Text

        Try
            If conexion.eliminarDepartamento(idempleado) Then
                MessageBox.Show("El Empleado ha sido eliminado.", "Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Error al eliminar el empleado.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        eliminarEmpleado()
    End Sub
End Class