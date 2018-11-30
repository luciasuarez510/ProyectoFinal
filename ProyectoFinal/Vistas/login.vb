Public Class login
    Private Sub CmbComisaria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbComisaria.SelectedIndexChanged
        CmbOficial.Enabled = True
    End Sub
End Class