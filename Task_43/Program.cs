/*
Задача 43 Напишите программу, которая найдёт точку пересечения двух прямых, заданных
уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
*/

#region --- 00. Configuration ---
Console.Clear();
Console.Title = "Задача 43" ;

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"************************************************************************
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
Значения b1, k1, b2 и k2 задаются пользователем.
************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion 
int b1 = GetNumberFromUser("введите число b1: ");
int k1 = GetNumberFromUser("введите число k1: ");
int b2 = GetNumberFromUser("введите число b2: ");
int k2 = GetNumberFromUser("введите число k2: ");

double[] result = GetIntersectionPoint(b1, k1, b2, k2);
Console.WriteLine(String.Join(" ", result));


//метод ввода числа
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

//метот нахождения точки пересечения 2-х прямых
double[] GetIntersectionPoint(int b1, int k1, int b2, int k2)
{
double[] array = new double[2];
array[0] = (double) (b2 - b1)/(k1-k2);
array[1] = (double) (k1 * array[0]) + b1;
return array;
}