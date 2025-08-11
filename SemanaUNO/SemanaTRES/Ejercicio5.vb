Public Class Ejercicio5


    Sub Main()

        Console.Clear()

        Dim numero As Integer

        Console.WriteLine("Ingrese un número:")
        numero = CInt(Console.ReadLine())

        If numero Mod 2 = 0 Then
            Console.WriteLine("El número " & numero & " es par.")

        Else
            Console.WriteLine("El número " & numero & " es impar.")
        End If

        Console.ReadKey()
        Console.Clear()

    End Sub

End Class
