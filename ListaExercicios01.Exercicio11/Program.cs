namespace ListaExercicios01.Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para verificar se um número é primo.
            Console.WriteLine("Digite o numero para ser verificado ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int verificado = numero % 2 ;

            Console.WriteLine(verificado);
        }
    }
}