internal class Program
{
    private static void Main(string[] args)
    {
        double i = 1;
        do
        {
            if (i % 2 != 0)
            {
                Console.WriteLine("Impar: " + i);
            }
            i = i + 1;
        } while (i <= 100);
    }
}
