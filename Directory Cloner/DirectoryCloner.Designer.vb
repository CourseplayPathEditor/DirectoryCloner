<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DirectoryCloner
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DirectoryCloner))
        Me.btnClone = New System.Windows.Forms.Button()
        Me.txtSource = New System.Windows.Forms.TextBox()
        Me.lblSource = New System.Windows.Forms.Label()
        Me.lblDestination = New System.Windows.Forms.Label()
        Me.txtDestination = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.progressCloning = New System.Windows.Forms.ProgressBar()
        Me.browseDirectories = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnSourceBrowse = New System.Windows.Forms.Button()
        Me.btnDestinationBrowse = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClone
        '
        Me.btnClone.Location = New System.Drawing.Point(12, 226)
        Me.btnClone.Name = "btnClone"
        Me.btnClone.Size = New System.Drawing.Size(260, 23)
        Me.btnClone.TabIndex = 0
        Me.btnClone.Text = "Clone"
        Me.btnClone.UseVisualStyleBackColor = True
        '
        'txtSource
        '
        Me.txtSource.Location = New System.Drawing.Point(12, 47)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(195, 20)
        Me.txtSource.TabIndex = 1
        '
        'lblSource
        '
        Me.lblSource.AutoSize = True
        Me.lblSource.Location = New System.Drawing.Point(13, 28)
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Size = New System.Drawing.Size(44, 13)
        Me.lblSource.TabIndex = 2
        Me.lblSource.Text = "Source:"
        '
        'lblDestination
        '
        Me.lblDestination.AutoSize = True
        Me.lblDestination.Location = New System.Drawing.Point(13, 90)
        Me.lblDestination.Name = "lblDestination"
        Me.lblDestination.Size = New System.Drawing.Size(63, 13)
        Me.lblDestination.TabIndex = 4
        Me.lblDestination.Text = "Destination:"
        '
        'txtDestination
        '
        Me.txtDestination.Location = New System.Drawing.Point(12, 109)
        Me.txtDestination.Name = "txtDestination"
        Me.txtDestination.Size = New System.Drawing.Size(195, 20)
        Me.txtDestination.TabIndex = 3
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(9, 168)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(115, 13)
        Me.lblStatus.TabIndex = 5
        Me.lblStatus.Text = "No operation running..."
        '
        'progressCloning
        '
        Me.progressCloning.Location = New System.Drawing.Point(12, 184)
        Me.progressCloning.Name = "progressCloning"
        Me.progressCloning.Size = New System.Drawing.Size(260, 23)
        Me.progressCloning.TabIndex = 6
        '
        'browseDirectories
        '
        Me.browseDirectories.RootFolder = System.Environment.SpecialFolder.DesktopDirectory
        '
        'btnSourceBrowse
        '
        Me.btnSourceBrowse.Location = New System.Drawing.Point(213, 45)
        Me.btnSourceBrowse.Name = "btnSourceBrowse"
        Me.btnSourceBrowse.Size = New System.Drawing.Size(59, 23)
        Me.btnSourceBrowse.TabIndex = 7
        Me.btnSourceBrowse.Text = "Find"
        Me.btnSourceBrowse.UseVisualStyleBackColor = True
        '
        'btnDestinationBrowse
        '
        Me.btnDestinationBrowse.Location = New System.Drawing.Point(213, 107)
        Me.btnDestinationBrowse.Name = "btnDestinationBrowse"
        Me.btnDestinationBrowse.Size = New System.Drawing.Size(59, 23)
        Me.btnDestinationBrowse.TabIndex = 8
        Me.btnDestinationBrowse.Text = "Find"
        Me.btnDestinationBrowse.UseVisualStyleBackColor = True
        '
        'DirectoryCloner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnDestinationBrowse)
        Me.Controls.Add(Me.btnSourceBrowse)
        Me.Controls.Add(Me.progressCloning)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblDestination)
        Me.Controls.Add(Me.txtDestination)
        Me.Controls.Add(Me.lblSource)
        Me.Controls.Add(Me.txtSource)
        Me.Controls.Add(Me.btnClone)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DirectoryCloner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Directory Cloner"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClone As System.Windows.Forms.Button
    Friend WithEvents txtSource As System.Windows.Forms.TextBox
    Friend WithEvents lblSource As System.Windows.Forms.Label
    Friend WithEvents lblDestination As System.Windows.Forms.Label
    Friend WithEvents txtDestination As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents progressCloning As System.Windows.Forms.ProgressBar
    Friend WithEvents browseDirectories As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnSourceBrowse As System.Windows.Forms.Button
    Friend WithEvents btnDestinationBrowse As System.Windows.Forms.Button

End Class
