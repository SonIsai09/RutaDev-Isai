

using SemanaDOS;

Console.WriteLine("Semana DOS \n Ejercicios Prácticos - Programación Orientada a Objetos (POO) en C# ");

bool salir = false;

while (!salir)
{
    Console.WriteLine("Seleccionar una Opcción ");

    Console.WriteLine("1. Ejercicio 1");
    Console.WriteLine("2. Ejercicio 2");
    Console.WriteLine("3. Ejercicio 3");
    Console.WriteLine("4. Ejercicio 4");

    Console.WriteLine("5. Ejercicio 5");

    Console.WriteLine("6. Ejercicio 6");
    Console.WriteLine("7. Ejercicio 7");
    Console.WriteLine("8. Ejercicio 8");
    Console.WriteLine("9. Ejercicio 9");

    Console.WriteLine("10. Ejercicio 10");

    Console.WriteLine("");
    Console.WriteLine("Opcción ");
    string opcion = Console.ReadLine();
    switch (opcion)
    {
        case "1":
            Persona person = new Persona();

            person.Nombre = "Isaí Álvarez";
           person.Edad = 29;

          person.Saludar();




            break;
        case "2":
          Persona persona1 = new Persona("Isaí Álvarez", 29);
            persona1.Saludar();

            break;
        case "3":

            Persona person3 = new Persona();

            person3.Nombre = "Isaí Álvarez";
            person3.Edad = -29;

            person3.Saludar();

            break;

        case "4":
            Rectangulo rectangulo = new Rectangulo();
            rectangulo.Base = 5;
            rectangulo.Altura = 10;
            Console.Clear();
            Console.WriteLine("*****Calcular área *****");
            Console.WriteLine($"Área: {rectangulo.CalcularArea()}");

            Console.WriteLine("\n*****Calcular perímetro *****");
            Console.WriteLine($"Perímetro: {rectangulo.CalcularPerimetro()}");
              
            Console.ReadKey();
            Console.Clear();
            break;
        case "5":
           List< Persona> personas = new List<Persona>
            {
                new Persona("Isaí Álvarez", 29),
                new Persona("Juan Pérez", 25),
                new Persona("María López", 30)
            };
            foreach (var p in personas)
            {
                p.Saludar();
            }

            break;

        case "6":
         
            Estudiante estudiante = new Estudiante();
            {
                estudiante.Nombre = "Isaí Álvarez";
                estudiante.Edad = 29;
                estudiante.Matricula = "123456";


                estudiante.MostrarInformacion();
            }
            ;
          
            Console.ReadKey();
            Console.Clear();

            break;
        case "7":
            Console.Clear();
            List<Persona> persona = new List<Persona>();
           persona.Add(new Persona("Juan Perez", 25));
            persona.Add(new Persona("Carolina Martinez", 26));
            persona.Add(new Persona("Pedro Gomez", 27));

            persona.Add(new Estudiante("Carlos Sura",25,"123456"));
            persona.Add(new Estudiante("Ana Torres", 24, "654321"));
            persona.Add(new Estudiante("Vladimir Orellana", 22, "8565654"));

            foreach (var p in persona)
            {
                
                    p.Saludar();
                
            }
            break;

        case "8":
    

         
            break;

        case "9":
            
            break;
        case "10":
           

            break;

      
          
        case "16":
            salir = true;
            break;
        default:
            Console.WriteLine("Opción no válida. Presiona una tecla para volver a intentar...");
            Console.ReadKey(true);
            Console.Clear();
            break;
    }



}
Console.WriteLine("\n Programa finalizado");