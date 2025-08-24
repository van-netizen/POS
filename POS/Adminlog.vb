Imports System.Configuration
Imports System.Data.OleDb
Public Class Adminlog
    Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Client\OneDrive\Desktop\Point of Sale\POSdatabase.accdb")
    Dim cmd As OleDbCommand
    Dim dataReader As OleDbDataReader
    Dim dataAdapted As OleDbDataAdapter
    Dim dTable As DataTable
    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles password.TextChanged

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim inputPassword = password.Text

        Try
            connection.Open()
            Dim query = "SELECT * FROM adminpass WHERE [Password] = @password"
            Dim cmd As New OleDbCommand(query, connection)
            cmd.Parameters.AddWithValue("@password", inputPassword)

            Dim reader = cmd.ExecuteReader

            If reader.HasRows Then

                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Hide()
                Admin.Show()
            Else

                MessageBox.Show("Incorrect password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                password.Text = ""
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Hide()
        Login.Show()
    End Sub
End Class