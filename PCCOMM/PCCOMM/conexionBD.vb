Imports System.Data
Imports System.Data.SqlClient

Public Class conexionBD

    'DECLARACION DE CONSTANTES PARA LA CADENA DE CONEXION
    Public Const Server = "KIORIYLAP\SQLEXPRESS"
    Public Const usuario = "sa"
    Public Const password = "yagami"
    Public Const dataBase = "atomix"

    Public Const cadenaConexion As String = "Server=" + Server + "; uid=" + usuario + " ; pwd=" + password + " ; database=" + dataBase + ""

    'VARIABLES PARA LA CONEXION Y LAS CONSULTAS
    Public conexionBD As SqlConnection
    Public queryCommand As SqlCommand
    Public queryBuilder As SqlCommandBuilder
    Public adaptador As SqlDataAdapter
    Public reader As SqlDataReader
    Public obtenerDato As DataSet


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

        queryCommand = New SqlCommand(queryInsertar, conexionBD)

        Dim filasAfectadas As Integer = queryCommand.ExecuteNonQuery()

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

        queryCommand = New SqlCommand(queryEliminar, conexionBD)

        Dim filasAfectadas As Integer = queryCommand.ExecuteNonQuery()

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

        queryCommand = New SqlCommand(queryActualizar, conexionBD)

        Dim filasAfectadas As Integer = queryCommand.ExecuteNonQuery()

        conexionBD.Close()

        If filasAfectadas > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    'CONSULTA
    Public Function consultaAdaptador(queryConsulta As String) As SqlDataAdapter

        conexion()

        adaptador = New SqlDataAdapter(queryConsulta, conexionBD)

        conexionBD.Close()

        Return adaptador

    End Function

    'CONSULTA READER
    Public Sub consultaReader(queryConsulta As String)

        conexion()

        queryCommand = New SqlCommand(queryConsulta, conexionBD)

        reader = queryCommand.ExecuteReader()

    End Sub

    'CERRAR CONEXION
    Public Sub cerrarConexion()

        If conexionBD.State = ConnectionState.Open Then

            conexionBD.Close()
        End If
    End Sub

    'LLENAR COMBOBOX
    Public Sub llenarComboBox(miComboBox As ComboBox, columna As String, tabla As String, condicion As String, orderBy As String, conCondicion As Boolean)

        Dim sqlLlenarComboBox As String = ""

        If conCondicion Then
            sqlLlenarComboBox = "SELECT " + columna + " FROM " + tabla + " WHERE " + condicion + " ORDER BY " + orderBy + " ASC"
        Else
            sqlLlenarComboBox = "SELECT " + columna + " FROM " + tabla + " ORDER BY " + orderBy + " ASC"
        End If

        obtenerDato = New DataSet
        obtenerDato.Reset()
        adaptador = consultaAdaptador(sqlLlenarComboBox)
        adaptador.Fill(obtenerDato, tabla)

        miComboBox.DataSource = obtenerDato.Tables(tabla)
        miComboBox.DisplayMember = columna
        miComboBox.SelectedIndex = -1
        frmAltaOrdenLaboratorio.entra = 1 'si noy hay datos marca un error en el index al cargar el precio
        frmEditarOrdenLaboratorio.entra = 1
    End Sub

    'LLENAR DATA GRID VIEW
    Public Sub llenarDataGridView(miDataGridView As DataGridView, columnas As String, tabla As String, orderBy As String)

        obtenerDato = New DataSet
        obtenerDato.Reset()
        adaptador = consultaAdaptador("SELECT " + columnas + " FROM " + tabla + " ORDER BY " + orderBy + " ASC")
        adaptador.Fill(obtenerDato, tabla)

        miDataGridView.DataSource = obtenerDato.Tables(0)

    End Sub

    'BUSCAR DATA GRID VIEW
    Public Sub buscarDataGridView(miDataGridView As DataGridView, queryBuscar As String, tabla As String)

        obtenerDato = New DataSet
        obtenerDato.Reset()
        adaptador = consultaAdaptador(queryBuscar)
        adaptador.Fill(obtenerDato, tabla)

        miDataGridView.DataSource = obtenerDato.Tables(0)

    End Sub

    'INSERTAR DATA GRID VIEW
    Public Sub insertarDataGridView(miDataGridView As DataGridView, columnas As String, tabla As String, orderBy As String)

        obtenerDato = New DataSet
        obtenerDato.Reset()
        adaptador = consultaAdaptador("SELECT " + columnas + " FROM " + tabla + " ORDER BY " + orderBy + " ASC")
        adaptador.Fill(obtenerDato, tabla)

        miDataGridView.DataSource = obtenerDato.Tables(tabla)
        miDataGridView.Rows.Insert(columnas)
    End Sub

End Class

