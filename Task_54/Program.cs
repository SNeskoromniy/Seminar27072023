/*
Задача 54: Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива
*/

#region --- 00. Configuration ---
Console.Clear();
Console.Title = "Задача №54";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"************************************************************************
Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива

************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion 
//Ввод размера массива
int row = GetNumberFromUser("введите количество строк массива: ");
int colum = GetNumberFromUser("введите количество столбцов массива: ");


int[,] matrix = new int[row, colum];//Инициализация массива 
FillArray(matrix);//Заполняем массив случайными числами
PrintArray(matrix);
GetSortArray(matrix);
PrintArray(matrix);

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
//Метод расчета суммы главной диагонали
void GetSortArray(int[,] matr)
{
    int temp;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = j + 1; k < matr.GetLength(0); k++)
            {
                if (matr[i, j] < matr[i, k])
                {
                    temp = matr[i, j];
                    matr[i, j] = matr[i, k];
                    matr[i, k] = temp;
                }
            }
        }
    }
}
