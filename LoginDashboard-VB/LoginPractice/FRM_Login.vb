Public Class FRM_Login

    Public Shared Username As String
    Dim loginAttempts As Integer = 0

    Private closingHelper As New SystemVoids()

    'clear all activities then focus to username
    Private Sub ClearAllThenFocus()
        TXT_Username.Text = Nothing
        TXT_Password.Text = Nothing
        TXT_Username.Focus()
        CB_ShowPassword.Checked = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTN_Login.Click

        'uncheck the show-password automatically
        CB_ShowPassword.Checked = False

        ''CORRECT USERNAME
        If TXT_Username.Text = "Emman" And TXT_Password.Text = "password" Then

            'MessageBox.Show("Login successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Username = TXT_Username.Text
            loginAttempts = 0 'reset login attempts detector

            Me.Hide() ' Hide the current form
            Dim newForm As New FRM_Loading() ' Create an instance of the new form
            newForm.Show() ' Show the new form


        ElseIf TXT_Username.Text = Nothing Or TXT_Password.Text = Nothing Then
            ''IF EMPTY:
            loginAttempts = 0 'reset login attempts detector
            MessageBox.Show("One of the Required field is empty!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning)


        Else
            ''LOGIN FAILED:
            loginAttempts += 1

            If loginAttempts >= 5 Then
                ' Exceeded login attempts
                MessageBox.Show("Login attempts exceeded." & vbNewLine & "Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close() ' Close application

            Else
                ' Show remaining login attempts
                MessageBox.Show("Incorrect Login." & vbNewLine & (5 - loginAttempts) & " attempts remaining.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            'clear items after clicking OK Button
            ClearAllThenFocus()

        End If

    End Sub

    Private Sub TXT_Username_TextChanged(sender As Object, e As EventArgs) Handles TXT_Username.TextChanged
        ''detect if the name txtfield is empty or not
        If String.IsNullOrEmpty(TXT_Username.Text) Then
            BTN_Login.Enabled = False
        Else
            BTN_Login.Enabled = True
        End If
    End Sub

    Private Sub CB_ShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles CB_ShowPassword.CheckedChanged
        'show password
        If CB_ShowPassword.Checked = True Then
            TXT_Password.PasswordChar = ""
        Else
            TXT_Password.PasswordChar = "*"
        End If
    End Sub

    Private Sub TXT_Password_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles TXT_Password.PreviewKeyDown

        'auto click enter for login
        If e.KeyCode = Keys.Enter Then
            BTN_Login.PerformClick()
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Dim result As DialogResult = MessageBox.Show("Are you sure you want to close the form?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'If result = DialogResult.No Then
        '    e.Cancel = True ' Cancel the form closing event
        'Else
        '    Dispose()
        '    Application.Exit() ' Exit the application
        'End If

        closingHelper.Dispose()
        closingHelper.ConfirmCloseForm(e)

    End Sub

End Class
