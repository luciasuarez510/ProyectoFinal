Namespace Entidades
    Public Class Historial

        Private Cmsr As Comisaria       'En esta comisaria
        Private oficial As Persona      'Este oficial
        Private fecha As Date           'en esta fecha
        Private CambioDepFis As String      'Cambia a tal dependencia/fiscalia

        Public ReadOnly Property GetCambio() As String ' Hacer Enum??? 
            Get
                Return CambioDepFis
            End Get
        End Property
        Public ReadOnly Property GetComisaria() As Comisaria
            Get
                Return Cmsr
            End Get
        End Property
        Public ReadOnly Property GetOficial() As Persona
            Get
                Return oficial
            End Get
        End Property

    End Class
End Namespace
