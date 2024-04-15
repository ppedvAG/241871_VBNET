Public Class Fahrzeug
    'felder
    Private _farbe As String 'backing field
    'Public hersteller As String
    'Public modell As String

    'properties
    Public Property Farbe As String 'full Property
        Get
            Return _farbe
        End Get
        Set(value As String)
            _farbe = value
        End Set
    End Property

    Public Property Hersteller As String 'auto Property
    Public Property Modell As String 'auto Property
    Public ReadOnly Property Kennzeichen As String 'auto Property

    Public Property AnzahlRäder As Integer 'auto Property


    'subs / functions
    Public Sub MachSignal()
        Console.WriteLine($"Das {_farbe}e Fahrzeug macht BRRRRR")
    End Sub

    'konstruktor
    Sub New(kennzeichen As String)
        Farbe = "pink"
        Me.Kennzeichen = kennzeichen
    End Sub

    Sub New(kennzeichen As String, farbe As String)
        Me.Farbe = farbe
        Me.Kennzeichen = kennzeichen
    End Sub

    Sub New(kennzeichen As String, räder As Integer)
        Me.AnzahlRäder = räder
        Me.Kennzeichen = kennzeichen
    End Sub


    'setter methode (unüblich!)
    Public Sub SetFarbe(farbe As String)
        _farbe = farbe
        'Me == this
    End Sub

    'getter function (unüblich!)
    Public Function GetFarbe() As String
        Return _farbe
    End Function

End Class
