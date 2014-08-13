<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chat_Screen
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
        Me.Messages = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Messages
        '
        Me.Messages.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.Messages.FormattingEnabled = True
        Me.Messages.ItemHeight = 15
        Me.Messages.Location = New System.Drawing.Point(12, 12)
        Me.Messages.Name = "Messages"
        Me.Messages.Size = New System.Drawing.Size(1139, 469)
        Me.Messages.TabIndex = 0
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(1158, 13)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(85, 472)
        Me.ListBox2.TabIndex = 1
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Comic Sans MS", 35.0!)
        Me.RichTextBox1.Location = New System.Drawing.Point(13, 491)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(1138, 77)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1158, 491)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 77)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "CHAT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Chat_Screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1255, 580)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Messages)
        Me.Name = "Chat_Screen"
        Me.Text = "Chat Screen"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Messages As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
