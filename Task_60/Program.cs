
#region --- 00. Configuration ---
Console.Clear();
Console.Title = "Задача №60";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"************************************************************************
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить
массив, добавляя индексы каждого элемента.
************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion 

int[,,] array3D = GetArray3D(3, 3, 3, 10, 99);
PrintMatrix(array3D);



int[,,] GetArray3D (int row, int col, int dep, int min, int max) 
{
    int[,,] matrix = new int[row, col, dep];
    Random rnd = new Random();   
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
                {
                    matrix[i,j,k] = rnd.Next(min, max + 1);
                }
        }
    }
    return matrix;
} 
 
void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i <  matrix.GetLength(0); i++)
    {
        //Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
            //Console.Write($"{matrix[i, j, k], 1}|"); 
            Console.Write($"A({i},{j},{k}): {matrix[i, j, k],1}; ");           
            }
        }
        Console.WriteLine();        
    }        
}
