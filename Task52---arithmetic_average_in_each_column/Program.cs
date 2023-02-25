// Задача 52: Задайте двумерный массив из целых чисел. 
//     Найдите среднее арифметическое элементов в каждом столбце.
//         Например, задан массив:
//             1 4 7 2
//             5 9 2 3
//             8 4 2 4
//         Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetRandomMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 11);
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            System.Console.Write(matrix[i, j] + "\t");
        System.Console.WriteLine();
    }
}

double[] ArithmeticAaverageColumns(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    double[] arithMatrix = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        arithMatrix[j] = matrix[0, j];
        for (int i = 1; i < matrix.GetLength(0); i++)
            arithMatrix[j] += matrix[i, j];
    }
    for (int j = 0; j < arithMatrix.Length; j++)
        arithMatrix[j] = Math.Round((arithMatrix[j] / rows), 1);
    return arithMatrix;
}

var theMatrix = GetRandomMatrix(new Random().Next(2, 5), new Random().Next(3, 7));
PrintMatrix(theMatrix);
double[] averageMatrix = ArithmeticAaverageColumns(theMatrix);
System.Console.WriteLine("--\t--\t--\t--\t--\t--");
System.Console.WriteLine($"{string.Join("\t", averageMatrix)} - среднее арифметическое каждого столбца");
System.Console.WriteLine($"Среднее арифметическое каждого столбца: {string.Join("; ", averageMatrix)}.");
System.Console.WriteLine();