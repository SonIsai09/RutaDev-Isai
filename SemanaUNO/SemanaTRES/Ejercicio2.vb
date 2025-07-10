Public Class Ejercicio2

    Sub Main()
        Console.Clear()
        Dim miEdad As Integer = 29
        Dim miAltura As Double = 1.75
        Dim miNombre As String = "Isaí Álvarez"
        Dim usuarioActivo As Boolean = True
        Dim miFechaNacimiento As Date = New Date(1995, 9, 25)



        Console.WriteLine("Mi edad es: " & miEdad & vbNewLine & "Mi estatura es: " & miAltura & vbNewLine & "Mi Nombre: " & miNombre & vbNewLine & "Usuario Activo: " & usuarioActivo & vbNewLine & "Fecha Nacimiento: " & miFechaNacimiento)
        Console.ReadKey()
        Console.Clear()
    End Sub

End Class
