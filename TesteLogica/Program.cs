using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Qual pergunta deseja rodar? (1, 2, 3...)");
        string escolha = Console.ReadLine();

        switch (escolha)
        {
            case "1":
                Pergunta1.Resolver();
                break;
            case "2":
                Pergunta2.Resolver();
                break;
            case "3":
                Pergunta3.Resolver();
                break;
            case "4":
                Pergunta4.Resolver();
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}
