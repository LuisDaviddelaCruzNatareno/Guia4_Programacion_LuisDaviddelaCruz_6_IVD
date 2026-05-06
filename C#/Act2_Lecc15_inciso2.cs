internal class Program
{
    private static void Main(string[] args)
    {
        double num, suma = 0;
        Console.Write("Ingrese el numero limite: ");
        num = Convert.ToDouble(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            // Verificamos si es múltiplo de 3 o de 5
            if (i % 3 == 0 || i % 5 == 0)
            {
                suma = suma + i;
                Console.WriteLine("Multiplo encontrado: " + i);
            }
        }
        Console.WriteLine("La suma total de los multiplos es: " + suma);
    }
}