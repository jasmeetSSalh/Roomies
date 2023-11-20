Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class AddExpense

    Private Sub addExpenseBackBtn_Click(sender As Object, e As EventArgs) Handles addExpenseBackBtn.Click
        Me.Hide()
        expenseNameBox.Text = ""
        expenseAmountBox.Text = "$0.00"
        expenseNotesBox.Text = ""
        expenseNameError.Hide()
        expenseAmountError.Hide()
        expenseParticipantError.Hide()
        selectAndrew.Checked = False
        selectNahid.Checked = False

    End Sub

    Private Sub addExpenseBackBtn_MouseEnter(sender As Object, e As EventArgs) Handles addExpenseBackBtn.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub addExpenseBackBtn_MouseLeave(sender As Object, e As EventArgs) Handles addExpenseBackBtn.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub expenseAmountBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles expenseAmountBox.KeyPress
        ' Prevent the deletion of the "$" symbol
        If expenseAmountBox.SelectionStart = 1 AndAlso e.KeyChar = CChar(vbBack) Then
            e.Handled = True
        End If

        If String.IsNullOrWhiteSpace(expenseAmountBox.Text) Then
            expenseAmountBox.Text = "$"
            expenseAmountBox.SelectionStart = 1
        End If
    End Sub

    Private Sub expenseAmountBox_TextChanged(sender As Object, e As EventArgs) Handles expenseAmountBox.TextChanged
        ' Ensure that the "$" symbol is always present
        If String.IsNullOrWhiteSpace(expenseAmountBox.Text) Then
            expenseAmountBox.Text = "$"
            expenseAmountBox.SelectionStart = 1
        End If
    End Sub

    Private Sub addExpenseButton_Click(sender As Object, e As EventArgs) Handles addExpenseButton.Click
        If String.IsNullOrWhiteSpace(expenseNameBox.Text) Then
            expenseNameError.Show()
        End If
        If expenseAmountBox.Text = "$0.00" Then
            expenseAmountError.Show()
        End If
        If Not selectAndrew.Checked And Not selectNahid.Checked Then
            expenseParticipantError.Show()
        End If
    End Sub
End Class
