Public Class Form2
    '-----------------------------------------------------
    '- Author : gusdnide 
    '- Org: TheMothership
    '-----------------------------------------------------
    Public Loader As New Loader_Class
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loader.Configurar()
        Me.Text = Loader.attTitulo + " || " + Loader.attVersao
        Timer1.Start()
    End Sub
    Private Function Atualizar() As Boolean
        If (Loader.attVersao = Loader.Versao) Then
            Return False
        Else
            Return True
        End If
    End Function
    Sub Injetar(ByVal Processo As String, ByVal DLL As String)
        'Sua funçao de injetar

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Dim wc As New System.Net.WebClient()
            If (Atualizar() = True) Then
                MsgBox("Novas atualizaçoes disponivel")
                Process.Start("Update.exe")
                Application.Exit()
            Else
                ToolStripStatusLabel1.Text = "Baixando dll..."
                ToolStripStatusLabel1.ForeColor = Color.Blue
                wc.DownloadFile(Loader.Server + "hack._dll", "hack.dll")
                If (System.IO.File.Exists("hack.dll") = True) Then
                    Timer2.Start()
                    Timer1.Stop()
                Else
                    ToolStripStatusLabel1.Text = "Ocorreu um error, por favor reinicie"
                    ToolStripStatusLabel1.ForeColor = Color.Red
                    Timer1.Stop()
                    Me.Close()
                    Form1.Show()
                End If
            End If
        Catch ex As Exception
            ToolStripStatusLabel1.Text = "Ocorreu um error, por favor reinicie"
            ToolStripStatusLabel1.ForeColor = Color.Red
            Timer1.Stop()
            Me.Close()
            Form1.Show()
        End Try

    End Sub
    Function ProcessoAberto(ByVal Processo As String) As Boolean
        If (Process.GetProcessesByName(Processo).Length > 0) Then
            Return True
        End If
        Return False
    End Function
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If (ProcessoAberto("Crossfire") = True) Then
            Injetar("Crossfire", "hack.dll")
            ToolStripStatusLabel1.Text = "Injetado com sucesso!"
            ToolStripStatusLabel1.ForeColor = Color.Green
        Else
            ToolStripStatusLabel1.Text = "Aguardando abrir jogo."
            ToolStripStatusLabel1.ForeColor = Color.Orange
        End If
    End Sub
End Class

