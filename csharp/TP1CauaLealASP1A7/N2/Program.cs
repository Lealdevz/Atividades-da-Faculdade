namespace N2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o seu nome: ");
        string nomeUsuario = Console.ReadLine();
        
        Console.WriteLine("Escolha o idioma (padrão pt)");
        Console.WriteLine("1-> Português");
        Console.WriteLine("2-> Espanhol");
        Console.WriteLine("3-> Inglês");
        
        string escolha = Console.ReadLine();
        Action<string> msg;

        switch (escolha)
        {
            case "1":
                msg = BoasVindas.Portugues;
                break;
            case "2":
                msg = BoasVindas.Espanhol;
                break;
            case "3":
                msg = BoasVindas.Ingles;
                break;
            default:
                Console.WriteLine("Escolha Incorreta");
                msg = BoasVindas.Portugues;
                break;
        }
        
        msg(nomeUsuario);
    }
}