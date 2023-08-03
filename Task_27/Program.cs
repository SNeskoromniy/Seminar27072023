/*Задача 27: Напишите программу, которая принимает на
вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int num = GetNumberFromUser();
int sum = GetSumDigits(num);

Console.Write($"Количество символов в числе {num} равно: {sum}");

// -------------------------Определение методов ---------------------------------
// Определяем функцию, выполняющую ввод целого числа с консоли
static int GetNumberFromUser()
{
    while (true)
    {
        try
        {
            Console.Write("Введите любое целое число: ");
            int num = int.Parse(Console.ReadLine() ?? "");
            return num;
        }
        catch (Exception exc)
        {
            Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        }
    }
}
//Функция расчета количества цифр в числе
static int GetSumDigits(int num)
{
    int sum = 0;
    for (int i = num == 0 ? 0 : 1; num > 0; num /= 10)
    {
        sum += num % 10;
    }

    return sum;
}
