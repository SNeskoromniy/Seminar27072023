/*
Заполните спирально массив 4 на 4.
*/
#region --- 00. Configuration ---
Console.Clear();
Console.Title = "Задача №62";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"************************************************************************
Заполните спирально массив 4 на 4.
************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion 

//Инициализация массива 
int[,] matrix = new int[4, 4];

//Заполняем массив спирально
GetSpiralArray(matrix);

//Печать массива 
PrintArray(matrix);
///Конец программы

//Определение методов

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
//Метод заполнения массива спирально
void GetSpiralArray(int[,] matr)
{
    int arraySize = 4;
    int element = 1;
    int startX = 0; //
    int startY = 0;
    int endX = arraySize - 1;
    int endY = arraySize - 1;

    while (startX <= endX && startY <= endY)
    {
        //
        for (int i = startY; i <= endY; i++)
        {
            matr[startX, i] = element++;
        }
        startX++;
        //
        for (int i = startX; i <= endX; i++)
        {
            matr[i, endY] = element++;
        }
        endY--;
        //
        for (int i = endY; i >= startY; i--)
        {
            matr[endX, i] = element++;
        }
        endX--;
        //
        for (int i = endX; i >= startX; i--)
        {
            matr[i, startY] = element++;
        }
        startY++;
    }
}
