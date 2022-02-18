namespace SwitchEjercicio2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Aplicación sentencia switch");

        String num;

        Console.WriteLine("Escriba en texto un número:");
        num = Console.ReadLine();

        switch (num.ToUpper())
        {
            case "UNO":
                Console.WriteLine("1");
                break;

            case "DOS":
                Console.WriteLine("2");
                break;

            case "TRES":
                Console.WriteLine("3");
                break;

            case "CUATRO":
                Console.WriteLine("4");
                break;

            case "CINCO":
                Console.WriteLine("5");
                break;

            default:
                Console.WriteLine("FUERA DEL RANGO");
                break;
        }

        Console.ReadKey();
    }
}
