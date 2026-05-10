namespace N4;

class Program
{
    static void Main(string[] args)
    {
        TemperatureSensor sensor = new TemperatureSensor();
        sensor.TemperatureExceeded += Alerta.AlertaTemperatura100;
        decimal temperatura;
        
        while (true)
        {
            Console.WriteLine("Digite a temperatura");
            if (!decimal.TryParse(Console.ReadLine(), out temperatura))
            {
                Console.WriteLine("Digite um valor correto");
                continue;
            }
            
            sensor.LerTemperatura(temperatura);
        }
    }
}