// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите число 1: ");
string userInput1 = Console.ReadLine() ?? "";
int A = int.Parse(userInput1);
Console.Write("Введите число 2: ");
string userInput2 = Console.ReadLine() ?? "";
int B = int.Parse(userInput2);
Console.Write("Введите число 2: ");
string userInput3 = Console.ReadLine() ?? "";
int C = int.Parse(userInput3);
if(A>B)
{
   if(A>C)
   {
    Console.WriteLine(A);
   }
   else
   {
    Console.WriteLine(C);
   }
}
else 
    if(B>C)
    {
    Console.WriteLine(B);
    }
    else
    {
    Console.WriteLine(C);
    }