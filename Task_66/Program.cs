/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N.
*/ 

#region --- 00. Configuration ---
Console.Clear();
Console.Title = "Задача №66";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"************************************************************************
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N.
************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion 
//
int numM = GetNumberFromUser("введите число M: ");
int numN = GetNumberFromUser("введите число N: ");
if (numM > numN)
{
    int temp = numM;
    numM = numN;
    numN = temp;
}
int result = GetSum(numM, numN);
Console.WriteLine(result);


//Определение методов
//
int GetSum(int M, int N)
{
if (M == N) return N;
return N + GetSum(M, N - 1);
}


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
