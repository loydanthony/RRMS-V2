Public Class Menu
    Private f2 As Book
    ''Private db_con As db_config
    Private Sub Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer_DateNow.Start()
        f2 = New Book

    End Sub


    Private Sub ToolStripStatusLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub Timer_DateNow_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_DateNow.Tick
        StripDate.Text = DateTime.Now.ToString
    End Sub

    Private Sub BookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookToolStripMenuItem.Click
        Panel_WA.Controls.Add(f2.getPanel(Me))
    End Sub

    Private Sub FTPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FTPToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click

    End Sub

    Private Sub Panel_WA_Paint(sender As Object, e As PaintEventArgs) Handles Panel_WA.Paint

    End Sub

    Private Sub BrowsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrowsToolStripMenuItem.Click
        Dim ftpBrowser As New ftpBrowser
        ftpBrowser.ShowDialog()
    End Sub
End Class
