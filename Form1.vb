Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        'Default username and password
        Dim password As String = "pass123"
        Dim user As String = "admin"
        'Defines the first login number 
        Dim i As Integer = 1

        'The Do loop will loop until the username and password is correct
        Do
            If (UserNameBox.Text = user) AndAlso (PasswordBox.Text = password) Then
                MsgBox("Logged In", MsgBoxStyle.OkCancel, "Valid")
                Exit Do
                'If incorrect, it will alert the user of this and give them two more boxes to enter the username and password
            Else
                MsgBox("Password or Username is incorrect. Try again", MsgBoxStyle.RetryCancel, "Invalid")
                user = InputBox("Enter Username", "UserName")
                password = InputBox("Enter Password", "Password")
            End If

            'We start at one attempt
            i += 1
            'If the attempt reaches 3 tries, the app will close
        Loop Until i = 3
        If (i = 3) Then
            MsgBox("You've exceeded your number of tries. Bye.", MsgBoxStyle.OkOnly, "Invalid")
            Me.Close()
        End If

    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        UserNameBox.Text = ""
        PasswordBox.Text = ""
    End Sub
End Class
