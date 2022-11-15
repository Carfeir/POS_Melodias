﻿Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Metodos
    Private servidores As SqlDataSourceEnumerator
    Private tablaServidores As DataTable
    Private servidor As String
    Public con As SqlConnection
    Public enunciado As SqlCommand
    Public adp As SqlDataAdapter
    Public dr As SqlDataReader
    Public ds As DataSet


    Public Sub abrir()
        Try
            servidores = SqlDataSourceEnumerator.Instance
            tablaServidores = New DataTable()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    'Carga en un ComboBox los nombres de las bases de Datos'
    Function cargarBases(ByVal servers As String, ByVal cmbBasesdeDatos As ComboBox) As Boolean
        Dim salida As Boolean = True
        Try
            Dim listaBasesDatos As List(Of String) = New List(Of String)
            Dim cadenaConexion As String
            Dim selectSQL As String
            ' Se comprueba que haya un servidor seleccionado para
            ' poder conectarnos
            If servers = "" Then
                MsgBox("Debe seleccionar un servidor")

                salida = False
            Else
                servidor = servers

                'Componemos la cadena de conexión con el servidor seleccionado y
                ' seguridad integrada
                ' si la autenticación se hace con usuario y password hay
                ' que cambiar la cadena
                cadenaConexion = "Data Source=" & servidor & " ;Integrated Security=True;Initial Catalog=master"


                con = New SqlConnection(cadenaConexion)

                ' Abrimos la conexión
                con.Open()

                'Obtenemos los nombres de las bases de datos que
                ' haya en el servidor
                selectSQL = "select name from sys.databases;"

                Dim com As SqlCommand = New SqlCommand(selectSQL, con)
                dr = com.ExecuteReader()

                ' Recorremos el dataReader
                While (dr.Read())
                    cmbBasesdeDatos.Items.Add(dr(0).ToString)
                End While

                cmbBasesdeDatos.SelectedIndex = 0

            End If
        Catch ex As Exception
            MsgBox("Servidor Invalido")
            salida = False
        End Try
        Return salida
    End Function
End Class
