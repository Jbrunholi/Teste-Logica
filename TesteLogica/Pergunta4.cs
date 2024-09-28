public class Pergunta4
{
    public static void Resolver()
    {
        DateTime dataVencimentoOriginal;
        DateTime dataVencimentoNova;
        double valorBoleto;

        Console.WriteLine("Informe a data de vencimento original (dd/MM/yyyy):");
        dataVencimentoOriginal = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

        Console.WriteLine("Informe a data de vencimento nova (pagamento) (dd/MM/yyyy):");
        dataVencimentoNova = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

        Console.WriteLine("Informe o valor do boleto:");
        valorBoleto = Convert.ToDouble(Console.ReadLine());

        double valorTotalJuros = 0;
        double valorTotalMulta = 0;

        // Cálculo dos juros e multas
        if (VerificaFinalDeSemana(dataVencimentoOriginal) || VerificaFeriado(dataVencimentoOriginal))
        {
            if (dataVencimentoNova > dataVencimentoOriginal.AddDays(1)) // Pagamento após dia útil
            {
                int diasJuros = (dataVencimentoNova - dataVencimentoOriginal).Days;
                valorTotalJuros = diasJuros * 0.03;
                valorTotalMulta = 2.00;
            }
        }
        else if (dataVencimentoNova == dataVencimentoOriginal)
        {
            valorTotalJuros = 0;
            valorTotalMulta = 0;
        }
        else if (dataVencimentoNova < dataVencimentoOriginal)
        {
            valorTotalJuros = 0;
            valorTotalMulta = 0;
        }
        else
        {
            if (dataVencimentoNova == dataVencimentoOriginal.AddDays(1))
            {
                valorTotalJuros = 0.03;
                valorTotalMulta = 2.00;
            }
        }

        double valorBoletoRecalculado = valorBoleto + valorTotalJuros + valorTotalMulta;

        Console.WriteLine($"Valor do Boleto Recalculado: R$ {valorBoletoRecalculado:F2}");
        Console.WriteLine($"Valor Total de Juros: R$ {valorTotalJuros:F2}");
        Console.WriteLine($"Valor Total de Multa: R$ {valorTotalMulta:F2}");
    }

    static bool VerificaFinalDeSemana(DateTime data)
    {
        return data.DayOfWeek == DayOfWeek.Saturday || data.DayOfWeek == DayOfWeek.Sunday;
    }

    static bool VerificaFeriado(DateTime data)
    {
        return data.Month == 1 && data.Day == 1; // Exemplo: 1º de janeiro como feriado
    }
}