Imports System.ComponentModel
Public Class AgregarDepto
    Dim conexion As New conexion()
    Dim dt As New DataTable()
    Private Sub AgregarDepto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        mostrar_departamento()
        validarBotones()
    End Sub

    Public Sub mostrar_departamento()
        Try
            Dim func As New conexion
            dt = func.mostrar_departamento
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

    Private Sub buscarDepartamento()
        Dim departamento As String
        Try
            departamento = txtNombreDepartamento.Text
            dt = conexion.buscarDepartamento(departamento)

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

    Private Sub limpiar()
        txtNombreDepartamento.Clear()
    End Sub

    Private Sub validarBotones()
        If txtNombreDepartamento.Text = "" Then
            btnEditar.Enabled = False
            btnRegistrar.Enabled = False
        Else
            btnEditar.Enabled = True
            btnRegistrar.Enabled = True
        End If
    End Sub
    Private Sub insertarDepartamento()
        Dim mayus As String

        mayus = txtNombreDepartamento.Text
        Dim departamento As String = StrConv(mayus, VbStrConv.ProperCase)
        txtNombreDepartamento.Text = departamento
        Try
            If conexion.insertarDepartamento(departamento) Then
                limpiar()
                MessageBox.Show("Departamento ingresado correctamente", "Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If txtNombreDepartamento.Text = "" Then
            MessageBox.Show("Por favor escriba el nombre de un departamento.", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            insertarDepartamento()
            limpiar()
            validarBotones()
            mostrar_departamento()
        End If

    End Sub

    Private Sub eliminarDepartamento()
        Dim mayus As String

        mayus = txtNombreDepartamento.Text
        Dim departamento As String = StrConv(mayus, VbStrConv.ProperCase)
        txtNombreDepartamento.Text = departamento

        Try
            If conexion.eliminarDepartamento(departamento) Then
                MessageBox.Show("El departamento ha sido eliminado.", "Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Error al eliminar el departamento.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        If txtNombreDepartamento.Text = "" Then
            MessageBox.Show("Por favor elija un departamento.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            eliminarDepartamento()
            limpiar()
            validarBotones()
            mostrar_departamento()
        End If
    End Sub

    Private Sub editarDepartamento()
        Dim iddepartamento As Integer
        Dim mayus As String

        Dim fila = dataListado.CurrentRow.Index
        iddepartamento = dataListado.Rows(fila).Cells(0).Value

        mayus = txtNombreDepartamento.Text
        Dim departamento As String = StrConv(mayus, VbStrConv.ProperCase)
        txtNombreDepartamento.Text = departamento

        Try
            If conexion.editarDepartamento(iddepartamento, departamento) Then
                MessageBox.Show("Departamento editado correctamente", "Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al editar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If txtNombreDepartamento.Text = "" Then
            MessageBox.Show("Por favor escriba el nombre de un departamento.", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            editarDepartamento()
            limpiar()
            validarBotones()
            mostrar_departamento()
        End If


    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        buscarDepartamento()
    End Sub

    Private Sub txtNombreDepartamento_TextChanged(sender As Object, e As EventArgs) Handles txtNombreDepartamento.TextChanged
        validarBotones()
        If txtNombreDepartamento.Text = "" Then
            mostrar_departamento()
        End If
    End Sub

    Private Sub dataListado_Click(sender As Object, e As DataGridViewCellEventArgs) Handles dataListado.CellClick
        Dim departamento As String
        Dim fila = dataListado.CurrentRow.Index
        Try
            departamento = dataListado.Rows(fila).Cells(1).Value
            txtNombreDepartamento.Text = departamento
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnFormEmpleados_Click(sender As Object, e As EventArgs) Handles btnFormEmpleados.Click
        AgregarEmpleado.Show()
    End Sub
End Class