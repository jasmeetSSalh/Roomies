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

    End Sub
End Class
