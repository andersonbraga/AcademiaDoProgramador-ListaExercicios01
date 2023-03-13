namespace ListaExercicios.Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em Fahrenheit  ");
            double temperaturaF = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"A temperatura em Celsius eh: {(temperaturaF - 32) / 1.8}");
        }
    }
}