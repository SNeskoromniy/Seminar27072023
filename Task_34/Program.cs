/*Задача 34: Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве.
[345, 897, 568, 234] -> 2*/

Console.Clear();

int[] array = GetArray(12, 100, 999);
Console.WriteLine(string.Join(" ", array));

int count = GetCountEnenNumberArray(array);
Console.WriteLine($"Количество четных чисел в массиве: {count}");

// объявление методов
// Метод заполнения массива случайными трехзначными числами 0 и 1
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

//Метод расчета количества четных чисел 
int GetCountEnenNumberArray(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    return count;
}