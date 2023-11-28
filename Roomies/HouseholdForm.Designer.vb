<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HouseholdForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        DefineHouseholdBtn = New Button()
        DefineBudgetBtn = New Button()
        SuspendLayout()
        ' 
        ' DefineHouseholdBtn
        ' 
        DefineHouseholdBtn.Location = New Point(169, 266)
        DefineHouseholdBtn.Name = "DefineHouseholdBtn"
        DefineHouseholdBtn.Size = New Size(126, 23)
        DefineHouseholdBtn.TabIndex = 0
        DefineHouseholdBtn.Text = "Define Household"
        DefineHouseholdBtn.UseVisualStyleBackColor = True
        ' 
        ' DefineBudgetBtn
        ' 
        DefineBudgetBtn.Location = New Point(169, 311)
        DefineBudgetBtn.Name = "DefineBudgetBtn"
        DefineBudgetBtn.Size = New Size(126, 23)
        DefineBudgetBtn.TabIndex = 1
        DefineBudgetBtn.Text = "Define Budget"
        DefineBudgetBtn.UseVisualStyleBackColor = True
        ' 
        ' HouseholdForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(464, 601)
        Controls.Add(DefineBudgetBtn)
        Controls.Add(DefineHouseholdBtn)
        Name = "HouseholdForm"
        Text = "HouseholdForm"
        ResumeLayout(False)
    End Sub

    Friend WithEvents DefineHouseholdBtn As Button
    Friend WithEvents DefineBudgetBtn As Button
End Class
