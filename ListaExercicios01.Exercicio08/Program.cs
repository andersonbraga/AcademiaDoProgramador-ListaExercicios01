namespace ListaExercicios01.Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para calcular o volume de uma lata de óleo

            Console.WriteLine("Informe o raio ");
            double raio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a altura ");
            double altura = Convert.ToDouble(Console.ReadLine());
            double volume = Math.PI * Math.Pow(raio, 2) * altura;

            Console.WriteLine(volume);
        }
    }
}