namespace ListaExercicios01.Exercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o peso ");
            float peso = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira o altura ");
            float altura = float.Parse(Console.ReadLine());
            float imc = peso / (altura * altura) * 10000;

            if (imc < 18.5)
            {
                Console.WriteLine($"Abaixo do peso {imc}");
            }
            if (imc > 18.5 && imc < 26)
            {
                Console.WriteLine($"Peso normal {imc}");
            }
            if (imc > 30)
            {
                Console.WriteLine($"Obeso {imc}");
            }

        }

            
    }
}