<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DepartmentForm
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
        Me.txtUpdateBy = New System.Windows.Forms.TextBox()
        Me.lblIpdateBy = New System.Windows.Forms.Label()
        Me.lblUpdateDate = New System.Windows.Forms.Label()
        Me.lblCreatedBy = New System.Windows.Forms.Label()
        Me.dgvDepartment = New System.Windows.Forms.DataGridView()
        Me.lblCreateDate = New System.Windows.Forms.Label()
        Me.MenuStripMain = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblPCID = New System.Windows.Forms.Label()
        Me.gbDepartment = New System.Windows.Forms.GroupBox()
        Me.DateTimeUpdateDate = New System.Windows.Forms.TextBox()
        Me.DateTimeCreateDate = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtCreatedBy = New System.Windows.Forms.TextBox()
        Me.lblDeptID = New System.Windows.Forms.Label()
        Me.txtDeptID = New System.Windows.Forms.TextBox()
        Me.txtDeptName = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        CType(Me.dgvDepartment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStripMain.SuspendLayout()
        Me.gbDepartment.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtUpdateBy
        '
        Me.txtUpdateBy.Location = New System.Drawing.Point(378, 71)
        Me.txtUpdateBy.Name = "txtUpdateBy"
        Me.txtUpdateBy.Size = New System.Drawing.Size(100, 20)
        Me.txtUpdateBy.TabIndex = 33
        '
        'lblIpdateBy
        '
        Me.lblIpdateBy.AutoSize = True
        Me.lblIpdateBy.Location = New System.Drawing.Point(288, 78)
        Me.lblIpdateBy.Name = "lblIpdateBy"
        Me.lblIpdateBy.Size = New System.Drawing.Size(60, 13)
        Me.lblIpdateBy.TabIndex = 31
        Me.lblIpdateBy.Text = "Update By:"
        '
        'lblUpdateDate
        '
        Me.lblUpdateDate.AutoSize = True
        Me.lblUpdateDate.Location = New System.Drawing.Point(288, 109)
        Me.lblUpdateDate.Name = "lblUpdateDate"
        Me.lblUpdateDate.Size = New System.Drawing.Size(71, 13)
        Me.lblUpdateDate.TabIndex = 30
        Me.lblUpdateDate.Text = "Update Date:"
        '
        'lblCreatedBy
        '
        Me.lblCreatedBy.AutoSize = True
        Me.lblCreatedBy.Location = New System.Drawing.Point(19, 156)
        Me.lblCreatedBy.Name = "lblCreatedBy"
        Me.lblCreatedBy.Size = New System.Drawing.Size(62, 13)
        Me.lblCreatedBy.TabIndex = 29
        Me.lblCreatedBy.Text = "Created By:"
        '
        'dgvDepartment
        '
        Me.dgvDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDepartment.Location = New System.Drawing.Point(548, 66)
        Me.dgvDepartment.Name = "dgvDepartment"
        Me.dgvDepartment.Size = New System.Drawing.Size(492, 313)
        Me.dgvDepartment.TabIndex = 11
        '
        'lblCreateDate
        '
        Me.lblCreateDate.AutoSize = True
        Me.lblCreateDate.Location = New System.Drawing.Point(19, 201)
        Me.lblCreateDate.Name = "lblCreateDate"
        Me.lblCreateDate.Size = New System.Drawing.Size(67, 13)
        Me.lblCreateDate.TabIndex = 28
        Me.lblCreateDate.Text = "Create Date:"
        '
        'MenuStripMain
        '
        Me.MenuStripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem})
        Me.MenuStripMain.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripMain.Name = "MenuStripMain"
        Me.MenuStripMain.Size = New System.Drawing.Size(1069, 24)
        Me.MenuStripMain.TabIndex = 13
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
        'lblPCID
        '
        Me.lblPCID.AutoSize = True
        Me.lblPCID.Location = New System.Drawing.Point(19, 112)
        Me.lblPCID.Name = "lblPCID"
        Me.lblPCID.Size = New System.Drawing.Size(96, 13)
        Me.lblPCID.TabIndex = 20
        Me.lblPCID.Text = "Department Name:"
        '
        'gbDepartment
        '
        Me.gbDepartment.Controls.Add(Me.DateTimeUpdateDate)
        Me.gbDepartment.Controls.Add(Me.DateTimeCreateDate)
        Me.gbDepartment.Controls.Add(Me.btnDelete)
        Me.gbDepartment.Controls.Add(Me.txtUpdateBy)
        Me.gbDepartment.Controls.Add(Me.txtCreatedBy)
        Me.gbDepartment.Controls.Add(Me.lblIpdateBy)
        Me.gbDepartment.Controls.Add(Me.lblUpdateDate)
        Me.gbDepartment.Controls.Add(Me.lblCreatedBy)
        Me.gbDepartment.Controls.Add(Me.lblCreateDate)
        Me.gbDepartment.Controls.Add(Me.lblPCID)
        Me.gbDepartment.Controls.Add(Me.lblDeptID)
        Me.gbDepartment.Controls.Add(Me.txtDeptID)
        Me.gbDepartment.Controls.Add(Me.txtDeptName)
        Me.gbDepartment.Controls.Add(Me.btnAdd)
        Me.gbDepartment.Controls.Add(Me.btnUpdate)
        Me.gbDepartment.Location = New System.Drawing.Point(12, 66)
        Me.gbDepartment.Name = "gbDepartment"
        Me.gbDepartment.Size = New System.Drawing.Size(502, 335)
        Me.gbDepartment.TabIndex = 12
        Me.gbDepartment.TabStop = False
        Me.gbDepartment.Text = "Department Info"
        '
        'DateTimeUpdateDate
        '
        Me.DateTimeUpdateDate.Enabled = False
        Me.DateTimeUpdateDate.Location = New System.Drawing.Point(378, 105)
        Me.DateTimeUpdateDate.Name = "DateTimeUpdateDate"
        Me.DateTimeUpdateDate.Size = New System.Drawing.Size(100, 20)
        Me.DateTimeUpdateDate.TabIndex = 51
        '
        'DateTimeCreateDate
        '
        Me.DateTimeCreateDate.Enabled = False
        Me.DateTimeCreateDate.Location = New System.Drawing.Point(161, 194)
        Me.DateTimeCreateDate.Name = "DateTimeCreateDate"
        Me.DateTimeCreateDate.Size = New System.Drawing.Size(100, 20)
        Me.DateTimeCreateDate.TabIndex = 40
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(304, 277)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(82, 36)
        Me.btnDelete.TabIndex = 38
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtCreatedBy
        '
        Me.txtCreatedBy.Enabled = False
        Me.txtCreatedBy.Location = New System.Drawing.Point(161, 156)
        Me.txtCreatedBy.Name = "txtCreatedBy"
        Me.txtCreatedBy.Size = New System.Drawing.Size(100, 20)
        Me.txtCreatedBy.TabIndex = 32
        '
        'lblDeptID
        '
        Me.lblDeptID.AutoSize = True
        Me.lblDeptID.Location = New System.Drawing.Point(19, 78)
        Me.lblDeptID.Name = "lblDeptID"
        Me.lblDeptID.Size = New System.Drawing.Size(79, 13)
        Me.lblDeptID.TabIndex = 21
        Me.lblDeptID.Text = "Department ID:"
        '
        'txtDeptID
        '
        Me.txtDeptID.Location = New System.Drawing.Point(161, 71)
        Me.txtDeptID.Name = "txtDeptID"
        Me.txtDeptID.Size = New System.Drawing.Size(100, 20)
        Me.txtDeptID.TabIndex = 15
        '
        'txtDeptName
        '
        Me.txtDeptName.Location = New System.Drawing.Point(161, 109)
        Me.txtDeptName.Name = "txtDeptName"
        Me.txtDeptName.Size = New System.Drawing.Size(100, 20)
        Me.txtDeptName.TabIndex = 16
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(92, 277)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(93, 36)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(202, 277)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(84, 36)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'DepartmentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 418)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvDepartment)
        Me.Controls.Add(Me.MenuStripMain)
        Me.Controls.Add(Me.gbDepartment)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "DepartmentForm"
        Me.Text = "DepartmentForm"
        CType(Me.dgvDepartment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStripMain.ResumeLayout(False)
        Me.MenuStripMain.PerformLayout()
        Me.gbDepartment.ResumeLayout(False)
        Me.gbDepartment.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUpdateBy As System.Windows.Forms.TextBox
    Friend WithEvents lblIpdateBy As System.Windows.Forms.Label
    Friend WithEvents lblUpdateDate As System.Windows.Forms.Label
    Friend WithEvents lblCreatedBy As System.Windows.Forms.Label
    Friend WithEvents dgvDepartment As System.Windows.Forms.DataGridView
    Friend WithEvents lblCreateDate As System.Windows.Forms.Label
    Friend WithEvents MenuStripMain As System.Windows.Forms.MenuStrip
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblPCID As System.Windows.Forms.Label
    Friend WithEvents gbDepartment As System.Windows.Forms.GroupBox
    Friend WithEvents lblDeptID As System.Windows.Forms.Label
    Friend WithEvents txtDeptID As System.Windows.Forms.TextBox
    Friend WithEvents txtDeptName As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents txtCreatedBy As System.Windows.Forms.TextBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents DateTimeCreateDate As System.Windows.Forms.TextBox
    Friend WithEvents DateTimeUpdateDate As System.Windows.Forms.TextBox
End Class
