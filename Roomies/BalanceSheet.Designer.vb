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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DataGridView1 = New DataGridView()
        BalanceSheetBackBtn = New PictureBox()
        householdTotalAmount = New Label()
        householdTotalLabel = New Label()
        ExpenseColumn = New DataGridViewTextBoxColumn()
        AmountColumn = New DataGridViewTextBoxColumn()
        DateColumn = New DataGridViewTextBoxColumn()
        Notes = New DataGridViewTextBoxColumn()
        ParticipantsColumn = New DataGridViewTextBoxColumn()
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
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.Location = New Point(3, 58)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 72
        DataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.RowTemplate.Height = 50
        DataGridView1.Size = New Size(441, 332)
        DataGridView1.TabIndex = 0
        ' 
        ' BalanceSheetBackBtn
        ' 
        BalanceSheetBackBtn.Image = My.Resources.Resources.back
        BalanceSheetBackBtn.Location = New Point(13, 12)
        BalanceSheetBackBtn.Name = "BalanceSheetBackBtn"
        BalanceSheetBackBtn.Size = New Size(40, 40)
        BalanceSheetBackBtn.SizeMode = PictureBoxSizeMode.Zoom
        BalanceSheetBackBtn.TabIndex = 1
        BalanceSheetBackBtn.TabStop = False
        ' 
        ' householdTotalAmount
        ' 
        householdTotalAmount.AutoSize = True
        householdTotalAmount.Font = New Font("Gadugi", 18.0F, FontStyle.Regular, GraphicsUnit.Point)
        householdTotalAmount.Location = New Point(216, 400)
        householdTotalAmount.Name = "householdTotalAmount"
        householdTotalAmount.Size = New Size(69, 28)
        householdTotalAmount.TabIndex = 9
        householdTotalAmount.Text = "$0.00"
        ' 
        ' householdTotalLabel
        ' 
        householdTotalLabel.AutoSize = True
        householdTotalLabel.Font = New Font("Gadugi", 18.0F, FontStyle.Regular, GraphicsUnit.Point)
        householdTotalLabel.Location = New Point(13, 400)
        householdTotalLabel.Name = "householdTotalLabel"
        householdTotalLabel.Size = New Size(193, 28)
        householdTotalLabel.TabIndex = 8
        householdTotalLabel.Text = "Household Total:"
        ' 
        ' ExpenseColumn
        ' 
        ExpenseColumn.DataPropertyName = "Name"
        ExpenseColumn.HeaderText = "Expense"
        ExpenseColumn.MinimumWidth = 9
        ExpenseColumn.Name = "ExpenseColumn"
        ExpenseColumn.ReadOnly = True
        ExpenseColumn.Width = 90
        ' 
        ' AmountColumn
        ' 
        AmountColumn.DataPropertyName = "Amount"
        AmountColumn.HeaderText = "Amount ($)"
        AmountColumn.MinimumWidth = 9
        AmountColumn.Name = "AmountColumn"
        AmountColumn.ReadOnly = True
        AmountColumn.Width = 65
        ' 
        ' DateColumn
        ' 
        DateColumn.DataPropertyName = "DateAdded"
        DateColumn.HeaderText = "DateAdded"
        DateColumn.MinimumWidth = 9
        DateColumn.Name = "DateColumn"
        DateColumn.ReadOnly = True
        ' 
        ' Notes
        ' 
        Notes.DataPropertyName = "Notes"
        Notes.HeaderText = "Notes"
        Notes.MinimumWidth = 9
        Notes.Name = "Notes"
        Notes.ReadOnly = True
        Notes.Width = 80
        ' 
        ' ParticipantsColumn
        ' 
        ParticipantsColumn.DataPropertyName = "ParticipantsString"
        ParticipantsColumn.HeaderText = "Participants"
        ParticipantsColumn.MinimumWidth = 9
        ParticipantsColumn.Name = "ParticipantsColumn"
        ParticipantsColumn.ReadOnly = True
        ' 
        ' BalanceSheet
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(householdTotalAmount)
        Controls.Add(householdTotalLabel)
        Controls.Add(BalanceSheetBackBtn)
        Controls.Add(DataGridView1)
        Name = "BalanceSheet"
        Size = New Size(447, 519)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(BalanceSheetBackBtn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BalanceSheetBackBtn As PictureBox
    Friend WithEvents householdTotalAmount As Label
    Friend WithEvents householdTotalLabel As Label
    Friend WithEvents ExpenseColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateColumn As DataGridViewTextBoxColumn
    Friend WithEvents Notes As DataGridViewTextBoxColumn
    Friend WithEvents ParticipantsColumn As DataGridViewTextBoxColumn
End Class
