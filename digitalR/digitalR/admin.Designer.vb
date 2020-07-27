<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnregister = New System.Windows.Forms.Button()
        Me.btndailyreport = New System.Windows.Forms.Button()
        Me.btnorderdetails = New System.Windows.Forms.Button()
        Me.btnoffer = New System.Windows.Forms.Button()
        Me.btnpayment = New System.Windows.Forms.Button()
        Me.btnstaff = New System.Windows.Forms.Button()
        Me.btnmenu = New System.Windows.Forms.Button()
        Me.btncategory = New System.Windows.Forms.Button()
        Me.btnrestinfo = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblAdminDashBoard = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Salmon
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(2, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1253, 65)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(486, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(280, 36)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Digital Restautrant"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LightCoral
        Me.PictureBox1.Image = Global.digitalR.My.Resources.Resources.th
        Me.PictureBox1.Location = New System.Drawing.Point(21, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'btnregister
        '
        Me.btnregister.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnregister.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregister.Location = New System.Drawing.Point(0, 5)
        Me.btnregister.Name = "btnregister"
        Me.btnregister.Size = New System.Drawing.Size(178, 46)
        Me.btnregister.TabIndex = 23
        Me.btnregister.Text = "Register"
        Me.btnregister.UseVisualStyleBackColor = False
        '
        'btndailyreport
        '
        Me.btndailyreport.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btndailyreport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndailyreport.Location = New System.Drawing.Point(2, 242)
        Me.btndailyreport.Name = "btndailyreport"
        Me.btndailyreport.Size = New System.Drawing.Size(167, 42)
        Me.btndailyreport.TabIndex = 21
        Me.btndailyreport.Text = "Daily Report"
        Me.btndailyreport.UseVisualStyleBackColor = False
        '
        'btnorderdetails
        '
        Me.btnorderdetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnorderdetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnorderdetails.Location = New System.Drawing.Point(1083, 3)
        Me.btnorderdetails.Name = "btnorderdetails"
        Me.btnorderdetails.Size = New System.Drawing.Size(178, 46)
        Me.btnorderdetails.TabIndex = 20
        Me.btnorderdetails.Text = "Order Details"
        Me.btnorderdetails.UseVisualStyleBackColor = False
        '
        'btnoffer
        '
        Me.btnoffer.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnoffer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnoffer.Location = New System.Drawing.Point(2, 182)
        Me.btnoffer.Name = "btnoffer"
        Me.btnoffer.Size = New System.Drawing.Size(178, 46)
        Me.btnoffer.TabIndex = 19
        Me.btnoffer.Text = "Offer"
        Me.btnoffer.UseVisualStyleBackColor = False
        '
        'btnpayment
        '
        Me.btnpayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnpayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpayment.Location = New System.Drawing.Point(1085, 125)
        Me.btnpayment.Name = "btnpayment"
        Me.btnpayment.Size = New System.Drawing.Size(167, 43)
        Me.btnpayment.TabIndex = 18
        Me.btnpayment.Text = "Payment"
        Me.btnpayment.UseVisualStyleBackColor = False
        '
        'btnstaff
        '
        Me.btnstaff.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnstaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstaff.Location = New System.Drawing.Point(1091, 182)
        Me.btnstaff.Name = "btnstaff"
        Me.btnstaff.Size = New System.Drawing.Size(164, 46)
        Me.btnstaff.TabIndex = 17
        Me.btnstaff.Text = "Staff Details"
        Me.btnstaff.UseVisualStyleBackColor = False
        '
        'btnmenu
        '
        Me.btnmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnmenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmenu.Location = New System.Drawing.Point(2, 125)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(178, 46)
        Me.btnmenu.TabIndex = 16
        Me.btnmenu.Text = "Menu"
        Me.btnmenu.UseVisualStyleBackColor = False
        '
        'btncategory
        '
        Me.btncategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btncategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncategory.Location = New System.Drawing.Point(2, 300)
        Me.btncategory.Name = "btncategory"
        Me.btncategory.Size = New System.Drawing.Size(169, 48)
        Me.btncategory.TabIndex = 15
        Me.btncategory.Text = "Category"
        Me.btncategory.UseVisualStyleBackColor = False
        '
        'btnrestinfo
        '
        Me.btnrestinfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnrestinfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrestinfo.Location = New System.Drawing.Point(1088, 242)
        Me.btnrestinfo.Name = "btnrestinfo"
        Me.btnrestinfo.Size = New System.Drawing.Size(164, 52)
        Me.btnrestinfo.TabIndex = 14
        Me.btnrestinfo.Text = "Restaurant Information"
        Me.btnrestinfo.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.lblAdminDashBoard)
        Me.Panel2.Controls.Add(Me.btnregister)
        Me.Panel2.Controls.Add(Me.btnorderdetails)
        Me.Panel2.Location = New System.Drawing.Point(2, 65)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1253, 54)
        Me.Panel2.TabIndex = 25
        '
        'lblAdminDashBoard
        '
        Me.lblAdminDashBoard.AutoSize = True
        Me.lblAdminDashBoard.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdminDashBoard.Location = New System.Drawing.Point(535, 15)
        Me.lblAdminDashBoard.Name = "lblAdminDashBoard"
        Me.lblAdminDashBoard.Size = New System.Drawing.Size(178, 24)
        Me.lblAdminDashBoard.TabIndex = 0
        Me.lblAdminDashBoard.Text = "Admin DashBoard"
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.digitalR.My.Resources.Resources.le_champ_des_lunes_restaurant_gastronomique_au_coeur_du_luberon_fond_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1257, 599)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btncategory)
        Me.Controls.Add(Me.btnrestinfo)
        Me.Controls.Add(Me.btndailyreport)
        Me.Controls.Add(Me.btnmenu)
        Me.Controls.Add(Me.btnstaff)
        Me.Controls.Add(Me.btnoffer)
        Me.Controls.Add(Me.btnpayment)
        Me.Name = "Admin"
        Me.Text = "Admin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnregister As Button
    Friend WithEvents btndailyreport As Button
    Friend WithEvents btnorderdetails As Button
    Friend WithEvents btnoffer As Button
    Friend WithEvents btnpayment As Button
    Friend WithEvents btnstaff As Button
    Friend WithEvents btnmenu As Button
    Friend WithEvents btncategory As Button
    Friend WithEvents btnrestinfo As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblAdminDashBoard As Label
End Class
