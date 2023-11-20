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
        DataGridView1 = New DataGridView()
        ExpenseColumn = New DataGridViewTextBoxColumn()
        DateColumn = New DataGridViewTextBoxColumn()
        AmountColumn = New DataGridViewTextBoxColumn()
        ParticipantsColumn = New DataGridViewTextBoxColumn()
        BalanceSheetBackBtn = New PictureBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(BalanceSheetBackBtn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ExpenseColumn, DateColumn, AmountColumn, ParticipantsColumn})
        DataGridView1.Location = New Point(13, 58)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.RowTemplate.Height = 50
        DataGridView1.Size = New Size(419, 446)
        DataGridView1.TabIndex = 0
        ' 
        ' ExpenseColumn
        ' 
        ExpenseColumn.DataPropertyName = "Name"
        ExpenseColumn.HeaderText = "Expense"
        ExpenseColumn.Name = "ExpenseColumn"
        ExpenseColumn.ReadOnly = True
        ExpenseColumn.Width = 76
        ' 
        ' DateColumn
        ' 
        DateColumn.DataPropertyName = "DateAdded"
        DateColumn.HeaderText = "DateAdded"
        DateColumn.Name = "DateColumn"
        DateColumn.ReadOnly = True
        ' 
        ' AmountColumn
        ' 
        AmountColumn.DataPropertyName = "Amount"
        AmountColumn.HeaderText = "Amount"
        AmountColumn.Name = "AmountColumn"
        AmountColumn.ReadOnly = True
        AmountColumn.Width = 70
        ' 
        ' ParticipantsColumn
        ' 
        ParticipantsColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ParticipantsColumn.DataPropertyName = "ParticipantsString"
        ParticipantsColumn.HeaderText = "Participants"
        ParticipantsColumn.Name = "ParticipantsColumn"
        ParticipantsColumn.ReadOnly = True
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
        ' BalanceSheet
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(BalanceSheetBackBtn)
        Controls.Add(DataGridView1)
        Name = "BalanceSheet"
        Size = New Size(447, 519)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(BalanceSheetBackBtn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BalanceSheetBackBtn As PictureBox
    Friend WithEvents ExpenseColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountColumn As DataGridViewTextBoxColumn
    Friend WithEvents ParticipantsColumn As DataGridViewTextBoxColumn
End Class
