Public Class Vehicle

    Public Property Manufacturer As String
    Public Property Model As String
    Public Property KW As Integer
    Public Property BuildDate As Date
    Public Property Color As String
    Public Property Engine As EngineType

End Class

Public Enum EngineType
    Gas
    Electric
    Diesel
    EFuel
    H2
End Enum
