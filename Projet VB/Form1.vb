Public Class frm_authentifier
    Private Sub init()
        txt_login.Clear()
        txt_pw.Clear()
    End Sub
    Private Sub btn_valider_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        init()

    End Sub

    Private Sub btn_valider_Click_1(sender As Object, e As EventArgs) Handles btn_valider.Click
        Dim login As String
        Dim pw As String
        login = txt_login.Text
        pw = txt_pw.Text
        If (login = "admin") And (pw = "1234") Then
            Me.Hide()
            frm_Gestion.Show()
        Else
            init()
        End If
    End Sub

    Private Sub txt_pw_TextChanged(sender As Object, e As EventArgs) Handles txt_pw.TextChanged
        Dim password As String
        password = txt_pw.PasswordChar
    End Sub
End Class
