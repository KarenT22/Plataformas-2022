namespace WhileEjercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa While valores");

            int num, contador = 0, suma;
            float promedio;

            Console.WriteLine("Digite un número");
            num = (int.Parse(Console.ReadLine()));

            while (contador < num)
            {
                
               
                contador++;
                Console.WriteLine("-" + contador);
            }
            Console.ReadKey();


        }
    }
}