Public Class AddNewProduct

    Function PresetDesc(Name As TextBox, Desc As TextBox, Quan As TextBox, BP As TextBox, SP As TextBox)
        For Each txt In {Name, Desc, Quan, BP, SP}
            txt.Clear()
            txt.ForeColor = Color.Gray
        Next
        '-------------------- PRESET DESCRIPTION ------------------------------
        Name.Text = "Enter Product Name Here"
        Desc.Text = "Product Description"
        Quan.Text = "Quantity"
        BP.Text = "Buying Price"
        SP.Text = "Selling Price"
        '------------------------------------------------------'

        Return 0
    End Function

    Private Sub CancelBttn_Click(sender As Object, e As EventArgs) Handles CancelBttn.Click
        Mainsystem.Opacity = 1
        Mainsystem.Enabled = True
        Hide()
        PresetDesc(ProductsName, ProductDescription, Quantity, BuyingPrice, SellingPrice)
    End Sub

    Private Sub ClearAllBttn_Click(sender As Object, e As EventArgs) Handles ClearAllBttn.Click
        MessageBox.Show("All Fields Cleared", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
        PresetDesc(ProductsName, ProductDescription, Quantity, BuyingPrice, SellingPrice)
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

    Private Sub ProductDescription_MouseClick(sender As Object, e As MouseEventArgs) Handles ProductDescription.MouseClick
        If ProductDescription.Text = "Product Description" Then
            ProductDescription.Clear()
            ProductDescription.ForeColor = Color.Black
        End If
    End Sub

    Private Sub ProductDescription_Leave(sender As Object, e As EventArgs) Handles ProductDescription.Leave
        If ProductDescription.Text = "" Then
            ProductDescription.Text = "Product Description"
            ProductDescription.ForeColor = Color.Gray
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