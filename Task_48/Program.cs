/*Задача 48: Задайте двумерный массив размера m на n,
каждый элемент в массиве находится по формуле: Aij = i+j.
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/

#region --- 00. Configuration ---
Console.Clear();
Console.Title = "Задача №48";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"************************************************************************
Задайте двумерный массив размера m на n,
каждый элемент в массиве находится по формуле: Aij = i+j.
Выведите полученный массив на экран.
************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion 

//Ввод размера массива
int numI = GetNumberFromUser("введите количество строк массива: ");
int numJ = GetNumberFromUser("введите количество столбцов массива: ");

int[,] matrix = new int[numI, numJ]; //Инициализация массива 
GetArray(matrix); //Заполняем массив случайными числами
PrintArray(matrix); //Печать массива заполненного случайными числами

//Конец программы


//Определение методов
//Метод ввода числа
static int GetNumberFromUser(string message)
{
    while (true)
    {
        try
        {
            Console.Write($"{message}");
            int num = int.Parse(Console.ReadLine() ?? "");
            return num;
        }
        catch (Exception exc)
        {
            Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        }
    }
}

//Метод печати массива
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

//Метод заполнения массива случайными числами от 1 до 9
void GetArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = i + j;
        }
    }
}