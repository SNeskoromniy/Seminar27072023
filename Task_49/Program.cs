/*Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты. 
Например, изначально массив выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
*/

#region --- 00. Configuration ---
Console.Clear();
Console.Title = "Задача №49";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"************************************************************************
Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion 

//Ввод размера массива
int numI = GetNumberFromUser("введите количество строк массива: ");
int numJ = GetNumberFromUser("введите количество столбцов массива: ");

int[,] matrix = new int[numI, numJ]; //Инициализация массива 
FillArray(matrix); //Заполняем массив случайными числами
PrintArray(matrix); //Печать массива заполненного случайными числами
SumOddElements(matrix);
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
void SumOddElements(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
           if (i%2 == 1 && j%2 == 1) matr[i, j] = matr[i, j] * matr[i, j];
        }
    }
}