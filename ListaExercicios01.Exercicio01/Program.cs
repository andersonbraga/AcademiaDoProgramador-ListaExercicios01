namespace ListaExercicios01.Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o valor da altura da caixa: ");
            double altura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura da caixa: ");
            double comprimento = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura da caixa: ");
            double largura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"O volume da caixa retangular é: {altura * comprimento * largura}");

        }
    }
}