namespace ListaExercicios01.Exercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor A");
            int valorA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o valor B");
            int valorB = Convert.ToInt32(Console.ReadLine());
            int c;

            if (valorA == valorB)
            {
                c = valorA + valorB;
                Console.WriteLine($"{c}");
            }
            else
            {
                c = valorA * valorB;
                Console.WriteLine($"{c}");
            }
        }
    }
}