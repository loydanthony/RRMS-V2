Public Class Add
    Dim addAut As AddAuthors
    Private book As Book
    Private runQuery As RunQuery

    Sub New(book As Book)
        ' TODO: Complete member initialization 
        InitializeComponent()
        Me.book = book
    End Sub

    Private Sub Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        addAut = New AddAuthors(Me)
        addAut.ShowDialog()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub DataGridView_Authour_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_Authour.CellContentClick

    End Sub


    Private Sub RichTextBox_b_title_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox_b_title.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox_advSuff.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox_advLName.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox_advMid.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        Dim b_tittle As String = RichTextBox_b_title.Text
        Dim b_stat As String = ""

        If Radio_onGoing.Checked Then
            b_stat = Radio_onGoing.Text
        ElseIf Radio_pubed.Checked Then
            b_stat = Radio_pubed.Text
        ElseIf Radio_unpub.Checked Then
            b_stat = Radio_unpub.Text
        End If

        Dim b_pubDate As Date = Date.Now
        Dim dateStrin = b_pubDate.ToString("yyyy-MM-dd")
        Dim b_cat As String = TextBox_categ.Text
        Dim b_en As Int16 = 0

        runQuery = New RunQuery

        Dim adv_fname = TextBox_advFname.Text
        Dim adv_midName = TextBox_advMid.Text
        Dim adv_last = TextBox_advLName.Text
        Dim adv_suff = TextBox_advSuff.Text

        ''INSERT BOOK
        runQuery.execNonQuery("INSERT INTO `book` (`book_id`, `book_title`, `abstract`, `pub_date`, `category`, `rev_count`, `status`, `enabled`, `views_count`) VALUES ('NULL', '" & b_tittle & "', '', '" & dateStrin & "', '" & b_cat & "', '0', '" & b_stat & "', '0', '0')")

        ''GET BOOK ID INSERTED
        Dim book_id As Integer = runQuery.getId("SELECT book_id FROM `book` where `book_title` ='" & b_tittle & "'")

        ''INSERT ADVISER
        runQuery.execNonQuery("INSERT INTO `adviser` (`adv_id`, `adv_fname`, `adv_midName`, `adv_Lname`, `adv_suff`, `adv_email`) VALUES (NULL, '" & adv_fname & "', '" & adv_midName & "', '" & adv_last & "', '" & adv_suff & "', '')")

        ''GET ADVISER ID
        Dim adv_id = runQuery.getId("SELECT adv_id FROM `adviser` WHERE adv_fname = '" & adv_fname & "' and adv_midName = '" & adv_midName & "' and adv_Lname = '" & adv_last & "' and adv_suff = '" & adv_suff & "'")

        ''INSER JUNCTION TABLE OF ADVISER AND BOOK
        runQuery.execNonQuery("INSERT INTO `junc_advicerbook` (`id`, `book_id`, `adv_id`) VALUES (NULL, '" & book_id.ToString & "', '" & adv_id.ToString & "')")

        For i As Integer = 0 To DataGridView_Authour.Rows.Count - 2
            Dim author_id = DataGridView_Authour.Rows(i).Cells(0).Value.ToString
            runQuery.execNonQuery("INSERT INTO `junc_authorbook` (`id`, `book_id`, `aut_id`) VALUES ('', '" & book_id.ToString & "', '" & author_id.ToString & "')")
        Next
        MsgBox("Add Sucessful!", MsgBoxStyle.Information, "Successful")
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class