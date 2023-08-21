//Число Фибоначчи

// Вводим
int num = GetNumberFromUser();

int[] array = GetFibbanachiArray(num);
Console.WriteLine(String.Join("", array));

int[] GetFibbanachiArray(int num)
{
    if (num <= 0) throw new Exception("Ошибка ввода положительного числа");
    int[] array = new int[num];
    array[0] = 0;
    if (num == 1) return array;
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;

}

//
static int GetNumberFromUser()
{
    while (true)
    {
        try
        {
            Console.Write("Введите целое положительное число: ");
            int num = int.Parse(Console.ReadLine() ?? "");
            return num;
        }
        catch (Exception exc)
        {
            Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        }
    }
}