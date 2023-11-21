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
        TabControl1 = New TabControl()
        Expense = New TabPage()
        Chore = New TabPage()
        CheckBox13 = New CheckBox()
        CheckBox12 = New CheckBox()
        CheckBox11 = New CheckBox()
        CheckBox10 = New CheckBox()
        CheckBox9 = New CheckBox()
        CheckBox8 = New CheckBox()
        CheckBox7 = New CheckBox()
        CheckBox6 = New CheckBox()
        CheckBox5 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
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
        TabControl1.SuspendLayout()
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
        Chore.Controls.Add(CheckBox13)
        Chore.Controls.Add(CheckBox12)
        Chore.Controls.Add(CheckBox11)
        Chore.Controls.Add(CheckBox10)
        Chore.Controls.Add(CheckBox9)
        Chore.Controls.Add(CheckBox8)
        Chore.Controls.Add(CheckBox7)
        Chore.Controls.Add(CheckBox6)
        Chore.Controls.Add(CheckBox5)
        Chore.Controls.Add(CheckBox4)
        Chore.Controls.Add(CheckBox3)
        Chore.Controls.Add(CheckBox2)
        Chore.Controls.Add(CheckBox1)
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
        ' CheckBox13
        ' 
        CheckBox13.AutoSize = True
        CheckBox13.Checked = True
        CheckBox13.CheckState = CheckState.Indeterminate
        CheckBox13.Location = New Point(17, 321)
        CheckBox13.Name = "CheckBox13"
        CheckBox13.Size = New Size(15, 14)
        CheckBox13.TabIndex = 21
        CheckBox13.UseVisualStyleBackColor = True
        ' 
        ' CheckBox12
        ' 
        CheckBox12.AutoSize = True
        CheckBox12.Checked = True
        CheckBox12.CheckState = CheckState.Indeterminate
        CheckBox12.Location = New Point(17, 304)
        CheckBox12.Name = "CheckBox12"
        CheckBox12.Size = New Size(15, 14)
        CheckBox12.TabIndex = 20
        CheckBox12.UseVisualStyleBackColor = True
        ' 
        ' CheckBox11
        ' 
        CheckBox11.AutoSize = True
        CheckBox11.Checked = True
        CheckBox11.CheckState = CheckState.Indeterminate
        CheckBox11.Location = New Point(17, 285)
        CheckBox11.Name = "CheckBox11"
        CheckBox11.Size = New Size(15, 14)
        CheckBox11.TabIndex = 19
        CheckBox11.UseVisualStyleBackColor = True
        ' 
        ' CheckBox10
        ' 
        CheckBox10.AutoSize = True
        CheckBox10.Checked = True
        CheckBox10.CheckState = CheckState.Indeterminate
        CheckBox10.Location = New Point(16, 265)
        CheckBox10.Name = "CheckBox10"
        CheckBox10.Size = New Size(15, 14)
        CheckBox10.TabIndex = 18
        CheckBox10.UseVisualStyleBackColor = True
        ' 
        ' CheckBox9
        ' 
        CheckBox9.AutoSize = True
        CheckBox9.Checked = True
        CheckBox9.CheckState = CheckState.Indeterminate
        CheckBox9.Location = New Point(16, 246)
        CheckBox9.Name = "CheckBox9"
        CheckBox9.Size = New Size(15, 14)
        CheckBox9.TabIndex = 17
        CheckBox9.UseVisualStyleBackColor = True
        ' 
        ' CheckBox8
        ' 
        CheckBox8.AutoSize = True
        CheckBox8.Checked = True
        CheckBox8.CheckState = CheckState.Indeterminate
        CheckBox8.Location = New Point(16, 228)
        CheckBox8.Name = "CheckBox8"
        CheckBox8.Size = New Size(15, 14)
        CheckBox8.TabIndex = 16
        CheckBox8.UseVisualStyleBackColor = True
        ' 
        ' CheckBox7
        ' 
        CheckBox7.AutoSize = True
        CheckBox7.Checked = True
        CheckBox7.CheckState = CheckState.Indeterminate
        CheckBox7.Location = New Point(16, 209)
        CheckBox7.Name = "CheckBox7"
        CheckBox7.Size = New Size(15, 14)
        CheckBox7.TabIndex = 15
        CheckBox7.UseVisualStyleBackColor = True
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Checked = True
        CheckBox6.CheckState = CheckState.Indeterminate
        CheckBox6.Location = New Point(16, 189)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(15, 14)
        CheckBox6.TabIndex = 14
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Checked = True
        CheckBox5.CheckState = CheckState.Indeterminate
        CheckBox5.Location = New Point(16, 169)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(15, 14)
        CheckBox5.TabIndex = 13
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Checked = True
        CheckBox4.CheckState = CheckState.Indeterminate
        CheckBox4.Location = New Point(16, 152)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(15, 14)
        CheckBox4.TabIndex = 12
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Checked = True
        CheckBox3.CheckState = CheckState.Indeterminate
        CheckBox3.Location = New Point(16, 132)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(15, 14)
        CheckBox3.TabIndex = 11
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Checked = True
        CheckBox2.CheckState = CheckState.Indeterminate
        CheckBox2.Location = New Point(16, 112)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(15, 14)
        CheckBox2.TabIndex = 10
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Checked = True
        CheckBox1.CheckState = CheckState.Indeterminate
        CheckBox1.Location = New Point(17, 93)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(15, 14)
        CheckBox1.TabIndex = 9
        CheckBox1.UseVisualStyleBackColor = True
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
        ChoreListView.Columns.AddRange(New ColumnHeader() {ColumnHeader6, ColumnHeader7, ColumnHeader8, ColumnHeader9, ColumnHeader10})
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
        ColumnHeader7.Text = "Description"
        ColumnHeader7.Width = 100
        ' 
        ' ColumnHeader8
        ' 
        ColumnHeader8.Text = "Due Date"
        ColumnHeader8.Width = 75
        ' 
        ' ColumnHeader9
        ' 
        ColumnHeader9.Text = "Frequency"
        ' 
        ' ColumnHeader10
        ' 
        ColumnHeader10.Text = "Assigned To"
        ColumnHeader10.Width = 80
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
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox12 As CheckBox
    Friend WithEvents CheckBox11 As CheckBox
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox13 As CheckBox
End Class
