'No hace falta el Imports de Entidades porque ya està dentro de Entidades
'hereda de persona
'Usar namespace


Namespace Entidades

    Public Class Persona

        Private Nombre As String
        Private Direccion As String
        Private dni As Integer
        Private cargo As Boolean 'es oficial, o no 
        Sub New(ByVal nom As String, ByVal dir As String, ByVal num As Integer, ByVal es As Boolean)
            Nombre = nom
            Direccion = dir
            dni = num
            cargo = es

        End Sub
        Public ReadOnly Property GetNombre() As String
            Get
                Return Nombre
            End Get
        End Property
        Public ReadOnly Property GetDireccion() As String
            Get
                Return Direccion
            End Get
        End Property


    End Class

End Namespace