<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registerForm
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
        Me.fn = New System.Windows.Forms.TextBox()
        Me.occupation = New System.Windows.Forms.TextBox()
        Me.ln = New System.Windows.Forms.TextBox()
        Me.mn = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.sex = New System.Windows.Forms.ComboBox()
        Me.status = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.purok = New System.Windows.Forms.ComboBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.picturebox = New System.Windows.Forms.PictureBox()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.residentNo = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bday = New System.Windows.Forms.DateTimePicker()
        CType(Me.picturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fn
        '
        Me.fn.Location = New System.Drawing.Point(278, 58)
        Me.fn.Multiline = True
        Me.fn.Name = "fn"
        Me.fn.Size = New System.Drawing.Size(273, 42)
        Me.fn.TabIndex = 0
        '
        'occupation
        '
        Me.occupation.Location = New System.Drawing.Point(278, 314)
        Me.occupation.Multiline = True
        Me.occupation.Name = "occupation"
        Me.occupation.Size = New System.Drawing.Size(273, 42)
        Me.occupation.TabIndex = 2
        '
        'ln
        '
        Me.ln.Location = New System.Drawing.Point(278, 193)
        Me.ln.Multiline = True
        Me.ln.Name = "ln"
        Me.ln.Size = New System.Drawing.Size(273, 42)
        Me.ln.TabIndex = 4
        '
        'mn
        '
        Me.mn.Location = New System.Drawing.Point(278, 125)
        Me.mn.Multiline = True
        Me.mn.Name = "mn"
        Me.mn.Size = New System.Drawing.Size(273, 42)
        Me.mn.TabIndex = 5
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(37, 73)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(54, 13)
        Me.label1.TabIndex = 6
        Me.label1.Text = "FirstName"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Lastname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 327)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Occupation"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 267)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Sex"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Middle Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(37, 384)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Marital Status"
        '
        'sex
        '
        Me.sex.FormattingEnabled = True
        Me.sex.Location = New System.Drawing.Point(278, 264)
        Me.sex.Name = "sex"
        Me.sex.Size = New System.Drawing.Size(124, 21)
        Me.sex.TabIndex = 12
        '
        'status
        '
        Me.status.FormattingEnabled = True
        Me.status.Location = New System.Drawing.Point(278, 384)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(124, 21)
        Me.status.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(37, 438)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Birthday ""MM/DD/YEAR"""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(37, 490)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Purok / Zone"
        '
        'purok
        '
        Me.purok.FormattingEnabled = True
        Me.purok.Location = New System.Drawing.Point(278, 482)
        Me.purok.Name = "purok"
        Me.purok.Size = New System.Drawing.Size(273, 21)
        Me.purok.TabIndex = 19
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(526, 515)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(113, 34)
        Me.btnRegister.TabIndex = 20
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'picturebox
        '
        Me.picturebox.Location = New System.Drawing.Point(602, 54)
        Me.picturebox.Name = "picturebox"
        Me.picturebox.Size = New System.Drawing.Size(179, 195)
        Me.picturebox.TabIndex = 21
        Me.picturebox.TabStop = False
        '
        'btnUpload
        '
        Me.btnUpload.Location = New System.Drawing.Point(602, 260)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(179, 32)
        Me.btnUpload.TabIndex = 22
        Me.btnUpload.Text = "Upload"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'residentNo
        '
        Me.residentNo.ForeColor = System.Drawing.Color.Red
        Me.residentNo.Location = New System.Drawing.Point(602, 12)
        Me.residentNo.Multiline = True
        Me.residentNo.Name = "residentNo"
        Me.residentNo.Size = New System.Drawing.Size(179, 32)
        Me.residentNo.TabIndex = 23
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(668, 515)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 34)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'bday
        '
        Me.bday.Location = New System.Drawing.Point(278, 438)
        Me.bday.Name = "bday"
        Me.bday.Size = New System.Drawing.Size(200, 20)
        Me.bday.TabIndex = 25
        '
        'registerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 560)
        Me.Controls.Add(Me.bday)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.residentNo)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.picturebox)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.purok)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.sex)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.mn)
        Me.Controls.Add(Me.ln)
        Me.Controls.Add(Me.occupation)
        Me.Controls.Add(Me.fn)
        Me.Name = "registerForm"
        Me.Text = "registerForm"
        CType(Me.picturebox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fn As TextBox
    Friend WithEvents occupation As TextBox
    Friend WithEvents ln As TextBox
    Friend WithEvents mn As TextBox
    Friend WithEvents label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents sex As ComboBox
    Friend WithEvents status As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents purok As ComboBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents picturebox As PictureBox
    Friend WithEvents btnUpload As Button
    Friend WithEvents residentNo As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents bday As DateTimePicker
End Class
