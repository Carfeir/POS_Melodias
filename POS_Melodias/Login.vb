Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If validar_campos() Then
            usuarios()
            Me.Hide()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Function validar_campos() As Boolean 'Se validan que los campos no esten vacio'
        If Trim(TNombre.Text) = "" Then
            MsgBox("El campo de Nombre de Usuario esta vacio")
            validar_campos = False
        ElseIf Trim(TContraseña.Text) = "" Then
            MsgBox("El campo de Contraseña esta vacio")
            validar_campos = False
        Else
            validar_campos = True
        End If
    End Function
    Private Sub usuarios() Handles Button1.Click
        'Se comparan los datos de usuario para acceder a su determinada cuenta'
        If Trim(TNombre.Text) = "JuanSupervisor" And Trim(TContraseña.Text) = "supervisor" Then
            HomeSupervisor.Show()
        ElseIf Trim(TNombre.Text) = "JuanEmple" And Trim(TContraseña.Text) = "empleado" Then
            HomeEmpleado.Show()
        ElseIf Trim(TNombre.Text) = "JuanAdmin" And Trim(TContraseña.Text) = "admin" Then
            HomeAdmin.Show()
        End If

    End Sub
End Class
