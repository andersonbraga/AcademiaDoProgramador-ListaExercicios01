namespace ListaExercicios01.Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para calcular a média harmônica das notas de um Aluno
            Console.WriteLine("Informe a nota1 do aluno");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a nota2 do aluno");
            double nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a nota3 do aluno");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            double mediaNotasHarmonicas = 3 / (1 / (nota1 + 1) / (nota2 + 1)/nota3);
            

            Console.WriteLine(mediaNotasHarmonicas);
        }
    }
}