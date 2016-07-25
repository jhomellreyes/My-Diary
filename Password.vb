Imports System.Data.OleDb
Public Class Password
    Private Sub Password_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        con.Close()
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\Diary.mdb"
        con.Open()
        Dim str As String
        Dim x As String = "admin"
        If txtPassword.Text = txtRePass.Text Then
            str = "Update [pass] set [password] = '" & txtPassword.Text & "' Where password = '" & x & "'"
            Dim cmd As OleDbCommand = New OleDbCommand(str, con)
            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                Intro.Button2.Hide()
                Home.ListView1.Items.Clear()
                showdata()
                Me.Hide()
                Intro.Show()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("You must enter the same password twice in order to confirm it.", MsgBoxStyle.Exclamation, "Password do not match")
            txtPassword.Clear()
            txtRePass.Clear()
        End If

    End Sub
End Class