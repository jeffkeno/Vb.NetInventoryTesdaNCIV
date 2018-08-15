Imports System.Data.SqlClient
Public Class CreateAccountForm
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection

    Private Sub MainToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainToolStripMenuItem.Click
        MainForm.Show()
        Me.Hide()
    End Sub

    Private Sub CreateAccountForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainForm.Hide()
        con.ConnectionString = My.Resources.connectString
        cmd.Connection = con
        getAllItems()
        FilterData("")
        txtPassword.UseSystemPasswordChar = True
        txtConfirmPassword.UseSystemPasswordChar = True
    End Sub

    Sub getAllItems()
        Dim querySelect As String = "SELECT * FROM tblUserName"
        con.ConnectionString = My.Resources.connectString
        Dim dTable As New DataTable
        Dim adapter As New SqlDataAdapter(querySelect, con)
        Try
            con.Open()
            adapter.Fill(dTable)
            dgvUser.DataSource = dTable
            dgvUser.Columns(1).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, , "Select")
        Finally
            con.Close()
        End Try
    End Sub

    Sub clearAll()
        txtUserName.Clear()
        txtPassword.Clear()
        txtConfirmPassword.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
    End Sub

    Function checkTextBox(ByVal txt1 As String, ByVal txt2 As String, ByVal txt3 As String, ByVal txt4 As String, ByVal txt5 As String) As Boolean
        If String.IsNullOrWhiteSpace(txt1) _
        Or String.IsNullOrWhiteSpace(txt2) _
        Or String.IsNullOrWhiteSpace(txt3) _
        Or String.IsNullOrWhiteSpace(txt4) _
        Or String.IsNullOrWhiteSpace(txt5) Then
            Return False
        Else
            Return True
        End If
    End Function

    'Function checkSearch(ByVal txt1 As String) As Boolean
    '    If String.IsNullOrWhiteSpace(txt1) Then
    '        Return False
    '    Else
    '        Return True
    '    End If
    'End Function

    Function checkDelete(ByVal txt1 As String) As Boolean
        If String.IsNullOrWhiteSpace(txt1) Then
            Return False
        Else
            Return True
        End If
    End Function
    Function checkPassword(ByVal txt1 As String) As Boolean
        If String.IsNullOrWhiteSpace(txt1) Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub txtUser(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserName.KeyPress
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

    Private Sub txtPass(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress, txtConfirmPassword.KeyPress
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

    Private Sub txtFirst(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFirstName.KeyPress, txtLastName.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not (Asc(e.KeyChar) = 32) Then
                If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
                    e.KeyChar = ChrW(0)
                    MessageBox.Show("Please enter a letters only")
                    e.Handled = True
                End If
            End If
        End If
    End Sub


    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        If checkTextBox(txtUserName.Text, txtPassword.Text, txtConfirmPassword.Text, txtFirstName.Text, txtLastName.Text) = True Then
          
                Dim txtu As String = txtUserName.Text
                Dim txtp As String = txtPassword.Text
            '  Dim txtpc As String = txtConfirmPassword.Text
                Dim txtfn As String = txtFirstName.Text
                Dim txtln As String = txtLastName.Text
            If txtPassword.Text <> txtConfirmPassword.Text Then
                MsgBox("Password mismatched")
            Else
                Dim addUser As String = "INSERT INTO tblUserName(clmUserName,clmPassword,clmFirstName,clmLastName) VALUES(@uname,@pname,@fname,@lname)"
                con.ConnectionString = My.Resources.connectString
                cmd.Connection = con
                cmd.CommandText = addUser
                cmd.Parameters.AddWithValue("@uname", txtu)
                cmd.Parameters.AddWithValue("@pname", txtp)
                cmd.Parameters.AddWithValue("@fname", txtfn)
                cmd.Parameters.AddWithValue("@lname", txtln)

                Dim rowsAffected As Integer
                Try
                    con.Open()
                    rowsAffected = cmd.ExecuteNonQuery
                Catch ex As Exception
                    MsgBox(ex.Message, , "INSERT QUERY ERROR")
                Finally
                    con.Close()
                    cmd.Parameters.Clear()
                End Try
                If rowsAffected = 1 Then
                    MsgBox("User Added")
                Else
                    MsgBox("User did not Added")
                End If
                txtUserName.Focus()
                clearAll()
            End If
        Else
            MsgBox("Fill up all the text")

        End If
            Me.getAllItems()
    End Sub



    Private Sub dgvUser_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvUser.CellContentClick
        btnCreate.Enabled = False
        txtUserName.Text = Trim(dgvUser.CurrentRow.Cells("clmUserName").Value.ToString)
        ' txtUserName.Enabled = False
        txtPassword.Text = Trim(dgvUser.CurrentRow.Cells("clmPassword").Value.ToString)
        txtConfirmPassword.Text = Trim(dgvUser.CurrentRow.Cells("clmPassword").Value.ToString)
        txtFirstName.Text = Trim(dgvUser.CurrentRow.Cells("clmFirstName").Value.ToString)
        txtLastName.Text = Trim(dgvUser.CurrentRow.Cells("clmLastName").Value.ToString)
    End Sub


    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        btnCreate.Enabled = True
        If checkTextBox(txtUserName.Text, txtPassword.Text, txtConfirmPassword.Text, txtFirstName.Text, txtLastName.Text) = True Then

            Dim txtu As String = txtUserName.Text
            Dim txtp As String = txtPassword.Text
            Dim txtfn As String = txtFirstName.Text
            Dim txtln As String = txtLastName.Text
            If txtPassword.Text <> txtConfirmPassword.Text Then
                MsgBox("Password mismatched")
            Else
                Dim EditUser As String = "UPDATE tblUserName Set clmPassword ='" & txtPassword.Text & "', clmFirstName ='" & txtFirstName.Text & "', clmLastName ='" & txtLastName.Text & "' WHERE clmUserName='" & txtUserName.Text & "'"
                con.ConnectionString = My.Resources.connectString
                cmd.Connection = con
                cmd.CommandText = EditUser
                cmd.Parameters.AddWithValue("@pname", txtp)
                cmd.Parameters.AddWithValue("@fname", txtfn)
                cmd.Parameters.AddWithValue("@lname", txtln)

                Dim rowsAffected As Integer
                Try
                    con.Open()
                    rowsAffected = cmd.ExecuteNonQuery
                Catch ex As Exception
                    MsgBox(ex.Message, , "INSERT QUERY ERROR")
                Finally
                    con.Close()
                    cmd.Parameters.Clear()
                End Try
                If rowsAffected = 1 Then
                    MsgBox("User Added")
                Else
                    MsgBox("User did not Added")
                End If
                txtUserName.Focus()
                clearAll()
            End If
        Else
            MsgBox("Fill up all the text")

        End If
        Me.getAllItems()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        If checkDelete(txtUserName.Text) = True Then
            If MessageBox.Show("Are you sure you want to delete this record " & txtUserName.Text & "?", "Confirm Delete", MessageBoxButtons.YesNo) =
                    Windows.Forms.DialogResult.Yes Then
                Dim txtu As String = txtUserName.Text
                Dim DeleteUser As String = "DELETE FROM tblUserName WHERE clmUserName=@uname"
                con.ConnectionString = My.Resources.connectString
                cmd.Connection = con
                cmd.CommandText = DeleteUser
                cmd.Parameters.AddWithValue("@uname", txtu)

                Dim rowsAffected As Integer

                Try
                    con.Open()
                    rowsAffected = cmd.ExecuteNonQuery
                Catch ex As Exception
                    MsgBox(ex.Message, , "DELETE QUERY ERROR")
                Finally
                    con.Close()
                    cmd.Parameters.Clear()
                End Try

                If rowsAffected = 1 Then
                    MsgBox("User deleted")
                Else
                    MsgBox("User did not deleted")
                End If
            End If
        Else
            MsgBox("Select a ID you want to delete")

        End If
        Me.getAllItems()
    End Sub
    Private Sub FilterData(ByVal valueToSearch As String)
        Dim SearchUser As String = "SELECT * FROM tblUserName WHERE" & " [clmUserName] like '%" & valueToSearch & "%'"
        Dim adapter As New SqlDataAdapter(SearchUser, con)
        Dim dTable As New DataTable()
        adapter.Fill(dTable)
        dgvUser.DataSource = dTable

    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        If checkPassword(txtPassword.Text) = True Then
            If btnShow.Text = "Show" Then
                btnShow.Text = "Unshow"
                txtPassword.UseSystemPasswordChar = False
                txtConfirmPassword.UseSystemPasswordChar = False
            ElseIf btnShow.Text = "Unshow" Then
                btnShow.Text = "Show"
                txtPassword.UseSystemPasswordChar = True
                txtConfirmPassword.UseSystemPasswordChar = True
            End If
        Else
            MsgBox("Select ID to view the password")
        End If
    End Sub
    
    Private Sub txtUserName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUserName.TextChanged
        FilterData(txtUserName.Text)
    End Sub
End Class