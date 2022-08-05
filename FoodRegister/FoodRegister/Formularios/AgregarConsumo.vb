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
        If txtCCosto.Text = "" Or txtPrecio.Text = "" Then
            MessageBox.Show("Debe ingresar ambos datos para poder registrar su consumoo", "Datos necesarios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            insertarConsumo()
        End If
    End Sub

    Private Sub txtCCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCCosto.KeyPress
        detectarNumeros(sender, e)
        detectarEspacios(sender, e)
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        detectarEspacios(sender, e)
        detectarNumeros(sender, e)
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