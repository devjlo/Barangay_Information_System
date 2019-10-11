<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViolateRegister
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnup = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.lvw = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.fullName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Des = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dte = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.penalty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.back = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 8
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(451, 28)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(413, 32)
        Me.TextBox2.TabIndex = 11
        Me.TextBox2.Text = "SEARCH"
        '
        'btnup
        '
        Me.btnup.Enabled = False
        Me.btnup.Location = New System.Drawing.Point(18, 58)
        Me.btnup.Name = "btnup"
        Me.btnup.Size = New System.Drawing.Size(160, 80)
        Me.btnup.TabIndex = 14
        Me.btnup.Text = "Update"
        Me.btnup.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(18, 170)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(160, 78)
        Me.btnadd.TabIndex = 16
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'lvw
        '
        Me.lvw.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.fullName, Me.Des, Me.dte, Me.penalty})
        Me.lvw.FullRowSelect = True
        Me.lvw.GridLines = True
        Me.lvw.Location = New System.Drawing.Point(264, 79)
        Me.lvw.Name = "lvw"
        Me.lvw.Size = New System.Drawing.Size(600, 323)
        Me.lvw.TabIndex = 18
        Me.lvw.UseCompatibleStateImageBehavior = False
        Me.lvw.View = System.Windows.Forms.View.Details
        '
        'id
        '
        Me.id.Text = "ID"
        Me.id.Width = 38
        '
        'fullName
        '
        Me.fullName.Text = "Name"
        Me.fullName.Width = 129
        '
        'Des
        '
        Me.Des.Text = "Description"
        Me.Des.Width = 181
        '
        'dte
        '
        Me.dte.Text = "Date"
        Me.dte.Width = 109
        '
        'penalty
        '
        Me.penalty.Text = "Penalty"
        Me.penalty.Width = 115
        '
        'back
        '
        Me.back.Location = New System.Drawing.Point(18, 277)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(160, 78)
        Me.back.TabIndex = 19
        Me.back.Text = "Back"
        Me.back.UseVisualStyleBackColor = True
        '
        'ViolateRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 418)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.lvw)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btnup)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Name = "ViolateRegister"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnup As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents lvw As ListView
    Friend WithEvents id As ColumnHeader
    Friend WithEvents fullName As ColumnHeader
    Friend WithEvents Des As ColumnHeader
    Friend WithEvents dte As ColumnHeader
    Friend WithEvents penalty As ColumnHeader
    Friend WithEvents back As Button
End Class
