<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Guna2ContextMenuStrip1 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        txt_username = New Guna.UI2.WinForms.Guna2TextBox()
        txt_password = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(276, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(123, 20)
        Label1.TabIndex = 0
        Label1.Text = "ACCOUNT LOGIN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(96, 128)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 20)
        Label2.TabIndex = 1
        Label2.Text = "USERNAME"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(96, 185)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 20)
        Label3.TabIndex = 2
        Label3.Text = "PASSWORD"
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.CustomizableEdges = CustomizableEdges1
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.Font = New Font("Segoe UI", 9F)
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.Location = New Point(405, 276)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button1.Size = New Size(225, 56)
        Guna2Button1.TabIndex = 3
        Guna2Button1.Text = "LOGIN"
        ' 
        ' Guna2ContextMenuStrip1
        ' 
        Guna2ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        Guna2ContextMenuStrip1.Name = "Guna2ContextMenuStrip1"
        Guna2ContextMenuStrip1.RenderStyle.ArrowColor = Color.FromArgb(CByte(151), CByte(143), CByte(255))
        Guna2ContextMenuStrip1.RenderStyle.BorderColor = Color.Gainsboro
        Guna2ContextMenuStrip1.RenderStyle.ColorTable = Nothing
        Guna2ContextMenuStrip1.RenderStyle.RoundedEdges = True
        Guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = Color.White
        Guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        Guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = Color.White
        Guna2ContextMenuStrip1.RenderStyle.SeparatorColor = Color.Gainsboro
        Guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = Drawing.Text.TextRenderingHint.SystemDefault
        Guna2ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' txt_username
        ' 
        txt_username.CustomizableEdges = CustomizableEdges3
        txt_username.DefaultText = ""
        txt_username.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txt_username.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txt_username.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_username.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_username.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txt_username.Font = New Font("Segoe UI", 9F)
        txt_username.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txt_username.Location = New Point(224, 128)
        txt_username.Margin = New Padding(3, 4, 3, 4)
        txt_username.Name = "txt_username"
        txt_username.PlaceholderText = ""
        txt_username.SelectedText = ""
        txt_username.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txt_username.Size = New Size(286, 33)
        txt_username.TabIndex = 5
        ' 
        ' txt_password
        ' 
        txt_password.CustomizableEdges = CustomizableEdges5
        txt_password.DefaultText = ""
        txt_password.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txt_password.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txt_password.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_password.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_password.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txt_password.Font = New Font("Segoe UI", 9F)
        txt_password.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txt_password.Location = New Point(224, 172)
        txt_password.Margin = New Padding(3, 4, 3, 4)
        txt_password.Name = "txt_password"
        txt_password.PlaceholderText = ""
        txt_password.SelectedText = ""
        txt_password.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        txt_password.Size = New Size(286, 33)
        txt_password.TabIndex = 6
        ' 
        ' Guna2Button2
        ' 
        Guna2Button2.CustomizableEdges = CustomizableEdges7
        Guna2Button2.DisabledState.BorderColor = Color.DarkGray
        Guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button2.Font = New Font("Segoe UI", 9F)
        Guna2Button2.ForeColor = Color.White
        Guna2Button2.Location = New Point(54, 276)
        Guna2Button2.Name = "Guna2Button2"
        Guna2Button2.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2Button2.Size = New Size(225, 56)
        Guna2Button2.TabIndex = 7
        Guna2Button2.Text = "ADMIN"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 463)
        Controls.Add(Guna2Button2)
        Controls.Add(txt_password)
        Controls.Add(txt_username)
        Controls.Add(Guna2Button1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Login"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ContextMenuStrip1 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents txt_username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
End Class
