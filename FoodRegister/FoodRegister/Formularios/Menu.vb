Public Class Menu
    Private Sub btnDeptos_Click(sender As Object, e As EventArgs) Handles btnDeptos.Click
        AgregarDepto.Show()
        Me.Close()
    End Sub

    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        AgregarEmpleado.Show()
        Me.Close()
    End Sub

    Private Sub btnConsumo_Click(sender As Object, e As EventArgs) Handles btnConsumo.Click
        AgregarConsumo.Show()
        Me.Close()
    End Sub

    Private Sub btnConsultas_Click(sender As Object, e As EventArgs) Handles btnConsultas.Click
        ConsultarRegistros.Show()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles reloj.Tick
        lblReloj.Text = Format(Now, "hh:mm")
    End Sub

End Class