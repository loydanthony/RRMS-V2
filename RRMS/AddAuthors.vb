Public Class AddAuthors

    Private add As Add
    Private runquery As RunQuery
    ''Private auth

    Sub New(add As Add)
        ' TODO: Complete member initialization 
        InitializeComponent()
        Me.add = add

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
        Else
            ''Dim fullname As String = TextBox_fnanme.Text + " " + TextBox_mi.Text + " " + TextBox_lname.Text
            Dim fname = TextBox_fnanme.Text
            Dim mname = TextBox_mi.Text
            Dim lname = TextBox_lname.Text
            Dim suff = TextBox_suf.Text
            runquery = New RunQuery()
            Dim id As Integer

            id = getId(fname, mname, lname, suff)
            ''MessageBox.Show(id)
            
            If id > 0 Then
                InsertToGrid(id, fname, mname, lname, suff)
            Else
                ''Dim query = "INSERT INTO `author` (`a_id`, `a_fname`, `a_mname`, `a_lname`, `a_suffix`, `a_add`, `a_email`, `a_pic`) VALUES (NULL, 'Klevie Jun', 'Roflo', 'Caseres', 'Jr.', '', '', '')"
                ''MessageBox.Show("Name Not FOund")
                runquery = Nothing
                runquery = New RunQuery()
                runquery.execNonQuery("INSERT INTO `author` (`a_id`, `a_fname`, `a_mname`, `a_lname`, `a_suffix`, `a_add`, `a_email`, `a_pic`) VALUES (NULL, '" & fname & "', '" & mname & "', '" & lname & "', '" & suff & "', '', '', '')")
                id = getId(fname, mname, lname, suff)
                InsertToGrid(id, fname, mname, lname, suff)
            End If

            Me.Close()
        End If
        
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        
        ''MessageBox.Show(index)
    End Sub

    Private Sub InsertToGrid(ByVal id As Integer, ByVal fname As String, ByVal mname As String, ByVal lname As String, ByVal suff As String)
        add.DataGridView_Authour.Rows.Add(id.ToString, fname, mname, lname, suff)
    End Sub

    Private Function getId(ByVal fname As String, ByVal mname As String, ByVal lname As String, ByVal suff As String)
        Return runquery.getId("SELECT `a_id` FROM `author` WHERE a_fname = '" & fname & "' and a_mname = '" & mname & "' and a_lname = '" & lname & "' and a_suffix = '" & suff & "'")
    End Function

End Class