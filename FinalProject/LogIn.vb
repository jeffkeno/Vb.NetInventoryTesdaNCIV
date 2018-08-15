Imports System.Data.SqlClient
Public Class LogIn
    ' Dim connectString = "Data Source=.\SQLYERFFEJ;Initial Catalog=dbProject;Integrated Security=True;" '---------------connection string
    '  "Data Source=.\SQLEXPRESS;Integrated Security=False;Initial Catalog = dbAndutan; User ID=sa;Password=student;" '---------------connection string
    'Integrated Security=True; gumagana pag professional version
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection
    

    Private Sub LogIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = My.Resources.connectString
        cmd.Connection = con
    End Sub
    Function checkTextBox(ByVal txt1 As String, ByVal txt2 As String) As Boolean
        If String.IsNullOrWhiteSpace(txt1) _
         Or String.IsNullOrWhiteSpace(txt2) Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub txtUser(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserName.KeyPress, txtPassword.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Then
                If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
                    e.KeyChar = ChrW(0)
                    MessageBox.Show("Please enter a letters and numbers only")
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub btnSignIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignIn.Click

        If checkTextBox(txtUserName.Text, txtPassword.Text) = True Then
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * FROM tblUserName WHERE [clmUserName]='" + txtUserName.Text + "'"
            cmd.Connection = con
            con.Open()
            Dim datasearch As SqlDataReader
            datasearch = cmd.ExecuteReader
            If datasearch.Read Then
                If txtPassword.Text = datasearch.Item("clmPassword") Then
                    '   Me.Hide()
                    MainForm.lblWelcomeText.Text = txtUserName.Text
                    DepartmentForm.txtCreatedBy.Text = txtUserName.Text
                    CategoryForm.txtCreatedBy.Text = txtUserName.Text
                    SupplierForm.txtCreatedBy.Text = txtUserName.Text
                    Product.txtCreatedBy.Text = txtUserName.Text
                    '   DepartmentForm.txtUpdateBy.Text = txtUserName.Text
                    MainForm.Show()
                    Me.txtUserName.Text = ""
                    Me.txtPassword.Text = ""
                Else
                    MessageBox.Show("Incorrect Password Entered", "Enter the correct password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtPassword.Focus()

                End If
            Else
                MessageBox.Show("Log In Failed", "Enter the correct account", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtUserName.Focus()
                txtPassword.Focus()
            End If

        Else
            MessageBox.Show("Error", "Complete the form", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        'End If
        con.Close()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MessageBox.Show("Are you sure want to close the Application", "Confirmation", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
