Imports Entidades.Entidades

Public Class AccesoAdatosComisaria

    Public Function GetComisariasFromDB(objConnection As SqlClient.SqlConnection) As SqlClient.SqlDataReader
        Dim objDR As SqlClient.SqlDataReader
        Dim objCommand As SqlClient.SqlCommand
        Dim ssql As String
        ssql = "SELECT * FROM Comisarias"                                        'la consulta que queremos
        If objConnection.State <> ConnectionState.Open Then                      'si la conexion no esta abierta, la abrimos
            objConnection.Open()
        End If
        objCommand = New SqlClient.SqlCommand(ssql, objConnection)               'ejecutar un sql usando la conexion
        objDR = objCommand.ExecuteReader(CommandBehavior.CloseConnection)        'reader () <- listado de tuplas con las información de comisarias
        objCommand = Nothing                                                     'Vaciamos el command asì nadie lo toca 
        Return objDR                                                             'retorne el reader 
    End Function
    'hacemos la conexion en el controlador, y que esta funcion reciba por referencia el reader

End Class



'como trabajar con base de datos https://snipplr.com/view/13059/ 