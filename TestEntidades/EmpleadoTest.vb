Imports Entidades

Module EmpleadoTest
    Sub main()
        Dim e As New Empleado()
        e.nombre = "Pepe"
        e.fechaNacimiento = Today
        mostrarEmpleado(e)
        e.fechaNacimiento = Today.AddYears(-1)
        mostrarEmpleado(e)
    End Sub

    Private Sub mostrarEmpleado(e As Empleado)
        Console.WriteLine(e.fechaNacimiento)
        Console.WriteLine(e.isCumpleañosHoy)
    End Sub
End Module
