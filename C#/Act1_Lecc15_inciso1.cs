internal class Program
{
    private static void Main(string[] args)
    {
        int num, f = 1;
        Console.Write("Ingrese numero para factorial: ");
        num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            f = f * i;
        }
        Console.WriteLine("El factorial es: " + f);
    }
}