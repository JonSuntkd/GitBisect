int opcion;
int num;
bool salir = false;

do
{
    Console.Clear();
    Console.WriteLine("\n\n --------ELIGE LA OPCION------\n");
    Console.WriteLine("1.Factorial");
    Console.WriteLine("2.Numeros pares");

    Console.WriteLine("3.Salir");
    Console.Write("\n Elija la opcion que desee:  ");
    opcion = Convert.ToInt32(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("\n\n\t FACTORIAL ");
            Console.WriteLine("Calculo del Factorial de un número entero positivo\n");
            do
            {
                Console.Write("Por favor Digite un número entero positivo: ");
                num = int.Parse(Console.ReadLine());
                verificar(num);
            } while (num < 0);
            factorial(num);
            Console.WriteLine("\n\n\t Presione cualquier tecla para volver al menu");
            Console.ReadKey();
            break;
        case 2:
            Console.Clear();
            Console.WriteLine("\n\t\t Numeros pares ");
            do
            {
                Console.Write("Por favor Digite un número entero positivo: ");
                num = int.Parse(Console.ReadLine());

            } while (num < 0);
            for (int i = 0; i < num; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("\n\t Numero par: " + i);
                }
            }
            Console.WriteLine("\n\n\t Presione cualquier tecla para volver al menu");
            Console.ReadKey();
            break;
        case 3:
            Console.Clear();
            Console.WriteLine("Salir de la aplicacion");
            salir = true;
            break;
        default:
            Console.WriteLine("Opcion invalida, elige una opcion entre 1 y 5");
            Console.WriteLine("\n\n\t Presione cualquier tecla para volver al menu");
            Console.ReadKey();
            break;
    }
} while (!salir);


static void verificar(int n)
{
    if (n < 0)
    {
        Console.Write("\nError: No existe el factorial de un número negativo...\n");
    }
}
static void factorial(int n)
{
    int fact = 1;
    for (int i = 1; i <= n; i++)
    {
        fact *= i;
    }
    Console.WriteLine("\nEl Factorial de " + n + " es: " + fact);
}

