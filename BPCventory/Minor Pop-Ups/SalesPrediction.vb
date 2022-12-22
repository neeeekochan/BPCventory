Imports MySql.Data.MySqlClient

Public Class SalesPrediction
    Private Sub SalesPrediction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SalesData = GetPredictionSalesReport()

        CalculatePredictionForNextMonth(SalesData)
        CalculatePredictionForNextTwoMonth(SalesData)
        CalculatePredictionForNextTHreeMonth(SalesData)

        GetHighestSellingProducts()
        GetLeastSellingProducts()
        GetChartData(SalesData)
    End Sub

    Dim CurrentDate = DateTime.Now

    Private Function GetPredictionSalesReport() As DataTable
        'Dim SQL = "Select YEAR(S.sales_date) As Year
        '                 , MONTH(S.sales_date) as Month
        '              , SUM(SD.total) AS Total
        '         From sales S
        '         inner Join sales_details SD
        '                On S.sales_id = SD.sales_id
        '            group by year, Month
        '            ORDER BY Year DESC
        '                    , month DESC 
        '            LIMIT 12"

        Dim SQL = "Select YEAR(S.sales_date) As Year
                         , MONTH(S.sales_date) as Month
	                     , SUM(SD.total) AS Total
	                From sales S
	                inner Join sales_details SD
                        On S.sales_id = SD.sales_id
                    WHERE DATE(CONCAT(YEAR(S.sales_date), '-', MONTH(S.sales_date), '-01')) <= DATE('" & Year(CurrentDate) & "-" & Month(CurrentDate) & "-01')
                    group by year, Month
                    ORDER BY Year DESC
                            , month DESC 
                    LIMIT 12"

        Return ExecuteDataTable(SQL)

        '' https://images.search.yahoo.com/search/images;_ylt=AwrOs3svC55jA74BJtiJzbkF;_ylu=c2xrA3RleHQEaXQDQWxzb1RyeV9OBHNlYwNyZWwEcG9zAzQ-?p=GSM%20SIM900&fr2=p:s,v:i,m:rs-top,ct:bing,rgn:top,pos:4&fr=mcafee&type=E210US91215G0#id=73&iurl=https%3A%2F%2Fwww.intellfengs.com%2Fimage%2Fcache%2Folimages%2F-02828100_2-800x1096.jpg&action=click
    End Function

    Private Sub CalculatePredictionForNextMonth(ByVal SalesData As DataTable)
        Dim CurrentMonth = Month(CurrentDate)
        Dim CurrentYear = Year(CurrentDate)

        Dim predictionDate = CurrentDate.AddMonths(1)

        Date_1.Text = String.Format("{0} {1}", Format(predictionDate, "MMMM"), Year(predictionDate).ToString())
        Sales_1.Text = "₱" + (CalculateNextMonthSales(SalesData)).ToString("N2")
    End Sub

    Private Sub CalculatePredictionForNextTwoMonth(ByVal SalesData As DataTable)
        Dim CurrentMonth = Month(CurrentDate)
        Dim CurrentYear = Year(CurrentDate)

        Dim predictionDate = CurrentDate.AddMonths(2)

        Date_2.Text = String.Format("{0} {1}", Format(predictionDate, "MMMM"), Year(predictionDate).ToString())
        Sales_2.Text = "₱" + (CalculateNextTwoMonthSales(SalesData)).ToString("N2")
    End Sub

    Private Sub CalculatePredictionForNextTHreeMonth(ByVal SalesData As DataTable)
        Dim CurrentMonth = Month(CurrentDate)
        Dim CurrentYear = Year(CurrentDate)

        Dim predictionDate = CurrentDate.AddMonths(3)

        Date_3.Text = String.Format("{0} {1}", Format(predictionDate, "MMMM"), Year(predictionDate).ToString())
        Sales_3.Text = "₱" + (CalculateNextThreeMonthSales(SalesData)).ToString("N2")
    End Sub

    Private Function CalculateNextMonthSales(ByVal SalesData As DataTable) As Decimal
        Dim Total As Decimal = 0

        For Each Sale As DataRow In SalesData.Rows
            Total += Convert.ToDouble(Sale("Total"))
        Next

        Return Total / 12
    End Function

    Private Function CalculateNextTwoMonthSales(ByVal SalesData As DataTable) As Decimal
        Dim StartIndex = 1
        Dim Total As Decimal = 0
        Dim NextMonthSales = CalculateNextMonthSales(SalesData)

        For Each Sale As DataRow In SalesData.Rows
            If StartIndex = 12 Then
                Exit For
            End If

            Total += Convert.ToDouble(Sale("Total"))
            StartIndex += 1
        Next

        Return (Total + NextMonthSales) / 12
    End Function

    Private Function CalculateNextThreeMonthSales(ByVal SalesData As DataTable) As Decimal
        Dim StartIndex = 1
        Dim Total As Decimal = 0
        Dim NextMonthSales = CalculateNextMonthSales(SalesData)
        Dim NextTwoMonthSales = CalculateNextTwoMonthSales(SalesData)

        For Each Sale As DataRow In SalesData.Rows
            If StartIndex = 11 Then
                Exit For
            End If

            Total += Convert.ToDouble(Sale("Total"))
            StartIndex += 1
        Next

        Return (Total + NextMonthSales + NextTwoMonthSales) / 12
    End Function

    Private Sub GetHighestSellingProducts()
        Dim SQL = "SELECT P.product_id
	                   , P.product_name
	                   , SUM(SD.sale_quantity) sold_count
	                FROM products P 
                    LEFT JOIN sales_details SD
    	                ON P.product_id = SD.product_id
                    GROUP BY product_id
                    ORDER BY SUM(SD.sale_quantity) DESC
                    LIMIT 5"

        HighestSellingDG.DataSource = ExecuteDataTable(SQL)

        HighestSellingDG.Columns(0).HeaderText = "Product ID"
        HighestSellingDG.Columns(1).HeaderText = "Product Name"
        HighestSellingDG.Columns(2).HeaderText = "Sold Quantity"

        For Each Column As DataGridViewColumn In HighestSellingDG.Columns
            Column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Column.HeaderCell.Style.Font = New Font("Arial", 14.0F, FontStyle.Bold, GraphicsUnit.Pixel)
        Next

        HighestSellingDG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub GetLeastSellingProducts()
        Dim SQL = "SELECT COUNT(*) FROM products"
        Dim ProductData = ExecuteDataTable(SQL)
        Dim ProductCount = Convert.ToInt32(ProductData.Rows(0)(0))

        If ProductCount < 10 Then
            ProductCount = ProductCount - 5
        Else ProductCount = 5
        End If

        SQL = "SELECT P.product_id
	                  , P.product_name
	                  , IFNULL(SUM(SD.sale_quantity), 0) sold_count
	            FROM products P 
                LEFT JOIN sales_details SD
    	            ON P.product_id = SD.product_id
                GROUP BY product_id
                ORDER BY SUM(SD.sale_quantity) ASC
                LIMIT " + ProductCount.ToString()


        LeastSellingDG.DataSource = ExecuteDataTable(SQL)

        LeastSellingDG.Columns(0).HeaderText = "Product ID"
        LeastSellingDG.Columns(1).HeaderText = "Product Name"
        LeastSellingDG.Columns(2).HeaderText = "Sold Quantity"

        For Each Column As DataGridViewColumn In LeastSellingDG.Columns
            Column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Column.HeaderCell.Style.Font = New Font("Arial", 14.0F, FontStyle.Bold, GraphicsUnit.Pixel)
        Next

        LeastSellingDG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Function ExecuteDataTable(ByVal SQL) As DataTable
        Dim dt = New DataTable()

        Using Connection As New MySqlConnection
            Connection.ConnectionString = "server=localhost;uid=root;password=;database=dt; Convert Zero Datetime=true;"
            Connection.Open()

            Using Command As New MySqlCommand
                Command.CommandText = SQL
                Command.Connection = Connection
                Using Adapter As New MySqlDataAdapter
                    Adapter.SelectCommand = Command
                    Adapter.Fill(dt)
                End Using
            End Using
        End Using

        Return dt
    End Function

    Private Sub GetChartData(ByVal SalesData As DataTable)
        Chart1.Series(0).Points.Clear()

        Chart1.Series(0).Points.AddXY(Format(CurrentDate.AddMonths(1), "MMMM") + Year(CurrentDate.AddMonths(1)).ToString(), Convert.ToDouble(CalculateNextMonthSales(SalesData)))
        Chart1.Series(0).Points.AddXY(Format(CurrentDate.AddMonths(2), "MMMM") + Year(CurrentDate.AddMonths(2)).ToString(), Convert.ToDouble(CalculateNextTwoMonthSales(SalesData)))
        Chart1.Series(0).Points.AddXY(Format(CurrentDate.AddMonths(3), "MMMM") + Year(CurrentDate.AddMonths(3)).ToString(), Convert.ToDouble(CalculateNextThreeMonthSales(SalesData)))
    End Sub
End Class