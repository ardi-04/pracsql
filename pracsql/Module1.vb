Imports MySql.Data.MySqlClient

Module Module1
    ' Connection string to the MySQL database
    Private conn As New MySqlConnection("server=localhost;user=root;password=rdtimbangMysql1;database=nomvet")

    ' Function to insert data into the ownerInfo table
    Public Sub InsertOwnerInfo(customerName As String, age As Integer, sex As String, address As String, contact As String, status As String, membershipStatus As String)
        Try
            ' SQL query with placeholders for parameters
            Dim query As String = "INSERT INTO ownerInfo (customer_name, customer_age, customer_sex, customer_address, customer_contact, customer_status, membership_status) " &
                                   "VALUES (@customer_name, @customer_age, @customer_sex, @customer_address, @customer_contact, @customer_status, @membership_status)"

            ' Create a new command object with the query and connection
            Dim command As New MySqlCommand(query, conn)

            ' Add parameters to the command object
            command.Parameters.AddWithValue("@customer_name", customerName)
            command.Parameters.AddWithValue("@customer_age", age)
            command.Parameters.AddWithValue("@customer_sex", sex)
            command.Parameters.AddWithValue("@customer_address", address)
            command.Parameters.AddWithValue("@customer_contact", contact)
            command.Parameters.AddWithValue("@customer_status", status)
            command.Parameters.AddWithValue("@membership_status", membershipStatus) ' Add the new parameter

            ' Open connection, execute the query, then close the connection
            conn.Open()
            command.ExecuteNonQuery()
            conn.Close()

        Catch ex As Exception
            ' Handle any errors (e.g., connection issues, query errors)
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Module
