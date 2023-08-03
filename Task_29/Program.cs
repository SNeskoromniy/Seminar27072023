/*
Задача 29: Напишите программу, которая задаёт массив
из 8 элементов и выводит их на экран.
*/
PrintArr(GenRandomArr(8));


// объявление методов
// Метод заполнения массива случайными числами 0 и 1
int[] GenRandomArr(int count)
{
    int[] arr = new int[count];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = GetNumberFromUser("введите число", "введите целое число");
    }
    return arr;
}

void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }

}

// Определяем функцию, выполняющую ввод целого числа с консоли
static int GetNumberFromUser(string message, string errorMessage)
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