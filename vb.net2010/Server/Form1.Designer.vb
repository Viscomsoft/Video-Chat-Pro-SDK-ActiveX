<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AxVideoChatServer1 = New AxVideoChatServerLib.AxVideoChatServer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textPort = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textConference = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.listUserID = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.textSelectedUserID = New System.Windows.Forms.TextBox()
        CType(Me.AxVideoChatServer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxVideoChatServer1
        '
        Me.AxVideoChatServer1.Enabled = True
        Me.AxVideoChatServer1.Location = New System.Drawing.Point(455, 93)
        Me.AxVideoChatServer1.Name = "AxVideoChatServer1"
        Me.AxVideoChatServer1.OcxState = CType(resources.GetObject("AxVideoChatServer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxVideoChatServer1.Size = New System.Drawing.Size(131, 90)
        Me.AxVideoChatServer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Server Port No"
        '
        'textPort
        '
        Me.textPort.Location = New System.Drawing.Point(153, 24)
        Me.textPort.Name = "textPort"
        Me.textPort.Size = New System.Drawing.Size(106, 20)
        Me.textPort.TabIndex = 2
        Me.textPort.Text = "1234"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Conference Number"
        '
        'textConference
        '
        Me.textConference.Location = New System.Drawing.Point(153, 53)
        Me.textConference.Name = "textConference"
        Me.textConference.Size = New System.Drawing.Size(106, 20)
        Me.textConference.TabIndex = 2
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(302, 26)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(288, 17)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "The Conference Number, User ID use Random Number"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(51, 101)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 39)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Create Conference"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(255, 101)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(160, 39)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Add User to this Conference "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(227, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "User ID  (if the user connected, it will mark *** )"
        '
        'listUserID
        '
        Me.listUserID.FormattingEnabled = True
        Me.listUserID.Location = New System.Drawing.Point(39, 200)
        Me.listUserID.Name = "listUserID"
        Me.listUserID.Size = New System.Drawing.Size(278, 290)
        Me.listUserID.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(372, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Selected User ID"
        '
        'textSelectedUserID
        '
        Me.textSelectedUserID.Location = New System.Drawing.Point(364, 254)
        Me.textSelectedUserID.Name = "textSelectedUserID"
        Me.textSelectedUserID.Size = New System.Drawing.Size(176, 20)
        Me.textSelectedUserID.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 532)
        Me.Controls.Add(Me.textSelectedUserID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.listUserID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.textConference)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.textPort)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AxVideoChatServer1)
        Me.Name = "Form1"
        Me.Text = "Video Chat Pro Server"
        CType(Me.AxVideoChatServer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AxVideoChatServer1 As AxVideoChatServerLib.AxVideoChatServer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents textPort As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents textConference As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents listUserID As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents textSelectedUserID As System.Windows.Forms.TextBox

End Class
