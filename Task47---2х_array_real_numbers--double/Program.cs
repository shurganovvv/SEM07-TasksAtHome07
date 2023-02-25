// Задача 47: Задайте двумерный массив размером m×n, 
//     заполненный случайными вещественными числами.
//         m = 3, n = 4.
//             0,5 7 -2 -0,2
//             1 -3,3 8 -9,9
//             8 7,8 -7,1 9

double[,] GetMatrix(int rows, int cols)
{
    double[,] matrix = new double[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-37, 37) + Math.Round(new Random().NextDouble(), 1);
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            System.Console.Write(matrix[i, j] + "\t");
        System.Console.WriteLine();
    }
}

System.Console.Write("Введите количество строк и столбцов Матрицы через ПОБЕЛ: ");
int[] lazyWrite = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int m = Math.Abs(lazyWrite[0]);
int n = Math.Abs(lazyWrite[1]);
double[,] theMatrix = GetMatrix(m, n);
PrintMatrix(theMatrix);