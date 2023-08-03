/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
#region --- 00. Configuration ---
Console.Clear();
Console.Title = "Задача 12. Проверка числа на палиндром";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"************************************************************************
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion 

// Основной блок решения
#region --- 00. Configuration ---

int num = GetNumberFromUser();

if (num < 10000 || num > 99999) //Проверка на пятизначное число
{
    Console.WriteLine("Число не является пятизначным");
}
else
{
    int sim1 = GetOneNumber(num);
    int sim2 = GetReverseNumber(num);
         
    if (sim1 == sim2)
        Console.WriteLine($"Число {num} является палиндромом");
    else
        Console.WriteLine($"Число {num} не палиндром");
}
#endregion 

//Конец программы


// -------------------------Определение методов ---------------------------------
// Определяем функцию, выполняющую ввод целого числа с консоли
static int GetNumberFromUser()
{
    while (true)
    {
        try
        {
            Console.Write("Введите пятизначное число: ");
            int num = int.Parse(Console.ReadLine() ?? "");
            return num;
        }
        catch (Exception exc)
        {
            Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        }
    }
}

static int GetReverseNumber(int num)
{
    int simTMP = num % 1000;
    int sim2 = (simTMP % 10 * 100) + (simTMP / 10 % 10) * 10 + (simTMP / 100);
    return sim2;
}

static int GetOneNumber(int num)
{
    int sim1 = num / 100;
    return sim1;
}
