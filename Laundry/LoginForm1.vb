﻿Imports System.Data.SqlClient
Public Class LoginForm1
    Dim con As SqlConnection
    Dim dr As SqlDataReader
    Dim cmd As SqlCommand
    Dim connection As String

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If txtbx_username.Text = "" And txtbx_password.Text = "" Then
            MessageBox.Show("Enter Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If txtbx_username.Text = "" Then
            MessageBox.Show("Enter Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtbx_username.Focus()
            Exit Sub
        End If

        If txtbx_password.Text = "" Then
            MessageBox.Show("Enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        End If

        connection = "data source=ALLEN\SQLEXPRESS; initial catalog= db_Laundry ; integrated security = SSPI"

        con = New SqlConnection(connection)

        Try
            con.Open()
        Catch ex As Exception
            MessageBox.Show("connection error")
            Exit Sub
        Finally
            'MessageBox.Show("You are connected!")
            con.Close()
        End Try
        loginuser()
    End Sub
    Private Sub loginuser()

        cmd = New SqlCommand("select Username, Password from tbl_Login where Password='" & txtbx_password.Text & "' and Username='" & txtbx_username.Text & "'", con)
        cmd.CommandType = CommandType.Text
        con.Open()
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Mainframe.Show()
            Me.Hide()
        Else
            MessageBox.Show("Incorrect Username or Password", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        con.Close()
        txtbx_username.Text = ""
        txtbx_password.Text = ""

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
