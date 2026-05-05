internal class Program
{
    private static void Main(string[] args)
    {
        double num, factorial = 1, i;
        Console.Write("Ingrese un numero para factorial: ");
        num = Convert.ToDouble(Console.ReadLine());
        i = num;

        do
        {
            factorial = factorial * i;
            i = i - 1;
        } while (i > 0);

        Console.WriteLine("El factorial es: " + factorial);
    }
}