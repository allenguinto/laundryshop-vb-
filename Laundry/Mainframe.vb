Public Class Mainframe

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

    Private Sub btn_release_Click(sender As System.Object, e As System.EventArgs) Handles btn_release.Click
        Me.Hide()
        Release.Show()
    End Sub
End Class
