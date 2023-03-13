namespace ListaExercicios01.Exercicio05
{
    //Crie um programa para calcular o volume de uma esfera
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o raio da esfera: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            double volumeEsfera = 4 * Math.PI * Math.Pow(raio, 3) / 3;

            Console.WriteLine(volumeEsfera);
        }
    }
}