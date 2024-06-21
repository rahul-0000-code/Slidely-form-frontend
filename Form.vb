Public Class Form
    Private Sub btnCreateSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        Dim createForm As New CreateForm()
        createForm.Show()
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewSubmission As New ViewSubmission()
        viewSubmission.Show()
    End Sub

    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            btnViewSubmissions.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnCreateSubmission.PerformClick()
        End If
    End Sub
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub
End Class
Public Class Submission
    Public Property id As String
    Public Property name As String
    Public Property email As String
    Public Property phoneNumber As String
    Public Property githubLink As String
    Public Property stopwatchTime As String
End Class
