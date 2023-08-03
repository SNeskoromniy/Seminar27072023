/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
#region --- 00. Configuration ---
Console.Clear();
Console.Title = "Задача 21. Расчет расстояния между точками";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"************************************************************************
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion 

//Определение значений

        Console.WriteLine("ВВЕДИТЕ КООРДИНАТЫ ПЕРВОЙ ТОЧКИ ");
        
        int xA = GetNumberFromUser("Введите X: ");
        
        int yA = GetNumberFromUser("Введите Y: ");
       
        int zA = GetNumberFromUser("Введите Z: ");

        Console.WriteLine("ВВЕДИТЕ КООРДИНАТЫ ВТОРОЙ ТОЧКИ ");
        
        int xB = GetNumberFromUser("Введите X: ");
        
        int yB = GetNumberFromUser("Введите Y: ");
      
        int zB = GetNumberFromUser("Введите Z: ");
 


double rezult = GetLengthCut(xA, yA, zA, xB, yB, zB);

Console.Write($"Длина отрезка: {rezult}");

//Конец программы


// Определяем функцию, выполняющую ввод целого числа с консоли
static int GetNumberFromUser(string message)
{
    while (true)
    {
        try
        {
            Console.Write(message);
            int num = int.Parse(Console.ReadLine() ?? "");
            return num;
        }
        catch (Exception exc)
        {
            Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        }
    }
}

//Определяем функцию расчета длины отрезка в пространстве
static double GetLengthCut ( int xA, int yA, int zA, int xB, int yB, int zB)
{
double length = Math.Sqrt((xB - xA) * (xB - xA) + (yB - yA) * (yB - yA) + (zB - zA) * (zB - zA));
return length;
}