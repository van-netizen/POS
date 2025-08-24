Imports System.Configuration
Imports System.Data.OleDb
Public Class Login


    Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=   C:\Users\Client\OneDrive\Desktop\Point of Sale\POSdatabase.accdb")
    Dim cmd As OleDbCommand
    Dim dataReader As OleDbDataReader
    Dim dataAdapted As OleDbDataAdapter
    Dim dTable As DataTable
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Login()
    End Sub


    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Hide()
        Adminlog.Show()
    End Sub
    Sub Login()

        Try
            connection.Open()
            Dim query As String = "SELECT Firstname, Lastname FROM account WHERE [Username] = @username AND [Password] = @password"
            Dim cmd As New OleDbCommand(query, connection)
            cmd.Parameters.AddWithValue("@username", txt_username.Text)
            cmd.Parameters.AddWithValue("@password", txt_password.Text)

            Dim dataReader As OleDbDataReader = cmd.ExecuteReader()

            If dataReader.HasRows Then

                dataReader.Read()

                Dim firstName As String = dataReader("Firstname").ToString()
                Dim lastName As String = dataReader("Lastname").ToString()

                MessageBox.Show("Login Successful!")



                Me.Hide()
                Form1.Show()
            Else
                MessageBox.Show("Invalid Username or Password")
                txt_password.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub



End Class