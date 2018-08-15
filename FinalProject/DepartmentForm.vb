Imports System.Data.SqlClient
Public Class DepartmentForm
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection
    Private Sub DepartmentForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainForm.Hide()
        LogIn.Hide()
        DateTimeCreateDate.Text = Date.Now().ToString("MMM/dd-yyyy")
        DateTimeUpdateDate.Text = Date.Now().ToString("MMM/dd-yyyy")
        con.ConnectionString = My.Resources.connectString
        cmd.Connection = con
        getAllItems()
    End Sub

    Function checkAddYes(ByVal txt1 As String, ByVal txt2 As String, ByVal txt3 As String, ByVal txt4 As String) As Boolean
        If String.IsNullOrWhiteSpace(txt1) _
         Or String.IsNullOrWhiteSpace(txt2) _
         Or String.IsNullOrWhiteSpace(txt3) _
         Or String.IsNullOrWhiteSpace(txt4) Then
            Return False
        Else
            Return True
        End If
    End Function
    Function checkEditYes(ByVal txt1 As String, ByVal txt2 As String, ByVal txt3 As String, ByVal txt4 As String) As Boolean
        If String.IsNullOrWhiteSpace(txt1) _
         Or String.IsNullOrWhiteSpace(txt2) _
          Or String.IsNullOrWhiteSpace(txt3) _
         Or String.IsNullOrWhiteSpace(txt4) Then
            Return False
        Else
            Return True
        End If
    End Function

    Function checkDelete(ByVal txt1 As String) As Boolean
        If String.IsNullOrWhiteSpace(txt1) Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub MainToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainToolStripMenuItem.Click
        MainForm.Show()
        Me.Hide()
    End Sub
    Sub getAllItems()
        Dim querySelect As String = "SELECT * FROM tblDept"
        con.ConnectionString = My.Resources.connectString
        Dim dTable As New DataTable
        Dim adapter As New SqlDataAdapter(querySelect, con)
        Try
            con.Open()
            adapter.Fill(dTable)
            dgvDepartment.DataSource = dTable
        Catch ex As Exception
            MsgBox(ex.Message, , "Select")
        Finally
            con.Close()
        End Try
    End Sub
    Sub clearAdd()
        txtDeptID.Clear()
        txtDeptName.Clear()
        ' txtCreatedBy.Clear()
    End Sub

    Sub clearEdit()
        txtDeptID.Clear()
        txtDeptName.Clear()
        txtUpdateBy.Clear()
    End Sub
    Private Sub txtDeparmentID(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDeptID.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Then
                e.KeyChar = ChrW(0)
                '     MessageBox.Show("Please enter numbers only for ID")
            End If
        End If
    End Sub

    Private Sub txtDepartmentName(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDeptName.KeyPress, txtCreatedBy.KeyPress, txtUpdateBy.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not (Asc(e.KeyChar) = 32) Then
                If Not (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Then
                    If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
                        e.KeyChar = ChrW(0)
                        '     MessageBox.Show("Please enter a letters and numbers only")
                    End If
                End If
            End If
        End If
    End Sub


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Dim txtID As String = txtDeptID.Text
        Dim txtdeptn As String = txtDeptName.Text
        Dim txtcreate As String = txtCreatedBy.Text
        Dim txtcreatedate As String = DateTimeCreateDate.Text

        If checkAddYes(txtDeptID.Text, txtDeptName.Text, txtCreatedBy.Text, DateTimeCreateDate.Text) = True Then
            Dim AddDepartmentYes As String = "INSERT INTO tblDept(DeptID,DeptName,Created_By,Created_Date) VALUES(@ID,@deptname,@created,@createdate)"
            con.ConnectionString = My.Resources.connectString
            cmd.Connection = con
            cmd.CommandText = AddDepartmentYes
            cmd.Parameters.AddWithValue("@ID", txtID)
            cmd.Parameters.AddWithValue("@deptname", txtdeptn)
            cmd.Parameters.AddWithValue("@created", txtcreate)
            cmd.Parameters.AddWithValue("@createdate", txtcreatedate)

            Dim rowsAffectedYes As Integer
            Try
                con.Open()
                rowsAffectedYes = cmd.ExecuteNonQuery
            Catch ex As Exception
                MsgBox(ex.Message, , "INSERT QUERY ERROR")
            Finally
                con.Close()
                cmd.Parameters.Clear()
            End Try
            If rowsAffectedYes = 1 Then
                MsgBox("Department Added")
            Else
                MsgBox("Department did not Added")
            End If
        Else
            MsgBox("Fill up all the text")

        End If

            clearAdd()
            getAllItems()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        btnAdd.Enabled = True
        Dim txtID As String = txtDeptID.Text
        Dim txtdeptn As String = txtDeptName.Text
        Dim txtupdate As String = txtUpdateBy.Text
        Dim txtupdatedate As String = DateTimeUpdateDate.Text

        If checkEditYes(txtDeptID.Text, txtDeptName.Text, txtUpdateBy.Text, DateTimeUpdateDate.Text) = True Then
            Dim EditDepartmentYes As String = "UPDATE tblDept SET DeptName=@deptname,Updated_By=@updated, Updated_Date=@update WHERE DeptID=@ID"
            con.ConnectionString = My.Resources.connectString
            cmd.Connection = con
            cmd.CommandText = EditDepartmentYes
            cmd.Parameters.AddWithValue("@ID", txtID)
            cmd.Parameters.AddWithValue("@deptname", txtdeptn)
            cmd.Parameters.AddWithValue("@updated", txtupdate)
            cmd.Parameters.AddWithValue("@update", txtupdatedate)

            Dim rowsAffectedYes As Integer
            Try
                con.Open()
                rowsAffectedYes = cmd.ExecuteNonQuery
            Catch ex As Exception
                MsgBox(ex.Message, , "UPDATE QUERY ERROR")
            Finally
                con.Close()
                cmd.Parameters.Clear()
            End Try
            If rowsAffectedYes = 1 Then
                MsgBox("Department Updated")
            Else
                MsgBox("Department did not Update")
            End If
            clearEdit()
            getAllItems()
        Else
            MsgBox("Fill up all the text")
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If checkDelete(txtDeptID.Text) = True Then
            If MessageBox.Show("Are you sure you want to delete this record " & txtDeptID.Text & "?", "Confirm Delete", MessageBoxButtons.YesNo) =
                  Windows.Forms.DialogResult.Yes Then
                Dim txtdept As String = txtDeptID.Text
                Dim DeleteDepartment As String = "DELETE FROM tblDept WHERE DeptID=@ID"
                con.ConnectionString = My.Resources.connectString
                cmd.Connection = con
                cmd.CommandText = DeleteDepartment
                cmd.Parameters.AddWithValue("@ID", txtdept)

                Dim rowsAffectedDelete As Integer

                Try
                    con.Open()
                    rowsAffectedDelete = cmd.ExecuteNonQuery
                Catch ex As Exception
                    MsgBox(ex.Message, , "DELETE QUERY ERROR")
                Finally
                    con.Close()
                    cmd.Parameters.Clear()
                End Try

                If rowsAffectedDelete = 1 Then
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



    Private Sub dgvDepartment_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDepartment.CellContentClick
        btnAdd.Enabled = False
        txtDeptID.Text = Trim(dgvDepartment.CurrentRow.Cells("DeptID").Value.ToString)
        txtDeptName.Text = Trim(dgvDepartment.CurrentRow.Cells("DeptName").Value.ToString)
        'txtCreatedBy.Text = Trim(dgvDepartment.CurrentRow.Cells("Created_By").Value.ToString)
        '   DateTimeCreateDate.Value = dgvDepartment.CurrentRow.Cells("Created_Date").Value
        ' txtUpdateBy.Text = Trim(dgvDepartment.CurrentRow.Cells("Updated_By").Value.ToString)
        '  DateTimeUpdateDate.Value = dgvDepartment.CurrentRow.Cells("Updated_Date").Value

    End Sub

    Private Sub FilterData(ByVal valueToSearch As String)
        Dim SearchUser As String = "SELECT * FROM tblDept WHERE" & " [DeptID] like '%" & valueToSearch & "%'"
        Dim adapter As New SqlDataAdapter(SearchUser, con)
        Dim dTable As New DataTable()
        adapter.Fill(dTable)
        dgvDepartment.DataSource = dTable

    End Sub

    Private Sub txtDeptID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDeptID.TextChanged
        FilterData(txtDeptID.Text)
    End Sub

End Class