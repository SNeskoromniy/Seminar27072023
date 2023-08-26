/*
Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
#region --- 00. Configuration ---
Console.Clear();
Console.Title = "Задача 47";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"************************************************************************
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion 

//Определение значений
int sizeI = GetNumberFromUser("введите количество строк в массиве: ");
int sizeJ = GetNumberFromUser("введите количество столбцов в массиве: ");



//Инициализация массива 
double[,] matrix = new double[sizeI, sizeJ];

//Заполняем массив случайными числами
GetDoubleNumMatrix(matrix);
Console.WriteLine();
//Печать массива заполненного случайными числами
PrintArray(matrix);


//Метод печати массива
void PrintArray(double[,] matr)
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
//Метод заполнения массива случайными числами от 1 до 9
void GetDoubleNumMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Math.Round((new Random().NextDouble()), 2);
        }
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
