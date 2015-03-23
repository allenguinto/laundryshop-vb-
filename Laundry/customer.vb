Imports System.Data.SqlClient
Public Class customer
    Dim con As SqlConnection = New SqlConnection("Data Source=ALLEN\SQLEXPRESS; Database = db_Laundry; Trusted_Connection =yes;")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    Dim ds As DataSet
    Dim dr As SqlDataReader
    Friend ID As String
    Public Sub customer()
        cmd = New SqlCommand("Insert Into tbl_customer (customer_name, customer_address, customer_contactno) Values ('" + txtbx_customername.Text + "', '" + txtbx_address.Text + "','" + txtbx_contactno.Text + "')", con)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet()
        da.Fill(ds, "db_Laundry")
    End Sub
    Public Sub view()
        Dim str As String = "Select * From tbl_customer"
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim TABLE As New DataTable
        Dim i As Integer

        With cmd
            .CommandText = str
            .Connection = con
        End With

        With da
            .SelectCommand = cmd
            .Fill(TABLE)
        End With

        ListView3.Items.Clear()
        For i = 0 To TABLE.Rows.Count - 1
            With ListView3

                .Items.Add(TABLE.Rows(i)("customer_id"))

                With .Items(.Items.Count - 1).SubItems
                    .Add(TABLE.Rows(i)("customer_name"))
                    .Add(TABLE.Rows(i)("customer_address"))
                    .Add(TABLE.Rows(i)("customer_contactno"))
                End With
            End With

        Next
    End Sub
    Public Sub view2()
        Dim str As String = "Select * From tbl_customer"
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim TABLE As New DataTable
        Dim i As Integer

        With cmd
            .CommandText = str
            .Connection = con
        End With

        With da
            .SelectCommand = cmd
            .Fill(TABLE)
        End With

        ListViews.Items.Clear()
        For i = 0 To TABLE.Rows.Count - 1
            With ListViews

                .Items.Add(TABLE.Rows(i)("customer_id"))

                With .Items(.Items.Count - 1).SubItems
                    .Add(TABLE.Rows(i)("customer_name"))
                    .Add(TABLE.Rows(i)("customer_address"))
                    .Add(TABLE.Rows(i)("customer_contactno"))
                End With
            End With

        Next
    End Sub
    Public Sub view1()
        Dim str As String = "Select * From tbl_customer"
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim TABLE As New DataTable
        Dim i As Integer

        With cmd
            .CommandText = str
            .Connection = con
        End With

        With da
            .SelectCommand = cmd
            .Fill(TABLE)
        End With

        ListViewe.Items.Clear()
        For i = 0 To TABLE.Rows.Count - 1
            With ListViewe

                .Items.Add(TABLE.Rows(i)("customer_id"))

                With .Items(.Items.Count - 1).SubItems
                    .Add(TABLE.Rows(i)("customer_name"))
                    .Add(TABLE.Rows(i)("customer_address"))
                    .Add(TABLE.Rows(i)("customer_contactno"))
                End With
            End With

        Next
    End Sub
    Private Sub btn_services_Click(sender As System.Object, e As System.EventArgs) Handles btn_customer.Click

    End Sub

    Private Sub btn_transaction_Click(sender As System.Object, e As System.EventArgs) Handles btn_transaction.Click
        Me.Hide()
        transaction.Show()
    End Sub

    Private Sub btn_history_Click(sender As System.Object, e As System.EventArgs) Handles btn_history.Click
        Me.Hide()
        History.Show()
    End Sub

    Private Sub btn_settings_Click(sender As System.Object, e As System.EventArgs) Handles btn_settings.Click
        Me.Hide()
        settings.Show()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        LoginForm1.Show()
    End Sub
    Private Sub btn_add2_Click(sender As System.Object, e As System.EventArgs) Handles btn_add2.Click
        customer()
        view()
        view1()
        view2()
        view3()
        clearitems()
    End Sub
    Private Sub clearitems()
        txtbx_customername.Text = ""
        txtbx_address.Text = ""
        txtbx_contactno.Text = ""
    End Sub
    Private Sub ListView3_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles ListView3.MouseClick
        ID = ListView3.SelectedItems(0).Text
        transaction.Show()
        Me.Hide()
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim str As String = "Select * From tbl_customer Where customer_name ='" + txtbx_searchn.Text + "' or customer_address ='" + txtbx_searcha.Text + "' or customer_contactno ='" + txtbx_searchc.Text + "'"
            Dim cmd As New SqlCommand
            Dim da As New SqlDataAdapter
            Dim TABLE As New DataTable
            Dim i As Integer

            With cmd
                .CommandText = str
                .Connection = con
            End With

            With da
                .SelectCommand = cmd
                .Fill(TABLE)
            End With

        ListViews.Items.Clear()

            For i = 0 To TABLE.Rows.Count - 1
            With ListViews
                .Items.Add(TABLE.Rows(i)("customer_id"))

                With .Items(.Items.Count - 1).SubItems
                    'Respondent Profile
                    .Add(TABLE.Rows(i)("customer_name"))
                    .Add(TABLE.Rows(i)("customer_address"))
                    .Add(TABLE.Rows(i)("customer_contactno"))

                End With
            End With
        Next
        clearitem()
    End Sub
    Private Sub clearitem()
        txtbx_searchn.Text = ""
        txtbx_searcha.Text = ""
        txtbx_searchc.Text = ""
    End Sub
    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtbx_searchc.TextChanged
        Dim selStart As Integer = txtbx_searchc.SelectionStart
        Dim selMoveLeft As Integer = 0
        Dim newStr As String = "" 'Build a new string by copying each valid character from the existing string. The new string starts as blank and valid characters are added 1 at a time.

        For i As Integer = 0 To txtbx_searchc.Text.Length - 1

            If "0123456789".IndexOf(txtbx_searchc.Text(i)) <> -1 Then 'Characters that are in the allowed set will be added to the new string.
                newStr = newStr & txtbx_searchc.Text(i)

            ElseIf i < selStart Then 'Characters that are not valid are removed - if these characters are before the cursor, we need to move the cursor left to account for their removal.
                selMoveLeft = selMoveLeft + 1

            End If
        Next

        txtbx_searchc.Text = newStr 'Place the new text into the textbox.
        txtbx_searchc.SelectionStart = selStart - selMoveLeft 'Move the cursor to the appropriate location.

    End Sub
    Private Sub customer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        view()
        view1()
        view2()
        view3()
    End Sub
    Private Sub btn_refreshc_Click(sender As System.Object, e As System.EventArgs)
        view()
    End Sub
    Private Sub btn_editc_Click(sender As System.Object, e As System.EventArgs) Handles btn_editc.Click
        Dim cmd = New SqlCommand("Update tbl_customer Set customer_name = '" + txtbx_cname2.Text + "', customer_address = '" + txtbx_add2.Text + "', customer_contactno = '" + txtbx_cnum.Text + "' Where customer_id = '" + lbl_id.Text + "'", con)
        Dim da = New SqlDataAdapter(cmd)
        Dim ds = New DataSet()
        da.Fill(ds, "db_Laundry")
        MsgBox("Saved")
        view()
        view1()
        view2()
        view3()
        clearitem2()
    End Sub

    Public Sub clearitem2()
        lbl_id.Text = ""
        txtbx_add2.Text = ""
        txtbx_cnum.Text = ""
        txtbx_cname2.Text = ""
    End Sub

    Private Sub txtbx_contactno_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtbx_contactno.TextChanged
        Dim selStart As Integer = txtbx_contactno.SelectionStart
        Dim selMoveLeft As Integer = 0
        Dim newStr As String = "" 'Build a new string by copying each valid character from the existing string. The new string starts as blank and valid characters are added 1 at a time.

        For i As Integer = 0 To txtbx_contactno.Text.Length - 1

            If "0123456789".IndexOf(txtbx_contactno.Text(i)) <> -1 Then 'Characters that are in the allowed set will be added to the new string.
                newStr = newStr & txtbx_contactno.Text(i)

            ElseIf i < selStart Then 'Characters that are not valid are removed - if these characters are before the cursor, we need to move the cursor left to account for their removal.
                selMoveLeft = selMoveLeft + 1

            End If
        Next

        txtbx_contactno.Text = newStr 'Place the new text into the textbox.
        txtbx_contactno.SelectionStart = selStart - selMoveLeft 'Move the cursor to the appropriate location.

    End Sub

    Private Sub txtbx_cnum_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtbx_cnum.TextChanged
        Dim selStart As Integer = txtbx_cnum.SelectionStart
        Dim selMoveLeft As Integer = 0
        Dim newStr As String = "" 'Build a new string by copying each valid character from the existing string. The new string starts as blank and valid characters are added 1 at a time.

        For i As Integer = 0 To txtbx_cnum.Text.Length - 1

            If "0123456789".IndexOf(txtbx_cnum.Text(i)) <> -1 Then 'Characters that are in the allowed set will be added to the new string.
                newStr = newStr & txtbx_cnum.Text(i)

            ElseIf i < selStart Then 'Characters that are not valid are removed - if these characters are before the cursor, we need to move the cursor left to account for their removal.
                selMoveLeft = selMoveLeft + 1

            End If
        Next

        txtbx_cnum.Text = newStr 'Place the new text into the textbox.
        txtbx_cnum.SelectionStart = selStart - selMoveLeft 'Move the cursor to the appropriate location.

    End Sub

    Private Sub btn_release_Click(sender As System.Object, e As System.EventArgs) Handles btn_release.Click
        Me.Hide()
        Release.Show()
    End Sub

    Private Sub ListViewe_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles ListViewe.MouseClick
        'ID = ListViewe.SelectedItems(0).Text

        Dim cmd As SqlCommand
        Dim query As String = "SELECT * FROM tbl_customer WHERE customer_id='" + ListViewe.SelectedItems(0).Text + "'"
        cmd = New SqlCommand(query, con)
        Try
            con.Open()
            Dim myreader As SqlDataReader = cmd.ExecuteReader()
            If myreader.Read() Then
                lbl_id.Text = myreader.GetValue(0)
                txtbx_cname2.Text = myreader.GetValue(1)
                txtbx_add2.Text = myreader.GetValue(2)
                txtbx_cnum.Text = myreader.GetValue(3)
            End If
            myreader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        view1()
        con.Close()

        ' MsgBox(ID)

        'transaction.Show()
    End Sub
    Public Sub view3()
        Dim str As String = "Select * From tbl_customer"
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim TABLE As New DataTable
        Dim i As Integer

        With cmd
            .CommandText = str
            .Connection = con
        End With

        With da
            .SelectCommand = cmd
            .Fill(TABLE)
        End With

        ListViewd.Items.Clear()
        For i = 0 To TABLE.Rows.Count - 1
            With ListViewd

                .Items.Add(TABLE.Rows(i)("customer_id"))

                With .Items(.Items.Count - 1).SubItems
                    .Add(TABLE.Rows(i)("customer_name"))
                    .Add(TABLE.Rows(i)("customer_address"))
                    .Add(TABLE.Rows(i)("customer_contactno"))
                End With
            End With

        Next
    End Sub
    Private Sub Button3_Click_1(sender As System.Object, e As System.EventArgs) Handles btn_del.Click
        If ID = Nothing Then
            MsgBox("Please choose a record to delete.", MsgBoxStyle.Exclamation)
        Else
            Dim result As Integer = MessageBox.Show("Do you want to delete this column with ID number: " + ListViewd.SelectedItems(0).Text + "?", "caption", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then

                Try

                    Dim str As String = "DELETE from tbl_customer where customer_id = '" + ListViewd.SelectedItems(0).Text + "'"
                    Dim da As New SqlDataAdapter(str, con)
                    Dim ds As New DataSet
                    da.Fill(ds, "db_Laundry")
                Catch ex As Exception
                    MsgBox(ex.Message)

                End Try
                MsgBox("Information Deleted!")
            End If

            view3()
            view()
            view1()
            view2()
            ID = Nothing
        End If
    End Sub

    Private Sub ListViewd_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles ListViewd.MouseClick
        ID = ListViewd.SelectedItems(0).Text
    End Sub

    Private Sub txtbx_customername_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtbx_customername.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 65) _
            Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 90) _
            And (Microsoft.VisualBasic.Asc(e.KeyChar) < 97) _
            Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 122) Then
            'Allowed space
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 32) Then
                e.Handled = True
            End If
        End If
        ' Allowed backspace
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtbx_address_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtbx_address.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 65) _
            Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 90) _
            And (Microsoft.VisualBasic.Asc(e.KeyChar) < 97) _
            Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 122) Then
            'Allowed space
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 32) Then
                e.Handled = True
            End If
        End If
        ' Allowed backspace
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtbx_cname2_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtbx_cname2.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 65) _
            Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 90) _
            And (Microsoft.VisualBasic.Asc(e.KeyChar) < 97) _
            Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 122) Then
            'Allowed space
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 32) Then
                e.Handled = True
            End If
        End If
        ' Allowed backspace
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtbx_add2_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtbx_add2.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 65) _
            Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 90) _
            And (Microsoft.VisualBasic.Asc(e.KeyChar) < 97) _
            Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 122) Then
            'Allowed space
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 32) Then
                e.Handled = True
            End If
        End If
        ' Allowed backspace
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtbx_searchn_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtbx_searchn.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 65) _
            Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 90) _
            And (Microsoft.VisualBasic.Asc(e.KeyChar) < 97) _
            Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 122) Then
            'Allowed space
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 32) Then
                e.Handled = True
            End If
        End If
        ' Allowed backspace
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtbx_searcha_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtbx_searcha.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 65) _
            Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 90) _
            And (Microsoft.VisualBasic.Asc(e.KeyChar) < 97) _
            Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 122) Then
            'Allowed space
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 32) Then
                e.Handled = True
            End If
        End If
        ' Allowed backspace
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub
End Class