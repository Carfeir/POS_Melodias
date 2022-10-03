Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If validar_campos() Then
            TNombre.Clear()
            TContraseña.Clear()
            usuarios()
            Me.Hide()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Function Validar_campos() As Boolean 'Se validan que los campos no esten vacio'
        If Trim(TNombre.Text) = "" Then
            MsgBox("El campo de Nombre de Usuario esta vacio")
            Validar_campos = False
        ElseIf Trim(TContraseña.Text) = "" Then
            MsgBox("El campo de Contraseña esta vacio")
            Validar_campos = False
        Else
            Validar_campos = True
        End If
    End Function
    Private Sub Usuarios() Handles Button1.Click
        'Se comparan los datos de usuario para acceder a su determinada cuenta'
        If Trim(TNombre.Text) = "JuanSupervisor" And Trim(TContraseña.Text) = "supervisor" Then
            HomeSupervisor.Show()
        ElseIf Trim(TNombre.Text) = "JuanEmple" And Trim(TContraseña.Text) = "empleado" Then
            HomeEmpleado.Show()
        ElseIf Trim(TNombre.Text) = "JuanAdmin" And Trim(TContraseña.Text) = "admin" Then
            HomeAdmin.Show()
        Else
            MsgBox("El usuario y/o contraseña no es correcta")

        End If

    End Sub
End Class
