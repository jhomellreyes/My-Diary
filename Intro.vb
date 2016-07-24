Imports System.Data.OleDb
Public Class Intro
    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        con.Close()
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\Diary.mdb"
        con.Open()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)

        Dim da As New OleDbDataAdapter("select * from pass", con)
        da.Fill(dt)

        For Each datarow In dt.Rows
            If txtPassword.Text = datarow.item(0) Then
                con.Close()
                Me.Hide()
                Home.Show()
            Else
                MsgBox("Wrong Password")
            End If
        Next

    End Sub

    Private Sub Intro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\Diary.mdb"
        con.Open()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)

        Dim da As New OleDbDataAdapter("select * from pass", con)
        da.Fill(dt)

        For Each datarow In dt.Rows
            If "admin" = datarow.item(0) Then
            Else
                Button2.Hide()
            End If
        Next
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Password.Show()
    End Sub
End Class
