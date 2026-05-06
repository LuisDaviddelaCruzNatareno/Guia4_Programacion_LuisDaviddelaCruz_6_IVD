internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Primeros 20 multiplos de 4:");
        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine("4 x " + i + " = " + (i * 4));
        }
    }
}