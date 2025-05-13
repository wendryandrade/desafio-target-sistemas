using System.Text.Json;

// Representa um dia de faturamento
public class DiaFaturamento
{
    public int dia { get; set; }
    public double valor { get; set; }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Análise de Faturamento Mensal (JSON)");
        Console.WriteLine("------------------------------------");

        try
        {
            // Caminho do arquivo JSON
            string caminhoArquivo = "dados.json";

            // Lê o conteúdo do arquivo
            string json = File.ReadAllText(caminhoArquivo);

            // Desserializa o conteúdo para lista de objetos
            List<DiaFaturamento> dados = JsonSerializer.Deserialize<List<DiaFaturamento>>(json);

            // Filtra apenas os dias com faturamento maior que 0
            var diasComFaturamento = dados.Where(d => d.valor > 0).ToList();

            // Calcula o menor, maior e a média
            double menor = diasComFaturamento.Min(d => d.valor);
            double maior = diasComFaturamento.Max(d => d.valor);
            double media = diasComFaturamento.Average(d => d.valor);
            int diasAcimaMedia = diasComFaturamento.Count(d => d.valor > media);

            // Exibe os resultados
            Console.WriteLine();
            Console.WriteLine($"Menor faturamento: R$ {menor:F2}");
            Console.WriteLine($"Maior faturamento: R$ {maior:F2}");
            Console.WriteLine($"Média mensal (ignorando 0): R$ {media:F2}");
            Console.WriteLine($"Dias com faturamento acima da média: {diasAcimaMedia}");

            Console.WriteLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao ler ou processar o arquivo JSON: " + ex.Message);
        }

        Console.ReadKey();
    }
}
