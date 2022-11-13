Public Class Users
    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TSAgregarUsuario.Click
        AgregarUsuario.Show()

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        HomeSupervisor.Show()
        Me.Hide()
    End Sub

    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MelodiasDataSet.usuario' table. You can move, or remove it, as needed.
        Me.UsuarioTableAdapter.Fill(Me.MelodiasDataSet.usuario)
        'TODO: This line of code loads data into the 'MelodiasDataSet.rol' table. You can move, or remove it, as needed.
        Me.RolTableAdapter.Fill(Me.MelodiasDataSet.rol)

    End Sub
End Class