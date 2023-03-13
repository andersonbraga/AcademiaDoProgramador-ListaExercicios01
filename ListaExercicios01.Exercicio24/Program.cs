namespace ListaExercicios01.Exercicio24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 501; i++)
            {
                if (i % 3 == 0)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}