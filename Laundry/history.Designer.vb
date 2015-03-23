<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class History
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_release = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_settings = New System.Windows.Forms.Button()
        Me.btn_history = New System.Windows.Forms.Button()
        Me.btn_transaction = New System.Windows.Forms.Button()
        Me.btn_customer = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tab_history = New System.Windows.Forms.TabPage()
        Me.grp_servicedetails = New System.Windows.Forms.GroupBox()
        Me.btn_sh = New System.Windows.Forms.Button()
        Me.dp_transdate3 = New System.Windows.Forms.DateTimePicker()
        Me.dp_transdate2 = New System.Windows.Forms.DateTimePicker()
        Me.lbl_tdate2 = New System.Windows.Forms.Label()
        Me.lbl_fdate2 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.C_transid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.C_cusid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.C_services = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.C_kilo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.C_total = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbl_fdate = New System.Windows.Forms.Label()
        Me.lbl_tdate = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.btn_show = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tab_history.SuspendLayout()
        Me.grp_servicedetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel1.BackgroundImage = Global.Laundry.My.Resources.Resources.Shadow
        Me.Panel1.Controls.Add(Me.btn_release)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.btn_settings)
        Me.Panel1.Controls.Add(Me.btn_history)
        Me.Panel1.Controls.Add(Me.btn_transaction)
        Me.Panel1.Controls.Add(Me.btn_customer)
        Me.Panel1.Location = New System.Drawing.Point(2, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(241, 707)
        Me.Panel1.TabIndex = 16
        '
        'btn_release
        '
        Me.btn_release.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_release.Font = New System.Drawing.Font("Segoe Print", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_release.Location = New System.Drawing.Point(23, 319)
        Me.btn_release.Name = "btn_release"
        Me.btn_release.Size = New System.Drawing.Size(195, 68)
        Me.btn_release.TabIndex = 8
        Me.btn_release.Text = "Releasing"
        Me.btn_release.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.Laundry.My.Resources.Resources._11051583_941740665860567_391952378_n
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Segoe Print", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(24, 618)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 68)
        Me.Button2.TabIndex = 6
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btn_settings
        '
        Me.btn_settings.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_settings.Font = New System.Drawing.Font("Segoe Print", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_settings.Location = New System.Drawing.Point(24, 412)
        Me.btn_settings.Name = "btn_settings"
        Me.btn_settings.Size = New System.Drawing.Size(195, 68)
        Me.btn_settings.TabIndex = 3
        Me.btn_settings.Text = "Settings"
        Me.btn_settings.UseVisualStyleBackColor = False
        '
        'btn_history
        '
        Me.btn_history.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_history.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_history.Font = New System.Drawing.Font("Segoe Print", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_history.Location = New System.Drawing.Point(24, 230)
        Me.btn_history.Name = "btn_history"
        Me.btn_history.Size = New System.Drawing.Size(196, 64)
        Me.btn_history.TabIndex = 2
        Me.btn_history.Text = "History"
        Me.btn_history.UseVisualStyleBackColor = False
        '
        'btn_transaction
        '
        Me.btn_transaction.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_transaction.Font = New System.Drawing.Font("Segoe Print", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_transaction.Location = New System.Drawing.Point(24, 144)
        Me.btn_transaction.Name = "btn_transaction"
        Me.btn_transaction.Size = New System.Drawing.Size(195, 62)
        Me.btn_transaction.TabIndex = 1
        Me.btn_transaction.Text = "Transaction"
        Me.btn_transaction.UseVisualStyleBackColor = True
        '
        'btn_customer
        '
        Me.btn_customer.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_customer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_customer.Font = New System.Drawing.Font("Segoe Print", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_customer.Location = New System.Drawing.Point(24, 66)
        Me.btn_customer.Name = "btn_customer"
        Me.btn_customer.Size = New System.Drawing.Size(195, 54)
        Me.btn_customer.TabIndex = 0
        Me.btn_customer.Text = "Customer"
        Me.btn_customer.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tab_history)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(249, 11)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1000, 703)
        Me.TabControl1.TabIndex = 7
        '
        'tab_history
        '
        Me.tab_history.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.tab_history.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.tab_history.Controls.Add(Me.grp_servicedetails)
        Me.tab_history.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_history.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.tab_history.Location = New System.Drawing.Point(4, 42)
        Me.tab_history.Name = "tab_history"
        Me.tab_history.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_history.Size = New System.Drawing.Size(992, 657)
        Me.tab_history.TabIndex = 0
        Me.tab_history.Text = "History"
        Me.tab_history.UseVisualStyleBackColor = True
        '
        'grp_servicedetails
        '
        Me.grp_servicedetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_servicedetails.Controls.Add(Me.btn_sh)
        Me.grp_servicedetails.Controls.Add(Me.dp_transdate3)
        Me.grp_servicedetails.Controls.Add(Me.dp_transdate2)
        Me.grp_servicedetails.Controls.Add(Me.lbl_tdate2)
        Me.grp_servicedetails.Controls.Add(Me.lbl_fdate2)
        Me.grp_servicedetails.Controls.Add(Me.ListView1)
        Me.grp_servicedetails.Controls.Add(Me.lbl_fdate)
        Me.grp_servicedetails.Controls.Add(Me.lbl_tdate)
        Me.grp_servicedetails.Controls.Add(Me.btn_exit)
        Me.grp_servicedetails.Controls.Add(Me.btn_print)
        Me.grp_servicedetails.Controls.Add(Me.btn_show)
        Me.grp_servicedetails.Controls.Add(Me.Label1)
        Me.grp_servicedetails.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_servicedetails.Location = New System.Drawing.Point(6, 8)
        Me.grp_servicedetails.Name = "grp_servicedetails"
        Me.grp_servicedetails.Size = New System.Drawing.Size(986, 646)
        Me.grp_servicedetails.TabIndex = 0
        Me.grp_servicedetails.TabStop = False
        '
        'btn_sh
        '
        Me.btn_sh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_sh.BackgroundImage = Global.Laundry.My.Resources.Resources._11051581_941740672527233_1395320717_n
        Me.btn_sh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_sh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_sh.Location = New System.Drawing.Point(320, 28)
        Me.btn_sh.Name = "btn_sh"
        Me.btn_sh.Size = New System.Drawing.Size(85, 74)
        Me.btn_sh.TabIndex = 118
        Me.btn_sh.UseVisualStyleBackColor = True
        '
        'dp_transdate3
        '
        Me.dp_transdate3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dp_transdate3.Location = New System.Drawing.Point(136, 67)
        Me.dp_transdate3.Name = "dp_transdate3"
        Me.dp_transdate3.Size = New System.Drawing.Size(135, 29)
        Me.dp_transdate3.TabIndex = 117
        '
        'dp_transdate2
        '
        Me.dp_transdate2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dp_transdate2.Location = New System.Drawing.Point(136, 22)
        Me.dp_transdate2.Name = "dp_transdate2"
        Me.dp_transdate2.Size = New System.Drawing.Size(135, 29)
        Me.dp_transdate2.TabIndex = 116
        '
        'lbl_tdate2
        '
        Me.lbl_tdate2.AutoSize = True
        Me.lbl_tdate2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_tdate2.Location = New System.Drawing.Point(38, 73)
        Me.lbl_tdate2.Name = "lbl_tdate2"
        Me.lbl_tdate2.Size = New System.Drawing.Size(59, 21)
        Me.lbl_tdate2.TabIndex = 114
        Me.lbl_tdate2.Text = "To Date"
        '
        'lbl_fdate2
        '
        Me.lbl_fdate2.AutoSize = True
        Me.lbl_fdate2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_fdate2.Location = New System.Drawing.Point(21, 30)
        Me.lbl_fdate2.Name = "lbl_fdate2"
        Me.lbl_fdate2.Size = New System.Drawing.Size(76, 21)
        Me.lbl_fdate2.TabIndex = 113
        Me.lbl_fdate2.Text = "From Date"
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.C_transid, Me.C_cusid, Me.C_services, Me.ColumnHeader1, Me.C_kilo, Me.C_total})
        Me.ListView1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(19, 121)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(685, 507)
        Me.ListView1.TabIndex = 112
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'C_transid
        '
        Me.C_transid.Text = "Transaction_id"
        Me.C_transid.Width = 130
        '
        'C_cusid
        '
        Me.C_cusid.Text = "Customer name"
        Me.C_cusid.Width = 130
        '
        'C_services
        '
        Me.C_services.Text = "Services"
        Me.C_services.Width = 100
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Price"
        Me.ColumnHeader1.Width = 100
        '
        'C_kilo
        '
        Me.C_kilo.Text = "Kilo/s"
        Me.C_kilo.Width = 100
        '
        'C_total
        '
        Me.C_total.Text = "Total_amount"
        Me.C_total.Width = 100
        '
        'lbl_fdate
        '
        Me.lbl_fdate.AutoSize = True
        Me.lbl_fdate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_fdate.Location = New System.Drawing.Point(15, 73)
        Me.lbl_fdate.Name = "lbl_fdate"
        Me.lbl_fdate.Size = New System.Drawing.Size(0, 21)
        Me.lbl_fdate.TabIndex = 9
        '
        'lbl_tdate
        '
        Me.lbl_tdate.AutoSize = True
        Me.lbl_tdate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_tdate.Location = New System.Drawing.Point(15, 35)
        Me.lbl_tdate.Name = "lbl_tdate"
        Me.lbl_tdate.Size = New System.Drawing.Size(0, 21)
        Me.lbl_tdate.TabIndex = 8
        '
        'btn_exit
        '
        Me.btn_exit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_exit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_exit.Location = New System.Drawing.Point(775, 283)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(85, 78)
        Me.btn_exit.TabIndex = 7
        Me.btn_exit.Text = "EXIT"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_print
        '
        Me.btn_print.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_print.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_print.Location = New System.Drawing.Point(775, 170)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(85, 78)
        Me.btn_print.TabIndex = 6
        Me.btn_print.Text = "PRINT"
        Me.btn_print.UseVisualStyleBackColor = True
        '
        'btn_show
        '
        Me.btn_show.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_show.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_show.Location = New System.Drawing.Point(510, 123)
        Me.btn_show.Name = "btn_show"
        Me.btn_show.Size = New System.Drawing.Size(85, 35)
        Me.btn_show.TabIndex = 5
        Me.btn_show.Text = "SHOW"
        Me.btn_show.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 21)
        Me.Label1.TabIndex = 1
        '
        'History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Laundry.My.Resources.Resources.images__2_
        Me.ClientSize = New System.Drawing.Size(1311, 720)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "History"
        Me.Text = "History"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tab_history.ResumeLayout(False)
        Me.grp_servicedetails.ResumeLayout(False)
        Me.grp_servicedetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_settings As System.Windows.Forms.Button
    Friend WithEvents btn_history As System.Windows.Forms.Button
    Friend WithEvents btn_transaction As System.Windows.Forms.Button
    Friend WithEvents btn_customer As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btn_release As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tab_history As System.Windows.Forms.TabPage
    Friend WithEvents grp_servicedetails As System.Windows.Forms.GroupBox
    Friend WithEvents btn_sh As System.Windows.Forms.Button
    Friend WithEvents dp_transdate3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dp_transdate2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_tdate2 As System.Windows.Forms.Label
    Friend WithEvents lbl_fdate2 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents C_transid As System.Windows.Forms.ColumnHeader
    Friend WithEvents C_cusid As System.Windows.Forms.ColumnHeader
    Friend WithEvents C_services As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents C_kilo As System.Windows.Forms.ColumnHeader
    Friend WithEvents C_total As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbl_fdate As System.Windows.Forms.Label
    Friend WithEvents lbl_tdate As System.Windows.Forms.Label
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents btn_print As System.Windows.Forms.Button
    Friend WithEvents btn_show As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
