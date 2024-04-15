Module Module1

    Sub Main()
        Console.WriteLine("*** Hallo Klassen ***")

        Dim meinAuto As Fahrzeug 'deklaration
        meinAuto = New Fahrzeug("XY-QQ 666", "blau") 'instanzierung
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

        Console.WriteLine("Ende")
        Console.ReadLine()

    End Sub

    Sub ZeigeFahrzeugInfos(fahrzeug As Fahrzeug)
        Console.WriteLine($"Das Fahrzeug ist von Hersteller {fahrzeug.Hersteller}, " &
                          $"das Modell {fahrzeug.Modell} in der Farbe {fahrzeug.Farbe}")
    End Sub

End Module

