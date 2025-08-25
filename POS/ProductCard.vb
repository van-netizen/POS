Public Class ProductCard


    Public Property ProductCategory As String
        Get
            Return lblCategory.Text
        End Get
        Set(value As String)
            lblCategory.Text = value
        End Set
    End Property

    Public Property ProductNames As String
        Get
            Return lblname.Text
        End Get
        Set(value As String)
            lblname.Text = value
        End Set
    End Property

    Public Property ProductPrice As Decimal
        Get
            Dim price As Decimal
            If Decimal.TryParse(lblPrice.Text.Replace("₱", ""), price) Then
                Return price
            Else
                Return 0
            End If
        End Get
        Set(value As Decimal)
            lblPrice.Text = "₱" & value.ToString("N2")
        End Set
    End Property

    Public Property ProductDescription As String
        Get
            Return lblDescription.Text
        End Get
        Set(value As String)
            lblDescription.Text = value
        End Set
    End Property

    Public Sub SetImage(imagePath As String)
        Try
            If System.IO.File.Exists(imagePath) Then
                PictureBox1.Image = Image.FromFile(imagePath)
            Else
                PictureBox1.Image = Nothing ' Or set a default image
            End If
        Catch ex As Exception
            PictureBox1.Image = Nothing
        End Try


        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub

End Class
