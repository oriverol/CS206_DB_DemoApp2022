<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class insertProduct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(insertProduct))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.usernameLbl = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.prodNameTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.prodDescTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.prodPriceTxt = New System.Windows.Forms.TextBox()
        Me.insertBtn = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel2.Controls.Add(Me.usernameLbl)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(591, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(194, 50)
        Me.Panel2.TabIndex = 27
        '
        'usernameLbl
        '
        Me.usernameLbl.AutoSize = True
        Me.usernameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameLbl.ForeColor = System.Drawing.Color.Black
        Me.usernameLbl.Location = New System.Drawing.Point(75, 15)
        Me.usernameLbl.Name = "usernameLbl"
        Me.usernameLbl.Size = New System.Drawing.Size(0, 20)
        Me.usernameLbl.TabIndex = 22
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(28, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(584, 50)
        Me.Panel1.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(2, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Insert Product"
        '
        'prodNameTxt
        '
        Me.prodNameTxt.Location = New System.Drawing.Point(196, 90)
        Me.prodNameTxt.MaxLength = 50
        Me.prodNameTxt.Name = "prodNameTxt"
        Me.prodNameTxt.Size = New System.Drawing.Size(161, 20)
        Me.prodNameTxt.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 20)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Product Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 20)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Product Description:"
        '
        'prodDescTxt
        '
        Me.prodDescTxt.Location = New System.Drawing.Point(196, 134)
        Me.prodDescTxt.MaxLength = 250
        Me.prodDescTxt.Name = "prodDescTxt"
        Me.prodDescTxt.Size = New System.Drawing.Size(463, 20)
        Me.prodDescTxt.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 20)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Product Price:"
        '
        'prodPriceTxt
        '
        Me.prodPriceTxt.Location = New System.Drawing.Point(196, 178)
        Me.prodPriceTxt.MaxLength = 7
        Me.prodPriceTxt.Name = "prodPriceTxt"
        Me.prodPriceTxt.Size = New System.Drawing.Size(107, 20)
        Me.prodPriceTxt.TabIndex = 32
        '
        'insertBtn
        '
        Me.insertBtn.Location = New System.Drawing.Point(196, 245)
        Me.insertBtn.Name = "insertBtn"
        Me.insertBtn.Size = New System.Drawing.Size(75, 23)
        Me.insertBtn.TabIndex = 34
        Me.insertBtn.Text = "Insert"
        Me.insertBtn.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.insertBtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.prodPriceTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.prodDescTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.prodNameTxt)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents usernameLbl As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents prodNameTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents prodDescTxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents prodPriceTxt As TextBox
    Friend WithEvents insertBtn As Button
End Class
