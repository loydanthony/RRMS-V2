Public Class Book
    Private m As New Menu
    Private add As Add
    Private Sub Panel_WA_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel_WA.Paint
        'InitForm()
    End Sub

    Function getPanel(ByVal m As Menu)
        Me.m = m
        Return Panel_WA
    End Function

    Private Sub InitForm()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        m.Panel_WA.Controls.Clear()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click

    End Sub

    Private Sub AddNewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewToolStripMenuItem.Click

        '' ADD DOCUMENT
        add = New Add(Me)
        add.ShowDialog()
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub ToolStripDropDownButton3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripDropDownButton1_Click(sender As Object, e As EventArgs) Handles ToolStripDropDownButton1.Click

    End Sub

    Private Sub BookDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookDetailsToolStripMenuItem.Click

    End Sub

    Private Sub Book_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        m.Panel_WA.Controls.Clear()
    End Sub
End Class