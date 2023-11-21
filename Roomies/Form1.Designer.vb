<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        TabControl1 = New TabControl()
        Expense = New TabPage()
        Chore = New TabPage()
        ChoreCompletionHistoryBtn = New Button()
        ChoreHistory = New ChoreHistory()
        Home = New TabPage()
        addTaskHomeScreenBtn = New Button()
        roomatesTasksHomeScreenListView = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        yourTasksHomeScreenListView = New ListView()
        taskName = New ColumnHeader()
        Description = New ColumnHeader()
        dueDate = New ColumnHeader()
        frequency = New ColumnHeader()
        assignedTo = New ColumnHeader()
        roomateTaskslbl = New Label()
        yourTaskslbl = New Label()
        Trade = New TabPage()
        TabControl1.SuspendLayout()
        Chore.SuspendLayout()
        Home.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Alignment = TabAlignment.Bottom
        TabControl1.Controls.Add(Expense)
        TabControl1.Controls.Add(Chore)
        TabControl1.Controls.Add(Home)
        TabControl1.Controls.Add(Trade)
        TabControl1.ItemSize = New Size(113, 50)
        TabControl1.Location = New Point(7, 12)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(455, 577)
        TabControl1.SizeMode = TabSizeMode.Fixed
        TabControl1.TabIndex = 0
        ' 
        ' Expense
        ' 
        Expense.Location = New Point(4, 4)
        Expense.Name = "Expense"
        Expense.Padding = New Padding(3)
        Expense.Size = New Size(447, 519)
        Expense.TabIndex = 0
        Expense.Text = "Expense"
        Expense.UseVisualStyleBackColor = True
        ' 
        ' Chore
        ' 
        Chore.Controls.Add(ChoreHistory)
        Chore.Controls.Add(ChoreCompletionHistoryBtn)
        Chore.Location = New Point(4, 4)
        Chore.Name = "Chore"
        Chore.Size = New Size(447, 519)
        Chore.TabIndex = 2
        Chore.Text = "Chore"
        Chore.UseVisualStyleBackColor = True
        ' 
        ' ChoreCompletionHistoryBtn
        ' 
        ChoreCompletionHistoryBtn.Location = New Point(17, 449)
        ChoreCompletionHistoryBtn.Name = "ChoreCompletionHistoryBtn"
        ChoreCompletionHistoryBtn.Size = New Size(106, 50)
        ChoreCompletionHistoryBtn.TabIndex = 0
        ChoreCompletionHistoryBtn.Text = "History"
        ChoreCompletionHistoryBtn.UseVisualStyleBackColor = True
        ' 
        ' ChoreHistory
        ' 
        ChoreHistory.Location = New Point(0, 0)
        ChoreHistory.Name = "ChoreHistory"
        ChoreHistory.Size = New Size(447, 519)
        ChoreHistory.TabIndex = 1
        ChoreHistory.Visible = False
        ' 
        ' Home
        ' 
        Home.Controls.Add(addTaskHomeScreenBtn)
        Home.Controls.Add(roomatesTasksHomeScreenListView)
        Home.Controls.Add(yourTasksHomeScreenListView)
        Home.Controls.Add(roomateTaskslbl)
        Home.Controls.Add(yourTaskslbl)
        Home.Location = New Point(4, 4)
        Home.Name = "Home"
        Home.Padding = New Padding(3)
        Home.Size = New Size(447, 519)
        Home.TabIndex = 1
        Home.Text = "Home"
        Home.UseVisualStyleBackColor = True
        ' 
        ' addTaskHomeScreenBtn
        ' 
        addTaskHomeScreenBtn.Location = New Point(116, 435)
        addTaskHomeScreenBtn.Name = "addTaskHomeScreenBtn"
        addTaskHomeScreenBtn.Size = New Size(203, 63)
        addTaskHomeScreenBtn.TabIndex = 5
        addTaskHomeScreenBtn.Text = "Add Task"
        addTaskHomeScreenBtn.UseVisualStyleBackColor = True
        ' 
        ' roomatesTasksHomeScreenListView
        ' 
        roomatesTasksHomeScreenListView.Activation = ItemActivation.OneClick
        roomatesTasksHomeScreenListView.Alignment = ListViewAlignment.Default
        roomatesTasksHomeScreenListView.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5})
        roomatesTasksHomeScreenListView.GridLines = True
        roomatesTasksHomeScreenListView.Location = New Point(6, 284)
        roomatesTasksHomeScreenListView.Name = "roomatesTasksHomeScreenListView"
        roomatesTasksHomeScreenListView.Size = New Size(424, 135)
        roomatesTasksHomeScreenListView.TabIndex = 4
        roomatesTasksHomeScreenListView.UseCompatibleStateImageBehavior = False
        roomatesTasksHomeScreenListView.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Task"
        ColumnHeader1.Width = 70
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Description"
        ColumnHeader2.Width = 120
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Due Date"
        ColumnHeader3.Width = 90
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Frequency"
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Assigned To"
        ColumnHeader5.Width = 80
        ' 
        ' yourTasksHomeScreenListView
        ' 
        yourTasksHomeScreenListView.Activation = ItemActivation.OneClick
        yourTasksHomeScreenListView.Alignment = ListViewAlignment.Default
        yourTasksHomeScreenListView.Columns.AddRange(New ColumnHeader() {taskName, Description, dueDate, frequency, assignedTo})
        yourTasksHomeScreenListView.GridLines = True
        yourTasksHomeScreenListView.Location = New Point(6, 85)
        yourTasksHomeScreenListView.Name = "yourTasksHomeScreenListView"
        yourTasksHomeScreenListView.Size = New Size(424, 135)
        yourTasksHomeScreenListView.TabIndex = 3
        yourTasksHomeScreenListView.UseCompatibleStateImageBehavior = False
        yourTasksHomeScreenListView.View = View.Details
        ' 
        ' taskName
        ' 
        taskName.Text = "Task"
        taskName.Width = 70
        ' 
        ' Description
        ' 
        Description.Text = "Description"
        Description.Width = 120
        ' 
        ' dueDate
        ' 
        dueDate.Text = "Due Date"
        dueDate.Width = 90
        ' 
        ' frequency
        ' 
        frequency.Text = "Frequency"
        ' 
        ' assignedTo
        ' 
        assignedTo.Text = "Assigned To"
        assignedTo.Width = 80
        ' 
        ' roomateTaskslbl
        ' 
        roomateTaskslbl.AutoSize = True
        roomateTaskslbl.Font = New Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point)
        roomateTaskslbl.Location = New Point(16, 243)
        roomateTaskslbl.Name = "roomateTaskslbl"
        roomateTaskslbl.Size = New Size(205, 28)
        roomateTaskslbl.TabIndex = 1
        roomateTaskslbl.Text = "Roomates's  Tasks"
        ' 
        ' yourTaskslbl
        ' 
        yourTaskslbl.AutoSize = True
        yourTaskslbl.Font = New Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point)
        yourTaskslbl.Location = New Point(16, 39)
        yourTaskslbl.Name = "yourTaskslbl"
        yourTaskslbl.Size = New Size(125, 28)
        yourTaskslbl.TabIndex = 0
        yourTaskslbl.Text = "Your Tasks"
        ' 
        ' Trade
        ' 
        Trade.Location = New Point(4, 4)
        Trade.Name = "Trade"
        Trade.Size = New Size(447, 519)
        Trade.TabIndex = 3
        Trade.Text = "Trade"
        Trade.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(464, 601)
        Controls.Add(TabControl1)
        Name = "Form1"
        Text = "Roomies"
        TabControl1.ResumeLayout(False)
        Chore.ResumeLayout(False)
        Home.ResumeLayout(False)
        Home.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Expense As TabPage
    Friend WithEvents Home As TabPage
    Friend WithEvents Chore As TabPage
    Friend WithEvents Trade As TabPage
    Friend WithEvents roomateTaskslbl As Label
    Friend WithEvents yourTaskslbl As Label
    Friend WithEvents yourTasksHomeScreenListView As ListView
    Friend WithEvents taskName As ColumnHeader
    Friend WithEvents dueDate As ColumnHeader
    Friend WithEvents frequency As ColumnHeader
    Friend WithEvents Description As ColumnHeader
    Friend WithEvents assignedTo As ColumnHeader
    Friend WithEvents addTaskHomeScreenBtn As Button
    Friend WithEvents roomatesTasksHomeScreenListView As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ChoreCompletionHistoryBtn As Button
    Friend WithEvents ChoreHistory As ChoreHistory
End Class
