namespace N6;

class Program
{
    static void Main(string[] args)
    {
        Action<string> log = null;

        log += Logger.LogToConsole;
        log += Logger.LogToFile;
        log += Logger.LogToDatabase;

        Console.WriteLine("Digite o log");
        string logMsg =  Console.ReadLine();
        log?.Invoke(logMsg);
    }
}