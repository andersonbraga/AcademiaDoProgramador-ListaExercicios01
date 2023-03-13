namespace ListaExercicios01.Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário base e o total de
            //vendas.A comissão é calculada com um percentual(informado pelo usuário) sobre o total de vendas.
                        
            Console.WriteLine("Informe o salario base do vendedor: ");
            double salarioBase = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o total de vendas realizadas: ");
            double totalVendas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o percentual: ");
            double percentual = Convert.ToDouble(Console.ReadLine());

            double salarioTotal = totalVendas * percentual + salarioBase;
            Console.WriteLine(salarioTotal);
        }
    }
}