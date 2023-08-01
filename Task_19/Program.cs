/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Clear();

int num;

while (true)
{
    try
    {
        Console.WriteLine("Введите пятизначное число: ");
        num = int.Parse(Console.ReadLine() ?? "");
        break;
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
    }

}

if (num < 10000 || num > 99999)
{
    Console.WriteLine("Число не является пятизначным");
}
else
{
    int sim1 = num / 100;
    int simTMP = num % 1000;
    int sim2 = (simTMP % 10 * 100) + (simTMP / 10 % 10) * 10 + (simTMP / 100);
    if (sim1 == sim2)
        Console.WriteLine($"Число {num} палиндром");
    else
        Console.WriteLine($"Число {num} не палиндром");
}

