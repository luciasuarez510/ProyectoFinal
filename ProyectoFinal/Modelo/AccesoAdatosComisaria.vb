Imports Entidades.Entidades
Namespace Modelo
    Public Class AccesoAdatosComisaria

        Public Function GetComisariasFromDB() As List(Of Comisaria)

            Dim conn As New Conexion()
            Dim listcom As New List(Of Comisaria)
            Dim cms As Comisaria
            Dim objDR As SqlClient.SqlDataReader
            Dim objCommand As SqlClient.SqlCommand
            Dim ssql As String


            ssql = "SELECT * FROM Comisarias"                                        'la consulta que queremos
            If conn.MiConexion().State <> ConnectionState.Open Then                      'si la conexion no esta abierta, la abrimos
                conn.Conectar()
            End If
            objCommand = New SqlClient.SqlCommand(ssql, conn.MiConexion())               'ejecutar un sql usando la conexion
            objDR = objCommand.ExecuteReader(CommandBehavior.CloseConnection)        'reader () <- listado de tuplas con las información de comisarias
            objCommand = Nothing                                                     'Vaciamos el command asì nadie lo toca 



            If objDR.HasRows Then
                While objDR.Read()
                    cms = New Comisaria(objDR.Item("id"), objDR.Item("nombre"), objDR.Item("direccion"))
                    listcom.Add(cms)
                End While
            End If
            objDR.Close()
            objDR = Nothing



            Return listcom
        End Function

        Public Function GetOficiales(ByRef cms As Comisaria) As List(Of Persona)
            Dim conn As New Conexion()
            Dim oficiales As New List(Of Persona)
            Dim offi As Persona
            Dim objDR As SqlClient.SqlDataReader
            Dim objCommand As SqlClient.SqlCommand
            Dim ssql As String
            ssql = "SELECT * FROM Oficiales WHERE idcomisaria = @idCom"
            If conn.MiConexion().State <> ConnectionState.Open Then                      'si la conexion no esta abierta, la abrimos
                conn.Conectar()
            End If
            objCommand = New SqlClient.SqlCommand(ssql, conn.MiConexion())
            objCommand.Parameters.AddWithValue("@idCom", cms.GetId())
            objDR = objCommand.ExecuteReader(CommandBehavior.CloseConnection)        'reader () <- listado de tuplas con las información de comisarias
            objCommand = Nothing

            If objDR.HasRows Then
                While objDR.Read()
                    offi = New Persona(objDR.Item("Nombre"), objDR.Item("Direccion"), objDR.Item("dni"), True)
                    oficiales.Add(offi)
                End While
            End If
            objDR.Close()
            objDR = Nothing
            Return oficiales
        End Function
    End Class



    'como trabajar con base de datos https://snipplr.com/view/13059/ 
End Namespace
