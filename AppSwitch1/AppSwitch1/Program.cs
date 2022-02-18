namespace SwitchEjercicio1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Aplicación sentencia switch");

        int num;

        Console.WriteLine("Digite el número:");
        num = int.Parse(Console.ReadLine());

        switch(num)
        {
            case 1: Console.WriteLine("UNO");
                break;

            case 2:
                Console.WriteLine("DOS");
                break;

            case 3:
                Console.WriteLine("TRES");
                break;

            case 4:
                Console.WriteLine("CUATRO");
                break;

            case 5:
                Console.WriteLine("CINCO");
                break;

            default:
                Console.WriteLine("FUERA DEL RANGO");
                break;
        }

        Console.ReadKey();
    }
}