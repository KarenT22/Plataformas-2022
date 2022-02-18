namespace NotasAlumno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplicación del condicional IF en notas");

            float nota1, nota2, nota3, suma, promedio;

            Console.WriteLine("Digite la primer nota:");
            nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite la segunda nota:");
            nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite la tercera nota:");
            nota3 = float.Parse(Console.ReadLine());

            suma = nota1 + nota2 + nota3;
            promedio = suma / 3;

            if (promedio == 3)
            {
                Console.WriteLine("Su promedio es:" + promedio);
                Console.WriteLine("Aprobado");

            }
            else if (promedio < 3)
            {
                Console.WriteLine("Su promedio es:" + promedio);
                Console.WriteLine("No aprobado");
            }

            else if (promedio >= 4 && promedio <= 4.9)
            {
                Console.WriteLine("Su promedio es:" + promedio);
                Console.WriteLine("Bien");
            }
            else
            {
                Console.WriteLine("Su promedio es:" + promedio);
                Console.WriteLine("Excelente");
            }

            Console.ReadKey();
        }
    }
}