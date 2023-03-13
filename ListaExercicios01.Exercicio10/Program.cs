namespace ListaExercicios01.Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno

           
            Console.WriteLine("Informe a nota1 do aluno");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a nota2 do aluno");
            double nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a nota3 do aluno");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            double mediaNotas = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine(mediaNotas);
        }
    }
}