<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Register
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
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblcontactno = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lbldateofjoining = New System.Windows.Forms.Label()
        Me.dtpDateofjoining = New System.Windows.Forms.DateTimePicker()
        Me.lblDesignation = New System.Windows.Forms.Label()
        Me.txtDesignation = New System.Windows.Forms.TextBox()
        Me.lblsalary = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnationality = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.dtpdob = New System.Windows.Forms.DateTimePicker()
        Me.lbldob = New System.Windows.Forms.Label()
        Me.txtmobileno = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lnllblClose = New System.Windows.Forms.LinkLabel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.groupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.Snow
        Me.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnRegister.FlatAppearance.BorderSize = 10
        Me.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegister.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(381, 613)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(142, 42)
        Me.btnRegister.TabIndex = 12
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseMnemonic = False
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.Location = New System.Drawing.Point(137, 84)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(67, 18)
        Me.lblPass.TabIndex = 15
        Me.lblPass.Text = "Password"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(137, 130)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(45, 18)
        Me.lblName.TabIndex = 16
        Me.lblName.Text = "Name"
        '
        'lblcontactno
        '
        Me.lblcontactno.AutoSize = True
        Me.lblcontactno.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcontactno.Location = New System.Drawing.Point(137, 172)
        Me.lblcontactno.Name = "lblcontactno"
        Me.lblcontactno.Size = New System.Drawing.Size(80, 18)
        Me.lblcontactno.TabIndex = 17
        Me.lblcontactno.Text = "Contact No."
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(141, 352)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(43, 18)
        Me.lblEmail.TabIndex = 18
        Me.lblEmail.Text = "Email"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(264, 130)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(196, 24)
        Me.txtName.TabIndex = 3
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(264, 37)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(202, 24)
        Me.txtUserName.TabIndex = 1
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(264, 346)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(202, 24)
        Me.txtEmail.TabIndex = 8
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(145, 259)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(52, 17)
        Me.lblAddress.TabIndex = 20
        Me.lblAddress.Text = "Address"
        '
        'lbldateofjoining
        '
        Me.lbldateofjoining.AutoSize = True
        Me.lbldateofjoining.Location = New System.Drawing.Point(141, 398)
        Me.lbldateofjoining.Name = "lbldateofjoining"
        Me.lbldateofjoining.Size = New System.Drawing.Size(94, 17)
        Me.lbldateofjoining.TabIndex = 22
        Me.lbldateofjoining.Text = "Date Of Joining"
        '
        'dtpDateofjoining
        '
        Me.dtpDateofjoining.Location = New System.Drawing.Point(264, 392)
        Me.dtpDateofjoining.Name = "dtpDateofjoining"
        Me.dtpDateofjoining.Size = New System.Drawing.Size(200, 24)
        Me.dtpDateofjoining.TabIndex = 9
        '
        'lblDesignation
        '
        Me.lblDesignation.AutoSize = True
        Me.lblDesignation.Location = New System.Drawing.Point(146, 451)
        Me.lblDesignation.Name = "lblDesignation"
        Me.lblDesignation.Size = New System.Drawing.Size(73, 17)
        Me.lblDesignation.TabIndex = 24
        Me.lblDesignation.Text = "Designation"
        '
        'txtDesignation
        '
        Me.txtDesignation.Location = New System.Drawing.Point(264, 444)
        Me.txtDesignation.Name = "txtDesignation"
        Me.txtDesignation.Size = New System.Drawing.Size(202, 24)
        Me.txtDesignation.TabIndex = 10
        '
        'lblsalary
        '
        Me.lblsalary.AutoSize = True
        Me.lblsalary.Location = New System.Drawing.Point(146, 493)
        Me.lblsalary.Name = "lblsalary"
        Me.lblsalary.Size = New System.Drawing.Size(42, 17)
        Me.lblsalary.TabIndex = 26
        Me.lblsalary.Text = "Salary"
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.White
        Me.groupBox1.Controls.Add(Me.Label2)
        Me.groupBox1.Controls.Add(Me.txtnationality)
        Me.groupBox1.Controls.Add(Me.txtaddress)
        Me.groupBox1.Controls.Add(Me.dtpdob)
        Me.groupBox1.Controls.Add(Me.lbldob)
        Me.groupBox1.Controls.Add(Me.txtmobileno)
        Me.groupBox1.Controls.Add(Me.Label1)
        Me.groupBox1.Controls.Add(Me.txtSalary)
        Me.groupBox1.Controls.Add(Me.lblsalary)
        Me.groupBox1.Controls.Add(Me.txtDesignation)
        Me.groupBox1.Controls.Add(Me.lblDesignation)
        Me.groupBox1.Controls.Add(Me.dtpDateofjoining)
        Me.groupBox1.Controls.Add(Me.lbldateofjoining)
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
        Me.groupBox1.Location = New System.Drawing.Point(288, 66)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(663, 527)
        Me.groupBox1.TabIndex = 2
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = " Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(141, 301)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 18)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Nationality"
        '
        'txtnationality
        '
        Me.txtnationality.Location = New System.Drawing.Point(264, 295)
        Me.txtnationality.Name = "txtnationality"
        Me.txtnationality.Size = New System.Drawing.Size(202, 24)
        Me.txtnationality.TabIndex = 7
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(264, 259)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(200, 24)
        Me.txtaddress.TabIndex = 6
        '
        'dtpdob
        '
        Me.dtpdob.Location = New System.Drawing.Point(264, 218)
        Me.dtpdob.Name = "dtpdob"
        Me.dtpdob.Size = New System.Drawing.Size(196, 24)
        Me.dtpdob.TabIndex = 5
        '
        'lbldob
        '
        Me.lbldob.AutoSize = True
        Me.lbldob.Location = New System.Drawing.Point(141, 218)
        Me.lbldob.Name = "lbldob"
        Me.lbldob.Size = New System.Drawing.Size(82, 17)
        Me.lbldob.TabIndex = 29
        Me.lbldob.Text = "Date Of Birth"
        '
        'txtmobileno
        '
        Me.txtmobileno.Location = New System.Drawing.Point(264, 170)
        Me.txtmobileno.Name = "txtmobileno"
        Me.txtmobileno.Size = New System.Drawing.Size(196, 24)
        Me.txtmobileno.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(100, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 17)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "User Name/Admin Id"
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(264, 490)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(202, 24)
        Me.txtSalary.TabIndex = 11
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(264, 84)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(196, 24)
        Me.txtpass.TabIndex = 2
        Me.txtpass.UseSystemPasswordChar = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Salmon
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(12, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1227, 59)
        Me.Panel2.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(3, 62)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 100)
        Me.Panel3.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LightSalmon
        Me.PictureBox1.Location = New System.Drawing.Point(62, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(457, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(280, 36)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Digital Restautrant"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Salmon
        Me.Panel5.Controls.Add(Me.lnllblClose)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Location = New System.Drawing.Point(2, 680)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1237, 52)
        Me.Panel5.TabIndex = 18
        '
        'lnllblClose
        '
        Me.lnllblClose.AutoSize = True
        Me.lnllblClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lnllblClose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lnllblClose.Location = New System.Drawing.Point(583, 18)
        Me.lnllblClose.Name = "lnllblClose"
        Me.lnllblClose.Size = New System.Drawing.Size(63, 24)
        Me.lnllblClose.TabIndex = 10
        Me.lnllblClose.TabStop = True
        Me.lnllblClose.Text = "Close"
        '
        'Panel6
        '
        Me.Panel6.Location = New System.Drawing.Point(3, 62)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(200, 100)
        Me.Panel6.TabIndex = 9
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Snow
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnClear.FlatAppearance.BorderSize = 10
        Me.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(589, 613)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(142, 42)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseMnemonic = False
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(1243, 731)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "Register"
        Me.Text = "Registration of Staff And Admin "
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents btnRegister As System.Windows.Forms.Button
    Private WithEvents lblPass As Label
    Private WithEvents lblName As Label
    Private WithEvents lblcontactno As Label
    Private WithEvents lblEmail As Label
    Private WithEvents txtName As TextBox
    Private WithEvents txtUserName As TextBox
    Private WithEvents txtEmail As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents lbldateofjoining As Label
    Friend WithEvents dtpDateofjoining As DateTimePicker
    Friend WithEvents lblDesignation As Label
    Private WithEvents txtDesignation As TextBox
    Friend WithEvents lblsalary As Label
    Private WithEvents groupBox1 As GroupBox
    Friend WithEvents txtSalary As TextBox
    Private WithEvents txtpass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtmobileno As TextBox
    Friend WithEvents lbldob As Label
    Friend WithEvents dtpdob As DateTimePicker
    Friend WithEvents txtaddress As TextBox
    Private WithEvents Label2 As Label
    Private WithEvents txtnationality As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lnllblClose As LinkLabel
    Friend WithEvents Panel6 As Panel
    Private WithEvents btnClear As Button
End Class
