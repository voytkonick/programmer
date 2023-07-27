// Seminar 2.

// Theory

/*

13254 / 10 = 1325
13254 / 100 = 132
13254 / 1000 = 13
13254 / 10000 = 1

13254 % 10 = 4
13254 % 100 = 54
13254 % 1000 = 254
13254 % 10000 = 3254

*/

// Task 1. Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа.

/*

int CutNumber(int num)
{
    int hunders = num / 100;
    int units = num % 10;

    int res = hunders * 10 + units;
    return res;

    //return = hunders * 10 + units;  можно просто так написать
    
}

int randNumber = new Random().Next(100,1000);  // 100 включено, 1000 нет

int newNumber = CutNumber(num);
Console.WriteLine($"New version of {randNumber} is {newNumber}");

*/

// Task 2. Напишите программу, которая принимает на вход число и 
// проверяет, кратно ли оно одновременно a и b.

/*

bool IsDividable(int num, int div1, int div2);
{
    // if (num % div1 == 0 && num % div2 == 0) // логическое И &&, логическое ИЛИ ||
    //     return true;
    // else
    //     return false;

    return num % div1 == 0 && num % div2 == 0;
}
Console.Write("Input a number for checking: ");
int number = Console.ToInt32(Console.ReadLine());
Console.Write("Input a first: ");
int divider1 = Console.ToInt32(Console.ReadLine());
Console.Write("Input a second: ");
int divider2 = Console.ToInt32(Console.ReadLine());

bool res = IsDividable(number, divider1, divider2);

if (res) Console.Write("yes");
else Console.Write("no");

*/

// Task 3. Напишите программу, которая выводит случайное число из 
// отрезка [10, 99] и показывает наибольшую цифру числа.

/*

int MaxNum(int num)
{
    int num1 = num / 10;
    int num2 = num % 10;
    if (num1 > num2)
    return num1 ;
    else return num2 ;
}
int num = new Random().Next(10,100);
Console.WriteLine(num);
int res = MaxNum(num);
Console.WriteLine("Max number " + res);

*/

// Task 4. Напишите программу, которая принимает на вход два числа и 
// проверяет, является ли одно число квадратом другого.

/*

bool KvadNum(int num1, int num2)
{
    return num1 == num2 * num2 || num2 == num1 * num1;
}
Console.Write("Input a number 1 for checking: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number 2 for checking: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool res = KvadNum(num1, num2);

if (res) Console.Write("yes");
else Console.Write("no");

*/












