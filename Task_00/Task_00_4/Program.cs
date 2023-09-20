// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Напишите число: ");
string strNum = Console.ReadLine();
int Num = int.Parse(strNum);
for (int i = 2; i <= Num; i+=2)
{
    //if(i%2 == 0)
    Console.WriteLine(i);
}