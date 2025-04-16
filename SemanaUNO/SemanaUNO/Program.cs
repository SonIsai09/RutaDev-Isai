
using SemanaUNO;

Console.WriteLine("Semana UNO \n Ejercicios Prácticos - Fundamentos de C# y Entorno de Desarrollo ");

bool salir=false;

while (!salir) {
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
    Console.WriteLine("11. Ejercicio 11");

    Console.WriteLine("12. Ejercicio 12");

    Console.WriteLine("13. Ejercicio 13");
    Console.WriteLine("14. Ejercicio 14");
    Console.WriteLine("15. Ejercicio 15");
    Console.WriteLine("16. Salir");
    Console.WriteLine("");
    Console.WriteLine("Opcción ");
    string opcion = Console.ReadLine();


    switch (opcion)
    {
        case "1":
            Ejercicio1 eje1 = new Ejercicio1();

            eje1.Nombre();
            break;
        case "2":
            Ejercicio2 eje2 = new Ejercicio2();

            eje2.Datos();
            break;
        case "3":
            Ejercicio3 eje3 = new Ejercicio3();

            eje3.Operaciones();
            break;

        case "4":
            Ejercicio4 eje4 = new Ejercicio4();

            eje4.EntradaUsuario();
            break;
        case "5":
            Ejercicio5 eje5 = new Ejercicio5();

            eje5.Calculadora();
            break;

        case "6":
            Ejercicio6 eje6 = new Ejercicio6();

            eje6.ParImpart();
            break;
        case "7":
            Ejercicio7 eje7 = new Ejercicio7();

            eje7.PosiNegativCero();
            break;

        case "8":
            Ejercicio8 eje8 = new Ejercicio8();

            eje8.ComparacionNum(); ;
            break;

        case "9":
            Ejercicio9 eje9 = new Ejercicio9();

            eje9.BucleFor(); ;
            break;
        case "10":
            Ejercicio10 eje10 = new Ejercicio10();

            eje10.SumaAcumulada(); ;
            break;

        case "11":
            Ejercicio11 eje11 = new Ejercicio11();

            eje11.TablaMultiplicar(); ;
            break;
        case "12":
            Ejercicio12 eje12 = new Ejercicio12();

            eje12.AdinaNumero(); ;
            break;

        case "13":
            Ejercicio13 eje13 = new Ejercicio13();

            eje13.ValidarEntrada(); ;
            break;

        case "14":
            Ejercicio14 eje14 = new Ejercicio14();

            eje14.CalProm(); ;
            break;

        case "15":
            Ejercicio15 eje15 = new Ejercicio15();

            eje15.Entorno(); ;
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

