/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 2
*/ 

#region --- 00. Configuration ---
Console.Clear();
Console.Title = "Задача №69";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"************************************************************************
Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 2
************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion 
//
int aNum = GetNumberFromUser("введите число A: ");
int bNum = GetNumberFromUser("введите число B: ");

GetNum(aNum, bNum);
Console.WriteLine(GetNum(aNum, bNum));





//Определение методов
//
int GetNum(int A, int B)
{
if (B == 0) return 1;
if (B == 1) return A;
if (B % 2 == 0) return GetNum(A * A, B / 2);
else return GetNum(A, B - 1) * A; 
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
