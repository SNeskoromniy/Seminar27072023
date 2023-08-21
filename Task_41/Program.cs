/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл
пользователь.
*/
int result = 0;
Console.WriteLine("ВВЕДИТЕ количество чисел");
int count = int.Parse(Console.ReadLine() ?? "");
int[] array = new int[count];

// Заполняем массив числами
for (int i = 0; i < array.Length; i++)
{
    array[i] = GetNumberFromUser();
}

result = GetEventNumbers(array);
Console.WriteLine($"Количество четных чисел равно: {result}");

//Метод ввода числа с клавиатуры
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


//метод подсчета четных чисел
int GetEventNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

