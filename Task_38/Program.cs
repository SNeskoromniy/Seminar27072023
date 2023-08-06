/* Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным
элементом массива*/

Console.Clear();

double[] array = GetDoubleNumbersArray(4, 5, 10);
Console.WriteLine(string.Join(" ", array));

double result = GetResult(array);
//Console.WriteLine($"минимальное число: {min}, максимальное число {max}, разница равна: {result} ");
Console.WriteLine($"разница чисел равна: {result} ");



//double[] min = GetMinNumber(array);
//Console.WriteLine($"минимальное число массива: {min}");
//double min = GetMaxNumber(array);
//Console.WriteLine($"максимальное число массива: {max}");
//double result = max - min;
//Console.WriteLine($"минимальное число массива: {min}");

//------- Конец программы----------


// объявление методов
// Метод заполнения массива случайными трехзначными числами 0 и 1
double[] GetDoubleNumbersArray(int size, double minValue, double maxValue)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = (new Random().NextDouble() * (maxValue - minValue));
    }
    return res;
}

double GetResult(double[] array)
{
    double min = array[0];
    double max = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];

    }
    double result = max - min;
    return result;
}
