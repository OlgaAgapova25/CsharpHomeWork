// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
Main();

void Main()
{
    int rows = 3;
    int columns = 4;
    int minValue = -10;
    int maxValue = 10;
    double[,] array = FillArray(rows, columns, minValue, maxValue);
    PrintArray(array);
}

double[,] FillArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue) + Math.Round(new Random().NextDouble(), 1);
        }
    }
    return result;
}

void PrintArray(double[,] array)
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

