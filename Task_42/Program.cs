/*
Задача 42 Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
*/
Console.Clear();

int num = GetNumberFromUser();
int[] array = GetBinaryNum(num);
Console.WriteLine(String.Join("", array));


//метод ввода числа
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

//Метод получения двоичного значения числа
int[] GetBinaryNum(int num)
{
    int count = 0;
    int temp = num;
    while (temp > 0) // считаем размер массива
    {
        temp = temp / 2;
        count++;
    }
    int[] result = new int[count];

    int i = result.Length - 1;

    while (num > 0) // получаем двоичное значение числа
    {
        result[i] = num % 2;
        num = num / 2;
        i--;
    }
    return result;
}
