Imports System.Data.SqlClient
Namespace Modelo
    Public Class Conexion
        Private conexion As String = "Conexion a Base de datos"
        Private conection As SqlClient.SqlConnection
        Sub New()
            Dim conection As New SqlConnection(conexion)
        End Sub
        Public Sub Conectar()
            conection.Open()
        End Sub
        Public Sub Cerrar()
            conection.Close()
        End Sub

        Property GetConexion() As Conexion

        Public ReadOnly Property MiConexion() As SqlConnection
            Get
                Return conection
            End Get

        End Property
    End Class
End Namespace

