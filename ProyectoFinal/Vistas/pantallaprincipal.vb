Imports Entidades 'buscar en VISTAS -> referencias -> Agregar referencias -> elegir entidades. Sino no toma Comisaria

Public Class pantallaprincipal
    Dim comisarias As New List(Of Comisaria)
    comisarias = LevantarComisarias()
Private Sub btnMostrarD_Click(sender As Object, e As EventArgs) Handles btnMostrarD.Click

    End Sub
    'Dentro de esta funcion estaria levantarOficiales()'
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class