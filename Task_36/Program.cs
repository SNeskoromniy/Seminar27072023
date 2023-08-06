/*Задача 36: Задайте одномерный массив, заполненный
случайными числами. Найдите сумму элементов, стоящих
на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.Clear();

int[] array = GetArray(6, -20, 20);
Console.WriteLine(string.Join(" ", array));

int sum = GetSumNotEnenElementArray(array);
Console.WriteLine($"Сумма не четных элементов массива равна: {sum}");

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

//Метод расчета суммы элементов массива, соящих на не четных позициях 
int GetSumNotEnenElementArray(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}
