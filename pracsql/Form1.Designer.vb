<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.InsertButton = New System.Windows.Forms.Button()
        Me.customerNameTextBox = New System.Windows.Forms.TextBox()
        Me.ageTextBox = New System.Windows.Forms.TextBox()
        Me.sexComboBox = New System.Windows.Forms.ComboBox()
        Me.addressTextBox = New System.Windows.Forms.TextBox()
        Me.contactTextBox = New System.Windows.Forms.TextBox()
        Me.statusComboBox = New System.Windows.Forms.ComboBox()
        Me.membershipStatusComboBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(53, 316)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(244, 84)
        Me.btnConnect.TabIndex = 0
        Me.btnConnect.Text = "connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'InsertButton
        '
        Me.InsertButton.Location = New System.Drawing.Point(419, 316)
        Me.InsertButton.Name = "InsertButton"
        Me.InsertButton.Size = New System.Drawing.Size(244, 84)
        Me.InsertButton.TabIndex = 1
        Me.InsertButton.Text = "insert button"
        Me.InsertButton.UseVisualStyleBackColor = True
        '
        'customerNameTextBox
        '
        Me.customerNameTextBox.Location = New System.Drawing.Point(419, 59)
        Me.customerNameTextBox.Name = "customerNameTextBox"
        Me.customerNameTextBox.Size = New System.Drawing.Size(195, 22)
        Me.customerNameTextBox.TabIndex = 2
        '
        'ageTextBox
        '
        Me.ageTextBox.Location = New System.Drawing.Point(419, 87)
        Me.ageTextBox.Name = "ageTextBox"
        Me.ageTextBox.Size = New System.Drawing.Size(195, 22)
        Me.ageTextBox.TabIndex = 3
        '
        'sexComboBox
        '
        Me.sexComboBox.FormattingEnabled = True
        Me.sexComboBox.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.sexComboBox.Location = New System.Drawing.Point(421, 130)
        Me.sexComboBox.Name = "sexComboBox"
        Me.sexComboBox.Size = New System.Drawing.Size(121, 24)
        Me.sexComboBox.TabIndex = 4
        '
        'addressTextBox
        '
        Me.addressTextBox.Location = New System.Drawing.Point(421, 172)
        Me.addressTextBox.Name = "addressTextBox"
        Me.addressTextBox.Size = New System.Drawing.Size(195, 22)
        Me.addressTextBox.TabIndex = 5
        '
        'contactTextBox
        '
        Me.contactTextBox.Location = New System.Drawing.Point(421, 200)
        Me.contactTextBox.Name = "contactTextBox"
        Me.contactTextBox.Size = New System.Drawing.Size(195, 22)
        Me.contactTextBox.TabIndex = 6
        '
        'statusComboBox
        '
        Me.statusComboBox.FormattingEnabled = True
        Me.statusComboBox.Items.AddRange(New Object() {"SINGLE", "MARRIED"})
        Me.statusComboBox.Location = New System.Drawing.Point(419, 239)
        Me.statusComboBox.Name = "statusComboBox"
        Me.statusComboBox.Size = New System.Drawing.Size(121, 24)
        Me.statusComboBox.TabIndex = 7
        '
        'membershipStatusComboBox
        '
        Me.membershipStatusComboBox.FormattingEnabled = True
        Me.membershipStatusComboBox.Items.AddRange(New Object() {"SILVER", "GOLD"})
        Me.membershipStatusComboBox.Location = New System.Drawing.Point(419, 269)
        Me.membershipStatusComboBox.Name = "membershipStatusComboBox"
        Me.membershipStatusComboBox.Size = New System.Drawing.Size(121, 24)
        Me.membershipStatusComboBox.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.membershipStatusComboBox)
        Me.Controls.Add(Me.statusComboBox)
        Me.Controls.Add(Me.contactTextBox)
        Me.Controls.Add(Me.addressTextBox)
        Me.Controls.Add(Me.sexComboBox)
        Me.Controls.Add(Me.ageTextBox)
        Me.Controls.Add(Me.customerNameTextBox)
        Me.Controls.Add(Me.InsertButton)
        Me.Controls.Add(Me.btnConnect)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConnect As Button
    Friend WithEvents InsertButton As Button
    Friend WithEvents customerNameTextBox As TextBox
    Friend WithEvents ageTextBox As TextBox
    Friend WithEvents sexComboBox As ComboBox
    Friend WithEvents addressTextBox As TextBox
    Friend WithEvents contactTextBox As TextBox
    Friend WithEvents statusComboBox As ComboBox
    Friend WithEvents membershipStatusComboBox As ComboBox
End Class
