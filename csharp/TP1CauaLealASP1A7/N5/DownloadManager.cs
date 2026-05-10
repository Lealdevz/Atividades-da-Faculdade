namespace N5;

public class DownloadManager
{
    public event Action DownloadComplete;

    public void IniciarDownload()
    {
        Console.WriteLine("Iniciando download");
        Thread.Sleep(5000);
        Console.WriteLine("Ta quase la");
        Thread.Sleep(5000);
        
        DownloadComplete?.Invoke();
    }
}