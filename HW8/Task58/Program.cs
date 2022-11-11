// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// (посмотрите как реализуется произведение матриц, там не просто перемножение элемент на элемент)
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
Main();

void Main()
{
    int i = 2;
    int j = 2;
    int k = 2;
    int[,] matrixA = FillArray(i, j, 1, 5);
    int[,] matrixB = FillArray(j, k, 1, 5);
    PrintArray(matrixA);
    Console.WriteLine();
    PrintArray(matrixB);
    Console.WriteLine();
    int[,] result = MatrixProduction(matrixA, matrixB);
    PrintArray(result);

}

int[,] FillArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    int rowsNumber = array.GetLength(0);
    int columnsNumber = array.GetLength(1);
    for (int i = 0; i < rowsNumber; i++)
    {
        for (int j = 0; j < columnsNumber; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] MatrixProduction(int[,] matrix1, int[,] matrix2)
{
    int rows1 = matrix1.GetLength(0);
    int columns1 = matrix1.GetLength(1);
    int columns2 = matrix2.GetLength(1);
    int[,] result = new int[rows1, columns2];
    for (int i = 0; i < rows1; i++)
    {
        for (int k = 0; k < columns2; k++)
        {
            int sum = 0;
            for (int j = 0; j < columns1; j++)
            {
                sum += matrix1[i,j] * matrix2 [j,k];
                result[i,k] = sum;
            }
        }

    }
    return result;
}
