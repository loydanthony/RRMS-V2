Public Class AddAuthors

    Private Function vid(ByVal ParamArray ctl() As Object) As Boolean



        For i As Integer = 0 To UBound(ctl)

            If ctl(i).text = "" Then

                ErrorProvider1.SetError(ctl(i), ctl(i).tag)

                Return False

            End If

        Next
        Return True
    End Function

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
<<<<<<< HEAD
        If TextBox_fnanme.Text = Nothing Or
            TextBox_lname.Text = Nothing Or
            TextBox_mi.Text = Nothing Then
            MsgBox("Please complete all fields.", MsgBoxStyle.Exclamation, "Error")
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
        If vid(TextBox_fnanme, TextBox_lname, TextBox_mi, TextBox_suf) = False Then
            Exit Sub

        Else
            MsgBox("Successfully Added!", MsgBoxStyle.Information, "Msg")
>>>>>>> parent of fd03cdb... Merge branch 'UI-Branch' of https://github.com/loydanthony/RRMS-V2 into UI-Branch
=======
>>>>>>> parent of 911a174... Forms With Function
=======
>>>>>>> parent of 911a174... Forms With Function
=======
>>>>>>> parent of 911a174... Forms With Function
=======
>>>>>>> parent of 911a174... Forms With Function
=======
>>>>>>> parent of 911a174... Forms With Function
=======
>>>>>>> parent of 911a174... Forms With Function
        End If
    End Sub


End Class