Imports MySql.Data.MySqlClient

Public Class Form1

    Private Sub InsertButton_Click(sender As Object, e As EventArgs) Handles InsertButton.Click
        ' Get the values from the textboxes and combo boxes on the form
        Dim customerName As String = customerNameTextBox.Text
        Dim age As Integer = Convert.ToInt32(ageTextBox.Text)
        Dim sex As String = sexComboBox.SelectedItem.ToString()
        Dim address As String = addressTextBox.Text
        Dim contact As String = contactTextBox.Text
        Dim status As String = statusComboBox.SelectedItem.ToString()
        Dim membershipStatus As String = membershipStatusComboBox.SelectedItem.ToString() ' Add this line for membership status

        ' Call the InsertOwnerInfo function from the DatabaseHelper module
        Module1.InsertOwnerInfo(customerName, age, sex, address, contact, status, membershipStatus)

        ' Notify the user that the data was inserted successfully
        MessageBox.Show("Data inserted successfully!")
    End Sub

    ' Button click event to connect to the MySQL database
    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Try
            ' Create a MySQL connection
            Dim conn As New MySqlConnection("server=localhost;user=root;password=rdtimbangMysql1;database=nomvet")

            ' Open connection and notify user
            conn.Open()
            MessageBox.Show("Connected successfully!")
            conn.Close()
        Catch ex As MySqlException
            ' If connection fails, show an error message
            MessageBox.Show("Connection failed: " & ex.Message)
        End Try
    End Sub





End Class
