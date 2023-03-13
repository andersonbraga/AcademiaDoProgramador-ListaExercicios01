namespace ListaExercicios01.Exercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor A: ");
            int valorA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o valor B: ");
            int valorB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o valor C: ");
            int valorC = Convert.ToInt32(Console.ReadLine());

            if (valorA != valorB && valorA != valorC && valorB != valorC && valorB != valorA)
            {
             

                if (valorB > valorC && valorB > valorA)
                {
                    Console.WriteLine($"{valorB} e {valorC} e {valorA}");
                }
                if (valorC > valorA && valorC > valorB)
                {
                    Console.WriteLine($"{valorC} e {valorB} e {valorA}");
                }
                if (valorA > valorB && valorA > valorC && valorB > valorC)
                {
                    Console.WriteLine($"{valorA} e {valorB} e {valorC}");
                }
                if (valorA > valorB && valorA > valorC && valorC > valorB)
                {
                    Console.WriteLine($"{valorA} e {valorC} e {valorB}");
                }

            }


        }
    }
}