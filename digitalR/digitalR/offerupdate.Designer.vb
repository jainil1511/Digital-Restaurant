<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class offerupdate
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dtpAdminDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpOfferEndDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpOfferStartDate = New System.Windows.Forms.DateTimePicker()
        Me.txtAdminID = New System.Windows.Forms.TextBox()
        Me.LblAdminDate = New System.Windows.Forms.Label()
        Me.LblAdminID = New System.Windows.Forms.Label()
        Me.LblOfferEndDate = New System.Windows.Forms.Label()
        Me.LblOfferStartDate = New System.Windows.Forms.Label()
        Me.LblDiscount = New System.Windows.Forms.Label()
        Me.LblOfferName = New System.Windows.Forms.Label()
        Me.LblOfferID = New System.Windows.Forms.Label()
        Me.txtOfferName = New System.Windows.Forms.TextBox()
        Me.txtOfferDiscount = New System.Windows.Forms.TextBox()
        Me.txtOfferID = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnload = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.lblSeach = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Backlbl = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Salmon
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1303, 59)
        Me.Panel1.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(3, 62)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 100)
        Me.Panel2.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(457, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(280, 36)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Digital Restautrant"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dtpAdminDate)
        Me.Panel3.Controls.Add(Me.dtpOfferEndDate)
        Me.Panel3.Controls.Add(Me.dtpOfferStartDate)
        Me.Panel3.Controls.Add(Me.txtAdminID)
        Me.Panel3.Controls.Add(Me.LblAdminDate)
        Me.Panel3.Controls.Add(Me.LblAdminID)
        Me.Panel3.Controls.Add(Me.LblOfferEndDate)
        Me.Panel3.Controls.Add(Me.LblOfferStartDate)
        Me.Panel3.Controls.Add(Me.LblDiscount)
        Me.Panel3.Controls.Add(Me.LblOfferName)
        Me.Panel3.Controls.Add(Me.LblOfferID)
        Me.Panel3.Controls.Add(Me.txtOfferName)
        Me.Panel3.Controls.Add(Me.txtOfferDiscount)
        Me.Panel3.Controls.Add(Me.txtOfferID)
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(5, 83)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(363, 441)
        Me.Panel3.TabIndex = 9
        '
        'dtpAdminDate
        '
        Me.dtpAdminDate.Location = New System.Drawing.Point(160, 375)
        Me.dtpAdminDate.Name = "dtpAdminDate"
        Me.dtpAdminDate.Size = New System.Drawing.Size(160, 22)
        Me.dtpAdminDate.TabIndex = 15
        '
        'dtpOfferEndDate
        '
        Me.dtpOfferEndDate.Location = New System.Drawing.Point(160, 274)
        Me.dtpOfferEndDate.Name = "dtpOfferEndDate"
        Me.dtpOfferEndDate.Size = New System.Drawing.Size(160, 22)
        Me.dtpOfferEndDate.TabIndex = 14
        '
        'dtpOfferStartDate
        '
        Me.dtpOfferStartDate.Location = New System.Drawing.Point(160, 215)
        Me.dtpOfferStartDate.Name = "dtpOfferStartDate"
        Me.dtpOfferStartDate.Size = New System.Drawing.Size(160, 22)
        Me.dtpOfferStartDate.TabIndex = 13
        '
        'txtAdminID
        '
        Me.txtAdminID.Location = New System.Drawing.Point(160, 334)
        Me.txtAdminID.Multiline = True
        Me.txtAdminID.Name = "txtAdminID"
        Me.txtAdminID.Size = New System.Drawing.Size(160, 25)
        Me.txtAdminID.TabIndex = 12
        '
        'LblAdminDate
        '
        Me.LblAdminDate.AutoSize = True
        Me.LblAdminDate.Location = New System.Drawing.Point(3, 380)
        Me.LblAdminDate.Name = "LblAdminDate"
        Me.LblAdminDate.Size = New System.Drawing.Size(88, 16)
        Me.LblAdminDate.TabIndex = 11
        Me.LblAdminDate.Text = "Admin Date"
        '
        'LblAdminID
        '
        Me.LblAdminID.AutoSize = True
        Me.LblAdminID.Location = New System.Drawing.Point(3, 334)
        Me.LblAdminID.Name = "LblAdminID"
        Me.LblAdminID.Size = New System.Drawing.Size(70, 16)
        Me.LblAdminID.TabIndex = 10
        Me.LblAdminID.Text = "Admin ID"
        '
        'LblOfferEndDate
        '
        Me.LblOfferEndDate.AutoSize = True
        Me.LblOfferEndDate.Location = New System.Drawing.Point(3, 280)
        Me.LblOfferEndDate.Name = "LblOfferEndDate"
        Me.LblOfferEndDate.Size = New System.Drawing.Size(109, 16)
        Me.LblOfferEndDate.TabIndex = 9
        Me.LblOfferEndDate.Text = "Offer End Date"
        '
        'LblOfferStartDate
        '
        Me.LblOfferStartDate.AutoSize = True
        Me.LblOfferStartDate.Location = New System.Drawing.Point(3, 220)
        Me.LblOfferStartDate.Name = "LblOfferStartDate"
        Me.LblOfferStartDate.Size = New System.Drawing.Size(114, 16)
        Me.LblOfferStartDate.TabIndex = 7
        Me.LblOfferStartDate.Text = "Offer Start Date"
        '
        'LblDiscount
        '
        Me.LblDiscount.AutoSize = True
        Me.LblDiscount.Location = New System.Drawing.Point(3, 157)
        Me.LblDiscount.Name = "LblDiscount"
        Me.LblDiscount.Size = New System.Drawing.Size(68, 16)
        Me.LblDiscount.TabIndex = 6
        Me.LblDiscount.Text = "Discount"
        '
        'LblOfferName
        '
        Me.LblOfferName.AutoSize = True
        Me.LblOfferName.Location = New System.Drawing.Point(3, 99)
        Me.LblOfferName.Name = "LblOfferName"
        Me.LblOfferName.Size = New System.Drawing.Size(86, 16)
        Me.LblOfferName.TabIndex = 5
        Me.LblOfferName.Text = "Offer Name"
        '
        'LblOfferID
        '
        Me.LblOfferID.AutoSize = True
        Me.LblOfferID.Location = New System.Drawing.Point(3, 37)
        Me.LblOfferID.Name = "LblOfferID"
        Me.LblOfferID.Size = New System.Drawing.Size(60, 16)
        Me.LblOfferID.TabIndex = 4
        Me.LblOfferID.Text = "Offer ID"
        '
        'txtOfferName
        '
        Me.txtOfferName.Location = New System.Drawing.Point(160, 99)
        Me.txtOfferName.Multiline = True
        Me.txtOfferName.Name = "txtOfferName"
        Me.txtOfferName.Size = New System.Drawing.Size(160, 25)
        Me.txtOfferName.TabIndex = 3
        '
        'txtOfferDiscount
        '
        Me.txtOfferDiscount.Location = New System.Drawing.Point(160, 154)
        Me.txtOfferDiscount.Multiline = True
        Me.txtOfferDiscount.Name = "txtOfferDiscount"
        Me.txtOfferDiscount.Size = New System.Drawing.Size(160, 27)
        Me.txtOfferDiscount.TabIndex = 1
        '
        'txtOfferID
        '
        Me.txtOfferID.Location = New System.Drawing.Point(160, 34)
        Me.txtOfferID.Multiline = True
        Me.txtOfferID.Name = "txtOfferID"
        Me.txtOfferID.Size = New System.Drawing.Size(160, 25)
        Me.txtOfferID.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Location = New System.Drawing.Point(411, 156)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(854, 286)
        Me.DataGridView1.TabIndex = 10
        Me.DataGridView1.VirtualMode = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Snow
        Me.Panel4.Controls.Add(Me.btnADD)
        Me.Panel4.Controls.Add(Me.btnclear)
        Me.Panel4.Controls.Add(Me.btnload)
        Me.Panel4.Controls.Add(Me.btndelete)
        Me.Panel4.Controls.Add(Me.btnupdate)
        Me.Panel4.Location = New System.Drawing.Point(465, 467)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(791, 57)
        Me.Panel4.TabIndex = 11
        '
        'btnADD
        '
        Me.btnADD.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnADD.FlatAppearance.BorderSize = 10
        Me.btnADD.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnADD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btnADD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnADD.Location = New System.Drawing.Point(198, 12)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(118, 37)
        Me.btnADD.TabIndex = 5
        Me.btnADD.Text = "ADD/INSERT"
        Me.btnADD.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnclear.FlatAppearance.BorderSize = 10
        Me.btnclear.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnclear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btnclear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnclear.Location = New System.Drawing.Point(654, 15)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(126, 32)
        Me.btnclear.TabIndex = 4
        Me.btnclear.Text = "CLEAR"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnload
        '
        Me.btnload.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnload.FlatAppearance.BorderSize = 10
        Me.btnload.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btnload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnload.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnload.Location = New System.Drawing.Point(35, 13)
        Me.btnload.Name = "btnload"
        Me.btnload.Size = New System.Drawing.Size(128, 37)
        Me.btnload.TabIndex = 3
        Me.btnload.Text = "LOAD"
        Me.btnload.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btndelete.FlatAppearance.BorderSize = 10
        Me.btndelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btndelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btndelete.Location = New System.Drawing.Point(507, 13)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(124, 32)
        Me.btndelete.TabIndex = 2
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnupdate.FlatAppearance.BorderSize = 10
        Me.btnupdate.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btnupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnupdate.Location = New System.Drawing.Point(360, 14)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(116, 32)
        Me.btnupdate.TabIndex = 1
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(714, 112)
        Me.txtsearch.Multiline = True
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(257, 30)
        Me.txtsearch.TabIndex = 12
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(1053, 112)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(128, 30)
        Me.btnsearch.TabIndex = 5
        Me.btnsearch.Text = "SEARCH"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'lblSeach
        '
        Me.lblSeach.AutoSize = True
        Me.lblSeach.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeach.Location = New System.Drawing.Point(511, 120)
        Me.lblSeach.Name = "lblSeach"
        Me.lblSeach.Size = New System.Drawing.Size(126, 16)
        Me.lblSeach.TabIndex = 16
        Me.lblSeach.Text = "Enter Offer Name"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Salmon
        Me.Panel5.Controls.Add(Me.Backlbl)
        Me.Panel5.Location = New System.Drawing.Point(2, 559)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1303, 47)
        Me.Panel5.TabIndex = 17
        '
        'Backlbl
        '
        Me.Backlbl.AutoSize = True
        Me.Backlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Backlbl.Location = New System.Drawing.Point(623, 15)
        Me.Backlbl.Name = "Backlbl"
        Me.Backlbl.Size = New System.Drawing.Size(63, 24)
        Me.Backlbl.TabIndex = 0
        Me.Backlbl.TabStop = True
        Me.Backlbl.Text = "Close"
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
        'offerupdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1290, 607)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.lblSeach)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "offerupdate"
        Me.Text = "offerupdate"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnclear As Button
    Friend WithEvents btnload As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents LblOfferEndDate As Label
    Friend WithEvents LblOfferStartDate As Label
    Friend WithEvents LblDiscount As Label
    Friend WithEvents LblOfferName As Label
    Friend WithEvents LblOfferID As Label
    Friend WithEvents txtOfferName As TextBox
    Friend WithEvents txtOfferDiscount As TextBox
    Friend WithEvents txtOfferID As TextBox
    Friend WithEvents txtAdminID As TextBox
    Friend WithEvents LblAdminDate As Label
    Friend WithEvents LblAdminID As Label
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents btnsearch As Button
    Friend WithEvents dtpAdminDate As DateTimePicker
    Friend WithEvents dtpOfferEndDate As DateTimePicker
    Friend WithEvents dtpOfferStartDate As DateTimePicker
    Friend WithEvents lblSeach As Label
    Friend WithEvents btnADD As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Backlbl As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
End Class
