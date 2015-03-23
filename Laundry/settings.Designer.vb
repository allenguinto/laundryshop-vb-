<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settings
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tb_settingss = New System.Windows.Forms.TabControl()
        Me.tab_history = New System.Windows.Forms.TabPage()
        Me.grp_servicedetails = New System.Windows.Forms.GroupBox()
        Me.ListView3 = New System.Windows.Forms.ListView()
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btn_adds = New System.Windows.Forms.Button()
        Me.txtbx_price = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbx_sname = New System.Windows.Forms.TextBox()
        Me.txtbx_sdesc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_fdate = New System.Windows.Forms.Label()
        Me.lbl_tdate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtbx_p2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtbx_sname2 = New System.Windows.Forms.TextBox()
        Me.txtbx_d2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.tb_settingss.SuspendLayout()
        Me.tab_history.SuspendLayout()
        Me.grp_servicedetails.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.Panel1.Location = New System.Drawing.Point(2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(241, 707)
        Me.Panel1.TabIndex = 15
        '
        'btn_release
        '
        Me.btn_release.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_release.Font = New System.Drawing.Font("Segoe Print", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_release.Location = New System.Drawing.Point(24, 314)
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
        Me.Button2.TabIndex = 5
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btn_settings
        '
        Me.btn_settings.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_settings.Font = New System.Drawing.Font("Segoe Print", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_settings.Location = New System.Drawing.Point(23, 405)
        Me.btn_settings.Name = "btn_settings"
        Me.btn_settings.Size = New System.Drawing.Size(195, 68)
        Me.btn_settings.TabIndex = 3
        Me.btn_settings.Text = "Settings"
        Me.btn_settings.UseVisualStyleBackColor = False
        '
        'btn_history
        '
        Me.btn_history.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_history.Font = New System.Drawing.Font("Segoe Print", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_history.Location = New System.Drawing.Point(23, 228)
        Me.btn_history.Name = "btn_history"
        Me.btn_history.Size = New System.Drawing.Size(196, 64)
        Me.btn_history.TabIndex = 2
        Me.btn_history.Text = "History"
        Me.btn_history.UseVisualStyleBackColor = True
        '
        'btn_transaction
        '
        Me.btn_transaction.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_transaction.Font = New System.Drawing.Font("Segoe Print", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_transaction.Location = New System.Drawing.Point(24, 142)
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
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(518, 11)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(508, 613)
        Me.ListView1.TabIndex = 17
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Service Id"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Service name"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Description"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 180
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Price"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 100
        '
        'tb_settingss
        '
        Me.tb_settingss.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tb_settingss.Controls.Add(Me.tab_history)
        Me.tb_settingss.Controls.Add(Me.TabPage1)
        Me.tb_settingss.Controls.Add(Me.TabPage2)
        Me.tb_settingss.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_settingss.Location = New System.Drawing.Point(249, 12)
        Me.tb_settingss.Name = "tb_settingss"
        Me.tb_settingss.SelectedIndex = 0
        Me.tb_settingss.Size = New System.Drawing.Size(1058, 698)
        Me.tb_settingss.TabIndex = 16
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
        Me.tab_history.Size = New System.Drawing.Size(1050, 652)
        Me.tab_history.TabIndex = 0
        Me.tab_history.Text = "Sevices Settings"
        Me.tab_history.UseVisualStyleBackColor = True
        '
        'grp_servicedetails
        '
        Me.grp_servicedetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_servicedetails.Controls.Add(Me.ListView3)
        Me.grp_servicedetails.Controls.Add(Me.btn_adds)
        Me.grp_servicedetails.Controls.Add(Me.txtbx_price)
        Me.grp_servicedetails.Controls.Add(Me.Label5)
        Me.grp_servicedetails.Controls.Add(Me.Label4)
        Me.grp_servicedetails.Controls.Add(Me.txtbx_sname)
        Me.grp_servicedetails.Controls.Add(Me.txtbx_sdesc)
        Me.grp_servicedetails.Controls.Add(Me.Label2)
        Me.grp_servicedetails.Controls.Add(Me.lbl_fdate)
        Me.grp_servicedetails.Controls.Add(Me.lbl_tdate)
        Me.grp_servicedetails.Controls.Add(Me.Label1)
        Me.grp_servicedetails.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_servicedetails.Location = New System.Drawing.Point(6, 8)
        Me.grp_servicedetails.Name = "grp_servicedetails"
        Me.grp_servicedetails.Size = New System.Drawing.Size(1038, 641)
        Me.grp_servicedetails.TabIndex = 0
        Me.grp_servicedetails.TabStop = False
        '
        'ListView3
        '
        Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.ListView3.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView3.FullRowSelect = True
        Me.ListView3.Location = New System.Drawing.Point(522, 9)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(508, 613)
        Me.ListView3.TabIndex = 18
        Me.ListView3.UseCompatibleStateImageBehavior = False
        Me.ListView3.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Service Id"
        Me.ColumnHeader9.Width = 100
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Service name"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader10.Width = 100
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Description"
        Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader11.Width = 180
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Price"
        Me.ColumnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader12.Width = 100
        '
        'btn_adds
        '
        Me.btn_adds.BackgroundImage = Global.Laundry.My.Resources.Resources._11040022_941740639193903_1986199048_n__1_
        Me.btn_adds.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_adds.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btn_adds.Location = New System.Drawing.Point(369, 210)
        Me.btn_adds.Name = "btn_adds"
        Me.btn_adds.Size = New System.Drawing.Size(85, 46)
        Me.btn_adds.TabIndex = 125
        Me.btn_adds.UseVisualStyleBackColor = True
        '
        'txtbx_price
        '
        Me.txtbx_price.Location = New System.Drawing.Point(195, 144)
        Me.txtbx_price.Name = "txtbx_price"
        Me.txtbx_price.Size = New System.Drawing.Size(186, 29)
        Me.txtbx_price.TabIndex = 124
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(32, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 21)
        Me.Label5.TabIndex = 123
        Me.Label5.Text = "Description:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(32, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 21)
        Me.Label4.TabIndex = 122
        Me.Label4.Text = "Price per kilo/pcs"
        '
        'txtbx_sname
        '
        Me.txtbx_sname.Location = New System.Drawing.Point(195, 37)
        Me.txtbx_sname.Name = "txtbx_sname"
        Me.txtbx_sname.Size = New System.Drawing.Size(186, 29)
        Me.txtbx_sname.TabIndex = 121
        '
        'txtbx_sdesc
        '
        Me.txtbx_sdesc.Location = New System.Drawing.Point(195, 90)
        Me.txtbx_sdesc.Name = "txtbx_sdesc"
        Me.txtbx_sdesc.Size = New System.Drawing.Size(315, 29)
        Me.txtbx_sdesc.TabIndex = 120
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(29, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 21)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "Service name and type:"
        '
        'lbl_fdate
        '
        Me.lbl_fdate.AutoSize = True
        Me.lbl_fdate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_fdate.Location = New System.Drawing.Point(-1, 92)
        Me.lbl_fdate.Name = "lbl_fdate"
        Me.lbl_fdate.Size = New System.Drawing.Size(0, 21)
        Me.lbl_fdate.TabIndex = 9
        '
        'lbl_tdate
        '
        Me.lbl_tdate.AutoSize = True
        Me.lbl_tdate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_tdate.Location = New System.Drawing.Point(-1, 54)
        Me.lbl_tdate.Name = "lbl_tdate"
        Me.lbl_tdate.Size = New System.Drawing.Size(0, 21)
        Me.lbl_tdate.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 21)
        Me.Label1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 42)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1050, 652)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "Edit Services"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox1.Controls.Add(Me.ListView1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lbl_id)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtbx_p2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtbx_sname2)
        Me.GroupBox1.Controls.Add(Me.txtbx_d2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox1.Location = New System.Drawing.Point(6, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1038, 635)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(29, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(285, 23)
        Me.Label8.TabIndex = 130
        Me.Label8.Text = "Select the datas you want to edit/update"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lbl_id.Location = New System.Drawing.Point(107, 64)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(35, 23)
        Me.lbl_id.TabIndex = 129
        Me.lbl_id.Text = "     "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label3.Location = New System.Drawing.Point(12, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 21)
        Me.Label3.TabIndex = 128
        Me.Label3.Text = "Service ID:"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Laundry.My.Resources.Resources._11041311_941740652527235_462376062_n
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Button1.Location = New System.Drawing.Point(404, 246)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 46)
        Me.Button1.TabIndex = 127
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtbx_p2
        '
        Me.txtbx_p2.Location = New System.Drawing.Point(183, 186)
        Me.txtbx_p2.Name = "txtbx_p2"
        Me.txtbx_p2.Size = New System.Drawing.Size(186, 29)
        Me.txtbx_p2.TabIndex = 124
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(12, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 21)
        Me.Label6.TabIndex = 123
        Me.Label6.Text = "Description:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(12, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 21)
        Me.Label7.TabIndex = 122
        Me.Label7.Text = "Price per kilo/pcs"
        '
        'txtbx_sname2
        '
        Me.txtbx_sname2.Location = New System.Drawing.Point(183, 100)
        Me.txtbx_sname2.Name = "txtbx_sname2"
        Me.txtbx_sname2.Size = New System.Drawing.Size(186, 29)
        Me.txtbx_sname2.TabIndex = 121
        '
        'txtbx_d2
        '
        Me.txtbx_d2.Location = New System.Drawing.Point(183, 142)
        Me.txtbx_d2.Name = "txtbx_d2"
        Me.txtbx_d2.Size = New System.Drawing.Size(315, 29)
        Me.txtbx_d2.TabIndex = 120
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(12, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(154, 21)
        Me.Label9.TabIndex = 117
        Me.Label9.Text = "Service name and type:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(-1, 92)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 21)
        Me.Label10.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(-1, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 21)
        Me.Label11.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(29, 124)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 21)
        Me.Label12.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 42)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1050, 652)
        Me.TabPage2.TabIndex = 2
        Me.TabPage2.Text = "Delete"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox2.Controls.Add(Me.ListView2)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1038, 641)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListView2.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView2.FullRowSelect = True
        Me.ListView2.Location = New System.Drawing.Point(16, 83)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(1009, 544)
        Me.ListView2.TabIndex = 18
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Service Id"
        Me.ColumnHeader5.Width = 180
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Service name"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 180
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Description"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 280
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Price"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 180
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.Laundry.My.Resources.Resources._11040768_941740642527236_260940077_n
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Button3.Location = New System.Drawing.Point(415, 7)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 69)
        Me.Button3.TabIndex = 128
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(29, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(367, 21)
        Me.Label15.TabIndex = 117
        Me.Label15.Text = "Select the datas from the list view the you want to delete"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(-1, 92)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(0, 21)
        Me.Label16.TabIndex = 9
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(-1, 54)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(0, 21)
        Me.Label17.TabIndex = 8
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(29, 124)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(0, 21)
        Me.Label18.TabIndex = 1
        '
        'settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Laundry.My.Resources.Resources.images__2_
        Me.ClientSize = New System.Drawing.Size(1311, 720)
        Me.Controls.Add(Me.tb_settingss)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "settings"
        Me.Text = "settings"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.tb_settingss.ResumeLayout(False)
        Me.tab_history.ResumeLayout(False)
        Me.grp_servicedetails.ResumeLayout(False)
        Me.grp_servicedetails.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_settings As System.Windows.Forms.Button
    Friend WithEvents btn_history As System.Windows.Forms.Button
    Friend WithEvents btn_transaction As System.Windows.Forms.Button
    Friend WithEvents btn_customer As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btn_release As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents tb_settingss As System.Windows.Forms.TabControl
    Friend WithEvents tab_history As System.Windows.Forms.TabPage
    Friend WithEvents grp_servicedetails As System.Windows.Forms.GroupBox
    Friend WithEvents btn_adds As System.Windows.Forms.Button
    Friend WithEvents txtbx_price As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtbx_sname As System.Windows.Forms.TextBox
    Friend WithEvents txtbx_sdesc As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_fdate As System.Windows.Forms.Label
    Friend WithEvents lbl_tdate As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtbx_p2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtbx_sname2 As System.Windows.Forms.TextBox
    Friend WithEvents txtbx_d2 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListView3 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
End Class
