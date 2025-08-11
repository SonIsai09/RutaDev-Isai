Public Class Ejercicio3

    Sub Main()


        Dim nombre As String
        Dim anioNacimiento As Integer

        Console.Clear()
        Console.WriteLine("Ingrese su nombre:")
        nombre = Console.ReadLine()

        Console.WriteLine("Ingrese su año de nacimiento:")
        anioNacimiento = CInt(Console.ReadLine())



        Dim anioActual As Integer = DateTime.Now.Year

        Dim edadCalculado As Integer

        edadCalculado = anioActual - anioNacimiento

        Console.WriteLine("Hola " & nombre & vbNewLine & "Tienes aproximadamente " & edadCalculado & " Años")
        Console.ReadKey()
        Console.Clear()
    End Sub

End Class
