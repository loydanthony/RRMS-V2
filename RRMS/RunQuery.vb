Imports MySql.Data.MySqlClient

Public Class RunQuery

    Dim db_con As db_config
    Dim query As String = ""
    Dim cmd As MySqlCommand
    Dim con As MySqlConnection
    Sub New(ByVal db_con As db_config)
        Me.db_con = db_con
    End Sub

    Sub New()
        db_con = New db_config
        con = db_con.getCon
    End Sub

    Public Function ExecuteQuery(ByVal query As String)
        ''Dim con As MySqlConnection
        con = db_con.getCon
        Dim dAdapter As New MySqlDataAdapter
        Dim dTable As New DataTable
        Dim Binder As New BindingSource

        Try

            con.Open()
            Me.query = query
            cmd = New MySqlCommand(query, con)
            dAdapter.SelectCommand = cmd
            dAdapter.Fill(dTable)
            Binder.DataSource = dTable
            dAdapter.Update(dTable)
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
            Return Nothing
        Finally
            con.Dispose()
        End Try
        Return Binder
    End Function

    Function execNonQuery(ByVal query As String)
        Dim isAdded = Nothing
        Try
            con.Open()
            cmd = New MySqlCommand(query, con)
            isAdded = cmd.ExecuteNonQuery
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            isAdded = -1
        Finally
            con.Dispose()
        End Try
        '
        Return isAdded
    End Function


    Function getId(ByVal query As String)
        'Dim con As MySqlConnection
        'con = db_con.getCon
        Dim id As Integer
        Try

            con.Open()
            cmd = New MySqlCommand(query, con)
            id = cmd.ExecuteScalar

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return -1
        Finally
            con.Dispose()
        End Try

        Return id
        End

    End Function

    Public Function getSingleArr(ByVal query As String)

        con = db_con.getCon
        Dim dAdapter As New MySqlDataAdapter
        Dim dTable As New DataTable
        Try
            con.Open()
            cmd = New MySqlCommand(query, con)
            dAdapter.SelectCommand = cmd
            dAdapter.Fill(dTable)

            Dim val(dTable.Rows.Count) As String
            Dim dataRow As DataRow
            Dim size As Integer = 0
            For Each dataRow In dTable.Rows
                val(size) = dataRow.Item(0).ToString
                size += 1
            Next
            con.Close()
            Return val
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
            Return Nothing
        Finally
            con.Dispose()
        End Try
    End Function
End Class
