/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
*/

#region --- 00. Configuration ---
Console.Clear();
Console.Title = "Задача №58";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"************************************************************************
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion 
//Ввод размера массива
int firstRowArr = GetNumberFromUser("введите количество строк первого массива: ");
int firstColumArr = GetNumberFromUser("введите количество столбцов первого массива: ");
int secondRowArr = GetNumberFromUser("введите количество строк второго массива: ");
int secondColumArr = GetNumberFromUser("введите количество столбцов второго массива: ");

if (firstColumArr == secondRowArr)
{
    //Инициализация массива 
    int[,] firstArr = new int[firstRowArr, firstColumArr];
    int[,] secondArr = new int[secondRowArr, secondColumArr];
    //Заполняем массивы случайными числами
    FillArray(firstArr);
    FillArray(secondArr);
    PrintArray(firstArr);
    PrintArray(secondArr);

    int[,] resultArray = GetProductArray(firstArr, secondArr);
    Console.WriteLine("Произведение 2-х матриц равно: ");
    PrintArray(resultArray);
}
else Console.WriteLine("Произведение матриц не возможно");
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

int[,] GetProductArray(int[,] firstMatr, int[,] secondMatr)
{
    int[,] productMatr = new int[firstMatr.GetLength(0), secondMatr.GetLength(1)];
    for (int i = 0; i < firstMatr.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatr.GetLength(1); j++)
        {
            for (int k = 0; k < firstMatr.GetLength(1); k++)
            {
                productMatr[i, j] += firstMatr[i, k] * secondMatr[k, j];
            }
        }
    }
    return productMatr;
}


