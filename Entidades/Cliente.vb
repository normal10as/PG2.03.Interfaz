Imports Entidades

Public Class Cliente
    Implements ICumpleañero

    Private _fechaNacimiento As Date

    Sub New()

    End Sub

    Public Property fechaNacimiento As Date Implements ICumpleañero.fechaNacimiento
        Get
            Return _fechaNacimiento
        End Get
        Set(value As Date)
            _fechaNacimiento = value
        End Set
    End Property

    Public Function isCumpleañosHoy() As Boolean Implements ICumpleañero.isCumpleañosHoy
        Return Today.Date = fechaNacimiento
    End Function
End Class
