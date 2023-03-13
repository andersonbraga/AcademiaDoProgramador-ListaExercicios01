namespace ListaExercicios01.Exercicio03
{//Crie um programa para calcular o volume de um Cilindro
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a área do raio");
            double raio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a altura");
            double altura = Convert.ToDouble(Console.ReadLine());

            double volume = Math.PI * altura * Math.Pow(raio,2) ;
            double volumeFormatado = Math.Round(volume, 1);

            Console.WriteLine(volumeFormatado);
        }
    }
}