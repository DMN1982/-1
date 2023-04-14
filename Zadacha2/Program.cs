Console.Write("Введите число 1: ");
string userInput1 = Console.ReadLine() ?? "";
int usernumber1 = int.Parse(userInput1);
Console.Write("Введите число 2: ");
string userInput2 = Console.ReadLine() ?? "";
int usernumber2 = int.Parse(userInput2);
if (usernumber1 > usernumber2)
{
    Console.WriteLine(usernumber1);
}
else
{
    Console.WriteLine(usernumber2);
}