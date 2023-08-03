/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
#region --- 00. Configuration ---
Console.Clear();
Console.Title = "Задача 23. Формирование таблицы кубов";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"************************************************************************
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion 

#region --- 01. Input operations ---
// Вызов метода, запрашивающего у пользователя целое число.
int num = GetNumberFromUser();
#endregion --- 01. Input operations ---

#region --- 02. Business logic and Output operations ---
for (int i = 1; i <= num; i++)
{
    Console.Write($" куб числа {i} равен: {i * i * i}");
    Console.WriteLine();
}
#endregion --- 02. Input operations ---
//Конец программы



// -------------------------Определение методов ---------------------------------
// Определяем функцию, выполняющую ввод целого числа с консоли
static int GetNumberFromUser()
{   
    while(true)
    {
        try
        {
            Console.Write("Введите целое число: ");
            int num = int.Parse(Console.ReadLine() ?? "");
            return num;
        }
        catch (Exception exc)
        {
            Console.WriteLine($"Ошибка ввода данных! {exc.Message}");        
        }
    }
}

