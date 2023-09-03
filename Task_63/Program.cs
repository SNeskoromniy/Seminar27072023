/*
Задача 63: Задайте значение N. Напишите программу, которая выведет все
натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/ 

#region --- 00. Configuration ---
Console.Clear();
Console.Title = "Задача №63";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"************************************************************************
Задайте значение N. Напишите программу, которая выведет все
натуральные числа в промежутке от 1 до N.
************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion 

int N = GetNumberFromUser("введите число N: ");
string str = GetNatur(1, N);
Console.WriteLine(str);





//Определение методов
//
string GetNatur(int startNum, int inNum)
{
if (startNum == inNum) return inNum.ToString();
return startNum + " " + GetNatur(startNum + 1, inNum); 
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