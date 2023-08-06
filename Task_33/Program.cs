/*
Задача 33: Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве.*/

Console.Clear();

int[] array = GetArray(12, 0, 9);
Console.WriteLine(string.Join(" ", array));

int num = GetNumberFromUser();

bool result = FindNumber(array, num);

Console.WriteLine($"число {num} = {(result ? "ДА" : "НЕТ")}");



// объявление методов
// Метод заполнения массива случайными числами 0 и 1
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

// Определяем функцию, выполняющую ввод целого числа с консоли
static int GetNumberFromUser()
{
    while (true)
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

//Функция поиска числа в массиве

bool FindNumber(int[] arr, int num)
{
    bool result = false;
    foreach (var el in array)
    {
        if (el == num) result = true;
    }
    return result;
}

