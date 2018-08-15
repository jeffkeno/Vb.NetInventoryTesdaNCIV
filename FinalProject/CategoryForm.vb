Imports System.Data.SqlClient

Public Class CategoryForm
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection

    Private Sub CategoryForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainForm.Hide()
        con.ConnectionString = My.Resources.connectString
        cmd.Connection = con
        getAllItems()
        DateTimeCreateDate.Text = Date.Now().ToString("MMM/dd-yyyy")
        DateTimeUpdateDate.Text = Date.Now().ToString("MMM/dd-yyyy")
    End Sub

    Sub getAllItems()
        Dim querySelect As String = "SELECT * FROM tblProduct_Category"
        con.ConnectionString = My.Resources.connectString
        Dim dTable As New DataTable
        Dim adapter As New SqlDataAdapter(querySelect, con)
        Try
            con.Open()
            adapter.Fill(dTable)
            dgvCategory.DataSource = dTable
        Catch ex As Exception
            MsgBox(ex.Message, , "Select")
        Finally
            con.Close()
        End Try
    End Sub

    Function checkAddYes(ByVal txt1 As String, ByVal txt2 As String, ByVal txt3 As String, ByVal txt4 As String, ByVal txt5 As String, ByVal txt6 As String) As Boolean
        If String.IsNullOrWhiteSpace(txt1) _
         Or String.IsNullOrWhiteSpace(txt2) _
          Or String.IsNullOrWhiteSpace(txt3) _
           Or String.IsNullOrWhiteSpace(txt4) _
            Or String.IsNullOrWhiteSpace(txt5) _
             Or String.IsNullOrWhiteSpace(txt6) Then
            Return False
        Else
            Return True
        End If
    End Function


    Function checkEditNo(ByVal txt1 As String, ByVal txt2 As String, ByVal txt3 As String, ByVal txt4 As String, ByVal txt5 As String, ByVal txt6 As String) As Boolean
        If String.IsNullOrWhiteSpace(txt1) _
         Or String.IsNullOrWhiteSpace(txt2) _
          Or String.IsNullOrWhiteSpace(txt3) _
            Or String.IsNullOrWhiteSpace(txt4) _
          Or String.IsNullOrWhiteSpace(txt5) _
            Or String.IsNullOrWhiteSpace(txt6) Then
            Return False
        Else
            Return True
        End If
    End Function
    Function checkEditYes(ByVal txt1 As String, ByVal txt2 As String, ByVal txt3 As String, ByVal txt4 As String, ByVal txt5 As String, ByVal txt6 As String) As Boolean
        If String.IsNullOrWhiteSpace(txt1) _
           Or String.IsNullOrWhiteSpace(txt2) _
            Or String.IsNullOrWhiteSpace(txt3) _
             Or String.IsNullOrWhiteSpace(txt4) _
              Or String.IsNullOrWhiteSpace(txt5) _
                 Or String.IsNullOrWhiteSpace(txt6) Then
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

    Sub clearAdd()
        txtPCID.Clear()
        txtDeptID.Clear()
        txtPCName.Clear()
        txtPCLocator.Clear()
        txtPCRemarks.Clear()
        ' txtCreatedBy.Clear()
    End Sub

    Sub clearEdit()
        txtPCID.Clear()
        txtDeptID.Clear()
        txtPCName.Clear()
        txtPCLocator.Clear()
        txtPCRemarks.Clear()
        txtUpdateBy.Clear()
    End Sub
    Private Sub MainToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainToolStripMenuItem.Click
        MainForm.Show()
        Me.Hide()
    End Sub


    Private Sub txtProdCatergoryID(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPCID.KeyPress, txtDeptID.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Then
                e.KeyChar = ChrW(0)
                '  MessageBox.Show("Please enter numbers only for ID")
            End If
        End If
    End Sub


    Private Sub txtProdCatergory(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPCName.KeyPress, txtPCLocator.KeyPress, txtPCRemarks.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not (Asc(e.KeyChar) = 32) Then
                If Not (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Then
                    If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
                        e.KeyChar = ChrW(0)
                        'MessageBox.Show("Please enter a letters and numbers only")
                    End If
                End If
            End If
        End If
    End Sub


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Dim txtProdCatID As String = txtPCID.Text
        Dim txtDepartID As String = txtDeptID.Text
        Dim txtProdCatName As String = txtPCName.Text
        Dim txtProdCatLocator As String = txtPCLocator.Text
        Dim txtProdCatRemarks As String = txtPCRemarks.Text
        Dim txtcreate As String = txtCreatedBy.Text
        Dim txtcreatedate As String = DateTimeCreateDate.Text

        If checkAddYes(txtPCID.Text, txtDeptID.Text, txtPCName.Text, txtPCLocator.Text, txtPCRemarks.Text, txtCreatedBy.Text) = True Then
            Dim AddCategoryYes As String = "INSERT INTO tblProduct_Category(PC_ID,DeptID,PC_Name,PC_Locator,PC_Remarks,Created_By,Created_Date) VALUES(@prodcatID,@deptID,@pcname,@pclocator,@pcremarks,@created,@createdate)"
            con.ConnectionString = My.Resources.connectString
            cmd.Connection = con
            cmd.CommandText = AddCategoryYes
            cmd.Parameters.AddWithValue("@prodcatID", txtProdCatID)
            cmd.Parameters.AddWithValue("@deptID", txtDepartID)
            cmd.Parameters.AddWithValue("@pcname", txtProdCatName)
            cmd.Parameters.AddWithValue("@pclocator", txtProdCatLocator)
            cmd.Parameters.AddWithValue("@pcremarks", txtProdCatRemarks)
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
                MsgBox("Category Product Added")
            Else
                MsgBox("Category Product did not Added")
            End If
            clearAdd()

        Else
            MsgBox("Fill up all the text")

        End If
        getAllItems()

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        btnAdd.Enabled = True
        Dim txtProdCatID As String = txtPCID.Text
        Dim txtDepartID As String = txtDeptID.Text
        Dim txtProdCatName As String = txtPCName.Text
        Dim txtProdCatLocator As String = txtPCLocator.Text
        Dim txtProdCatRemarks As String = txtPCRemarks.Text
        Dim txtupdate As String = txtUpdateBy.Text
        Dim txtupdatedate As String = DateTimeUpdateDate.Text


        If checkEditYes(txtPCID.Text, txtDeptID.Text, txtPCName.Text, txtPCLocator.Text, txtPCRemarks.Text, txtUpdateBy.Text) = True Then
            Dim EditCategoryYes As String = "UPDATE tblProduct_Category SET PC_ID=@prodcatID,DeptID=@deptID,PC_Name=@pcname,PC_Locator=@pclocator, Updated_By=@updated, Updated_Date=@update WHERE PC_ID=@prodcatID"
            con.ConnectionString = My.Resources.connectString
            cmd.Connection = con
            cmd.CommandText = EditCategoryYes
            cmd.Parameters.AddWithValue("@prodcatID", txtProdCatID)
            cmd.Parameters.AddWithValue("@deptID", txtDepartID)
            cmd.Parameters.AddWithValue("@pcname", txtProdCatName)
            cmd.Parameters.AddWithValue("@pclocator", txtProdCatLocator)
            cmd.Parameters.AddWithValue("@pcremarks", txtProdCatRemarks)
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
                MsgBox("Category Product Updated")
            Else
                MsgBox("Category Product did not Update")
            End If
            clearEdit()
            getAllItems()
        Else
            MsgBox("Fill up all the text")
        End If
       

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If checkDelete(txtPCID.Text) = True Then
            If MessageBox.Show("Are you sure you want to delete this record " & txtPCID.Text & "?", "Confirm Delete", MessageBoxButtons.YesNo) =
                  Windows.Forms.DialogResult.Yes Then
                Dim txtProdCatID As String = txtPCID.Text
                Dim DeleteDepartment As String = "DELETE FROM tblProduct_Category WHERE PC_ID=@prodcatID"
                con.ConnectionString = My.Resources.connectString
                cmd.Connection = con
                cmd.CommandText = DeleteDepartment
                cmd.Parameters.AddWithValue("@prodcatID", txtProdCatID)

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
                    MsgBox("Category Product deleted")
                Else
                    MsgBox("Category Product did not deleted")
                End If
            End If
        Else
            MsgBox("Select a Category Product ID you want to delete")
        End If
        Me.getAllItems()
    End Sub


    Private Sub FilterData(ByVal valueToSearch As String)
        Dim SearchUser As String = "SELECT * FROM tblProduct_Category WHERE" & " [PC_ID] like '%" & valueToSearch & "%'"
        Dim adapter As New SqlDataAdapter(SearchUser, con)
        Dim dTable As New DataTable()
        adapter.Fill(dTable)
        dgvCategory.DataSource = dTable
    End Sub

  
    Private Sub txtPCID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPCID.TextChanged
        FilterData(txtPCID.Text)
    End Sub

    Private Sub dgvCategory_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCategory.CellContentClick
        btnAdd.Enabled = False
        txtPCID.Text = Trim(dgvCategory.CurrentRow.Cells("PC_ID").Value.ToString)
        txtDeptID.Text = Trim(dgvCategory.CurrentRow.Cells("DeptID").Value.ToString)
        txtPCName.Text = Trim(dgvCategory.CurrentRow.Cells("PC_Name").Value.ToString)
        txtPCLocator.Text = Trim(dgvCategory.CurrentRow.Cells("PC_Locator").Value.ToString)
        txtPCRemarks.Text = Trim(dgvCategory.CurrentRow.Cells("PC_Remarks").Value.ToString)
        ' txtCreatedBy.Text = Trim(dgvCategory.CurrentRow.Cells("Created_By").Value.ToString)
        ' DateTimeCreateDate.Value = dgvCategory.CurrentRow.Cells("Created_Date").Value
        'txtUpdateBy.Text = Trim(dgvCategory.CurrentRow.Cells("Updated_By").Value.ToString)
        'DateTimeUpdateDate.Value = dgvCategory.CurrentRow.Cells("Updated_Date").Value
    End Sub



End Class


