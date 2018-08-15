Imports System.Data.SqlClient
Public Class SupplierForm
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection

    Private Sub SupplierForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainForm.Hide()
        DateTimeCreateDate.Text = Date.Now().ToString("MMM/dd-yyyy")
        DateTimeUpdateDate.Text = Date.Now().ToString("MMM/dd-yyyy")
        con.ConnectionString = My.Resources.connectString
        cmd.Connection = con
        getAllItems()
    End Sub

    Private Sub MainToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainToolStripMenuItem.Click
        MainForm.Show()
        Me.Hide()
   
    End Sub


    Sub getAllItems()
        Dim querySelect As String = "SELECT * FROM tblSupplier"
        con.ConnectionString = My.Resources.connectString
        Dim dTable As New DataTable
        Dim adapter As New SqlDataAdapter(querySelect, con)
        Try
            con.Open()
            adapter.Fill(dTable)
            dgvSupplier.DataSource = dTable
        Catch ex As Exception
            MsgBox(ex.Message, , "Select")
        Finally
            con.Close()
        End Try
    End Sub

    Function checkAddYes(ByVal txt1 As String, ByVal txt2 As String, ByVal txt3 As String, ByVal txt4 As String, ByVal txt5 As String, ByVal txt6 As String, ByVal txt7 As String) As Boolean
        If String.IsNullOrWhiteSpace(txt1) _
         Or String.IsNullOrWhiteSpace(txt2) _
          Or String.IsNullOrWhiteSpace(txt3) _
           Or String.IsNullOrWhiteSpace(txt4) _
            Or String.IsNullOrWhiteSpace(txt5) _
             Or String.IsNullOrWhiteSpace(txt6) _
               Or String.IsNullOrWhiteSpace(txt7) Then
            Return False
        Else
            Return True
        End If
    End Function

  

    Function checkEditYes(ByVal txt1 As String, ByVal txt2 As String, ByVal txt3 As String, ByVal txt4 As String, ByVal txt5 As String, ByVal txt6 As String, ByVal txt7 As String) As Boolean
        If String.IsNullOrWhiteSpace(txt1) _
           Or String.IsNullOrWhiteSpace(txt2) _
            Or String.IsNullOrWhiteSpace(txt3) _
             Or String.IsNullOrWhiteSpace(txt4) _
              Or String.IsNullOrWhiteSpace(txt5) _
               Or String.IsNullOrWhiteSpace(txt6) _
             Or String.IsNullOrWhiteSpace(txt7) Then
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
        txtSupplierID.Clear()
        txtSupplierName.Clear()
        txtSupplierAddress.Clear()
        txtMobileNumber.Clear()
        txtPhoneNumber.Clear()
        txtEmail.Clear()
        '  txtCreatedBy.Clear()
    End Sub

    Sub clearEdit()
        txtSupplierID.Clear()
        txtSupplierName.Clear()
        txtSupplierAddress.Clear()
        txtMobileNumber.Clear()
        txtPhoneNumber.Clear()
        txtEmail.Clear()
        txtUpdateBy.Clear()
    End Sub
    Private Sub txtSupplyID(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSupplierID.KeyPress, txtMobileNumber.KeyPress, txtPhoneNumber.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Then
                e.KeyChar = ChrW(0)
                '   MessageBox.Show("Please enter numbers only for ID")
            End If
        End If
    End Sub

    Private Sub txtSupplyName(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSupplierName.KeyPress, txtCreatedBy.KeyPress, txtUpdateBy.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not (Asc(e.KeyChar) = 32) Then
                If Not (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Then
                    If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
                        e.KeyChar = ChrW(0)
                        '  MessageBox.Show("Please enter a letters and numbers only")
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtSupplyAddress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSupplierAddress.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not (Asc(e.KeyChar) = 32) Then
                If Not (Asc(e.KeyChar) = 44) Then
                    If Not (Asc(e.KeyChar) = 46) Then
                        If Not (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Then
                            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
                                e.KeyChar = ChrW(0)
                                '      MessageBox.Show("Please enter the complete supplier address")
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub


    Private Sub txtEmailAdd(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmail.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not (Asc(e.KeyChar) = 32) Then
                If Not (Asc(e.KeyChar) = 46) Then
                    If Not (Asc(e.KeyChar) = 64) Then
                        If Not (Asc(e.KeyChar) = 95) Then
                            If Not (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Then
                                If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
                                    e.KeyChar = ChrW(0)
                                    '  MessageBox.Show("Please enter a letters and numbers only")
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim txtSupplyID As String = txtSupplierID.Text
        Dim txtSupplyName As String = txtSupplierName.Text
        Dim txtSupplyAddress As String = txtSupplierAddress.Text
        Dim txtMobileNo As String = txtMobileNumber.Text
        Dim txtPhoneNo As String = txtPhoneNumber.Text
        Dim txtMail As String = txtEmail.Text
        Dim txtcreate As String = txtCreatedBy.Text
        Dim txtcreatedate As String = DateTimeCreateDate.Text


        If checkAddYes(txtSupplierID.Text, txtSupplierName.Text, txtSupplierAddress.Text, txtMobileNumber.Text, txtPhoneNumber.Text, txtEmail.Text, txtCreatedBy.Text) = True Then
            Dim AddSupplierYes As String = "INSERT INTO tblSupplier(SupID,SupName,SupAdd,MobileNo,PhoneNo,Email,Created_By,Created_Date) VALUES(@supID,@supname,@supadd,@mobile,@phone,@email,@created,@createdate)"
            con.ConnectionString = My.Resources.connectString
            cmd.Connection = con
            cmd.CommandText = AddSupplierYes
            cmd.Parameters.AddWithValue("@supID", txtSupplyID)
            cmd.Parameters.AddWithValue("@supname", txtSupplyName)
            cmd.Parameters.AddWithValue("@supadd", txtSupplyAddress)
            cmd.Parameters.AddWithValue("@mobile", txtMobileNo)
            cmd.Parameters.AddWithValue("@phone", txtPhoneNo)
            cmd.Parameters.AddWithValue("@email", txtMail)
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
                MsgBox("Supplier Added")
            Else
                MsgBox("Supplier did not Added")
            End If
            clearAdd()

        Else
            MsgBox("Fill up all the text")

        End If
            getAllItems()

       
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        btnAdd.Enabled = True
        Dim txtSupplyID As String = txtSupplierID.Text
        Dim txtSupplyName As String = txtSupplierName.Text
        Dim txtSupplyAddress As String = txtSupplierAddress.Text
        Dim txtMobileNo As String = txtMobileNumber.Text
        Dim txtPhoneNo As String = txtPhoneNumber.Text
        Dim txtMail As String = txtEmail.Text
        Dim txtupdate As String = txtUpdateBy.Text
        Dim txtupdatedate As String = DateTimeUpdateDate.Text


        If checkEditYes(txtSupplierID.Text, txtSupplierName.Text, txtSupplierAddress.Text, txtMobileNumber.Text, txtPhoneNumber.Text, txtEmail.Text, txtUpdateBy.Text) = True Then
            Dim EditSupplierNo As String = "UPDATE tblSupplier SET SupName=@supname,SupAdd=@supadd,MobileNo=@mobile,PhoneNo=@phone,Email=@email,Updated_By=@updated, Updated_Date=@update WHERE SupID=@supID"
            con.ConnectionString = My.Resources.connectString
            cmd.Connection = con
            cmd.CommandText = EditSupplierNo
            cmd.Parameters.AddWithValue("@supID", txtSupplyID)
            cmd.Parameters.AddWithValue("@supname", txtSupplyName)
            cmd.Parameters.AddWithValue("@supadd", txtSupplyAddress)
            cmd.Parameters.AddWithValue("@mobile", txtMobileNo)
            cmd.Parameters.AddWithValue("@phone", txtPhoneNo)
            cmd.Parameters.AddWithValue("@email", txtMail)
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
                MsgBox("Supplier Updated")
            Else
                MsgBox("Supplier did not Update")
            End If
            clearEdit()
            getAllItems()
        Else
            MsgBox("Fill up all the text")
        End If

      
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If checkDelete(txtSupplierID.Text) = True Then
            If MessageBox.Show("Are you sure you want to delete this record " & txtSupplierID.Text & "?", "Confirm Delete", MessageBoxButtons.YesNo) =
                  Windows.Forms.DialogResult.Yes Then
                Dim txtSupplyID As String = txtSupplierID.Text
                Dim DeleteSupplier As String = "DELETE FROM tblSupplier WHERE SupID=@supplyID"
                con.ConnectionString = My.Resources.connectString
                cmd.Connection = con
                cmd.CommandText = DeleteSupplier
                cmd.Parameters.AddWithValue("@supplyID", txtSupplyID)

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
                    MsgBox("Supplier deleted")
                Else
                    MsgBox("Supplier did not deleted")
                End If
            End If
        Else
            MsgBox("Select a Supplier ID you want to delete")
        End If
        Me.getAllItems()
    End Sub

    Private Sub FilterData(ByVal valueToSearch As String)
        Dim SearchUser As String = "SELECT * FROM tblSupplier WHERE" & " [SupID] like '%" & valueToSearch & "%'"
        Dim adapter As New SqlDataAdapter(SearchUser, con)
        Dim dTable As New DataTable()
        adapter.Fill(dTable)
        dgvSupplier.DataSource = dTable
    End Sub

    Private Sub dgvSupplier_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSupplier.CellContentClick
        btnAdd.Enabled = False
        txtSupplierID.Text = Trim(dgvSupplier.CurrentRow.Cells("SupID").Value.ToString)
        txtSupplierName.Text = Trim(dgvSupplier.CurrentRow.Cells("SupName").Value.ToString)
        txtSupplierAddress.Text = Trim(dgvSupplier.CurrentRow.Cells("SupAdd").Value.ToString)
        txtMobileNumber.Text = Trim(dgvSupplier.CurrentRow.Cells("MobileNo").Value.ToString)
        txtPhoneNumber.Text = Trim(dgvSupplier.CurrentRow.Cells("PhoneNo").Value.ToString)
        txtEmail.Text = Trim(dgvSupplier.CurrentRow.Cells("Email").Value.ToString)
        '  txtCreatedBy.Text = Trim(dgvSupplier.CurrentRow.Cells("Created_By").Value.ToString)
        '   DateTimeCreateDate.Value = dgvSupplier.CurrentRow.Cells("Created_Date").Value
        ' txtUpdateBy.Text = Trim(dgvSupplier.CurrentRow.Cells("Updated_By").Value.ToString)
        '  DateTimeUpdateDate.Value = dgvSupplier.CurrentRow.Cells("Updated_Date").Value
    End Sub

 
  
    Private Sub txtSupplierID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSupplierID.TextChanged
        FilterData(txtSupplierID.Text)
    End Sub
End Class