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

int Digit(int num)
{
    int dozens = num / 10;
    int second = dozens % 10;
    return second;
}
Console.Write("Input a three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

int second = Digit(num);
Console.WriteLine("Second digit " + second);

*/

// Task 13. Напишите программу, которая выводит третью цифру заданного 
// числа ( или -1, если третьей цифры нет).


int ThirdDigit(int num)
{   
    int hunders = num / 1000;
        return hunders;     
}
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int third = ThirdDigit(num);
Console.Write($"Third digit of {num} is {third}");



// Task 15. Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

/*

bool Weekend(int day)
{
    return day >= 1 && day <= 5;
}
Console.Write("Input a number from 1 to 7: ");
int day = Convert.ToInt32(Console.ReadLine());

bool res = Weekend(day);

if (res) Console.Write("Working day :(");
else Console.Write("Weekend! :)");

*/


// Task 19. Любое число на вход.

// Task 21.

// Task 23. Math.Pow(5, 3);