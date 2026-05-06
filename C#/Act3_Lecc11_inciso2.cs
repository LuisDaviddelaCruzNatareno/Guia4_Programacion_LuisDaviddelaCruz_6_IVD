internal class Program
{
    private static void Main(string[] args)
    {
        int num = 0, suma = 0;
        Console.WriteLine("Ingrese numeros para sumar (ingrese 9 para terminar):");

        while (num != 9)
        {
            num = Convert.ToInt32(Console.ReadLine());
            if (num != 9)
            {
                suma += num;
            }
        }
        Console.WriteLine("La suma total es: " + suma);
    }
}