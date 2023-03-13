namespace ListaExercicios01.Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%. Após o aumento, desconte 8% de
            // impostos.Imprima o salário inicial, o salário com o aumento e o salário final.


            Console.WriteLine("Insira o salario do funcionario: ");
            double salarioInicial = Convert.ToDouble(Console.ReadLine());
            double salarioComAumento = salarioInicial * 0.15 + salarioInicial;
            double salarioFinal = salarioComAumento * 0.08 - salarioComAumento;
            Console.WriteLine($" Salario Inicial {salarioInicial} \n Salario com Aumento {salarioComAumento} \n Salario Final {salarioFinal}");

        }
    }
}