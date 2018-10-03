Imports Entidades

Public Class Cliente
    Implements ICumpleañero

    Private _fechaNacimiento As Date
    Private _nombre As String

    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property fechaNacimiento As Date Implements ICumpleañero.fechaNacimiento
        Get
            Return _fechaNacimiento
        End Get
        Set(value As Date)
            _fechaNacimiento = value
        End Set
    End Property

    Public Function isCumpleañosHoy() As Boolean Implements ICumpleañero.isCumpleañosHoy
        Return Today.Date = fechaNacimiento.Date
    End Function

    Public Overrides Function ToString() As String
        Return nombre
    End Function
End Class
