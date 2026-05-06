internal class Program
{
    private static void Main(string[] args)
    {
        int pin, intentos = 1;
        Console.WriteLine("--- CAJERO AUTOMATICO ---");

        do
        {
            Console.Write("Ingrese su PIN (Intento " + intentos + "/3): ");
            pin = Convert.ToInt32(Console.ReadLine());

            if (pin == 1234)
            {
                Console.WriteLine("Acceso concedido. Bienvenido.");
                intentos = 5; // Salida
            }
            else
            {
                Console.WriteLine("PIN incorrecto.");
                intentos++;
            }
        } while (intentos <= 3);

        if (intentos == 4)
        {
            Console.WriteLine("Tarjeta bloqueada por seguridad.");
        }
    }
}