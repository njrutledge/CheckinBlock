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
        btnClose = New Button()
        btnStartTimer = New Button()
        lblText = New Label()
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        btnClose.Enabled = False
        btnClose.Font = New Font("Segoe UI", 24F)
        btnClose.Location = New Point(238, 164)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(189, 54)
        btnClose.TabIndex = 1
        btnClose.Text = "<--"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnStartTimer
        ' 
        btnStartTimer.Font = New Font("Segoe UI", 24F)
        btnStartTimer.Location = New Point(12, 164)
        btnStartTimer.Name = "btnStartTimer"
        btnStartTimer.Size = New Size(189, 54)
        btnStartTimer.TabIndex = 0
        btnStartTimer.Text = "Start timer"
        btnStartTimer.UseVisualStyleBackColor = True
        ' 
        ' lblText
        ' 
        lblText.Font = New Font("Segoe UI", 24F)
        lblText.Location = New Point(12, 32)
        lblText.Name = "lblText"
        lblText.Size = New Size(415, 90)
        lblText.TabIndex = 2
        lblText.Text = "Its time for your 20 second check-in!"
        lblText.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = SystemColors.Window
        ClientSize = New Size(439, 230)
        ControlBox = False
        Controls.Add(lblText)
        Controls.Add(btnClose)
        Controls.Add(btnStartTimer)
        Name = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnStartTimer As Button
    Friend WithEvents lblText As Label

End Class
