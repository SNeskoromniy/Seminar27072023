/* Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным
элементом массива*/

Console.Clear();
//Формируем массив
double[] array = GetDoubleNumbersArray(10, 0, 10, 3); //размер массива, диапазон значений массива, кол-во знаков после запятой
Console.WriteLine(string.Join(" ", array));
// Выводим минимальное число массива
double min = GetMinNumber(array);
Console.WriteLine($"минимальное число массива: {min}");
// выводим максимальное число массива
double max = GetMaxNumber(array);
Console.WriteLine($"максимальное число массива: {max}");
//Расчет разности между max и min
double result = max - min;
//Console.WriteLine($"минимальное число: {min}, максимальное число {max}, разница равна: {result} ");
Console.WriteLine($"разница чисел равна: {result} ");

//------- Конец программы----------


// объявление методов
// Метод заполнения массива случайными вещественными числами с округлением до 2 знаков после запятой
double[] GetDoubleNumbersArray(int size, double minValue, double maxValue, int round)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = Math.Round((new Random().NextDouble() * (maxValue - minValue)), round);
    }
    return res;
}

//Метод поиска минимального числа
double GetMinNumber(double[] array)
{
    double min = array[0];
    double max = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        //if (array[i] > max) max = array[i];

    }
    return min;
}

//Метод поиска максимального числа
double GetMaxNumber(double[] array)
{
    double max = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

/* Метод получения разницы между максимальным и минимальным элементом массива
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
*/