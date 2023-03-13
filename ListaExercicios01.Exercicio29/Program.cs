namespace ListaExercicios01.Exercicio29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("\n");
                for (int j = 1; j <= 10; j++)
                {
                    int resultado = i * j;
                    Console.WriteLine($"{i}x{j} = {resultado}");
                }
            }
        }
    }
}