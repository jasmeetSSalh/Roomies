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
        _completedChores.Clear()
        HistoryList.Items.Clear()
        Me.Hide()
    End Sub

    Private Sub BalanceSheetBackBtn_MouseEnter(sender As Object, e As EventArgs) Handles BackBtn.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub BalanceSheetBackBtn_MouseLeave(sender As Object, e As EventArgs) Handles BackBtn.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub
End Class
