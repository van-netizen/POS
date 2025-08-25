<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductCard
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        PictureBox1 = New PictureBox()
        lblname = New Label()
        lblPrice = New Label()
        lblDescription = New Label()
        lblCategory = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(19, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(204, 173)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' lblname
        ' 
        lblname.AutoSize = True
        lblname.Location = New Point(22, 219)
        lblname.Name = "lblname"
        lblname.Size = New Size(53, 20)
        lblname.TabIndex = 1
        lblname.Text = "Label1"
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.Location = New Point(22, 249)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(50, 20)
        lblPrice.TabIndex = 2
        lblPrice.Text = "label2"
        ' 
        ' lblDescription
        ' 
        lblDescription.AutoSize = True
        lblDescription.Location = New Point(19, 280)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(53, 20)
        lblDescription.TabIndex = 3
        lblDescription.Text = "Label3"
        ' 
        ' lblCategory
        ' 
        lblCategory.AutoSize = True
        lblCategory.Location = New Point(22, 188)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(53, 20)
        lblCategory.TabIndex = 4
        lblCategory.Text = "Label3"
        ' 
        ' ProductCard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(lblCategory)
        Controls.Add(lblDescription)
        Controls.Add(lblPrice)
        Controls.Add(lblname)
        Controls.Add(PictureBox1)
        Name = "ProductCard"
        Size = New Size(234, 317)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblname As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblCategory As Label

End Class
