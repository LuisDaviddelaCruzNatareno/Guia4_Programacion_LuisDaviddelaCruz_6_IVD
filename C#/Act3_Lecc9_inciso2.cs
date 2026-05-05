internal class Program
{
    private static void Main(string[] args)
    {
        double num, contador = 20;
        Console.WriteLine("Ingrese el numero limite: ");
        num = Convert.ToDouble(Console.ReadLine());
        while (contador <= num)
        {
            if (contador % 2 != 0) { Console.WriteLine("Impar: " + contador); }
            contador = contador + 1;
        }
    }
}