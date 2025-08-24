<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Adminlog
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
        password = New Guna.UI2.WinForms.Guna2TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        SuspendLayout()
        ' 
        ' password
        ' 
        password.CustomizableEdges = CustomizableEdges1
        password.DefaultText = ""
        password.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        password.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        password.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        password.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        password.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        password.Font = New Font("Segoe UI", 9F)
        password.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        password.Location = New Point(219, 138)
        password.Margin = New Padding(3, 4, 3, 4)
        password.Name = "password"
        password.PlaceholderText = ""
        password.SelectedText = ""
        password.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        password.Size = New Size(286, 44)
        password.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(127, 148)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 20)
        Label1.TabIndex = 1
        Label1.Text = "PASSWORD"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(290, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 20)
        Label2.TabIndex = 2
        Label2.Text = "ADMIN LOGIN"
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.CustomizableEdges = CustomizableEdges3
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.Font = New Font("Segoe UI", 9F)
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.Location = New Point(371, 227)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Button1.Size = New Size(225, 56)
        Guna2Button1.TabIndex = 3
        Guna2Button1.Text = "LOGIN"
        ' 
        ' Guna2Button2
        ' 
        Guna2Button2.CustomizableEdges = CustomizableEdges5
        Guna2Button2.DisabledState.BorderColor = Color.DarkGray
        Guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button2.Font = New Font("Segoe UI", 9F)
        Guna2Button2.ForeColor = Color.White
        Guna2Button2.Location = New Point(96, 227)
        Guna2Button2.Name = "Guna2Button2"
        Guna2Button2.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2Button2.Size = New Size(225, 56)
        Guna2Button2.TabIndex = 4
        Guna2Button2.Text = "BACK"
        ' 
        ' Adminlog
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Guna2Button2)
        Controls.Add(Guna2Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(password)
        Name = "Adminlog"
        Text = "Adminlog"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
End Class
