Imports System.ComponentModel

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateForm
    Inherits System.Windows.Forms.Form

    ' Declare components
    Private components As IContainer
    Private lblName As Label
    Private lblEmail As Label
    Private lblPhoneNo As Label
    Private lblGithubLink As Label
    Private txtName As TextBox
    Private txtEmail As TextBox
    Private txtPhoneNo As TextBox
    Private txtGithubLink As TextBox
    Private btnSubmit As Button
    Private btnToggleStopwatch As Button
    Private txtStopwatch As TextBox
    Private timer As Timer
    Private Label1 As Label

    ' Constructor
    Public Sub New()
        InitializeComponent()
    End Sub

    ' Form initialization
    Private Sub InitializeComponent()
        components = New Container()
        lblName = New Label()
        lblEmail = New Label()
        lblPhoneNo = New Label()
        lblGithubLink = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhoneNo = New TextBox()
        txtGithubLink = New TextBox()
        btnSubmit = New Button()
        btnToggleStopwatch = New Button()
        txtStopwatch = New TextBox()
        timer = New Timer(components)
        Label1 = New Label()

        SuspendLayout()

        ' lblName
        lblName.AutoSize = True
        lblName.Location = New Point(145, 86)
        lblName.Size = New Size(59, 25)
        lblName.Text = "Name"

        ' lblEmail
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(150, 136)
        lblEmail.Size = New Size(54, 25)
        lblEmail.Text = "Email"

        ' lblPhoneNo
        lblPhoneNo.AutoSize = True
        lblPhoneNo.Location = New Point(118, 200)
        lblPhoneNo.Size = New Size(86, 25)
        lblPhoneNo.Text = "PhoneNo"

        ' lblGithubLink
        lblGithubLink.AutoSize = True
        lblGithubLink.Location = New Point(103, 263)
        lblGithubLink.Size = New Size(101, 25)
        lblGithubLink.Text = "Github Link"

        ' txtName
        txtName.Location = New Point(227, 80)
        txtName.Size = New Size(239, 31)

        ' txtEmail
        txtEmail.Location = New Point(227, 133)
        txtEmail.Size = New Size(239, 31)

        ' txtPhoneNo
        txtPhoneNo.Location = New Point(227, 194)
        txtPhoneNo.Size = New Size(239, 31)

        ' txtGithubLink
        txtGithubLink.Location = New Point(227, 257)
        txtGithubLink.Size = New Size(239, 31)

        ' btnSubmit
        btnSubmit.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSubmit.Location = New Point(145, 383)
        btnSubmit.Size = New Size(233, 59)
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True

        ' btnToggleStopwatch
        btnToggleStopwatch.Location = New Point(54, 316)
        btnToggleStopwatch.Size = New Size(150, 34)
        btnToggleStopwatch.Text = "Stopwatch Time"
        btnToggleStopwatch.UseVisualStyleBackColor = True

        ' txtStopwatch
        txtStopwatch.Location = New Point(227, 316)
        txtStopwatch.Size = New Size(239, 31)

        ' timer
        timer.Enabled = True
        timer.Interval = 1000

        ' Label1
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(129, 19)
        Label1.Size = New Size(263, 45)
        Label1.Text = "Add Submission"

        ' CreateForm
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(521, 470)
        Controls.Add(Label1)
        Controls.Add(txtStopwatch)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(btnSubmit)
        Controls.Add(txtGithubLink)
        Controls.Add(lblGithubLink)
        Controls.Add(txtPhoneNo)
        Controls.Add(lblPhoneNo)
        Controls.Add(txtEmail)
        Controls.Add(lblEmail)
        Controls.Add(txtName)
        Controls.Add(lblName)
        Name = "CreateForm"
        Text = "Create Submission"

        AddHandler btnSubmit.Click, AddressOf btnSubmit_Click
        AddHandler btnToggleStopwatch.Click, AddressOf btnToggleStopwatch_Click
        AddHandler KeyDown, AddressOf CreateForm_KeyDown

        ResumeLayout(False)
        PerformLayout()
    End Sub

    ' Method to handle Ctrl+S for submission and Ctrl+T for stopwatch toggle
    Private Sub CreateForm_KeyDown(sender As Object, e As KeyEventArgs)
        If e.Control AndAlso e.KeyCode = Keys.S Then
            ' Perform submission action
            SubmitForm()
        ElseIf e.Control AndAlso e.KeyCode = Keys.T Then
            ' Perform stopwatch toggle action
            ToggleStopwatch()
        End If
    End Sub

  Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
    SubmitForm()
End Sub


    ' Method to handle stopwatch toggle button click
    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs)
        ToggleStopwatch()
    End Sub

    ' Method to perform submission action
    Private Sub SubmitForm()
        ' Implement submission logic here
        ' Example: MessageBox.Show("Form submitted successfully!")
    End Sub

    ' Method to toggle stopwatch
    Private Sub ToggleStopwatch()
        ' Implement stopwatch toggle logic here
        ' Example: timer.Enabled = Not timer.Enabled
    End Sub

    ' Dispose method
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

End Class
