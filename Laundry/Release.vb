Imports System.Data.SqlClient
Public Class Release
    Dim con As SqlConnection = New SqlConnection("Data Source=ALLEN\SQLEXPRESS; Database = db_Laundry; Trusted_Connection =yes;")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    Dim ds As DataSet
    Dim dr As SqlDataReader
    Friend ID As String
    Public Sub view()
        Dim str As String = "SELECT b.trans_id, a.customer_name, b.service_name, b.trans_price, b.trans_kilo, b.trans_totalamount, b.trans_status FROM tbl_trans as b INNER JOIN tbl_customer as a ON a.customer_id = b.customer_id Where trans_status = 'Unrelease'"
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
                .Items.Add(TABLE.Rows(i)("trans_id"))

                With .Items(.Items.Count - 1).SubItems
                    'Respondent Profile
                    .Add(TABLE.Rows(i)("customer_name"))
                    .Add(TABLE.Rows(i)("service_name"))
                    .Add(TABLE.Rows(i)("trans_price"))
                    .Add(TABLE.Rows(i)("trans_kilo"))
                    .Add(TABLE.Rows(i)("trans_totalamount"))
                    .Add(TABLE.Rows(i)("trans_status"))
                End With
            End With
        Next
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

    Private Sub btn_settings_Click(sender As System.Object, e As System.EventArgs) Handles btn_settings.Click
        Me.Hide()
        settings.Show()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        LoginForm1.Show()
    End Sub
    Private Sub Release_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        view()
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim cmd = New SqlCommand("Update tbl_trans Set trans_status = '" + ComboBox1.Text + "'", con)
        Dim da = New SqlDataAdapter(cmd)
        Dim ds = New DataSet()
        da.Fill(ds, "db_Laundry")
        MsgBox("Saved")
        view()
    End Sub
    Private Sub ListView1_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseClick
        Dim cmd As SqlCommand
        Dim query As String = "SELECT * FROM tbl_trans WHERE trans_id='" + ListView1.SelectedItems(0).Text + "'"
        cmd = New SqlCommand(query, con)
        Try
            con.Open()
            Dim myreader As SqlDataReader = cmd.ExecuteReader()
            If myreader.Read() Then
                lbl_ID.Text = myreader.GetValue(0)
                ComboBox1.Text = myreader.GetValue(7)
            End If
            myreader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        view()
        con.Close()
    End Sub
End Class