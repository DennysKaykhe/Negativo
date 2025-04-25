double numero;

Console.Clear();

Console.Write("Digite um número: ");
numero = Convert.ToDouble(Console.ReadLine());

if (numero > 0)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\nNúmero correto!");
}
else
{
 Console.ForegroundColor = ConsoleColor.Red;
 Console.WriteLine("\nVocê digitou um número negativo");
}

Console.ResetColor();