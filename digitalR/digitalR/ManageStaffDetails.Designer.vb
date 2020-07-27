<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageStaffDetails
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnStaffClear = New System.Windows.Forms.Button()
        Me.btnStaffLoad = New System.Windows.Forms.Button()
        Me.btnStaffDelete = New System.Windows.Forms.Button()
        Me.btnStaffUpdate = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpStaffAdminID = New System.Windows.Forms.DateTimePicker()
        Me.txtNationality = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtStaffAdminID = New System.Windows.Forms.TextBox()
        Me.txtStaffaddress = New System.Windows.Forms.TextBox()
        Me.dtpStaffdob = New System.Windows.Forms.DateTimePicker()
        Me.lbldob = New System.Windows.Forms.Label()
        Me.txtStaffmobileno = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtStaffSalary = New System.Windows.Forms.TextBox()
        Me.lblsalary = New System.Windows.Forms.Label()
        Me.txtStaffDesignation = New System.Windows.Forms.TextBox()
        Me.lblDesignation = New System.Windows.Forms.Label()
        Me.dtpStaffDateofjoining = New System.Windows.Forms.DateTimePicker()
        Me.lbldateofjoining = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtStaffEmail = New System.Windows.Forms.TextBox()
        Me.txtstaffUserName = New System.Windows.Forms.TextBox()
        Me.txtStaffName = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblcontactno = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtstaffSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblSTaffSearch = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lnllblClose = New System.Windows.Forms.LinkLabel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Salmon
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1356, 59)
        Me.Panel1.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(3, 62)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 100)
        Me.Panel2.TabIndex = 9
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(531, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(280, 36)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Digital Restautrant"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(419, 184)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(931, 354)
        Me.DataGridView1.TabIndex = 11
        Me.DataGridView1.VirtualMode = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Snow
        Me.Panel5.Controls.Add(Me.btnStaffClear)
        Me.Panel5.Controls.Add(Me.btnStaffLoad)
        Me.Panel5.Controls.Add(Me.btnStaffDelete)
        Me.Panel5.Controls.Add(Me.btnStaffUpdate)
        Me.Panel5.Location = New System.Drawing.Point(408, 576)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(915, 63)
        Me.Panel5.TabIndex = 12
        '
        'btnStaffClear
        '
        Me.btnStaffClear.AutoEllipsis = True
        Me.btnStaffClear.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnStaffClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnStaffClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStaffClear.FlatAppearance.BorderSize = 2
        Me.btnStaffClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnStaffClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnStaffClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnStaffClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStaffClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaffClear.Location = New System.Drawing.Point(715, 18)
        Me.btnStaffClear.Name = "btnStaffClear"
        Me.btnStaffClear.Size = New System.Drawing.Size(139, 32)
        Me.btnStaffClear.TabIndex = 4
        Me.btnStaffClear.Text = "CLEAR"
        Me.btnStaffClear.UseVisualStyleBackColor = False
        '
        'btnStaffLoad
        '
        Me.btnStaffLoad.AutoEllipsis = True
        Me.btnStaffLoad.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnStaffLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnStaffLoad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStaffLoad.FlatAppearance.BorderSize = 2
        Me.btnStaffLoad.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnStaffLoad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnStaffLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnStaffLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStaffLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaffLoad.Location = New System.Drawing.Point(61, 13)
        Me.btnStaffLoad.Name = "btnStaffLoad"
        Me.btnStaffLoad.Size = New System.Drawing.Size(139, 37)
        Me.btnStaffLoad.TabIndex = 3
        Me.btnStaffLoad.Text = "LOAD"
        Me.btnStaffLoad.UseVisualStyleBackColor = False
        '
        'btnStaffDelete
        '
        Me.btnStaffDelete.AutoEllipsis = True
        Me.btnStaffDelete.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnStaffDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnStaffDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStaffDelete.FlatAppearance.BorderSize = 2
        Me.btnStaffDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnStaffDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnStaffDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnStaffDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStaffDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaffDelete.Location = New System.Drawing.Point(494, 18)
        Me.btnStaffDelete.Name = "btnStaffDelete"
        Me.btnStaffDelete.Size = New System.Drawing.Size(137, 32)
        Me.btnStaffDelete.TabIndex = 2
        Me.btnStaffDelete.Text = "DELETE"
        Me.btnStaffDelete.UseVisualStyleBackColor = False
        '
        'btnStaffUpdate
        '
        Me.btnStaffUpdate.AutoEllipsis = True
        Me.btnStaffUpdate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnStaffUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnStaffUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStaffUpdate.FlatAppearance.BorderSize = 2
        Me.btnStaffUpdate.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnStaffUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnStaffUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnStaffUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStaffUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaffUpdate.Location = New System.Drawing.Point(266, 15)
        Me.btnStaffUpdate.Name = "btnStaffUpdate"
        Me.btnStaffUpdate.Size = New System.Drawing.Size(141, 32)
        Me.btnStaffUpdate.TabIndex = 1
        Me.btnStaffUpdate.Text = "UPDATE"
        Me.btnStaffUpdate.UseVisualStyleBackColor = False
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.groupBox1.Controls.Add(Me.dtpStaffAdminID)
        Me.groupBox1.Controls.Add(Me.txtNationality)
        Me.groupBox1.Controls.Add(Me.Label6)
        Me.groupBox1.Controls.Add(Me.Label4)
        Me.groupBox1.Controls.Add(Me.Label1)
        Me.groupBox1.Controls.Add(Me.txtStaffAdminID)
        Me.groupBox1.Controls.Add(Me.txtStaffaddress)
        Me.groupBox1.Controls.Add(Me.dtpStaffdob)
        Me.groupBox1.Controls.Add(Me.lbldob)
        Me.groupBox1.Controls.Add(Me.txtStaffmobileno)
        Me.groupBox1.Controls.Add(Me.Label3)
        Me.groupBox1.Controls.Add(Me.txtStaffSalary)
        Me.groupBox1.Controls.Add(Me.lblsalary)
        Me.groupBox1.Controls.Add(Me.txtStaffDesignation)
        Me.groupBox1.Controls.Add(Me.lblDesignation)
        Me.groupBox1.Controls.Add(Me.dtpStaffDateofjoining)
        Me.groupBox1.Controls.Add(Me.lbldateofjoining)
        Me.groupBox1.Controls.Add(Me.lblAddress)
        Me.groupBox1.Controls.Add(Me.txtStaffEmail)
        Me.groupBox1.Controls.Add(Me.txtstaffUserName)
        Me.groupBox1.Controls.Add(Me.txtStaffName)
        Me.groupBox1.Controls.Add(Me.lblEmail)
        Me.groupBox1.Controls.Add(Me.lblcontactno)
        Me.groupBox1.Controls.Add(Me.lblName)
        Me.groupBox1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.ForeColor = System.Drawing.Color.Black
        Me.groupBox1.Location = New System.Drawing.Point(4, 65)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(398, 585)
        Me.groupBox1.TabIndex = 13
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Staff Details"
        '
        'dtpStaffAdminID
        '
        Me.dtpStaffAdminID.Location = New System.Drawing.Point(149, 539)
        Me.dtpStaffAdminID.Name = "dtpStaffAdminID"
        Me.dtpStaffAdminID.Size = New System.Drawing.Size(225, 24)
        Me.dtpStaffAdminID.TabIndex = 37
        '
        'txtNationality
        '
        Me.txtNationality.Location = New System.Drawing.Point(145, 243)
        Me.txtNationality.Name = "txtNationality"
        Me.txtNationality.Size = New System.Drawing.Size(225, 24)
        Me.txtNationality.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 18)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Nationality"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 545)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 17)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Admin Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 490)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "AdminId"
        '
        'txtStaffAdminID
        '
        Me.txtStaffAdminID.Location = New System.Drawing.Point(149, 490)
        Me.txtStaffAdminID.Name = "txtStaffAdminID"
        Me.txtStaffAdminID.Size = New System.Drawing.Size(229, 24)
        Me.txtStaffAdminID.TabIndex = 31
        '
        'txtStaffaddress
        '
        Me.txtStaffaddress.Location = New System.Drawing.Point(145, 202)
        Me.txtStaffaddress.Name = "txtStaffaddress"
        Me.txtStaffaddress.Size = New System.Drawing.Size(225, 24)
        Me.txtStaffaddress.TabIndex = 30
        '
        'dtpStaffdob
        '
        Me.dtpStaffdob.Location = New System.Drawing.Point(145, 159)
        Me.dtpStaffdob.Name = "dtpStaffdob"
        Me.dtpStaffdob.Size = New System.Drawing.Size(221, 24)
        Me.dtpStaffdob.TabIndex = 5
        '
        'lbldob
        '
        Me.lbldob.AutoSize = True
        Me.lbldob.Location = New System.Drawing.Point(17, 159)
        Me.lbldob.Name = "lbldob"
        Me.lbldob.Size = New System.Drawing.Size(82, 17)
        Me.lbldob.TabIndex = 29
        Me.lbldob.Text = "Date Of Birth"
        '
        'txtStaffmobileno
        '
        Me.txtStaffmobileno.Location = New System.Drawing.Point(145, 113)
        Me.txtStaffmobileno.Name = "txtStaffmobileno"
        Me.txtStaffmobileno.Size = New System.Drawing.Size(221, 24)
        Me.txtStaffmobileno.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "User Name"
        '
        'txtStaffSalary
        '
        Me.txtStaffSalary.Location = New System.Drawing.Point(145, 440)
        Me.txtStaffSalary.Name = "txtStaffSalary"
        Me.txtStaffSalary.Size = New System.Drawing.Size(229, 24)
        Me.txtStaffSalary.TabIndex = 10
        '
        'lblsalary
        '
        Me.lblsalary.AutoSize = True
        Me.lblsalary.Location = New System.Drawing.Point(23, 443)
        Me.lblsalary.Name = "lblsalary"
        Me.lblsalary.Size = New System.Drawing.Size(42, 17)
        Me.lblsalary.TabIndex = 26
        Me.lblsalary.Text = "Salary"
        '
        'txtStaffDesignation
        '
        Me.txtStaffDesignation.Location = New System.Drawing.Point(149, 384)
        Me.txtStaffDesignation.Name = "txtStaffDesignation"
        Me.txtStaffDesignation.Size = New System.Drawing.Size(225, 24)
        Me.txtStaffDesignation.TabIndex = 9
        '
        'lblDesignation
        '
        Me.lblDesignation.AutoSize = True
        Me.lblDesignation.Location = New System.Drawing.Point(17, 384)
        Me.lblDesignation.Name = "lblDesignation"
        Me.lblDesignation.Size = New System.Drawing.Size(73, 17)
        Me.lblDesignation.TabIndex = 24
        Me.lblDesignation.Text = "Designation"
        '
        'dtpStaffDateofjoining
        '
        Me.dtpStaffDateofjoining.Location = New System.Drawing.Point(149, 330)
        Me.dtpStaffDateofjoining.Name = "dtpStaffDateofjoining"
        Me.dtpStaffDateofjoining.Size = New System.Drawing.Size(225, 24)
        Me.dtpStaffDateofjoining.TabIndex = 8
        '
        'lbldateofjoining
        '
        Me.lbldateofjoining.AutoSize = True
        Me.lbldateofjoining.Location = New System.Drawing.Point(17, 330)
        Me.lbldateofjoining.Name = "lbldateofjoining"
        Me.lbldateofjoining.Size = New System.Drawing.Size(94, 17)
        Me.lbldateofjoining.TabIndex = 22
        Me.lbldateofjoining.Text = "Date Of Joining"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(17, 202)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(52, 17)
        Me.lblAddress.TabIndex = 20
        Me.lblAddress.Text = "Address"
        '
        'txtStaffEmail
        '
        Me.txtStaffEmail.Location = New System.Drawing.Point(149, 279)
        Me.txtStaffEmail.Name = "txtStaffEmail"
        Me.txtStaffEmail.Size = New System.Drawing.Size(225, 24)
        Me.txtStaffEmail.TabIndex = 7
        '
        'txtstaffUserName
        '
        Me.txtstaffUserName.Location = New System.Drawing.Point(145, 30)
        Me.txtstaffUserName.Name = "txtstaffUserName"
        Me.txtstaffUserName.Size = New System.Drawing.Size(225, 24)
        Me.txtstaffUserName.TabIndex = 1
        '
        'txtStaffName
        '
        Me.txtStaffName.Location = New System.Drawing.Point(145, 73)
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.Size = New System.Drawing.Size(221, 24)
        Me.txtStaffName.TabIndex = 3
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(17, 281)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(43, 18)
        Me.lblEmail.TabIndex = 18
        Me.lblEmail.Text = "Email"
        '
        'lblcontactno
        '
        Me.lblcontactno.AutoSize = True
        Me.lblcontactno.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcontactno.Location = New System.Drawing.Point(17, 113)
        Me.lblcontactno.Name = "lblcontactno"
        Me.lblcontactno.Size = New System.Drawing.Size(80, 18)
        Me.lblcontactno.TabIndex = 17
        Me.lblcontactno.Text = "Contact No."
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(23, 73)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(45, 18)
        Me.lblName.TabIndex = 16
        Me.lblName.Text = "Name"
        '
        'txtstaffSearch
        '
        Me.txtstaffSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstaffSearch.Location = New System.Drawing.Point(687, 108)
        Me.txtstaffSearch.Multiline = True
        Me.txtstaffSearch.Name = "txtstaffSearch"
        Me.txtstaffSearch.Size = New System.Drawing.Size(246, 25)
        Me.txtstaffSearch.TabIndex = 35
        '
        'btnSearch
        '
        Me.btnSearch.AutoEllipsis = True
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSearch.FlatAppearance.BorderSize = 2
        Me.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(1021, 103)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(139, 31)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblSTaffSearch
        '
        Me.lblSTaffSearch.AutoSize = True
        Me.lblSTaffSearch.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSTaffSearch.Location = New System.Drawing.Point(436, 108)
        Me.lblSTaffSearch.Name = "lblSTaffSearch"
        Me.lblSTaffSearch.Size = New System.Drawing.Size(172, 21)
        Me.lblSTaffSearch.TabIndex = 35
        Me.lblSTaffSearch.Text = "Enter Name  By Search"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Salmon
        Me.Panel3.Controls.Add(Me.lnllblClose)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(4, 665)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1356, 43)
        Me.Panel3.TabIndex = 10
        '
        'lnllblClose
        '
        Me.lnllblClose.AutoSize = True
        Me.lnllblClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnllblClose.Location = New System.Drawing.Point(631, 10)
        Me.lnllblClose.Name = "lnllblClose"
        Me.lnllblClose.Size = New System.Drawing.Size(63, 24)
        Me.lnllblClose.TabIndex = 10
        Me.lnllblClose.TabStop = True
        Me.lnllblClose.Text = "Close"
        '
        'Panel4
        '
        Me.Panel4.Location = New System.Drawing.Point(3, 62)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 100)
        Me.Panel4.TabIndex = 9
        '
        'ManageStaffDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1362, 708)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lblSTaffSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtstaffSearch)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ManageStaffDetails"
        Me.Text = "ManageStaffDetails"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnStaffClear As Button
    Friend WithEvents btnStaffDelete As Button
    Friend WithEvents btnStaffUpdate As Button
    Private WithEvents groupBox1 As GroupBox
    Friend WithEvents txtStaffaddress As TextBox
    Friend WithEvents dtpStaffdob As DateTimePicker
    Friend WithEvents lbldob As Label
    Friend WithEvents txtStaffmobileno As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtStaffSalary As TextBox
    Friend WithEvents lblsalary As Label
    Private WithEvents txtStaffDesignation As TextBox
    Friend WithEvents lblDesignation As Label
    Friend WithEvents dtpStaffDateofjoining As DateTimePicker
    Friend WithEvents lbldateofjoining As Label
    Friend WithEvents lblAddress As Label
    Private WithEvents txtStaffEmail As TextBox
    Private WithEvents txtstaffUserName As TextBox
    Private WithEvents txtStaffName As TextBox
    Private WithEvents lblEmail As Label
    Private WithEvents lblcontactno As Label
    Private WithEvents lblName As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtStaffAdminID As TextBox
    Private WithEvents txtstaffSearch As TextBox
    Friend WithEvents btnSearch As Button
    Private WithEvents lblSTaffSearch As Label
    Private WithEvents Label6 As Label
    Private WithEvents txtNationality As TextBox
    Friend WithEvents dtpStaffAdminID As DateTimePicker
    Friend WithEvents btnStaffLoad As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lnllblClose As LinkLabel
    Friend WithEvents Panel4 As Panel
End Class
