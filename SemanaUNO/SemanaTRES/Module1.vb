Module Module1

    Sub Main()
        Console.WriteLine("Semana TRES  Ejercicios Prácticos - Introducción a Visual Basic .NET")


        Dim salir As Boolean = False


        While Not salir
            Console.WriteLine("Seleccione una opción:")
            Console.WriteLine("1. Ejercicio 1")
            Console.WriteLine("2. Ejercicio 2")
            Console.WriteLine("3. Ejercicio 3")
            Console.WriteLine("4. Ejercicio 4")
            Console.WriteLine("5. Ejercicio 5")
            Console.WriteLine("6. Ejercicio 6")
            Console.WriteLine("7. Ejercicio 7")
            Console.WriteLine("8. Ejercicio 8")
            Console.WriteLine("9. Ejercicio 9")
            Console.WriteLine("10. Ejercicio 10")
            Console.WriteLine("11. Ejercicio 11")
            Console.WriteLine("12. Salir")

            Console.Write("Ingrese su opción: ")
            Dim opcion As String = Console.ReadLine()
            Select Case opcion
                Case "1"
                    Dim ejercicio1 As New Ejercicio1()
                    ejercicio1.Main()
                Case "2"
                    Dim ejercicio2 As New Ejercicio2()
                    ejercicio2.Main()
                Case "3"
                    Dim ejercicio3 As New Ejercicio3()
                    ejercicio3.Main()
                Case "4"
                    Dim ejercicio4 As New Ejercicio4()
                    ejercicio4.Main()
                Case "5"
                    Dim ejercicio5 As New Ejercicio5()
                    ejercicio5.Main()
                Case "6"
                    Dim ejercicio6 As New Ejercicio6()
                    ejercicio6.Main()

                Case "7"
                    Dim ejercicio7 As New Ejercicio7()
                    ejercicio7.Main()

                Case "8"
                    Dim ejercicio8 As New Ejercicio8()
                    ejercicio8.Main()

                Case "9"
                    Console.Clear()
                    Dim ejercicio9 As New Ejercicio9()
                    ejercicio9.Main()
                Case "10"

                    Dim ejercicio10 As New Ejercicio10()
                    ejercicio10.Main()
                Case "11"
                    Console.Clear()
                    Dim ejercicio11 As New Ejercicio11()
                    ejercicio11.ShowDialog()

                Case "12"
                    salir = True
                Case Else

                    Console.WriteLine("Opción no válida, por favor intente de nuevo.")

            End Select
            Console.WriteLine()
        End While
    End Sub

End Module
