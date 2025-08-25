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

                        FlowLayoutPanel1.Controls.Add(card)
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
        FlowLayoutPanel1.AutoScroll = True
    End Sub

End Class