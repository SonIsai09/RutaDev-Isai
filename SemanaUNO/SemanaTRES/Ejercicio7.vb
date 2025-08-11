Public Class Ejercicio7

    Sub Main()
        Console.Clear()
        Dim numeroSecreto As Integer = 7
        Dim numeroUsuario As Integer = 0

        Do
            Console.WriteLine("Adivina el número secreto (entre 1 y 10):")
            numeroUsuario = Console.ReadLine()

            If numeroUsuario = numeroSecreto Then
                Console.WriteLine("¡Felicidades! Has adivinado el número secreto.")
            Else
                Console.WriteLine("Inténtalo de nuevo. El número secreto es diferente.")
            End If

        Loop While numeroUsuario <> numeroSecreto


        Console.ReadKey()
        Console.Clear()
    End Sub


End Class
