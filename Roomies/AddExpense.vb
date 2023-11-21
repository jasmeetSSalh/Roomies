Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class AddExpense

    Private Sub addExpenseBackBtn_Click(sender As Object, e As EventArgs) Handles addExpenseBackBtn.Click
        Me.Hide()
        Form1.expenseAddedSuccess.Hide()
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

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles expenseAmountBox.Enter
        ' Set the text to something when the user tabs into the textbox
        expenseAmountBox.Text = "$"
        expenseAmountBox.SelectionStart = 1
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

    Private Sub expenseAmountBox_GotFocus(sender As Object, e As EventArgs) Handles expenseAmountBox.GotFocus
        If String.IsNullOrEmpty(expenseAmountBox.Text) Then
            expenseAmountBox.Text = "$"
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
        Else
            expenseNameError.Hide()
        End If
        If expenseAmountBox.Text = "$0.00" Or expenseAmountBox.Text = "$" Or expenseAmountBox.Text = "$0" Or expenseAmountBox.Text = "$0.0" Then
            expenseAmountError.Show()
        Else
            expenseAmountError.Hide()
        End If
        If Not selectAndrew.Checked And Not selectNahid.Checked Then
            expenseParticipantError.Show()
        Else
            expenseParticipantError.Hide()
        End If

        If Not String.IsNullOrWhiteSpace(expenseNameBox.Text) And Not expenseAmountBox.Text = "$0.00" And Not (Not selectAndrew.Checked And Not selectNahid.Checked) Then
            Dim name As String = expenseNameBox.Text
            Dim amount As Decimal = expenseAmountBox.Text.Substring(1)
            Dim notes As String = expenseNotesBox.Text
            Dim participants As New List(Of String)

            If selectAndrew.Checked Then
                participants.Add("Andrew")
            End If
            If selectNahid.Checked Then
                participants.Add("Nahid")
            End If

            Form1.expenses.Add(New Expense With {.Name = name, .Amount = amount, .Notes = notes, .DateAdded = DateTime.Now, .Participants = participants})
            Form1.expenseAddedSuccess.Show()

            If participants.Contains("Andrew") Then
                If participants.Count = 1 Then
                    Dim listItem As New ListViewItem(name)
                    listItem.SubItems.Add(amount.ToString("N2"))
                    Form1.yourExpenseList.Items.Add(listItem)
                Else
                    Dim listItem As New ListViewItem(name)
                    listItem.SubItems.Add((amount / 2).ToString("N2"))
                    Form1.yourExpenseList.Items.Add(listItem)
                End If
            End If

            Form1.UpdateTotalAmount()
            Dim total As Decimal = 0
            For Each item In Form1.expenses
                total += item.Amount
            Next

            Form1.BalanceSheet1.householdTotalAmount.Text = "$" + total.ToString("N2")

            Me.Hide()
            expenseNameBox.Text = ""
            expenseAmountBox.Text = "$0.00"
            expenseNotesBox.Text = ""
            expenseNameError.Hide()
            expenseAmountError.Hide()
            expenseParticipantError.Hide()
            selectAndrew.Checked = False
            selectNahid.Checked = False


        End If

    End Sub


End Class
