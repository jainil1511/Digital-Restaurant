<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserHomePage
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
        Me.btnorderstatus = New System.Windows.Forms.Button()
        Me.btnoffer = New System.Windows.Forms.Button()
        Me.btnpayment = New System.Windows.Forms.Button()
        Me.btnmenu = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.logopb = New System.Windows.Forms.PictureBox()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.btnrestinfo = New System.Windows.Forms.Button()
        Me.btnfeedback = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.logopb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnorderstatus
        '
        Me.btnorderstatus.BackColor = System.Drawing.Color.Salmon
        Me.btnorderstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnorderstatus.Location = New System.Drawing.Point(0, 121)
        Me.btnorderstatus.Name = "btnorderstatus"
        Me.btnorderstatus.Size = New System.Drawing.Size(166, 53)
        Me.btnorderstatus.TabIndex = 7
        Me.btnorderstatus.Text = "Order Status"
        Me.btnorderstatus.UseVisualStyleBackColor = False
        '
        'btnoffer
        '
        Me.btnoffer.BackColor = System.Drawing.Color.Salmon
        Me.btnoffer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnoffer.Location = New System.Drawing.Point(0, 180)
        Me.btnoffer.Name = "btnoffer"
        Me.btnoffer.Size = New System.Drawing.Size(166, 50)
        Me.btnoffer.TabIndex = 6
        Me.btnoffer.Text = "Offer"
        Me.btnoffer.UseVisualStyleBackColor = False
        '
        'btnpayment
        '
        Me.btnpayment.BackColor = System.Drawing.Color.Salmon
        Me.btnpayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpayment.Location = New System.Drawing.Point(977, 62)
        Me.btnpayment.Name = "btnpayment"
        Me.btnpayment.Size = New System.Drawing.Size(146, 47)
        Me.btnpayment.TabIndex = 5
        Me.btnpayment.Text = "Payment"
        Me.btnpayment.UseVisualStyleBackColor = False
        '
        'btnmenu
        '
        Me.btnmenu.BackColor = System.Drawing.Color.Salmon
        Me.btnmenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmenu.Location = New System.Drawing.Point(0, 62)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(166, 53)
        Me.btnmenu.TabIndex = 2
        Me.btnmenu.Text = "Menu"
        Me.btnmenu.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Salmon
        Me.Panel1.Controls.Add(Me.logopb)
        Me.Panel1.Controls.Add(Me.lbltitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1126, 56)
        Me.Panel1.TabIndex = 2
        '
        'logopb
        '
        Me.logopb.BackColor = System.Drawing.Color.LightCoral
        Me.logopb.Image = Global.digitalR.My.Resources.Resources.th
        Me.logopb.Location = New System.Drawing.Point(54, 3)
        Me.logopb.Name = "logopb"
        Me.logopb.Size = New System.Drawing.Size(100, 47)
        Me.logopb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logopb.TabIndex = 4
        Me.logopb.TabStop = False
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.BackColor = System.Drawing.Color.Transparent
        Me.lbltitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbltitle.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.Black
        Me.lbltitle.Location = New System.Drawing.Point(405, 3)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(311, 42)
        Me.lbltitle.TabIndex = 11
        Me.lbltitle.Text = "Digital Restaurant"
        '
        'btnrestinfo
        '
        Me.btnrestinfo.BackColor = System.Drawing.Color.Salmon
        Me.btnrestinfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrestinfo.Location = New System.Drawing.Point(981, 180)
        Me.btnrestinfo.Name = "btnrestinfo"
        Me.btnrestinfo.Size = New System.Drawing.Size(142, 56)
        Me.btnrestinfo.TabIndex = 0
        Me.btnrestinfo.Text = "Restaurant Information"
        Me.btnrestinfo.UseVisualStyleBackColor = False
        '
        'btnfeedback
        '
        Me.btnfeedback.BackColor = System.Drawing.Color.Salmon
        Me.btnfeedback.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfeedback.Location = New System.Drawing.Point(977, 121)
        Me.btnfeedback.Name = "btnfeedback"
        Me.btnfeedback.Size = New System.Drawing.Size(146, 48)
        Me.btnfeedback.TabIndex = 12
        Me.btnfeedback.Text = "Feedback"
        Me.btnfeedback.UseVisualStyleBackColor = False
        '
        'UserHomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global.digitalR.My.Resources.Resources.le_champ_des_lunes_restaurant_gastronomique_au_coeur_du_luberon_fond_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1126, 487)
        Me.Controls.Add(Me.btnfeedback)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnpayment)
        Me.Controls.Add(Me.btnorderstatus)
        Me.Controls.Add(Me.btnmenu)
        Me.Controls.Add(Me.btnoffer)
        Me.Controls.Add(Me.btnrestinfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "UserHomePage"
        Me.Text = "UserHomePage"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.logopb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnorderstatus As System.Windows.Forms.Button
    Friend WithEvents btnoffer As System.Windows.Forms.Button
    Friend WithEvents btnpayment As System.Windows.Forms.Button
    Friend WithEvents btnmenu As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents btnrestinfo As System.Windows.Forms.Button
    Friend WithEvents logopb As System.Windows.Forms.PictureBox
    Friend WithEvents btnfeedback As System.Windows.Forms.Button
End Class
