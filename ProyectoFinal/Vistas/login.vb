Imports Modelo.Modelo
Imports Entidades.Entidades
Public Class login
    Dim comisari As Comisaria
    Dim oficial As Persona
    Private Sub CmbComisaria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbComisaria.SelectedIndexChanged
        CmbOficial.Enabled = True

    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listadecomisarias As New List(Of Comisaria)
        Dim acceso As New AccesoAdatosComisaria
        listadecomisarias = acceso.GetComisariasFromDB()
        For Each com As Comisaria In listadecomisarias
            CmbComisaria.Items.Add(com.GSNombre())
        Next

    End Sub
End Class