﻿Public Class Menu
    Private Sub btnDeptos_Click(sender As Object, e As EventArgs) Handles btnDeptos.Click
        AgregarDepto.Show()
    End Sub

    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        AgregarEmpleado.Show()
    End Sub
End Class