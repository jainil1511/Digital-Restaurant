<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class category
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtCategorySearch = New System.Windows.Forms.TextBox()
        Me.btncategorySearch = New System.Windows.Forms.Button()
        Me.lblCategoryIDSearch = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtpCategoryAdminDate = New System.Windows.Forms.DateTimePicker()
        Me.lblCategoryAdminDate = New System.Windows.Forms.Label()
        Me.txtCategoryName = New System.Windows.Forms.TextBox()
        Me.txtCategoryAdminID = New System.Windows.Forms.TextBox()
        Me.txtCategoryAvailable = New System.Windows.Forms.TextBox()
        Me.txtCategoryID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCategoryAdminID = New System.Windows.Forms.Label()
        Me.lblCategoryName = New System.Windows.Forms.Label()
        Me.lblCategoryId = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCategoryUpdate = New System.Windows.Forms.Button()
        Me.btnCategoryClear = New System.Windows.Forms.Button()
        Me.btnCategoryDelete = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnCategoryLoad = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lnllblClose = New System.Windows.Forms.LinkLabel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.logopb = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.logopb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Salmon
        Me.Panel1.Controls.Add(Me.logopb)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(-5, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1324, 59)
        Me.Panel1.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(535, 17)
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
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(448, 150)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowRowErrors = False
        Me.DataGridView1.Size = New System.Drawing.Size(831, 321)
        Me.DataGridView1.TabIndex = 1
        Me.DataGridView1.VirtualMode = True
        '
        'txtCategorySearch
        '
        Me.txtCategorySearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCategorySearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategorySearch.Location = New System.Drawing.Point(663, 98)
        Me.txtCategorySearch.Multiline = True
        Me.txtCategorySearch.Name = "txtCategorySearch"
        Me.txtCategorySearch.Size = New System.Drawing.Size(238, 26)
        Me.txtCategorySearch.TabIndex = 16
        Me.txtCategorySearch.Tag = "Enter Category Name"
        '
        'btncategorySearch
        '
        Me.btncategorySearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btncategorySearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncategorySearch.Location = New System.Drawing.Point(988, 97)
        Me.btncategorySearch.Name = "btncategorySearch"
        Me.btncategorySearch.Size = New System.Drawing.Size(132, 32)
        Me.btncategorySearch.TabIndex = 17
        Me.btncategorySearch.Text = "Search"
        Me.btncategorySearch.UseVisualStyleBackColor = True
        '
        'lblCategoryIDSearch
        '
        Me.lblCategoryIDSearch.AutoSize = True
        Me.lblCategoryIDSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblCategoryIDSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoryIDSearch.Location = New System.Drawing.Point(448, 98)
        Me.lblCategoryIDSearch.Name = "lblCategoryIDSearch"
        Me.lblCategoryIDSearch.Size = New System.Drawing.Size(149, 20)
        Me.lblCategoryIDSearch.TabIndex = 18
        Me.lblCategoryIDSearch.Text = "Category Name Search"
        Me.lblCategoryIDSearch.UseCompatibleTextRendering = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dtpCategoryAdminDate)
        Me.Panel2.Controls.Add(Me.lblCategoryAdminDate)
        Me.Panel2.Controls.Add(Me.txtCategoryName)
        Me.Panel2.Controls.Add(Me.txtCategoryAdminID)
        Me.Panel2.Controls.Add(Me.txtCategoryAvailable)
        Me.Panel2.Controls.Add(Me.txtCategoryID)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.lblCategoryAdminID)
        Me.Panel2.Controls.Add(Me.lblCategoryName)
        Me.Panel2.Controls.Add(Me.lblCategoryId)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(25, 111)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(358, 436)
        Me.Panel2.TabIndex = 19
        '
        'dtpCategoryAdminDate
        '
        Me.dtpCategoryAdminDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCategoryAdminDate.Location = New System.Drawing.Point(138, 334)
        Me.dtpCategoryAdminDate.Name = "dtpCategoryAdminDate"
        Me.dtpCategoryAdminDate.Size = New System.Drawing.Size(199, 26)
        Me.dtpCategoryAdminDate.TabIndex = 5
        '
        'lblCategoryAdminDate
        '
        Me.lblCategoryAdminDate.AutoSize = True
        Me.lblCategoryAdminDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoryAdminDate.Location = New System.Drawing.Point(3, 334)
        Me.lblCategoryAdminDate.Name = "lblCategoryAdminDate"
        Me.lblCategoryAdminDate.Size = New System.Drawing.Size(103, 20)
        Me.lblCategoryAdminDate.TabIndex = 8
        Me.lblCategoryAdminDate.Text = "Admin Date"
        '
        'txtCategoryName
        '
        Me.txtCategoryName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoryName.Location = New System.Drawing.Point(135, 111)
        Me.txtCategoryName.Multiline = True
        Me.txtCategoryName.Name = "txtCategoryName"
        Me.txtCategoryName.Size = New System.Drawing.Size(202, 29)
        Me.txtCategoryName.TabIndex = 2
        '
        'txtCategoryAdminID
        '
        Me.txtCategoryAdminID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoryAdminID.Location = New System.Drawing.Point(135, 255)
        Me.txtCategoryAdminID.Multiline = True
        Me.txtCategoryAdminID.Name = "txtCategoryAdminID"
        Me.txtCategoryAdminID.Size = New System.Drawing.Size(202, 29)
        Me.txtCategoryAdminID.TabIndex = 4
        '
        'txtCategoryAvailable
        '
        Me.txtCategoryAvailable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoryAvailable.Location = New System.Drawing.Point(135, 184)
        Me.txtCategoryAvailable.Multiline = True
        Me.txtCategoryAvailable.Name = "txtCategoryAvailable"
        Me.txtCategoryAvailable.Size = New System.Drawing.Size(202, 29)
        Me.txtCategoryAvailable.TabIndex = 3
        '
        'txtCategoryID
        '
        Me.txtCategoryID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoryID.Location = New System.Drawing.Point(138, 34)
        Me.txtCategoryID.Multiline = True
        Me.txtCategoryID.Name = "txtCategoryID"
        Me.txtCategoryID.Size = New System.Drawing.Size(199, 29)
        Me.txtCategoryID.TabIndex = 1
        Me.txtCategoryID.Tag = "1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Available"
        '
        'lblCategoryAdminID
        '
        Me.lblCategoryAdminID.AutoSize = True
        Me.lblCategoryAdminID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoryAdminID.Location = New System.Drawing.Point(3, 256)
        Me.lblCategoryAdminID.Name = "lblCategoryAdminID"
        Me.lblCategoryAdminID.Size = New System.Drawing.Size(83, 20)
        Me.lblCategoryAdminID.TabIndex = 2
        Me.lblCategoryAdminID.Text = "Admin ID"
        '
        'lblCategoryName
        '
        Me.lblCategoryName.AutoSize = True
        Me.lblCategoryName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoryName.Location = New System.Drawing.Point(3, 112)
        Me.lblCategoryName.Name = "lblCategoryName"
        Me.lblCategoryName.Size = New System.Drawing.Size(116, 16)
        Me.lblCategoryName.TabIndex = 1
        Me.lblCategoryName.Text = "Category Name"
        '
        'lblCategoryId
        '
        Me.lblCategoryId.AutoSize = True
        Me.lblCategoryId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoryId.Location = New System.Drawing.Point(3, 35)
        Me.lblCategoryId.Name = "lblCategoryId"
        Me.lblCategoryId.Size = New System.Drawing.Size(90, 16)
        Me.lblCategoryId.TabIndex = 0
        Me.lblCategoryId.Text = "Category ID"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Snow
        Me.Panel3.Controls.Add(Me.btnCategoryUpdate)
        Me.Panel3.Controls.Add(Me.btnCategoryClear)
        Me.Panel3.Controls.Add(Me.btnCategoryDelete)
        Me.Panel3.Controls.Add(Me.btnadd)
        Me.Panel3.Controls.Add(Me.btnCategoryLoad)
        Me.Panel3.Location = New System.Drawing.Point(419, 495)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(860, 69)
        Me.Panel3.TabIndex = 20
        '
        'btnCategoryUpdate
        '
        Me.btnCategoryUpdate.AutoEllipsis = True
        Me.btnCategoryUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCategoryUpdate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCategoryUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnCategoryUpdate.FlatAppearance.BorderSize = 10
        Me.btnCategoryUpdate.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCategoryUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btnCategoryUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCategoryUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategoryUpdate.Location = New System.Drawing.Point(346, 14)
        Me.btnCategoryUpdate.Name = "btnCategoryUpdate"
        Me.btnCategoryUpdate.Size = New System.Drawing.Size(126, 38)
        Me.btnCategoryUpdate.TabIndex = 8
        Me.btnCategoryUpdate.Text = "UPDATE"
        Me.btnCategoryUpdate.UseVisualStyleBackColor = False
        '
        'btnCategoryClear
        '
        Me.btnCategoryClear.AutoEllipsis = True
        Me.btnCategoryClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCategoryClear.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCategoryClear.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnCategoryClear.FlatAppearance.BorderSize = 10
        Me.btnCategoryClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCategoryClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btnCategoryClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCategoryClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategoryClear.Location = New System.Drawing.Point(679, 14)
        Me.btnCategoryClear.Name = "btnCategoryClear"
        Me.btnCategoryClear.Size = New System.Drawing.Size(132, 38)
        Me.btnCategoryClear.TabIndex = 10
        Me.btnCategoryClear.Text = "CLEAR"
        Me.btnCategoryClear.UseVisualStyleBackColor = False
        '
        'btnCategoryDelete
        '
        Me.btnCategoryDelete.AutoEllipsis = True
        Me.btnCategoryDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCategoryDelete.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCategoryDelete.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnCategoryDelete.FlatAppearance.BorderSize = 10
        Me.btnCategoryDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCategoryDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btnCategoryDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCategoryDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategoryDelete.Location = New System.Drawing.Point(515, 14)
        Me.btnCategoryDelete.Name = "btnCategoryDelete"
        Me.btnCategoryDelete.Size = New System.Drawing.Size(133, 38)
        Me.btnCategoryDelete.TabIndex = 9
        Me.btnCategoryDelete.Text = "DELETE"
        Me.btnCategoryDelete.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.AutoEllipsis = True
        Me.btnadd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnadd.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnadd.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnadd.FlatAppearance.BorderSize = 10
        Me.btnadd.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnadd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btnadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(187, 14)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(124, 38)
        Me.btnadd.TabIndex = 7
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'btnCategoryLoad
        '
        Me.btnCategoryLoad.AutoEllipsis = True
        Me.btnCategoryLoad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCategoryLoad.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCategoryLoad.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnCategoryLoad.FlatAppearance.BorderSize = 10
        Me.btnCategoryLoad.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCategoryLoad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btnCategoryLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCategoryLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategoryLoad.Location = New System.Drawing.Point(17, 14)
        Me.btnCategoryLoad.Name = "btnCategoryLoad"
        Me.btnCategoryLoad.Size = New System.Drawing.Size(135, 38)
        Me.btnCategoryLoad.TabIndex = 6
        Me.btnCategoryLoad.Text = "LOAD"
        Me.btnCategoryLoad.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Salmon
        Me.Panel4.Controls.Add(Me.lnllblClose)
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Location = New System.Drawing.Point(-5, 570)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1324, 50)
        Me.Panel4.TabIndex = 21
        '
        'lnllblClose
        '
        Me.lnllblClose.AutoSize = True
        Me.lnllblClose.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lnllblClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnllblClose.Location = New System.Drawing.Point(628, 19)
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
        'logopb
        '
        Me.logopb.BackColor = System.Drawing.Color.LightCoral
        Me.logopb.Image = Global.digitalR.My.Resources.Resources.th
        Me.logopb.Location = New System.Drawing.Point(63, 3)
        Me.logopb.Name = "logopb"
        Me.logopb.Size = New System.Drawing.Size(100, 50)
        Me.logopb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logopb.TabIndex = 15
        Me.logopb.TabStop = False
        '
        'category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1323, 622)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblCategoryIDSearch)
        Me.Controls.Add(Me.btncategorySearch)
        Me.Controls.Add(Me.txtCategorySearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "category"
        Me.Text = "category"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.logopb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtCategorySearch As TextBox
    Friend WithEvents btncategorySearch As Button
    Friend WithEvents lblCategoryIDSearch As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtCategoryName As TextBox
    Friend WithEvents txtCategoryAdminID As TextBox
    Friend WithEvents txtCategoryAvailable As TextBox
    Friend WithEvents txtCategoryID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblCategoryAdminID As Label
    Friend WithEvents lblCategoryName As Label
    Friend WithEvents lblCategoryId As Label
    Friend WithEvents lblCategoryAdminDate As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnCategoryUpdate As Button
    Friend WithEvents btnCategoryClear As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents btnCategoryLoad As Button
    Friend WithEvents dtpCategoryAdminDate As DateTimePicker
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lnllblClose As LinkLabel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnCategoryDelete As Button
    Friend WithEvents logopb As PictureBox
End Class
