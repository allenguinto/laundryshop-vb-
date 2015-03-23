<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mainframe
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
        Me.Panel1.SuspendLayout()
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
        Me.Panel1.TabIndex = 3
        '
        'btn_release
        '
        Me.btn_release.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_release.Font = New System.Drawing.Font("Segoe Print", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_release.Location = New System.Drawing.Point(25, 300)
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
        Me.btn_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_settings.Font = New System.Drawing.Font("Segoe Print", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_settings.Location = New System.Drawing.Point(25, 400)
        Me.btn_settings.Name = "btn_settings"
        Me.btn_settings.Size = New System.Drawing.Size(195, 68)
        Me.btn_settings.TabIndex = 3
        Me.btn_settings.Text = "Settings"
        Me.btn_settings.UseVisualStyleBackColor = True
        '
        'btn_history
        '
        Me.btn_history.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_history.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_history.Font = New System.Drawing.Font("Segoe Print", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_history.Location = New System.Drawing.Point(25, 211)
        Me.btn_history.Name = "btn_history"
        Me.btn_history.Size = New System.Drawing.Size(196, 64)
        Me.btn_history.TabIndex = 2
        Me.btn_history.Text = "History"
        Me.btn_history.UseVisualStyleBackColor = True
        '
        'btn_transaction
        '
        Me.btn_transaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_transaction.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_transaction.Font = New System.Drawing.Font("Segoe Print", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_transaction.Location = New System.Drawing.Point(23, 123)
        Me.btn_transaction.Name = "btn_transaction"
        Me.btn_transaction.Size = New System.Drawing.Size(196, 62)
        Me.btn_transaction.TabIndex = 1
        Me.btn_transaction.Text = "Transaction"
        Me.btn_transaction.UseVisualStyleBackColor = True
        '
        'btn_customer
        '
        Me.btn_customer.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_customer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_customer.Font = New System.Drawing.Font("Segoe Print", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_customer.Location = New System.Drawing.Point(24, 48)
        Me.btn_customer.Name = "btn_customer"
        Me.btn_customer.Size = New System.Drawing.Size(197, 54)
        Me.btn_customer.TabIndex = 0
        Me.btn_customer.Text = "Customer"
        Me.btn_customer.UseVisualStyleBackColor = False
        '
        'Mainframe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImage = Global.Laundry.My.Resources.Resources.yes
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1311, 720)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Mainframe"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_settings As System.Windows.Forms.Button
    Friend WithEvents btn_history As System.Windows.Forms.Button
    Friend WithEvents btn_transaction As System.Windows.Forms.Button
    Friend WithEvents btn_customer As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btn_release As System.Windows.Forms.Button

End Class
