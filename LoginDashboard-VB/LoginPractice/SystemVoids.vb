Public Class SystemVoids

    Implements IDisposable
    Private disposedValue As Boolean = False
    Dim SystemName As String = "Emman"

    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' Dispose of managed resources here '
            End If

            ' Dispose of unmanaged resources here '

            disposedValue = True
        End If
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub


    'exit
    Public Sub ConfirmCloseForm(e As FormClosingEventArgs)
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to close the form?", SystemName + " | Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.No Then
            e.Cancel = True ' Cancel the form closing event

            'Else
            '    Dispose()
            '    Application.Exit() ' Exit the application

        End If
    End Sub



    ' Other methods and properties here '

End Class