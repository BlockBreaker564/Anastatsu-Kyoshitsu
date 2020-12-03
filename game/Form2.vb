Public Class Form2
    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Dim s As New Form3
        Select Case e.KeyCode
            Case Keys.Enter
                s.ShowDialog()
        End Select
    End Sub
End Class