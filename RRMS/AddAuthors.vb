Public Class AddAuthors

    Private add As Add

    Sub New(add As Add)
        ' TODO: Complete member initialization 
        add = add
        InitializeComponent()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox_mi.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox_fnanme.Text = Nothing Or
            TextBox_lname.Text = Nothing Or
            TextBox_mi.Text = Nothing Then
            MsgBox("Please complete all fields.", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub


End Class