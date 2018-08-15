<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CategoryForm
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
        Me.dgvCategory = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.gbCategory = New System.Windows.Forms.GroupBox()
        Me.DateTimeUpdateDate = New System.Windows.Forms.TextBox()
        Me.DateTimeCreateDate = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtUpdateBy = New System.Windows.Forms.TextBox()
        Me.txtCreatedBy = New System.Windows.Forms.TextBox()
        Me.lblIpdateBy = New System.Windows.Forms.Label()
        Me.lblUpdateDate = New System.Windows.Forms.Label()
        Me.lblCreatedBy = New System.Windows.Forms.Label()
        Me.lblCreateDate = New System.Windows.Forms.Label()
        Me.lblPCID = New System.Windows.Forms.Label()
        Me.txtPCName = New System.Windows.Forms.TextBox()
        Me.lblDeptID = New System.Windows.Forms.Label()
        Me.lblPCName = New System.Windows.Forms.Label()
        Me.txtPCID = New System.Windows.Forms.TextBox()
        Me.txtDeptID = New System.Windows.Forms.TextBox()
        Me.lblPCLocator = New System.Windows.Forms.Label()
        Me.lblPCRemarks = New System.Windows.Forms.Label()
        Me.txtPCRemarks = New System.Windows.Forms.TextBox()
        Me.txtPCLocator = New System.Windows.Forms.TextBox()
        Me.MenuStripMain = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCategory.SuspendLayout()
        Me.MenuStripMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvCategory
        '
        Me.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCategory.Location = New System.Drawing.Point(539, 43)
        Me.dgvCategory.Name = "dgvCategory"
        Me.dgvCategory.Size = New System.Drawing.Size(467, 313)
        Me.dgvCategory.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(84, 272)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(96, 36)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(186, 272)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(96, 36)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'gbCategory
        '
        Me.gbCategory.Controls.Add(Me.DateTimeUpdateDate)
        Me.gbCategory.Controls.Add(Me.DateTimeCreateDate)
        Me.gbCategory.Controls.Add(Me.btnDelete)
        Me.gbCategory.Controls.Add(Me.txtUpdateBy)
        Me.gbCategory.Controls.Add(Me.txtCreatedBy)
        Me.gbCategory.Controls.Add(Me.lblIpdateBy)
        Me.gbCategory.Controls.Add(Me.lblUpdateDate)
        Me.gbCategory.Controls.Add(Me.lblCreatedBy)
        Me.gbCategory.Controls.Add(Me.lblCreateDate)
        Me.gbCategory.Controls.Add(Me.lblPCID)
        Me.gbCategory.Controls.Add(Me.txtPCName)
        Me.gbCategory.Controls.Add(Me.lblDeptID)
        Me.gbCategory.Controls.Add(Me.lblPCName)
        Me.gbCategory.Controls.Add(Me.txtPCID)
        Me.gbCategory.Controls.Add(Me.txtDeptID)
        Me.gbCategory.Controls.Add(Me.lblPCLocator)
        Me.gbCategory.Controls.Add(Me.lblPCRemarks)
        Me.gbCategory.Controls.Add(Me.txtPCRemarks)
        Me.gbCategory.Controls.Add(Me.txtPCLocator)
        Me.gbCategory.Controls.Add(Me.btnAdd)
        Me.gbCategory.Controls.Add(Me.btnUpdate)
        Me.gbCategory.Location = New System.Drawing.Point(21, 33)
        Me.gbCategory.Name = "gbCategory"
        Me.gbCategory.Size = New System.Drawing.Size(502, 335)
        Me.gbCategory.TabIndex = 5
        Me.gbCategory.TabStop = False
        Me.gbCategory.Text = "Category Info"
        '
        'DateTimeUpdateDate
        '
        Me.DateTimeUpdateDate.Enabled = False
        Me.DateTimeUpdateDate.Location = New System.Drawing.Point(365, 150)
        Me.DateTimeUpdateDate.Name = "DateTimeUpdateDate"
        Me.DateTimeUpdateDate.Size = New System.Drawing.Size(100, 20)
        Me.DateTimeUpdateDate.TabIndex = 51
        '
        'DateTimeCreateDate
        '
        Me.DateTimeCreateDate.Enabled = False
        Me.DateTimeCreateDate.Location = New System.Drawing.Point(365, 86)
        Me.DateTimeCreateDate.Name = "DateTimeCreateDate"
        Me.DateTimeCreateDate.Size = New System.Drawing.Size(100, 20)
        Me.DateTimeCreateDate.TabIndex = 41
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(288, 272)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(102, 36)
        Me.btnDelete.TabIndex = 39
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtUpdateBy
        '
        Me.txtUpdateBy.Location = New System.Drawing.Point(365, 115)
        Me.txtUpdateBy.Name = "txtUpdateBy"
        Me.txtUpdateBy.Size = New System.Drawing.Size(100, 20)
        Me.txtUpdateBy.TabIndex = 33
        '
        'txtCreatedBy
        '
        Me.txtCreatedBy.Enabled = False
        Me.txtCreatedBy.Location = New System.Drawing.Point(365, 55)
        Me.txtCreatedBy.Name = "txtCreatedBy"
        Me.txtCreatedBy.Size = New System.Drawing.Size(100, 20)
        Me.txtCreatedBy.TabIndex = 32
        '
        'lblIpdateBy
        '
        Me.lblIpdateBy.AutoSize = True
        Me.lblIpdateBy.Location = New System.Drawing.Point(275, 122)
        Me.lblIpdateBy.Name = "lblIpdateBy"
        Me.lblIpdateBy.Size = New System.Drawing.Size(60, 13)
        Me.lblIpdateBy.TabIndex = 31
        Me.lblIpdateBy.Text = "Update By:"
        '
        'lblUpdateDate
        '
        Me.lblUpdateDate.AutoSize = True
        Me.lblUpdateDate.Location = New System.Drawing.Point(275, 153)
        Me.lblUpdateDate.Name = "lblUpdateDate"
        Me.lblUpdateDate.Size = New System.Drawing.Size(71, 13)
        Me.lblUpdateDate.TabIndex = 30
        Me.lblUpdateDate.Text = "Update Date:"
        '
        'lblCreatedBy
        '
        Me.lblCreatedBy.AutoSize = True
        Me.lblCreatedBy.Location = New System.Drawing.Point(275, 58)
        Me.lblCreatedBy.Name = "lblCreatedBy"
        Me.lblCreatedBy.Size = New System.Drawing.Size(62, 13)
        Me.lblCreatedBy.TabIndex = 29
        Me.lblCreatedBy.Text = "Created By:"
        '
        'lblCreateDate
        '
        Me.lblCreateDate.AutoSize = True
        Me.lblCreateDate.Location = New System.Drawing.Point(275, 86)
        Me.lblCreateDate.Name = "lblCreateDate"
        Me.lblCreateDate.Size = New System.Drawing.Size(67, 13)
        Me.lblCreateDate.TabIndex = 28
        Me.lblCreateDate.Text = "Create Date:"
        '
        'lblPCID
        '
        Me.lblPCID.AutoSize = True
        Me.lblPCID.Location = New System.Drawing.Point(6, 61)
        Me.lblPCID.Name = "lblPCID"
        Me.lblPCID.Size = New System.Drawing.Size(106, 13)
        Me.lblPCID.TabIndex = 20
        Me.lblPCID.Text = "Product Category ID:"
        '
        'txtPCName
        '
        Me.txtPCName.Location = New System.Drawing.Point(160, 135)
        Me.txtPCName.Name = "txtPCName"
        Me.txtPCName.Size = New System.Drawing.Size(100, 20)
        Me.txtPCName.TabIndex = 17
        '
        'lblDeptID
        '
        Me.lblDeptID.AutoSize = True
        Me.lblDeptID.Location = New System.Drawing.Point(6, 96)
        Me.lblDeptID.Name = "lblDeptID"
        Me.lblDeptID.Size = New System.Drawing.Size(79, 13)
        Me.lblDeptID.TabIndex = 21
        Me.lblDeptID.Text = "Department ID:"
        '
        'lblPCName
        '
        Me.lblPCName.AutoSize = True
        Me.lblPCName.Location = New System.Drawing.Point(6, 138)
        Me.lblPCName.Name = "lblPCName"
        Me.lblPCName.Size = New System.Drawing.Size(123, 13)
        Me.lblPCName.TabIndex = 22
        Me.lblPCName.Text = "Product Category Name:"
        '
        'txtPCID
        '
        Me.txtPCID.Location = New System.Drawing.Point(160, 58)
        Me.txtPCID.Name = "txtPCID"
        Me.txtPCID.Size = New System.Drawing.Size(100, 20)
        Me.txtPCID.TabIndex = 15
        '
        'txtDeptID
        '
        Me.txtDeptID.Location = New System.Drawing.Point(160, 96)
        Me.txtDeptID.Name = "txtDeptID"
        Me.txtDeptID.Size = New System.Drawing.Size(100, 20)
        Me.txtDeptID.TabIndex = 16
        '
        'lblPCLocator
        '
        Me.lblPCLocator.AutoSize = True
        Me.lblPCLocator.Location = New System.Drawing.Point(6, 176)
        Me.lblPCLocator.Name = "lblPCLocator"
        Me.lblPCLocator.Size = New System.Drawing.Size(86, 13)
        Me.lblPCLocator.TabIndex = 23
        Me.lblPCLocator.Text = "Product Locator:"
        '
        'lblPCRemarks
        '
        Me.lblPCRemarks.AutoSize = True
        Me.lblPCRemarks.Location = New System.Drawing.Point(6, 211)
        Me.lblPCRemarks.Name = "lblPCRemarks"
        Me.lblPCRemarks.Size = New System.Drawing.Size(137, 13)
        Me.lblPCRemarks.TabIndex = 14
        Me.lblPCRemarks.Text = "Product Category Remarks:"
        '
        'txtPCRemarks
        '
        Me.txtPCRemarks.Location = New System.Drawing.Point(160, 208)
        Me.txtPCRemarks.Name = "txtPCRemarks"
        Me.txtPCRemarks.Size = New System.Drawing.Size(100, 20)
        Me.txtPCRemarks.TabIndex = 19
        '
        'txtPCLocator
        '
        Me.txtPCLocator.Location = New System.Drawing.Point(160, 173)
        Me.txtPCLocator.Name = "txtPCLocator"
        Me.txtPCLocator.Size = New System.Drawing.Size(100, 20)
        Me.txtPCLocator.TabIndex = 18
        '
        'MenuStripMain
        '
        Me.MenuStripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem})
        Me.MenuStripMain.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripMain.Name = "MenuStripMain"
        Me.MenuStripMain.Size = New System.Drawing.Size(1018, 24)
        Me.MenuStripMain.TabIndex = 9
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
        'CategoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 401)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStripMain)
        Me.Controls.Add(Me.gbCategory)
        Me.Controls.Add(Me.dgvCategory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CategoryForm"
        Me.Text = "CategoryForm"
        CType(Me.dgvCategory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCategory.ResumeLayout(False)
        Me.gbCategory.PerformLayout()
        Me.MenuStripMain.ResumeLayout(False)
        Me.MenuStripMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvCategory As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents gbCategory As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStripMain As System.Windows.Forms.MenuStrip
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblPCID As System.Windows.Forms.Label
    Friend WithEvents txtPCName As System.Windows.Forms.TextBox
    Friend WithEvents lblDeptID As System.Windows.Forms.Label
    Friend WithEvents lblPCName As System.Windows.Forms.Label
    Friend WithEvents txtPCID As System.Windows.Forms.TextBox
    Friend WithEvents txtDeptID As System.Windows.Forms.TextBox
    Friend WithEvents lblPCLocator As System.Windows.Forms.Label
    Friend WithEvents lblPCRemarks As System.Windows.Forms.Label
    Friend WithEvents txtPCRemarks As System.Windows.Forms.TextBox
    Friend WithEvents txtPCLocator As System.Windows.Forms.TextBox
    Friend WithEvents txtUpdateBy As System.Windows.Forms.TextBox
    Friend WithEvents txtCreatedBy As System.Windows.Forms.TextBox
    Friend WithEvents lblIpdateBy As System.Windows.Forms.Label
    Friend WithEvents lblUpdateDate As System.Windows.Forms.Label
    Friend WithEvents lblCreatedBy As System.Windows.Forms.Label
    Friend WithEvents lblCreateDate As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents DateTimeCreateDate As System.Windows.Forms.TextBox
    Friend WithEvents DateTimeUpdateDate As System.Windows.Forms.TextBox
End Class
