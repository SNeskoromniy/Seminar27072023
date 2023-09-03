/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью
рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29
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
int result = FAckerman(numM, numN);
Console.WriteLine(result);


//Определение методов
//Метод вычисления функции Аккермана
static int FAckerman(int M, int N)
{
if (M == 0) return N + 1;
if (M > 0 && N == 0) return FAckerman(M - 1, 1);
if (M > 0 && N > 0) return FAckerman(M - 1, FAckerman(M, N - 1));
return FAckerman(M, N);
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
