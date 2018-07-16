Public Class Book
    Private m As New Menu
    Private add As Add
    Private Sub Panel_WA_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel_back.Paint
        'InitForm()
    End Sub

    Function getPanel(ByVal m As Menu)
        Me.m = m
        Return Panel_back
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


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub ToolStripDropDownButton3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripDropDownButton1_Click(sender As Object, e As EventArgs) Handles ToolStripDropDownButton1.Click

    End Sub

    Private Sub BookDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookDetailsToolStripMenuItem.Click

    End Sub

    Private Sub Book_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        m.Panel_WA.Controls.Clear()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Panel_WA.Controls.Clear()
        m.Panel_WA.Controls.Clear()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim bList As BookList
        bList = New BookList(Me)
        Me.Panel_WA.Controls.Add(bList.getPanel())
    End Sub
End Class