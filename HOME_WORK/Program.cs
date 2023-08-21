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



