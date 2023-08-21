// программа которая перевернет массив


Console.Clear();

int[] array = GetArray(10, 0, 10);
Console.WriteLine(string.Join(" ", array));


int[] reversArray1 = reversArray(array);
Console.WriteLine(string.Join(" ", reverseArray));







// объявление методов
// Метод заполнения массива случайными  числами 0 и 1
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

//Метод получения обратного массива

int[] ReverseArray1(int[] inArray)
{
int[] result = new int[inArray.Length];
for (int i = 0; i < inArray.Length; i++)
{
    result[i] = inArray[inArray.Length - 1 - i];
}
return result;
}

//
void ReverseArray2(int[] inArray)
{
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        int temp = inArray[i];
        inArray[i] = inArray[inArray.Length - i - 1];
        inArray[inArray.Length - 1 - i] = temp;
    }

}
