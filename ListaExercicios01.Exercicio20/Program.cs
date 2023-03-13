namespace ListaExercicios01.Exercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um numero ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine($"{numero} é par");
            }
            else
            {
                Console.WriteLine($"{numero} é impar");
            }
        }
    }
}