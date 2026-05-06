internal class Program
{
    private static void Main(string[] args)
    {
        int n1, n2, suma = 0;
        Console.Write("Ingrese primer numero: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese segundo numero: ");
        n2 = Convert.ToInt32(Console.ReadLine());

        if (n1 > n2)
        {
            int aux = n1; n1 = n2; n2 = aux;
        }

        for (int i = n1; i <= n2; i++)
        {
            suma += i;
        }
        Console.WriteLine("La suma de los valores entre ambos es: " + suma);
    }
}