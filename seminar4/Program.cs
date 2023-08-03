// Seminar 4.

// Task 1. Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.

/*

int Summa(int number)
{
    int result = 0;
    for (int i = 1; i <= number; i++)
        result +=i;
    return result;
}
Console.Write("input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write(Summa(number));

*/

// Task 2. Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе.

/*

int CountNum(int N)
{
    int count = 1;
    for (;N >= 10; count++)
        N = N / 10;
    return count;
}
Console.Write("input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write(CountNum(number));

*/

// Task 3. Напишите программу, которая принимает на вход число N 
// и выдаёт произведение нечетных чисел от 1 до N.

/*

int Work(int number)
{
    int result = 1;
    for (int i = 1; i <= number; i = i + 2)
        result *=i;
    return result;
}
Console.Write("input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write(Work(number));

*/


// Генерация произвольного массива:

/*

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; // инициализируется размер массива, не конкретный индекс.

    for(int i =0; i < size; i++)  //можно использовать и while
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}
// int a = 5;
// Console.Write(a++);      //постфиксная форма
// Console.Write(+a);     

void WriteArray(int[] array)    //вывод массива
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");   //возвращаем массив

    Console.WriteLine();
}

Console.Write("Input a length of an array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min of an array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max of an array: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
WriteArray(myArray);

*/