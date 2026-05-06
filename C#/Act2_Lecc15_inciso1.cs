internal class Program
{
    private static void Main(string[] args)
    {
        double n, suma = 0;
        while (suma < 100)
        {
            Console.WriteLine("Suma actual: " + suma);
            Console.Write("Ingrese un numero: ");
            n = Convert.ToDouble(Console.ReadLine());
            suma = suma + n;
        }
        Console.WriteLine("Meta alcanzada. Suma final: " + suma);
    }
}