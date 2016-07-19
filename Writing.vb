Imports System.Data.OleDb
Public Class Writing

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.Close()

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\Diary.mdb"
        con.Open()
        Dim str As String
        str = "Insert into diary([day],[story]) Values (?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, con)
        cmd.Parameters.Add(New OleDbParameter("day", CType(Convert.ToString(today), String)))
        cmd.Parameters.Add(New OleDbParameter("story", CType(txtStory.Text, String)))

        Try
            cmd.ExecuteNonQuery()
            MsgBox("saved")
            cmd.Dispose()
            Home.ListView1.Items.Clear()
            showdata()
            con.Close()
            Me.Hide()
            Home.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Writing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ddate.Text = System.DateTime.Now.ToString("MMMM dd, yyyy")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Home.Show()

    End Sub
End Class