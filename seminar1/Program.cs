        //  Seminar 1
        //  Theory
/*
int intNumber = 25;
double dubleNumber = 12.12;
string text = "some text";
bool logicVar = true;       // or false




int num = 5;
Console.WriteLine("My numbers is " + num);



Console.Write("Input a number: ");                 //просим вести цифры
int num = Convert.ToInt32(Console.ReadLine());    //конвертируем текст в числовой формат
Console.Write("Your number is " + num);          //вывод иформации
*/

        //  Task 1. Напишите программу, которая на вход принимает два числа 
        //  и проверяет, является ли первое число квадратом второго.

/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad2 = num2 * num2;

if(num1 == quad2)
{
    Console.WriteLine("Yes");   //если строка одна, можно делать без фигурных скобок и соединить с предыдущей строкой у которой нет ";"
}
else
{
    Console.WriteLine("No!");    
}
*/

        //  Task2. Напишите программу, которая на вход принимает положительное число (N),
        //  а на выходе показывает все целые числа в промежутке от -N до N.

/*
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = -num;

while(current <= num)
{
    Console.Write(current + " ");
    current++;
}

*/