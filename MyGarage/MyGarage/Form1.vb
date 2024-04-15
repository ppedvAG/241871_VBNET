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

        Dim v2 = New Vehicle()
        v2.Manufacturer = "Raudi"
        v2.Model = "Rocus"
        v2.KW = 12
        v2.BuildDate = New Date(2099, 2, 2)
        v2.Color = "Rot"

        Dim v3 = New Vehicle()
        v3.Manufacturer = "Zaudi"
        v3.Model = "Zocus"
        v3.KW = 986
        v3.BuildDate = New Date(1854, 11, 11)
        v3.Color = "Blau"

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

        DataGridView1.DataSource = faker.Generate(1000)

    End Sub
End Class
