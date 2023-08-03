/*Задача 25: Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B.*/

int a = GetNumberFromUser("Введите число А", "введите целое число");
int b = GetNumberFromUser("Введите число В", "введите целое число");
int result = GetStepen(a, b);

Console.WriteLine($"Число {a} в степени {b} равно: {result} ");


// -------------------------Определение методов ---------------------------------
//Определяем функцию возведения числа А в степень В
int GetStepen(int a, int b )
{
int result = a;
for (int i = 0; i < b-1; i++)
{
    result = result * b;
}
return result;
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