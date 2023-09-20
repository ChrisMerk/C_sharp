// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.WriteLine("Напишите число1: ");
string strNum1 = Console.ReadLine();
int Num1 = int.Parse(strNum1);
Console.WriteLine("Напишите число2: ");
string strNum2 = Console.ReadLine();
int Num2 = int.Parse(strNum2);
if(Num1>Num2)
{
    Console.WriteLine($"{Num1} > {Num2}");
}
else
{
    Console.WriteLine($"{Num2} > {Num1}");
}