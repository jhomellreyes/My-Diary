Imports System.Data.OleDb
Public Class Edit
    Private Sub btnESave_Click(sender As Object, e As EventArgs) Handles btnESave.Click
        con.Close()
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\Diary.mdb"
        con.Open()
        Dim str As String
        str = "Update [diary] set [story] = '" & txtStory.Text & "' Where day = '" & Eddate.Text & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(str, con)
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            MsgBox("Saved")
            Home.ListView1.Items.Clear()
            showdata()
            Me.Hide()
            Home.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Home.Show()
    End Sub
End Class