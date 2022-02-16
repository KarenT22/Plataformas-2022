namespace MayorMenor
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, suma, diferencia, producto, division;

            Console.WriteLine("Programa Mayor o Menor de 2 números");

            Console.WriteLine("Digite un número:");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite otro número:");
            num2 = double.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                suma = num1 + num2;
                diferencia = num1 - num2;

                Console.WriteLine("La suma de los dos número es:" + suma);

                Console.WriteLine("La diferencia de los dos número es:" + diferencia);
            }
            else
            {
                producto = num1 * num2;
                division = num1 / num2;

                Console.WriteLine("El producto de los dos número es:" + producto);

                Console.WriteLine("La división de los dos número es:" + division);
            }


            Console.ReadKey();


        }


    }
}
