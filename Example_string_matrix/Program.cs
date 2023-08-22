Console.Clear();

//Задаем строковый массив размерностью 2 столбца и 5 строк
string[,] table = new string[5,5];
// String.Empty
// table [0,0] table [0,1] table [0,2] table [0,4]
// table [1,0] table [1,1] table [1,2] table [1,4]

FullMatrix(table);

PrintMatrix(table);

//Печать массива
void PrintMatrix(string[,] table)
{
for (int rows = 0; rows < table.GetLength(0); rows++)
{
 for (int columns = 0; columns < table.GetLength(1); columns++)
 {
 Console.Write($" {table[rows, columns]}");
 }
 Console.WriteLine();
}
}

//Заполняю массив  символом "+"
void FullMatrix(string[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = "+";
        }
    }
}