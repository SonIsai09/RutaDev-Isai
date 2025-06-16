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
    Console.WriteLine("8. Ejercicio 8 y Ejercicio 9");


    Console.WriteLine("10. Ejercicio 10");

    Console.WriteLine("x. Salir");

    Console.WriteLine("");
    Console.WriteLine("Opcción ");
    string opcion = Console.ReadLine();
    switch (opcion)
    {
        case "1":
            Console.Clear();
            Persona person = new Persona();

            person.Nombre = "Isaí Álvarez";
            person.Edad = 29;

            person.Saludar();
            Console.ReadKey();
            Console.Clear();


            break;
        case "2":
            Console.Clear();
            Persona persona1 = new Persona("Isaí Álvarez", 29);
            persona1.Saludar();
            Console.ReadKey();
            Console.Clear();

            break;
        case "3":
            Console.Clear();
            Persona person3 = new Persona();

            person3.Nombre = "Isaí Álvarez";
            person3.Edad = -29;

            person3.Saludar();
            Console.ReadKey();
            Console.Clear();
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
            Console.Clear();
            List<Persona> personas = new List<Persona>
            {
                new Persona("Isaí Álvarez", 29),
                new Persona("Juan Pérez", 25),
                new Persona("María López", 30)
            };
            foreach (var p in personas)
            {
                p.Saludar();
            }
            Console.ReadKey();
            Console.Clear();
            break;

        case "6":
            Console.Clear();
            Estudiante estudiante = new Estudiante();
            {
                estudiante.Nombre = "Isaí Álvarez";
                estudiante.Edad = 29;
                estudiante.Matricula = "123456";


                estudiante.Saludar();
            }
            ;

            Console.ReadKey();
            Console.Clear();

            break;
        case "7":
            Console.Clear();
            List<Persona> persona = new List<Persona>() {
            new Persona("Juan Perez", 25),
           new Persona("Carolina Martinez", 26),
           new Persona("Pedro Gomez", 27),



          new Estudiante("Carlos Sura", 25, "123456"),
          new Estudiante("Ana Torres", 24, "654321"),
          new Estudiante("Vladimir Orellana", 22, "8565654") ,


            };



            Console.WriteLine("*** Lista de Personas ***");
            foreach (var per in persona)
            {
                Console.WriteLine("---------------------------------------------");
                per.Saludar();
                Console.WriteLine("---------------------------------------------");
            }
            Console.ReadKey();
            Console.Clear();
            break;

        case "8":
            Console.Clear();

            Calculadora calculadora = new Calculadora();
            Console.Write("Ingrese el primer numero: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Signo de operación '+','-','*','/': ");
            string operacion = Console.ReadLine();



            Console.Write("Ingrese el segundo numero: ");


            double numero2 = Convert.ToDouble(Console.ReadLine());



            double resultado = 0;
            switch (operacion)
            {
                case "+":
                    resultado = calculadora.sumar(numero1, numero2);
                    Console.WriteLine($"Resultado de la suma: {resultado}");
                    break;
                case "-":
                    resultado = calculadora.restar(numero1, numero2);
                    Console.WriteLine($"Resultado de la resta: {resultado}");
                    break;
                case "*":
                    resultado = calculadora.multiplicar(numero1, numero2);
                    Console.WriteLine($"Resultado de la multiplicación: {resultado}");
                    break;
                case "/":
                    try
                    {
                        resultado = calculadora.dividir(numero1, numero2);
                        Console.WriteLine($"Resultado de la división: {resultado}");
                    }


                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine("Erro:  " + ex.Message);
                    }


                    break;
                default:
                    Console.WriteLine("Operación no válida.");
                    break;
            }
            Console.ReadKey();
            Console.Clear();

            break;


        case "10":

            Console.Clear();
            Persona[] pers = new Persona[3];

            pers[0] = new Persona("Isaí Álvarez", 29);
            pers[1] = new Persona("Juan Pérez", 25);
            pers[2] = new Persona("María López", 30);

            foreach (var p in pers)
            {

                p.Saludar();

            }
            Console.ReadKey();
            Console.Clear();


            break;



        case "x":
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