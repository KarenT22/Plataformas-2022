namespace EjercicioFor2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, limite, mayores=0, menores=0;

            Console.WriteLine("Programa Sentencia FOR");

            Console.WriteLine("Digite el limite de números:");
            limite = int.Parse(Console.ReadLine());

            for (int contador = 0; contador < limite; contador++)
            {
                Console.WriteLine("Digite un número entero:");
                num = int.Parse(Console.ReadLine());

                if (num >= 1000)
                {
                    mayores+=1;
                }
                else
                {
                    menores+=1;
                }

            }

            Console.WriteLine("Hay " + mayores + " número(s) mayor(es) a 1000");
            Console.WriteLine("Hay " + menores + " número(s) menor(es) a 1000");

            Console.ReadKey();


        }
    }
}