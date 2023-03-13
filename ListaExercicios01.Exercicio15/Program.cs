namespace ListaExercicios01.Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Alguns países medem temperaturas em graus Celsius, e outros em graus Fahrenheit.Faça um algoritmo para ler 
            //uma temperatura Celsius e imprima em Fahrenheit(pesquise como fazer este tipo de conversão).

            Console.WriteLine("Digite a temperatura em Celsius: ");
            double temperaturaC = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"A temperatura em Fahrenheit eh: {temperaturaC * 1.8 + 32}");

        }
    }
}