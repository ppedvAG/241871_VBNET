Module Module1

    Private Sub MachDoppel(zahl As Integer)
        zahl = zahl * 2
    End Sub

    Private Sub MachGelb(meinAuto As Fahrzeug)
        meinAuto.Farbe = "gelb"
    End Sub

    'todo wir ist noch was zu tun
    'hack  hier gibt es Hack

    Sub Main()
        Console.WriteLine("*** Hallo Klassen ***")

        Dim zahl As System.Int32 = 6
        Console.WriteLine(zahl)
        MachDoppel(zahl)
        Console.WriteLine(zahl)

        Dim meinAuto As Fahrzeug 'deklaration
        meinAuto = New Fahrzeug("XY-QQ 666", "blau") 'instanzierung
        Console.WriteLine(meinAuto.Farbe)
        MachGelb(meinAuto)
        Console.WriteLine(meinAuto.Farbe)
        meinAuto.Hersteller = "Baudi"
        meinAuto.Modell = "911"
        'meinAuto.Farbe = "blau"
        'meinAuto.Kennzeichen = "XX-XX 888" 'geht nicht, weil readonly
        'meinAuto.SetFarbe("blau")
        meinAuto.MachSignal()
        ZeigeFahrzeugInfos(meinAuto)

        Dim meinFahrrad As Fahrzeug = New Fahrzeug("AB-CD 999", 8) 'deklaration + instanzierung
        meinFahrrad.Hersteller = "Bose"
        meinFahrrad.Modell = "Golf"
        'meinFahrrad.Farbe = "gelb"
        'meinFahrrad.SetFarbe("gelb")
        meinFahrrad.MachSignal()
        ZeigeFahrzeugInfos(meinFahrrad)

        Dim liste = New List(Of Fahrzeug)
        While True
            liste.Add(New Fahrzeug("666"))
        End While

        Console.WriteLine("Ende")
        Console.ReadLine()

    End Sub



    Sub ZeigeFahrzeugInfos(fahrzeug As Fahrzeug)

        ZeigeFahrzeugInfos(fahrzeug)
        Console.WriteLine($"Das Fahrzeug ist von Hersteller {fahrzeug.Hersteller}, " &
                          $"das Modell {fahrzeug.Modell} in der Farbe {fahrzeug.Farbe}")
    End Sub

End Module

