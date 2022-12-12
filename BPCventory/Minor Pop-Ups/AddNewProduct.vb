Public Class AddNewProduct

    Function PresetDesc(Name As TextBox, PrtNum As TextBox, PrdSize As TextBox, UL As TextBox, PrdDim As TextBox, AC As TextBox, SP As TextBox, Quan As TextBox)
        For Each txt In {Name, PrtNum, PrdSize, UL, PrdDim, AC, SP, Quan}
            txt.Clear()
            txt.ForeColor = Color.Gray
        Next
        '-------------------- PRESET DESCRIPTION ------------------------------
        Name.Text = "Enter Product Name Here"
        PartNumber.Text = "Part Number"
        PrdSize.Text = "Size"
        UL.Text = "Unit Length"
        PrdDim.Text = "Dimensions"
        SP.Text = "Selling Price"
        AC.Text = "Buying Price"
        Quan.Text = "Quantity"

        '------------------------------------------------------'

        Return 0
    End Function

    Private Sub CancelBttn_Click(sender As Object, e As EventArgs) Handles CancelBttn.Click
        Mainsystem.Opacity = 1
        Mainsystem.Enabled = True
        Hide()
        PresetDesc(ProductsName, PartNumber, ProductSize, UnitLength, ProductDimension, BuyingPrice, SellingPrice, Quantity)
    End Sub

    Private Sub ClearAllBttn_Click(sender As Object, e As EventArgs) Handles ClearAllBttn.Click
        MessageBox.Show("All Fields Cleared", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
        PresetDesc(ProductsName, PartNumber, ProductSize, UnitLength, ProductDimension, BuyingPrice, SellingPrice, Quantity)
    End Sub


    '--------------------- TEXTBOX DESCRIPTION APPEARANCE AND DISAPPEARANCE --------------------

    Private Sub ProductsName_MouseClick(sender As Object, e As MouseEventArgs) Handles ProductsName.MouseClick
        If ProductsName.Text = "Enter Product Name Here" Then
            ProductsName.Clear()
            ProductsName.ForeColor = Color.Black
        End If
    End Sub

    Private Sub ProductsName_Leave(sender As Object, e As EventArgs) Handles ProductsName.Leave
        If ProductsName.Text = "" Then
            ProductsName.Text = "Enter Product Name Here"
            ProductsName.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub PartNumber_MouseClick(sender As Object, e As MouseEventArgs) Handles PartNumber.MouseClick
        If PartNumber.Text = "Part Number" Then
            PartNumber.Clear()
            PartNumber.ForeColor = Color.Black
        End If
    End Sub

    Private Sub PartNumber_Leave(sender As Object, e As EventArgs) Handles PartNumber.Leave
        If PartNumber.Text = "" Then
            PartNumber.Text = "Part Number"
            PartNumber.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub ProductSize_MouseClick(sender As Object, e As MouseEventArgs) Handles ProductSize.MouseClick
        If ProductSize.Text = "Size" Then
            ProductSize.Clear()
            ProductSize.ForeColor = Color.Black
        End If
    End Sub

    Private Sub ProductSize_Leave(sender As Object, e As EventArgs) Handles ProductSize.Leave
        If ProductSize.Text = "" Then
            ProductSize.Text = "Size"
            ProductSize.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub UnitLength_MouseClick(sender As Object, e As MouseEventArgs) Handles UnitLength.MouseClick
        If UnitLength.Text = "Unit Length" Then
            UnitLength.Clear()
            UnitLength.ForeColor = Color.Black
        End If
    End Sub

    Private Sub UnitLength_Leave(sender As Object, e As EventArgs) Handles UnitLength.Leave
        If UnitLength.Text = "" Then
            UnitLength.Text = "Unit Length"
            UnitLength.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub ProductDimension_MouseClick(sender As Object, e As MouseEventArgs) Handles ProductDimension.MouseClick
        If ProductDimension.Text = "Dimensions" Then
            ProductDimension.Clear()
            ProductDimension.ForeColor = Color.Black
        End If
    End Sub

    Private Sub ProductDimension_Leave(sender As Object, e As EventArgs) Handles ProductDimension.Leave
        If ProductDimension.Text = "" Then
            ProductDimension.Text = "Dimensions"
            ProductDimension.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub Quantity_MouseClick(sender As Object, e As MouseEventArgs) Handles Quantity.MouseClick
        If Quantity.Text = "Quantity" Then
            Quantity.Clear()
            Quantity.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Quantity_Leave(sender As Object, e As EventArgs) Handles Quantity.Leave
        If Quantity.Text = "" Then
            Quantity.Text = "Quantity"
            Quantity.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub BuyingPrice_MouseClick(sender As Object, e As MouseEventArgs) Handles BuyingPrice.MouseClick
        If BuyingPrice.Text = "Buying Price" Then
            BuyingPrice.Clear()
            BuyingPrice.ForeColor = Color.Black
        End If
    End Sub

    Private Sub BuyingPrice_Leave(sender As Object, e As EventArgs) Handles BuyingPrice.Leave
        If BuyingPrice.Text = "" Then
            BuyingPrice.Text = "Buying Price"
            BuyingPrice.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub SellingPrice_MouseClick(sender As Object, e As MouseEventArgs) Handles SellingPrice.MouseClick
        If SellingPrice.Text = "Selling Price" Then
            SellingPrice.Clear()
            SellingPrice.ForeColor = Color.Black
        End If
    End Sub

    Private Sub SellingPrice_Leave(sender As Object, e As EventArgs) Handles SellingPrice.Leave
        If SellingPrice.Text = "" Then
            SellingPrice.Text = "Selling Price"
            SellingPrice.ForeColor = Color.Gray
        End If
    End Sub

    '----------------------------------------------------------------------------
    '----------------------------------------------------------------------------
End Class