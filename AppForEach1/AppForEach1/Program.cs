namespace EjercicioForEach1
{
    class Program
    {
        static void Main (string [] args)
        {
            Console.WriteLine("Programa Sentencia ForEach");

            int[] sueldos=new int [5];

            for(int contador=0; contador < 5; contador++)
            {
                Console.WriteLine("Ingrese el sueldo:");
                sueldos[contador] = int.Parse(Console.ReadLine());
            }

            /*for (int contador = 0; contador < 5; contador++)
            {
                Console.WriteLine(sueldos[contador]);
            }*/

            foreach (int sueldo in sueldos)
            {
                Console.WriteLine(sueldo);
            }
            Console.WriteLine(sueldos[4]);

            Console.ReadKey();
        }
    }
}
