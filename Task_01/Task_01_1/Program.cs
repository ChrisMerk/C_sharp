﻿// //Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Напишите число: ");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);
if (num > 99 && num<1000)
{
    Console.WriteLine(num /10%10);
}
else
{
    Console.WriteLine("Число не трехзначное");
}
