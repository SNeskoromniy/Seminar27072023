/*
Заполнение матрицы случайными числами
*/

Console.Clear();



//Инициализация массива 
int[,] matrix = new int[3, 4];
//ПЕчатае пустой массив
PrintArray(matrix);
//Заполняем массив случайными числами
FillArray(matrix);
Console.WriteLine();
//Печать массива заполненного случайными числами
PrintArray(matrix);


//Метод печати массива
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
//Метод заполнения массива случайными числами от 1 до 9
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);//[1; 10)
        }
    }
}


