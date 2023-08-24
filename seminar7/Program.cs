// Task 0. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

/*

int[,] CreateRandom2dArray()
{
    Console.Write("Input a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());  

    int[,] array = new int[rows, colums];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < colums; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

*/

// Task 1. Задайте двумерный массив размера m на n, каждый элемент в массиве находится 
// по формуле: Aij = i+j. Выведите полученный массив на экран.

/*

int[,] Create2dArray(int rows, int colums)
{
    int[,] array = new int[rows, colums];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < colums; j++)
            array[i, j] = i + j;
        
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

Console.Write("Input a quantity of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a quantity of colums: ");
int colums = Convert.ToInt32(Console.ReadLine()); 

int[,] myArray = Create2dArray(rows, colums);
Show2dArray(myArray);

*/

// Task 2. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты.
// ???

/*

int[,] Create2dArray(int rows, int colums)
{
    int[,] array = new int[rows, colums];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < colums; j++)
            array[i, j] = i + j;
        
    return array;
}

void Replace2dArray(int[,] array)
{
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
        {
            if(array[i,j] % 2 == 0)
            {
                array[i, j] = array[i,j] * array[i,j];
            }
        }
    }
}

Console.Write("Input a quantity of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a quantity of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());

Replace2dArray(myArray);
Create2dArray(myArray);

*/

// Task 3. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной 
// диагонали (с индексами (0,0); (1;1) и т.д.
// ???

/*

int[,] Create2dArray(int rows, int colums)
{
    int[,] array = new int[rows, colums];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < colums; j++)
            array[i, j] = i + j;
        
    return array;
}

int SumOfMain(int[,] array)
{
    int res = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        res += array[i,i];
    }
    return res;
}

Console.Write("Input a quantity of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a quantity of colums: ");
int colums = Convert.ToInt32(Console.ReadLine()); 

int res =SumOfMain(MyArray);
Console.Write($"Sum: {res}");

*/

// Task 4. ????

/*

void SortLine(int[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i,k] < array[i,k + 1])
                    {
                        int temp = array[i,k];
                        array[i,k] = array[i,k + 1];
                        array[i,k + 1] = temp;
                    }
            }
        }
    }
}

*/