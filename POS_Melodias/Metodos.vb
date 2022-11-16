Imports System.Data
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
                cadenaConexion = "Data Source=LAPTOP-CV4L1LJF\SQLEXPRESS;Initial Catalog=melodias;Integrated Security=True"

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

    Public Function User(ByVal nombreUsuario As String) As Boolean
        Dim resultado As Boolean = False
        Dim cadenaConexion As String

        Try
            cadenaConexion = "Data Source=LAPTOP-CV4L1LJF\SQLEXPRESS;Initial Catalog=melodias;Integrated Security=True"
            con = New SqlConnection(cadenaConexion)
            con.Open()

            enunciado = New SqlCommand("Select nombreUsuario from usuario where nombreUsuario='" & nombreUsuario & "'", con)
            dr = enunciado.ExecuteReader

            If dr.Read Then
                resultado = True
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function


    Function contrasenia(ByVal nombreUsuario As String) As String
        Dim resultado As String = ""
        Dim cadenaConexion As String

        Try
            cadenaConexion = "Data Source=LAPTOP-CV4L1LJF\SQLEXPRESS;Initial Catalog=melodias;Integrated Security=True"
            con = New SqlConnection(cadenaConexion)
            con.Open()

            enunciado = New SqlCommand("Select contraseña from usuario where nombreUsuario='" & nombreUsuario & "'", con)
            dr = enunciado.ExecuteReader

            If dr.Read Then
                resultado = dr.Item("contraseña")
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Function ConsultaTipoUsuario(ByVal nombreUsuario As String) As Integer
        Dim resultado As Integer
        Dim cadenaConexion As String

        Try
            cadenaConexion = "Data Source=LAPTOP-CV4L1LJF\SQLEXPRESS;Initial Catalog=melodias;Integrated Security=True"
            con = New SqlConnection(cadenaConexion)
            con.Open()

            enunciado = New SqlCommand("Select IdRol from usuario where nombreUsuario='" & nombreUsuario & "'", con)
            dr = enunciado.ExecuteReader

            If dr.Read Then
                resultado = CInt(dr.Item("IdRol"))
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

End Class
