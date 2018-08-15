<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SupplierForm
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
        Me.lblMobileNumber = New System.Windows.Forms.Label()
        Me.MainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtMobileNumber = New System.Windows.Forms.TextBox()
        Me.dgvSupplier = New System.Windows.Forms.DataGridView()
        Me.lblSupplierName = New System.Windows.Forms.Label()
        Me.txtSupplierAddress = New System.Windows.Forms.TextBox()
        Me.lblSupplierID = New System.Windows.Forms.Label()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtSupplierID = New System.Windows.Forms.TextBox()
        Me.txtSupplierName = New System.Windows.Forms.TextBox()
        Me.MenuStripMain = New System.Windows.Forms.MenuStrip()
        Me.txtUpdateBy = New System.Windows.Forms.TextBox()
        Me.gbSupplier = New System.Windows.Forms.GroupBox()
        Me.DateTimeUpdateDate = New System.Windows.Forms.TextBox()
        Me.DateTimeCreateDate = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtCreatedBy = New System.Windows.Forms.TextBox()
        Me.lblCreatedBy = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.lblIpdateBy = New System.Windows.Forms.Label()
        Me.lblUpdateDate = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblCreateDate = New System.Windows.Forms.Label()
        Me.lblSupplierAddress = New System.Windows.Forms.Label()
        CType(Me.dgvSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStripMain.SuspendLayout()
        Me.gbSupplier.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMobileNumber
        '
        Me.lblMobileNumber.AutoSize = True
        Me.lblMobileNumber.Location = New System.Drawing.Point(19, 149)
        Me.lblMobileNumber.Name = "lblMobileNumber"
        Me.lblMobileNumber.Size = New System.Drawing.Size(81, 13)
        Me.lblMobileNumber.TabIndex = 24
        Me.lblMobileNumber.Text = "Mobile Number:"
        '
        'MainToolStripMenuItem
        '
        Me.MainToolStripMenuItem.Name = "MainToolStripMenuItem"
        Me.MainToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.MainToolStripMenuItem.Text = "Main"
        '
        'txtMobileNumber
        '
        Me.txtMobileNumber.Location = New System.Drawing.Point(161, 142)
        Me.txtMobileNumber.Name = "txtMobileNumber"
        Me.txtMobileNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtMobileNumber.TabIndex = 26
        '
        'dgvSupplier
        '
        Me.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSupplier.Location = New System.Drawing.Point(548, 39)
        Me.dgvSupplier.Name = "dgvSupplier"
        Me.dgvSupplier.Size = New System.Drawing.Size(492, 313)
        Me.dgvSupplier.TabIndex = 15
        '
        'lblSupplierName
        '
        Me.lblSupplierName.AutoSize = True
        Me.lblSupplierName.Location = New System.Drawing.Point(19, 65)
        Me.lblSupplierName.Name = "lblSupplierName"
        Me.lblSupplierName.Size = New System.Drawing.Size(79, 13)
        Me.lblSupplierName.TabIndex = 20
        Me.lblSupplierName.Text = "Supplier Name:"
        '
        'txtSupplierAddress
        '
        Me.txtSupplierAddress.Location = New System.Drawing.Point(161, 101)
        Me.txtSupplierAddress.Name = "txtSupplierAddress"
        Me.txtSupplierAddress.Size = New System.Drawing.Size(100, 20)
        Me.txtSupplierAddress.TabIndex = 17
        '
        'lblSupplierID
        '
        Me.lblSupplierID.AutoSize = True
        Me.lblSupplierID.Location = New System.Drawing.Point(19, 31)
        Me.lblSupplierID.Name = "lblSupplierID"
        Me.lblSupplierID.Size = New System.Drawing.Size(62, 13)
        Me.lblSupplierID.TabIndex = 21
        Me.lblSupplierID.Text = "Supplier ID:"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainToolStripMenuItem})
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'txtSupplierID
        '
        Me.txtSupplierID.Location = New System.Drawing.Point(161, 24)
        Me.txtSupplierID.Name = "txtSupplierID"
        Me.txtSupplierID.Size = New System.Drawing.Size(100, 20)
        Me.txtSupplierID.TabIndex = 15
        '
        'txtSupplierName
        '
        Me.txtSupplierName.Location = New System.Drawing.Point(161, 62)
        Me.txtSupplierName.Name = "txtSupplierName"
        Me.txtSupplierName.Size = New System.Drawing.Size(100, 20)
        Me.txtSupplierName.TabIndex = 16
        '
        'MenuStripMain
        '
        Me.MenuStripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem})
        Me.MenuStripMain.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripMain.Name = "MenuStripMain"
        Me.MenuStripMain.Size = New System.Drawing.Size(1063, 24)
        Me.MenuStripMain.TabIndex = 17
        '
        'txtUpdateBy
        '
        Me.txtUpdateBy.Location = New System.Drawing.Point(370, 101)
        Me.txtUpdateBy.Name = "txtUpdateBy"
        Me.txtUpdateBy.Size = New System.Drawing.Size(100, 20)
        Me.txtUpdateBy.TabIndex = 33
        '
        'gbSupplier
        '
        Me.gbSupplier.Controls.Add(Me.DateTimeUpdateDate)
        Me.gbSupplier.Controls.Add(Me.DateTimeCreateDate)
        Me.gbSupplier.Controls.Add(Me.btnDelete)
        Me.gbSupplier.Controls.Add(Me.btnAdd)
        Me.gbSupplier.Controls.Add(Me.btnUpdate)
        Me.gbSupplier.Controls.Add(Me.txtEmail)
        Me.gbSupplier.Controls.Add(Me.lblEmail)
        Me.gbSupplier.Controls.Add(Me.txtCreatedBy)
        Me.gbSupplier.Controls.Add(Me.lblCreatedBy)
        Me.gbSupplier.Controls.Add(Me.txtUpdateBy)
        Me.gbSupplier.Controls.Add(Me.txtPhoneNumber)
        Me.gbSupplier.Controls.Add(Me.lblIpdateBy)
        Me.gbSupplier.Controls.Add(Me.lblUpdateDate)
        Me.gbSupplier.Controls.Add(Me.lblPhoneNumber)
        Me.gbSupplier.Controls.Add(Me.lblCreateDate)
        Me.gbSupplier.Controls.Add(Me.lblSupplierAddress)
        Me.gbSupplier.Controls.Add(Me.lblMobileNumber)
        Me.gbSupplier.Controls.Add(Me.txtMobileNumber)
        Me.gbSupplier.Controls.Add(Me.lblSupplierName)
        Me.gbSupplier.Controls.Add(Me.txtSupplierAddress)
        Me.gbSupplier.Controls.Add(Me.lblSupplierID)
        Me.gbSupplier.Controls.Add(Me.txtSupplierID)
        Me.gbSupplier.Controls.Add(Me.txtSupplierName)
        Me.gbSupplier.Location = New System.Drawing.Point(12, 60)
        Me.gbSupplier.Name = "gbSupplier"
        Me.gbSupplier.Size = New System.Drawing.Size(502, 335)
        Me.gbSupplier.TabIndex = 16
        Me.gbSupplier.TabStop = False
        Me.gbSupplier.Text = "Supplier Info"
        '
        'DateTimeUpdateDate
        '
        Me.DateTimeUpdateDate.Enabled = False
        Me.DateTimeUpdateDate.Location = New System.Drawing.Point(370, 141)
        Me.DateTimeUpdateDate.Name = "DateTimeUpdateDate"
        Me.DateTimeUpdateDate.Size = New System.Drawing.Size(100, 20)
        Me.DateTimeUpdateDate.TabIndex = 50
        '
        'DateTimeCreateDate
        '
        Me.DateTimeCreateDate.Enabled = False
        Me.DateTimeCreateDate.Location = New System.Drawing.Point(370, 62)
        Me.DateTimeCreateDate.Name = "DateTimeCreateDate"
        Me.DateTimeCreateDate.Size = New System.Drawing.Size(100, 20)
        Me.DateTimeCreateDate.TabIndex = 38
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(307, 272)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(82, 36)
        Me.btnDelete.TabIndex = 48
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(95, 272)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(93, 36)
        Me.btnAdd.TabIndex = 46
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(205, 272)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(84, 36)
        Me.btnUpdate.TabIndex = 47
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(161, 225)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtEmail.TabIndex = 39
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(19, 225)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 38
        Me.lblEmail.Text = "Email:"
        '
        'txtCreatedBy
        '
        Me.txtCreatedBy.Enabled = False
        Me.txtCreatedBy.Location = New System.Drawing.Point(370, 28)
        Me.txtCreatedBy.Name = "txtCreatedBy"
        Me.txtCreatedBy.Size = New System.Drawing.Size(100, 20)
        Me.txtCreatedBy.TabIndex = 37
        '
        'lblCreatedBy
        '
        Me.lblCreatedBy.AutoSize = True
        Me.lblCreatedBy.Location = New System.Drawing.Point(280, 31)
        Me.lblCreatedBy.Name = "lblCreatedBy"
        Me.lblCreatedBy.Size = New System.Drawing.Size(62, 13)
        Me.lblCreatedBy.TabIndex = 36
        Me.lblCreatedBy.Text = "Created By:"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(161, 184)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtPhoneNumber.TabIndex = 32
        '
        'lblIpdateBy
        '
        Me.lblIpdateBy.AutoSize = True
        Me.lblIpdateBy.Location = New System.Drawing.Point(280, 104)
        Me.lblIpdateBy.Name = "lblIpdateBy"
        Me.lblIpdateBy.Size = New System.Drawing.Size(60, 13)
        Me.lblIpdateBy.TabIndex = 31
        Me.lblIpdateBy.Text = "Update By:"
        '
        'lblUpdateDate
        '
        Me.lblUpdateDate.AutoSize = True
        Me.lblUpdateDate.Location = New System.Drawing.Point(280, 146)
        Me.lblUpdateDate.Name = "lblUpdateDate"
        Me.lblUpdateDate.Size = New System.Drawing.Size(71, 13)
        Me.lblUpdateDate.TabIndex = 30
        Me.lblUpdateDate.Text = "Update Date:"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(19, 184)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(81, 13)
        Me.lblPhoneNumber.TabIndex = 29
        Me.lblPhoneNumber.Text = "Phone Number:"
        '
        'lblCreateDate
        '
        Me.lblCreateDate.AutoSize = True
        Me.lblCreateDate.Location = New System.Drawing.Point(280, 69)
        Me.lblCreateDate.Name = "lblCreateDate"
        Me.lblCreateDate.Size = New System.Drawing.Size(67, 13)
        Me.lblCreateDate.TabIndex = 28
        Me.lblCreateDate.Text = "Create Date:"
        '
        'lblSupplierAddress
        '
        Me.lblSupplierAddress.AutoSize = True
        Me.lblSupplierAddress.Location = New System.Drawing.Point(19, 104)
        Me.lblSupplierAddress.Name = "lblSupplierAddress"
        Me.lblSupplierAddress.Size = New System.Drawing.Size(86, 13)
        Me.lblSupplierAddress.TabIndex = 27
        Me.lblSupplierAddress.Text = "Supplier Address"
        '
        'SupplierForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 419)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvSupplier)
        Me.Controls.Add(Me.MenuStripMain)
        Me.Controls.Add(Me.gbSupplier)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SupplierForm"
        Me.Text = "SupplierForm"
        CType(Me.dgvSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStripMain.ResumeLayout(False)
        Me.MenuStripMain.PerformLayout()
        Me.gbSupplier.ResumeLayout(False)
        Me.gbSupplier.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMobileNumber As System.Windows.Forms.Label
    Friend WithEvents MainToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtMobileNumber As System.Windows.Forms.TextBox
    Friend WithEvents dgvSupplier As System.Windows.Forms.DataGridView
    Friend WithEvents lblSupplierName As System.Windows.Forms.Label
    Friend WithEvents txtSupplierAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblSupplierID As System.Windows.Forms.Label
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtSupplierID As System.Windows.Forms.TextBox
    Friend WithEvents txtSupplierName As System.Windows.Forms.TextBox
    Friend WithEvents MenuStripMain As System.Windows.Forms.MenuStrip
    Friend WithEvents txtUpdateBy As System.Windows.Forms.TextBox
    Friend WithEvents gbSupplier As System.Windows.Forms.GroupBox
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblIpdateBy As System.Windows.Forms.Label
    Friend WithEvents lblUpdateDate As System.Windows.Forms.Label
    Friend WithEvents lblPhoneNumber As System.Windows.Forms.Label
    Friend WithEvents lblCreateDate As System.Windows.Forms.Label
    Friend WithEvents lblSupplierAddress As System.Windows.Forms.Label
    Friend WithEvents txtCreatedBy As System.Windows.Forms.TextBox
    Friend WithEvents lblCreatedBy As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents DateTimeCreateDate As System.Windows.Forms.TextBox
    Friend WithEvents DateTimeUpdateDate As System.Windows.Forms.TextBox
End Class
