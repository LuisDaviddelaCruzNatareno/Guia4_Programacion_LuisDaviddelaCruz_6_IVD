internal class Program
{
    private static void Main(string[] args)
    {
        double num, i = 1;
        Console.WriteLine("Ingrese tabla a mostrar: ");
        num = Convert.ToDouble(Console.ReadLine());
        while (i <= 10)
        {
            Console.WriteLine(num + " x " + i + " = " + (num * i));
            i = i + 1;
        }
        Console.WriteLine("Fin de la tabla.");
    }
}