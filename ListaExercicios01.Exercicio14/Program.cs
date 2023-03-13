namespace ListaExercicios01.Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir quantos dias de vida ela possui.
            //Considere sempre anos completos, e que um ano possui 365 dias.Ex: uma pessoa com 19 anos possui 6935 dias
            //de vida; veja um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS.

            Console.WriteLine("Insira seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Insira sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{nome} voce ja viveu {idade * 365}");
        }
    }
}