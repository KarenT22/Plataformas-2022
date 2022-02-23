namespace EjercicioForEach2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            float division;
            Console.WriteLine("Programa Manejo de errores");
            Console.WriteLine("Digite número");
            numero = int.Parse(Console.ReadLine());
            try
            {
                division = numero / 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("El error es:"+ex.Message);
            }
            

            
        }
    }
}

