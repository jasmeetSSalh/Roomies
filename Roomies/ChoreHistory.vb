Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ChoreHistory
    Inherits UserControl

    Private _completedChores As New List(Of CompletedChores)

    Public Property CompletedChores As List(Of CompletedChores)
        Get
            Return _completedChores
        End Get
        Set(value As List(Of CompletedChores))
            _completedChores = value

        End Set
    End Property

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Me.Hide()
    End Sub

    Private Sub ChoreHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each chore In _completedChores

            Dim item As New ListViewItem(chore.TaskName)

            item.SubItems.Add(chore.AssignedTo)
            item.SubItems.Add(chore.CompletedOn.Value.ToString())

            Me.HistoryList.Items.Add(item)
        Next
    End Sub

    Private Sub BalanceSheetBackBtn_MouseEnter(sender As Object, e As EventArgs) Handles BackBtn.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub BalanceSheetBackBtn_MouseLeave(sender As Object, e As EventArgs) Handles BackBtn.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub
End Class
