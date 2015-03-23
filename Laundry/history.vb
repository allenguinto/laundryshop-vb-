Imports System.Data.SqlClient
Public Class History
    Dim con As SqlConnection = New SqlConnection("Data Source=ALLEN\SQLEXPRESS; Database = db_Laundry; Trusted_Connection =yes;")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    Dim ds As DataSet
    Dim dr As SqlDataReader
    Friend ID As String


    Private Sub btn_customer_Click(sender As System.Object, e As System.EventArgs) Handles btn_customer.Click
        Me.Hide()
        customer.Show()
    End Sub

    Private Sub btn_transaction_Click(sender As System.Object, e As System.EventArgs) Handles btn_transaction.Click
        Me.Hide()
        transaction.Show()
    End Sub

    Private Sub btn_settings_Click(sender As System.Object, e As System.EventArgs) Handles btn_settings.Click
        Me.Hide()
        settings.Show()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        LoginForm1.Show()
    End Sub

    Private Sub btn_sh_Click(sender As System.Object, e As System.EventArgs) Handles btn_sh.Click
        Dim str As String = "SELECT b.trans_id, a.customer_name, b.service_name, b.trans_price, b.trans_kilo, b.trans_totalamount FROM tbl_trans as b INNER JOIN tbl_customer as a ON a.customer_id = b.customer_id Where trans_date between'" + dp_transdate2.Text + "' AND '" + dp_transdate3.Text + "'"
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

                End With
            End With
        Next
    End Sub

    Private Sub btn_release_Click(sender As System.Object, e As System.EventArgs) Handles btn_release.Click
        Me.Hide()
        Release.Show()
    End Sub

    Private Sub history_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_exit_Click(sender As System.Object, e As System.EventArgs) Handles btn_exit.Click

    End Sub
End Class