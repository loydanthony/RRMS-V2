Public Class BookList

    Private book As Book

    

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BookList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub New(book As Book)

        ' This call is required by the designer.
        InitializeComponent()
        Me.book = book
        ' Add any initialization after the InitializeComponent() call.
        loadData()
    End Sub

    Function getPanel()
        Return Panel_WA

    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub LineShape2_Click(sender As Object, e As EventArgs) Handles LineShape2.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint
        
    End Sub

    Private Sub loadData()
        Dim runQuery As New RunQuery

        DataGridView2.DataSource = runQuery.ExecuteQuery("SELECT `book_id` As 'BOOK ID', `book_title`As 'BOOK TITTLE', `abstract` as 'ABSTRACT', `pub_date` as 'Date', `category` as 'Category', `rev_count` as 'Revision', `status` as 'Status', `views_count` as 'View Count' FROM `book` WHERE 1")
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Dim row As DataGridViewRow
        Dim runQuery As New RunQuery
        If e.RowIndex >= 0 And e.RowIndex < DataGridView2.Rows.Count - 1 Then
            row = DataGridView2.Rows(e.RowIndex)
            RichTextBox1.Text = row.Cells("BOOK TITTLE").Value.ToString
            RichTextBox2.Text = row.Cells("ABSTRACT").Value.ToString
            'TextBox_student_contact.Text = row.Cells("Contact").Value.ToString
            'TextBox_Student_Fname.Text = row.Cells("First Name").Value.ToString
            'TextBox_Student_Lname.Text = row.Cells("Last Name").Value.ToString
            'TextBox_Student_MidName.Text = row.Cells("Middle Name").Value.ToString
            'ComboBox_Student_Course.Text = row.Cells("Course").Value.ToString
            'ComboBox_Student_Gender.Text = row.Cells("Gender").Value.ToString
            'ComboBox_Student_YrLevel1.Text = row.Cells("Year Level").Value.ToString
            'student_dob.Text = row.Cells("Date of Birth").Value.
            DataGridView1.DataSource = runQuery.ExecuteQuery("SELECT `a_fname` as 'First Name', `a_mname` as 'Middle Name', `a_lname` as 'Last Name', `a_suffix` As 'Suffix' FROM `author` WHERE a_id = '" & row.Cells(0).Value.ToString & "'")
        End If

    End Sub

    Private Sub RichTextBox2_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox2.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class