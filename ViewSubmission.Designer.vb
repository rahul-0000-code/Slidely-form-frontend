<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmission
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
        txtGithubLink = New TextBox()
        lblGithubLink = New Label()
        txtPhoneNo = New TextBox()
        lblPhoneNo = New Label()
        txtEmail = New TextBox()
        lblEmail = New Label()
        txtName = New TextBox()
        lblName = New Label()
        txtStopwatch = New TextBox()
        lblStopwatch = New Label()
        btnPrevious = New Button()
        btnNext = New Button()
        btnEdit = New Button()
        btnDelete = New Button()
        btnSave = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.Location = New Point(324, 370)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.ReadOnly = True
        txtGithubLink.Size = New Size(235, 31)
        txtGithubLink.TabIndex = 15
        ' 
        ' lblGithubLink
        ' 
        lblGithubLink.AutoSize = True
        lblGithubLink.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lblGithubLink.Location = New Point(200, 376)
        lblGithubLink.Name = "lblGithubLink"
        lblGithubLink.Size = New Size(108, 25)
        lblGithubLink.TabIndex = 14
        lblGithubLink.Text = "Github Link"
        ' 
        ' txtPhoneNo
        ' 
        txtPhoneNo.Location = New Point(324, 311)
        txtPhoneNo.Name = "txtPhoneNo"
        txtPhoneNo.ReadOnly = True
        txtPhoneNo.Size = New Size(235, 31)
        txtPhoneNo.TabIndex = 13
        ' 
        ' lblPhoneNo
        ' 
        lblPhoneNo.AutoSize = True
        lblPhoneNo.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lblPhoneNo.Location = New Point(215, 317)
        lblPhoneNo.Name = "lblPhoneNo"
        lblPhoneNo.Size = New Size(90, 25)
        lblPhoneNo.TabIndex = 12
        lblPhoneNo.Text = "PhoneNo"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(324, 250)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(235, 31)
        txtEmail.TabIndex = 11
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lblEmail.Location = New Point(247, 253)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(56, 25)
        lblEmail.TabIndex = 10
        lblEmail.Text = "Email"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(324, 197)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(235, 31)
        txtName.TabIndex = 9
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lblName.Location = New Point(242, 203)
        lblName.Name = "lblName"
        lblName.Size = New Size(61, 25)
        lblName.TabIndex = 8
        lblName.Text = "Name"
        ' 
        ' txtStopwatch
        ' 
        txtStopwatch.Location = New Point(324, 425)
        txtStopwatch.Name = "txtStopwatch"
        txtStopwatch.ReadOnly = True
        txtStopwatch.Size = New Size(235, 31)
        txtStopwatch.TabIndex = 17
        ' 
        ' lblStopwatch
        ' 
        lblStopwatch.AutoSize = True
        lblStopwatch.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lblStopwatch.Location = New Point(163, 431)
        lblStopwatch.Name = "lblStopwatch"
        lblStopwatch.Size = New Size(144, 25)
        lblStopwatch.TabIndex = 16
        lblStopwatch.Text = "Stopwatch Time"
        ' 
        ' btnPrevious
        ' 
        btnPrevious.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnPrevious.Location = New Point(53, 555)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(185, 56)
        btnPrevious.TabIndex = 18
        btnPrevious.Text = "Previous"
        btnPrevious.UseVisualStyleBackColor = True
        ' 
        ' btnNext
        ' 
        btnNext.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnNext.Location = New Point(519, 555)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(185, 56)
        btnNext.TabIndex = 19
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnEdit.Location = New Point(53, 119)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(155, 47)
        btnEdit.TabIndex = 20
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnDelete.Location = New Point(549, 119)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(155, 47)
        btnDelete.TabIndex = 21
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        btnSave.Location = New Point(259, 489)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(195, 47)
        btnSave.TabIndex = 22
        btnSave.Text = "Submit"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(216, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(287, 45)
        Label1.TabIndex = 23
        Label1.Text = "VIEW SUBMISSIONS"
        ' 
        ' ViewSubmission
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(756, 636)
        Controls.Add(Label1)
        Controls.Add(btnSave)
        Controls.Add(btnDelete)
        Controls.Add(btnEdit)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(txtStopwatch)
        Controls.Add(lblStopwatch)
        Controls.Add(txtGithubLink)
        Controls.Add(lblGithubLink)
        Controls.Add(txtPhoneNo)
        Controls.Add(lblPhoneNo)
        Controls.Add(txtEmail)
        Controls.Add(lblEmail)
        Controls.Add(txtName)
        Controls.Add(lblName)
        Name = "ViewSubmission"
        Text = "View Submission"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents lblGithubLink As Label
    Friend WithEvents txtPhoneNo As TextBox
    Friend WithEvents lblPhoneNo As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents txtStopwatch As TextBox
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label1 As Label
End Class
