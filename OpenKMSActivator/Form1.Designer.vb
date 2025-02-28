<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.LogTextBox = New System.Windows.Forms.TextBox()
        Me.ActivateButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OfficeButton = New System.Windows.Forms.Button()
        Me.WindowsButton = New System.Windows.Forms.Button()
        Me.OfficeVersionComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LogTextBox
        '
        Me.LogTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LogTextBox.BackColor = System.Drawing.Color.Black
        Me.LogTextBox.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LogTextBox.Location = New System.Drawing.Point(17, 154)
        Me.LogTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LogTextBox.Multiline = True
        Me.LogTextBox.Name = "LogTextBox"
        Me.LogTextBox.ReadOnly = True
        Me.LogTextBox.Size = New System.Drawing.Size(455, 336)
        Me.LogTextBox.TabIndex = 2
        '
        'ActivateButton
        '
        Me.ActivateButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ActivateButton.Location = New System.Drawing.Point(17, 508)
        Me.ActivateButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ActivateButton.Name = "ActivateButton"
        Me.ActivateButton.Size = New System.Drawing.Size(100, 28)
        Me.ActivateButton.TabIndex = 3
        Me.ActivateButton.Text = "Activate"
        Me.ActivateButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(453, 41)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Мултифункционален активатор"
        '
        'OfficeButton
        '
        Me.OfficeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OfficeButton.Image = Global.OpenKMSActivator.My.Resources.Resources.office_3_
        Me.OfficeButton.Location = New System.Drawing.Point(431, 502)
        Me.OfficeButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.OfficeButton.Name = "OfficeButton"
        Me.OfficeButton.Size = New System.Drawing.Size(43, 39)
        Me.OfficeButton.TabIndex = 1
        Me.OfficeButton.UseVisualStyleBackColor = True
        '
        'WindowsButton
        '
        Me.WindowsButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WindowsButton.Image = Global.OpenKMSActivator.My.Resources.Resources.windows
        Me.WindowsButton.Location = New System.Drawing.Point(380, 502)
        Me.WindowsButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.WindowsButton.Name = "WindowsButton"
        Me.WindowsButton.Size = New System.Drawing.Size(43, 39)
        Me.WindowsButton.TabIndex = 0
        Me.WindowsButton.UseVisualStyleBackColor = True
        '
        'OfficeVersionComboBox
        '
        Me.OfficeVersionComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OfficeVersionComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OfficeVersionComboBox.FormattingEnabled = True
        Me.OfficeVersionComboBox.Items.AddRange(New Object() {"Office 2016", "Office 2013", "Office 2010"})
        Me.OfficeVersionComboBox.Location = New System.Drawing.Point(211, 508)
        Me.OfficeVersionComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.OfficeVersionComboBox.Name = "OfficeVersionComboBox"
        Me.OfficeVersionComboBox.Size = New System.Drawing.Size(160, 25)
        Me.OfficeVersionComboBox.TabIndex = 5
        Me.OfficeVersionComboBox.Text = "Select Office Version"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(113, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(281, 41)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "за администратори"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(493, 554)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.OfficeVersionComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ActivateButton)
        Me.Controls.Add(Me.LogTextBox)
        Me.Controls.Add(Me.OfficeButton)
        Me.Controls.Add(Me.WindowsButton)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WindowsButton As Button
    Friend WithEvents OfficeButton As Button
    Friend WithEvents LogTextBox As TextBox
    Friend WithEvents ActivateButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents OfficeVersionComboBox As ComboBox
    Friend WithEvents Label2 As Label
End Class
