
Public Class Form1
    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        Dim i, x1, x2, S, k As Integer, Sa As Single
        S = 1 : k = 0
        For i = 10 To 99
            x1 = i \ 10
            x2 = i Mod 10
            If x2 * 2 = x1 Then
                Posl.Text = Posl.Text + CStr(i) + vbNewLine
                S = S * i
                k = k + 1

            End If
        Next
        If k <> 0 Then Sa = S / k
        TS.Text = S
        Tk.Text = k
        TSa.Text = Sa

    End Sub
End Class



