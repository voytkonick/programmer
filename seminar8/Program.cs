// Task 0. Задайте двумерный массив. Напишите программу, которая поменяет местами 
// указанные пользователем строки массива.

/*

int[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
{
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

void ChangeRows(int[,] array, int r1, int r2)
{
    if(r1 >= 0 && r1 < array.GetLength(0) &&
       r2 >= 0 && r2 < array.GetLength(0) &&
       r1 != r2)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[r1, j];
            array[r1, j] = array[r2, j];
            array[r2 , j] = temp;
        }
    }
}

Console.Write("Enter a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows,colums, minValue, maxValue);
Show2dArray(myArray);

Console.Write($"Input a number of the first row to change: ");
int row1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write($"Input a number of the second row to change: ");
int row2 = Convert.ToInt32(Console.ReadLine()) - 1;

ChangeRows(myArray, row1, row2);
Show2dArray(myArray);

*/

// Task 1. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.

/*

int[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
{
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

void ReplacementRowsColums(int [,] array)

{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = i + 1; j < array.GetLength(1); j++)
        {
            int temp = array[i,j];
            array[i,j] = array[j,i];
            array[j,i] = temp;
        }
    }
}

Console.Write("Enter a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows,colums, minValue, maxValue);
Show2dArray(myArray);

Console.WriteLine();

ReplacementRowsColums(myArray);
Show2dArray(myArray);

*/

// Task 2. Из двумерного массива целых чисел удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.


int[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
{
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

int[,] DelteRowAndColoumnWithMinValue (int[,] array)
            {
                int minI = 0;
                int minJ = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] < array[minI, minJ])
                        {
                            minI = i;
                            minJ = j;                            
                        }                        
                    }                    
                }

int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
                for (int i = 0; i < result.GetLength(0); i++)
                {
                    for (int j = 0; j < result.GetLength(1); j++)
                    {
                        if (i < minI && j < minJ) result[i,j] = array[i, j];
                        if (i < minI && j >= minJ) result[i, j] = array[i, j + 1];
                        if (i >= minI && j < minJ) result[i, j] = array[i + 1, j]; 
                        if (i >= minI && j >= minJ) result[i, j] = array[i + 1, j + 1];
                    }
                }
                return result;
            }

Console.Write("Enter a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows,colums, minValue, maxValue);
Show2dArray(myArray);
Console.WriteLine();

int[,] NewArray = NewArray(myArray);
Show2dArray(NewArray);