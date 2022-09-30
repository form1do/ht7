// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
int[,] GenerateArray(int rows, int colums)
{
    int[,] array = new int[rows, colums];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 11);
        }
    }
    return array;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

bool FindPositinOnArray(int [,]array, int row, int column)
{
    int searchRow = row-1;
    int searchColumns = column-1;
    bool position = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == searchRow && j == searchColumns)
            {
                position = true;
            }
        }
    }
    return position;
}
System.Console.WriteLine("Ввидете колчество строк в массиве");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Ввидете колчество столбцов в массиве");
int column = Convert.ToInt32(Console.ReadLine());
int[,] UserArray = GenerateArray(row, column);
PrintArray(UserArray);
System.Console.WriteLine("Ввидете строку искомого элемента");
int targetRow = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Ввидете столбец искомого элемента");
int targetColumn = Convert.ToInt32(Console.ReadLine());
if (FindPositinOnArray(UserArray, targetRow, targetColumn))
{
    Console.WriteLine($"Значение элемента  > {UserArray[targetRow-1,targetColumn-1]}");
}
else
{
    Console.WriteLine("Числа нет в массиве");
}