namespace ListaExercicios01.Exercicio26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o numero: ");
            int valorA = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            while (true)
            {
                Console.Write(valorA);
                if (valorA == 1)
                {
                    break;
                }
                Console.Write("*");
                fact *= valorA;
                valorA--;
            }
            Console.WriteLine(" = {0}", fact);
            Console.ReadLine();


        }
    }
}