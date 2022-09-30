// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] CreateMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix .GetLength(0); i++)
    {
        for (int j = 0; j < matrix .GetLength(1); j++)
        {
            matrix [i, j] = new Random().Next(0, 11);
        }
    }
    return matrix ;
}

void PrintArray(int[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            System.Console.Write($"{matrixForPrint[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void FindMean(int[,] userMatrix)//ищет среднее арифмитическое в столбце
{
    double arithmeticMean = 0;
    double sumColumns = 0;

    for (int j = 0; j < userMatrix.GetLength(1); j++)
    {
        for (int i = 0; i < userMatrix.GetLength(0); i++)
        {
            sumColumns += userMatrix[i, j];
        }
        arithmeticMean = sumColumns / userMatrix.GetLength(0);
        Console.WriteLine($" Среднее арифметическое элементов столбца {j + 1} = {arithmeticMean:F2}");
        sumColumns = 0;
    }
}

int rows = Prompt("Введите количество строк");
int columns = Prompt("Введите количество столбцов");
int[,] myMatrix = CreateMatrix(rows, columns);
PrintArray(myMatrix);
FindMean(myMatrix);

