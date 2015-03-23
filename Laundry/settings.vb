Imports System.Data.SqlClient
Public Class settings
    Dim con As SqlConnection = New SqlConnection("Data Source=ALLEN\SQLEXPRESS; Database = db_Laundry; Trusted_Connection =yes;")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    Dim ds As DataSet
    Dim dr As SqlDataReader
    Friend ID As String
    Public Sub settings()
        cmd = New SqlCommand("Insert Into tbl_service (service_name, service_decs, service_price) Values ('" + txtbx_sname.Text + "', '" + txtbx_sdesc.Text + "','" + txtbx_price.Text + "')", con)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet()
        da.Fill(ds, "db_Laundry")
    End Sub
    Private Sub btn_customer_Click(sender As System.Object, e As System.EventArgs) Handles btn_customer.Click
        Me.Hide()
        customer.Show()
    End Sub

    Private Sub btn_transaction_Click(sender As System.Object, e As System.EventArgs) Handles btn_transaction.Click
        Me.Hide()
        transaction.Show()
    End Sub

    Private Sub btn_history_Click(sender As System.Object, e As System.EventArgs) Handles btn_history.Click
        Me.Hide()
        History.Show()
    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        LoginForm1.Show()
    End Sub
    Public Sub view()
        Dim str As String = "Select * From tbl_service"
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

        ListView1.Items.Clear()

        For i = 0 To TABLE.Rows.Count - 1
            With ListView1
                .Items.Add(TABLE.Rows(i)("service_id"))
                With .Items(.Items.Count - 1).SubItems
                    'Respondent Profile
                    .Add(TABLE.Rows(i)("service_name"))
                    .Add(TABLE.Rows(i)("service_decs"))
                    .Add(TABLE.Rows(i)("service_price"))
                End With

            End With
        Next
    End Sub
    Public Sub viewer()
        Dim str As String = "Select * From tbl_service"
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
                .Items.Add(TABLE.Rows(i)("service_id"))
                With .Items(.Items.Count - 1).SubItems
                    'Respondent Profile
                    .Add(TABLE.Rows(i)("service_name"))
                    .Add(TABLE.Rows(i)("service_decs"))
                    .Add(TABLE.Rows(i)("service_price"))
                End With

            End With
        Next
    End Sub
    Public Sub view3()
        Dim str As String = "Select * From tbl_service"
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
                .Items.Add(TABLE.Rows(i)("service_id"))
                With .Items(.Items.Count - 1).SubItems
                    'Respondent Profile
                    .Add(TABLE.Rows(i)("service_name"))
                    .Add(TABLE.Rows(i)("service_decs"))
                    .Add(TABLE.Rows(i)("service_price"))
                End With

            End With
        Next
    End Sub
    Private Sub btn_adds_Click(sender As System.Object, e As System.EventArgs) Handles btn_adds.Click
        settings()
        view()
        viewer()
        view3()
        clearitems()
    End Sub
    Private Sub ListView1_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseClick
        'ID = ListView1.SelectedItems(0).Text
        Dim cmd As SqlCommand
        Dim query As String = "SELECT * FROM tbl_service WHERE service_id='" + ListView1.SelectedItems(0).Text + "'"
        cmd = New SqlCommand(query, con)
        Try
            con.Open()
            Dim myreader As SqlDataReader = cmd.ExecuteReader()
            If myreader.Read() Then
                lbl_id.Text = myreader.GetValue(0)
                txtbx_sname2.Text = myreader.GetValue(1)
                txtbx_d2.Text = myreader.GetValue(2)
                txtbx_p2.Text = myreader.GetValue(3)
            End If
            myreader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        view()
        con.Close()
    End Sub
    Private Sub clearitems()
        txtbx_sname.Text = ""
        txtbx_price.Text = ""
        txtbx_sdesc.Text = ""
    End Sub
    Private Sub settings_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        view()
        viewer()
        view3()
    End Sub
    Private Sub btn_edits_Click(sender As System.Object, e As System.EventArgs)
        If ID = Nothing Then
            MsgBox("Please choose a record to delete.", MsgBoxStyle.Exclamation)
        Else
            Dim cmd As SqlCommand
            Dim query As String = "SELECT * FROM tbl_service WHERE service_id='" + ListView1.SelectedItems(0).Text + "'"
            cmd = New SqlCommand(query, con)
            Try
                con.Open()
                Dim myreader As SqlDataReader = cmd.ExecuteReader()
                If myreader.Read() Then
                    lbl_id.Text = myreader.GetValue(0)
                    txtbx_p2.Text = myreader.GetValue(3)
                    txtbx_sname2.Text = myreader.GetValue(1)
                    txtbx_d2.Text = myreader.GetValue(2)
                End If
                myreader.Close()
            Catch ex As System.Exception
                MsgBox(ex.Message)
            End Try
            view()
            viewer()
            view3()
            con.Close()
        End If
        ID = Nothing
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim cmd = New SqlCommand("Update tbl_service Set service_name = '" + txtbx_sname2.Text + "', service_decs = '" + txtbx_d2.Text + "', service_price = '" + txtbx_p2.Text + "' Where service_id = '" + lbl_id.Text + "'", con)
        Dim da = New SqlDataAdapter(cmd)
        Dim ds = New DataSet()
        da.Fill(ds, "db_Laundry")
        MsgBox("Saved")
        view()
        clearitem2()
    End Sub

    Public Sub clearitem2()
        lbl_id.Text = ""
        txtbx_p2.Text = ""
        txtbx_sname2.Text = ""
        txtbx_d2.Text = ""
    End Sub

    Private Sub btn_release_Click(sender As System.Object, e As System.EventArgs) Handles btn_release.Click
        Me.Hide()
        Release.Show()
    End Sub

    Private Sub txtbx_sname_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub txtbx_sdesc_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub txtbx_sname2_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub txtbx_d2_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub txtbx_price_TextChanged(sender As System.Object, e As System.EventArgs)
        Dim selStart As Integer = txtbx_price.SelectionStart
        Dim selMoveLeft As Integer = 0
        Dim newStr As String = "" 'Build a new string by copying each valid character from the existing string. The new string starts as blank and valid characters are added 1 at a time.

        For i As Integer = 0 To txtbx_price.Text.Length - 1

            If "0123456789".IndexOf(txtbx_price.Text(i)) <> -1 Then 'Characters that are in the allowed set will be added to the new string.
                newStr = newStr & txtbx_price.Text(i)

            ElseIf i < selStart Then 'Characters that are not valid are removed - if these characters are before the cursor, we need to move the cursor left to account for their removal.
                selMoveLeft = selMoveLeft + 1

            End If
        Next

        txtbx_price.Text = newStr 'Place the new text into the textbox.
        txtbx_price.SelectionStart = selStart - selMoveLeft 'Move the cursor to the appropriate location.
    End Sub

    Private Sub txtbx_p2_TextChanged(sender As System.Object, e As System.EventArgs)
        Dim selStart As Integer = txtbx_p2.SelectionStart
        Dim selMoveLeft As Integer = 0
        Dim newStr As String = "" 'Build a new string by copying each valid character from the existing string. The new string starts as blank and valid characters are added 1 at a time.

        For i As Integer = 0 To txtbx_p2.Text.Length - 1

            If "0123456789".IndexOf(txtbx_price.Text(i)) <> -1 Then 'Characters that are in the allowed set will be added to the new string.
                newStr = newStr & txtbx_price.Text(i)

            ElseIf i < selStart Then 'Characters that are not valid are removed - if these characters are before the cursor, we need to move the cursor left to account for their removal.
                selMoveLeft = selMoveLeft + 1

            End If
        Next

        txtbx_p2.Text = newStr 'Place the new text into the textbox.
        txtbx_p2.SelectionStart = selStart - selMoveLeft 'Move the cursor to the appropriate location.
    End Sub
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If ID = Nothing Then
            MsgBox("Please choose a record to delete.", MsgBoxStyle.Exclamation)
        Else
            Dim result As Integer = MessageBox.Show("Do you want to delete this column with ID number: " + ListView2.SelectedItems(0).Text + "?", "caption", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then

                Try

                    Dim str As String = "DELETE from tbl_service where service_id = '" + ListView2.SelectedItems(0).Text + "'"
                    Dim da As New SqlDataAdapter(str, con)
                    Dim ds As New DataSet
                    da.Fill(ds, "db_Laundry")
                Catch ex As Exception
                    MsgBox(ex.Message)

                End Try
                MsgBox("Information Deleted!")
            End If

            view()
            viewer()
            view3()
            ID = Nothing
        End If
    End Sub

    Private Sub ListView2_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles ListView2.MouseClick
        ID = ListView2.SelectedItems(0).Text
    End Sub
End Class