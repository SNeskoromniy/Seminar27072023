/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
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

for (int i = 1; i <= num; i++)
{
    Console.Write($" куб числа {i} равен: {i * i * i}");
    Console.WriteLine();
}