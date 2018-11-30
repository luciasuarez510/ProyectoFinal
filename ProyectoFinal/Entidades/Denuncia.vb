
Namespace Entidades
    Enum Delitos
        Robo
        Asesinato
        Drogas
    End Enum

    Public Class Denuncia
        Private Oficial As Persona
        Private Denunciante As Persona
        Private Denunciado As Persona
        Private Fecha As Date
        Private Comisaria As Comisaria
        Private Descripcion As String
        Private TipoDelito As Delitos
        Private TipoDenun As Boolean
        Private _ficha As List(Of Historial) 'Porque tiene muchos historiales. Ficha es el Historial, solo no quiero ser redundante

        Public Sub AgregarHistoriaAFicha(historia As Historial) 'Sub porque es una funcion void
            _ficha.Add(historia)
        End Sub

        Public ReadOnly Property GetOficial() As Persona
            Get
                Return Oficial

            End Get
        End Property
        Public ReadOnly Property GetDenunciante() As Persona
            Get
                Return Denunciante
            End Get
        End Property
        Public ReadOnly Property GetDenunciado() As Persona
            Get
                Return Denunciado
            End Get
        End Property
        Public ReadOnly Property GetComisaria() As Comisaria
            Get
                Return Comisaria
            End Get
        End Property
        Public ReadOnly Property GetDescripcion() As String
            Get
                Return Descripcion
            End Get
        End Property

        Public Property FechaF As Date
            Get
                Return Fecha
            End Get
            Set(value As Date)
                Fecha = value
            End Set
        End Property

        Public ReadOnly Property Ficha As List(Of Historial) ' Tengo que recordar instanciarlo así comienza con una lista nula, al menos
            Get
                Return _ficha
            End Get

        End Property
    End Class
End Namespace