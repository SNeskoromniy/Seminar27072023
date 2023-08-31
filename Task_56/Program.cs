/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов.
*/

#region --- 00. Configuration ---
Console.Clear();
Console.Title = "Задача №56";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"************************************************************************
Задайте прямоугольный двумерный массив. 
************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion 
//Ввод размера массива
int row = GetNumberFromUser("введите количество строк прямоугольного массива: ");
int colum = GetNumberFromUser("введите количество столбцов прямоугольного массива: ");
if (row == colum)
{
    int[,] matrix = new int[row, colum];//Инициализация массива 
    FillArray(matrix);//Заполняем массив случайными числами
    PrintArray(matrix);
    int[] array = GetSumRowArray(matrix);
    //Выводим суммы строк
    Console.Write("Суммы элементов строк массива: ");
    Console.WriteLine(string.Join(" ", array));
    int rowMinSum = GetRowMinSumArr(array);
    Console.WriteLine($"Строка массива с минимальной суммой элементов: {rowMinSum}");
}
else Console.WriteLine("Массив не является прямоугольным");
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
//Метод поиска строки массива с минимальным значением суммы  элементов
int[] GetSumRowArray(int[,] matr)
{
    int tempSum;
    int[] resultArr = new int[matr.GetLength(0)];
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            resultArr[i] += matr[i, j];
        }
    }
    return resultArr;
}

int GetRowMinSumArr(int[] array)
{
    int minSum = array[0];
    int row = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minSum )
        {
            minSum = array[i];
            row = i;
        }
    }
    return row;
}

