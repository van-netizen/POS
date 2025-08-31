Imports System.Data.OleDb

Public Class Form1
    Private Sub LoadProducts()
        FlowLayoutPanel1.Controls.Clear()

        Dim connStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Client\OneDrive\Desktop\Point of Sale\POSdatabase.accdb"
        Dim query As String = "SELECT Category, ProductName, Description, Price, imagePath FROM product"

        Using conn As New OleDbConnection(connStr)
            Using cmd As New OleDbCommand(query, conn)
                conn.Open()
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim card As New ProductCard()
                        card.ProductCategory = reader("Category").ToString()
                        card.ProductNames = reader("ProductName").ToString()
                        card.ProductDescription = reader("Description").ToString()
                        card.ProductPrice = Convert.ToDecimal(reader("Price"))
                        card.SetImage(reader("imagePath").ToString())

                        ' Optional: Set size if needed
                        card.Width = 200
                        card.Height = 250
                        card.Margin = New Padding(10)

                        AddHandler card.Click, AddressOf ProductCard_Click

                        FlowLayoutPanel1.Controls.Add(card)
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With receipt.Columns
            .Clear()
            .Add("ProductName", "Product Name")
            .Add("Price", "Price")
            .Add("Quantity", "Quantity")
            .Add("Total", "Total")
        End With

        receipt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        receipt.AllowUserToAddRows = False

        LoadProducts()
        FlowLayoutPanel1.AutoScroll = True
    End Sub


    Private Sub ProductCard_Click(sender As Object, e As EventArgs)
        Dim clickedCard As ProductCard = DirectCast(sender, ProductCard)

        Dim productName As String = clickedCard.ProductNames
        Dim price As Decimal = clickedCard.ProductPrice

        Dim itemFound As Boolean = False

        For Each row As DataGridViewRow In receipt.Rows
            If row.Cells("ProductName").Value IsNot Nothing AndAlso row.Cells("ProductName").Value.ToString() = productName Then
                Dim currentQty As Integer = Convert.ToInt32(row.Cells("Quantity").Value)
                row.Cells("Quantity").Value = currentQty + 1
                row.Cells("Total").Value = (currentQty + 1) * price
                itemFound = True
                Exit For
            End If
        Next

        If Not itemFound Then
            receipt.Rows.Add(productName, price.ToString("N2"), 1, price.ToString("N2"))
        End If
    End Sub

    Private Sub ClearReceiptbtn_Click(sender As Object, e As EventArgs) Handles ClearReceiptbtn.Click
        receipt.Rows.Clear()
    End Sub
End Class