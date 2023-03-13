namespace ListaExercicios01.Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit

            Console.WriteLine("Digite a temperatura em Celsius: ");
            double temperaturaC = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"A temperatura em Fahrenheit eh: {temperaturaC * 1.8 + 32}");

        }
    }
}