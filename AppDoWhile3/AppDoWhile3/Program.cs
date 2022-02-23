namespace EjercicioDoWhile3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, suma = 0, contador = 0;
            
            Console.WriteLine("Programa Valores Acomulados Sentencia Do While");

            do
            {
                Console.WriteLine("Digite un valor:");
                num = int.Parse(Console.ReadLine());
                if (num != 9999)
                {
                    suma += num;
                }
                contador += 1;

            } while (num != 9999);

            if (suma == 0)
            {
                Console.WriteLine("La suma es:" + suma );
            }
            else if (suma<0)
            {
                Console.WriteLine("La suma es menor a 0:" + suma);
            }
            else
            {
                Console.WriteLine("La suma es mayor a 0:" + suma);
            }
                       
            Console.ReadKey();


        }
    }
}
