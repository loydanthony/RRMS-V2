Public Class Menu
    Private f2 As Book
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
End Class
