Imports MySql.Data.MySqlClient
Public Class Form1
    Public ds As New DataSet
    Public strSQL As String
    Public cmd As New MySqlCommand
    Public da As MySqlDataAdapter
    Public dr As MySqlDataReader
    Dim a, b, c, d, f
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        List()
    End Sub
    'SAVE
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        strSQL = "Insert into tbl_characters(name,damage,speed,target) values ('" & txtname.Text & "', '" & txtdamage.Text & "', '" & txtspeed.Text & "', '" & cbotarget.Text & "')"
        Dim da As New MySqlDataAdapter(strSQL, CONNECTION)
        da.Fill(ds)
        txtname.Text = ""
        txtdamage.Text = ""
        txtspeed.Text = ""
        cbotarget.text = ””
        txtname.Focus()
        List()
    End Sub
    'DELETE
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If ListView1.Items.Count > 0 Then
            For i = ListView1.Items.Count - 1 To 0 Step -1
                If ListView1.Items(i).Checked = True Then
                    strSQL = "DELETE FROM tbl_characters WHERE id = '" & ListView1.Items(i).Text & "'"
                    Dim da As New MySqlDataAdapter(strSQL, CONNECTION)
                    da.Fill(ds)
                End If
            Next i
        End If
        List()
    End Sub
    'UPDATE
    Private Sub ListView1_MouseClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        If ListView1.Items.Count > 0 Then
            Form2.Label5.Text = ListView1.SelectedItems(0).SubItems(0).Text
            Form2.txtname.Text = ListView1.SelectedItems(0).SubItems(1).Text
            Form2.txtdamage.Text = ListView1.SelectedItems(0).SubItems(2).Text
            Form2.txtspeed.Text = ListView1.SelectedItems(0).SubItems(3).Text
            Form2.cbotarget.Text = ListView1.SelectedItems(0).SubItems(4).Text
        End If
        Form2.Show()
    End Sub
    'SEARCH
    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        If ComboBox1.Text = "Name" Then
            strSQL = "SELECT * from tbl_characters where name like '%" & TextBox4.Text & "%'"
        ElseIf ComboBox1.Text = "Damage" Then
            strSQL = "SELECT * from  tbl_characters where damage like '%" & TextBox4.Text & "%'"
        ElseIf ComboBox1.Text = "Speed" Then
            strSQL = "SELECT * from tbl_characters where speed like '%" & TextBox4.Text & "%'"
        ElseIf ComboBox1.Text = "Target" Then
            strSQL = "SELECT * from tbl_characters where target like '%" & TextBox4.Text & "%'"
        End If

        CONNECTION.Open()
        cmd = New MySqlCommand(strSQL, CONNECTION)
        dr = cmd.ExecuteReader()
        ListView1.Items.Clear()

        Do While dr.Read()
            a = (dr.Item("id").ToString())
            b = (dr.Item("name").ToString())
            c = (dr.Item(“damage").ToString())
            d = (dr.Item("speed").ToString())
            f = (dr.Item("target").ToString())

            Dim lv As ListViewItem = ListView1.Items.Add(a)
            lv.SubItems.Add(b)
            lv.SubItems.Add(c)
            lv.SubItems.Add(d)
            lv.SubItems.Add(f)

        Loop
        dr.Close()
        CONNECTION.Close()
        cmd.Dispose()
    End Sub
    'DISPLAY
    Public Sub List()
        strSQL = "SELECT * FROM tbl_characters"
        CONNECTION.Open()
        cmd = New MySqlCommand(strSQL, CONNECTION)
        dr = cmd.ExecuteReader()
        ListView1.Items.Clear()

        Do While dr.Read()
            a = (dr.Item("id").ToString())
            b = (dr.Item("name").ToString())
            c = (dr.Item(“damage").ToString())
            d = (dr.Item("speed").ToString())
            f = (dr.Item("target").ToString())

            Dim lv As ListViewItem = ListView1.Items.Add(a)
            lv.SubItems.Add(b)
            lv.SubItems.Add(c)
            lv.SubItems.Add(d)
            lv.SubItems.Add(f)

        Loop
        dr.Close()
        cmd.Dispose()
        CONNECTION.Close()
    End Sub
    'CANCEL
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtname.Text = ""
        txtdamage.Text = ""
        txtspeed.Text = ""
        cbotarget.Text = ””
        txtname.Focus()
    End Sub
End Class
