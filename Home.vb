Imports System.Data.OleDb
Public Class Home
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Close()
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\Diary.mdb"
        con.Open()
        showdata()
        con.Close()
    End Sub
    Private Sub btnNewStory_Click(sender As Object, e As EventArgs) Handles btnNewStory.Click
        Me.Hide()
        Writing.Show()
        Writing.txtStory.Text = ""
    End Sub

    Private Sub btnEditStory_Click(sender As Object, e As EventArgs) Handles btnEditStory.Click
        If Not ListView1.SelectedItems.Count = 0 Then
            With ListView1.SelectedItems.Item(0)
                Edit.txtStory.Text = .SubItems(1).Text
                Edit.Eddate.Text = .SubItems(0).Text
                Edit.Show()
                Me.Hide()
                Edit.Show()
            End With
        Else
            MsgBox("Select Story First")
        End If


    End Sub

    Private Sub listView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        If Not ListView1.SelectedItems.Count = 0 Then
            With ListView1.SelectedItems.Item(0)
                View.RichTextBox1.Text = .SubItems(1).Text
                View.ddate.Text = "Day:" & .SubItems(0).Text
                View.Show()
            End With
        End If
    End Sub
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult
        result = MessageBox.Show("Are your sure you want to logout?", "My Diary", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Dispose()
        End If
    End Sub

    Private Sub btnDelStory_Click(sender As Object, e As EventArgs) Handles btnDelStory.Click
        If Not ListView1.SelectedItems.Count = 0 Then
            With ListView1.SelectedItems.Item(0)
                Dim dateee = .SubItems(0).Text
                con.Close()
                con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\Diary.mdb"
                con.Open()
                Dim str As String
                str = "Delete from [diary] Where day = '" & dateee & "'"
                Dim cmd As OleDbCommand = New OleDbCommand(str, con)
                Try
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    MsgBox("Deleted")
                    Me.ListView1.Items.Clear()
                    showdata()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End With
        End If
    End Sub
End Class