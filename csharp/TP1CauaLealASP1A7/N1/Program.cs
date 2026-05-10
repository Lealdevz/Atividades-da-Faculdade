namespace N1;

class Program
{
    public delegate decimal CalculeDiscount(decimal valorOriginal);
    
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o valor do produto");
        if (decimal.TryParse(Console.ReadLine(), out var valor))
        {
            CalculeDiscount calculo = Desconto.DezDeDesconto;
            decimal resultado = calculo(valor);
            
            Console.WriteLine("Resultado -> " + resultado);
        }
    }
}