Public Class Ejercicio4


    Sub Main()

        Console.Clear()
        Dim numero As Integer


        Console.WriteLine("Ingrese un numero")
        numero = CInt(Console.ReadLine())

        If numero > 0 Then
            Console.WriteLine("El numero " & numero & " es positivo")

        ElseIf numero < 0 Then
            Console.WriteLine("El numero " & numero & " es negativo")
        Else
            Console.WriteLine("El numero es cero")
        End If



        Console.ReadKey()
        Console.Clear()
    End Sub

End Class
