Public Class AgregarEmpleado
    Dim conexion As New conexion()
    Dim dt As New DataTable()
    Dim sql As String

    Private Sub AgregarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "select * From Departamentos"
        conexion.llenarComboDepartamento(sql, cmbDepartamento)
    End Sub
End Class