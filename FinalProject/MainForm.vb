Public Class MainForm

    

    Private Sub DepartmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentToolStripMenuItem.Click
        DepartmentForm.Show()
        Me.Hide()

    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FileSystemToolStripMenuItem.HideDropDown()
        LogIn.Hide()
        CategoryForm.Hide()

    End Sub

   
  
    Private Sub CategoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoryToolStripMenuItem.Click
        CategoryForm.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If MessageBox.Show("Are you sure want to Logout?", "Confirmation", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Me.Hide()
            LogIn.Show()
        End If
    End Sub

    Private Sub btnCreateAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateAccount.Click
        CreateAccountForm.Show()
        Me.Hide()
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierToolStripMenuItem.Click
        SupplierForm.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblDateTime.Text = Date.Now().ToString("HH:mm:ss")
    End Sub

    Private Sub ProductsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductsToolStripMenuItem.Click
        Product.Show()
    End Sub
End Class