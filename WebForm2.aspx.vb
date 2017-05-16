Imports System.IO.File
Public Class WebForm2

    Inherits System.Web.UI.Page
    Dim alist2 As New ArrayList()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' NOTE FOR FUTURE****** Make if statement of id textbox = to name substring to only show certain id transactions
        'IF id textbox equals id substring show all transactions of that id 
        Dim i, c, a, s, s1 As Integer
        Dim name, temp, id As String

        alist2 = Session("hold")
        a = alist2.Count

        alist2 = Session("alist2")
        temp = Session("temp")

        c = temp.Length
        s = temp.IndexOf(",")
        s1 = temp.IndexOf(",", s + 1)

        name = temp.Substring(0, s)
        id = temp.Substring(s + 1, (c - (s + 1)))

        TextBox1.Text = name
        TextBox2.Text = id

        Session("holdname") = TextBox1.Text
        Session("holdid") = TextBox2.Text





    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Redirect("Webform3.aspx")

    End Sub



    Protected Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub



    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim translist As New ArrayList()
        Dim amtlist As New ArrayList()
        Dim a, i, c, s, s1 As Integer
        Dim amt, temp As String
        translist = Session("holdtrans")

        a = translist.Count

        For i = 0 To a - 1
            ListBox2.Items.Add(translist(i))
        Next

        Dim temparray2(a) As String

        For i = 0 To a - 1
            temparray2(i) = translist(i)
        Next





        WriteAllLines("F:\Customer Form\Customer Form\App_Data\translist.txt", temparray2)

    End Sub

    Protected Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged


    End Sub

    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim temp, amt As String
        Dim c, s, s1 As Integer
        Dim damt As Double
        Dim amttotal As Double

        'temp = ListBox2.SelectedItem.ToString

        '  c = temp.Length
        '  s = temp.IndexOf(",")
        's1 = temp.IndexOf(",", s + 1)

        'ListBox2.Items.Add(s1)
        ' amt = temp.Substring(s + 1, s1 - 3)

        amttotal = Session("damttot")


        TextBox3.Text = amttotal.ToString



    End Sub

End Class