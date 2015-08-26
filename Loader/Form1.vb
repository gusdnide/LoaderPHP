Public Class Form1
    '-----------------------------------------------------
    '- Author : gusdnide 
    '- Org: TheMothership
    '-----------------------------------------------------

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://SiteRegistro") ' Site para o registro
    End Sub
    Function Logar(ByVal Usuario As String, ByVal Senha As String) As Boolean
        'Sua funçao de logar
        Return True
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Logar(TextBox1.Text, TextBox2.Text) = True) Then
            MsgBox("Seja bem-vindo " + TextBox1.Text)
            Form2.Show()
            Me.Hide()
        Else
            MsgBox("Login/Senha incorreto, tente novamente")
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
