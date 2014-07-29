Imports System.Data
Imports System.Data.SqlClient

Public Class conexionBD

    'DECLARACION DE CONSTANTES PARA LA CADENA DE CONEXION
    Public Const Server = "KIORIYLAP\SQLEXPRESS"
    Public Const usuario = "sa"
    Public Const password = "yagami"
    Public Const dataBase = "atomix"

    Public Const cadenaConexion As String = "Server=" + Server +
                                            "; uid=" + usuario +
                                            " ; pwd=" + password +
                                            " ; database=" + dataBase + ""
    'VARIABLES PARA LA CONEXION Y LAS CONSULTAS
    Public conexionBD As SqlConnection
    Public query As SqlCommand
    Public queryBuilder As SqlCommandBuilder
    Public adaptador As SqlDataAdapter
    Public reader As SqlDataReader

    'CONEXION
    Public Sub conexion()

        conexionBD = New SqlConnection(cadenaConexion)

        Try
            conexionBD.Open()

        Catch ex As SqlException
            MsgBox("Conexion Fallida")

        End Try

    End Sub

    'INSERTAR
    Public Function insertar(queryInsertar As String) As Boolean

        conexion()

        query = New SqlCommand(queryInsertar, conexionBD)

        Dim filasAfectadas As Integer = query.ExecuteNonQuery()

        conexionBD.Close()

        If filasAfectadas > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    'ELIMINAR
    Public Function eliminar(tabla As String, condicion As String) As Boolean

        conexion()

        Dim queryEliminar As String = "DELETE FROM " + tabla + " WHERE " + condicion

        query = New SqlCommand(queryEliminar, conexionBD)

        Dim filasAfectadas As Integer = query.ExecuteNonQuery()

        conexionBD.Close()

        If filasAfectadas > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    'ACTUALIZAR
    Public Function actualizar(tabla As String, datos As String, condicion As String) As Boolean

        conexion()

        Dim queryActualizar As String = "UPDATE " + tabla + " SET " + datos + " WHERE " + condicion

        query = New SqlCommand(queryActualizar, conexionBD)

        Dim filasAfectadas As Integer = query.ExecuteNonQuery()

        conexionBD.Close()

        If filasAfectadas > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    'CONSULTA
    Public Function consulta(queryConsulta As String) As SqlDataAdapter

        conexion()

        adaptador = New SqlDataAdapter(queryConsulta, conexionBD)

        conexionBD.Close()

        Return adaptador

    End Function
End Class
