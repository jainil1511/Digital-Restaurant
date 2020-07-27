<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserMenuShow
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserMenuShow))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btncal = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Foodname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtExtraNote = New System.Windows.Forms.TextBox()
        Me.lblExtraNote = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txttablenumber = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnorder = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnOther = New System.Windows.Forms.Button()
        Me.btnGujrati = New System.Windows.Forms.Button()
        Me.btnPanjabi = New System.Windows.Forms.Button()
        Me.btnChiensese = New System.Windows.Forms.Button()
        Me.dtporderdate = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FooditemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodItemPhotoDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DigitalrDataSet = New digitalR.digitalrDataSet()
        Me.userSearch = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lnllblClose = New System.Windows.Forms.LinkLabel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.ItemTableAdapter = New digitalR.digitalrDataSetTableAdapters.ItemTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalrDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.btncal)
        Me.Panel1.Controls.Add(Me.DataGridView2)
        Me.Panel1.Controls.Add(Me.txtExtraNote)
        Me.Panel1.Controls.Add(Me.lblExtraNote)
        Me.Panel1.Controls.Add(Me.txttotal)
        Me.Panel1.Controls.Add(Me.txttablenumber)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnorder)
        Me.Panel1.Controls.Add(Me.btnRemove)
        Me.Panel1.Controls.Add(Me.txtUserName)
        Me.Panel1.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'btncal
        '
        Me.btncal.AutoEllipsis = True
        resources.ApplyResources(Me.btncal, "btncal")
        Me.btncal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btncal.FlatAppearance.BorderSize = 2
        Me.btncal.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btncal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btncal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btncal.Name = "btncal"
        Me.btncal.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Foodname, Me.Price, Me.Quantity, Me.total})
        resources.ApplyResources(Me.DataGridView2, "DataGridView2")
        Me.DataGridView2.Name = "DataGridView2"
        '
        'Foodname
        '
        resources.ApplyResources(Me.Foodname, "Foodname")
        Me.Foodname.Name = "Foodname"
        '
        'Price
        '
        resources.ApplyResources(Me.Price, "Price")
        Me.Price.Name = "Price"
        '
        'Quantity
        '
        Me.Quantity.FillWeight = 70.0!
        resources.ApplyResources(Me.Quantity, "Quantity")
        Me.Quantity.Name = "Quantity"
        '
        'total
        '
        resources.ApplyResources(Me.total, "total")
        Me.total.Name = "total"
        '
        'txtExtraNote
        '
        resources.ApplyResources(Me.txtExtraNote, "txtExtraNote")
        Me.txtExtraNote.Name = "txtExtraNote"
        '
        'lblExtraNote
        '
        resources.ApplyResources(Me.lblExtraNote, "lblExtraNote")
        Me.lblExtraNote.Name = "lblExtraNote"
        '
        'txttotal
        '
        resources.ApplyResources(Me.txttotal, "txttotal")
        Me.txttotal.Name = "txttotal"
        '
        'txttablenumber
        '
        resources.ApplyResources(Me.txttablenumber, "txttablenumber")
        Me.txttablenumber.Name = "txttablenumber"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'btnorder
        '
        Me.btnorder.AutoEllipsis = True
        resources.ApplyResources(Me.btnorder, "btnorder")
        Me.btnorder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnorder.FlatAppearance.BorderSize = 2
        Me.btnorder.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnorder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnorder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnorder.Name = "btnorder"
        Me.btnorder.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.AutoEllipsis = True
        resources.ApplyResources(Me.btnRemove, "btnRemove")
        Me.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRemove.FlatAppearance.BorderSize = 2
        Me.btnRemove.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'txtUserName
        '
        resources.ApplyResources(Me.txtUserName, "txtUserName")
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.ReadOnly = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.dtporderdate)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.userSearch)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Snow
        Me.Panel4.Controls.Add(Me.btnOther)
        Me.Panel4.Controls.Add(Me.btnGujrati)
        Me.Panel4.Controls.Add(Me.btnPanjabi)
        Me.Panel4.Controls.Add(Me.btnChiensese)
        resources.ApplyResources(Me.Panel4, "Panel4")
        Me.Panel4.Name = "Panel4"
        '
        'btnOther
        '
        Me.btnOther.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnOther.FlatAppearance.BorderSize = 17
        resources.ApplyResources(Me.btnOther, "btnOther")
        Me.btnOther.Name = "btnOther"
        Me.btnOther.UseVisualStyleBackColor = False
        '
        'btnGujrati
        '
        Me.btnGujrati.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnGujrati.FlatAppearance.BorderSize = 17
        resources.ApplyResources(Me.btnGujrati, "btnGujrati")
        Me.btnGujrati.Name = "btnGujrati"
        Me.btnGujrati.UseVisualStyleBackColor = False
        '
        'btnPanjabi
        '
        Me.btnPanjabi.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnPanjabi.FlatAppearance.BorderSize = 17
        resources.ApplyResources(Me.btnPanjabi, "btnPanjabi")
        Me.btnPanjabi.Name = "btnPanjabi"
        Me.btnPanjabi.UseVisualStyleBackColor = False
        '
        'btnChiensese
        '
        resources.ApplyResources(Me.btnChiensese, "btnChiensese")
        Me.btnChiensese.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnChiensese.FlatAppearance.BorderSize = 17
        Me.btnChiensese.Name = "btnChiensese"
        Me.btnChiensese.UseVisualStyleBackColor = False
        '
        'dtporderdate
        '
        resources.ApplyResources(Me.dtporderdate, "dtporderdate")
        Me.dtporderdate.Name = "dtporderdate"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FooditemName, Me.Rate, Me.FoodDescription, Me.FoodItemPhotoDataGridViewImageColumn})
        Me.DataGridView1.DataSource = Me.ItemBindingSource
        resources.ApplyResources(Me.DataGridView1, "DataGridView1")
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'FooditemName
        '
        Me.FooditemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FooditemName.DataPropertyName = "fooditemName"
        Me.FooditemName.Frozen = True
        resources.ApplyResources(Me.FooditemName, "FooditemName")
        Me.FooditemName.Name = "FooditemName"
        Me.FooditemName.ReadOnly = True
        '
        'Rate
        '
        Me.Rate.DataPropertyName = "rate"
        resources.ApplyResources(Me.Rate, "Rate")
        Me.Rate.Name = "Rate"
        Me.Rate.ReadOnly = True
        '
        'FoodDescription
        '
        Me.FoodDescription.DataPropertyName = "FoodDescription"
        resources.ApplyResources(Me.FoodDescription, "FoodDescription")
        Me.FoodDescription.Name = "FoodDescription"
        Me.FoodDescription.ReadOnly = True
        '
        'FoodItemPhotoDataGridViewImageColumn
        '
        Me.FoodItemPhotoDataGridViewImageColumn.DataPropertyName = "FoodItemPhoto"
        resources.ApplyResources(Me.FoodItemPhotoDataGridViewImageColumn, "FoodItemPhotoDataGridViewImageColumn")
        Me.FoodItemPhotoDataGridViewImageColumn.Name = "FoodItemPhotoDataGridViewImageColumn"
        Me.FoodItemPhotoDataGridViewImageColumn.ReadOnly = True
        '
        'ItemBindingSource
        '
        Me.ItemBindingSource.DataMember = "Item"
        Me.ItemBindingSource.DataSource = Me.DigitalrDataSet
        '
        'DigitalrDataSet
        '
        Me.DigitalrDataSet.DataSetName = "digitalrDataSet"
        Me.DigitalrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'userSearch
        '
        resources.ApplyResources(Me.userSearch, "userSearch")
        Me.userSearch.Name = "userSearch"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Salmon
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.Label2)
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.Name = "Panel3"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LightCoral
        Me.PictureBox1.Image = Global.digitalR.My.Resources.Resources.th
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Salmon
        Me.Panel5.Controls.Add(Me.lnllblClose)
        Me.Panel5.Controls.Add(Me.Panel6)
        resources.ApplyResources(Me.Panel5, "Panel5")
        Me.Panel5.Name = "Panel5"
        '
        'lnllblClose
        '
        resources.ApplyResources(Me.lnllblClose, "lnllblClose")
        Me.lnllblClose.Name = "lnllblClose"
        Me.lnllblClose.TabStop = True
        '
        'Panel6
        '
        resources.ApplyResources(Me.Panel6, "Panel6")
        Me.Panel6.Name = "Panel6"
        '
        'ItemTableAdapter
        '
        Me.ItemTableAdapter.ClearBeforeFill = True
        '
        'UserMenuShow
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        resources.ApplyResources(Me, "$this")
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Name = "UserMenuShow"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalrDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lnllblClose As LinkLabel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents btnorder As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnChiensese As Button
    Friend WithEvents btnGujrati As Button
    Friend WithEvents btnOther As Button
    Friend WithEvents btnPanjabi As Button
    Friend WithEvents userSearch As TextBox
    Friend WithEvents txttablenumber As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txttotal As TextBox
    Friend WithEvents dtporderdate As DateTimePicker
    Friend WithEvents lblExtraNote As Label
    Friend WithEvents txtExtraNote As TextBox
    Friend WithEvents DigitalrDataSet As digitalrDataSet
    Friend WithEvents ItemBindingSource As BindingSource
    Friend WithEvents ItemTableAdapter As digitalrDataSetTableAdapters.ItemTableAdapter
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents btncal As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents FooditemName As DataGridViewTextBoxColumn
    Friend WithEvents Rate As DataGridViewTextBoxColumn
    Friend WithEvents FoodDescription As DataGridViewTextBoxColumn
    Friend WithEvents FoodItemPhotoDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents Foodname As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
