<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Violationmain
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
        Me.name = New System.Windows.Forms.TextBox()
        Me.Description = New System.Windows.Forms.TextBox()
        Me.penalty = New System.Windows.Forms.TextBox()
        Me.search = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lvw = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.fullName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.sex = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.occupation = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.purok = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.sve = New System.Windows.Forms.Button()
        Me.cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'name
        '
        Me.name.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name.Location = New System.Drawing.Point(90, 37)
        Me.name.Name = "name"
        Me.name.Size = New System.Drawing.Size(195, 24)
        Me.name.TabIndex = 1
        '
        'Description
        '
        Me.Description.Location = New System.Drawing.Point(125, 115)
        Me.Description.Multiline = True
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(262, 83)
        Me.Description.TabIndex = 2
        '
        'penalty
        '
        Me.penalty.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.penalty.Location = New System.Drawing.Point(98, 317)
        Me.penalty.Name = "penalty"
        Me.penalty.Size = New System.Drawing.Size(195, 24)
        Me.penalty.TabIndex = 4
        '
        'search
        '
        Me.search.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search.Location = New System.Drawing.Point(558, 33)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(389, 29)
        Me.search.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Description :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Date :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 320)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Penalty :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(484, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Search :"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(90, 261)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 11
        '
        'lvw
        '
        Me.lvw.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.fullName, Me.sex, Me.occupation, Me.purok})
        Me.lvw.FullRowSelect = True
        Me.lvw.GridLines = True
        Me.lvw.Location = New System.Drawing.Point(425, 80)
        Me.lvw.Name = "lvw"
        Me.lvw.Size = New System.Drawing.Size(522, 323)
        Me.lvw.TabIndex = 12
        Me.lvw.UseCompatibleStateImageBehavior = False
        Me.lvw.View = System.Windows.Forms.View.Details
        '
        'id
        '
        Me.id.Text = "ID"
        Me.id.Width = 51
        '
        'fullName
        '
        Me.fullName.Text = "Name"
        Me.fullName.Width = 129
        '
        'sex
        '
        Me.sex.Text = "Sex"
        Me.sex.Width = 75
        '
        'occupation
        '
        Me.occupation.Text = "Occupation"
        Me.occupation.Width = 141
        '
        'purok
        '
        Me.purok.Text = "Purok"
        Me.purok.Width = 94
        '
        'sve
        '
        Me.sve.Location = New System.Drawing.Point(425, 444)
        Me.sve.Name = "sve"
        Me.sve.Size = New System.Drawing.Size(207, 37)
        Me.sve.TabIndex = 13
        Me.sve.Text = "Save"
        Me.sve.UseVisualStyleBackColor = True
        '
        'cancel
        '
        Me.cancel.Location = New System.Drawing.Point(766, 444)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(181, 37)
        Me.cancel.TabIndex = 14
        Me.cancel.Text = "Cancel"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'Violationmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 493)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.sve)
        Me.Controls.Add(Me.lvw)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.penalty)
        Me.Controls.Add(Me.Description)
        Me.Controls.Add(Me.name)
        '   Me.name = "Violationmain"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents name As TextBox
    Friend WithEvents Description As TextBox
    Friend WithEvents penalty As TextBox
    Friend WithEvents search As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lvw As ListView
    Friend WithEvents id As ColumnHeader
    Friend WithEvents fullName As ColumnHeader
    Friend WithEvents sex As ColumnHeader
    Friend WithEvents occupation As ColumnHeader
    Friend WithEvents purok As ColumnHeader
    Friend WithEvents sve As Button
    Friend WithEvents cancel As Button
End Class
