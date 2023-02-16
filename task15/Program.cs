// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Input number");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 0 && n <= 7) 
{
    if ( n == 1) {Console.WriteLine("Mondey");}
    else if (n == 2) {Console.WriteLine("Tuesday");}
    else if (n == 3) {Console.WriteLine("Wednesday");}
    else if (n == 4) {Console.WriteLine("Thursday");}
    else if (n == 5) {Console.WriteLine("Friday");}
    else if (n == 6) {Console.WriteLine("Saturday");}
    else if (n == 7) {Console.WriteLine("Sunday");}
    if (n == 6 || n == 7) {Console.WriteLine("Выходной");}
    else {Console.WriteLine("Будний день");}
}
else {Console.WriteLine("NO this weekday");}