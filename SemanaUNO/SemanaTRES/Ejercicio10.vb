Public Class Ejercicio10


    Public Class Persona
        Public Property Nombre As String
        Public Property Edad As Integer

        Public Sub Saludar()
            Console.WriteLine("Hola, mi nombre es " & Nombre & " y tengo " & Edad & " años. Esto es una pruene de la semana 2 ejercicio 1")
        End Sub
    End Class


    Public Sub Main()
        Dim persona As New Persona()
        Console.Clear()
        persona.Nombre = "Isaí Álvarez"
        persona.Edad = 29

        persona.Saludar()
        Console.ReadKey()

        Console.Clear()
    End Sub

End Class
