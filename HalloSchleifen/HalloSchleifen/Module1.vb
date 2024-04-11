Imports System.Reflection

Module Module1

    Sub Main()
        Console.WriteLine("Hallo Schleifen")

        Dim zahlen(4) As Integer
        zahlen(0) = 12
        zahlen(1) = -5
        zahlen(2) = 3
        zahlen(3) = 9999
        zahlen(4) = -500

        For index As Integer = 0 To zahlen.Length - 1
            Console.WriteLine($"Der Wert von Index {index} ist {zahlen(index)}")
        Next

        For Each zahl As Integer In zahlen
            Console.WriteLine($"Zahl: {zahl}")
        Next


        Dim eingabe As ConsoleKey

        While eingabe <> ConsoleKey.D2


            Console.WriteLine("Ende? [y]")
            eingabe = Console.ReadKey().Key

        End While

    End Sub

End Module
