namespace N5;

class Program
{
    static void Main(string[] args)
    {
        DownloadManager dm = new DownloadManager();
        dm.DownloadComplete += Alerta.AlertaDownloadCompleto;

        dm.IniciarDownload();
    }
}