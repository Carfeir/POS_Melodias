Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Se comparan los datos de usuario para acceder a su determinada cuenta'
        If Not Validar_campos() Then
            MsgBox("No puede haber campos vacios")
        Else
            If Trim(TNombre.Text) = "JuanSupervisor" And Trim(TContraseña.Text) = "supervisor" Then
                HomeSupervisor.Show()
                Me.Hide()
                TNombre.Clear()
                TContraseña.Clear()
            ElseIf Trim(TNombre.Text) = "JuanEmple" And Trim(TContraseña.Text) = "empleado" Then
                HomeEmpleado.Show()
                Me.Hide()
                TNombre.Clear()
                TContraseña.Clear()
            ElseIf Trim(TNombre.Text) = "JuanAdmin" And Trim(TContraseña.Text) = "admin" Then
                HomeAdmin.Show()
                Me.Hide()
                TNombre.Clear()
                TContraseña.Clear()
            Else
                MsgBox("El usuario y/o contraseña no es correcta")
            End If
        End If
    End Sub

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


End Class
