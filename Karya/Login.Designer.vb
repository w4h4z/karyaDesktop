<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    'Inherits System.Windows.Forms.Form
    Inherits MetroFramework.Forms.MetroForm

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
        Me.txtNPM = New MetroFramework.Controls.MetroTextBox()
        Me.txtPw = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.btnLogin = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'txtNPM
        '
        Me.txtNPM.Lines = New String(-1) {}
        Me.txtNPM.Location = New System.Drawing.Point(158, 90)
        Me.txtNPM.MaxLength = 32767
        Me.txtNPM.Name = "txtNPM"
        Me.txtNPM.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNPM.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNPM.SelectedText = ""
        Me.txtNPM.Size = New System.Drawing.Size(205, 23)
        Me.txtNPM.TabIndex = 0
        Me.txtNPM.UseSelectable = True
        '
        'txtPw
        '
        Me.txtPw.Lines = New String(-1) {}
        Me.txtPw.Location = New System.Drawing.Point(158, 119)
        Me.txtPw.MaxLength = 32767
        Me.txtPw.Name = "txtPw"
        Me.txtPw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPw.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPw.SelectedText = ""
        Me.txtPw.Size = New System.Drawing.Size(205, 23)
        Me.txtPw.TabIndex = 1
        Me.txtPw.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(57, 94)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(40, 19)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "NPM"
        Me.MetroLabel1.UseStyleColors = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.Location = New System.Drawing.Point(57, 123)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(67, 19)
        Me.MetroLabel2.TabIndex = 3
        Me.MetroLabel2.Text = "Password"
        Me.MetroLabel2.UseStyleColors = True
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(158, 165)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(205, 35)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseSelectable = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 254)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.txtPw)
        Me.Controls.Add(Me.txtNPM)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.Resizable = False
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNPM As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPw As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnLogin As MetroFramework.Controls.MetroButton
End Class
