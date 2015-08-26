Imports System.Net
Public Class Loader_Class
    '-----------------------------------------------------
    '- Author : gusdnide 
    '- Org: TheMothership
    '-----------------------------------------------------
    '
    '             Configuraçoes
    '
    '
    Public Server As String = "http://SEUSERVER/"
    Public Versao As String = "1.0" ' Versao
    '
    '             Componentes
    '
    Private WC As New WebClient()
    Public StatusLoader As String = WC.DownloadString(Server + "config.conf") 'Link da Config
    Private Linha() As String
    '
    '             Funçoes 
    '
    Public Sub Configurar() 'Configura para poder pegar ( Usar isso sempre que for puxar as informaçoes do seu server)
        Dim t As New TextBox
        t.Text = StatusLoader
        Linha = t.Lines()
    End Sub
    Public Function attTitulo() As String 'Retorna o titulo do server
        Return Linha(1)
    End Function
    Public Function attVersao() As String 'Retorna a versao do server
        Return Linha(0)
    End Function
End Class