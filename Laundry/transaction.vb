Imports System.Data.SqlClient
Public Class transaction
    Dim con As SqlConnection = New SqlConnection("Data Source=ALLEN\SQLEXPRESS; Database = db_Laundry; Trusted_Connection =yes;")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    Dim ds As DataSet
    Dim dr As SqlDataReader
    Friend ID As String
    Public laundrydate As Date = Date.Today
    Private Sub mainformload() Handles MyBase.Load
        dpdaterelease.MinDate = laundrydate
        DateTimePicker1.MinDate = laundrydate
    End Sub
    Public Sub transaction()
        cmd = New SqlCommand("Insert Into tbl_trans (customer_id, service_name, trans_price, trans_date, trans_daterelease, trans_kilo, trans_totalamount, trans_status) Values ('" + lbl_cid2.Text + "', '" + cb_services.Text + "', '" + txtbx_price.Text + "','" + DateTimePicker1.Text + "', '" + dpdaterelease.Text + "', '" + txtbx_kilo.Text + "', '" + txtbx_total.Text + "', 'Unrelease')", con)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet()
        da.Fill(ds, "db_Laundry")
    End Sub
    Private Sub transaction_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        viewer()
        view1()
        'MsgBox(customer.ID)

        Dim cmd, cmd_service As SqlCommand
        Dim query As String = "Select * From tbl_customer WHERE customer_id = " + customer.ID
        Dim query_service As String = "Select * from tbl_service"
        cmd = New SqlCommand(query, con)
        Try
            con.Open()
            Dim myreader As SqlDataReader = cmd.ExecuteReader()
            If myreader.Read() Then
                lbl_cid2.Text = myreader.GetValue(0)
                lbl_cn2.Text = myreader.GetValue(1)
                lbl_ca2.Text = myreader.GetValue(2)
                lbl_cc2.Text = myreader.GetValue(3)

            End If
            myreader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        viewer()
        con.Close()

        'select to get all services
        cmd_service = New SqlCommand(query_service, con)
        Try
            con.Open()
            Dim myreader_service As SqlDataReader = cmd_service.ExecuteReader()


            While myreader_service.Read
                Dim services = myreader_service.GetString(1)
                cb_services.Items.Add(services)
                'cb_services2.Items.Add(services)
            End While
            myreader_service.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        viewer()
        'view1()
        con.Close()
    End Sub
    Private Sub btn_customer_Click(sender As System.Object, e As System.EventArgs) Handles btn_customer.Click
        Me.Hide()
        customer.Show()
    End Sub

    Private Sub btn_history_Click(sender As System.Object, e As System.EventArgs) Handles btn_history.Click
        Me.Hide()
        History.Show()
    End Sub
    Private Sub btn_settings_Click(sender As System.Object, e As System.EventArgs) Handles btn_settings.Click
        Me.Hide()
        settings.Show()
    End Sub
    Private Sub btn_add_Click(sender As System.Object, e As System.EventArgs) Handles btn_add.Click
        transaction()
        viewer()
        view1()
        clearitems()
    End Sub
    Public Sub viewer()
        Dim str As String = "Select * From tbl_trans"
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

        ListView2.Items.Clear()

        For i = 0 To TABLE.Rows.Count - 1
            With ListView2
                .Items.Add(TABLE.Rows(i)("trans_id"))
                With .Items(.Items.Count - 1).SubItems
                    'Respondent Profile
                    .Add(TABLE.Rows(i)("service_name"))
                    .Add(TABLE.Rows(i)("trans_price"))
                    .Add(TABLE.Rows(i)("trans_date"))
                    .Add(TABLE.Rows(i)("trans_daterelease"))
                    .Add(TABLE.Rows(i)("trans_kilo"))
                    .Add(TABLE.Rows(i)("trans_totalamount"))
                End With

            End With
        Next
    End Sub
    Private Sub btn_delete_Click(sender As System.Object, e As System.EventArgs) Handles btn_delete.Click
        If ID = Nothing Then
            MsgBox("Please choose a record to delete.", MsgBoxStyle.Exclamation)
        Else
            Dim result As Integer = MessageBox.Show("Do you want to delete this column with ID number: " + ListView2.SelectedItems(0).Text + "?", "caption", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then

                Try

                    Dim str As String = "DELETE from tbl_trans where trans_id = '" + ListView2.SelectedItems(0).Text + "'"
                    Dim da As New SqlDataAdapter(str, con)
                    Dim ds As New DataSet
                    da.Fill(ds, "db_Laundry")
                Catch ex As Exception
                    MsgBox(ex.Message)

                End Try
                MsgBox("Information Deleted!")
            End If

            viewer()
            view1()
            ID = Nothing
        End If

    End Sub
    Private Sub ListView2_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles ListView2.MouseClick
        ID = ListView2.SelectedItems(0).Text
    End Sub
    Private Sub clearitems()
        cb_services.Text = ""
        txtbx_price.Text = ""
        txtbx_kilo.Text = ""
        txtbx_total.Text = ""
    End Sub
    Private Sub btn_edit_Click(sender As System.Object, e As System.EventArgs) Handles btn_edit.Click
        Dim cmd = New SqlCommand("Update tbl_trans Set service_name = '" + cb_services2.Text + "', trans_price = '" + txtbx_price2.Text + "', trans_date = '" + dp_transdate2.Text + "', trans_daterelease = '" + dp_daterelease2.Text + "', trans_kilo = '" + txtbx_kilo2.Text + "', trans_totalamount = '" + txtbx_total2.Text + "' Where trans_id = '" + lbl_id.Text + "'", con)
        Dim da = New SqlDataAdapter(cmd)
        Dim ds = New DataSet()
        da.Fill(ds, "db_Laundry")
        MsgBox("Saved")
        view1()
        viewer()
        clearitem2()
    End Sub
    Public Sub clearitem2()
        lbl_id.Text = ""
        cb_services2.Text = ""
        txtbx_price2.Text = ""
        dp_transdate2.Text = ""
        dp_daterelease2.Text = ""
        txtbx_kilo2.Text = ""
        txtbx_total2.Text = ""
    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        LoginForm1.Show()
    End Sub
    Private Sub txtbx_price_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtbx_price.TextChanged
        txtbx_total.Text = Val(txtbx_price.Text) * Val(txtbx_kilo.Text)
    End Sub

    Private Sub txtbx_kilo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtbx_kilo.TextChanged
        txtbx_total.Text = Val(txtbx_price.Text) * Val(txtbx_kilo.Text)
        Dim selStart As Integer = txtbx_kilo.SelectionStart
        Dim selMoveLeft As Integer = 0
        Dim newStr As String = "" 'Build a new string by copying each valid character from the existing string. The new string starts as blank and valid characters are added 1 at a time.

        For i As Integer = 0 To txtbx_kilo.Text.Length - 1

            If "0123456789".IndexOf(txtbx_kilo.Text(i)) <> -1 Then 'Characters that are in the allowed set will be added to the new string.
                newStr = newStr & txtbx_kilo.Text(i)

            ElseIf i < selStart Then 'Characters that are not valid are removed - if these characters are before the cursor, we need to move the cursor left to account for their removal.
                selMoveLeft = selMoveLeft + 1

            End If
        Next

        txtbx_kilo.Text = newStr 'Place the new text into the textbox.
        txtbx_kilo.SelectionStart = selStart - selMoveLeft 'Move the cursor to the appropriate location.
    End Sub
    Private Sub cb_services_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cb_services.SelectedIndexChanged
        Dim cmd As SqlCommand
        Dim query As String = "Select * From tbl_service WHERE service_name = '" + cb_services.SelectedItem + "'"
        cmd = New SqlCommand(query, con)
        Try
            con.Open()
            Dim myreader As SqlDataReader = cmd.ExecuteReader()
            If myreader.Read() Then
                txtbx_price.Text = myreader.GetValue(3)
            End If
            myreader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        viewer()
        con.Close()
        ' MsgBox(cb_services.SelectedItem)
    End Sub

    Private Sub btn_release_Click(sender As System.Object, e As System.EventArgs) Handles btn_release.Click
        Me.Hide()
        Release.Show()
    End Sub
    Private Sub btn_rt_Click(sender As System.Object, e As System.EventArgs)
        cb_services.Text = ""
        txtbx_price.Text = ""
        txtbx_kilo.Text = ""
        DateTimePicker1.Text = ""
        dp_daterelease2.Text = ""
        txtbx_total.Text = ""
    End Sub
    Private Sub ListViewte_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles ListViewte.MouseClick
        'ID = ListViewte.SelectedItems(0).Text
        Dim cmd As SqlCommand
        Dim query As String = "SELECT * FROM tbl_trans WHERE trans_id='" + ListViewte.SelectedItems(0).Text + "'"
        cmd = New SqlCommand(query, con)
        Try
            con.Open()
            Dim myreader As SqlDataReader = cmd.ExecuteReader()
            If myreader.Read() Then
                lbl_id.Text = myreader.GetValue(0)
                cb_services2.Text = myreader.GetValue(1)
                txtbx_price2.Text = myreader.GetValue(2)
                dp_transdate2.Text = myreader.GetValue(3)
                dp_daterelease2.Text = myreader.GetValue(4)
                txtbx_kilo2.Text = myreader.GetValue(5)
                txtbx_total2.Text = myreader.GetValue(6)
            End If
            myreader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        view1()
        con.Close()
    End Sub
    Public Sub view1()
        Dim str As String = "Select * From tbl_trans"
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

        ListViewte.Items.Clear()

        For i = 0 To TABLE.Rows.Count - 1
            With ListViewte
                .Items.Add(TABLE.Rows(i)("trans_id"))
                With .Items(.Items.Count - 1).SubItems
                    'Respondent Profile
                    .Add(TABLE.Rows(i)("service_name"))
                    .Add(TABLE.Rows(i)("trans_kilo"))
                    .Add(TABLE.Rows(i)("trans_price"))
                    .Add(TABLE.Rows(i)("trans_date"))
                    .Add(TABLE.Rows(i)("trans_daterelease"))
                    .Add(TABLE.Rows(i)("trans_totalamount"))
                End With

            End With
        Next
    End Sub
    Private Sub txtbx_kilo2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtbx_kilo2.TextChanged
        txtbx_total2.Text = Val(txtbx_price2.Text) * Val(txtbx_kilo2.Text)
        Dim selStart As Integer = txtbx_kilo2.SelectionStart
        Dim selMoveLeft As Integer = 0
        Dim newStr As String = "" 'Build a new string by copying each valid character from the existing string. The new string starts as blank and valid characters are added 1 at a time.

        For i As Integer = 0 To txtbx_kilo2.Text.Length - 1

            If "0123456789".IndexOf(txtbx_kilo2.Text(i)) <> -1 Then 'Characters that are in the allowed set will be added to the new string.
                newStr = newStr & txtbx_kilo2.Text(i)

            ElseIf i < selStart Then 'Characters that are not valid are removed - if these characters are before the cursor, we need to move the cursor left to account for their removal.
                selMoveLeft = selMoveLeft + 1

            End If
        Next

        txtbx_kilo2.Text = newStr 'Place the new text into the textbox.
        txtbx_kilo2.SelectionStart = selStart - selMoveLeft 'Move the cursor to the appropriate location.
    End Sub
    Private Sub txtbx_price2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtbx_price2.TextChanged
        txtbx_total2.Text = Val(txtbx_price2.Text) * Val(txtbx_kilo2.Text)
        Dim selStart As Integer = txtbx_price2.SelectionStart
        Dim selMoveLeft As Integer = 0
        Dim newStr As String = "" 'Build a new string by copying each valid character from the existing string. The new string starts as blank and valid characters are added 1 at a time.

        For i As Integer = 0 To txtbx_price2.Text.Length - 1

            If "0123456789".IndexOf(txtbx_price2.Text(i)) <> -1 Then 'Characters that are in the allowed set will be added to the new string.
                newStr = newStr & txtbx_price2.Text(i)

            ElseIf i < selStart Then 'Characters that are not valid are removed - if these characters are before the cursor, we need to move the cursor left to account for their removal.
                selMoveLeft = selMoveLeft + 1

            End If
        Next

        txtbx_price2.Text = newStr 'Place the new text into the textbox.
        txtbx_price2.SelectionStart = selStart - selMoveLeft 'Move the cursor to the appropriate location.
    End Sub
    Private Sub cb_services2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cb_services2.SelectedIndexChanged
        Dim cmd As SqlCommand
        Dim query As String = "Select * From tbl_service WHERE service_name = '" + cb_services2.SelectedItem + "'"
        cmd = New SqlCommand(query, con)
        view1()
        Try
            con.Open()
            Dim myreader As SqlDataReader = cmd.ExecuteReader()
            If myreader.Read() Then
                txtbx_price2.Text = myreader.GetValue(3)
            End If
            myreader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        view1()
        con.Close()
    End Sub

    Private Function query_service() As Object
        Throw New NotImplementedException
    End Function

End Class