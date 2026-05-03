internal class Program
{
    private static void Main(string[] args)
    {
        double pesoManzana;
        double pesoTotal = 0;
        Console.WriteLine("--- BÁSCULA DE MANZANAS para1kg ---");

        
        while (pesoTotal < 1)
        {
            Console.Write("Coloque una manzana y digite su peso (ej: 0.2): ");
            pesoManzana = Convert.ToDouble(Console.ReadLine());

            pesoTotal = pesoTotal + pesoManzana;

            Console.WriteLine("Peso actual en la báscula: " + pesoTotal + " kg");
        }

        // Formato visual para el resultado final
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\n¡LISTO! Ha completado el kilogramo de manzanas.");
        Console.ResetColor();
    }
}