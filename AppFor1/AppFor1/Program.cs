namespace EjercicioFor1
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota;
            int  contador2=0, contador3=0;

            Console.WriteLine("Programa sentencia FOR");

            for (int contador1 = 1; contador1 <= 10; contador1++)
            {
                Console.WriteLine("Digite la nota " + contador1 +":");
                nota = float.Parse(Console.ReadLine());

                if (nota == 3 || nota >= 3)
                {
                    contador2++;
                }
                else
                {
                    contador3++;
                }

            }

            Console.WriteLine("El estudiante tiene " + contador2 + " notas mayores o iguales a 3");
            Console.WriteLine("El estudiante tiene " + contador3 + " notas menores a 3");

            Console.ReadKey();


        }
    }
}