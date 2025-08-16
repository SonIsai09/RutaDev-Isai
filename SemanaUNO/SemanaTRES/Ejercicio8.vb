Public Class Ejercicio8


    Sub Main()


        Console.Clear()

        MostrarMensaje("Practica de VB .NET")



        Console.ReadKey()

        Console.Clear()

        Console.WriteLine("************Suma de dos números***********")
        Dim valor1 As Integer, valor2 As Integer
        Console.WriteLine("Ingre el primer valor")
        valor1 = Console.ReadLine()
        Console.WriteLine("Ingre el segundo valor")
        valor2 = Console.ReadLine()

        Console.WriteLine("El resultado de la suma es: " & SumarNumero(valor1, valor2))
        Console.ReadKey()

        Console.Clear()
    End Sub


    Sub MostrarMensaje(mensaje As String)

        Console.WriteLine("Hol esto es " & mensaje)
    End Sub

    Function SumarNumero(num1 As Integer, num2 As Integer) As Integer

        Dim resultado As Integer = num1 + num2

        Return resultado

    End Function

End Class
