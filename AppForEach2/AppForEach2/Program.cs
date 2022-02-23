namespace EjercicioForEach2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa Sentencia ForEach Notas");

            float nota;
            int limite, mayores=0, menores=0;

            Console.WriteLine("Ingrese el limite de notas:");
            limite = int.Parse(Console.ReadLine());

            float[] notas=new float [limite];

            for (int contador = 1; contador <= limite; contador++)
            {
                Console.WriteLine("Digite la nota "+contador+":");
                nota = float.Parse(Console.ReadLine());
                notas[contador-1] = nota;
            }

            /*for (int contador = 0; contador < 5; contador++)
            {
                Console.WriteLine(sueldos[contador]);
            }*/

            foreach (float nota2 in notas)
            {
                if (nota2 >= 3)
                {
                    mayores+=1;
                }
                else
                {
                    menores += 1;
                }
                
            }
            Console.WriteLine("Las notas mayores son: " +mayores);
            Console.WriteLine("Las notas menores son: " + menores);

            Console.ReadKey();
        }
    }
}
