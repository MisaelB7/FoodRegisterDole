Imports System.Data.SqlClient
Public Class AgregarConsumo
    Dim conexion As New conexion()
    Public cmb As SqlCommand
    Private Sub AgregarConsumo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
    End Sub
End Class