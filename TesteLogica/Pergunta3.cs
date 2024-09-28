using System;

public class Pergunta3
{
    public static void Resolver()
    {
        string opcao = "";

        while (opcao != "0")
        {
            Console.WriteLine("Escolha a opção (A, B, C, D, E) para ver a análise ou digite 0 para sair:");
            opcao = Console.ReadLine().ToUpper();

            switch (opcao)
            {
                case "A":
                    Console.WriteLine("A) a=1, b=2, c=3");
                    Console.WriteLine("Passo 1: Verificar se é um triângulo:");
                    Console.WriteLine("1 < 2 + 3 -> 1 < 5 -> Verdadeiro");
                    Console.WriteLine("2 < 1 + 3 -> 2 < 4 -> Verdadeiro");
                    Console.WriteLine("3 < 1 + 2 -> 3 < 3 -> Falso");
                    Console.WriteLine("Resultado: Não é possível formar um triângulo.");
                    break;

                case "B":
                    Console.WriteLine("B) a=3, b=4, c=5");
                    Console.WriteLine("Passo 1: Verificar se é um triângulo:");
                    Console.WriteLine("3 < 4 + 5 -> 3 < 9 -> Verdadeiro");
                    Console.WriteLine("4 < 3 + 5 -> 4 < 8 -> Verdadeiro");
                    Console.WriteLine("5 < 3 + 4 -> 5 < 7 -> Verdadeiro");
                    Console.WriteLine("Passo 2: Verificar o tipo de triângulo:");
                    Console.WriteLine("Todos os lados são diferentes 3 ≠ 4 ≠ 5");
                    Console.WriteLine("Resultado: Triângulo Escaleno.");
                    break;

                case "C":
                    Console.WriteLine("C) a=2, b=2, c=4");
                    Console.WriteLine("Passo 1: Verificar se é um triângulo:");
                    Console.WriteLine("2 < 2 + 4 -> 2 < 6 -> Verdadeiro");
                    Console.WriteLine("2 < 2 + 4 -> 2 < 6 -> Verdadeiro");
                    Console.WriteLine("4 < 2 + 2 -> 4 < 4 -> Falso");
                    Console.WriteLine("Resultado: Não é possível formar um triângulo.");
                    break;

                case "D":
                    Console.WriteLine("D) a=4, b=4, c=4");
                    Console.WriteLine("Passo 1: Verificar se é um triângulo:");
                    Console.WriteLine("4 < 4 + 4 -> 4 < 8 -> Verdadeiro");
                    Console.WriteLine("4 < 4 + 4 -> 4 < 8 -> Verdadeiro");
                    Console.WriteLine("4 < 4 + 4 -> 4 < 8 -> Verdadeiro");
                    Console.WriteLine("Passo 2: Verificar o tipo de triângulo:");
                    Console.WriteLine("Todos os lados são iguais 4 = 4 = 4");
                    Console.WriteLine("Resultado: Triângulo Equilátero.");
                    break;

                case "E":
                    Console.WriteLine("E) a=5, b=3, c=3");
                    Console.WriteLine("Passo 1: Verificar se é um triângulo:");
                    Console.WriteLine("5 < 3 + 3 -> 5 < 6 -> Verdadeiro");
                    Console.WriteLine("3 < 5 + 3 -> 3 < 8 -> Verdadeiro");
                    Console.WriteLine("3 < 5 + 3 -> 3 < 8 -> Verdadeiro");
                    Console.WriteLine("Passo 2: Verificar o tipo de triângulo:");
                    Console.WriteLine("Dois lados são iguais (b = c), mas a é diferente.");
                    Console.WriteLine("Resultado: Triângulo Isósceles.");
                    break;

                case "0":
                    Console.WriteLine("Encerrando o programa.");
                    break;

                default:
                    Console.WriteLine("Opção inválida. Escolha entre A, B, C, D, E ou 0 para sair.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
