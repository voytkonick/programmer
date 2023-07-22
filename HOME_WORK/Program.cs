    // Домашнее задание 1

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


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



// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


// Console.Write("Input a first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a third number: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// if (num2 < num1)
// {
//     Console.WriteLine($"Максимальное число {num1}");
// }
// else if (num3 < num2)
// {
//     Console.WriteLine($"Максимальное число  {num2}");
// }
// else
// {
//     Console.WriteLine($"Максимальное число  {num3}");
// }



// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).


// Console.Write("Input a number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num %2 == 0)
// {
//     Console.WriteLine("Число четное!");
// }
// else
// {
//     Console.WriteLine("Число нечетное!");
// }


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// Console.Write("Input a number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int current = 1;

// while (current <= num)
// {
//     if (current %2 == 0)
//     Console.Write($"{current} ");
//     current++;
// }

