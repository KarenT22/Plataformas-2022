namespace EjercicioDoWhile2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, suma=0, contador=0;
            float promedio;

            Console.WriteLine("Programa Promedio Sentencia Do While");

            do
            {
                Console.WriteLine("Digite un número:");
                num = int.Parse(Console.ReadLine());
                suma +=num;
                contador +=1;

            } while (num != 0);
            promedio = suma / (contador-1);
            Console.WriteLine("La suma de los número ingresados es:" + suma);
            Console.WriteLine("El promedio de los número ingresados es:" + promedio);
            Console.ReadKey();


        }
    }
}
