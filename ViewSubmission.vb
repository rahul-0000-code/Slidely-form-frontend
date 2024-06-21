Imports System.Net.Http
Imports Newtonsoft.Json
Imports System.Text

Public Class ViewSubmission
    Private list As List(Of String)
    Private submission As Submission
    Private index As Integer = 0

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Async Sub ViewSubmission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Await LoadSubmissionsListAsync()
        If list IsNot Nothing AndAlso list.Count > 0 Then
            Await LoadSubmissionAsync(index)
        Else
            MessageBox.Show("No submissions available to display.")
        End If
    End Sub

    Private Async Function LoadSubmissionsListAsync() As Task
        Using client As New HttpClient()
            client.BaseAddress = New Uri("http://localhost:3000")
            Dim response As HttpResponseMessage = Await client.GetAsync("/list")
            If response.IsSuccessStatusCode Then
                Dim json As String = Await response.Content.ReadAsStringAsync()
                list = JsonConvert.DeserializeObject(Of List(Of String))(json)
            Else
                MessageBox.Show("Failed to load submissions.")
            End If
        End Using
    End Function


    Private Async Function LoadSubmissionAsync(index As Integer) As Task
        Using client As New HttpClient()
            client.BaseAddress = New Uri("http://localhost:3000")
            Dim response As HttpResponseMessage = Await client.GetAsync($"/read/{list(index)}")

            Try
                Dim json As String = Await response.Content.ReadAsStringAsync()
                submission = JsonConvert.DeserializeObject(Of Submission)(json)
                ShowSubmission()
            Catch ex As Exception
                MessageBox.Show("Failed to parse submission data.")
            End Try
        End Using
    End Function


    Private Sub ShowSubmission()
        If submission IsNot Nothing Then
            txtName.Text = submission.name
            txtEmail.Text = submission.email
            txtPhoneNo.Text = submission.phoneNumber
            txtGithubLink.Text = submission.githubLink
            txtStopwatch.Text = submission.stopwatchTime
            SetReadOnlyFields(True)
        End If
    End Sub

    Private Sub SetReadOnlyFields(isReadOnly As Boolean)
        txtName.ReadOnly = isReadOnly
        txtEmail.ReadOnly = isReadOnly
        txtPhoneNo.ReadOnly = isReadOnly
        txtGithubLink.ReadOnly = isReadOnly
        txtStopwatch.ReadOnly = isReadOnly
        btnSave.Visible = Not isReadOnly
    End Sub

    Private Async Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If index > 0 Then
            index -= 1
            Await LoadSubmissionAsync(index)
        End If
    End Sub

    Private Async Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If index < list.Count - 1 Then
            index += 1
            Await LoadSubmissionAsync(index)
        End If
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        End If
    End Sub

    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If submission IsNot Nothing Then
            Using client As New HttpClient()
                client.BaseAddress = New Uri("http://localhost:3000")
                Dim response As HttpResponseMessage = Await client.DeleteAsync($"/submission/{submission.id}")
                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Submission deleted successfully.")
                    Await LoadSubmissionsListAsync()
                    If list.Count > 0 Then
                        index = Math.Min(index, list.Count - 1)
                        Await LoadSubmissionAsync(index)
                    Else
                        ClearSubmissionFields()
                    End If
                Else
                    MessageBox.Show("Failed to delete submission.")
                End If
            End Using
        End If
    End Sub

    Private Sub ClearSubmissionFields()
        txtName.Text = String.Empty
        txtEmail.Text = String.Empty
        txtPhoneNo.Text = String.Empty
        txtGithubLink.Text = String.Empty
        txtStopwatch.Text = String.Empty
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        SetReadOnlyFields(False)
    End Sub

    Private Async Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        submission.Name = txtName.Text
        submission.Email = txtEmail.Text
        submission.PhoneNumber = txtPhoneNo.Text
        submission.GithubLink = txtGithubLink.Text
        submission.StopwatchTime = txtStopwatch.Text

        Using client As New HttpClient()
            client.BaseAddress = New Uri("http://localhost:3000")
            Dim json As String = JsonConvert.SerializeObject(submission)
            Dim content As New StringContent(json, Encoding.UTF8, "application/json")
            Dim response As HttpResponseMessage = Await client.PutAsync($"/submission/{submission.id}", content)
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission updated successfully.")
                Await LoadSubmissionsListAsync()
                Await LoadSubmissionAsync(index)
            Else
                MessageBox.Show("Failed to update submission.")
            End If
        End Using
    End Sub
End Class
