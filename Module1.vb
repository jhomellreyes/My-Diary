Imports System.Data.OleDb
Module Module1
    Public today = System.DateTime.Now.ToString("MMMM dd, yy   hh:mm ")
    Public con As New OleDbConnection
    Public x As New Integer
    Public Sub showdata()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter("Select * from diary", con)
        da.Fill(dt)
        Dim myrow As DataRow
        For Each myrow In dt.Rows
            Home.ListView1.Items.Add(myrow.Item(0))
            Home.ListView1.Items(Home.ListView1.Items.Count - 1).SubItems.Add(myrow.Item(1))
        Next
    End Sub

End Module
