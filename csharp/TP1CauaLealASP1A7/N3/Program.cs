namespace N3;

class Program
{
    static void Main(string[] args)
    {
        double altura;
        double baseRet;
        
        while (true)
        {
            Console.WriteLine("Digite a altura do retangulo: ");
            if (!double.TryParse(Console.ReadLine(), out altura))
            {
                Console.WriteLine("Digite um valor correto");
                continue;
            }
            Console.WriteLine("Digite a base do retangulo: ");
            if (!double.TryParse(Console.ReadLine(), out baseRet))
            {
                Console.WriteLine("Digite um valor correto");
                continue;
            }

            break;
        }

        Func<double, double, double> calcularArea = Calculadora.CalcularAreaRetangulo;
        double resultado = calcularArea(altura, baseRet);
        
        Console.WriteLine($"Area: {resultado}");
    }
}