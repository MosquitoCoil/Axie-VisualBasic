
Imports MySql.Data.MySqlClient
Public Class Form2

    Dim strsql As String
    Dim ds As New DataSet
    Public da As MySqlDataAdapter
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        strsql = "Update tbl_characters set name = '" & txtname.Text & "', damage = '" & txtdamage.Text & "', speed = '" & txtspeed.Text & "',target ='" & cbotarget.Text & "' where id = '" & Label5.Text & "'"
        Dim da As New MySqlDataAdapter(strsql, CONNECTION)
        da.Fill(ds)
        Me.Hide()
        Form1.List()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtname.Text = ""
        txtdamage.Text = ""
        txtspeed.Text = ""
        cbotarget.Text = ""
        txtname.Focus()
    End Sub

End Class
