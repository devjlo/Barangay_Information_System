<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm
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
        Me.btnResidents = New System.Windows.Forms.Button()
        Me.btnFiles = New System.Windows.Forms.Button()
        Me.btnViolation = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnResidents
        '
        Me.btnResidents.Location = New System.Drawing.Point(781, 79)
        Me.btnResidents.Name = "btnResidents"
        Me.btnResidents.Size = New System.Drawing.Size(145, 86)
        Me.btnResidents.TabIndex = 0
        Me.btnResidents.Text = "Residents"
        Me.btnResidents.UseVisualStyleBackColor = True
        '
        'btnFiles
        '
        Me.btnFiles.Location = New System.Drawing.Point(781, 212)
        Me.btnFiles.Name = "btnFiles"
        Me.btnFiles.Size = New System.Drawing.Size(145, 86)
        Me.btnFiles.TabIndex = 1
        Me.btnFiles.Text = "Files"
        Me.btnFiles.UseVisualStyleBackColor = True
        '
        'btnViolation
        '
        Me.btnViolation.Location = New System.Drawing.Point(781, 330)
        Me.btnViolation.Name = "btnViolation"
        Me.btnViolation.Size = New System.Drawing.Size(145, 86)
        Me.btnViolation.TabIndex = 2
        Me.btnViolation.Text = "Violation"
        Me.btnViolation.UseVisualStyleBackColor = True
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 578)
        Me.Controls.Add(Me.btnViolation)
        Me.Controls.Add(Me.btnFiles)
        Me.Controls.Add(Me.btnResidents)
        Me.Name = "mainForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnResidents As Button
    Friend WithEvents btnFiles As Button
    Friend WithEvents btnViolation As Button
End Class
