// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число: ");
string userInput = Console.ReadLine() ?? "";
int N = int.Parse(userInput);
for (int i = 1; i <= N; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($" {i} ");
    }
}