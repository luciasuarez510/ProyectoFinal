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
        Sub New(ByVal idd As String, ByVal nombr As String, ByVal dir As String)
            ID = idd
            Nombre = nombr
            Direccion = dir
        End Sub
        Public ReadOnly Property GetId() As String
            Get
                Return ID
            End Get
        End Property
        Public Property GSNombre() As String
            Get
                Return Nombre
            End Get
            Set(value As String)
                Nombre = value
            End Set
        End Property
    End Class
End Namespace

