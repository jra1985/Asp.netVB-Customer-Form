Imports System.IO.File
Public Class WebForm1
    Inherits System.Web.UI.Page
    Public alist As New ArrayList()
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim a, i As Integer
        Dim temparray() As String

        ' Be sure the path is the same when using different machines ie C/F/E
        temparray = ReadAllLines("F:\Customer Form\Customer Form\App_Data\alist2.txt")

        a = temparray.Count

        For i = 0 To a - 1
            alist.Add(temparray(i))
        Next

        a = alist.Count

        For i = 0 To a - 1
            ListBox1.Items.Add(alist(i))
        Next

        Session("alist") = alist
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim c As Integer
        Dim temp As String

        c = ListBox1.Items.Count

        temp = ListBox1.SelectedItem.ToString()

        Session("hold") = alist

        Session("temp") = temp
        Response.Redirect("webform2.aspx")
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim name, id, temp As String
        Dim c, i As Integer

        name = TextBox1.Text
        id = TextBox2.Text

        TextBox1.Text = " "
        TextBox2.Text = " "
        TextBox1.Focus()
        temp = name + "," + id
        ListBox1.Items.Add(temp)

        alist.Add(temp)

        c = alist.Count

        Dim temparray(c - 1) As String

        For i = 0 To c - 1
            temparray(i) = alist(i)
        Next

        WriteAllLines("F:\Customer Form\Customer Form\App_Data\alist2.txt", temparray)
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)


    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click






    End Sub
End Class