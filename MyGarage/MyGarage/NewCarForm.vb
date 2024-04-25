Imports MyGarage.Model

Public Class NewCarForm

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        For Each et In [Enum].GetValues(GetType(EngineType))
            engineComboBox.Items.Add(et)
        Next

        'engineComboBox.Items.Add(EngineType.Gas)
        'engineComboBox.Items.Add(EngineType.Electric)
        'engineComboBox.Items.Add(EngineType.Diesel)
        'engineComboBox.Items.Add(EngineType.EFuel)
        'engineComboBox.Items.Add(EngineType.H2)

    End Sub

    Property SelectedCar As Car

    Private Sub NewCarForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        manufacturerTextBox.DataBindings.Add(NameOf(TextBox.Text), SelectedCar, NameOf(Car.Manufacturer))
        modelTextBox.DataBindings.Add(NameOf(TextBox.Text), SelectedCar, NameOf(Car.Model))
        powerNumericUpDown.DataBindings.Add(NameOf(NumericUpDown.Value), SelectedCar, NameOf(Car.KW), True)
        buildDateTimePicker.DataBindings.Add(NameOf(DateTimePicker.Value), SelectedCar, NameOf(Car.BuildDate), True)
        colorTextBox.DataBindings.Add(NameOf(TextBox.Text), SelectedCar, NameOf(Car.Color))
        engineComboBox.DataBindings.Add(NameOf(ComboBox.SelectedItem), SelectedCar, NameOf(Car.Engine), True, DataSourceUpdateMode.OnPropertyChanged)
        licencePlateMaskedTextBox.DataBindings.Add(NameOf(MaskedTextBox.Text), SelectedCar, NameOf(Car.Kennzeichen), True)

    End Sub


    Private Sub okButton_Click(sender As Object, e As EventArgs) Handles okButton.Click

        DialogResult = DialogResult.OK
        Close()

    End Sub

    Private Sub abortButton_Click(sender As Object, e As EventArgs) Handles abortButton.Click

        DialogResult = DialogResult.Abort
        Close()

    End Sub



    'Function GetCar() As Car
    '    Dim nc = New Car()

    '    nc.Manufacturer = manufacturerTextBox.Text
    '    nc.Model = modelTextBox.Text
    '    nc.KW = CType(powerNumericUpDown.Value, Integer)
    '    nc.BuildDate = buildDateTimePicker.Value
    '    nc.Color = colorTextBox.Text
    '    nc.Engine = CType(engineComboBox.SelectedItem, EngineType)
    '    nc.Kennzeichen = licencePlateMaskedTextBox.Text

    '    Return nc
    'End Function

    'Sub SetCar(car As Car)
    '    manufacturerTextBox.Text = car.Manufacturer
    '    modelTextBox.Text = car.Model
    '    powerNumericUpDown.Value = car.KW
    '    buildDateTimePicker.Value = car.BuildDate
    '    colorTextBox.Text = car.Color
    '    engineComboBox.SelectedItem = car.Engine
    '    licencePlateMaskedTextBox.Text = car.Kennzeichen

    'End Sub
End Class