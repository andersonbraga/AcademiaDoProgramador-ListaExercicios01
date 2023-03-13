namespace ListaExercicios01.Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a cada dia. Cada
            //    pãozinho custa R$ 0,12 e a broa custa R$ 1,50.Ao final do dia, o dono quer saber quanto arrecadou com a
            //venda dos pães e broas(juntos), e quanto deve guardar numa conta de poupança(10 % do total arrecadado).
            //Você foi contratado para fazer os cálculos para o dono. Com base nestes fatos, faça um algoritmo para ler as
            //    quantidades de pães e de broas, e depois calcular os dados solicitados.

            double paoFrances = 0.12;
            double broa = 1.50;
            Console.WriteLine("Digite quantas vendas fez de pao ");
            double vendaPao = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite quantas vendas fez de broa ");
            double vendaBroa = Convert.ToDouble(Console.ReadLine());

            double totalVendas = (paoFrances * vendaPao) + (broa * vendaBroa);
            double poupanca = totalVendas * 0.1;

            Console.WriteLine($"total de vendas {totalVendas} e vai ser depositado na poupança {poupanca}");

        }
    }
}