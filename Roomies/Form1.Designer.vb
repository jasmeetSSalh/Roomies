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
        AddExpenseForm = New AddExpense()
        BalanceSheet1 = New BalanceSheet()
        expenseAddedSuccess = New Label()
        addExpenseButton = New Button()
        ViewBalanceSheet = New Button()
        yourTotalAmount = New Label()
        yourTotalLabel = New Label()
        yourExpenseList = New ListView()
        yourExpenseItemColumn = New ColumnHeader()
        yourExpenseCostColumn = New ColumnHeader()
        yourExpenseLabel = New Label()
        Chore = New TabPage()
        ChoreHistory = New ChoreHistory()
        addTaskChoreBtn = New Button()
        ChoreTitle = New Label()
        ChoreListScroll = New VScrollBar()
        ChoreListView = New ListView()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader7 = New ColumnHeader()
        ColumnHeader8 = New ColumnHeader()
        ColumnHeader9 = New ColumnHeader()
        ColumnHeader10 = New ColumnHeader()
        ChoreCompletionHistoryBtn = New Button()
        Home = New TabPage()
        HouseholdBtn = New Button()
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
        personTradeLabel = New Label()
        personComboBox = New ComboBox()
        TradeBtn = New Button()
        mateTradeLabel = New Label()
        taskComboBox = New ComboBox()
        selfTradeLabel = New Label()
        offerComboBox = New ComboBox()
        ColumnHeader11 = New ColumnHeader()
        Effort = New ColumnHeader()
        ColumnHeader12 = New ColumnHeader()
        TabControl1.SuspendLayout()
        Expense.SuspendLayout()
        Chore.SuspendLayout()
        Home.SuspendLayout()
        Trade.SuspendLayout()
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
        Expense.Controls.Add(AddExpenseForm)
        Expense.Controls.Add(BalanceSheet1)
        Expense.Controls.Add(expenseAddedSuccess)
        Expense.Controls.Add(addExpenseButton)
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
        ' AddExpenseForm
        ' 
        AddExpenseForm.Location = New Point(-12, -15)
        AddExpenseForm.Name = "AddExpenseForm"
        AddExpenseForm.Size = New Size(463, 908)
        AddExpenseForm.TabIndex = 11
        AddExpenseForm.Visible = False
        ' 
        ' BalanceSheet1
        ' 
        BalanceSheet1.Location = New Point(0, -1)
        BalanceSheet1.Margin = New Padding(5, 6, 5, 6)
        BalanceSheet1.Name = "BalanceSheet1"
        BalanceSheet1.Size = New Size(447, 519)
        BalanceSheet1.TabIndex = 9
        BalanceSheet1.Visible = False
        ' 
        ' expenseAddedSuccess
        ' 
        expenseAddedSuccess.AutoSize = True
        expenseAddedSuccess.Font = New Font("Gadugi", 9.857143F, FontStyle.Regular, GraphicsUnit.Point)
        expenseAddedSuccess.ForeColor = Color.Green
        expenseAddedSuccess.Location = New Point(10, 403)
        expenseAddedSuccess.Name = "expenseAddedSuccess"
        expenseAddedSuccess.Size = New Size(246, 17)
        expenseAddedSuccess.TabIndex = 21
        expenseAddedSuccess.Text = "A new expense was successfully added!"
        expenseAddedSuccess.Visible = False
        ' 
        ' addExpenseButton
        ' 
        addExpenseButton.Font = New Font("Gadugi", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        addExpenseButton.Location = New Point(306, 373)
        addExpenseButton.Name = "addExpenseButton"
        addExpenseButton.Size = New Size(126, 26)
        addExpenseButton.TabIndex = 10
        addExpenseButton.Text = "Add Expense"
        addExpenseButton.UseVisualStyleBackColor = True
        ' 
        ' ViewBalanceSheet
        ' 
        ViewBalanceSheet.Font = New Font("Gadugi", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point)
        ViewBalanceSheet.Location = New Point(10, 420)
        ViewBalanceSheet.Name = "ViewBalanceSheet"
        ViewBalanceSheet.Size = New Size(422, 47)
        ViewBalanceSheet.TabIndex = 8
        ViewBalanceSheet.Text = "Household Balance Sheet"
        ViewBalanceSheet.UseVisualStyleBackColor = True
        ' 
        ' yourTotalAmount
        ' 
        yourTotalAmount.AutoSize = True
        yourTotalAmount.Font = New Font("Gadugi", 18.0F, FontStyle.Regular, GraphicsUnit.Point)
        yourTotalAmount.Location = New Point(140, 373)
        yourTotalAmount.Name = "yourTotalAmount"
        yourTotalAmount.Size = New Size(69, 28)
        yourTotalAmount.TabIndex = 7
        yourTotalAmount.Text = "$0.00"
        ' 
        ' yourTotalLabel
        ' 
        yourTotalLabel.AutoSize = True
        yourTotalLabel.Font = New Font("Gadugi", 18.0F, FontStyle.Regular, GraphicsUnit.Point)
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
        yourExpenseItemColumn.Width = 300
        ' 
        ' yourExpenseCostColumn
        ' 
        yourExpenseCostColumn.Text = "Cost ($)"
        yourExpenseCostColumn.Width = 120
        ' 
        ' yourExpenseLabel
        ' 
        yourExpenseLabel.AutoSize = True
        yourExpenseLabel.Font = New Font("Gadugi", 18.0F, FontStyle.Regular, GraphicsUnit.Point)
        yourExpenseLabel.Location = New Point(10, 29)
        yourExpenseLabel.Name = "yourExpenseLabel"
        yourExpenseLabel.Size = New Size(165, 28)
        yourExpenseLabel.TabIndex = 4
        yourExpenseLabel.Text = "Your Expenses"
        ' 
        ' Chore
        ' 
        Chore.Controls.Add(ChoreHistory)
        Chore.Controls.Add(addTaskChoreBtn)
        Chore.Controls.Add(ChoreTitle)
        Chore.Controls.Add(ChoreListScroll)
        Chore.Controls.Add(ChoreListView)
        Chore.Controls.Add(ChoreCompletionHistoryBtn)
        Chore.Location = New Point(4, 4)
        Chore.Name = "Chore"
        Chore.Size = New Size(447, 519)
        Chore.TabIndex = 2
        Chore.Text = "Chore"
        Chore.UseVisualStyleBackColor = True
        ' 
        ' ChoreHistory
        ' 
        ChoreHistory.Location = New Point(0, -3)
        ChoreHistory.Name = "ChoreHistory"
        ChoreHistory.Size = New Size(447, 519)
        ChoreHistory.TabIndex = 22
        ChoreHistory.Visible = False
        ' 
        ' addTaskChoreBtn
        ' 
        addTaskChoreBtn.Location = New Point(120, 415)
        addTaskChoreBtn.Name = "addTaskChoreBtn"
        addTaskChoreBtn.Size = New Size(203, 63)
        addTaskChoreBtn.TabIndex = 8
        addTaskChoreBtn.Text = "Add Task"
        addTaskChoreBtn.UseVisualStyleBackColor = True
        ' 
        ' ChoreTitle
        ' 
        ChoreTitle.AutoSize = True
        ChoreTitle.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        ChoreTitle.Location = New Point(136, 13)
        ChoreTitle.Name = "ChoreTitle"
        ChoreTitle.Size = New Size(160, 25)
        ChoreTitle.TabIndex = 7
        ChoreTitle.Text = "Household Tasks"
        ' 
        ' ChoreListScroll
        ' 
        ChoreListScroll.Location = New Point(412, 67)
        ChoreListScroll.Name = "ChoreListScroll"
        ChoreListScroll.Size = New Size(21, 309)
        ChoreListScroll.TabIndex = 6
        ' 
        ' ChoreListView
        ' 
        ChoreListView.Activation = ItemActivation.OneClick
        ChoreListView.Alignment = ListViewAlignment.Default
        ChoreListView.BorderStyle = BorderStyle.FixedSingle
        ChoreListView.CheckBoxes = True
        ChoreListView.Columns.AddRange(New ColumnHeader() {ColumnHeader6, ColumnHeader11, ColumnHeader7, ColumnHeader8, ColumnHeader9, ColumnHeader10})
        ChoreListView.GridLines = True
        ChoreListView.Location = New Point(38, 67)
        ChoreListView.Name = "ChoreListView"
        ChoreListView.Size = New Size(371, 309)
        ChoreListView.TabIndex = 5
        ChoreListView.UseCompatibleStateImageBehavior = False
        ChoreListView.View = View.Details
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Task"
        ColumnHeader6.Width = 65
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.DisplayIndex = 1
        ColumnHeader7.Text = "Description"
        ' 
        ' ColumnHeader8
        ' 
        ColumnHeader8.DisplayIndex = 2
        ColumnHeader8.Text = "Due Date"
        ColumnHeader8.Width = 75
        ' 
        ' ColumnHeader9
        ' 
        ColumnHeader9.DisplayIndex = 3
        ColumnHeader9.Text = "Frequency"
        ' 
        ' ColumnHeader10
        ' 
        ColumnHeader10.DisplayIndex = 4
        ColumnHeader10.Text = "Assigned To"
        ColumnHeader10.Width = 70
        ' 
        ' ChoreCompletionHistoryBtn
        ' 
        ChoreCompletionHistoryBtn.Location = New Point(8, 422)
        ChoreCompletionHistoryBtn.Name = "ChoreCompletionHistoryBtn"
        ChoreCompletionHistoryBtn.Size = New Size(106, 50)
        ChoreCompletionHistoryBtn.TabIndex = 0
        ChoreCompletionHistoryBtn.Text = "History"
        ChoreCompletionHistoryBtn.UseVisualStyleBackColor = True
        ' 
        ' Home
        ' 
        Home.Controls.Add(HouseholdBtn)
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
        ' HouseholdBtn
        ' 
        HouseholdBtn.Location = New Point(16, 444)
        HouseholdBtn.Name = "HouseholdBtn"
        HouseholdBtn.Size = New Size(86, 44)
        HouseholdBtn.TabIndex = 6
        HouseholdBtn.Text = "Show Household"
        HouseholdBtn.UseVisualStyleBackColor = True
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
        roomatesTasksHomeScreenListView.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader12})
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
        ColumnHeader2.DisplayIndex = 2
        ColumnHeader2.Text = "Description"
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.DisplayIndex = 3
        ColumnHeader3.Text = "Due Date"
        ColumnHeader3.Width = 90
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.DisplayIndex = 4
        ColumnHeader4.Text = "Frequency"
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.DisplayIndex = 5
        ColumnHeader5.Text = "Assigned To"
        ColumnHeader5.Width = 80
        ' 
        ' yourTasksHomeScreenListView
        ' 
        yourTasksHomeScreenListView.Activation = ItemActivation.OneClick
        yourTasksHomeScreenListView.Alignment = ListViewAlignment.Default
        yourTasksHomeScreenListView.Columns.AddRange(New ColumnHeader() {taskName, Effort, Description, dueDate, frequency, assignedTo})
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
        roomateTaskslbl.Font = New Font("Gadugi", 18.0F, FontStyle.Regular, GraphicsUnit.Point)
        roomateTaskslbl.Location = New Point(16, 243)
        roomateTaskslbl.Name = "roomateTaskslbl"
        roomateTaskslbl.Size = New Size(205, 28)
        roomateTaskslbl.TabIndex = 1
        roomateTaskslbl.Text = "Roomates's  Tasks"
        ' 
        ' yourTaskslbl
        ' 
        yourTaskslbl.AutoSize = True
        yourTaskslbl.Font = New Font("Gadugi", 18.0F, FontStyle.Regular, GraphicsUnit.Point)
        yourTaskslbl.Location = New Point(16, 39)
        yourTaskslbl.Name = "yourTaskslbl"
        yourTaskslbl.Size = New Size(125, 28)
        yourTaskslbl.TabIndex = 0
        yourTaskslbl.Text = "Your Tasks"
        ' 
        ' Trade
        ' 
        Trade.Controls.Add(personTradeLabel)
        Trade.Controls.Add(personComboBox)
        Trade.Controls.Add(TradeBtn)
        Trade.Controls.Add(mateTradeLabel)
        Trade.Controls.Add(taskComboBox)
        Trade.Controls.Add(selfTradeLabel)
        Trade.Controls.Add(offerComboBox)
        Trade.Location = New Point(4, 4)
        Trade.Name = "Trade"
        Trade.Size = New Size(447, 519)
        Trade.TabIndex = 3
        Trade.Text = "Trade"
        Trade.UseVisualStyleBackColor = True
        ' 
        ' personTradeLabel
        ' 
        personTradeLabel.AutoSize = True
        personTradeLabel.Location = New Point(22, 110)
        personTradeLabel.Name = "personTradeLabel"
        personTradeLabel.Size = New Size(139, 15)
        personTradeLabel.TabIndex = 6
        personTradeLabel.Text = "Roommate to Trade With"
        ' 
        ' personComboBox
        ' 
        personComboBox.FormattingEnabled = True
        personComboBox.Location = New Point(22, 148)
        personComboBox.Name = "personComboBox"
        personComboBox.Size = New Size(240, 23)
        personComboBox.TabIndex = 5
        ' 
        ' TradeBtn
        ' 
        TradeBtn.Location = New Point(22, 338)
        TradeBtn.Name = "TradeBtn"
        TradeBtn.Size = New Size(164, 60)
        TradeBtn.TabIndex = 4
        TradeBtn.Text = "Ask for Trade"
        TradeBtn.UseVisualStyleBackColor = True
        ' 
        ' mateTradeLabel
        ' 
        mateTradeLabel.AutoSize = True
        mateTradeLabel.Location = New Point(22, 208)
        mateTradeLabel.Name = "mateTradeLabel"
        mateTradeLabel.Size = New Size(105, 15)
        mateTradeLabel.TabIndex = 3
        mateTradeLabel.Text = "The Task You Want"
        ' 
        ' taskComboBox
        ' 
        taskComboBox.FormattingEnabled = True
        taskComboBox.Location = New Point(22, 246)
        taskComboBox.Name = "taskComboBox"
        taskComboBox.Size = New Size(240, 23)
        taskComboBox.TabIndex = 2
        ' 
        ' selfTradeLabel
        ' 
        selfTradeLabel.AutoSize = True
        selfTradeLabel.Location = New Point(22, 22)
        selfTradeLabel.Name = "selfTradeLabel"
        selfTradeLabel.Size = New Size(100, 15)
        selfTradeLabel.TabIndex = 1
        selfTradeLabel.Text = "Your Task to Offer"
        ' 
        ' offerComboBox
        ' 
        offerComboBox.FormattingEnabled = True
        offerComboBox.Location = New Point(22, 60)
        offerComboBox.Name = "offerComboBox"
        offerComboBox.Size = New Size(240, 23)
        offerComboBox.TabIndex = 0
        ' 
        ' ColumnHeader11
        ' 
        ColumnHeader11.DisplayIndex = 5
        ColumnHeader11.Text = "Effort"
        ColumnHeader11.Width = 40
        ' 
        ' Effort
        ' 
        Effort.Text = "Effort"
        ' 
        ' ColumnHeader12
        ' 
        ColumnHeader12.DisplayIndex = 1
        ColumnHeader12.Text = "Effort"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(464, 601)
        Controls.Add(TabControl1)
        Name = "Form1"
        Text = "Roomies"
        TabControl1.ResumeLayout(False)
        Expense.ResumeLayout(False)
        Expense.PerformLayout()
        Chore.ResumeLayout(False)
        Chore.PerformLayout()
        Home.ResumeLayout(False)
        Home.PerformLayout()
        Trade.ResumeLayout(False)
        Trade.PerformLayout()
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
    Friend WithEvents yourTotalAmount As Label
    Friend WithEvents yourTotalLabel As Label
    Friend WithEvents yourExpenseList As ListView
    Friend WithEvents yourExpenseItemColumn As ColumnHeader
    Friend WithEvents yourExpenseCostColumn As ColumnHeader
    Friend WithEvents yourExpenseLabel As Label
    Friend WithEvents ViewBalanceSheet As Button
    Friend WithEvents BalanceSheet1 As BalanceSheet
    Friend WithEvents addExpenseButton As Button
    Friend WithEvents AddExpenseForm As AddExpense
    Friend WithEvents expenseAddedSuccess As Label
    Friend WithEvents addTaskChoreBtn As Button
    Friend WithEvents ChoreTitle As Label
    Friend WithEvents ChoreListScroll As VScrollBar
    Friend WithEvents ChoreListView As ListView
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents mateTradeLabel As Label
    Friend WithEvents taskComboBox As ComboBox
    Friend WithEvents selfTradeLabel As Label
    Friend WithEvents offerComboBox As ComboBox
    Friend WithEvents TradeBtn As Button
    Friend WithEvents personTradeLabel As Label
    Friend WithEvents personComboBox As ComboBox
    Friend WithEvents ChoreCompletionHistoryBtn As Button
    Friend WithEvents ChoreHistory As ChoreHistory
    Friend WithEvents HouseholdBtn As Button
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents Effort As ColumnHeader
End Class
