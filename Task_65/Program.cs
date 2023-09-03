/*
Задача 65: Задайте значения M и N. Напишите программу, которая выведет
все натуральные числа в промежутке от M до N.
*/

#region --- 00. Configuration ---
Console.Clear();
Console.Title = "Задача №65";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"************************************************************************
 Задайте значения M и N. Напишите программу, которая выведет
все натуральные числа в промежутке от M до N.
************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion 
//
int mNum = GetNumberFromUser("введите число M: ");
int nNum = GetNumberFromUser("введите число N: ");
if (mNum > nNum)
{
    int temp = mNum;
    mNum = nNum;
    nNum = temp;
} 
string str = GetNatur(mNum, nNum);
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