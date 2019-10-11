<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class filesForm
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
        Me.btnBarangayClearance = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnPermit = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBarangayClearance
        '
        Me.btnBarangayClearance.Location = New System.Drawing.Point(35, 24)
        Me.btnBarangayClearance.Name = "btnBarangayClearance"
        Me.btnBarangayClearance.Size = New System.Drawing.Size(204, 112)
        Me.btnBarangayClearance.TabIndex = 0
        Me.btnBarangayClearance.Text = "Barangay Clearance"
        Me.btnBarangayClearance.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(305, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(204, 112)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnPermit
        '
        Me.btnPermit.Location = New System.Drawing.Point(35, 179)
        Me.btnPermit.Name = "btnPermit"
        Me.btnPermit.Size = New System.Drawing.Size(204, 112)
        Me.btnPermit.TabIndex = 2
        Me.btnPermit.Text = "Water,Pending,Electrical,Building Clearance"
        Me.btnPermit.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(35, 338)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(204, 112)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Brgy. Clearance of Residency"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'filesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 534)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnPermit)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnBarangayClearance)
        Me.Name = "filesForm"
        Me.Text = "filesForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBarangayClearance As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnPermit As Button
    Friend WithEvents Button4 As Button
End Class
