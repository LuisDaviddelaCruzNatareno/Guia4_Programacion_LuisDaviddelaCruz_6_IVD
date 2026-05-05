internal class Program
{
    private static void Main(string[] args)
    {
        double num, i = 1, divisores = 0;
        Console.WriteLine("Ingrese un numero: ");
        num = Convert.ToDouble(Console.ReadLine());
        while (i <= num)
        {
            if (num % i == 0) { divisores = divisores + 1; }
            i = i + 1;
        }
        if (divisores == 2) { Console.WriteLine("Es PRIMO"); }
        else { Console.WriteLine("NO es primo"); }
    }
    }
}