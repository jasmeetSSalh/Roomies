<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChoreHistory
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
        BackBtn = New PictureBox()
        HistoryList = New ListView()
        CType(BackBtn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BackBtn
        ' 
        BackBtn.Image = My.Resources.Resources.back
        BackBtn.Location = New Point(24, 20)
        BackBtn.Name = "BackBtn"
        BackBtn.Size = New Size(48, 48)
        BackBtn.SizeMode = PictureBoxSizeMode.StretchImage
        BackBtn.TabIndex = 1
        BackBtn.TabStop = False
        ' 
        ' HistoryList
        ' 
        HistoryList.Location = New Point(24, 81)
        HistoryList.Name = "HistoryList"
        HistoryList.Size = New Size(399, 379)
        HistoryList.TabIndex = 2
        HistoryList.UseCompatibleStateImageBehavior = False
        ' 
        ' ChoreHistory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(HistoryList)
        Controls.Add(BackBtn)
        Name = "ChoreHistory"
        Size = New Size(447, 519)
        CType(BackBtn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents BackBtn As PictureBox
    Friend WithEvents HistoryList As ListView
End Class
