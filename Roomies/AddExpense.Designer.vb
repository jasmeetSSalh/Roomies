<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddExpense
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
        addExpenseBackBtn = New PictureBox()
        expenseNameLabel = New Label()
        expenseAmountLabel = New Label()
        expenseNotesLabel = New Label()
        expenseNameBox = New TextBox()
        expenseAmountBox = New TextBox()
        expenseNotesBox = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        expenseAmountError = New Label()
        selectAndrew = New CheckBox()
        selectNahid = New CheckBox()
        expenseParticipantError = New Label()
        expenseNameError = New Label()
        addExpenseButton = New Button()
        CType(addExpenseBackBtn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' addExpenseBackBtn
        ' 
        addExpenseBackBtn.Image = My.Resources.Resources.back
        addExpenseBackBtn.Location = New Point(29, 54)
        addExpenseBackBtn.Margin = New Padding(5, 6, 5, 6)
        addExpenseBackBtn.Name = "addExpenseBackBtn"
        addExpenseBackBtn.Size = New Size(69, 80)
        addExpenseBackBtn.SizeMode = PictureBoxSizeMode.Zoom
        addExpenseBackBtn.TabIndex = 2
        addExpenseBackBtn.TabStop = False
        ' 
        ' expenseNameLabel
        ' 
        expenseNameLabel.AutoSize = True
        expenseNameLabel.Font = New Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point)
        expenseNameLabel.Location = New Point(68, 165)
        expenseNameLabel.Margin = New Padding(5, 0, 5, 0)
        expenseNameLabel.Name = "expenseNameLabel"
        expenseNameLabel.Size = New Size(182, 51)
        expenseNameLabel.TabIndex = 6
        expenseNameLabel.Text = "Expense:"
        ' 
        ' expenseAmountLabel
        ' 
        expenseAmountLabel.AutoSize = True
        expenseAmountLabel.Font = New Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point)
        expenseAmountLabel.Location = New Point(68, 292)
        expenseAmountLabel.Margin = New Padding(5, 0, 5, 0)
        expenseAmountLabel.Name = "expenseAmountLabel"
        expenseAmountLabel.Size = New Size(181, 51)
        expenseAmountLabel.TabIndex = 7
        expenseAmountLabel.Text = "Amount:"
        ' 
        ' expenseNotesLabel
        ' 
        expenseNotesLabel.AutoSize = True
        expenseNotesLabel.Font = New Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point)
        expenseNotesLabel.Location = New Point(68, 419)
        expenseNotesLabel.Margin = New Padding(5, 0, 5, 0)
        expenseNotesLabel.Name = "expenseNotesLabel"
        expenseNotesLabel.Size = New Size(141, 51)
        expenseNotesLabel.TabIndex = 8
        expenseNotesLabel.Text = "Notes:"
        ' 
        ' expenseNameBox
        ' 
        expenseNameBox.BorderStyle = BorderStyle.FixedSingle
        expenseNameBox.Font = New Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point)
        expenseNameBox.Location = New Point(279, 165)
        expenseNameBox.Margin = New Padding(3, 3, 3, 10)
        expenseNameBox.MaxLength = 14
        expenseNameBox.Name = "expenseNameBox"
        expenseNameBox.PlaceholderText = "(i.e. toilet paper)"
        expenseNameBox.Size = New Size(398, 63)
        expenseNameBox.TabIndex = 9
        ' 
        ' expenseAmountBox
        ' 
        expenseAmountBox.BorderStyle = BorderStyle.FixedSingle
        expenseAmountBox.Font = New Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point)
        expenseAmountBox.Location = New Point(279, 292)
        expenseAmountBox.Margin = New Padding(3, 3, 3, 10)
        expenseAmountBox.MaxLength = 14
        expenseAmountBox.Name = "expenseAmountBox"
        expenseAmountBox.PlaceholderText = "$0.00"
        expenseAmountBox.Size = New Size(398, 63)
        expenseAmountBox.TabIndex = 10
        ' 
        ' expenseNotesBox
        ' 
        expenseNotesBox.BorderStyle = BorderStyle.FixedSingle
        expenseNotesBox.Font = New Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point)
        expenseNotesBox.Location = New Point(279, 419)
        expenseNotesBox.Margin = New Padding(3, 3, 3, 10)
        expenseNotesBox.MaxLength = 14
        expenseNotesBox.Name = "expenseNotesBox"
        expenseNotesBox.PlaceholderText = "(i.e. 3 ply !!)"
        expenseNotesBox.Size = New Size(398, 63)
        expenseNotesBox.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(68, 574)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(367, 51)
        Label1.TabIndex = 12
        Label1.Text = "Select Participants:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Gadugi", 9.857143F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(74, 625)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(599, 28)
        Label2.TabIndex = 13
        Label2.Text = "Selecting more than one will split the expense EVENLY."
        ' 
        ' expenseAmountError
        ' 
        expenseAmountError.AutoSize = True
        expenseAmountError.Font = New Font("Gadugi", 9.857143F, FontStyle.Regular, GraphicsUnit.Point)
        expenseAmountError.ForeColor = Color.Red
        expenseAmountError.Location = New Point(78, 360)
        expenseAmountError.Margin = New Padding(5, 0, 5, 0)
        expenseAmountError.Name = "expenseAmountError"
        expenseAmountError.Size = New Size(535, 28)
        expenseAmountError.TabIndex = 16
        expenseAmountError.Text = "The amount entered must be greater than $0.00!"
        expenseAmountError.Visible = False
        ' 
        ' selectAndrew
        ' 
        selectAndrew.AutoSize = True
        selectAndrew.Font = New Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point)
        selectAndrew.Location = New Point(78, 666)
        selectAndrew.Name = "selectAndrew"
        selectAndrew.Size = New Size(136, 37)
        selectAndrew.TabIndex = 17
        selectAndrew.Text = "Andrew"
        selectAndrew.UseVisualStyleBackColor = True
        ' 
        ' selectNahid
        ' 
        selectNahid.AutoSize = True
        selectNahid.Font = New Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point)
        selectNahid.Location = New Point(78, 709)
        selectNahid.Name = "selectNahid"
        selectNahid.Size = New Size(115, 37)
        selectNahid.TabIndex = 18
        selectNahid.Text = "Nahid"
        selectNahid.UseVisualStyleBackColor = True
        ' 
        ' expenseParticipantError
        ' 
        expenseParticipantError.AutoSize = True
        expenseParticipantError.Font = New Font("Gadugi", 9.857143F, FontStyle.Regular, GraphicsUnit.Point)
        expenseParticipantError.ForeColor = Color.Red
        expenseParticipantError.Location = New Point(78, 759)
        expenseParticipantError.Margin = New Padding(5, 0, 5, 0)
        expenseParticipantError.Name = "expenseParticipantError"
        expenseParticipantError.Size = New Size(474, 28)
        expenseParticipantError.TabIndex = 19
        expenseParticipantError.Text = "At least ONE participant has to be selected!"
        expenseParticipantError.Visible = False
        ' 
        ' expenseNameError
        ' 
        expenseNameError.AutoSize = True
        expenseNameError.Font = New Font("Gadugi", 9.857143F, FontStyle.Regular, GraphicsUnit.Point)
        expenseNameError.ForeColor = Color.Red
        expenseNameError.Location = New Point(68, 233)
        expenseNameError.Margin = New Padding(5, 0, 5, 0)
        expenseNameError.Name = "expenseNameError"
        expenseNameError.Size = New Size(459, 28)
        expenseNameError.TabIndex = 20
        expenseNameError.Text = "A name must be entered for the expense!"
        expenseNameError.Visible = False
        ' 
        ' addExpenseButton
        ' 
        addExpenseButton.Font = New Font("Gadugi", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point)
        addExpenseButton.Location = New Point(200, 847)
        addExpenseButton.Margin = New Padding(5, 6, 5, 6)
        addExpenseButton.Name = "addExpenseButton"
        addExpenseButton.Padding = New Padding(3)
        addExpenseButton.Size = New Size(367, 84)
        addExpenseButton.TabIndex = 21
        addExpenseButton.Text = "Add Expense"
        addExpenseButton.UseVisualStyleBackColor = True
        ' 
        ' AddExpense
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(addExpenseButton)
        Controls.Add(expenseNameError)
        Controls.Add(expenseParticipantError)
        Controls.Add(selectNahid)
        Controls.Add(selectAndrew)
        Controls.Add(expenseAmountError)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(expenseNotesBox)
        Controls.Add(expenseAmountBox)
        Controls.Add(expenseNameBox)
        Controls.Add(expenseNotesLabel)
        Controls.Add(expenseAmountLabel)
        Controls.Add(expenseNameLabel)
        Controls.Add(addExpenseBackBtn)
        Margin = New Padding(5, 6, 5, 6)
        Name = "AddExpense"
        Size = New Size(766, 1038)
        CType(addExpenseBackBtn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents addExpenseBackBtn As PictureBox
    Friend WithEvents expenseNameLabel As Label
    Friend WithEvents expenseAmountLabel As Label
    Friend WithEvents expenseNotesLabel As Label
    Friend WithEvents expenseNameBox As TextBox
    Friend WithEvents expenseAmountBox As TextBox
    Friend WithEvents expenseNotesBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents expenseAmountError As Label
    Friend WithEvents selectAndrew As CheckBox
    Friend WithEvents selectNahid As CheckBox
    Friend WithEvents expenseParticipantError As Label
    Friend WithEvents expenseNameError As Label
    Friend WithEvents addExpenseButton As Button

End Class
