// Задача 50: Напишите программу, которая 
//     на вход принимает позиции элемента в двумерном массиве, 
//     и возвращает значение этого элемента 
//     или же указание, что такого элемента нет.
//         Например, задан массив:
//             1 4 7 2
//             5 9 2 3
//             8 4 2 4
//         17 -> такого числа в массиве нет

int[,] GetRandomMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-24, 24);
    }
    return matrix;
}

void MatrixReloaded(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            System.Console.Write(matrix[i, j] + "\t");
        System.Console.WriteLine();
    }
}

void FindTrinity(int[,] matrix, int rows, int cols)
{
    if (rows <= matrix.GetLength(0) && cols <= matrix.GetLength(1))
        System.Console.WriteLine($"Белый кролик прибыл {matrix[rows - 1, cols - 1]} лет назад");
    else
    {
        System.Console.WriteLine("И снова у матрицы сбой: Убили опять Тринити");
        System.Console.WriteLine("Морфеус не слишком худой, и Нео летит впеpеди!");
    }
}

System.Console.Write("Введите № строки и № столбца Матрицы через ПОБЕЛ: ");
int[] lazyWrite = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int Morpheus = Math.Abs(lazyWrite[0]);
int Neo = Math.Abs(lazyWrite[1]);

var theMatrix = GetRandomMatrix(new Random().Next(1, 10), new Random().Next(1, 10));
MatrixReloaded(theMatrix);
FindTrinity(theMatrix, Morpheus, Neo);