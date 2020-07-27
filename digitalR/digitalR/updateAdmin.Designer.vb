<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updateAdmin
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
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpdob = New System.Windows.Forms.DateTimePicker()
        Me.lbldob = New System.Windows.Forms.Label()
        Me.txtmobileno = New System.Windows.Forms.TextBox()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.lblsalary = New System.Windows.Forms.Label()
        Me.txtDesignation = New System.Windows.Forms.TextBox()
        Me.lblDesignation = New System.Windows.Forms.Label()
        Me.dtpDateofjoining = New System.Windows.Forms.DateTimePicker()
        Me.lbldateofjoining = New System.Windows.Forms.Label()
        Me.rtbAddress = New System.Windows.Forms.RichTextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblcontactno = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.lblid = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.Transparent
        Me.groupBox1.Controls.Add(Me.txtid)
        Me.groupBox1.Controls.Add(Me.lblid)
        Me.groupBox1.Controls.Add(Me.dtpdob)
        Me.groupBox1.Controls.Add(Me.lbldob)
        Me.groupBox1.Controls.Add(Me.txtmobileno)
        Me.groupBox1.Controls.Add(Me.lblusername)
        Me.groupBox1.Controls.Add(Me.txtSalary)
        Me.groupBox1.Controls.Add(Me.lblsalary)
        Me.groupBox1.Controls.Add(Me.txtDesignation)
        Me.groupBox1.Controls.Add(Me.lblDesignation)
        Me.groupBox1.Controls.Add(Me.dtpDateofjoining)
        Me.groupBox1.Controls.Add(Me.lbldateofjoining)
        Me.groupBox1.Controls.Add(Me.rtbAddress)
        Me.groupBox1.Controls.Add(Me.lblAddress)
        Me.groupBox1.Controls.Add(Me.txtEmail)
        Me.groupBox1.Controls.Add(Me.txtpass)
        Me.groupBox1.Controls.Add(Me.txtUserName)
        Me.groupBox1.Controls.Add(Me.txtName)
        Me.groupBox1.Controls.Add(Me.lblEmail)
        Me.groupBox1.Controls.Add(Me.lblcontactno)
        Me.groupBox1.Controls.Add(Me.lblName)
        Me.groupBox1.Controls.Add(Me.lblPass)
        Me.groupBox1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.ForeColor = System.Drawing.Color.Black
        Me.groupBox1.Location = New System.Drawing.Point(227, 1)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(509, 547)
        Me.groupBox1.TabIndex = 3
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "User Details"
        '
        'dtpdob
        '
        Me.dtpdob.Location = New System.Drawing.Point(187, 246)
        Me.dtpdob.Name = "dtpdob"
        Me.dtpdob.Size = New System.Drawing.Size(187, 24)
        Me.dtpdob.TabIndex = 6
        '
        'lbldob
        '
        Me.lbldob.AutoSize = True
        Me.lbldob.Location = New System.Drawing.Point(67, 246)
        Me.lbldob.Name = "lbldob"
        Me.lbldob.Size = New System.Drawing.Size(82, 17)
        Me.lbldob.TabIndex = 29
        Me.lbldob.Text = "Date Of Birth"
        '
        'txtmobileno
        '
        Me.txtmobileno.Location = New System.Drawing.Point(178, 198)
        Me.txtmobileno.Name = "txtmobileno"
        Me.txtmobileno.Size = New System.Drawing.Size(196, 24)
        Me.txtmobileno.TabIndex = 5
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Location = New System.Drawing.Point(66, 65)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(69, 17)
        Me.lblusername.TabIndex = 28
        Me.lblusername.Text = "User Name"
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(178, 504)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(178, 24)
        Me.txtSalary.TabIndex = 11
        '
        'lblsalary
        '
        Me.lblsalary.AutoSize = True
        Me.lblsalary.Location = New System.Drawing.Point(76, 507)
        Me.lblsalary.Name = "lblsalary"
        Me.lblsalary.Size = New System.Drawing.Size(42, 17)
        Me.lblsalary.TabIndex = 26
        Me.lblsalary.Text = "Salary"
        '
        'txtDesignation
        '
        Me.txtDesignation.Location = New System.Drawing.Point(178, 458)
        Me.txtDesignation.Name = "txtDesignation"
        Me.txtDesignation.Size = New System.Drawing.Size(178, 24)
        Me.txtDesignation.TabIndex = 10
        '
        'lblDesignation
        '
        Me.lblDesignation.AutoSize = True
        Me.lblDesignation.Location = New System.Drawing.Point(68, 458)
        Me.lblDesignation.Name = "lblDesignation"
        Me.lblDesignation.Size = New System.Drawing.Size(73, 17)
        Me.lblDesignation.TabIndex = 24
        Me.lblDesignation.Text = "Designation"
        '
        'dtpDateofjoining
        '
        Me.dtpDateofjoining.Location = New System.Drawing.Point(178, 402)
        Me.dtpDateofjoining.Name = "dtpDateofjoining"
        Me.dtpDateofjoining.Size = New System.Drawing.Size(200, 24)
        Me.dtpDateofjoining.TabIndex = 9
        '
        'lbldateofjoining
        '
        Me.lbldateofjoining.AutoSize = True
        Me.lbldateofjoining.Location = New System.Drawing.Point(68, 402)
        Me.lbldateofjoining.Name = "lbldateofjoining"
        Me.lbldateofjoining.Size = New System.Drawing.Size(94, 17)
        Me.lbldateofjoining.TabIndex = 22
        Me.lbldateofjoining.Text = "Date Of Joining"
        '
        'rtbAddress
        '
        Me.rtbAddress.Location = New System.Drawing.Point(184, 287)
        Me.rtbAddress.Name = "rtbAddress"
        Me.rtbAddress.Size = New System.Drawing.Size(200, 38)
        Me.rtbAddress.TabIndex = 7
        Me.rtbAddress.Text = ""
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(68, 287)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(52, 17)
        Me.lblAddress.TabIndex = 20
        Me.lblAddress.Text = "Address"
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(178, 112)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(196, 24)
        Me.txtpass.TabIndex = 3
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(176, 62)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(202, 24)
        Me.txtUserName.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(178, 158)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(196, 24)
        Me.txtName.TabIndex = 4
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(68, 351)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(43, 18)
        Me.lblEmail.TabIndex = 18
        Me.lblEmail.Text = "Email"
        '
        'lblcontactno
        '
        Me.lblcontactno.AutoSize = True
        Me.lblcontactno.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcontactno.Location = New System.Drawing.Point(66, 200)
        Me.lblcontactno.Name = "lblcontactno"
        Me.lblcontactno.Size = New System.Drawing.Size(80, 18)
        Me.lblcontactno.TabIndex = 17
        Me.lblcontactno.Text = "Contact No."
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(66, 158)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(45, 18)
        Me.lblName.TabIndex = 16
        Me.lblName.Text = "Name"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.Location = New System.Drawing.Point(66, 112)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(67, 18)
        Me.lblPass.TabIndex = 15
        Me.lblPass.Text = "Password"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(187, 351)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(197, 24)
        Me.txtEmail.TabIndex = 8
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(374, 554)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(115, 37)
        Me.btnupdate.TabIndex = 12
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Location = New System.Drawing.Point(66, 20)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(18, 17)
        Me.lblid.TabIndex = 30
        Me.lblid.Text = "id"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(176, 12)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(100, 24)
        Me.txtid.TabIndex = 1
        '
        'updateAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 618)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "updateAdmin"
        Me.Text = "updateAdmin"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents groupBox1 As GroupBox
    Friend WithEvents dtpdob As DateTimePicker
    Friend WithEvents lbldob As Label
    Friend WithEvents txtmobileno As TextBox
    Friend WithEvents lblusername As Label
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents lblsalary As Label
    Private WithEvents txtDesignation As TextBox
    Friend WithEvents lblDesignation As Label
    Friend WithEvents dtpDateofjoining As DateTimePicker
    Friend WithEvents lbldateofjoining As Label
    Friend WithEvents rtbAddress As RichTextBox
    Friend WithEvents lblAddress As Label
    Private WithEvents txtEmail As TextBox
    Private WithEvents txtpass As TextBox
    Private WithEvents txtUserName As TextBox
    Private WithEvents txtName As TextBox
    Private WithEvents lblEmail As Label
    Private WithEvents lblcontactno As Label
    Private WithEvents lblName As Label
    Private WithEvents lblPass As Label
    Friend WithEvents btnupdate As Button
    Friend WithEvents txtid As TextBox
    Friend WithEvents lblid As Label
End Class
