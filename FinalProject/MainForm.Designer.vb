<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Me.lblWelcomeText = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.MenuStripMain = New System.Windows.Forms.MenuStrip()
        Me.FileSystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.QueryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnCreateAccount = New System.Windows.Forms.Button()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStripMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblWelcomeText
        '
        Me.lblWelcomeText.AutoSize = True
        Me.lblWelcomeText.Location = New System.Drawing.Point(250, 59)
        Me.lblWelcomeText.Name = "lblWelcomeText"
        Me.lblWelcomeText.Size = New System.Drawing.Size(0, 13)
        Me.lblWelcomeText.TabIndex = 3
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Location = New System.Drawing.Point(125, 59)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(65, 13)
        Me.lblWelcome.TabIndex = 2
        Me.lblWelcome.Text = "WELCOME:"
        '
        'MenuStripMain
        '
        Me.MenuStripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileSystemToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.MenuStripMain.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripMain.Name = "MenuStripMain"
        Me.MenuStripMain.Size = New System.Drawing.Size(387, 24)
        Me.MenuStripMain.TabIndex = 4
        '
        'FileSystemToolStripMenuItem
        '
        Me.FileSystemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DepartmentToolStripMenuItem, Me.CategoryToolStripMenuItem, Me.ProductsToolStripMenuItem, Me.SupplierToolStripMenuItem, Me.BorrowToolStripMenuItem, Me.PurchaseOrderToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileSystemToolStripMenuItem.Name = "FileSystemToolStripMenuItem"
        Me.FileSystemToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.FileSystemToolStripMenuItem.Text = "File System"
        '
        'DepartmentToolStripMenuItem
        '
        Me.DepartmentToolStripMenuItem.Name = "DepartmentToolStripMenuItem"
        Me.DepartmentToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.DepartmentToolStripMenuItem.Text = "Department"
        '
        'CategoryToolStripMenuItem
        '
        Me.CategoryToolStripMenuItem.Name = "CategoryToolStripMenuItem"
        Me.CategoryToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.CategoryToolStripMenuItem.Text = "Category"
        '
        'ProductsToolStripMenuItem
        '
        Me.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem"
        Me.ProductsToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ProductsToolStripMenuItem.Text = "Products"
        '
        'SupplierToolStripMenuItem
        '
        Me.SupplierToolStripMenuItem.Name = "SupplierToolStripMenuItem"
        Me.SupplierToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.SupplierToolStripMenuItem.Text = "Supplier"
        '
        'BorrowToolStripMenuItem
        '
        Me.BorrowToolStripMenuItem.Name = "BorrowToolStripMenuItem"
        Me.BorrowToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.BorrowToolStripMenuItem.Text = "Borrow"
        '
        'PurchaseOrderToolStripMenuItem
        '
        Me.PurchaseOrderToolStripMenuItem.Name = "PurchaseOrderToolStripMenuItem"
        Me.PurchaseOrderToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.PurchaseOrderToolStripMenuItem.Text = "Purchase Order"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportsToolStripMenuItem1, Me.QueryToolStripMenuItem, Me.BackupToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.ReportsToolStripMenuItem.Text = "Utilities"
        '
        'ReportsToolStripMenuItem1
        '
        Me.ReportsToolStripMenuItem1.Name = "ReportsToolStripMenuItem1"
        Me.ReportsToolStripMenuItem1.Size = New System.Drawing.Size(114, 22)
        Me.ReportsToolStripMenuItem1.Text = "Reports"
        '
        'QueryToolStripMenuItem
        '
        Me.QueryToolStripMenuItem.Name = "QueryToolStripMenuItem"
        Me.QueryToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.QueryToolStripMenuItem.Text = "Query"
        '
        'BackupToolStripMenuItem
        '
        Me.BackupToolStripMenuItem.Name = "BackupToolStripMenuItem"
        Me.BackupToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.BackupToolStripMenuItem.Text = "Backup"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(91, 104)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 5
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.Location = New System.Drawing.Point(117, 189)
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.Size = New System.Drawing.Size(147, 46)
        Me.btnCreateAccount.TabIndex = 6
        Me.btnCreateAccount.Text = "Create Account"
        Me.btnCreateAccount.UseVisualStyleBackColor = True
        '
        'lblDateTime
        '
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.Location = New System.Drawing.Point(146, 144)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(0, 25)
        Me.lblDateTime.TabIndex = 7
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 330)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblDateTime)
        Me.Controls.Add(Me.btnCreateAccount)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lblWelcomeText)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.MenuStripMain)
        Me.MainMenuStrip = Me.MenuStripMain
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Main Form                   "
        Me.MenuStripMain.ResumeLayout(False)
        Me.MenuStripMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWelcomeText As System.Windows.Forms.Label
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents MenuStripMain As System.Windows.Forms.MenuStrip
    Friend WithEvents FileSystemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepartmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents BorrowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchaseOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QueryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCreateAccount As System.Windows.Forms.Button
    Friend WithEvents lblDateTime As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
