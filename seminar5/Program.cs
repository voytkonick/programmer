//  Seminar 5.
//  Task 1. Задайте массив из m элементов, заполненный случайными числами 
// из промежутка [a, b]. Найдите сумму отрицательных элементов массива.

/*

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; // инициализируется размер массива, не конкретный индекс.

    for(int i =0; i < size; i++)  //можно использовать и while
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void WriteArray(int[] array)    //вывод массива
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");   //возвращаем массив

    Console.WriteLine();
}

int SumOfNegative(int [] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] < 0)
            sum += array[i];
    return sum;
}

Console.Write("input a Length of array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min possible value: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max possible value: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(m, a, b);
WriteArray(myArray);
Console.WriteLine(SumOfNegative(myArray));

*/

// Task 2. Напишите программу замена элементов массива: положительные элементы замените 
// на соответствующие отрицательные, и наоборот.

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; // инициализируется размер массива, не конкретный индекс.

    for(int i =0; i < size; i++)  //можно использовать и while
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void WriteArray(int[] array)    //вывод массива
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");   //возвращаем массив

    Console.WriteLine();
}

int[] Replace (int[] array)
{
    for( int i = 0; i < array.Length; i++)
        array[i] = array[i] * (-1);
    return array;
}

Console.Write("input a Length of array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min possible value: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max possible value: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(m, a, b);
WriteArray(Replace(myArray));
*/

// Task 3. Задайте массив. Напишите программу, которая определяет, присутствует ли 
// заданное число в массиве.


/*

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; // инициализируется размер массива, не конкретный индекс.

    for(int i =0; i < size; i++)  //можно использовать и while
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void WriteArray(int[] array)    //вывод массива
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");   //возвращаем массив

    Console.WriteLine();
}

bool Find(int[] array, int number)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(number == array[i])
        return true;
    }
    return false;
}   

Console.Write("input a Length of array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min possible value: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max possible value: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(m, a, b); //создали массив
WriteArray(myArray);  //вывели массив

Console.Write("input number: ");  //вводим число которое необходимо найти
int number = Convert.ToInt32(Console.ReadLine());

bool res = Find(myArray, number);
Console.WriteLine(res);

*/


// Task 4. Задайте одномерный массив из m случайных чисел. Найдите количество элементов 
// массива, значения которых лежат в отрезке [a,b].

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

int quantity (int[] array, int min_num, int max_num)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if (array[i] > min_num && array[i] < max_num) 
        count++;

    return count;
}
Console.Write("Enter a length of an array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, minValue, maxValue);
WriteArray(myArray);

Console.Write("Enter the left border: ");
int min_num = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the right border: ");
int max_num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(quantity(myArray, min_num, max_num));

*/

