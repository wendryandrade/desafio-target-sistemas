public class Program
{
    public static void Main()
    {
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Cálculo de Soma utilizando WHILE");
        Console.WriteLine("--------------------------------");

        int indice = 13, soma = 0, k = 0;

        // Repetição que soma os números de 1 até o valor de "indice"
        while (k < indice)
        {
            k = k + 1;
            soma = soma + k;
        }

        Console.WriteLine();
        Console.WriteLine("Valor final da variável soma: " + soma);
        Console.ReadKey();
    }
}
