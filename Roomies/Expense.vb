Public Class Expense


    Public Property Name As String
    Public Property Amount As Decimal
    Public Property DateAdded As DateTime

    Private _participants As List(Of String)
    Public Property Participants As List(Of String)
        Get
            Return _participants
        End Get
        Set(value As List(Of String))
            _participants = value
            ParticipantsString = String.Join(", ", value)
        End Set
    End Property

    Public Property ParticipantsString As String

End Class
