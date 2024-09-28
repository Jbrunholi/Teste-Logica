using System;

public class Pergunta2
{
    public static void Resolver()
    {
        int codigoAluno;
        
        do
        {
            Console.WriteLine("Informe o código do aluno (Digite 0 para sair):");
            codigoAluno = int.Parse(Console.ReadLine());

            if (codigoAluno == 0)
            {
                break;
            }

            Console.WriteLine("Informe a primeira nota:");
            float nota1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Informe a segunda nota:");
            float nota2 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Informe a terceira nota:");
            float nota3 = float.Parse(Console.ReadLine());

            float media = CalcularMediaPonderada(nota1, nota2, nota3);

            Console.WriteLine($"Código do Aluno: {codigoAluno}");
            Console.WriteLine($"Notas: {nota1}, {nota2}, {nota3}");
            Console.WriteLine($"Média Ponderada: {media:F2}");
            
            if (media >= 6)
            {
                Console.WriteLine("Resultado: APROVADO");
            }
            else
            {
                Console.WriteLine("Resultado: REPROVADO");
            }
            Console.WriteLine();  // Linha em branco para separar resultados

        } while (codigoAluno != 0);
    }

    private static float CalcularMediaPonderada(float nota1, float nota2, float nota3)
    {
        float maiorNota = Math.Max(nota1, Math.Max(nota2, nota3));
        
        if (maiorNota == nota1)
        {
            return (nota1 * 4 + nota2 * 3 + nota3 * 3) / 10;
        }
        else if (maiorNota == nota2)
        {
            return (nota2 * 4 + nota1 * 3 + nota3 * 3) / 10;
        }
        else
        {
            return (nota3 * 4 + nota1 * 3 + nota2 * 3) / 10;
        }
    }
}
