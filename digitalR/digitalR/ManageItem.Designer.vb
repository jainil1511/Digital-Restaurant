<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManageItem
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ID = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.dtpFoodIAdminDate = New System.Windows.Forms.DateTimePicker()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtFoodAdminID = New System.Windows.Forms.TextBox()
        Me.lblfoodAdminDate = New System.Windows.Forms.Label()
        Me.lblAdminId = New System.Windows.Forms.Label()
        Me.pcbItem = New System.Windows.Forms.PictureBox()
        Me.lblItempicture = New System.Windows.Forms.Label()
        Me.txtFoodStatus = New System.Windows.Forms.TextBox()
        Me.lblItemStatus = New System.Windows.Forms.Label()
        Me.txtCategoryID = New System.Windows.Forms.TextBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.txtFoodDescription = New System.Windows.Forms.TextBox()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.txtFoodItem = New System.Windows.Forms.TextBox()
        Me.lblItemRate = New System.Windows.Forms.Label()
        Me.lblItemDescription = New System.Windows.Forms.Label()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.lblItemID = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtfoodSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lnllblClose = New System.Windows.Forms.LinkLabel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnStaffUpdate = New System.Windows.Forms.Button()
        Me.btnStaffDelete = New System.Windows.Forms.Button()
        Me.btnStaffClear = New System.Windows.Forms.Button()
        Me.btnItemAdd = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnStaffLoad = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pcbItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridView1.Location = New System.Drawing.Point(418, 134)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.RowTemplate.DividerHeight = 1
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(941, 473)
        Me.DataGridView1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ID)
        Me.Panel1.Controls.Add(Me.txtID)
        Me.Panel1.Controls.Add(Me.dtpFoodIAdminDate)
        Me.Panel1.Controls.Add(Me.btnBrowse)
        Me.Panel1.Controls.Add(Me.txtFoodAdminID)
        Me.Panel1.Controls.Add(Me.lblfoodAdminDate)
        Me.Panel1.Controls.Add(Me.lblAdminId)
        Me.Panel1.Controls.Add(Me.pcbItem)
        Me.Panel1.Controls.Add(Me.lblItempicture)
        Me.Panel1.Controls.Add(Me.txtFoodStatus)
        Me.Panel1.Controls.Add(Me.lblItemStatus)
        Me.Panel1.Controls.Add(Me.txtCategoryID)
        Me.Panel1.Controls.Add(Me.lblCategory)
        Me.Panel1.Controls.Add(Me.txtRate)
        Me.Panel1.Controls.Add(Me.txtFoodDescription)
        Me.Panel1.Controls.Add(Me.txtItemName)
        Me.Panel1.Controls.Add(Me.txtFoodItem)
        Me.Panel1.Controls.Add(Me.lblItemRate)
        Me.Panel1.Controls.Add(Me.lblItemDescription)
        Me.Panel1.Controls.Add(Me.lblItemName)
        Me.Panel1.Controls.Add(Me.lblItemID)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(6, 74)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(406, 613)
        Me.Panel1.TabIndex = 1
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID.Location = New System.Drawing.Point(6, 15)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(29, 18)
        Me.ID.TabIndex = 21
        Me.ID.Text = " ID"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(176, 16)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(186, 22)
        Me.txtID.TabIndex = 20
        '
        'dtpFoodIAdminDate
        '
        Me.dtpFoodIAdminDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFoodIAdminDate.Location = New System.Drawing.Point(176, 576)
        Me.dtpFoodIAdminDate.Name = "dtpFoodIAdminDate"
        Me.dtpFoodIAdminDate.Size = New System.Drawing.Size(200, 22)
        Me.dtpFoodIAdminDate.TabIndex = 19
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(207, 359)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(128, 34)
        Me.btnBrowse.TabIndex = 18
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtFoodAdminID
        '
        Me.txtFoodAdminID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFoodAdminID.Location = New System.Drawing.Point(176, 534)
        Me.txtFoodAdminID.Name = "txtFoodAdminID"
        Me.txtFoodAdminID.Size = New System.Drawing.Size(184, 22)
        Me.txtFoodAdminID.TabIndex = 16
        '
        'lblfoodAdminDate
        '
        Me.lblfoodAdminDate.AutoSize = True
        Me.lblfoodAdminDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfoodAdminDate.Location = New System.Drawing.Point(11, 578)
        Me.lblfoodAdminDate.Name = "lblfoodAdminDate"
        Me.lblfoodAdminDate.Size = New System.Drawing.Size(94, 18)
        Me.lblfoodAdminDate.TabIndex = 15
        Me.lblfoodAdminDate.Text = "Admin Date"
        '
        'lblAdminId
        '
        Me.lblAdminId.AutoSize = True
        Me.lblAdminId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdminId.Location = New System.Drawing.Point(11, 533)
        Me.lblAdminId.Name = "lblAdminId"
        Me.lblAdminId.Size = New System.Drawing.Size(70, 18)
        Me.lblAdminId.TabIndex = 14
        Me.lblAdminId.Text = "AdminID"
        '
        'pcbItem
        '
        Me.pcbItem.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pcbItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pcbItem.Location = New System.Drawing.Point(156, 230)
        Me.pcbItem.Name = "pcbItem"
        Me.pcbItem.Size = New System.Drawing.Size(239, 123)
        Me.pcbItem.TabIndex = 13
        Me.pcbItem.TabStop = False
        Me.pcbItem.WaitOnLoad = True
        '
        'lblItempicture
        '
        Me.lblItempicture.AutoSize = True
        Me.lblItempicture.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItempicture.Location = New System.Drawing.Point(6, 230)
        Me.lblItempicture.Name = "lblItempicture"
        Me.lblItempicture.Size = New System.Drawing.Size(90, 18)
        Me.lblItempicture.TabIndex = 12
        Me.lblItempicture.Text = "Item Photo"
        '
        'txtFoodStatus
        '
        Me.txtFoodStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFoodStatus.Location = New System.Drawing.Point(176, 494)
        Me.txtFoodStatus.Name = "txtFoodStatus"
        Me.txtFoodStatus.Size = New System.Drawing.Size(184, 22)
        Me.txtFoodStatus.TabIndex = 11
        '
        'lblItemStatus
        '
        Me.lblItemStatus.AutoSize = True
        Me.lblItemStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemStatus.Location = New System.Drawing.Point(6, 494)
        Me.lblItemStatus.Name = "lblItemStatus"
        Me.lblItemStatus.Size = New System.Drawing.Size(56, 18)
        Me.lblItemStatus.TabIndex = 10
        Me.lblItemStatus.Text = "Status"
        '
        'txtCategoryID
        '
        Me.txtCategoryID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoryID.Location = New System.Drawing.Point(174, 449)
        Me.txtCategoryID.Name = "txtCategoryID"
        Me.txtCategoryID.Size = New System.Drawing.Size(186, 22)
        Me.txtCategoryID.TabIndex = 9
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.Location = New System.Drawing.Point(6, 449)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(97, 18)
        Me.lblCategory.TabIndex = 8
        Me.lblCategory.Text = "Category ID"
        '
        'txtRate
        '
        Me.txtRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.Location = New System.Drawing.Point(174, 399)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(188, 22)
        Me.txtRate.TabIndex = 7
        '
        'txtFoodDescription
        '
        Me.txtFoodDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFoodDescription.Location = New System.Drawing.Point(176, 138)
        Me.txtFoodDescription.Multiline = True
        Me.txtFoodDescription.Name = "txtFoodDescription"
        Me.txtFoodDescription.Size = New System.Drawing.Size(194, 75)
        Me.txtFoodDescription.TabIndex = 6
        '
        'txtItemName
        '
        Me.txtItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemName.Location = New System.Drawing.Point(174, 97)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(196, 22)
        Me.txtItemName.TabIndex = 5
        '
        'txtFoodItem
        '
        Me.txtFoodItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFoodItem.Location = New System.Drawing.Point(176, 51)
        Me.txtFoodItem.Name = "txtFoodItem"
        Me.txtFoodItem.Size = New System.Drawing.Size(186, 22)
        Me.txtFoodItem.TabIndex = 4
        '
        'lblItemRate
        '
        Me.lblItemRate.AutoSize = True
        Me.lblItemRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemRate.Location = New System.Drawing.Point(6, 401)
        Me.lblItemRate.Name = "lblItemRate"
        Me.lblItemRate.Size = New System.Drawing.Size(43, 18)
        Me.lblItemRate.TabIndex = 3
        Me.lblItemRate.Text = "Rate"
        '
        'lblItemDescription
        '
        Me.lblItemDescription.AutoSize = True
        Me.lblItemDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemDescription.Location = New System.Drawing.Point(6, 137)
        Me.lblItemDescription.Name = "lblItemDescription"
        Me.lblItemDescription.Size = New System.Drawing.Size(138, 18)
        Me.lblItemDescription.TabIndex = 2
        Me.lblItemDescription.Text = "Food Description"
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.Location = New System.Drawing.Point(6, 96)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(89, 18)
        Me.lblItemName.TabIndex = 1
        Me.lblItemName.Text = "Item Name"
        '
        'lblItemID
        '
        Me.lblItemID.AutoSize = True
        Me.lblItemID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemID.Location = New System.Drawing.Point(6, 51)
        Me.lblItemID.Name = "lblItemID"
        Me.lblItemID.Size = New System.Drawing.Size(61, 18)
        Me.lblItemID.TabIndex = 0
        Me.lblItemID.Text = "Item ID"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Salmon
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Location = New System.Drawing.Point(3, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1356, 59)
        Me.Panel4.TabIndex = 11
        '
        'Panel5
        '
        Me.Panel5.Location = New System.Drawing.Point(3, 62)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(200, 100)
        Me.Panel5.TabIndex = 9
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.LightSalmon
        Me.PictureBox2.Location = New System.Drawing.Point(62, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(532, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Digital Restautrant"
        '
        'txtfoodSearch
        '
        Me.txtfoodSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfoodSearch.Location = New System.Drawing.Point(773, 82)
        Me.txtfoodSearch.Multiline = True
        Me.txtfoodSearch.Name = "txtfoodSearch"
        Me.txtfoodSearch.Size = New System.Drawing.Size(205, 25)
        Me.txtfoodSearch.TabIndex = 14
        '
        'btnSearch
        '
        Me.btnSearch.AutoEllipsis = True
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSearch.FlatAppearance.BorderSize = 2
        Me.btnSearch.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(1076, 76)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(136, 34)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.Location = New System.Drawing.Point(537, 82)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(132, 20)
        Me.lblSearch.TabIndex = 15
        Me.lblSearch.Text = "Search By Item"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Salmon
        Me.Panel3.Controls.Add(Me.lnllblClose)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Location = New System.Drawing.Point(3, 693)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1356, 50)
        Me.Panel3.TabIndex = 16
        '
        'lnllblClose
        '
        Me.lnllblClose.AutoSize = True
        Me.lnllblClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnllblClose.Location = New System.Drawing.Point(648, 15)
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
        'btnStaffUpdate
        '
        Me.btnStaffUpdate.AutoEllipsis = True
        Me.btnStaffUpdate.BackColor = System.Drawing.Color.Snow
        Me.btnStaffUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnStaffUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStaffUpdate.FlatAppearance.BorderSize = 20
        Me.btnStaffUpdate.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnStaffUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnStaffUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnStaffUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStaffUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaffUpdate.Location = New System.Drawing.Point(336, 15)
        Me.btnStaffUpdate.Name = "btnStaffUpdate"
        Me.btnStaffUpdate.Size = New System.Drawing.Size(141, 32)
        Me.btnStaffUpdate.TabIndex = 1
        Me.btnStaffUpdate.Text = "UPDATE"
        Me.btnStaffUpdate.UseVisualStyleBackColor = False
        '
        'btnStaffDelete
        '
        Me.btnStaffDelete.AutoEllipsis = True
        Me.btnStaffDelete.BackColor = System.Drawing.Color.Snow
        Me.btnStaffDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnStaffDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStaffDelete.FlatAppearance.BorderSize = 20
        Me.btnStaffDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnStaffDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnStaffDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnStaffDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStaffDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaffDelete.Location = New System.Drawing.Point(513, 15)
        Me.btnStaffDelete.Name = "btnStaffDelete"
        Me.btnStaffDelete.Size = New System.Drawing.Size(137, 32)
        Me.btnStaffDelete.TabIndex = 2
        Me.btnStaffDelete.Text = "DELETE"
        Me.btnStaffDelete.UseVisualStyleBackColor = False
        '
        'btnStaffClear
        '
        Me.btnStaffClear.AutoEllipsis = True
        Me.btnStaffClear.BackColor = System.Drawing.Color.Snow
        Me.btnStaffClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnStaffClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStaffClear.FlatAppearance.BorderSize = 20
        Me.btnStaffClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnStaffClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnStaffClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnStaffClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStaffClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaffClear.Location = New System.Drawing.Point(678, 15)
        Me.btnStaffClear.Name = "btnStaffClear"
        Me.btnStaffClear.Size = New System.Drawing.Size(139, 32)
        Me.btnStaffClear.TabIndex = 4
        Me.btnStaffClear.Text = "CLEAR"
        Me.btnStaffClear.UseVisualStyleBackColor = False
        '
        'btnItemAdd
        '
        Me.btnItemAdd.AutoEllipsis = True
        Me.btnItemAdd.BackColor = System.Drawing.Color.Snow
        Me.btnItemAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnItemAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnItemAdd.FlatAppearance.BorderSize = 20
        Me.btnItemAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnItemAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnItemAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnItemAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnItemAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItemAdd.Location = New System.Drawing.Point(167, 15)
        Me.btnItemAdd.Name = "btnItemAdd"
        Me.btnItemAdd.Size = New System.Drawing.Size(141, 32)
        Me.btnItemAdd.TabIndex = 5
        Me.btnItemAdd.Text = "ADD"
        Me.btnItemAdd.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnItemAdd)
        Me.Panel2.Controls.Add(Me.btnStaffClear)
        Me.Panel2.Controls.Add(Me.btnStaffLoad)
        Me.Panel2.Controls.Add(Me.btnStaffDelete)
        Me.Panel2.Controls.Add(Me.btnStaffUpdate)
        Me.Panel2.Location = New System.Drawing.Point(462, 615)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(858, 57)
        Me.Panel2.TabIndex = 13
        '
        'btnStaffLoad
        '
        Me.btnStaffLoad.AutoEllipsis = True
        Me.btnStaffLoad.BackColor = System.Drawing.Color.Snow
        Me.btnStaffLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnStaffLoad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStaffLoad.FlatAppearance.BorderSize = 20
        Me.btnStaffLoad.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnStaffLoad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnStaffLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnStaffLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStaffLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaffLoad.Location = New System.Drawing.Point(18, 13)
        Me.btnStaffLoad.Name = "btnStaffLoad"
        Me.btnStaffLoad.Size = New System.Drawing.Size(123, 37)
        Me.btnStaffLoad.TabIndex = 3
        Me.btnStaffLoad.Text = "LOAD"
        Me.btnStaffLoad.UseVisualStyleBackColor = False
        '
        'ManageItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtfoodSearch)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ManageItem"
        Me.Text = "ManageItem"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pcbItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtfoodSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblSearch As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lnllblClose As LinkLabel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnStaffUpdate As Button
    Friend WithEvents btnStaffDelete As Button
    Friend WithEvents btnStaffClear As Button
    Friend WithEvents btnItemAdd As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnStaffLoad As Button
    Friend WithEvents txtRate As TextBox
    Friend WithEvents txtFoodDescription As TextBox
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents txtFoodItem As TextBox
    Friend WithEvents lblItemRate As Label
    Friend WithEvents lblItemDescription As Label
    Friend WithEvents lblItemName As Label
    Friend WithEvents lblItemID As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents txtCategoryID As TextBox
    Friend WithEvents lblItemStatus As Label
    Friend WithEvents txtFoodStatus As TextBox
    Friend WithEvents pcbItem As PictureBox
    Friend WithEvents lblItempicture As Label
    Friend WithEvents lblfoodAdminDate As Label
    Friend WithEvents lblAdminId As Label
    Friend WithEvents txtFoodAdminID As TextBox
    Friend WithEvents dtpFoodIAdminDate As DateTimePicker
    Friend WithEvents ID As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents btnBrowse As Button
End Class
