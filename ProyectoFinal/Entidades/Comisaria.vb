Namespace Entidades
    Public Class Comisaria
        Private ID As String
        Private Nombre As String
        Private Direccion As String
        Private Oficiales As New List(Of Persona)
        'Public Property OficialesAQ(i As Integer) As Persona   VAMOS A NECESITAR AÑADIR OFICIALES A LA COMISARIA
        'Get
        'Return Oficiales.Item(i)
        'End Get
        'Set(value As Persona)
        '      
        '      Oficiales.Add(value)
        'End Set
        'End Property
        'Public Sub LevantarOficiales(listaDeOficiales As List(Of Oficial))
        '    Dim oficial As Persona
        '    'Dim o As 
        '    'o = LevantarOficialesBD(ID)
        '    For Each oficialX As Oficial In listaDeOficiales
        '        Oficiales.Add(oficialX)
        '    Next
        'End Sub
    End Class
End Namespace

