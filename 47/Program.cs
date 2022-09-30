// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
double[,] CreateMatrix(int m, int n){
    double [,]matrix = new double [m,n];// m и n - строки и столбцы по условию
    for (int i =0;i<matrix.GetLength(0); i++){
         for (int j = 0; j < matrix.GetLength(1); j++) {
            matrix[i, j] = new Random().NextDouble(); 
    }
}
return matrix;
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]:f1}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
PrintArray(CreateMatrix(3,4));