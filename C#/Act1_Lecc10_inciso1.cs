internal class Program
{
    private static void Main(string[] args)
    {
        double carros = 200;
        double ingreso;

        do
        {
            Console.WriteLine("Cajones disponibles: " + carros);
            Console.Write("Presione 1 para ingresar auto: ");
            ingreso = Convert.ToDouble(Console.ReadLine());
            carros = carros - 1;
        } while (carros > 0);

        Console.WriteLine("Ya no hay cajones libres");
    }
}