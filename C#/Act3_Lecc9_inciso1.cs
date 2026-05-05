internal class Program
{
    private static void Main(string[] args)
    {
        double num, suma = 0;
        Console.WriteLine("Ingrese un numero (0 para terminar): ");
        num = Convert.ToDouble(Console.ReadLine());
        while (num != 0)
        {
            suma = suma + num;
            Console.WriteLine("Suma actual: " + suma);
            Console.Write("Ingrese otro numero: ");
            num = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("Suma final: " + suma);
    }
}