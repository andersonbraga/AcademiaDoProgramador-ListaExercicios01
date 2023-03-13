namespace ListaExercicios01.Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor A: ");
            double valorA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o valor B: ");
            double valorB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o valor C: ");
            double valorC = Convert.ToDouble(Console.ReadLine());

            if (valorA + valorB < valorC)
            {
                Console.WriteLine("Valor A+B é menor que C");
            }
            else
            {
                Console.WriteLine("Valor A+B não é menor que C");
            }
        }
    }
}