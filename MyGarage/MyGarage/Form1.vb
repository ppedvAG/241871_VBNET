﻿Imports System.IO
Imports Bogus
Imports MyGarage.Model
Imports Newtonsoft
Imports Newtonsoft.Json

Public Class Form1


    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DataGridView1.DataSource = BindingSource1
    End Sub

    Private Sub ShowTestCarsButton_Click(sender As Object, e As EventArgs) Handles showTestCarsButton.Click

        Dim liste = New List(Of Vehicle)

        Dim veh1 = New Vehicle()
        veh1.Manufacturer = "Baudi"
        veh1.Model = "911"
        veh1.KW = 137
        veh1.BuildDate = New Date(2000, 12, 12)
        veh1.Color = "Gelb"
        veh1.Engine = EngineType.Electric

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
        v3.Engine = EngineType.EFuel


        liste.Add(veh1)
        liste.Add(v2)
        liste.Add(v3)

        BindingSource1.DataSource = liste

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

        BindingSource1.DataSource = faker.Generate(1000)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim cars = CType(BindingSource1.DataSource, List(Of Vehicle))
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

            Try

                Dim sr As New StreamReader(openFileDialog1.FileName)
                Dim liste As New List(Of Vehicle)
                While Not sr.EndOfStream

                    Dim line = sr.ReadLine()
                    Dim chunks = line.Split(";"c)

                    Dim car = New Vehicle()
                    car.Manufacturer = chunks(0)
                    car.Model = chunks(1)
                    car.KW = Integer.Parse(chunks(2))
                    car.BuildDate = DateTime.Parse(chunks(3))
                    car.Color = chunks(4)
                    car.Engine = CType([Enum].Parse(GetType(EngineType), chunks(5)), EngineType)
                    liste.Add(car)

                End While

                sr.Close()
                BindingSource1.DataSource = liste

            Catch ex As IOException
                MessageBox.Show($"Lesefehler: {ex.Message}")
            Catch ex As FormatException
                MessageBox.Show($"Dateiinhalt nicht korrekt: {ex.Message}")
            Catch ex As Exception
                MessageBox.Show($"Fehler: {ex.Message}")
            End Try
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        BindingSource1.DataSource = New List(Of Vehicle)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Dim car As New Car()
        car.Manufacturer = "Bolkswagen"
        car.Kennzeichen = "HD-XX 9999"

        Dim veh As New Vehicle
        veh.Manufacturer = "Bolvo"

        Dim b As New Bike
        b.Manufacturer = "Beidner"

        ZeigeInfo(veh)
        ZeigeInfo(car)
        ZeigeInfo(b)

    End Sub

    Public Sub ZeigeInfo(veh As Vehicle)

        Dim bike = TryCast(veh, Bike)
        If bike IsNot Nothing Then
            MessageBox.Show($"Fahrrad von: {veh.Manufacturer}  {veh.GetInfo()}")
        Else
            MessageBox.Show($"{veh.Manufacturer} {veh.GetInfo()}")
        End If

        'MessageBox.Show(veh.Manufacturer & " " & veh.GetInfo())
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim ncf = New NewCarForm()
        ncf.BackColor = Color.Thistle
        ncf.StartPosition = FormStartPosition.CenterParent
        ncf.SelectedCar = New Car()

        If ncf.ShowDialog() = DialogResult.OK Then

            'AddToListOrCreateNewListToShowCar(nc)
            BindingSource1.Add(ncf.SelectedCar)
        Else
            MessageBox.Show("😔")
        End If

    End Sub



    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        If Not DataGridView1.CurrentRow Is Nothing Then 'nix machen, liste leer
            Dim selectedCar = TryCast(DataGridView1.CurrentRow.DataBoundItem, Car)

            If Not selectedCar Is Nothing Then
                Dim ncf = New NewCarForm()
                ncf.BackColor = Color.Indigo
                ncf.StartPosition = FormStartPosition.CenterParent

                ncf.SelectedCar = selectedCar

                If ncf.ShowDialog() = DialogResult.OK Then
                    'BindingSource1.Add(ncf.SelectedCar)

                End If

            End If
        End If

    End Sub

    'Private Sub AddToListOrCreateNewListToShowCar(nc As Car)

    '    If BindingSource1.DataSource Is Nothing Then 'new list
    '        Dim liste = New List(Of Car)
    '        liste.Add(nc)
    '        BindingSource1.DataSource = liste
    '    Else 'add to list

    '        Dim carList = TryCast(BindingSource1.DataSource, List(Of Car))
    '        If Not carList Is Nothing Then
    '            carList.Add(nc)
    '        End If

    '    End If

    'End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim aaaa As New HalloBinding()
        aaaa.ShowDialog()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        Dim cars = TryCast(BindingSource1.List, IEnumerable(Of Car))
        If Not cars Is Nothing Then
            Try
                Dim json As String = JsonConvert.SerializeObject(cars)
                File.WriteAllText("cars.json", json)
                MessageBox.Show("Done")
            Catch ex As Exception
                MessageBox.Show($"Fehler: {ex.Message}")
            End Try
        Else
            MessageBox.Show("Keine Autos in der Liste :-(")
        End If

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try
            Dim json As String = File.ReadAllText("cars.json")
            Dim listeOfCars = JsonConvert.DeserializeObject(Of IEnumerable(Of Car))(json)

            For Each car In listeOfCars
                BindingSource1.Add(car)
            Next

        Catch ex As Exception
            MessageBox.Show($"Fehler: {ex.Message}")

        End Try

    End Sub
End Class
