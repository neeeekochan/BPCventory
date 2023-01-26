Public Class PrinterClass
    Public Sub Print(sender As Object, e As Printing.PrintPageEventArgs, DGV As DataGridView)

        Dim x As Integer = 50
        Dim y As Integer = 50


        'draw headers
        Dim ja As Integer = 0
        Do While (ja < DGV.Columns.Count - 1)
            Dim rect As Rectangle = New Rectangle(x, y, DGV.Columns(ja).Width, DGV.ColumnHeadersHeight)
            Dim sf As StringFormat = New StringFormat
            sf.LineAlignment = StringAlignment.Center
            sf.Alignment = StringAlignment.Center
            e.Graphics.FillRectangle(Brushes.LightGray, rect)
            e.Graphics.DrawRectangle(Pens.Black, rect)
            If (Not (DGV.Columns(ja).HeaderText) Is Nothing) Then
                e.Graphics.DrawString(DGV.Columns(ja).HeaderText, SystemFonts.DefaultFont, Brushes.Black, rect, sf)
            End If
            x = (x + rect.Width)
            ja = (ja + 1)
        Loop
        x = 50
        y = (y + DGV.ColumnHeadersHeight)
    
        'draw rows
        For Each row As DataGridViewRow In DGV.Rows
            Dim j = 0
            Do While (j < DGV.Columns.Count - 1)
                Dim cell As DataGridViewCell
                cell = row.Cells(j)
                Dim rect As Rectangle = New Rectangle(x, y, cell.Size.Width, cell.Size.Height + 10)
                Dim sf As StringFormat = New StringFormat
                sf.LineAlignment = StringAlignment.Center
                sf.Alignment = StringAlignment.Center
                e.Graphics.DrawRectangle(Pens.Black, rect)
                If (Not (cell.Value) Is Nothing) Then
                    e.Graphics.DrawString(cell.Value.ToString, SystemFonts.DefaultFont, Brushes.Black, rect, sf)
                End If
                x = (x + rect.Width)
                j = (j + 1)
            Loop
            x = 50
            y = (y + row.Height + 10)
        Next
    End Sub
End Class
