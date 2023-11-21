Imports System.ComponentModel

Public Class Form1
    Public expenses As New BindingList(Of Expense)()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Test data for testing the PopulateListView function
        ''''''''''''''''''''''''''''''''''''''''''''' TEST
        Dim task1 As New Task("Task 1", "Description 1", DateTime.Now.AddDays(1), "Daily", "Soap", "P1")
        Dim task2 As New Task("Task 2", "Description 2", DateTime.Now.AddDays(2), "None", "Nothing", "P2")

        yourTasksArray.Add(task1)
        yourTasksArray.Add(task2)

        roommatesTasksArray.Add(task1)
        roommatesTasksArray.Add(task2)

        PopulateYourHomeScreenListView(yourTasksArray)
        PopulateRoomateHomeScreenListView(roommatesTasksArray)
        '''''''''''''''''''''''''''''''''''''''''''''' REMOVE THE CODE AFTER WE ARE DONE TESTING
        '''
        expenses.Add(New Expense With {.Name = "Groceries", .Amount = 100D, .DateAdded = DateTime.Now, .Participants = New List(Of String)({"Andrew", "Nahid"})})
        expenses.Add(New Expense With {.Name = "Electricity Bill", .Amount = 60D, .DateAdded = DateTime.Now.AddDays(-10), .Participants = New List(Of String)({"Andrew", "Nahid"})})

        BalanceSheet1.DataGridView1.DataSource = expenses
        DisplayYourExpense()
        UpdateTotalAmount()
    End Sub

    ' Task Definition
    Public Class Task
        ' Private fields
        Private _taskName As String
        Private _description As String
        Private _dueDate As DateTime
        Private _frequency As String
        Private _exceptions As String
        Private _assignedTo As String ' Added AssignedTo property

        ' Constructor
        Public Sub New(taskName As String, description As String, dueDate As DateTime, frequency As String, exceptions As String, assignedTo As String)
            Me.TaskName = taskName
            Me.Description = description
            Me.DueDate = dueDate
            Me.Frequency = frequency
            Me.Exceptions = exceptions
            Me.AssignedTo = assignedTo
        End Sub

        ' TaskName property
        Public Property TaskName As String
            Get
                Return _taskName
            End Get
            Set(value As String)
                _taskName = value
            End Set
        End Property

        ' Description property
        Public Property Description As String
            Get
                Return _description
            End Get
            Set(value As String)
                _description = value
            End Set
        End Property

        ' DueDate property
        Public Property DueDate As DateTime
            Get
                Return _dueDate
            End Get
            Set(value As DateTime)
                _dueDate = value
            End Set
        End Property

        ' Frequency property
        Public Property Frequency As String
            Get
                Return _frequency
            End Get
            Set(value As String)
                _frequency = value
            End Set
        End Property

        ' Exceptions property
        Public Property Exceptions As String
            Get
                Return _exceptions
            End Get
            Set(value As String)
                _exceptions = value
            End Set
        End Property

        ' AssignedTo property
        Public Property AssignedTo As String
            Get
                Return _assignedTo
            End Get
            Set(value As String)
                _assignedTo = value
            End Set
        End Property
    End Class


    ' Your Tasks Array
    Dim yourTasksArray As New List(Of Task)()

    ' Function to add tasks to yourTasksArray - used to add tasks from the task creation form
    Public Sub AddTask(task As Task)
        yourTasksArray.Add(task)
    End Sub

    ' Your Roommates Tasks Array
    Dim roommatesTasksArray As New List(Of Task)()



    'xxxxxxxxxxxxxxxxxxxxxxx______HOMEPAGE CODE______xxxxxxxxxxxxxxxxxxxxxxxxxx


    ''' <param name="tasksArray"></param>
    ' Function to add tasks in yourTasksArray to ListView
    Private Sub PopulateYourHomeScreenListView(tasksArray As List(Of Task))
        For Each task As Task In tasksArray
            ' Check if the item is already in the ListView
            If Not TaskExistsInListView(yourTasksHomeScreenListView, task) Then
                Dim item As New ListViewItem(task.TaskName)
                item.SubItems.Add(task.Description)
                item.SubItems.Add(task.DueDate.ToString("M"))
                item.SubItems.Add(task.Frequency.ToString())
                item.SubItems.Add(task.AssignedTo)
                yourTasksHomeScreenListView.Items.Add(item)
            End If
        Next
    End Sub

    Private Sub PopulateRoomateHomeScreenListView(tasksArray As List(Of Task))
        For Each task As Task In tasksArray
            If Not TaskExistsInListView(roomatesTasksHomeScreenListView, task) Then
                Dim item As New ListViewItem(task.TaskName)
                item.SubItems.Add(task.Description)
                item.SubItems.Add(task.DueDate.ToString("M"))
                item.SubItems.Add(task.Frequency.ToString())
                item.SubItems.Add(task.AssignedTo)
                roomatesTasksHomeScreenListView.Items.Add(item)
            End If
        Next
    End Sub

    ' Function to check if a task exists in the ListView
    Private Function TaskExistsInListView(listView As ListView, task As Task) As Boolean
        For Each item As ListViewItem In listView.Items
            ' Assuming the first column contains the task name
            If item.Text = task.TaskName Then
                Return True
            End If
        Next
        Return False
    End Function


    'This button is on the home page, and redirects the user to the task creation's page
    Private Sub AddTaskHomeScreenBtn_Click(sender As Object, e As EventArgs) Handles addTaskHomeScreenBtn.Click
        Dim choreCreationForm As New ChoreCreationForm(Me)
        Dim result As DialogResult = choreCreationForm.ShowDialog()

        If result = DialogResult.OK Then
            Dim newTask As Task = choreCreationForm.CreatedTask
            yourTasksArray.Add(newTask)
            PopulateYourHomeScreenListView(yourTasksArray) ' Update the list view
        End If
    End Sub

    'xxxxxxxxxxxxxxxxxxxxxxx______HOMEPAGE CODE ENDS______xxxxxxxxxxxxxxxxxxxxxxxxxx

    'xxxxxxxxxxxxxxxxxxxxxxx______EXPENSE PAGE CODE______xxxxxxxxxxxxxxxxxxxxxxxxxx
    Private Sub DisplayYourExpense()
        For Each item As Expense In expenses
            If item.Participants.Contains("Andrew") Then
                If item.Participants.Count = 1 Then
                    Dim listItem As New ListViewItem(item.Name)
                    listItem.SubItems.Add(item.Amount.ToString("N2"))
                    yourExpenseList.Items.Add(listItem)
                Else
                    Dim listItem As New ListViewItem(item.Name)
                    listItem.SubItems.Add((item.Amount / 2).ToString("N2"))
                    yourExpenseList.Items.Add(listItem)
                End If
            End If

        Next
    End Sub
    Public Sub UpdateTotalAmount()
        Dim totalAmount As Decimal = 0

        For Each item As ListViewItem In yourExpenseList.Items
            Dim costValue As Decimal

            If Decimal.TryParse(item.SubItems(1).Text.TrimStart("$"c), costValue) Then
                totalAmount += costValue
            End If
        Next

        yourTotalAmount.Text = $"{totalAmount:C}"
    End Sub
    Private Sub ViewBalanceSheet_Click(sender As Object, e As EventArgs) Handles ViewBalanceSheet.Click
        BalanceSheet1.Show()
        expenseAddedSuccess.Hide()
    End Sub

    Private Sub BalanceSheet1_Load(sender As Object, e As EventArgs) Handles BalanceSheet1.Load
        Dim total As Decimal = 0
        For Each item In expenses
            total += item.Amount
        Next

        BalanceSheet1.householdTotalAmount.Text = "$" + total.ToString("N2")
    End Sub

    Private Sub addExpenseButton_Click(sender As Object, e As EventArgs) Handles addExpenseButton.Click
        AddExpenseForm.Show()
        expenseAddedSuccess.Hide()
    End Sub


    'xxxxxxxxxxxxxxxxxxxxxxx______EXPENSE PAGE CODE ENDS______xxxxxxxxxxxxxxxxxxxxxxxxxx


End Class
