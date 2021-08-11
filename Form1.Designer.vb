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
        Me.PasswordBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UserNameBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LoginBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PasswordBox
        '
        Me.PasswordBox.Location = New System.Drawing.Point(193, 166)
        Me.PasswordBox.Name = "PasswordBox"
        Me.PasswordBox.Size = New System.Drawing.Size(327, 22)
        Me.PasswordBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(118, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Password:"
        '
        'UserNameBox
        '
        Me.UserNameBox.Location = New System.Drawing.Point(193, 121)
        Me.UserNameBox.Name = "UserNameBox"
        Me.UserNameBox.Size = New System.Drawing.Size(327, 22)
        Me.UserNameBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(112, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "UserName:"
        '
        'LoginBtn
        '
        Me.LoginBtn.Location = New System.Drawing.Point(121, 230)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(147, 31)
        Me.LoginBtn.TabIndex = 5
        Me.LoginBtn.Text = "Login"
        Me.LoginBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.Location = New System.Drawing.Point(274, 230)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(129, 31)
        Me.ExitBtn.TabIndex = 6
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'ClearBtn
        '
        Me.ClearBtn.Location = New System.Drawing.Point(409, 230)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(111, 31)
        Me.ClearBtn.TabIndex = 7
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 414)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.LoginBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UserNameBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PasswordBox)
        Me.Name = "Form1"
        Me.Text = "3nm,"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PasswordBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents UserNameBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LoginBtn As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents ClearBtn As Button
End Class
