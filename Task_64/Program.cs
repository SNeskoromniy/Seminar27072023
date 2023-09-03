/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
натуральные числа в промежутке от N до M.
*/ 

#region --- 00. Configuration ---
Console.Clear();
Console.Title = "Задача №64";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"************************************************************************
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
натуральные числа в промежутке от N до M.
************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion 
//
int mNum = GetNumberFromUser("введите число M: ");
int nNum = GetNumberFromUser("введите число N: ");
//Проверка введенных значений.
if (mNum > nNum)
{
    int temp = mNum;
    mNum = nNum;
    nNum = temp;
}
string str = GetNatur(mNum, nNum);
Console.WriteLine(str);
//Конец программы


//Определение методов
//
string GetNatur(int startNum, int inNum)
{
if (startNum == inNum) return inNum.ToString();
return inNum + " " + GetNatur(startNum, inNum - 1); 
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
