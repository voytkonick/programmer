﻿// // Task1. Задача 63: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от 1 до N.

// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

/*

string PrintNumer(int num, string res)
{
    if (num == 1)
    {
        res = '1' + " " + res;
        return res;
    }
    else
    {
        res = num + " " + res;
        return PrintNumer(num - 1, res);
    }
}

string result = "";
Console.Write("Input the number: ");
int number = Convert.ToInt32(Console.ReadLine());
result = PrintNumer(number, result);
Console.WriteLine(result);

*/

// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
//  в промежутке от M до N.

// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

/*

string PrintNumber(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + " " + PrintNumber(start + 1 , end));
}

Console.WriteLine(PrintNumber(2, 15));

*/

/*

void ShowNaturalNumbers(int min, int max, int count=0)

{
    if(min>count) count=min;
    else count++;
        Console.Write(count + " ");
    if(count<max)
    {
        ShowNaturalNumbers(min, max, count);    
    }
}

Console.Write("Input a min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max: ");
int max = Convert.ToInt32(Console.ReadLine());
ShowNaturalNumbers(min, max);

*/


// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму 
// его цифр.

// 453 -> 12
// 45 -> 9

/*

int SumDigits(int number)
{
    if(number == 0)
        return 0;
    else
        return number % 10 + SumDigits(number / 10);
}

Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumDigits(number));

*/


// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит 
// число А в целую степень B с помощью рекурсии.

// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

/*

int PowerAB(int a, int b)
{
    if(b == 0)
        return 1;
    return a * PowerAB(a, b - 1);
}

Console.WriteLine(PowerAB(3,5));

*/