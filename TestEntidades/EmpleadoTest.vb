Imports Entidades

Module EmpleadoTest
    Sub main()
        Dim e As New Empleado()
        e.nombre = "Pepe"
        e.fechaNacimiento = Today
        Console.WriteLine(e.isCumpleañosHoy)
        e.fechaNacimiento = Today.AddYears(-1)
        Console.WriteLine(e.isCumpleañosHoy)
    End Sub
End Module
