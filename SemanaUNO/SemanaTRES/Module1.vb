Module Module1

    Sub Main()
        Console.WriteLine("Semana TRES  Ejercicios Prácticos - Introducción a Visual Basic .NET")


        Dim salir As Boolean = False


        While Not salir
            Console.WriteLine("Seleccione una opción:")
            Console.WriteLine("1. Ejercicio 1")
            Console.WriteLine("2. Ejercicio 2")
            Console.WriteLine("3. Ejercicio 3")
            Console.WriteLine("4. Salir")
            Dim opcion As String = Console.ReadLine()
            Select Case opcion
                Case "1"
                    Dim ejercicio1 As New Ejercicio1()
                    ejercicio1.Main()
                Case "2"
                    Dim ejercicio2 As New Ejercicio2()
                    ejercicio2.Main()
                Case "3"

                Case "4"
                    salir = True
                Case Else
                    Console.WriteLine("Opción no válida, por favor intente de nuevo.")
            End Select
            Console.WriteLine()
        End While
    End Sub

End Module
