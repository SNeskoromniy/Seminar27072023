/*
Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

#region --- 00. Configuration ---
Console.Clear();
Console.Title = "Задача 50";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"************************************************************************
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion 

//Инициализация массива 
int[,] matrix = new int[3, 4];
//Заполняем массив случайными числами
FillArray(matrix);

//Ввод позиции элемента
int numI = GetNumberFromUser("введите номер строки в массиве: ");
int numJ = GetNumberFromUser("введите номер столбца в массиве: ");
Console.WriteLine();

//Печать массива заполненного случайными числами
PrintArray(matrix);
Console.WriteLine();
//
if (numI > matrix.GetLength(0) || numJ > matrix.GetLength(1))
{
    Console.WriteLine("Такого элемента массива нет!!!");
}
else Console.WriteLine($"Элемент массива: {matrix[numI,numJ]}");

//Конец программы


//Метод заполнения массива случайными числами от 1 до 9
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);//[1; 10]
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
}

//метод ввода числа
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

