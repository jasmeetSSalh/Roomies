<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BalanceSheet
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DataGridView1 = New DataGridView()
        ExpenseColumn = New DataGridViewTextBoxColumn()
        AmountColumn = New DataGridViewTextBoxColumn()
        DateColumn = New DataGridViewTextBoxColumn()
        Notes = New DataGridViewTextBoxColumn()
        ParticipantsColumn = New DataGridViewTextBoxColumn()
        BalanceSheetBackBtn = New PictureBox()
        householdTotalAmount = New Label()
        householdTotalLabel = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(BalanceSheetBackBtn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.ColumnHeadersHeight = 40
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ExpenseColumn, AmountColumn, DateColumn, Notes, ParticipantsColumn})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Window
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.Location = New Point(22, 116)
        DataGridView1.Margin = New Padding(5, 6, 5, 6)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 72
        DataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridView1.RowTemplate.Height = 50
        DataGridView1.Size = New Size(718, 663)
        DataGridView1.TabIndex = 0
        ' 
        ' ExpenseColumn
        ' 
        ExpenseColumn.DataPropertyName = "Name"
        ExpenseColumn.HeaderText = "Expense"
        ExpenseColumn.MinimumWidth = 9
        ExpenseColumn.Name = "ExpenseColumn"
        ExpenseColumn.ReadOnly = True
        ExpenseColumn.Width = 150
        ' 
        ' AmountColumn
        ' 
        AmountColumn.DataPropertyName = "Amount"
        AmountColumn.HeaderText = "Amount ($)"
        AmountColumn.MinimumWidth = 9
        AmountColumn.Name = "AmountColumn"
        AmountColumn.ReadOnly = True
        AmountColumn.Width = 130
        ' 
        ' DateColumn
        ' 
        DateColumn.DataPropertyName = "DateAdded"
        DateColumn.HeaderText = "DateAdded"
        DateColumn.MinimumWidth = 9
        DateColumn.Name = "DateColumn"
        DateColumn.ReadOnly = True
        DateColumn.Width = 175
        ' 
        ' Notes
        ' 
        Notes.DataPropertyName = "Notes"
        Notes.HeaderText = "Notes"
        Notes.MinimumWidth = 9
        Notes.Name = "Notes"
        Notes.ReadOnly = True
        Notes.Width = 130
        ' 
        ' ParticipantsColumn
        ' 
        ParticipantsColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ParticipantsColumn.DataPropertyName = "ParticipantsString"
        ParticipantsColumn.HeaderText = "Participants"
        ParticipantsColumn.MinimumWidth = 9
        ParticipantsColumn.Name = "ParticipantsColumn"
        ParticipantsColumn.ReadOnly = True
        ' 
        ' BalanceSheetBackBtn
        ' 
        BalanceSheetBackBtn.Image = My.Resources.Resources.back
        BalanceSheetBackBtn.Location = New Point(22, 24)
        BalanceSheetBackBtn.Margin = New Padding(5, 6, 5, 6)
        BalanceSheetBackBtn.Name = "BalanceSheetBackBtn"
        BalanceSheetBackBtn.Size = New Size(69, 80)
        BalanceSheetBackBtn.SizeMode = PictureBoxSizeMode.Zoom
        BalanceSheetBackBtn.TabIndex = 1
        BalanceSheetBackBtn.TabStop = False
        ' 
        ' householdTotalAmount
        ' 
        householdTotalAmount.AutoSize = True
        householdTotalAmount.Font = New Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point)
        householdTotalAmount.Location = New Point(370, 799)
        householdTotalAmount.Margin = New Padding(5, 0, 5, 0)
        householdTotalAmount.Name = "householdTotalAmount"
        householdTotalAmount.Size = New Size(123, 51)
        householdTotalAmount.TabIndex = 9
        householdTotalAmount.Text = "$0.00"
        ' 
        ' householdTotalLabel
        ' 
        householdTotalLabel.AutoSize = True
        householdTotalLabel.Font = New Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point)
        householdTotalLabel.Location = New Point(22, 799)
        householdTotalLabel.Margin = New Padding(5, 0, 5, 0)
        householdTotalLabel.Name = "householdTotalLabel"
        householdTotalLabel.Size = New Size(338, 51)
        householdTotalLabel.TabIndex = 8
        householdTotalLabel.Text = "Household Total:"
        ' 
        ' BalanceSheet
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(householdTotalAmount)
        Controls.Add(householdTotalLabel)
        Controls.Add(BalanceSheetBackBtn)
        Controls.Add(DataGridView1)
        Margin = New Padding(5, 6, 5, 6)
        Name = "BalanceSheet"
        Size = New Size(766, 1038)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(BalanceSheetBackBtn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BalanceSheetBackBtn As PictureBox
    Friend WithEvents ExpenseColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateColumn As DataGridViewTextBoxColumn
    Friend WithEvents Notes As DataGridViewTextBoxColumn
    Friend WithEvents ParticipantsColumn As DataGridViewTextBoxColumn
    Friend WithEvents householdTotalAmount As Label
    Friend WithEvents householdTotalLabel As Label
End Class
