namespace ListaExercicios01.Exercicio25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insira um valor ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"\n{n}X{i}={n*i}");
            }
        }
    }
}