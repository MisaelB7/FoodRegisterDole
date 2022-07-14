Imports System.ComponentModel
Public Class AgregarDepto
    Dim conexion As New conexion()
    Dim dt As New DataTable()
    Private Sub AgregarDepto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_departamento()
        conexion.conectar()
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

            Else
                dataListado.DataSource = Nothing
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub insertarDepartamento()
        Dim mayus As String

        mayus = txtNombreDepartamento.Text
        Dim departamento As String = StrConv(mayus, VbStrConv.ProperCase)
        txtNombreDepartamento.Text = departamento
        Try
            If conexion.insertarDepartamento(departamento) Then
                txtNombreDepartamento.Clear()
                MessageBox.Show("Departamento ingresado correctamente", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtNombreEmpleado_TextChanged(sender As Object, e As EventArgs) Handles txtNombreDepartamento.TextChanged
        buscarDepartamento()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If txtNombreDepartamento.Text = "" Then
            MessageBox.Show("Por favor escriba el nombre de un departamento.", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            insertarDepartamento()
        End If

    End Sub

    Private Sub eliminarDepartamento()
        Dim mayus As String

        mayus = txtNombreDepartamento.Text
        Dim departamento As String = StrConv(mayus, VbStrConv.ProperCase)
        txtNombreDepartamento.Text = departamento

        Try
            If conexion.eliminarDepartamento(departamento) Then
                MessageBox.Show("El departamento ha sido eliminado.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Error al eliminar el departamento.", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        eliminarDepartamento()
    End Sub

    Private Sub dataListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListado.CellClick
        Dim fila = dataListado.CurrentRow.Index
        txtNombreDepartamento.Text = dataListado.Rows(fila).Cells(1).Value
    End Sub

End Class