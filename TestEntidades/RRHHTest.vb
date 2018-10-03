Imports Entidades

Module RRHHTest

    Sub Main()
        Dim rrhh As New RRHH()

        Dim cliente1 As New Cliente()
        cliente1.nombre = "Juan Perez"
        cliente1.fechaNacimiento = Today.Date
        rrhh.addCumpleañero(cliente1)

        Dim empleado1 As New Empleado()
        empleado1.nombre = "Pepe"
        empleado1.fechaNacimiento = Today.Date
        rrhh.addCumpleañero(empleado1)

        Dim empleado2 As New Empleado()
        empleado2.nombre = "Portero"
        empleado2.fechaNacimiento = Today.Date.AddDays(-10)
        rrhh.addCumpleañero(empleado2)

        rrhh.felicitarCumpleañeros()
    End Sub

End Module
