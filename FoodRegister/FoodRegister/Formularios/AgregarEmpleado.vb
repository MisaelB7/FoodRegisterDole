﻿Imports System.ComponentModel
Public Class AgregarEmpleado
    Dim conexion As New conexion()
    Dim dt As New DataTable()
    Dim sql As String

    Private Sub AgregarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "select * From Departamentos Order By idDepartamento"
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
        tipocontrato = Convert.ToString(idTipoContrato)


        Dim idempleado As String = txtCCosto.Text
        Dim nombre As String = StrConv(txtNombreEmpleado.Text, VbStrConv.ProperCase)
        Dim apellido As String = StrConv(txtApellidoEmpleado.Text, VbStrConv.ProperCase)
        Dim nombreApellido = nombre + " " + apellido
        Dim identidad As String = txtIdentidad.Text
        Dim fkdepartamento = departamento
        Dim fktipocontrato = tipocontrato

        If cmbDepartamento.Text = "Seleccione.." Then
            MessageBox.Show("Por favor seleccione un departamento.", "No ha seleccionado departamento", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                If conexion.insertarEmpleado(idempleado, nombre, apellido, nombreApellido, identidad, fkdepartamento, fktipocontrato) Then

                    MessageBox.Show("Empleado registrado correctamente", "Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Error al registrar el empleado", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        insertarEmpleado()
    End Sub

    Private Sub editarEmpleado()
        Dim idDepto As Object = cmbDepartamento.SelectedValue
        Dim idTipoContrato As Object = cmbContrato.SelectedValue

        Dim departamento = Convert.ToString(idDepto)
        Dim tipocontrato = Convert.ToString(idTipoContrato)

        Dim idempleado As String = txtCCosto.Text
        Dim nombre As String = StrConv(txtNombreEmpleado.Text, VbStrConv.ProperCase)
        Dim apellido As String = StrConv(txtApellidoEmpleado.Text, VbStrConv.ProperCase)
        Dim nombreApellido = nombre + " " + apellido
        Dim identidad As String = txtIdentidad.Text
        Dim fkdepartamento = departamento
        Dim fktipocontrato = tipocontrato

        If cmbDepartamento.Text = "Seleccione.." Then
            MessageBox.Show("Por favor seleccione un departamento.", "No ha seleccionado departamento", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                If conexion.editarEmpleado(idempleado, nombre, apellido, nombreApellido, identidad, fkdepartamento, fktipocontrato) Then
                    MessageBox.Show("Empleado actualizado correctamente", "Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Error al editar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub txtCCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCCosto.KeyPress
        detectarEspacios(sender, e)
        detectarNumeros(sender, e)
    End Sub

    Private Sub txtNombreEmpleado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreEmpleado.KeyPress
        detectarLetras(sender, e)
    End Sub

    Private Sub txtApellidoEmpleado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellidoEmpleado.KeyPress
        detectarLetras(sender, e)
    End Sub

    Private Sub txtIdentidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdentidad.KeyPress
        detectarNumeros(sender, e)
        detectarEspacios(sender, e)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        editarEmpleado()
    End Sub

    Private Sub eliminarEmpleado()

        Dim idempleado = txtCCosto.Text

        Try
            If conexion.eliminarEmpleado(idempleado) Then
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

    Private Sub buscarEmpleado()
        Dim idempleado = txtCCosto.Text
        Dim nombre As String = StrConv(txtNombreEmpleado.Text, VbStrConv.ProperCase)
        Dim sql As String
        sql = "SELECT idempleado, nombre, apellidos, identidad, fkDepartamento, fkTipoContratos From Empleados WHERE IdEmpleado LIKE '%'  +'" + idempleado + "'  + '%' OR Nombre LIKE '%'  + '" + nombre + "' + '%'"
        Try
            conexion.buscarEmpleado(sql, txtCCosto, txtNombreEmpleado, txtApellidoEmpleado, txtIdentidad, cmbDepartamento, cmbContrato)
        Catch ex As Exception
            MessageBox.Show("Error")
        End Try
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtCCosto.Text = "" And txtNombreEmpleado.Text = "" Then
            MessageBox.Show("Por favor ingrese el centro de costo del empleado.", "Campo Necesario", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            buscarEmpleado()
        End If
    End Sub

    Private Sub detectarLetras(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsLetter(e.KeyChar) _
                     AndAlso Not Char.IsControl(e.KeyChar) _
                     AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
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