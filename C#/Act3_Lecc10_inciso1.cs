internal class Program
{
    private static void Main(string[] args)
    {
        int divisores, suma_primos = 0;

        for (int num = 1; num <= 22; num++)
        {
            divisores = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    divisores = divisores + 1;
                }
            }

            if (divisores == 2)
            {
                Console.WriteLine("Primo encontrado: " + num);
                suma_primos = suma_primos + num;
            }
        }

        Console.WriteLine("La suma total es: " + suma_primos);
    }
}