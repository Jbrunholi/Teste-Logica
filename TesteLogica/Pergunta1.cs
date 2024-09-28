using System;

public class Pergunta1
{
    public static void Resolver()
    {
        int totalCarrosAte2000 = 0;
        int totalGeralCarros = 0;
        string continuar;

        do
        {
            Console.WriteLine("Informe o ano do veículo:");
            int ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor do veículo:");
            decimal valorVeiculo = decimal.Parse(Console.ReadLine());

            decimal desconto = 0;
            if (ano <= 2000)
            {
                desconto = valorVeiculo * 0.12m;
                totalCarrosAte2000++;
            }
            else
            {
                desconto = valorVeiculo * 0.07m;
            }

            decimal valorFinal = valorVeiculo - desconto;

            Console.WriteLine($"Desconto aplicado: {desconto:C}");
            Console.WriteLine($"Valor final a ser pago: {valorFinal:C}");

            totalGeralCarros++;

            Console.WriteLine("Deseja continuar calculando desconto? (S/N)");
            continuar = Console.ReadLine().ToUpper();

        } while (continuar == "S");

        Console.WriteLine($"\nTotal de carros com ano até 2000: {totalCarrosAte2000}");
        Console.WriteLine($"Total de carros processados: {totalGeralCarros}");
    }
}
