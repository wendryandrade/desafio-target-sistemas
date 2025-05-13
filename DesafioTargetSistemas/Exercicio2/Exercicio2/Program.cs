public class Program
{
    public static void Main()
    {
        int num;

        Console.WriteLine("----------------------");
        Console.WriteLine("Sequência de Fibonacci");
        Console.WriteLine("----------------------");

        // Repetição até o usuário digitar um número válido (inteiro positivo)
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Digite um número inteiro positivo: ");
            string entrada = Console.ReadLine();

            // Tenta converter a entrada em número inteiro
            if (int.TryParse(entrada, out num) && num >= 0)
                break;

            Console.WriteLine("Entrada inválida. Tente novamente.");
        }

        // Mostra a sequência até o número informado
        Console.WriteLine();
        Console.Write("Sequência até o número informado: ");
        int a = 0, b = 1;
        Console.Write($"{a} ");
        while (b <= num)
        {
            Console.Write($"{b} ");
            int temp = b;
            b = a + b;
            a = temp;
        }
        Console.WriteLine();

        // Redefine a e b para verificar se pertence à sequência
        a = 0; b = 1;
        while (b < num)
        {
            int temp = b;
            b = a + b;
            a = temp;
        }

        // Verifica se o número digitado pertence à sequência
        if (b == num || num == 0)
            Console.WriteLine("O número pertence à sequência de Fibonacci.");
        else
            Console.WriteLine("O número NÃO pertence à sequência de Fibonacci.");

        Console.WriteLine();
        Console.ReadKey();
    }
}
