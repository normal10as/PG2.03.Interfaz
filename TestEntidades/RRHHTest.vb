Imports Entidades

Module RRHHTest

    Sub Main()
        Dim r As New RRHH()

        Dim c As New Cliente()
        c.nombre = "Juan Perez"
        c.fechaNacimiento = Today.Date
        r.addCumpleañero(c)

        Dim e As New Empleado()
        e.nombre = "Pepe"
        e.fechaNacimiento = Today.Date
        r.addCumpleañero(e)

        Dim e2 As New Empleado()
        e2.nombre = "Portero"
        e2.fechaNacimiento = Today.Date.AddDays(1)
        r.addCumpleañero(e2)

        r.felicitarCumpleañeros()
    End Sub

End Module
