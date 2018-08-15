Imports System.Data.SqlClient
Public Class Product
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection

    Private Sub Product_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainForm.Hide()
        con.ConnectionString = My.Resources.connectString
        cmd.Connection = con
        getAllItems()
        DateTimeCreateDate.Text = Date.Now().ToString("MMM/dd-yyyy")
        DateTimeUpdateDate.Text = Date.Now().ToString("MMM/dd-yyyy")
    End Sub


    Sub getAllItems()
        Dim querySelect As String = "SELECT * FROM tblProduct"
        con.ConnectionString = My.Resources.connectString
        Dim dTable As New DataTable
        Dim adapter As New SqlDataAdapter(querySelect, con)
        Try
            con.Open()
            adapter.Fill(dTable)
            dgvProduct.DataSource = dTable
        Catch ex As Exception
            MsgBox(ex.Message, , "Select")
        Finally
            con.Close()
        End Try
    End Sub

    Function checkAddYes(ByVal txt1 As String, ByVal txt2 As String, ByVal txt3 As String, ByVal txt4 As String, ByVal txt5 As String, ByVal txt6 As String, ByVal txt7 As String, ByVal txt8 As String, ByVal txt9 As String, ByVal txt10 As String, ByVal txt11 As String, ByVal txt12 As String, ByVal txt13 As String, ByVal txt14 As String, ByVal txt15 As String, ByVal txt16 As String) As Boolean
        If String.IsNullOrWhiteSpace(txt1) _
        Or String.IsNullOrWhiteSpace(txt2) _
        Or String.IsNullOrWhiteSpace(txt3) _
        Or String.IsNullOrWhiteSpace(txt4) _
        Or String.IsNullOrWhiteSpace(txt5) _
        Or String.IsNullOrWhiteSpace(txt6) _
        Or String.IsNullOrWhiteSpace(txt7) _
        Or String.IsNullOrWhiteSpace(txt8) _
        Or String.IsNullOrWhiteSpace(txt9) _
        Or String.IsNullOrWhiteSpace(txt10) _
        Or String.IsNullOrWhiteSpace(txt11) _
        Or String.IsNullOrWhiteSpace(txt12) _
        Or String.IsNullOrWhiteSpace(txt13) _
        Or String.IsNullOrWhiteSpace(txt14) _
        Or String.IsNullOrWhiteSpace(txt15) _
        Or String.IsNullOrWhiteSpace(txt16) Then
            Return False
        Else
            Return True
        End If
    End Function

    Function checkAddNo(ByVal txt1 As String, ByVal txt2 As String, ByVal txt3 As String, ByVal txt4 As String, ByVal txt5 As String, ByVal txt6 As String, ByVal txt7 As String, ByVal txt8 As String, ByVal txt9 As String, ByVal txt10 As String, ByVal txt11 As String, ByVal txt12 As String, ByVal txt13 As String, ByVal txt14 As String, ByVal txt15 As String, ByVal txt16 As String, ByVal txt17 As String) As Boolean
        If String.IsNullOrWhiteSpace(txt1) _
        Or String.IsNullOrWhiteSpace(txt2) _
        Or String.IsNullOrWhiteSpace(txt3) _
        Or String.IsNullOrWhiteSpace(txt4) _
        Or String.IsNullOrWhiteSpace(txt5) _
        Or String.IsNullOrWhiteSpace(txt6) _
        Or String.IsNullOrWhiteSpace(txt7) _
        Or String.IsNullOrWhiteSpace(txt8) _
        Or String.IsNullOrWhiteSpace(txt9) _
        Or String.IsNullOrWhiteSpace(txt10) _
        Or String.IsNullOrWhiteSpace(txt11) _
        Or String.IsNullOrWhiteSpace(txt12) _
        Or String.IsNullOrWhiteSpace(txt13) _
        Or String.IsNullOrWhiteSpace(txt15) _
        Or String.IsNullOrWhiteSpace(txt16) _
        Or String.IsNullOrWhiteSpace(txt17) Then
            Return False
        Else
            Return True
        End If
    End Function



    Function checkEditYes(ByVal txt1 As String, ByVal txt2 As String, ByVal txt3 As String, ByVal txt4 As String, ByVal txt5 As String, ByVal txt6 As String, ByVal txt7 As String, ByVal txt8 As String, ByVal txt9 As String, ByVal txt10 As String, ByVal txt11 As String, ByVal txt12 As String, ByVal txt13 As String, ByVal txt14 As String, ByVal txt15 As String, ByVal txt16 As String) As Boolean
        If String.IsNullOrWhiteSpace(txt1) _
        Or String.IsNullOrWhiteSpace(txt2) _
        Or String.IsNullOrWhiteSpace(txt3) _
        Or String.IsNullOrWhiteSpace(txt4) _
        Or String.IsNullOrWhiteSpace(txt5) _
        Or String.IsNullOrWhiteSpace(txt6) _
        Or String.IsNullOrWhiteSpace(txt7) _
        Or String.IsNullOrWhiteSpace(txt8) _
        Or String.IsNullOrWhiteSpace(txt9) _
        Or String.IsNullOrWhiteSpace(txt10) _
        Or String.IsNullOrWhiteSpace(txt11) _
        Or String.IsNullOrWhiteSpace(txt12) _
        Or String.IsNullOrWhiteSpace(txt13) _
        Or String.IsNullOrWhiteSpace(txt14) _
        Or String.IsNullOrWhiteSpace(txt15) _
        Or String.IsNullOrWhiteSpace(txt16) Then
            Return False
        Else
            Return True
        End If
    End Function

    Function checkEditNo(ByVal txt1 As String, ByVal txt2 As String, ByVal txt3 As String, ByVal txt4 As String, ByVal txt5 As String, ByVal txt6 As String, ByVal txt7 As String, ByVal txt8 As String, ByVal txt9 As String, ByVal txt10 As String, ByVal txt11 As String, ByVal txt12 As String, ByVal txt13 As String, ByVal txt14 As String, ByVal txt15 As String, ByVal txt16 As String, ByVal txt17 As String) As Boolean
        If String.IsNullOrWhiteSpace(txt1) _
        Or String.IsNullOrWhiteSpace(txt2) _
        Or String.IsNullOrWhiteSpace(txt3) _
        Or String.IsNullOrWhiteSpace(txt4) _
        Or String.IsNullOrWhiteSpace(txt5) _
        Or String.IsNullOrWhiteSpace(txt6) _
        Or String.IsNullOrWhiteSpace(txt7) _
        Or String.IsNullOrWhiteSpace(txt8) _
        Or String.IsNullOrWhiteSpace(txt9) _
        Or String.IsNullOrWhiteSpace(txt10) _
        Or String.IsNullOrWhiteSpace(txt11) _
        Or String.IsNullOrWhiteSpace(txt12) _
        Or String.IsNullOrWhiteSpace(txt13) _
        Or String.IsNullOrWhiteSpace(txt15) _
        Or String.IsNullOrWhiteSpace(txt16) _
        Or String.IsNullOrWhiteSpace(txt17) Then
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
        txtItemID.Clear()
        txtProductID.Clear()
        txtProductCode.Clear()
        txtProductName.Clear()
        txtProductSDescription.Clear()
        txtProductUOM.Clear()
        cbStatus.SelectedIndex = -1
        txtRemarks.Clear()
        txtCost.Clear()
        txtMarkUp.Clear()
        txtPriceA.Clear()
        txtPriceB.Clear()
        txtPriceC.Clear()
        txtPriceD.Clear()
        txtPriceE.Clear()
        ' txtCreatedBy.Clear()
    End Sub

    Sub clearEdit()

        txtPCID.Clear()
        txtItemID.Clear()
        txtProductID.Clear()
        txtProductCode.Clear()
        txtProductName.Clear()
        txtProductSDescription.Clear()
        txtProductUOM.Clear()
        cbStatus.SelectedIndex = -1
        txtRemarks.Clear()
        txtCost.Clear()
        txtMarkUp.Clear()
        txtPriceA.Clear()
        txtPriceB.Clear()
        txtPriceC.Clear()
        txtPriceD.Clear()
        txtPriceE.Clear()
        txtUpdateBy.Clear()
    End Sub

    Private Sub MainToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainToolStripMenuItem.Click
        MainForm.Show()
        Me.Hide()
    End Sub

    Private Sub FilterData(ByVal valueToSearch As String)
        Dim SearchUser As String = "SELECT * FROM tblProduct WHERE" & " [ProdID] like '%" & valueToSearch & "%'"
        Dim adapter As New SqlDataAdapter(SearchUser, con)
        Dim dTable As New DataTable()
        adapter.Fill(dTable)
        dgvProduct.DataSource = dTable
    End Sub

    Private Sub cbStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbStatus.SelectedIndexChanged
        If cbStatus.SelectedIndex = 1 Then
            txtRemarks.Enabled = True
        Else
            txtRemarks.Enabled = False
        End If
    End Sub

    Private Sub txtID(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtItemID.KeyPress, txtPCID.KeyPress, txtProductID.KeyPress, txtProductUOM.KeyPress, txtCost.KeyPress, txtMarkUp.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Then
                e.KeyChar = ChrW(0)
                '  MessageBox.Show("Please enter numbers only")
            End If
        End If
    End Sub
    Private Sub txtPrices(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPriceA.KeyPress, txtPriceB.KeyPress, txtPriceC.KeyPress, txtPriceD.KeyPress, txtPriceE.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not (Asc(e.KeyChar) = 46) Then
                If Not (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Then
                    e.KeyChar = ChrW(0)
                    '         MessageBox.Show("Please enter numbers only")
                End If
            End If
        End If
    End Sub

    Private Sub txtProd(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtProductCode.KeyPress, txtProductName.KeyPress, txtProductSDescription.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not (Asc(e.KeyChar) = 32) Then
                If Not (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Then
                    If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
                        e.KeyChar = ChrW(0)
                        '       MessageBox.Show("Please enter the complete supplier address")
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Dim txtProdID As String = txtProductID.Text
        Dim txtProdItem As String = txtItemID.Text
        Dim txtProdCatID As String = txtPCID.Text
        Dim txtProdName As String = txtProductName.Text
        Dim txtProdCode As String = txtProductCode.Text
        Dim txtProdSDesc As String = txtProductSDescription.Text
        Dim txtProdUOM As String = txtProductUOM.Text
        Dim txtcombostatusY As String = "Y"
        Dim txtcombostatusN As String = "N"
        Dim txtremark As String = txtRemarks.Text
        Dim txtremarkY As String = ""
        Dim txtProdCost As String = txtCost.Text
        Dim txtProdMarkup As String = txtMarkUp.Text
        Dim txtProdPriceA As String = txtPriceA.Text
        Dim txtProdPriceB As String = txtPriceB.Text
        Dim txtProdPriceC As String = txtPriceC.Text
        Dim txtProdPriceD As String = txtPriceD.Text
        Dim txtProdPriceE As String = txtPriceE.Text
        Dim txtcreate As String = txtCreatedBy.Text
        Dim txtcreatedate As String = DateTimeCreateDate.Text

        If cbStatus.SelectedIndex = 1 Then
            If checkAddNo(txtProductID.Text, txtItemID.Text, txtPCID.Text, txtProductCode.Text, txtProductName.Text, txtProductSDescription.Text, txtProductUOM.Text, cbStatus.Text, txtRemarks.Text, txtCost.Text, txtMarkUp.Text, txtPriceA.Text, txtPriceB.Text, txtPriceC.Text, txtPriceD.Text, txtPriceE.Text, txtCreatedBy.Text) = True Then
                Dim AddProductNo As String = "INSERT INTO tblProduct(ProdID,ItemID,PC_ID,ProdName,ProdCode,ProdSDesc,ProdUOM,Status,Remarks,Cost,MarkUp,PriceA,PriceB,PriceC,PriceD,PriceE,Created_By,Created_Date) VALUES(@prodID,@itemID,@PCID,@prodname,@prodcode,@prodsdesc,@produom,@status,@remarks,@cost,@markup,@priceA,@priceB,@priceC,@priceD,@priceE,@created,@createdate)"
                con.ConnectionString = My.Resources.connectString
                cmd.Connection = con
                cmd.CommandText = AddProductNo
                cmd.Parameters.AddWithValue("@prodID", txtProdID)
                cmd.Parameters.AddWithValue("@itemID", txtProdItem)
                cmd.Parameters.AddWithValue("@PCID", txtProdCatID)
                cmd.Parameters.AddWithValue("@prodname", txtProdName)
                cmd.Parameters.AddWithValue("@prodcode", txtProdCode)
                cmd.Parameters.AddWithValue("@prodsdesc", txtProdSDesc)
                cmd.Parameters.AddWithValue("@produom", txtProdUOM)
                cmd.Parameters.AddWithValue("@status", txtcombostatusN)
                cmd.Parameters.AddWithValue("@remarks", txtremark)
                cmd.Parameters.AddWithValue("@cost", txtProdCost)
                cmd.Parameters.AddWithValue("@markup", txtProdMarkup)
                cmd.Parameters.AddWithValue("@priceA", txtProdPriceA)
                cmd.Parameters.AddWithValue("@priceB", txtProdPriceB)
                cmd.Parameters.AddWithValue("@priceC", txtProdPriceC)
                cmd.Parameters.AddWithValue("@priceD", txtProdPriceD)
                cmd.Parameters.AddWithValue("@priceE", txtProdPriceE)
                cmd.Parameters.AddWithValue("@created", txtcreate)
                cmd.Parameters.AddWithValue("@createdate", txtcreatedate)

                Dim rowsAffectedNo As Integer
                Try
                    con.Open()
                    rowsAffectedNo = cmd.ExecuteNonQuery
                Catch ex As Exception
                    MsgBox(ex.Message, , "INSERT QUERY ERROR")
                Finally
                    con.Close()
                    cmd.Parameters.Clear()
                End Try
                If rowsAffectedNo = 1 Then
                    MsgBox("Product Added")
                Else
                    MsgBox("Product did not Added")
                End If
                clearAdd()

            Else
                MsgBox("Fill up all the text")

            End If
            getAllItems()

        Else
            If checkAddYes(txtProductID.Text, txtItemID.Text, txtPCID.Text, txtProductCode.Text, txtProductName.Text, txtProductSDescription.Text, txtProductUOM.Text, cbStatus.Text, txtCost.Text, txtMarkUp.Text, txtPriceA.Text, txtPriceB.Text, txtPriceC.Text, txtPriceD.Text, txtPriceE.Text, txtCreatedBy.Text) = True Then
                Dim AddProductYes As String = "INSERT INTO tblProduct(ProdID,ItemID,PC_ID,ProdName,ProdCode,ProdSDesc,ProdUOM,Status,Cost,MarkUp,PriceA,PriceB,PriceC,PriceD,PriceE,Created_By,Created_Date) VALUES(@prodID,@itemID,@PCID,@prodname,@prodcode,@prodsdesc,@produom,@status,@cost,@markup,@priceA,@priceB,@priceC,@priceD,@priceE,@created,@createdate)"
                con.ConnectionString = My.Resources.connectString
                cmd.Connection = con
                cmd.CommandText = AddProductYes
                cmd.Parameters.AddWithValue("@prodID", txtProdID)
                cmd.Parameters.AddWithValue("@itemID", txtProdItem)
                cmd.Parameters.AddWithValue("@PCID", txtProdCatID)
                cmd.Parameters.AddWithValue("@prodname", txtProdName)
                cmd.Parameters.AddWithValue("@prodcode", txtProdCode)
                cmd.Parameters.AddWithValue("@prodsdesc", txtProdSDesc)
                cmd.Parameters.AddWithValue("@produom", txtProdUOM)
                cmd.Parameters.AddWithValue("@status", txtcombostatusY)
                'cmd.Parameters.AddWithValue("@remarks", txtremarkY)
                cmd.Parameters.AddWithValue("@cost", txtProdCost)
                cmd.Parameters.AddWithValue("@markup", txtProdMarkup)
                cmd.Parameters.AddWithValue("@priceA", txtProdPriceA)
                cmd.Parameters.AddWithValue("@priceB", txtProdPriceB)
                cmd.Parameters.AddWithValue("@priceC", txtProdPriceC)
                cmd.Parameters.AddWithValue("@priceD", txtProdPriceD)
                cmd.Parameters.AddWithValue("@priceE", txtProdPriceE)
                cmd.Parameters.AddWithValue("@created", txtcreate)
                cmd.Parameters.AddWithValue("@createdate", txtcreatedate)


                Dim rowAffectedYes As Integer
                Try
                    con.Open()
                    rowAffectedYes = cmd.ExecuteNonQuery

                Catch ex As Exception
                    MsgBox(ex.Message, , " INSERT QUERY ERROR")
                Finally
                    con.Close()
                    cmd.Parameters.Clear()
                End Try
                If rowAffectedYes = 1 Then
                    MsgBox("Product Added")
                Else
                    MsgBox("Product did not Added")
                    clearAdd()
                End If
            Else
                MsgBox("Fill up all the text")
            End If
        End If
        getAllItems()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        btnAdd.Enabled = True
        Dim txtProdID As String = txtProductID.Text
        Dim txtProdItem As String = txtItemID.Text
        Dim txtProdCatID As String = txtPCID.Text
        Dim txtProdName As String = txtProductName.Text
        Dim txtProdCode As String = txtProductCode.Text
        Dim txtProdSDesc As String = txtProductSDescription.Text
        Dim txtProdUOM As String = txtProductUOM.Text
        Dim txtcombostatusY As String = "Y"
        Dim txtcombostatusN As String = "N"
        Dim txtremark As String = txtRemarks.Text
        Dim txtremarkY As String = ""
        Dim txtProdCost As String = txtCost.Text
        Dim txtProdMarkup As String = txtMarkUp.Text
        Dim txtProdPriceA As String = txtPriceA.Text
        Dim txtProdPriceB As String = txtPriceB.Text
        Dim txtProdPriceC As String = txtPriceC.Text
        Dim txtProdPriceD As String = txtPriceD.Text
        Dim txtProdPriceE As String = txtPriceE.Text
        Dim txtupdate As String = txtUpdateBy.Text
        Dim txtupdatedate As Date = DateTimeUpdateDate.Text

        If cbStatus.SelectedIndex = 1 Then
            If checkEditNo(txtProductID.Text, txtItemID.Text, txtPCID.Text, txtProductCode.Text, txtProductName.Text, txtProductSDescription.Text, txtProductUOM.Text, cbStatus.Text, txtRemarks.Text, txtCost.Text, txtMarkUp.Text, txtPriceA.Text, txtPriceB.Text, txtPriceC.Text, txtPriceD.Text, txtPriceE.Text, txtUpdateBy.Text) = True Then
                Dim UpdateCategoryNo As String = "UPDATE tblProduct SET ItemID=itemID,PC_ID=@PCID,ProdName=prodname,ProdCode=@prodcode,ProdSDesc=@prodsdesc,ProdUOM=@produom,Status=@status,Remarks=@remarks,Cost=@cost,MarkUp=@markup,PriceA=@priceA,PriceB=@priceB,PriceC=@priceC,PriceD=@priceD,PriceE=@priceE,Updated_By=@updated,Updated_Date=@update WHERE ProdID=@prodID "
                con.ConnectionString = My.Resources.connectString
                cmd.Connection = con
                cmd.CommandText = UpdateCategoryNo
                cmd.Parameters.AddWithValue("@prodID", txtProdID)
                cmd.Parameters.AddWithValue("@itemID", txtProdItem)
                cmd.Parameters.AddWithValue("@PCID", txtProdCatID)
                cmd.Parameters.AddWithValue("@prodname", txtProdName)
                cmd.Parameters.AddWithValue("@prodcode", txtProdCode)
                cmd.Parameters.AddWithValue("@prodsdesc", txtProdSDesc)
                cmd.Parameters.AddWithValue("@produom", txtProdUOM)
                cmd.Parameters.AddWithValue("@status", txtcombostatusN)
                cmd.Parameters.AddWithValue("@remarks", txtremark)
                cmd.Parameters.AddWithValue("@cost", txtProdCost)
                cmd.Parameters.AddWithValue("@markup", txtProdMarkup)
                cmd.Parameters.AddWithValue("@priceA", txtProdPriceA)
                cmd.Parameters.AddWithValue("@priceB", txtProdPriceB)
                cmd.Parameters.AddWithValue("@priceC", txtProdPriceC)
                cmd.Parameters.AddWithValue("@priceD", txtProdPriceD)
                cmd.Parameters.AddWithValue("@priceE", txtProdPriceE)
                cmd.Parameters.AddWithValue("@updated", txtupdate)
                cmd.Parameters.AddWithValue("@update", txtupdatedate)

                Dim rowsAffectedNo As Integer
                Try
                    con.Open()
                    rowsAffectedNo = cmd.ExecuteNonQuery
                Catch ex As Exception
                    MsgBox(ex.Message, , "INSERT QUERY ERROR")
                Finally
                    con.Close()
                    cmd.Parameters.Clear()
                End Try
                If rowsAffectedNo = 1 Then
                    MsgBox("Product Added")
                Else
                    MsgBox("Product did not Added")
                End If
                clearAdd()

            Else
                MsgBox("Fill up all the text")

            End If
            getAllItems()

        Else
            If checkEditYes(txtProductID.Text, txtItemID.Text, txtPCID.Text, txtProductCode.Text, txtProductName.Text, txtProductSDescription.Text, txtProductUOM.Text, cbStatus.Text, txtCost.Text, txtMarkUp.Text, txtPriceA.Text, txtPriceB.Text, txtPriceC.Text, txtPriceD.Text, txtPriceE.Text, txtUpdateBy.Text) = True Then
                Dim UpdateCategoryYes As String = "UPDATE tblProduct SET ItemID=itemID,PC_ID=@PCID,ProdName=prodname,ProdCode=@prodcode,ProdSDesc=@prodsdesc,ProdUOM=@produom,Status=@status,Remarks=@remarks,Cost=@cost,MarkUp=@markup,PriceA=@priceA,PriceB=@priceB,PriceC=@priceC,PriceD=@priceD,PriceE=@priceE,Updated_By=@updated,Updated_Date=@update WHERE ProdID=@prodID "
                con.ConnectionString = My.Resources.connectString
                cmd.Connection = con
                cmd.CommandText = UpdateCategoryYes
                cmd.Parameters.AddWithValue("@prodID", txtProdID)
                cmd.Parameters.AddWithValue("@itemID", txtProdItem)
                cmd.Parameters.AddWithValue("@PCID", txtProdCatID)
                cmd.Parameters.AddWithValue("@prodname", txtProdName)
                cmd.Parameters.AddWithValue("@prodcode", txtProdCode)
                cmd.Parameters.AddWithValue("@prodsdesc", txtProdSDesc)
                cmd.Parameters.AddWithValue("@produom", txtProdUOM)
                cmd.Parameters.AddWithValue("@status", txtcombostatusY)
                cmd.Parameters.AddWithValue("@remarks", txtremarkY)
                cmd.Parameters.AddWithValue("@cost", txtProdCost)
                cmd.Parameters.AddWithValue("@markup", txtProdMarkup)
                cmd.Parameters.AddWithValue("@priceA", txtProdPriceA)
                cmd.Parameters.AddWithValue("@priceB", txtProdPriceB)
                cmd.Parameters.AddWithValue("@priceC", txtProdPriceC)
                cmd.Parameters.AddWithValue("@priceD", txtProdPriceD)
                cmd.Parameters.AddWithValue("@priceE", txtProdPriceE)
                cmd.Parameters.AddWithValue("@updated", txtupdate)
                cmd.Parameters.AddWithValue("@update", txtupdatedate)



                Dim rowAffectedYes As Integer
                Try
                    con.Open()
                    rowAffectedYes = cmd.ExecuteNonQuery

                Catch ex As Exception
                    MsgBox(ex.Message, , " INSERT QUERY ERROR")
                Finally
                    con.Close()
                    cmd.Parameters.Clear()
                End Try
                If rowAffectedYes = 1 Then
                    MsgBox("Product Added")
                Else
                    MsgBox("Product did not Added")
                    clearAdd()
                End If
            Else
                MsgBox("Fill up all the text")
            End If
        End If
        getAllItems()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If checkDelete(txtProductID.Text) = True Then
            If MessageBox.Show("Are you sure you want to delete this record " & txtProductID.Text & "?", "Confirm Delete", MessageBoxButtons.YesNo) =
                  Windows.Forms.DialogResult.Yes Then
                Dim txtprodID As String = txtProductID.Text
                Dim DeleteSupplier As String = "DELETE FROM tblProduct WHERE ProdID=@prodID"
                con.ConnectionString = My.Resources.connectString
                cmd.Connection = con
                cmd.CommandText = DeleteSupplier
                cmd.Parameters.AddWithValue("@prodID", txtprodID)

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
                    MsgBox("Product deleted")
                Else
                    MsgBox("Product did not deleted")
                End If
            End If
        Else
            MsgBox("Select a Product ID you want to delete")
        End If
        Me.getAllItems()
    End Sub


    Private Sub dgvProduct_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProduct.CellContentClick
        btnAdd.Enabled = False
        txtProductID.Text = Trim(dgvProduct.CurrentRow.Cells("ProdID").Value.ToString)
        txtItemID.Text = Trim(dgvProduct.CurrentRow.Cells("ItemID").Value.ToString)
        txtPCID.Text = Trim(dgvProduct.CurrentRow.Cells("PC_ID").Value.ToString)
        txtProductCode.Text = Trim(dgvProduct.CurrentRow.Cells("ProdCode").Value.ToString)
        txtProductName.Text = Trim(dgvProduct.CurrentRow.Cells("ProdName").Value.ToString)
        txtProductSDescription.Text = Trim(dgvProduct.CurrentRow.Cells("ProdSDesc").Value.ToString)
        txtProductUOM.Text = Trim(dgvProduct.CurrentRow.Cells("ProdUOM").Value.ToString)
        cbStatus.SelectedText = dgvProduct.CurrentRow.Cells("Status").Value
        txtRemarks.Text = Trim(dgvProduct.CurrentRow.Cells("Remarks").Value.ToString)
        txtCost.Text = Trim(dgvProduct.CurrentRow.Cells("Costs").Value.ToString)
        txtMarkUp.Text = Trim(dgvProduct.CurrentRow.Cells("MarkUp").Value.ToString)
        txtPriceA.Text = Trim(dgvProduct.CurrentRow.Cells("PriceA").Value.ToString)
        txtPriceB.Text = Trim(dgvProduct.CurrentRow.Cells("PriceB").Value.ToString)
        txtPriceC.Text = Trim(dgvProduct.CurrentRow.Cells("PriceC").Value.ToString)
        txtPriceD.Text = Trim(dgvProduct.CurrentRow.Cells("PriceD").Value.ToString)
        txtPriceE.Text = Trim(dgvProduct.CurrentRow.Cells("PriceE").Value.ToString)
        txtCreatedBy.Text = Trim(dgvProduct.CurrentRow.Cells("Created_By").Value.ToString)
        '   DateTimeCreateDate.Value = dgvSupplier.CurrentRow.Cells("Created_Date").Value
        txtUpdateBy.Text = Trim(dgvProduct.CurrentRow.Cells("Updated_By").Value.ToString)
        '  DateTimeUpdateDate.Value = dgvSupplier.CurrentRow.Cells("Updated_Date").Value
    End Sub


    Private Sub txtProductID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProductID.TextChanged
        FilterData(txtProductID.Text)
    End Sub

End Class