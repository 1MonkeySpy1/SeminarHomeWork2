// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите 3-х значное число");
int n = Convert.ToInt32(Console.ReadLine());

if (n>99 && n<1000) 
{int med = n % 100;
int las = med / 10;
Console.WriteLine(las);}
else {Console.WriteLine("Введите 3-х значное число(ОТ 100 ДО 1000)");}
