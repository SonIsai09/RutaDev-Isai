
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
    Console.WriteLine("14. Salir");
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
        case "14":
            salir = true;
            break;
        default:
            break;
    }



}
Console.WriteLine("\n Programa finalizado");

