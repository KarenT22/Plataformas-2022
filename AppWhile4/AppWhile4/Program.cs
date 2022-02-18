namespace WhileEjercicio4
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Programa Piezas");

            int piezas, aptas=0, contador;
            float longitud;

            Console.WriteLine("Digite el número de piezas");
            piezas = int.Parse(Console.ReadLine());

            contador = 0;

            while (contador < piezas)
            {
                Console.WriteLine("Digite la longitud de la pieza");
                longitud = float.Parse(Console.ReadLine());

                if(longitud >= 1.2 && longitud <= 1.3)
                {
                    aptas += 1;
                }

                contador ++; 
            }

            Console.WriteLine("Las piezas aptas son:" + aptas);
            Console.ReadKey();


        }
    }
}

  