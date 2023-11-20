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
        Dim ListViewItem1 As ListViewItem = New ListViewItem(New String() {"Party Cups", "$10.00"}, -1)
        TabControl1 = New TabControl()
        Expense = New TabPage()
        BalanceSheet1 = New BalanceSheet()
        ViewBalanceSheet = New Button()
        yourTotalAmount = New Label()
        yourTotalLabel = New Label()
        yourExpenseList = New ListView()
        yourExpenseItemColumn = New ColumnHeader()
        yourExpenseCostColumn = New ColumnHeader()
        yourExpenseLabel = New Label()
        Chore = New TabPage()
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
        Performance = New TabPage()
        TabControl1.SuspendLayout()
        Expense.SuspendLayout()
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
        TabControl1.Controls.Add(Performance)
        TabControl1.ItemSize = New Size(90, 50)
        TabControl1.Location = New Point(7, 12)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(455, 577)
        TabControl1.SizeMode = TabSizeMode.Fixed
        TabControl1.TabIndex = 0
        ' 
        ' Expense
        ' 
        Expense.Controls.Add(BalanceSheet1)
        Expense.Controls.Add(ViewBalanceSheet)
        Expense.Controls.Add(yourTotalAmount)
        Expense.Controls.Add(yourTotalLabel)
        Expense.Controls.Add(yourExpenseList)
        Expense.Controls.Add(yourExpenseLabel)
        Expense.Location = New Point(4, 4)
        Expense.Name = "Expense"
        Expense.Padding = New Padding(3)
        Expense.Size = New Size(447, 519)
        Expense.TabIndex = 0
        Expense.Text = "Expense"
        Expense.UseVisualStyleBackColor = True
        ' 
        ' BalanceSheet1
        ' 
        BalanceSheet1.Location = New Point(0, 0)
        BalanceSheet1.Name = "BalanceSheet1"
        BalanceSheet1.Size = New Size(447, 519)
        BalanceSheet1.TabIndex = 9
        BalanceSheet1.Visible = False
        ' 
        ' ViewBalanceSheet
        ' 
        ViewBalanceSheet.Location = New Point(10, 454)
        ViewBalanceSheet.Name = "ViewBalanceSheet"
        ViewBalanceSheet.Size = New Size(126, 47)
        ViewBalanceSheet.TabIndex = 8
        ViewBalanceSheet.Text = "Household Balance Sheet"
        ViewBalanceSheet.UseVisualStyleBackColor = True
        ' 
        ' yourTotalAmount
        ' 
        yourTotalAmount.AutoSize = True
        yourTotalAmount.Font = New Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point)
        yourTotalAmount.Location = New Point(140, 373)
        yourTotalAmount.Name = "yourTotalAmount"
        yourTotalAmount.Size = New Size(69, 28)
        yourTotalAmount.TabIndex = 7
        yourTotalAmount.Text = "$0.00"
        ' 
        ' yourTotalLabel
        ' 
        yourTotalLabel.AutoSize = True
        yourTotalLabel.Font = New Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point)
        yourTotalLabel.Location = New Point(10, 373)
        yourTotalLabel.Name = "yourTotalLabel"
        yourTotalLabel.Size = New Size(126, 28)
        yourTotalLabel.TabIndex = 6
        yourTotalLabel.Text = "Your Total:"
        ' 
        ' yourExpenseList
        ' 
        yourExpenseList.Activation = ItemActivation.OneClick
        yourExpenseList.Alignment = ListViewAlignment.Default
        yourExpenseList.Columns.AddRange(New ColumnHeader() {yourExpenseItemColumn, yourExpenseCostColumn})
        yourExpenseList.GridLines = True
        yourExpenseList.Items.AddRange(New ListViewItem() {ListViewItem1})
        yourExpenseList.LabelEdit = True
        yourExpenseList.Location = New Point(10, 67)
        yourExpenseList.Name = "yourExpenseList"
        yourExpenseList.Size = New Size(424, 295)
        yourExpenseList.TabIndex = 5
        yourExpenseList.UseCompatibleStateImageBehavior = False
        yourExpenseList.View = View.Details
        ' 
        ' yourExpenseItemColumn
        ' 
        yourExpenseItemColumn.Text = "Item"
        yourExpenseItemColumn.Width = 600
        ' 
        ' yourExpenseCostColumn
        ' 
        yourExpenseCostColumn.Text = "Cost"
        yourExpenseCostColumn.Width = 120
        ' 
        ' yourExpenseLabel
        ' 
        yourExpenseLabel.AutoSize = True
        yourExpenseLabel.Font = New Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point)
        yourExpenseLabel.Location = New Point(10, 29)
        yourExpenseLabel.Name = "yourExpenseLabel"
        yourExpenseLabel.Size = New Size(165, 28)
        yourExpenseLabel.TabIndex = 4
        yourExpenseLabel.Text = "Your Expenses"
        ' 
        ' Chore
        ' 
        Chore.Location = New Point(4, 4)
        Chore.Name = "Chore"
        Chore.Size = New Size(447, 519)
        Chore.TabIndex = 2
        Chore.Text = "Chore"
        Chore.UseVisualStyleBackColor = True
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
        ' Performance
        ' 
        Performance.Location = New Point(4, 4)
        Performance.Name = "Performance"
        Performance.Size = New Size(447, 519)
        Performance.TabIndex = 4
        Performance.Text = "Performance"
        Performance.UseVisualStyleBackColor = True
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
        Expense.ResumeLayout(False)
        Expense.PerformLayout()
        Home.ResumeLayout(False)
        Home.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Expense As TabPage
    Friend WithEvents Home As TabPage
    Friend WithEvents Chore As TabPage
    Friend WithEvents Trade As TabPage
    Friend WithEvents Performance As TabPage
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
    Friend WithEvents yourTotalAmount As Label
    Friend WithEvents yourTotalLabel As Label
    Friend WithEvents yourExpenseList As ListView
    Friend WithEvents yourExpenseItemColumn As ColumnHeader
    Friend WithEvents yourExpenseCostColumn As ColumnHeader
    Friend WithEvents yourExpenseLabel As Label
    Friend WithEvents ViewBalanceSheet As Button
    Friend WithEvents BalanceSheet1 As BalanceSheet
End Class
