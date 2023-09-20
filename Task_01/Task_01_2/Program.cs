// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("Напишите число: ");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);
if (num > 99)
{
    while (num > 999)
    {
        num /= 10;
    }
    Console.WriteLine(num % 10);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}