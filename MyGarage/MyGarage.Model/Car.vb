Public Class Car
    Inherits Vehicle

    Public Property Kennzeichen As String
    Public Overrides Function GetInfo() As String
        Return MyBase.GetInfo() & ", especially a car"
    End Function

End Class

