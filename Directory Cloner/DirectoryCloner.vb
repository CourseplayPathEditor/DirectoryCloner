Public Class DirectoryCloner

    Private Sub btnClone_Click(sender As Object, e As EventArgs) Handles btnClone.Click
        progressCloning.Style = ProgressBarStyle.Marquee

        Try
            Dim SourceDirectory As New IO.DirectoryInfo(txtSource.Text)
            Dim SourceFiles As IO.FileInfo() = SourceDirectory.GetFiles()

            lblStatus.Text = "Cloning file 0 of " & SourceFiles.Count.ToString

            Dim file As IO.FileInfo
            Dim count As Integer = 0

            For Each file In SourceFiles
                count += 1
                file.CopyTo(txtDestination.Text & "\" & file.Name, True)
                lblStatus.Text = "Cloning file " & count.ToString & " of " & SourceFiles.Count.ToString
            Next
        Catch ex As Exception
            MsgBox("An error occured! Check that all paths exist and you have the correct permissions to access them, then try again.", MsgBoxStyle.Critical, "Cloning Error")
        End Try


        lblStatus.Text = "Cloning complete."
        progressCloning.Style = ProgressBarStyle.Blocks
    End Sub

    Private Sub btnSourceBrowse_Click(sender As Object, e As EventArgs) Handles btnSourceBrowse.Click
        browseDirectories.ShowDialog()
        txtSource.Text = browseDirectories.SelectedPath
    End Sub

    Private Sub btnDestinationBrowse_Click(sender As Object, e As EventArgs) Handles btnDestinationBrowse.Click
        browseDirectories.ShowDialog()
        txtDestination.Text = browseDirectories.SelectedPath
    End Sub
End Class
