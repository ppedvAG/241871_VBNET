Public Class Vehicle
    Inherits Object

    Public Property Manufacturer As String
    Public Property Model As String
    Public Property KW As Integer
    Public Property BuildDate As Date = Date.Now
    Public Property Color As String
    Public Property Engine As EngineType

    Public Overridable Function GetInfo() As String
        Return "I'm a vehicle"
    End Function

End Class
