Module Module1

    Sub Main()
        Console.OutputEncoding = Text.Encoding.UTF8

        Dim eineZahl As Integer = 555
        Dim kommaZahl As Double = 3.4
        Dim hallo As String = "Hallo"

        Console.WriteLine(hallo)
        Console.WriteLine("Welt")

        Console.WriteLine(hallo & " Welt")

        Console.WriteLine("Zahl: " & eineZahl)
        Console.WriteLine("Zahl: {0} und mit Komma: {1:c}", eineZahl, kommaZahl) 'string formating
        Console.WriteLine($"Zahl: {eineZahl} und mit Komma: {kommaZahl:c}") 'string interpolation

        Dim eingabe As String = Console.ReadLine()
        Console.WriteLine($"Du hast eingegeben: {eingabe}")

        Dim eingabeAlsZahl As Integer
        If Integer.TryParse(eingabe, eingabeAlsZahl) Then
            Console.WriteLine($"Das doppelte: {eingabeAlsZahl * 2}")
        Else
            Console.WriteLine($"Das ist keine coole Zahl: {eingabe}")
        End If

        eingabeAlsZahl = CInt(kommaZahl)


        Console.ReadKey()

    End Sub

End Module
