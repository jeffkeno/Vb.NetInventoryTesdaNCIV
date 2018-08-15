<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Product
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
        Me.dgvProduct = New System.Windows.Forms.DataGridView()
        Me.gbProduct = New System.Windows.Forms.GroupBox()
        Me.txtPriceA = New System.Windows.Forms.TextBox()
        Me.lblPriceA = New System.Windows.Forms.Label()
        Me.txtPriceB = New System.Windows.Forms.TextBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.lblPriceB = New System.Windows.Forms.Label()
        Me.lblMarkUp = New System.Windows.Forms.Label()
        Me.txtPriceC = New System.Windows.Forms.TextBox()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblPriceC = New System.Windows.Forms.Label()
        Me.txtMarkUp = New System.Windows.Forms.TextBox()
        Me.txtPriceD = New System.Windows.Forms.TextBox()
        Me.lblPriceD = New System.Windows.Forms.Label()
        Me.txtItemID = New System.Windows.Forms.TextBox()
        Me.lblProductUOM = New System.Windows.Forms.Label()
        Me.txtProductUOM = New System.Windows.Forms.TextBox()
        Me.lblProductSDescription = New System.Windows.Forms.Label()
        Me.txtProductSDescription = New System.Windows.Forms.TextBox()
        Me.txtPriceE = New System.Windows.Forms.TextBox()
        Me.lblPriceE = New System.Windows.Forms.Label()
        Me.lblItemID = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.DateTimeUpdateDate = New System.Windows.Forms.TextBox()
        Me.DateTimeCreateDate = New System.Windows.Forms.TextBox()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.txtUpdateBy = New System.Windows.Forms.TextBox()
        Me.txtCreatedBy = New System.Windows.Forms.TextBox()
        Me.lblIpdateBy = New System.Windows.Forms.Label()
        Me.lblUpdateDate = New System.Windows.Forms.Label()
        Me.lblCreatedBy = New System.Windows.Forms.Label()
        Me.lblCreateDate = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblRemarks = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.lblPCID = New System.Windows.Forms.Label()
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.lblProductID = New System.Windows.Forms.Label()
        Me.txtPCID = New System.Windows.Forms.TextBox()
        Me.lblProductCode = New System.Windows.Forms.Label()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.txtProductCode = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.MenuStripMain.SuspendLayout()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbProduct.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStripMain
        '
        Me.MenuStripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem})
        Me.MenuStripMain.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripMain.Name = "MenuStripMain"
        Me.MenuStripMain.Size = New System.Drawing.Size(1105, 24)
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
        'dgvProduct
        '
        Me.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduct.Location = New System.Drawing.Point(577, 64)
        Me.dgvProduct.Name = "dgvProduct"
        Me.dgvProduct.Size = New System.Drawing.Size(503, 401)
        Me.dgvProduct.TabIndex = 14
        '
        'gbProduct
        '
        Me.gbProduct.Controls.Add(Me.txtPriceA)
        Me.gbProduct.Controls.Add(Me.lblPriceA)
        Me.gbProduct.Controls.Add(Me.txtPriceB)
        Me.gbProduct.Controls.Add(Me.txtCost)
        Me.gbProduct.Controls.Add(Me.lblPriceB)
        Me.gbProduct.Controls.Add(Me.lblMarkUp)
        Me.gbProduct.Controls.Add(Me.txtPriceC)
        Me.gbProduct.Controls.Add(Me.lblCost)
        Me.gbProduct.Controls.Add(Me.lblPriceC)
        Me.gbProduct.Controls.Add(Me.txtMarkUp)
        Me.gbProduct.Controls.Add(Me.txtPriceD)
        Me.gbProduct.Controls.Add(Me.lblPriceD)
        Me.gbProduct.Controls.Add(Me.txtItemID)
        Me.gbProduct.Controls.Add(Me.lblProductUOM)
        Me.gbProduct.Controls.Add(Me.txtProductUOM)
        Me.gbProduct.Controls.Add(Me.lblProductSDescription)
        Me.gbProduct.Controls.Add(Me.txtProductSDescription)
        Me.gbProduct.Controls.Add(Me.txtPriceE)
        Me.gbProduct.Controls.Add(Me.lblPriceE)
        Me.gbProduct.Controls.Add(Me.lblItemID)
        Me.gbProduct.Controls.Add(Me.btnDelete)
        Me.gbProduct.Controls.Add(Me.DateTimeUpdateDate)
        Me.gbProduct.Controls.Add(Me.DateTimeCreateDate)
        Me.gbProduct.Controls.Add(Me.cbStatus)
        Me.gbProduct.Controls.Add(Me.txtUpdateBy)
        Me.gbProduct.Controls.Add(Me.txtCreatedBy)
        Me.gbProduct.Controls.Add(Me.lblIpdateBy)
        Me.gbProduct.Controls.Add(Me.lblUpdateDate)
        Me.gbProduct.Controls.Add(Me.lblCreatedBy)
        Me.gbProduct.Controls.Add(Me.lblCreateDate)
        Me.gbProduct.Controls.Add(Me.lblStatus)
        Me.gbProduct.Controls.Add(Me.lblRemarks)
        Me.gbProduct.Controls.Add(Me.txtRemarks)
        Me.gbProduct.Controls.Add(Me.lblPCID)
        Me.gbProduct.Controls.Add(Me.txtProductID)
        Me.gbProduct.Controls.Add(Me.lblProductID)
        Me.gbProduct.Controls.Add(Me.txtPCID)
        Me.gbProduct.Controls.Add(Me.lblProductCode)
        Me.gbProduct.Controls.Add(Me.lblProductName)
        Me.gbProduct.Controls.Add(Me.txtProductName)
        Me.gbProduct.Controls.Add(Me.txtProductCode)
        Me.gbProduct.Controls.Add(Me.btnAdd)
        Me.gbProduct.Controls.Add(Me.btnUpdate)
        Me.gbProduct.Location = New System.Drawing.Point(34, 48)
        Me.gbProduct.Name = "gbProduct"
        Me.gbProduct.Size = New System.Drawing.Size(502, 487)
        Me.gbProduct.TabIndex = 15
        Me.gbProduct.TabStop = False
        Me.gbProduct.Text = "Product Info"
        '
        'txtPriceA
        '
        Me.txtPriceA.Location = New System.Drawing.Point(372, 25)
        Me.txtPriceA.Name = "txtPriceA"
        Me.txtPriceA.Size = New System.Drawing.Size(100, 20)
        Me.txtPriceA.TabIndex = 78
        '
        'lblPriceA
        '
        Me.lblPriceA.AutoSize = True
        Me.lblPriceA.Location = New System.Drawing.Point(281, 28)
        Me.lblPriceA.Name = "lblPriceA"
        Me.lblPriceA.Size = New System.Drawing.Size(44, 13)
        Me.lblPriceA.TabIndex = 77
        Me.lblPriceA.Text = "Price A:"
        '
        'txtPriceB
        '
        Me.txtPriceB.Location = New System.Drawing.Point(372, 57)
        Me.txtPriceB.Name = "txtPriceB"
        Me.txtPriceB.Size = New System.Drawing.Size(100, 20)
        Me.txtPriceB.TabIndex = 76
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(161, 323)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(100, 20)
        Me.txtCost.TabIndex = 61
        '
        'lblPriceB
        '
        Me.lblPriceB.AutoSize = True
        Me.lblPriceB.Location = New System.Drawing.Point(281, 60)
        Me.lblPriceB.Name = "lblPriceB"
        Me.lblPriceB.Size = New System.Drawing.Size(44, 13)
        Me.lblPriceB.TabIndex = 75
        Me.lblPriceB.Text = "Price B:"
        '
        'lblMarkUp
        '
        Me.lblMarkUp.AutoSize = True
        Me.lblMarkUp.Location = New System.Drawing.Point(6, 353)
        Me.lblMarkUp.Name = "lblMarkUp"
        Me.lblMarkUp.Size = New System.Drawing.Size(51, 13)
        Me.lblMarkUp.TabIndex = 58
        Me.lblMarkUp.Text = "Mark Up:"
        '
        'txtPriceC
        '
        Me.txtPriceC.Location = New System.Drawing.Point(372, 92)
        Me.txtPriceC.Name = "txtPriceC"
        Me.txtPriceC.Size = New System.Drawing.Size(100, 20)
        Me.txtPriceC.TabIndex = 74
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(6, 323)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(31, 13)
        Me.lblCost.TabIndex = 59
        Me.lblCost.Text = "Cost:"
        '
        'lblPriceC
        '
        Me.lblPriceC.AutoSize = True
        Me.lblPriceC.Location = New System.Drawing.Point(282, 92)
        Me.lblPriceC.Name = "lblPriceC"
        Me.lblPriceC.Size = New System.Drawing.Size(44, 13)
        Me.lblPriceC.TabIndex = 73
        Me.lblPriceC.Text = "Price C:"
        '
        'txtMarkUp
        '
        Me.txtMarkUp.Location = New System.Drawing.Point(161, 353)
        Me.txtMarkUp.Name = "txtMarkUp"
        Me.txtMarkUp.Size = New System.Drawing.Size(100, 20)
        Me.txtMarkUp.TabIndex = 63
        '
        'txtPriceD
        '
        Me.txtPriceD.Location = New System.Drawing.Point(373, 126)
        Me.txtPriceD.Name = "txtPriceD"
        Me.txtPriceD.Size = New System.Drawing.Size(100, 20)
        Me.txtPriceD.TabIndex = 72
        '
        'lblPriceD
        '
        Me.lblPriceD.AutoSize = True
        Me.lblPriceD.Location = New System.Drawing.Point(281, 126)
        Me.lblPriceD.Name = "lblPriceD"
        Me.lblPriceD.Size = New System.Drawing.Size(45, 13)
        Me.lblPriceD.TabIndex = 71
        Me.lblPriceD.Text = "Price D:"
        '
        'txtItemID
        '
        Me.txtItemID.Location = New System.Drawing.Point(161, 55)
        Me.txtItemID.Name = "txtItemID"
        Me.txtItemID.Size = New System.Drawing.Size(100, 20)
        Me.txtItemID.TabIndex = 70
        '
        'lblProductUOM
        '
        Me.lblProductUOM.AutoSize = True
        Me.lblProductUOM.Location = New System.Drawing.Point(7, 222)
        Me.lblProductUOM.Name = "lblProductUOM"
        Me.lblProductUOM.Size = New System.Drawing.Size(75, 13)
        Me.lblProductUOM.TabIndex = 66
        Me.lblProductUOM.Text = "Product UOM:"
        '
        'txtProductUOM
        '
        Me.txtProductUOM.Location = New System.Drawing.Point(161, 219)
        Me.txtProductUOM.Name = "txtProductUOM"
        Me.txtProductUOM.Size = New System.Drawing.Size(100, 20)
        Me.txtProductUOM.TabIndex = 67
        '
        'lblProductSDescription
        '
        Me.lblProductSDescription.AutoSize = True
        Me.lblProductSDescription.Location = New System.Drawing.Point(7, 191)
        Me.lblProductSDescription.Name = "lblProductSDescription"
        Me.lblProductSDescription.Size = New System.Drawing.Size(131, 13)
        Me.lblProductSDescription.TabIndex = 64
        Me.lblProductSDescription.Text = "Product Short Description:"
        '
        'txtProductSDescription
        '
        Me.txtProductSDescription.Location = New System.Drawing.Point(161, 188)
        Me.txtProductSDescription.Name = "txtProductSDescription"
        Me.txtProductSDescription.Size = New System.Drawing.Size(100, 20)
        Me.txtProductSDescription.TabIndex = 65
        '
        'txtPriceE
        '
        Me.txtPriceE.Location = New System.Drawing.Point(372, 164)
        Me.txtPriceE.Name = "txtPriceE"
        Me.txtPriceE.Size = New System.Drawing.Size(100, 20)
        Me.txtPriceE.TabIndex = 62
        '
        'lblPriceE
        '
        Me.lblPriceE.AutoSize = True
        Me.lblPriceE.Location = New System.Drawing.Point(282, 164)
        Me.lblPriceE.Name = "lblPriceE"
        Me.lblPriceE.Size = New System.Drawing.Size(44, 13)
        Me.lblPriceE.TabIndex = 60
        Me.lblPriceE.Text = "Price E:"
        '
        'lblItemID
        '
        Me.lblItemID.AutoSize = True
        Me.lblItemID.Location = New System.Drawing.Point(7, 55)
        Me.lblItemID.Name = "lblItemID"
        Me.lblItemID.Size = New System.Drawing.Size(44, 13)
        Me.lblItemID.TabIndex = 54
        Me.lblItemID.Text = "Item ID:"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(314, 408)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(113, 36)
        Me.btnDelete.TabIndex = 52
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'DateTimeUpdateDate
        '
        Me.DateTimeUpdateDate.Enabled = False
        Me.DateTimeUpdateDate.Location = New System.Drawing.Point(373, 313)
        Me.DateTimeUpdateDate.Name = "DateTimeUpdateDate"
        Me.DateTimeUpdateDate.Size = New System.Drawing.Size(100, 20)
        Me.DateTimeUpdateDate.TabIndex = 51
        '
        'DateTimeCreateDate
        '
        Me.DateTimeCreateDate.Enabled = False
        Me.DateTimeCreateDate.Location = New System.Drawing.Point(372, 245)
        Me.DateTimeCreateDate.Name = "DateTimeCreateDate"
        Me.DateTimeCreateDate.Size = New System.Drawing.Size(100, 20)
        Me.DateTimeCreateDate.TabIndex = 46
        '
        'cbStatus
        '
        Me.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"Y", "N"})
        Me.cbStatus.Location = New System.Drawing.Point(161, 259)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(100, 21)
        Me.cbStatus.TabIndex = 45
        '
        'txtUpdateBy
        '
        Me.txtUpdateBy.Location = New System.Drawing.Point(373, 278)
        Me.txtUpdateBy.Name = "txtUpdateBy"
        Me.txtUpdateBy.Size = New System.Drawing.Size(100, 20)
        Me.txtUpdateBy.TabIndex = 33
        '
        'txtCreatedBy
        '
        Me.txtCreatedBy.Enabled = False
        Me.txtCreatedBy.Location = New System.Drawing.Point(372, 200)
        Me.txtCreatedBy.Name = "txtCreatedBy"
        Me.txtCreatedBy.Size = New System.Drawing.Size(100, 20)
        Me.txtCreatedBy.TabIndex = 32
        '
        'lblIpdateBy
        '
        Me.lblIpdateBy.AutoSize = True
        Me.lblIpdateBy.Location = New System.Drawing.Point(282, 281)
        Me.lblIpdateBy.Name = "lblIpdateBy"
        Me.lblIpdateBy.Size = New System.Drawing.Size(60, 13)
        Me.lblIpdateBy.TabIndex = 31
        Me.lblIpdateBy.Text = "Update By:"
        '
        'lblUpdateDate
        '
        Me.lblUpdateDate.AutoSize = True
        Me.lblUpdateDate.Location = New System.Drawing.Point(282, 312)
        Me.lblUpdateDate.Name = "lblUpdateDate"
        Me.lblUpdateDate.Size = New System.Drawing.Size(71, 13)
        Me.lblUpdateDate.TabIndex = 30
        Me.lblUpdateDate.Text = "Update Date:"
        '
        'lblCreatedBy
        '
        Me.lblCreatedBy.AutoSize = True
        Me.lblCreatedBy.Location = New System.Drawing.Point(281, 203)
        Me.lblCreatedBy.Name = "lblCreatedBy"
        Me.lblCreatedBy.Size = New System.Drawing.Size(62, 13)
        Me.lblCreatedBy.TabIndex = 29
        Me.lblCreatedBy.Text = "Created By:"
        '
        'lblCreateDate
        '
        Me.lblCreateDate.AutoSize = True
        Me.lblCreateDate.Location = New System.Drawing.Point(281, 244)
        Me.lblCreateDate.Name = "lblCreateDate"
        Me.lblCreateDate.Size = New System.Drawing.Size(67, 13)
        Me.lblCreateDate.TabIndex = 28
        Me.lblCreateDate.Text = "Create Date:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(7, 262)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(40, 13)
        Me.lblStatus.TabIndex = 27
        Me.lblStatus.Text = "Status:"
        '
        'lblRemarks
        '
        Me.lblRemarks.AutoSize = True
        Me.lblRemarks.Location = New System.Drawing.Point(7, 298)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(52, 13)
        Me.lblRemarks.TabIndex = 24
        Me.lblRemarks.Text = "Remarks:"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(161, 295)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(100, 20)
        Me.txtRemarks.TabIndex = 26
        '
        'lblPCID
        '
        Me.lblPCID.AutoSize = True
        Me.lblPCID.Location = New System.Drawing.Point(6, 81)
        Me.lblPCID.Name = "lblPCID"
        Me.lblPCID.Size = New System.Drawing.Size(106, 13)
        Me.lblPCID.TabIndex = 20
        Me.lblPCID.Text = "Product Category ID:"
        '
        'txtProductID
        '
        Me.txtProductID.Location = New System.Drawing.Point(161, 25)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Size = New System.Drawing.Size(100, 20)
        Me.txtProductID.TabIndex = 17
        '
        'lblProductID
        '
        Me.lblProductID.AutoSize = True
        Me.lblProductID.Location = New System.Drawing.Point(7, 25)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(61, 13)
        Me.lblProductID.TabIndex = 22
        Me.lblProductID.Text = "Product ID:"
        '
        'txtPCID
        '
        Me.txtPCID.Location = New System.Drawing.Point(161, 84)
        Me.txtPCID.Name = "txtPCID"
        Me.txtPCID.Size = New System.Drawing.Size(100, 20)
        Me.txtPCID.TabIndex = 15
        '
        'lblProductCode
        '
        Me.lblProductCode.AutoSize = True
        Me.lblProductCode.Location = New System.Drawing.Point(7, 154)
        Me.lblProductCode.Name = "lblProductCode"
        Me.lblProductCode.Size = New System.Drawing.Size(75, 13)
        Me.lblProductCode.TabIndex = 23
        Me.lblProductCode.Text = "Product Code:"
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Location = New System.Drawing.Point(6, 123)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(78, 13)
        Me.lblProductName.TabIndex = 14
        Me.lblProductName.Text = "Product Name:"
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(161, 116)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(100, 20)
        Me.txtProductName.TabIndex = 19
        '
        'txtProductCode
        '
        Me.txtProductCode.Location = New System.Drawing.Point(161, 151)
        Me.txtProductCode.Name = "txtProductCode"
        Me.txtProductCode.Size = New System.Drawing.Size(100, 20)
        Me.txtProductCode.TabIndex = 18
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(41, 408)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(113, 36)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(182, 408)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(113, 36)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1105, 547)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvProduct)
        Me.Controls.Add(Me.gbProduct)
        Me.Controls.Add(Me.MenuStripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Product"
        Me.Text = "Product"
        Me.MenuStripMain.ResumeLayout(False)
        Me.MenuStripMain.PerformLayout()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbProduct.ResumeLayout(False)
        Me.gbProduct.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStripMain As System.Windows.Forms.MenuStrip
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgvProduct As System.Windows.Forms.DataGridView
    Friend WithEvents gbProduct As System.Windows.Forms.GroupBox
    Friend WithEvents txtPriceA As System.Windows.Forms.TextBox
    Friend WithEvents lblPriceA As System.Windows.Forms.Label
    Friend WithEvents txtPriceB As System.Windows.Forms.TextBox
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents lblPriceB As System.Windows.Forms.Label
    Friend WithEvents lblMarkUp As System.Windows.Forms.Label
    Friend WithEvents txtPriceC As System.Windows.Forms.TextBox
    Friend WithEvents lblCost As System.Windows.Forms.Label
    Friend WithEvents lblPriceC As System.Windows.Forms.Label
    Friend WithEvents txtMarkUp As System.Windows.Forms.TextBox
    Friend WithEvents txtPriceD As System.Windows.Forms.TextBox
    Friend WithEvents lblPriceD As System.Windows.Forms.Label
    Friend WithEvents txtItemID As System.Windows.Forms.TextBox
    Friend WithEvents lblProductUOM As System.Windows.Forms.Label
    Friend WithEvents txtProductUOM As System.Windows.Forms.TextBox
    Friend WithEvents lblProductSDescription As System.Windows.Forms.Label
    Friend WithEvents txtProductSDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtPriceE As System.Windows.Forms.TextBox
    Friend WithEvents lblPriceE As System.Windows.Forms.Label
    Friend WithEvents lblItemID As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents DateTimeUpdateDate As System.Windows.Forms.TextBox
    Friend WithEvents DateTimeCreateDate As System.Windows.Forms.TextBox
    Friend WithEvents cbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents txtUpdateBy As System.Windows.Forms.TextBox
    Friend WithEvents txtCreatedBy As System.Windows.Forms.TextBox
    Friend WithEvents lblIpdateBy As System.Windows.Forms.Label
    Friend WithEvents lblUpdateDate As System.Windows.Forms.Label
    Friend WithEvents lblCreatedBy As System.Windows.Forms.Label
    Friend WithEvents lblCreateDate As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblRemarks As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents lblPCID As System.Windows.Forms.Label
    Friend WithEvents txtProductID As System.Windows.Forms.TextBox
    Friend WithEvents lblProductID As System.Windows.Forms.Label
    Friend WithEvents txtPCID As System.Windows.Forms.TextBox
    Friend WithEvents lblProductCode As System.Windows.Forms.Label
    Friend WithEvents lblProductName As System.Windows.Forms.Label
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents txtProductCode As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
End Class
