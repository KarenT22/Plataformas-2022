namespace Condicionales
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Aplicación condicionales");

            int numero;
            Console.WriteLine("Digite un número:");
            numero = int.Parse(Console.ReadLine());

            if (numero < 10)
            {
                Console.WriteLine("El número tiene un dígito");
            }
            else if(numero <= 99)
            {
                Console.WriteLine("El número tiene dos dígitos");
            }
            else
            {
                Console.WriteLine("El número tiene más de dos dígitos");
            }

            Console.ReadKey();


        }


    }
}
