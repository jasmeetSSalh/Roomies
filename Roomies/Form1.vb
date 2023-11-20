
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Test data for testing the PopulateListView function
        ''''''''''''''''''''''''''''''''''''''''''''' TEST
        Dim task1 As New Task("Garbage", "Description 1", DateTime.Now.AddDays(1), "Daily", "Soap", "P1")
        Dim task2 As New Task("Cooking", "Description 2", DateTime.Now.AddDays(2), "None", "Nothing", "P1")

        yourTasksArray.Add(task1)
        yourTasksArray.Add(task2)

        Dim task3 As New Task("Mopping", "Description 1", DateTime.Now.AddDays(1), "Daily", "Soap", "P2")
        Dim task4 As New Task("Fixing", "Description 2", DateTime.Now.AddDays(2), "None", "Nothing", "P2")

        roommatesTasksArray.Add(task3)
        roommatesTasksArray.Add(task4)

        PopulateYourHomeScreenListView(yourTasksArray)
        PopulateRoomateHomeScreenListView(roommatesTasksArray)

        PopulateListViewTasks(ChoreListView, yourTasksArray)
        PopulateListViewTasks(ChoreListView, roommatesTasksArray)
        '''''''''''''''''''''''''''''''''''''''''''''' REMOVE THE CODE AFTER WE ARE DONE TESTING

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

    Dim roommatePersonList As New List(Of String) From {"P1", "P2"}

    Dim yourName As String = "P1"



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

    Private Sub PopulateListViewTasks(listView As ListView, items As List(Of Task))
        For Each task As Task In items
            If Not TaskExistsInListView(listView, task) Then
                Dim item As New ListViewItem(task.TaskName)
                item.SubItems.Add(task.Description)
                item.SubItems.Add(task.DueDate.ToString("M"))
                item.SubItems.Add(task.Frequency.ToString())
                item.SubItems.Add(task.AssignedTo)
                listView.Items.Add(item)
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
    Private Sub AddTaskHomeScreenBtn_Click(sender As Object, e As EventArgs) Handles addTaskHomeScreenBtn.Click, addTaskChoreBtn.Click
        Dim choreCreationForm As New ChoreCreationForm(Me)
        Dim result As DialogResult = choreCreationForm.ShowDialog()

        If result = DialogResult.OK Then
            Dim newTask As Task = choreCreationForm.CreatedTask
            PopulateYourHomeScreenListView(yourTasksArray) ' Update the list view
            'update chorelistview
            PopulateListViewTasks(ChoreListView, yourTasksArray)

        End If
    End Sub

    'xxxxxxxxxxxxxxxxxxxxxxx______HOMEPAGE CODE ENDS______xxxxxxxxxxxxxxxxxxxxxxxxxx

    Private Sub ChoreListScroll_Scroll(sender As Object, e As ScrollEventArgs) Handles ChoreListScroll.Scroll
        Dim maxIndex As Integer = ChoreListView.Items.Count - 1
        Dim scrollValue As Integer = ChoreListScroll.Value

        If scrollValue >= maxIndex Then
            ChoreListView.EnsureVisible(e.NewValue)
        End If

    End Sub

    Private Sub Trade_Enter(sender As Object, e As EventArgs) Handles Trade.Enter
        ' populating the combo boxes in the trade tab

        offerComboBox.Items.Clear()
        personComboBox.Items.Clear()
        taskComboBox.Items.Clear()


        For Each task As Task In yourTasksArray
            offerComboBox.Items.Add(task.TaskName)
        Next

        For Each person As String In roommatePersonList
            personComboBox.Items.Add(person)
        Next

        personComboBox.Items.Remove(yourName)

        'set selected item
        offerComboBox.SelectedIndex = 0

        personComboBox.SelectedIndex = 0

    End Sub

    Private Sub Chore_Enter(sender As Object, e As EventArgs) Handles Chore.Enter
        'clear the list view and repopulate it
        ChoreListView.Items.Clear()

        PopulateListViewTasks(ChoreListView, yourTasksArray)
        PopulateListViewTasks(ChoreListView, roommatesTasksArray)
    End Sub

    Private Sub personComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles personComboBox.SelectedIndexChanged
        taskComboBox.Items.Clear()

        'for each task assigned to selected person
        For Each task As Task In roommatesTasksArray
            If task.AssignedTo = personComboBox.SelectedItem Then
                taskComboBox.Items.Add(task.TaskName)
            End If
        Next

        taskComboBox.SelectedIndex = 0
    End Sub

    Private Sub TradeBtn_Click(sender As Object, e As EventArgs) Handles TradeBtn.Click
        MessageBox.Show("Trade Sent!")
        'wait for 1.5 seconds to mimic trade acceptence
        System.Threading.Thread.Sleep(1500)

        MessageBox.Show("Trade Accepted!")

        'swap offercombobox and taskcombobox tasks
        Dim offerTask As Task = yourTasksArray.Find(Function(x) x.TaskName = offerComboBox.SelectedItem)
        Dim roommateTask As Task = roommatesTasksArray.Find(Function(x) x.TaskName = taskComboBox.SelectedItem)


        roommatesTasksArray.Remove(roommateTask)
        yourTasksArray.Remove(offerTask)

        offerTask.AssignedTo = personComboBox.SelectedItem
        roommateTask.AssignedTo = yourName

        yourTasksArray.Add(roommateTask)
        roommatesTasksArray.Add(offerTask)

    End Sub

    Private Sub ClearHomeScreen()

        yourTasksHomeScreenListView.Items.Clear()
        roomatesTasksHomeScreenListView.Items.Clear()

    End Sub

    ' creating a Enter handler for homepage to automatically update lists to any changes on other tabs
    Private Sub Home_Enter(sender As Object, e As EventArgs) Handles Home.Enter
        ClearHomeScreen()

        PopulateYourHomeScreenListView(yourTasksArray)
        PopulateRoomateHomeScreenListView(roommatesTasksArray)
    End Sub
End Class
