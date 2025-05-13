public class Program
{
    public static void Main()
    {
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Percentual de Representação por Estado");
        Console.WriteLine("--------------------------------------");

        // Valores de faturamento por estado
        double faturamentoSP = 67836.43;
        double faturamentoRJ = 36678.66;
        double faturamentoMG = 29229.88;
        double faturamentoES = 27165.48;
        double faturamentoOutros = 19849.53;

        // Soma total do faturamento
        double total = faturamentoSP + faturamentoRJ + faturamentoMG + faturamentoES + faturamentoOutros;

        // Exibe o total
        Console.WriteLine();
        Console.WriteLine($"Total do faturamento mensal: R$ {total:F2}");

        // Cálculo dos percentuais
        double percentualSP = (faturamentoSP / total) * 100;
        double percentualRJ = (faturamentoRJ / total) * 100;
        double percentualMG = (faturamentoMG / total) * 100;
        double percentualES = (faturamentoES / total) * 100;
        double percentualOutros = (faturamentoOutros / total) * 100;

        // Exibe os resultados formatados
        Console.WriteLine();
        Console.WriteLine($"SP:     {percentualSP:F2}%");
        Console.WriteLine($"RJ:     {percentualRJ:F2}%");
        Console.WriteLine($"MG:     {percentualMG:F2}%");
        Console.WriteLine($"ES:     {percentualES:F2}%");
        Console.WriteLine($"Outros: {percentualOutros:F2}%");

        Console.WriteLine();
        Console.ReadKey();
    }
}
