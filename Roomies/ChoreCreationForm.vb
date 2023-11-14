Imports Roomies.Form1

Public Class ChoreCreationForm

    Private Sub ChoreCreationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private _mainForm As Form1

    Public Sub New(mainForm As Form1)
        InitializeComponent()
        _mainForm = mainForm
    End Sub

    Private Sub AddToPoolRadiobtnFunction(sender As Object, e As EventArgs) Handles addToPoolRadiobtn.Click
        voluteerRadiobtn.Checked = False

    End Sub

    Private Sub VoluteerRadiobtnFunction(sender As Object, e As EventArgs) Handles voluteerRadiobtn.Click
        addToPoolRadiobtn.Checked = False
    End Sub


    ' Property to get the created task
    Public Property CreatedTask As Task
        Get
            Return CreateTask()
        End Get
        Set(value As Task)

        End Set
    End Property

    ' Function to create a Task from the entered information
    Private Function CreateTask() As Task
        Dim taskName As String = nameOfTaskTextbox.Text
        Dim description As String = descriptionTextbox.Text
        Dim dueDate As DateTime = DateTimePicker1.Value
        Dim frequency As String = frequencyComboBox.SelectedItem
        Dim exceptions As String = ComboBox1.Text
        Dim assignedTo As String = If(addToPoolRadiobtn.Checked, "Pool", If(voluteerRadiobtn.Checked, "Me", ""))

        Return New Task(taskName, description, dueDate, frequency, exceptions, assignedTo)
    End Function

    Private Sub Okbtn_Click(sender As Object, e As EventArgs) Handles okbtn.Click
        Dim task As Task = CreateTask()
        _mainForm.AddTask(task)
        Me.DialogResult = DialogResult.OK ' Set DialogResult
        Me.Close()
    End Sub

    Private Sub Cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        Me.DialogResult = DialogResult.Cancel ' Set DialogResult
        Me.Close()
    End Sub

End Class
