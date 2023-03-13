namespace ListaExercicios01.Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um algoritmo para ler as dimensões de um
            //terreno e depois exibir a área do terreno.

            Console.WriteLine("Insira as dimenoses do terreno 1");
            double dimensao1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira as dimenoses do terreno 2");
            double dimensao2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(dimensao1 * dimensao2);
        }
    }
}