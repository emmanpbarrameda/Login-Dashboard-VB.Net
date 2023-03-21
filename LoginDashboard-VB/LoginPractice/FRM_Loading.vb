Public Class FRM_Loading

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If PB1.Value < PB1.Maximum Then
            PB1.Value = PB1.Value + 1
            LBL_LoadingPercent.Text = Val(LBL_LoadingPercent.Text) + 1
        Else
            FRM_Main.Show()
            Me.Close()
        End If
    End Sub

End Class