Imports System.Net
Imports System.IO

Public Class ftpBrowser
    Dim txtserver As String = "ftp://127.0.0.1/"
    Dim txtusername As String = "klevie"
    Dim txtpassword As String = "admin1234"
    Private Sub ftpBrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''txtserver.Select()
        tvserver.Nodes.Item(0).Collapse()
        loadftpremote(txtserver, tvserver)
    End Sub

    Public Sub loadftpremote(ByVal dirpath As String, etree As TreeView)

        Try
            etree.Nodes.Item(0).Nodes.Clear()
            etree.BeginUpdate()
            Dim request As FtpWebRequest = DirectCast(WebRequest.Create(dirpath), FtpWebRequest)
            request.Method = WebRequestMethods.Ftp.ListDirectory
            request.Credentials = New NetworkCredential(txtusername, txtpassword)
            Dim response As FtpWebResponse = DirectCast(request.GetResponse(), FtpWebResponse)
            Dim responseStream As Stream = response.GetResponseStream()
            Dim reader As New StreamReader(responseStream)
            Do While reader.Peek() >= 0
                Dim nd As TreeNode = New TreeNode(reader.ReadLine())
                etree.Nodes.Item(0).Nodes.Add(nd)
                'etree.Nodes.Item(0).im()
            Loop
            reader.Close()
            response.Close()
            etree.Nodes.Item(0).Expand()
            etree.EndUpdate()
            ''MessageBox.Show("ok")

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub tvserver_AfterExpand(sender As Object, e As TreeViewEventArgs) Handles tvserver.AfterExpand
        tvserver.BeginUpdate()
        Dim node As TreeNode = e.Node
        For Each Cnode As TreeNode In node.Nodes

            Dim pathbuilder As String = txtserver & properremotelink(Cnode.FullPath)
            If Not Path.HasExtension(pathbuilder) Then
                Cnode.Nodes.Clear()
                Dim request As FtpWebRequest = DirectCast(WebRequest.Create(pathbuilder), FtpWebRequest)
                request.Method = WebRequestMethods.Ftp.ListDirectory
                request.Credentials = New NetworkCredential(txtusername, txtpassword)
                Dim response As FtpWebResponse = DirectCast(request.GetResponse(), FtpWebResponse)
                Dim responsestream As Stream = response.GetResponseStream()
                Dim reader As New StreamReader(responsestream)
                Dim strlist As New List(Of String)
                Do While reader.Peek() >= 0
                    Dim xnode As TreeNode = New TreeNode(Path.GetFileName(reader.ReadLine()))
                    Cnode.Nodes.Add(xnode)

                Loop
                reader.Close()
                response.Close()



            End If
        Next

        tvserver.EndUpdate()
    End Sub

    Private Sub tvserver_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvserver.AfterSelect
        ToolStripStatusLabel1.Text = txtserver & properremotelink(e.Node.FullPath)

    End Sub

    Private Sub tvserver_BeforeExpand(sender As Object, e As TreeViewCancelEventArgs) Handles tvserver.BeforeExpand


    End Sub
    Public Function properremotelink(ByVal input As String) As String
        Dim output As String = input
        If input.StartsWith("FTP Server") Then output = input.ToString.Remove(0, 10)
        Return output


    End Function

End Class