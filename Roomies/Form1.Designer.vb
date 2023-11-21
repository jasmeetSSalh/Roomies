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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Expense = New System.Windows.Forms.TabPage()
        Me.Chore = New System.Windows.Forms.TabPage()
        Me.addTaskChoreBtn = New System.Windows.Forms.Button()
        Me.ChoreTitle = New System.Windows.Forms.Label()
        Me.ChoreListScroll = New System.Windows.Forms.VScrollBar()
        Me.ChoreListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader()
        Me.Home = New System.Windows.Forms.TabPage()
        Me.addTaskHomeScreenBtn = New System.Windows.Forms.Button()
        Me.roomatesTasksHomeScreenListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader()
        Me.yourTasksHomeScreenListView = New System.Windows.Forms.ListView()
        Me.taskName = New System.Windows.Forms.ColumnHeader()
        Me.Description = New System.Windows.Forms.ColumnHeader()
        Me.dueDate = New System.Windows.Forms.ColumnHeader()
        Me.frequency = New System.Windows.Forms.ColumnHeader()
        Me.assignedTo = New System.Windows.Forms.ColumnHeader()
        Me.roomateTaskslbl = New System.Windows.Forms.Label()
        Me.yourTaskslbl = New System.Windows.Forms.Label()
        Me.Trade = New System.Windows.Forms.TabPage()
        Me.personTradeLabel = New System.Windows.Forms.Label()
        Me.personComboBox = New System.Windows.Forms.ComboBox()
        Me.TradeBtn = New System.Windows.Forms.Button()
        Me.mateTradeLabel = New System.Windows.Forms.Label()
        Me.taskComboBox = New System.Windows.Forms.ComboBox()
        Me.selfTradeLabel = New System.Windows.Forms.Label()
        Me.offerComboBox = New System.Windows.Forms.ComboBox()
        Me.Performance = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.Chore.SuspendLayout()
        Me.Home.SuspendLayout()
        Me.Trade.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.TabControl1.Controls.Add(Me.Expense)
        Me.TabControl1.Controls.Add(Me.Chore)
        Me.TabControl1.Controls.Add(Me.Home)
        Me.TabControl1.Controls.Add(Me.Trade)
        Me.TabControl1.Controls.Add(Me.Performance)
        Me.TabControl1.ItemSize = New System.Drawing.Size(90, 50)
        Me.TabControl1.Location = New System.Drawing.Point(10, 20)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(650, 962)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 0
        '
        'Expense
        '
        Me.Expense.Location = New System.Drawing.Point(4, 4)
        Me.Expense.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Expense.Name = "Expense"
        Me.Expense.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Expense.Size = New System.Drawing.Size(642, 904)
        Me.Expense.TabIndex = 0
        Me.Expense.Text = "Expense"
        Me.Expense.UseVisualStyleBackColor = True
        '
        'Chore
        '
        Me.Chore.Controls.Add(Me.addTaskChoreBtn)
        Me.Chore.Controls.Add(Me.ChoreTitle)
        Me.Chore.Controls.Add(Me.ChoreListScroll)
        Me.Chore.Controls.Add(Me.ChoreListView)
        Me.Chore.Location = New System.Drawing.Point(4, 4)
        Me.Chore.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Chore.Name = "Chore"
        Me.Chore.Size = New System.Drawing.Size(642, 904)
        Me.Chore.TabIndex = 2
        Me.Chore.Text = "Chore"
        Me.Chore.UseVisualStyleBackColor = True
        '
        'addTaskChoreBtn
        '
        Me.addTaskChoreBtn.Location = New System.Drawing.Point(171, 692)
        Me.addTaskChoreBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.addTaskChoreBtn.Name = "addTaskChoreBtn"
        Me.addTaskChoreBtn.Size = New System.Drawing.Size(290, 105)
        Me.addTaskChoreBtn.TabIndex = 8
        Me.addTaskChoreBtn.Text = "Add Task"
        Me.addTaskChoreBtn.UseVisualStyleBackColor = True
        '
        'ChoreTitle
        '
        Me.ChoreTitle.AutoSize = True
        Me.ChoreTitle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ChoreTitle.Location = New System.Drawing.Point(194, 22)
        Me.ChoreTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ChoreTitle.Name = "ChoreTitle"
        Me.ChoreTitle.Size = New System.Drawing.Size(246, 40)
        Me.ChoreTitle.TabIndex = 7
        Me.ChoreTitle.Text = "Household Tasks"
        '
        'ChoreListScroll
        '
        Me.ChoreListScroll.Location = New System.Drawing.Point(589, 112)
        Me.ChoreListScroll.Name = "ChoreListScroll"
        Me.ChoreListScroll.Size = New System.Drawing.Size(21, 515)
        Me.ChoreListScroll.TabIndex = 6
        '
        'ChoreListView
        '
        Me.ChoreListView.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ChoreListView.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.ChoreListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ChoreListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.ChoreListView.GridLines = True
        Me.ChoreListView.Location = New System.Drawing.Point(19, 112)
        Me.ChoreListView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChoreListView.Name = "ChoreListView"
        Me.ChoreListView.Size = New System.Drawing.Size(565, 514)
        Me.ChoreListView.TabIndex = 5
        Me.ChoreListView.UseCompatibleStateImageBehavior = False
        Me.ChoreListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Task"
        Me.ColumnHeader6.Width = 65
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Description"
        Me.ColumnHeader7.Width = 100
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Due Date"
        Me.ColumnHeader8.Width = 75
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Frequency"
        Me.ColumnHeader9.Width = 80
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Assigned To"
        Me.ColumnHeader10.Width = 80
        '
        'Home
        '
        Me.Home.Controls.Add(Me.addTaskHomeScreenBtn)
        Me.Home.Controls.Add(Me.roomatesTasksHomeScreenListView)
        Me.Home.Controls.Add(Me.yourTasksHomeScreenListView)
        Me.Home.Controls.Add(Me.roomateTaskslbl)
        Me.Home.Controls.Add(Me.yourTaskslbl)
        Me.Home.Location = New System.Drawing.Point(4, 4)
        Me.Home.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Home.Name = "Home"
        Me.Home.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Home.Size = New System.Drawing.Size(642, 904)
        Me.Home.TabIndex = 1
        Me.Home.Text = "Home"
        Me.Home.UseVisualStyleBackColor = True
        '
        'addTaskHomeScreenBtn
        '
        Me.addTaskHomeScreenBtn.Location = New System.Drawing.Point(166, 725)
        Me.addTaskHomeScreenBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.addTaskHomeScreenBtn.Name = "addTaskHomeScreenBtn"
        Me.addTaskHomeScreenBtn.Size = New System.Drawing.Size(290, 105)
        Me.addTaskHomeScreenBtn.TabIndex = 5
        Me.addTaskHomeScreenBtn.Text = "Add Task"
        Me.addTaskHomeScreenBtn.UseVisualStyleBackColor = True
        '
        'roomatesTasksHomeScreenListView
        '
        Me.roomatesTasksHomeScreenListView.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.roomatesTasksHomeScreenListView.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.roomatesTasksHomeScreenListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.roomatesTasksHomeScreenListView.GridLines = True
        Me.roomatesTasksHomeScreenListView.Location = New System.Drawing.Point(9, 473)
        Me.roomatesTasksHomeScreenListView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.roomatesTasksHomeScreenListView.Name = "roomatesTasksHomeScreenListView"
        Me.roomatesTasksHomeScreenListView.Size = New System.Drawing.Size(604, 222)
        Me.roomatesTasksHomeScreenListView.TabIndex = 4
        Me.roomatesTasksHomeScreenListView.UseCompatibleStateImageBehavior = False
        Me.roomatesTasksHomeScreenListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Task"
        Me.ColumnHeader1.Width = 70
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Description"
        Me.ColumnHeader2.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Due Date"
        Me.ColumnHeader3.Width = 90
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Frequency"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Assigned To"
        Me.ColumnHeader5.Width = 80
        '
        'yourTasksHomeScreenListView
        '
        Me.yourTasksHomeScreenListView.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.yourTasksHomeScreenListView.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.yourTasksHomeScreenListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.taskName, Me.Description, Me.dueDate, Me.frequency, Me.assignedTo})
        Me.yourTasksHomeScreenListView.GridLines = True
        Me.yourTasksHomeScreenListView.Location = New System.Drawing.Point(9, 142)
        Me.yourTasksHomeScreenListView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.yourTasksHomeScreenListView.Name = "yourTasksHomeScreenListView"
        Me.yourTasksHomeScreenListView.Size = New System.Drawing.Size(604, 222)
        Me.yourTasksHomeScreenListView.TabIndex = 3
        Me.yourTasksHomeScreenListView.UseCompatibleStateImageBehavior = False
        Me.yourTasksHomeScreenListView.View = System.Windows.Forms.View.Details
        '
        'taskName
        '
        Me.taskName.Text = "Task"
        Me.taskName.Width = 70
        '
        'Description
        '
        Me.Description.Text = "Description"
        Me.Description.Width = 120
        '
        'dueDate
        '
        Me.dueDate.Text = "Due Date"
        Me.dueDate.Width = 90
        '
        'frequency
        '
        Me.frequency.Text = "Frequency"
        '
        'assignedTo
        '
        Me.assignedTo.Text = "Assigned To"
        Me.assignedTo.Width = 80
        '
        'roomateTaskslbl
        '
        Me.roomateTaskslbl.AutoSize = True
        Me.roomateTaskslbl.Font = New System.Drawing.Font("Gadugi", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.roomateTaskslbl.Location = New System.Drawing.Point(23, 405)
        Me.roomateTaskslbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.roomateTaskslbl.Name = "roomateTaskslbl"
        Me.roomateTaskslbl.Size = New System.Drawing.Size(306, 43)
        Me.roomateTaskslbl.TabIndex = 1
        Me.roomateTaskslbl.Text = "Roomates's  Tasks"
        '
        'yourTaskslbl
        '
        Me.yourTaskslbl.AutoSize = True
        Me.yourTaskslbl.Font = New System.Drawing.Font("Gadugi", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.yourTaskslbl.Location = New System.Drawing.Point(23, 65)
        Me.yourTaskslbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.yourTaskslbl.Name = "yourTaskslbl"
        Me.yourTaskslbl.Size = New System.Drawing.Size(188, 43)
        Me.yourTaskslbl.TabIndex = 0
        Me.yourTaskslbl.Text = "Your Tasks"
        '
        'Trade
        '
        Me.Trade.Controls.Add(Me.personTradeLabel)
        Me.Trade.Controls.Add(Me.personComboBox)
        Me.Trade.Controls.Add(Me.TradeBtn)
        Me.Trade.Controls.Add(Me.mateTradeLabel)
        Me.Trade.Controls.Add(Me.taskComboBox)
        Me.Trade.Controls.Add(Me.selfTradeLabel)
        Me.Trade.Controls.Add(Me.offerComboBox)
        Me.Trade.Location = New System.Drawing.Point(4, 4)
        Me.Trade.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Trade.Name = "Trade"
        Me.Trade.Size = New System.Drawing.Size(642, 904)
        Me.Trade.TabIndex = 3
        Me.Trade.Text = "Trade"
        Me.Trade.UseVisualStyleBackColor = True
        '
        'personTradeLabel
        '
        Me.personTradeLabel.AutoSize = True
        Me.personTradeLabel.Location = New System.Drawing.Point(31, 183)
        Me.personTradeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.personTradeLabel.Name = "personTradeLabel"
        Me.personTradeLabel.Size = New System.Drawing.Size(211, 25)
        Me.personTradeLabel.TabIndex = 6
        Me.personTradeLabel.Text = "Roommate to Trade With"
        '
        'personComboBox
        '
        Me.personComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.personComboBox.FormattingEnabled = True
        Me.personComboBox.Location = New System.Drawing.Point(31, 247)
        Me.personComboBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.personComboBox.Name = "personComboBox"
        Me.personComboBox.Size = New System.Drawing.Size(341, 33)
        Me.personComboBox.TabIndex = 5
        '
        'TradeBtn
        '
        Me.TradeBtn.Location = New System.Drawing.Point(31, 563)
        Me.TradeBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TradeBtn.Name = "TradeBtn"
        Me.TradeBtn.Size = New System.Drawing.Size(234, 100)
        Me.TradeBtn.TabIndex = 4
        Me.TradeBtn.Text = "Ask for Trade"
        Me.TradeBtn.UseVisualStyleBackColor = True
        '
        'mateTradeLabel
        '
        Me.mateTradeLabel.AutoSize = True
        Me.mateTradeLabel.Location = New System.Drawing.Point(31, 347)
        Me.mateTradeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.mateTradeLabel.Name = "mateTradeLabel"
        Me.mateTradeLabel.Size = New System.Drawing.Size(158, 25)
        Me.mateTradeLabel.TabIndex = 3
        Me.mateTradeLabel.Text = "The Task You Want"
        '
        'taskComboBox
        '
        Me.taskComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.taskComboBox.FormattingEnabled = True
        Me.taskComboBox.Location = New System.Drawing.Point(31, 410)
        Me.taskComboBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.taskComboBox.Name = "taskComboBox"
        Me.taskComboBox.Size = New System.Drawing.Size(341, 33)
        Me.taskComboBox.TabIndex = 2
        '
        'selfTradeLabel
        '
        Me.selfTradeLabel.AutoSize = True
        Me.selfTradeLabel.Location = New System.Drawing.Point(31, 37)
        Me.selfTradeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.selfTradeLabel.Name = "selfTradeLabel"
        Me.selfTradeLabel.Size = New System.Drawing.Size(153, 25)
        Me.selfTradeLabel.TabIndex = 1
        Me.selfTradeLabel.Text = "Your Task to Offer"
        '
        'offerComboBox
        '
        Me.offerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.offerComboBox.FormattingEnabled = True
        Me.offerComboBox.Location = New System.Drawing.Point(31, 100)
        Me.offerComboBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.offerComboBox.Name = "offerComboBox"
        Me.offerComboBox.Size = New System.Drawing.Size(341, 33)
        Me.offerComboBox.TabIndex = 0
        '
        'Performance
        '
        Me.Performance.Location = New System.Drawing.Point(4, 4)
        Me.Performance.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Performance.Name = "Performance"
        Me.Performance.Size = New System.Drawing.Size(642, 904)
        Me.Performance.TabIndex = 4
        Me.Performance.Text = "Performance"
        Me.Performance.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 1002)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Roomies"
        Me.TabControl1.ResumeLayout(False)
        Me.Chore.ResumeLayout(False)
        Me.Chore.PerformLayout()
        Me.Home.ResumeLayout(False)
        Me.Home.PerformLayout()
        Me.Trade.ResumeLayout(False)
        Me.Trade.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents addTaskChoreBtn As Button
    Friend WithEvents ChoreTitle As Label
    Friend WithEvents ChoreListScroll As VScrollBar
    Friend WithEvents ChoreListView As ListView
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents mateTradeLabel As Label
    Friend WithEvents taskComboBox As ComboBox
    Friend WithEvents selfTradeLabel As Label
    Friend WithEvents offerComboBox As ComboBox
    Friend WithEvents TradeBtn As Button
    Friend WithEvents personTradeLabel As Label
    Friend WithEvents personComboBox As ComboBox
End Class
