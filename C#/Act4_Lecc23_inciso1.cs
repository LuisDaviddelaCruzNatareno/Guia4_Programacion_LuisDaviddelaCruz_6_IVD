internal class Program
{
    private static void Main(string[] args)
    {
        double num, mayor, menor;

        Console.Write("Ingrese un numero (negativo para terminar): ");
        num = Convert.ToDouble(Console.ReadLine());

        if (num >= 0)
        {
            mayor = num;
            menor = num;

            while (num >= 0)
            {
                if (num > mayor) { mayor = num; }
                if (num < menor) { menor = num; }

                Console.Write("Ingrese otro numero: ");
                num = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("El numero mayor es: " + mayor);
            Console.WriteLine("El numero menor es: " + menor);
        }
        else
        {
            Console.WriteLine("No se ingresaron numeros validos.");
        }
    }
}