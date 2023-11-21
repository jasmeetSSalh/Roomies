<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChoreCreationForm
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
        nameOfTasklbl = New Label()
        descriptionlbl = New Label()
        datelbl = New Label()
        exceptionslbl = New Label()
        preferenceSelectionlbl = New Label()
        nameOfTaskTextbox = New TextBox()
        descriptionTextbox = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        Label6 = New Label()
        frequencyComboBox = New ComboBox()
        ComboBox1 = New ComboBox()
        cancelbtn = New Button()
        okbtn = New Button()
        voluteerRadiobtn = New RadioButton()
        SuspendLayout()
        ' 
        ' nameOfTasklbl
        ' 
        nameOfTasklbl.AutoSize = True
        nameOfTasklbl.Font = New Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point)
        nameOfTasklbl.Location = New Point(32, 42)
        nameOfTasklbl.Name = "nameOfTasklbl"
        nameOfTasklbl.Size = New Size(104, 19)
        nameOfTasklbl.TabIndex = 0
        nameOfTasklbl.Text = "Name of Task"
        ' 
        ' descriptionlbl
        ' 
        descriptionlbl.AutoSize = True
        descriptionlbl.Font = New Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point)
        descriptionlbl.Location = New Point(32, 94)
        descriptionlbl.Name = "descriptionlbl"
        descriptionlbl.Size = New Size(88, 19)
        descriptionlbl.TabIndex = 1
        descriptionlbl.Text = "Description"
        ' 
        ' datelbl
        ' 
        datelbl.AutoSize = True
        datelbl.Font = New Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point)
        datelbl.Location = New Point(32, 213)
        datelbl.Name = "datelbl"
        datelbl.Size = New Size(41, 19)
        datelbl.TabIndex = 2
        datelbl.Text = "Date"
        ' 
        ' exceptionslbl
        ' 
        exceptionslbl.AutoSize = True
        exceptionslbl.Font = New Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point)
        exceptionslbl.Location = New Point(32, 312)
        exceptionslbl.Name = "exceptionslbl"
        exceptionslbl.Size = New Size(82, 19)
        exceptionslbl.TabIndex = 3
        exceptionslbl.Text = "Exceptions"
        ' 
        ' preferenceSelectionlbl
        ' 
        preferenceSelectionlbl.AutoSize = True
        preferenceSelectionlbl.Font = New Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point)
        preferenceSelectionlbl.Location = New Point(32, 425)
        preferenceSelectionlbl.Name = "preferenceSelectionlbl"
        preferenceSelectionlbl.Size = New Size(128, 19)
        preferenceSelectionlbl.TabIndex = 4
        preferenceSelectionlbl.Text = "Select Preference"
        ' 
        ' nameOfTaskTextbox
        ' 
        nameOfTaskTextbox.Font = New Font("Gadugi", 14F, FontStyle.Regular, GraphicsUnit.Point)
        nameOfTaskTextbox.Location = New Point(157, 36)
        nameOfTaskTextbox.Name = "nameOfTaskTextbox"
        nameOfTaskTextbox.Size = New Size(261, 32)
        nameOfTaskTextbox.TabIndex = 5
        ' 
        ' descriptionTextbox
        ' 
        descriptionTextbox.Font = New Font("Gadugi", 14F, FontStyle.Regular, GraphicsUnit.Point)
        descriptionTextbox.Location = New Point(157, 94)
        descriptionTextbox.Multiline = True
        descriptionTextbox.Name = "descriptionTextbox"
        descriptionTextbox.Size = New Size(261, 79)
        descriptionTextbox.TabIndex = 6
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(32, 252)
        DateTimePicker1.MinDate = New Date(2023, 11, 14, 0, 0, 0, 0)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(141, 23)
        DateTimePicker1.TabIndex = 7
        DateTimePicker1.Value = New Date(2023, 11, 14, 17, 19, 42, 0)
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(233, 213)
        Label6.Name = "Label6"
        Label6.Size = New Size(81, 19)
        Label6.TabIndex = 8
        Label6.Text = "Frequency"
        ' 
        ' frequencyComboBox
        ' 
        frequencyComboBox.FormattingEnabled = True
        frequencyComboBox.Items.AddRange(New Object() {"None", "Daily", "Weekly", "Monthly", ""})
        frequencyComboBox.Location = New Point(233, 252)
        frequencyComboBox.Name = "frequencyComboBox"
        frequencyComboBox.Size = New Size(121, 23)
        frequencyComboBox.TabIndex = 9
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Andrew", "Nahid"})
        ComboBox1.Location = New Point(68, 349)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(334, 45)
        ComboBox1.TabIndex = 10
        ' 
        ' cancelbtn
        ' 
        cancelbtn.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cancelbtn.Location = New Point(90, 531)
        cancelbtn.Name = "cancelbtn"
        cancelbtn.Size = New Size(92, 32)
        cancelbtn.TabIndex = 11
        cancelbtn.Text = "Cancel"
        cancelbtn.UseVisualStyleBackColor = True
        ' 
        ' okbtn
        ' 
        okbtn.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        okbtn.Location = New Point(294, 531)
        okbtn.Name = "okbtn"
        okbtn.Size = New Size(92, 32)
        okbtn.TabIndex = 12
        okbtn.Text = "OK"
        okbtn.UseVisualStyleBackColor = True
        ' 
        ' voluteerRadiobtn
        ' 
        voluteerRadiobtn.AutoSize = True
        voluteerRadiobtn.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        voluteerRadiobtn.Location = New Point(68, 466)
        voluteerRadiobtn.Name = "voluteerRadiobtn"
        voluteerRadiobtn.Size = New Size(155, 25)
        voluteerRadiobtn.TabIndex = 14
        voluteerRadiobtn.TabStop = True
        voluteerRadiobtn.Text = "Volunteer For Task"
        voluteerRadiobtn.UseVisualStyleBackColor = True
        ' 
        ' ChoreCreationForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(464, 601)
        Controls.Add(voluteerRadiobtn)
        Controls.Add(okbtn)
        Controls.Add(cancelbtn)
        Controls.Add(ComboBox1)
        Controls.Add(frequencyComboBox)
        Controls.Add(Label6)
        Controls.Add(DateTimePicker1)
        Controls.Add(descriptionTextbox)
        Controls.Add(nameOfTaskTextbox)
        Controls.Add(preferenceSelectionlbl)
        Controls.Add(exceptionslbl)
        Controls.Add(datelbl)
        Controls.Add(descriptionlbl)
        Controls.Add(nameOfTasklbl)
        Name = "ChoreCreationForm"
        Text = "ChoreCreationForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents nameOfTasklbl As Label
    Friend WithEvents descriptionlbl As Label
    Friend WithEvents datelbl As Label
    Friend WithEvents exceptionslbl As Label
    Friend WithEvents preferenceSelectionlbl As Label
    Friend WithEvents nameOfTaskTextbox As TextBox
    Friend WithEvents descriptionTextbox As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents frequencyComboBox As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents cancelbtn As Button
    Friend WithEvents okbtn As Button
    Friend WithEvents voluteerRadiobtn As RadioButton
End Class
