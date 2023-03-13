namespace ListaExercicios01.Exercicio04
{
    //Crie um programa para calcular o consumo de combustível por Km. Deverá ser informado a quilometragem
    //Inicial e Final do Percurso do Veículo.Deverá ser informado o Consumo de Combustível

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o km inicial: ");
            double kmInicial = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o km final: ");
            double kmFinal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o consumo de combustivel: ");
            double consumoCombustivel = Convert.ToDouble(Console.ReadLine());

            double consumoCombustivelKm = (kmFinal - kmInicial) / consumoCombustivel;

            Console.WriteLine($"O consumo por KM eh: {consumoCombustivelKm}");


        }
    }
}