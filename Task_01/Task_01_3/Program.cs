// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Напишите число: ");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);
if (num == 6 || num == 7)
{
    Console.WriteLine("выходной");
}
else
{
    Console.WriteLine("не выходной");
}