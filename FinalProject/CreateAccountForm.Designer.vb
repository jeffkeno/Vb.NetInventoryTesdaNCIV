<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateAccountForm
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
        Me.MenuStripMain = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.dgvUser = New System.Windows.Forms.DataGridView()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.gbAccountInfo = New System.Windows.Forms.GroupBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.MenuStripMain.SuspendLayout()
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAccountInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStripMain
        '
        Me.MenuStripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem})
        Me.MenuStripMain.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripMain.Name = "MenuStripMain"
        Me.MenuStripMain.Size = New System.Drawing.Size(932, 24)
        Me.MenuStripMain.TabIndex = 8
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainToolStripMenuItem})
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'MainToolStripMenuItem
        '
        Me.MainToolStripMenuItem.Name = "MainToolStripMenuItem"
        Me.MainToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.MainToolStripMenuItem.Text = "Main"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(178, 79)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 1
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(178, 41)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(100, 20)
        Me.txtUserName.TabIndex = 0
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(67, 79)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(56, 13)
        Me.lblPassword.TabIndex = 10
        Me.lblPassword.Text = "Password:"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(67, 44)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(58, 13)
        Me.lblUserName.TabIndex = 9
        Me.lblUserName.Text = "Username:"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(178, 197)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 4
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(178, 160)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 3
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(66, 200)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(56, 13)
        Me.lblLastName.TabIndex = 0
        Me.lblLastName.Text = "Lastname:"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(67, 163)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(55, 13)
        Me.lblFirstName.TabIndex = 13
        Me.lblFirstName.Text = "Firstname:"
        '
        'dgvUser
        '
        Me.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUser.Location = New System.Drawing.Point(418, 49)
        Me.dgvUser.Name = "dgvUser"
        Me.dgvUser.Size = New System.Drawing.Size(502, 274)
        Me.dgvUser.TabIndex = 7
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(65, 238)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 23)
        Me.btnCreate.TabIndex = 5
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.Location = New System.Drawing.Point(66, 121)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(94, 13)
        Me.lblConfirmPassword.TabIndex = 12
        Me.lblConfirmPassword.Text = "Confirm Password:"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(178, 118)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtConfirmPassword.TabIndex = 2
        '
        'gbAccountInfo
        '
        Me.gbAccountInfo.Controls.Add(Me.btnShow)
        Me.gbAccountInfo.Controls.Add(Me.btnEdit)
        Me.gbAccountInfo.Controls.Add(Me.btnDelete)
        Me.gbAccountInfo.Controls.Add(Me.lblUserName)
        Me.gbAccountInfo.Controls.Add(Me.btnCreate)
        Me.gbAccountInfo.Controls.Add(Me.txtConfirmPassword)
        Me.gbAccountInfo.Controls.Add(Me.lblPassword)
        Me.gbAccountInfo.Controls.Add(Me.lblConfirmPassword)
        Me.gbAccountInfo.Controls.Add(Me.txtUserName)
        Me.gbAccountInfo.Controls.Add(Me.txtPassword)
        Me.gbAccountInfo.Controls.Add(Me.lblFirstName)
        Me.gbAccountInfo.Controls.Add(Me.lblLastName)
        Me.gbAccountInfo.Controls.Add(Me.txtLastName)
        Me.gbAccountInfo.Controls.Add(Me.txtFirstName)
        Me.gbAccountInfo.Location = New System.Drawing.Point(24, 49)
        Me.gbAccountInfo.Name = "gbAccountInfo"
        Me.gbAccountInfo.Size = New System.Drawing.Size(368, 303)
        Me.gbAccountInfo.TabIndex = 14
        Me.gbAccountInfo.TabStop = False
        Me.gbAccountInfo.Text = "Account Information:"
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(146, 274)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 23)
        Me.btnShow.TabIndex = 20
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(146, 238)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 18
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(227, 238)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 19
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'CreateAccountForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 364)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbAccountInfo)
        Me.Controls.Add(Me.dgvUser)
        Me.Controls.Add(Me.MenuStripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CreateAccountForm"
        Me.Text = "CreateAccountForm"
        Me.MenuStripMain.ResumeLayout(False)
        Me.MenuStripMain.PerformLayout()
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAccountInfo.ResumeLayout(False)
        Me.gbAccountInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStripMain As System.Windows.Forms.MenuStrip
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents dgvUser As System.Windows.Forms.DataGridView
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents lblConfirmPassword As System.Windows.Forms.Label
    Friend WithEvents txtConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents gbAccountInfo As System.Windows.Forms.GroupBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnShow As System.Windows.Forms.Button
End Class
