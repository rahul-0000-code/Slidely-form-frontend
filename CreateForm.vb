Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class CreateForm

    Private Stopwatch As New Stopwatch()

    Private Sub toggleStopWatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If Stopwatch.IsRunning Then
            Stopwatch.Stop()
        Else
            Stopwatch.Start()
            timer.Start()
        End If
        UpdateStopwatchDisplay()
    End Sub

    Private Sub UpdateStopwatchDisplay()
        txtStopwatch.Text = Stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        UpdateStopwatchDisplay()
    End Sub

    Private Sub ClearSubmissionFields()
        txtName.Text = String.Empty
        txtEmail.Text = String.Empty
        txtPhoneNo.Text = String.Empty
        txtGithubLink.Text = String.Empty
        txtStopwatch.Text = "00:00:00"
        Stopwatch.Restart()
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If Stopwatch.IsRunning Then
            Stopwatch.Stop()
        End If
        Dim submission As New Submission With {
            .name = txtName.Text,
            .email = txtEmail.Text,
            .phoneNumber = txtPhoneNo.Text,
            .githubLink = txtGithubLink.Text,
            .stopwatchTime = txtStopwatch.Text
        }
        Await SubmitFormAsync(submission)
    End Sub

    Private Async Function SubmitFormAsync(submission As Submission) As Task
        Using client As New HttpClient()
            client.BaseAddress = New Uri("http://localhost:3000")
            Dim json As String = JsonConvert.SerializeObject(submission)
            Dim content As New StringContent(json, Encoding.UTF8, "application/json")
            Dim response As HttpResponseMessage = Await client.PostAsync("/submit", content)

            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission successful!")
                ClearSubmissionFields()
                Me.Close() ' Close the form after successful submission
            Else
                ' Log detailed error information
                Dim responseContent As String = Await response.Content.ReadAsStringAsync()
                MessageBox.Show($"Submission failed. Status code: {response.StatusCode}. Response: {responseContent}")
            End If
        End Using
    End Function

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.T Then
            btnToggleStopwatch.PerformClick()
        End If
    End Sub

    Private Sub CreateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Stopwatch.Start()
        timer.Start()
    End Sub

    Private Sub CreateForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        timer.Stop()
        Stopwatch.Stop()
    End Sub
End Class
