Imports System.Data.SqlClient

Module Module1

    Sub Main()

        Console.WriteLine("Hallo Datenbank")

        Dim conString = "Server=(localdb)\mssqllocaldb;Database=Northwnd;Trusted_Connection=true"

        Dim con = New SqlConnection(conString)
        con.Open()
        Console.WriteLine("Connection OK")

        Dim countCmd = New SqlCommand()
        countCmd.Connection = con
        countCmd.CommandText = "SELECT count(*) FROM Employees"
        Dim count = countCmd.ExecuteScalar()
        Console.WriteLine($"Employees in DB: {count}")

        Dim cmd = New SqlCommand()
        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM Employees"
        Dim reader = cmd.ExecuteReader()
        While reader.Read()
            Console.WriteLine($"{reader.GetString(2)} {reader.GetString(1)} {reader("BirthDate")} ")
        End While

        Console.WriteLine("Ende")
        Console.ReadKey()


    End Sub

End Module
