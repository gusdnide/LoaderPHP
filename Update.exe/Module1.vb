Imports System.IO
Imports System.Net
Module Module1
    '-----------------------------------------------------
    '- Author : gusdnide 
    '- Org: TheMothership
    '-----------------------------------------------------

    Const Server As String = "http://SEUSERVER/" ' Configure seu server
    Const UpdateLink As String = Server + "update._exe" ' Arquivo da atualizaçoes
    Function ProcessoAberto(ByVal Processo As String) As Boolean
        If (Process.GetProcessesByName(Processo).Length > 0) Then
            Return True
        End If
        Return False
    End Function
    Sub BaixarAtt()
        Dim client As New WebClient()
        Try
            Console.WriteLine("Iniciando Download....")
            client.DownloadFile(UpdateLink, "Loader.exe")
            Console.WriteLine("Download Terminado.")
        Catch ex As Exception
            Console.WriteLine("Error ao conectar / salvar")
        End Try
     
    End Sub
    Sub Main()
        While (ProcessoAberto("Loader") = True)
            Console.WriteLine("Tentando fechar o loader")
            Dim proc As New Process
            proc = Process.GetProcessesByName("Loader")(0)
            If (proc.Id > 0) Then
                proc.Kill()
            Else
                Exit While
            End If
        End While
        File.Delete("Loader.exe")
        BaixarAtt()
        Process.Start("Loader.exe")
    End Sub

End Module
