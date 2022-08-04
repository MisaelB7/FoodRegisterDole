Imports System.Data.SqlClient
Public Class AgregarConsumo
    Dim conexion As New conexion()
    Public cmb As SqlCommand
    Private Sub AgregarConsumo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
    End Sub

    Private Sub insertarConsumo()
        Dim fechaHoraActual As Date
        Dim comida As String
        fechaHoraActual = DateTime.Now
        Dim horaActual = Hour(fechaHoraActual)
        Dim fechaActual = Format(fechaHoraActual, "dd/MM/yyyy")

        Dim fkempleado = txtCCosto.Text
        Dim precio = txtPrecio.Text
        Dim desayuno, almuerzo, cena As String

        desayuno = precio
        almuerzo = precio
        cena = precio
        If horaActual >= 4 And horaActual <= 9 Then
            comida = "desayuno"
            Try
                If conexion.insertarConsumo(fechaActual, fkempleado, desayuno, almuerzo, cena, comida) Then
                    MessageBox.Show("Se ha ingresado su desayuno correctamente.", "Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf horaActual >= 11 And horaActual <= 13 Then
            comida = "almuerzo"
            Try
                If conexion.insertarConsumo(fechaActual, fkempleado, desayuno, almuerzo, cena, comida) Then
                    MessageBox.Show("Se ha ingresado su almuerzo correctamente.", "Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf horaActual >= 17 And horaActual <= 23 Then
            comida = "cena"
            Try
                If conexion.insertarConsumo(fechaActual, fkempleado, desayuno, almuerzo, cena, comida) Then
                    MessageBox.Show("Se ha ingresado su cena correctamente.", "Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Aun no es hora de la comida.", "Horario Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        insertarConsumo()
    End Sub
End Class