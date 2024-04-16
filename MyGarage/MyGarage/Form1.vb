Imports System.IO
Imports Bogus
Imports MyGarage.Model

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim liste = New List(Of Vehicle)

        Dim v1 = New Vehicle()
        v1.Manufacturer = "Baudi"
        v1.Model = "911"
        v1.KW = 137
        v1.BuildDate = New Date(2000, 12, 12)
        v1.Color = "Gelb"
        v1.Engine = EngineType.Electric

        Dim v2 = New Vehicle()
        v2.Manufacturer = "Raudi"
        v2.Model = "Rocus"
        v2.KW = 12
        v2.BuildDate = New Date(2099, 2, 2)
        v2.Color = "Rot"
        v2.Engine = EngineType.Diesel

        Dim v3 = New Vehicle()
        v3.Manufacturer = "Zaudi"
        v3.Model = "Zocus"
        v3.KW = 986
        v3.BuildDate = New Date(1854, 11, 11)
        v3.Color = "Blau"
        v3.Engine = 2

        liste.Add(v1)
        liste.Add(v2)
        liste.Add(v3)

        DataGridView1.DataSource = liste

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim faker As New Faker(Of Vehicle)

        '-- Make a rule for each property
        faker.RuleFor(Function(c) c.Manufacturer, Function(f) f.Vehicle.Manufacturer())
        faker.RuleFor(Function(c) c.Model, Function(f) f.Vehicle.Model())
        faker.RuleFor(Function(c) c.KW, Function(f) f.Random.Int(20, 300))
        faker.RuleFor(Function(c) c.BuildDate, Function(f) f.Date.Past(10))
        faker.RuleFor(Function(c) c.Color, Function(f) f.Commerce.Color())
        'faker.RuleFor(Function(c) c.Engine, Function(f) f.Random.Int(0, 4))
        faker.RuleFor(Function(c) c.Engine, Function(f) f.PickRandom(Of EngineType))

        DataGridView1.DataSource = faker.Generate(1000)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim cars = CType(DataGridView1.DataSource, List(Of Vehicle))
        If cars IsNot Nothing Then
            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then

                Dim sw As New StreamWriter(SaveFileDialog1.FileName)

                For Each car In cars
                    'sw.WriteLine(car.Manufacturer & ";" & car.Model & ";" & car.KW & "...")
                    sw.WriteLine(String.Join(";", car.Manufacturer, car.Model, car.KW, car.BuildDate.ToShortDateString(), car.Color, CType(car.Engine, Integer)))
                Next

                sw.Close()

            End If
        Else
            MessageBox.Show("Keine Vehicle in der Liste")
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "CSV Datei|*.csv|Alle Dateien|*.*"

        If openFileDialog1.ShowDialog() = DialogResult.OK Then

            Dim sr As New StreamReader(openFileDialog1.FileName)
            Dim liste As New List(Of Vehicle)
            While Not sr.EndOfStream

                Dim line = sr.ReadLine()
                Dim chunks = line.Split(";")

                Dim car = New Vehicle()
                car.Manufacturer = chunks(0)
                car.Model = chunks(1)
                car.KW = chunks(2)
                car.BuildDate = chunks(3)
                car.Color = chunks(4)
                car.Engine = chunks(5)
                liste.Add(car)

            End While

            sr.Close()
            DataGridView1.DataSource = liste
        End If

    End Sub
End Class
