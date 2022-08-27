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

    Public Function mostrarDepartamento() As DataTable
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

    Public Function insertarEmpleado(identidad As String, nombre As String, apellido As String, nombreapellido As String, ccosto As String, fkdepartamento As String, fktipocontrato As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("insertar_empleado", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@identidad", identidad)
            cmb.Parameters.AddWithValue("@nombre", nombre)
            cmb.Parameters.AddWithValue("@apellido", apellido)
            cmb.Parameters.AddWithValue("@nombreapellido", nombreapellido)
            cmb.Parameters.AddWithValue("@ccosto", ccosto)
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

    Public Function editarEmpleado(identidad As String, nombre As String, apellido As String, nombreapellido As String, ccosto As String, fkdepartamento As String, fktipocontrato As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("editar_empleado", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@identidad", identidad)
            cmb.Parameters.AddWithValue("@nombre", nombre)
            cmb.Parameters.AddWithValue("@apellido", apellido)
            cmb.Parameters.AddWithValue("@nombreapellido", nombreapellido)
            cmb.Parameters.AddWithValue("@ccosto", ccosto)
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

    Public Function eliminarEmpleado(identidad As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("borrar_empleado", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@identidad", identidad)
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

    Public Function buscarEmpleado(sql As String, ccosto As TextBox, nombreEmpleado As TextBox, apellidoEmpleado As TextBox, identidad As TextBox, departamento As ComboBox, tipoContrato As ComboBox)
        cmb = New SqlCommand(sql, conexion)
        conexion.Open()
        Try
            dr = cmb.ExecuteReader()
            If (dr.Read()) Then
                identidad.Text = dr("identidad").ToString
                nombreEmpleado.Text = dr("nombre").ToString()
                apellidoEmpleado.Text = dr("apellidos").ToString()
                ccosto.Text = dr("ccosto").ToString
                departamento.SelectedValue = dr("fkDepartamento")
                tipoContrato.SelectedValue = dr("fkTipoContratos")
            Else
                MessageBox.Show("Empleado no encontrado, compruebe su número de identidad", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function insertarConsumo(fecha As Date, fkempleado As String, precio As String, comida As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("insertar_consumo", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@fecha", fecha)
            cmb.Parameters.AddWithValue("@fkempleado", fkempleado)
            cmb.Parameters.AddWithValue("@costo", precio)
            cmb.Parameters.AddWithValue("@comida", comida)
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

    Public Function mostrarConsumo()
        Try
            conexion.Open()
            cmb = New SqlCommand("mostrar_consumo", conexion)
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

    Public Function bucarConsumo(fechaInicial As Date, fechaFinal As Date) As DataTable
        Try
            conexion.Open()
            Dim cmb As New SqlCommand("buscar_consumoFecha", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@fechaInicial", fechaInicial)
            cmb.Parameters.AddWithValue("@fechaFinal", fechaFinal)
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

    Public Function bucarConsumoID(fechaInicial As Date, fechaFinal As Date, identidad As String) As DataTable
        Try
            conexion.Open()
            Dim cmb As New SqlCommand("buscar_consumoIdEmpleado", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@fechaInicial", fechaInicial)
            cmb.Parameters.AddWithValue("@fechaFinal", fechaFinal)
            cmb.Parameters.AddWithValue("@fkempleado", identidad)
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

    Public Function bucarConsumoDepto(fechaInicial As Date, fechaFinal As Date, departamento As String) As DataTable
        Try
            conexion.Open()
            Dim cmb As New SqlCommand("buscar_consumoDepartamento", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@fechaInicial", fechaInicial)
            cmb.Parameters.AddWithValue("@fechaFinal", fechaFinal)
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

    Public Function bucarConsumoCcosto(fechaInicial As Date, fechaFinal As Date, ccosto As String) As DataTable
        Try
            conexion.Open()
            Dim cmb As New SqlCommand("buscar_consumoCcosto", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@fechaInicial", fechaInicial)
            cmb.Parameters.AddWithValue("@fechaFinal", fechaFinal)
            cmb.Parameters.AddWithValue("@ccosto", ccosto)
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
End Class
