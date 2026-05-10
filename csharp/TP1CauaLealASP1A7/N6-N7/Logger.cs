namespace N6;

public class Logger
{
    public static void LogToConsole(string msg)
    {
        Console.WriteLine("Console -> " + msg);
    }

    public static void LogToFile(string msg)
    {
        Console.WriteLine("File -> " + msg);
    }
    
    public static void LogToDatabase(string msg)
    {
        Console.WriteLine("Database -> " + msg);
    }
}