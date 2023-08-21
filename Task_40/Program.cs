/*
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать
треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон.
*/

int[] array = new int[3];
Console.WriteLine("ВВЕДИТЕ длину первой стороны треугольника");
array[0] = GetNumberFromUser();
Console.WriteLine("ВВЕДИТЕ длину второй стороны треугольника");
array[1] = GetNumberFromUser();
Console.WriteLine("ВВЕДИТЕ длину третьей стороны треугольника");
array[2] = GetNumberFromUser();

bool result = IsTriangle(array);
Console.WriteLine($"результат проверки: {result}");


//Метод

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


//
bool IsTriangle(int[] array)
{
    if (array[0] > array[1] + array[2]) return false;
    if (array[1] > array[0] + array[2]) return false;
    if (array[2] > array[1] + array[0]) return false;
    return true;
}
