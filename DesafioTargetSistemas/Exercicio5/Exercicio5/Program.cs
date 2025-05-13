public class Program
{
    public static void Main()
    {
        Console.WriteLine("------------------");
        Console.WriteLine("Inversão de String");
        Console.WriteLine("------------------");

        Console.WriteLine();

        Console.WriteLine("Digite uma palavra ou frase:");
        string textoOriginal = Console.ReadLine();

        Console.WriteLine();

        string textoInvertido = "";

        // Percorre a string de trás pra frente e monta a string invertida
        for (int i = textoOriginal.Length - 1; i >= 0; i--)
        {
            textoInvertido += textoOriginal[i];
        }

        // Exibe a string original e a invertida
        Console.WriteLine($"Original:  {textoOriginal}");
        Console.WriteLine($"Invertido: {textoInvertido}");
        Console.ReadKey();
    }
}