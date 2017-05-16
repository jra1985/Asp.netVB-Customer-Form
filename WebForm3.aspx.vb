Imports System.IO.File
Public Class WebForm3
    Inherits System.Web.UI.Page
    Public translist As New ArrayList()
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim c, i As Integer
        Dim temparray() As String


        TextBox1.Text = Session("holdid")
        temparray = ReadAllLines("F:\Customer Form\Customer Form\App_Data\translist.txt")

        c = temparray.Count
        For i = 0 To c - 1
            translist.Add(temparray(i))
        Next
        translist.RemoveAt(c - 1)
    End Sub

    Protected Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged


    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim amt As String
        Dim dat As String
        Dim temp As String
        Dim id As String
        Dim damt, damttot As Double
        Dim i, c, a As Integer


        dat = TextBox3.Text
        amt = TextBox2.Text
        id = TextBox1.Text

        damt = Double.Parse(amt)

        damttot = damttot + damt

        Session("damttot") = damttot
        temp = id + "," + amt + "," + dat

        translist.Add(temp)
        Session("holdtrans") = translist

        c = translist.Count
        For i = 0 To c - 1
            ListBox1.Items.Add(translist(i))
        Next

        Response.Redirect("webform2.aspx")

    End Sub

    Protected Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class