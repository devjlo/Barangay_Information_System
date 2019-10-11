<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Residents
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lvw = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.fn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ln = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.sex = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.occupation = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.fooruk = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(78, 61)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 125)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(371, 20)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(413, 36)
        Me.txtSearch.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(78, 212)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 125)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Register"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lvw
        '
        Me.lvw.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.fn, Me.mn, Me.ln, Me.sex, Me.occupation, Me.status, Me.fooruk})
        Me.lvw.FullRowSelect = True
        Me.lvw.GridLines = True
        Me.lvw.Location = New System.Drawing.Point(248, 106)
        Me.lvw.Name = "lvw"
        Me.lvw.Size = New System.Drawing.Size(730, 323)
        Me.lvw.TabIndex = 4
        Me.lvw.UseCompatibleStateImageBehavior = False
        Me.lvw.View = System.Windows.Forms.View.Details
        '
        'id
        '
        Me.id.Text = "ID"
        Me.id.Width = 66
        '
        'fn
        '
        Me.fn.Text = "First Name"
        Me.fn.Width = 100
        '
        'mn
        '
        Me.mn.Text = "Middle Name"
        Me.mn.Width = 102
        '
        'ln
        '
        Me.ln.Text = "Last Name"
        Me.ln.Width = 103
        '
        'sex
        '
        Me.sex.Text = "Sex"
        Me.sex.Width = 75
        '
        'occupation
        '
        Me.occupation.Text = "Occupation"
        Me.occupation.Width = 95
        '
        'status
        '
        Me.status.Text = "Status"
        Me.status.Width = 83
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(790, 20)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(63, 36)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(78, 364)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(122, 125)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'fooruk
        '
        Me.fooruk.Text = "Purok"
        Me.fooruk.Width = 94
        '
        'Residents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 494)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lvw)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Button2)
        Me.Name = "Residents"
        Me.Text = "Residents"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lvw As ListView
    Friend WithEvents id As ColumnHeader
    Friend WithEvents fn As ColumnHeader
    Friend WithEvents mn As ColumnHeader
    Friend WithEvents ln As ColumnHeader
    Friend WithEvents sex As ColumnHeader
    Friend WithEvents occupation As ColumnHeader
    Friend WithEvents status As ColumnHeader
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents fooruk As ColumnHeader
End Class
