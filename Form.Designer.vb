<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form
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
        btnViewSubmissions = New Button()
        btnCreateSubmission = New Button()
        SuspendLayout()
        ' 
        ' btnViewSubmissions
        ' 
        btnViewSubmissions.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewSubmissions.Location = New Point(232, 109)
        btnViewSubmissions.Name = "btnViewSubmissions"
        btnViewSubmissions.Size = New Size(332, 74)
        btnViewSubmissions.TabIndex = 0
        btnViewSubmissions.Text = "View Submission"
        btnViewSubmissions.UseVisualStyleBackColor = True
        ' 
        ' btnCreateSubmission
        ' 
        btnCreateSubmission.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCreateSubmission.Location = New Point(232, 227)
        btnCreateSubmission.Name = "btnCreateSubmission"
        btnCreateSubmission.Size = New Size(332, 74)
        btnCreateSubmission.TabIndex = 1
        btnCreateSubmission.Text = "Create New Submission"
        btnCreateSubmission.UseVisualStyleBackColor = True
        ' 
        ' Form
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnCreateSubmission)
        Controls.Add(btnViewSubmissions)
        Name = "Form"
        Text = "Slidely Form Task Frontend"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents btnCreateSubmission As Button

End Class
