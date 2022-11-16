Imports System.Data.SqlClient
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Login
    Public m As New Metodos

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Function Validar_campos() As Boolean 'Se validan que los campos no esten vacio'
        If Trim(TNombre.Text) = "" Then
            Validar_campos = False
        ElseIf Trim(TContraseña.Text) = "" Then
            Validar_campos = False
        Else
            Validar_campos = True
        End If
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Validar_campos() Then
            Try
                If m.User(TNombre.Text) = True Then
                    Dim contra As String = m.contrasenia(TNombre.Text)
                    If contra.Equals(TContraseña.Text) = True Then
                        Me.Hide()
                        If m.ConsultaTipoUsuario(TNombre.Text) = 2 Then
                            HomeAdmin.Show()
                        ElseIf m.ConsultaTipoUsuario(TNombre.Text) = 1 Then
                            HomeSupervisor.Show()
                        Else
                            HomeEmpleado.Show()
                        End If
                    Else
                        MsgBox("Contraseña Invalida", MsgBoxStyle.Critical)
                    End If
                Else
                    MsgBox("El Usuario: " + TNombre.Text + " no se encuentra registrado")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("Completar todos los campos para ingresar")
        End If

    End Sub

    'Private Sub LinkLabelCambiarContraseña_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
    '   ChangePassword.Show()
    'End Sub

End Class
