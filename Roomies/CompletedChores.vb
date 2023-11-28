Public Class CompletedChores
    Inherits Form1.Task

    Private _completedOn As DateTime?

    Public Sub New(taskName As String, description As String, dueDate As DateTime, frequency As String, exceptions As String, assignedTo As String, effort As Integer, completedOn As DateTime?)
        MyBase.New(taskName, description, dueDate, frequency, exceptions, assignedTo, effort)
        Me.CompletedOn = completedOn
    End Sub

    Public Property CompletedOn As DateTime?
        Get
            Return _completedOn
        End Get
        Set(value As DateTime?)
            _completedOn = value
        End Set
    End Property

End Class
