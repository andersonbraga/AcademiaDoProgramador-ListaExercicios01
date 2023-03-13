namespace ListaExercicios01.Exercicio27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um valor");
            int valorA = Convert.ToInt32(Console.ReadLine());

            int a = 1;
            int b = 0;
            int c;

            for (int i = 1; i < valorA ; i++)
            {
                Console.WriteLine($"{b}");
                c = a;
                a = b;
                b += c;


            }
        }
    }
}