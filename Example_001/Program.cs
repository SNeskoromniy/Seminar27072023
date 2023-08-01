/* Задача принимает на вход координаты и выдает номер четверти
Console.Clear();

int X;
while (true) // проверка на корректность ввода целого числа
{
Console.WriteLine("ВВЕДИТЕ X: ");
if (int.TryParse(Console.ReadLine(), out X))
    break;
Console.WriteLine("Число не является целым");
}
int Y;
while (true) // проверка на корректность ввода целого числа
{
Console.WriteLine("ВВЕДИТЕ Y: ");
if (int.TryParse(Console.ReadLine(), out Y))
    break;
Console.WriteLine("Число не является целым");
}

Console.Write($"{X},{Y}");*/
Console.Clear();
int X, Y;
static void InitCoordinatesByUser (ref init x, ref init y;
{
try
{
Console.WriteLine("ВВЕДИТЕ X: ");
x = int.Parse(Console.ReadLine()?? "");

Console.WriteLine("ВВЕДИТЕ X: ");
y = int.Parse(Console.ReadLine()?? "");
}

catch(Exception exc)
{
    Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
    return;
}
}



Console.Write($"{X},{Y}");
