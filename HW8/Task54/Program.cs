// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
Main();

void Main()
{
    int rows = 3;
    int columns = 4;
    int minValue = 1;
    int maxValue = 10;
    double[,] array = FillArray(rows, columns, minValue, maxValue);
    PrintArray(array);
    double[,] sortedArray = SortedArray(array);
    Console.WriteLine();
    PrintArray(sortedArray);
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

double[,] SortedArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j+1; k < array.GetLength(1); k++)
            {
            if (array[i,k] > array[i,j]) 
            {
                double temp = array[i,j];
                array[i,j] = array [i, k];
                array[i, k] = temp;
            }
            }
        }
    }
    return array;
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