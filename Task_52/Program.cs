/*Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое
каждого столбца: 4,6; 5,6; 3,6; 3.
*/

#region --- 00. Configuration ---
Console.Clear();
Console.Title = "Задача №52";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"************************************************************************
Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion 
//Ввод размера массива
int numI = GetNumberFromUser("введите количество строк массива: ");
int numJ = GetNumberFromUser("введите количество столбцов массива: ");

//Инициализация массива 
int[,] matrix = new int[numI, numJ];
double[] resultArray = new double[matrix.GetLength(1)];
double sum = 0;

//Заполняем массив случайными числами
FillArray(matrix);

//Печать массива заполненного случайными числами
PrintArray(matrix);

resultArray = GetArithmeticMeanNum(matrix);
Console.WriteLine("Результат расчета среднего арифметического: ");
Console.WriteLine(string.Join("; ", resultArray));
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
            matr[i, j] = new Random().Next(1, 10);//[1; 10)
        }
    }
}
//Метод расчета среднего арифметического по столбцам массива
double[] GetArithmeticMeanNum(int[,] matrix)
{
    double[] resultArr = new double[matrix.GetLength(1)];
    double sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j];
        }
        resultArr[j] = sum / matrix.GetLength(1);
        sum = 0;
    }
    return resultArr;
}