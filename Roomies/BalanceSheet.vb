Public Class BalanceSheet
    Private Sub BalanceSheetBackBtn_Click(sender As Object, e As EventArgs) Handles BalanceSheetBackBtn.Click
        Me.Hide()
    End Sub

    Private Sub BalanceSheetBackBtn_MouseEnter(sender As Object, e As EventArgs) Handles BalanceSheetBackBtn.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub BalanceSheetBackBtn_MouseLeave(sender As Object, e As EventArgs) Handles BalanceSheetBackBtn.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
