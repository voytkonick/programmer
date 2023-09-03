        // _____________________________Домашнее задание 1.___________________________________

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

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int current = 1;

while (current <= num)
{
    if (current %2 == 0)
    Console.Write($"{current} ");
    current++;
}

*/


        // ___________________________Домашнее задание 2.______________________________

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



        // _________________________Домашнее задание 3._________________________________

// Task 19. Напишите программу, которая принимает на вход любое число 
// и проверяет, является ли оно палиндромом.

// Не вышло у меня добить синтаксис, есть сложности с этой задачей.
/*

int Revers(int n);
    int temp = n;
    int rev = 0;
    while(n > 0)
{
        int dig = n % 10;
        rev = rev * 10 + dig;
        n = n / 10;
}
    if(temp == rev)
{
        Console.WriteLine("Number is palindrome!");
}
    else
{
        Console.WriteLine("Number is not palindrome!");
}

Console.Write("Enter a number: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write(Revers(n));
*/

// Task 21. Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.

/*

double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double deltaX = x2 - x1;
    double deltaY = y2 - y1;
    double deltaZ = z2 - z1;

    return Math.Round(Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ), 2);
}
Console.Write("Input x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Distance (x1, y1, z1, x2, y2, z2));

*/


// Task 23. Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// Math.Pow(5, 3);

/*

void WriteCube(int number)
{
    int current = 1;
    while (current <= number)
    {
        Console.WriteLine($"{current} - {Math.Pow(current, 3)}");
        current++;
    }
}
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

WriteCube(number);

*/



// ___________________Домашняя работа 4.______________________

// 25. Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// Придумать свой метод. Метод Math.Pow только для проверки.

/*

int Prompt(string message)         // в очередной раз не понимаю почему в примерах решения есть этот блок, а на семинарах мы его не практикуем.         
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int Degree(int number1, int number2)
{
    int work = 1;
    for (int i = 0; i < number2; i++)
    {
        work *= number1;
    }
    return work;
}

bool RealFactor(int number2)
{
    if (number2 < 0)
    {
        System.Console.Write("enter a number greater than zero!");
        return false;
    }
    return true;
}   

int number1 = Prompt("input a number1: ");
int number2 = Prompt("input a number2: ");
System.Console.Write($"{number1} to the extent {number2} = {Degree(number1, number2)}");

*/


// 27.Напишите программу, которая принимает на вход число и выдаёт 
// сумму цифр в числе.

/*

int Prompt(string message)          
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int Summa(int number)
{
    int result = 0;
    while (number > 0)          // или можно for (;number > 0;)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}
int number = Prompt("input a number: ");
System.Console.Write($"summa all numbers {number} = {Summa(number)}");

*/


// 29. Напишите программу, которая задаёт массив из m элементов 
// и выводит их на экран.
// Ввод элементов пользователем.

/*

int[] CreateArray(int size)
{
    int[] array = new int[size]; 
    for(int i =0; i < size; i++)  
    {
        Console.Write($"Input a {i} value of an array: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

void WriteArray(int[] array)   
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");   
}

Console.Write("Input a length of an array: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(length);
WriteArray(myArray);

*/






// ____________________________ Домашняя работа 5 ________________________________

// 34. Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

/*

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(99,1000);

    return array;
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int NumberOfEven(int[] array)
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            quantity += 1;

    return quantity;         
}

Console.Write("Enter a length of an array: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length);
WriteArray(myArray);

Console.WriteLine(NumberOfEven(myArray));

*/




// 36. Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

/*

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int SummOfOdd(int[] array)
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 != 0)
            quantity = quantity + array[i];

    return quantity;         
}

Console.Write("Enter a length of an array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, minValue, maxValue);
WriteArray(myArray);

Console.WriteLine(SummOfOdd(myArray));

*/


// 38. Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// double


/*
Console.Write("Enter a length of an array: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];

void CreateRandomArray(int size)
{
    Random MyArray = new Random();
    for(int i = 0; i < size; i++)
    {
        array[i] = MyArray.NextDouble();
        Console.Write($"{array[i]:F2} ");  //выводим массив с округлением до двух знаков
    }  
    Console.WriteLine();   
}


CreateRandomArray(size); //выводим массив на консоль

double Difference(double[] array)
{
    double min = array[0];
    double max = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(max < array[i])   //определяем максимальный элемент в массиве
            max = array[i];
        if(min > array[i])   //определяем минимальный элемент в массиве
            min = array[i];
    }
    return max - min;   //выводим их разность
}

Console.WriteLine($"Difference between maximum and minimum: {Difference(array):F2}");

*/





// ____________________________ Домашняя работа 6 ________________________________

// Задача 41.
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввел пользователь.

/*

Console.Write("Enter the number of element of the array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[size];

void Arr(int size)
{
    for (int i = 0; i < size; i++)
    {
    Console.WriteLine($"Enter {i+1} element an array: ");
        Array[i] = Convert.ToInt32(Console.ReadLine());
    }

}

int CountNumber(int[] Array)
{
    int i = 0;
    int count = 0;
    while (i < Array.Length)
    {
        if(Array[i]>0)
        count++;
        i++;
    }
    return count;
}

Arr(size);
Console.Write($"More than zero: {CountNumber(Array)}");

*/

// Задача 43.
// Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями 
// y = k1*x +b1, y = k2*x +b2, значения b1, k1, b2 и k2 задаются пользователем.

/*

Console.WriteLine("Input value b1:");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input value k1:");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input value b2:");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input value k2:");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"Two straight lines will intersect at the coordinates X: {x}, Y: {y}");

*/

// Задача *. Написать программу, преобразующую число из десятеричной системы счисления 
// в двоичную.
// либо string, либо array

/*

using System;

namespace DecimalToBinaryConverterArray
{
    class Program
    {
        static int[] DecimalToBinary(int decimalNumber)
        {
            if (decimalNumber == 0)
                return new int[] { 0 };

            int[] binaryArray = new int[32]; // Максимальная длина двоичного числа для int
            int index = 0;

            while (decimalNumber > 0)
            {
                binaryArray[index++] = decimalNumber % 2;
                decimalNumber /= 2;
            }

            Array.Reverse(binaryArray, 0, index); // Переворачиваем массив, чтобы получить правильный порядок

            return binaryArray;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите десятичное число: ");
            int decimalNumber = int.Parse(Console.ReadLine());

            int[] binaryArray = DecimalToBinary(decimalNumber);
            Console.Write("Двоичное представление: ");
            foreach (int bit in binaryArray)
            {
                Console.Write(bit);
            }
        }
    }
}

*/



// ____________________________ Домашняя работа 7 ________________________________


// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// double

/*

using System;

namespace RandomMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк (m): ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов (n): ");
            int n = int.Parse(Console.ReadLine());

            // Создайте генератор случайных чисел
            Random random = new Random();

            // Создайте двумерный массив
            double[,] matrix = new double[m, n];

            // Заполните массив случайными вещественными числами
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    double randomNumber = random.NextDouble();
                    matrix[i, j] = randomNumber;
                }
            }

            // Выведите массив на экран (для демонстрации)
            Console.WriteLine("Случайно заполненный двумерный массив:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

*/


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

/*
using System;

namespace ArrayElementLookup
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк (m): ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов (n): ");
            int n = int.Parse(Console.ReadLine());

            double[,] matrix = new double[m, n];

            // Заполнение массива, например, случайными числами
            Random random = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = random.NextDouble();
                }
            }

            Console.Write("Введите индекс строки элемента: ");
            int rowIndex = int.Parse(Console.ReadLine());

            Console.Write("Введите индекс столбца элемента: ");
            int columnIndex = int.Parse(Console.ReadLine());

            double elementValue = GetArrayElement(matrix, rowIndex, columnIndex);

            if (elementValue != double.MinValue)
            {
                Console.WriteLine($"Значение элемента [{rowIndex}, {columnIndex}]: {elementValue}");
            }
            else
            {
                Console.WriteLine("Элемент с такими координатами не существует.");
            }
        }

        static double GetArrayElement(double[,] array, int rowIndex, int columnIndex)
        {
            int rowCount = array.GetLength(0);
            int columnCount = array.GetLength(1);

            if (rowIndex >= 0 && rowIndex < rowCount && columnIndex >= 0 && columnIndex < columnCount)
            {
                return array[rowIndex, columnIndex];
            }
            else
            {
                return double.MinValue; // Специальное значение для обозначения отсутствия элемента
            }
        }
    }
}

*/


// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

/*

using System;

namespace ColumnAverages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            int rowCount = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов: ");
            int columnCount = int.Parse(Console.ReadLine());

            Console.Write("Введите минимальное значение: ");
            int minValue = int.Parse(Console.ReadLine());

            Console.Write("Введите максимальное значение: ");
            int maxValue = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rowCount, columnCount];

            Random random = new Random();

            // Заполнение массива случайными значениями в заданном диапазоне
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    matrix[i, j] = random.Next(minValue, maxValue + 1);
                }
            }

            double[] columnAverages = new double[columnCount];

            // Вычисление средних арифметических для каждого столбца
            for (int j = 0; j < columnCount; j++)
            {
                int columnSum = 0;
                for (int i = 0; i < rowCount; i++)
                {
                    columnSum += matrix[i, j];
                }
                columnAverages[j] = (double)columnSum / rowCount;
            }

            // Вывод результатов
            Console.WriteLine("Массив:");
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Средние арифметические для каждого столбца:");
            for (int j = 0; j < columnCount; j++)
            {
                Console.WriteLine($"Столбец {j + 1}: {columnAverages[j]}");
            }
        }
    }
}


*/




// ____________________________________________________________________ Домашняя работа 7 ________________________________________________________________________________________

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.

/*

using System;

namespace SortRowsDescending
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            int rowCount = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов: ");
            int columnCount = int.Parse(Console.ReadLine());

            Console.Write("Введите минимальное значение: ");
            int minValue = int.Parse(Console.ReadLine());

            Console.Write("Введите максимальное значение: ");
            int maxValue = int.Parse(Console.ReadLine());

            int[,] matrix = GenerateRandomMatrix(rowCount, columnCount, minValue, maxValue);

            Console.WriteLine("Исходный двумерный массив:");
            PrintMatrix(matrix);

            SortRowsDescending(matrix);

            Console.WriteLine("\nУпорядоченный двумерный массив по убыванию:");
            PrintMatrix(matrix);
        }

        static int[,] GenerateRandomMatrix(int rowCount, int columnCount, int minValue, int maxValue)
        {
            Random random = new Random();
            int[,] matrix = new int[rowCount, columnCount];

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    matrix[i, j] = random.Next(minValue, maxValue + 1);
                }
            }

            return matrix;
        }

        static void SortRowsDescending(int[,] matrix)
        {
            int rowCount = matrix.GetLength(0);
            int columnCount = matrix.GetLength(1);

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount - 1; j++)
                {
                    for (int k = 0; k < columnCount - j - 1; k++)
                    {
                        if (matrix[i, k] < matrix[i, k + 1])
                        {
                            int temp = matrix[i, k];
                            matrix[i, k] = matrix[i, k + 1];
                            matrix[i, k + 1] = temp;
                        }
                    }
                }
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rowCount = matrix.GetLength(0);
            int columnCount = matrix.GetLength(1);

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}


*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.

/*

using System;

namespace FindRowWithMinSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            int rowCount = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов: ");
            int columnCount = int.Parse(Console.ReadLine());

            Console.Write("Введите минимальное значение: ");
            int minValue = int.Parse(Console.ReadLine());

            Console.Write("Введите максимальное значение: ");
            int maxValue = int.Parse(Console.ReadLine());

            int[,] matrix = GenerateRandomMatrix(rowCount, columnCount, minValue, maxValue);

            Console.WriteLine("Сгенерированный двумерный массив:");
            PrintMatrix(matrix);

            int minSumRow = FindRowWithMinSum(matrix);

            if (minSumRow != -1)
            {
                Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRow}");
            }
            else
            {
                Console.WriteLine("Массив пустой.");
            }
        }

        static int[,] GenerateRandomMatrix(int rowCount, int columnCount, int minValue, int maxValue)
        {
            Random random = new Random();
            int[,] matrix = new int[rowCount, columnCount];

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    matrix[i, j] = random.Next(minValue, maxValue + 1);
                }
            }

            return matrix;
        }

        static int FindRowWithMinSum(int[,] matrix)
        {
            int rowCount = matrix.GetLength(0);
            int columnCount = matrix.GetLength(1);

            if (rowCount == 0 || columnCount == 0)
            {
                return -1; // Массив пустой
            }

            int minSum = int.MaxValue;
            int minSumRow = -1;

            for (int i = 0; i < rowCount; i++)
            {
                int rowSum = 0;

                for (int j = 0; j < columnCount; j++)
                {
                    rowSum += matrix[i, j];
                }

                if (rowSum < minSum)
                {
                    minSum = rowSum;
                    minSumRow = i;
                }
            }

            return minSumRow;
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rowCount = matrix.GetLength(0);
            int columnCount = matrix.GetLength(1);

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.

/*

using System;

namespace MatrixMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк первой матрицы: ");
            int rowCount1 = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов первой матрицы: ");
            int columnCount1 = int.Parse(Console.ReadLine());

            Console.Write("Введите минимальное значение для первой матрицы: ");
            int minValue1 = int.Parse(Console.ReadLine());

            Console.Write("Введите максимальное значение для первой матрицы: ");
            int maxValue1 = int.Parse(Console.ReadLine());

            Console.Write("Введите количество строк второй матрицы: ");
            int rowCount2 = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов второй матрицы: ");
            int columnCount2 = int.Parse(Console.ReadLine());

            Console.Write("Введите минимальное значение для второй матрицы: ");
            int minValue2 = int.Parse(Console.ReadLine());

            Console.Write("Введите максимальное значение для второй матрицы: ");
            int maxValue2 = int.Parse(Console.ReadLine());

            if (columnCount1 != rowCount2)
            {
                Console.WriteLine("Умножение матриц невозможно. Число столбцов первой матрицы должно быть равно числу строк второй матрицы.");
            }
            else
            {
                int[,] matrix1 = GenerateRandomMatrix(rowCount1, columnCount1, minValue1, maxValue1);
                int[,] matrix2 = GenerateRandomMatrix(rowCount2, columnCount2, minValue2, maxValue2);

                Console.WriteLine("Первая матрица:");
                PrintMatrix(matrix1);

                Console.WriteLine("\nВторая матрица:");
                PrintMatrix(matrix2);

                int[,] resultMatrix = MultiplyMatrices(matrix1, matrix2);

                if (resultMatrix != null)
                {
                    Console.WriteLine("\nРезультат умножения матриц:");
                    PrintMatrix(resultMatrix);
                }
                else
                {
                    Console.WriteLine("\nУмножение матриц невозможно из-за неправильных размеров.");
                }
            }
        }

        static int[,] GenerateRandomMatrix(int rowCount, int columnCount, int minValue, int maxValue)
        {
            Random random = new Random();
            int[,] matrix = new int[rowCount, columnCount];

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    matrix[i, j] = random.Next(minValue, maxValue + 1);
                }
            }

            return matrix;
        }

        static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rowCount1 = matrix1.GetLength(0);
            int columnCount1 = matrix1.GetLength(1);
            int rowCount2 = matrix2.GetLength(0);
            int columnCount2 = matrix2.GetLength(1);

            if (columnCount1 != rowCount2)
            {
                return null; // Умножение невозможно из-за неправильных размеров
            }

            int[,] resultMatrix = new int[rowCount1, columnCount2];

            for (int i = 0; i < rowCount1; i++)
            {
                for (int j = 0; j < columnCount2; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < columnCount1; k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }
                    resultMatrix[i, j] = sum;
                }
            }

            return resultMatrix;
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rowCount = matrix.GetLength(0);
            int columnCount = matrix.GetLength(1);

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

*/

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

/*

using System;

namespace ThreeDimensionalArrayWithIndices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер по X: ");
            int sizeX = int.Parse(Console.ReadLine());

            Console.Write("Введите размер по Y: ");
            int sizeY = int.Parse(Console.ReadLine());

            Console.Write("Введите размер по Z: ");
            int sizeZ = int.Parse(Console.ReadLine());

            int[,,] threeDimArray = new int[sizeX, sizeY, sizeZ];
            int currentNumber = 10;

            // Заполнение трехмерного массива неповторяющимися двузначными числами
            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                {
                    for (int k = 0; k < sizeZ; k++)
                    {
                        threeDimArray[i, j, k] = currentNumber++;
                    }
                }
            }

            // Вывод трехмерного массива с индексами
            for (int i = 0; i < sizeX; i++)
            {
                Console.WriteLine($"Слой {i + 1}:");
                for (int j = 0; j < sizeY; j++)
                {
                    for (int k = 0; k < sizeZ; k++)
                    {
                        Console.Write($"[{i}, {j}, {k}] = {threeDimArray[i, j, k]}  ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}

*/


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Написал для размера любого массива, заданного пользователем.

using System;

namespace SpiralArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива (n): ");
            int n = int.Parse(Console.ReadLine());

            int[,] spiralArray = new int[n, n];
            int value = 1;

            int minRow = 0, maxRow = n - 1, minCol = 0, maxCol = n - 1;

            while (value <= n * n)
            {
                // Слева направо
                for (int i = minCol; i <= maxCol; i++)
                {
                    spiralArray[minRow, i] = value++;
                }
                minRow++;

                // Сверху вниз
                for (int i = minRow; i <= maxRow; i++)
                {
                    spiralArray[i, maxCol] = value++;
                }
                maxCol--;

                // Справа налево
                for (int i = maxCol; i >= minCol; i--)
                {
                    spiralArray[maxRow, i] = value++;
                }
                maxRow--;

                // Снизу вверх
                for (int i = maxRow; i >= minRow; i--)
                {
                    spiralArray[i, minCol] = value++;
                }
                minCol++;
            }

            // Вывод спирального массива
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(spiralArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}



