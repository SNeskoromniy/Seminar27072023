/*Задача 26: Напишите программу, которая
принимает на вход число и выдаёт количество цифр
в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

int num = GetNumberFromUser();
int count = GetCountDigits(num);
Console.Write($"Количество символов в числе {num} равно: {count}");

// -------------------------Определение методов ---------------------------------
// Определяем функцию, выполняющую ввод целого числа с консоли
static int GetNumberFromUser()
{
    while (true)
    {
        try
        {
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine() ?? "");
            return num;
        }
        catch (Exception exc)
        {
            Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        }
    }
}
static int GetCountDigits(int num)
{
    int count = 0;
    while (num != 0)
    {
        count++;
    num = num / 10;
    }
    return count;
}

