//       Домашнее задание 1

// Задача 2: Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.

/*

Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"Большее число {num1}, меньшее {num2}");
}
else
{
    Console.WriteLine($"Большее число {num2}, меньшее {num1}");
}

*/


// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

/*

Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num2 < num1)
{
    Console.WriteLine($"Максимальное число {num1}");
}
else if (num3 < num2)
{
    Console.WriteLine($"Максимальное число  {num2}");
}
else
{
    Console.WriteLine($"Максимальное число  {num3}");
}

*/


// Задача 6: Напишите программу, которая на вход принимает число 
// и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num %2 == 0)
{
    Console.WriteLine("Число четное!");
}
else
{
    Console.WriteLine("Число нечетное!");
}

*/


// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

/*

// Console.Write("Input a number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int current = 1;

// while (current <= num)
// {
//     if (current %2 == 0)
//     Console.Write($"{current} ");
//     current++;
// }

*/


//      Домашнее задание 2.
// Task 10. Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.

/*

int Digit(string number)
{
    System.Console.Write(number);
    string input = Console.ReadLine();
    int text = Convert.ToInt32(input);
    return text;
}

int number = Digit("Input a three-digit number: ");
if (number < 100 || number >=1000)
{
    Console.Write("!!! Enter a three-digit number !!!");
    return;
}
Console.Write("Input a three-digit number: ");
int second = number / 10 % 10;
Console.WriteLine($"Second digit {second}");

*/

// Task 13. Напишите программу, которая выводит третью цифру заданного 
// числа ( или -1, если третьей цифры нет).

/*

int Digit(string number)
{
    System.Console.Write(number);
    string input = Console.ReadLine();
    int text = Convert.ToInt32(input);
    return text;
}

int ThirdDigit(int num)
{   
    while (num > 999)
    {
        num /= 10;
    }
    return num % 10;     
}

bool ValidDigit(int num)
{   
    if (num < 100)
    {
        Console.Write("Third digit NO!");
        return false;
    }
    return true;     
}

int num = Digit("Input a number: ");
if (ValidDigit(num))
{
    Console.Write(ThirdDigit(num));
}

*/

// Task 15. Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

/*

int Digit(string number)
{
    System.Console.Write(number);
    string input = Console.ReadLine();
    int text = Convert.ToInt32(input);
    return text;
}

bool Working(int day)
{
    if (day > 0 && day <=7)
    {
        return true;
    }
    Console.Write ("!!! Enter the day of the week !!!");
    return false;
}

bool Weekend(int weekday)
{
    if (weekday > 5)
    {
        return true;
    }
    return false;
}

int weekday = Digit("Enter the day 1 - 7 of the week: ");

if (Working(weekday)) 
    if (Weekend(weekday))
    {
        Console.Write("Weekend! :)");
    }
        
    else 
    {
        Console.Write("Working day :(");
    }

*/




// Task 19. Напишите программу, которая принимает на вход любое число 
// и проверяет, является ли оно палиндромом.




// Task 21. Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.




// Task 23. Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// Math.Pow(5, 3);