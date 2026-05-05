internal class Program
{
    private static void Main(string[] args)
    {
        double monedas;
        double total = 0;

        Console.WriteLine("**** NIVEL 5 BLOQUEADO ****");

        while (total < 350)
        {
            Console.WriteLine("Monedas actuales: " + total);
            Console.Write("Ingrese monedas ganadas: ");
            monedas = Convert.ToDouble(Console.ReadLine());

            total = total + monedas;
        }
}