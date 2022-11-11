// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

Console.Clear();
Main();

void Main()
{
    int rows = 3;
    int columns = 2;
    int minValue = 1;
    int maxValue = 10;
    int[,] array = FillArray(rows, columns, minValue, maxValue);
    PrintArray(array);
    Console.WriteLine();
    int[] sums = RowsSumCalculation(array);
    foreach (int el in sums) Console.Write($"{el} "); //left to make check easier
    Console.WriteLine();
    int minSumRowNumber = MinSumRowNumber(sums);
    Console.WriteLine($"Row where sum of elements is minimal is {minSumRowNumber+1}");
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

int[] RowsSumCalculation(int[,] array)
{
    int[] rowsSums = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        rowsSums[i] = sum;
    }
    return rowsSums;
}

int MinSumRowNumber(int[] rowsSums)
{
    int min = rowsSums[0];
    int minSumRowNumber = 0;
    for (int i = 1; i < rowsSums.Length; i++)
    {
        if (rowsSums[i] < min)
        { 
            min = rowsSums[i];
            minSumRowNumber = i;
        }
    }
    return minSumRowNumber;
}