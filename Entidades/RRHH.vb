Public Class RRHH
    Private _icumpleañeros As List(Of ICumpleañero)

    Sub New()
        _icumpleañeros = New List(Of ICumpleañero)

    End Sub

    Public Sub addCumpleañero(cumpleañero As ICumpleañero)
        _icumpleañeros.Add(cumpleañero)
    End Sub

    Public Sub removeCumpleañero(cumpleañero As ICumpleañero)
        _icumpleañeros.Remove(cumpleañero)
    End Sub

    Public Function getAllCumpleañeros() As List(Of ICumpleañero)
        Return _icumpleañeros
    End Function

    Public Sub felicitarCumpleañeros()
        For Each cumpleañero As ICumpleañero In getAllCumpleañeros()
            If cumpleañero.isCumpleañosHoy() Then
                Console.WriteLine("Feliz cumpleaños" & cumpleañero.ToString())
            End If
        Next

    End Sub
End Class
