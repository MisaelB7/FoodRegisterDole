Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class conexion
    Public conexion As SqlConnection = New SqlConnection("Data Source= FLAXTAC-LAPTOP; Initial Catalog=FoodRegister; Integrated Security=True")
    Private cmba As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public cmb As SqlCommand
    Public dr As SqlDataReader
    Private dv As New DataView
    Public datos As DataSet
    Public dt As DataTable

    Public Sub conectar()
        Try
            conexion.Open()
            'MessageBox.Show("Conexión exitosa")
        Catch ex As Exception
            MessageBox.Show("Error conexion de base de datos")
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Function mostrar_departamento() As DataTable
        Try
            conexion.Open()
            cmb = New SqlCommand("mostrar_departamento", conexion)
            cmb.CommandType = CommandType.StoredProcedure

            cmb.Connection = conexion

            If cmb.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmb)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function buscarDepartamento(departamento As String) As DataTable
        Try
            conexion.Open()
            Dim cmb As New SqlCommand("buscar_departamento", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@departamento", departamento)
            If cmb.ExecuteNonQuery <> 0 Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmb)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function insertarDepartamento(departamento As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("insertar_departamento", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@departamento", departamento)
            If cmb.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function eliminarDepartamento(departamento As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("borrar_departamento", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@departamento", departamento)
            If cmb.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function editarDepartamento(iddepartamento As Integer, departamento As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("editar_departamento", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@iddepartamento", iddepartamento)
            cmb.Parameters.AddWithValue("@departamento", departamento)
            If cmb.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try

    End Function

    Public Function llenarComboboxEmpleados(sql As String, cbo As ComboBox)
        Try
            conexion.Open()

            cmb = New SqlCommand
            da = New SqlDataAdapter
            dt = New DataTable

            With cmb
                .Connection = conexion
                .CommandText = sql
            End With

            With da
                .SelectCommand = cmb
                .Fill(dt)
            End With

            cbo.DataSource = dt
            cbo.DisplayMember = dt.Columns(1).ColumnName
            cbo.ValueMember = dt.Columns(0).ColumnName

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function insertarEmpleado(idempleado As String, nombre As String, apellido As String, nombreapellido As String, identidad As String, fkdepartamento As String, fktipocontrato As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("insertar_empleado", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@idempleado", idempleado)
            cmb.Parameters.AddWithValue("@nombre", nombre)
            cmb.Parameters.AddWithValue("@apellido", apellido)
            cmb.Parameters.AddWithValue("@nombreapellido", nombreapellido)
            cmb.Parameters.AddWithValue("@identidad", identidad)
            cmb.Parameters.AddWithValue("@fkdepartamento", fkdepartamento)
            cmb.Parameters.AddWithValue("@fktipocontrato", fktipocontrato)
            If cmb.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function
End Class
