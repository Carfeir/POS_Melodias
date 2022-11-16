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

    Public Function User(ByVal nombreUsuario As String) As Boolean
        Dim resultado As Boolean = False
        Dim cadenaConexion As String

        Try
            cadenaConexion = "Data Source=DESKTOP-R1FDA93\SQLEXPRESS;Initial Catalog=melodias;Integrated Security=True"
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
            cadenaConexion = "Data Source=DESKTOP-R1FDA93\SQLEXPRESS;Initial Catalog=melodias;Integrated Security=True"
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
            cadenaConexion = "Data Source=DESKTOP-R1FDA93\SQLEXPRESS;Initial Catalog=melodias;Integrated Security=True"
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
