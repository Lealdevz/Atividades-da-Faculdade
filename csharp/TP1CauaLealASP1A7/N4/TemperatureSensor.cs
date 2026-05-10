namespace N4;

public class TemperatureSensor
{
    public event Action TemperatureExceeded;

    public void LerTemperatura(decimal temperatura)
    {
        if (temperatura > 100)
        {
            TemperatureExceeded?.Invoke();
        }
    }
}