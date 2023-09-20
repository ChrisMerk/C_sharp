// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Напишите число1: ");
string strNum1 = Console.ReadLine();
int Num1 = int.Parse(strNum1);
Console.WriteLine("Напишите число2: ");
string strNum2 = Console.ReadLine();
int Num2 = int.Parse(strNum2);
Console.WriteLine("Напишите число3: ");
string strNum3 = Console.ReadLine();
int Num3 = int.Parse(strNum3);
if(Num1>Num2)
{
    if(Num1>Num3)
    {
        Console.WriteLine(Num1);
    }
    else
    {
        Console.WriteLine(Num3);
    }
}
else
{
    if(Num2>Num3)
    {
        Console.WriteLine(Num2);
    }
    else
    {
        Console.WriteLine(Num3);
    }
}