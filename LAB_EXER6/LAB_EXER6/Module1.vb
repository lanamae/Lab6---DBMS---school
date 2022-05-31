Imports MySql.Data.MySqlClient
Module Module1
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand


    Sub opencon()
        con.ConnectionString = "server=localhost;port=3307;username=root;password=;database=db_fproject"
        con.Open()
    End Sub
End Module
