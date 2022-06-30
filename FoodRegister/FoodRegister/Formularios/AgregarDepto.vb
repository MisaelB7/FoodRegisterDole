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
End Class