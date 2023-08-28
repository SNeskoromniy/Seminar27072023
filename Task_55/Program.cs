/*
Задача 53: Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку массива.
*/
#region --- 00. Configuration ---
Console.Clear();
Console.Title = "Задача №53";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"************************************************************************
Задача 55: Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя.

************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion 
//Ввод размера массива
int row = GetNumberFromUser("введите количество строк массива: ");
int colum = GetNumberFromUser("введите количество столбцов массива: ");

//Инициализация массива 
int[,] matrix = new int[row, colum];
double[] resultArray = new double[matrix.GetLength(1)];


//Заполняем массив случайными числами
FillArray(matrix);

//Печать массива заполненного случайными числами
PrintArray(matrix);

if (row == colum)
{
    int[,] newArray = ReplacingRowsColums(matrix);
    PrintArray(newArray);
}
else
    Console.WriteLine("Перевернуть массив не возможно");

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
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); //[1; 9)
        }
    }
}
//Метод замены 1-й и последней строки
int[,] ReplacingRowsColums(int[,] matr)
{
    int[,] newArray = new int[matr.GetLength(0), matr.GetLength(1)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            newArray[i, j] = matr[j, i];
        }
    }
    return newArray;
}