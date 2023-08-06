/*Задача 32: Напишите программу замены элементов массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
*/

Console.Clear();

int[] array = GetArray(12, -9, 9);
Console.WriteLine(string.Join(" ", array));

int[] replace = GetReplace(array);
Console.WriteLine(string.Join(" ", replace));

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

//Метод расчета суммы положительных чисел 
int[] GetReplace(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
    return arr;
}