internal class Program
{
    private static void Main(string[] args)
    {
        int suma = 0;
        for (int i = 1; i <= 22; i++)
        {
            int divisores = 0;
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0) divisores++;
            }
            if (divisores == 2) suma += i;
        }
        Console.WriteLine("La suma de los numeros primos del 1 al 22 es: " + suma);
    }
}