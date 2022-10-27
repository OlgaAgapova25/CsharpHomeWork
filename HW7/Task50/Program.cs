// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет ([1,7] это позиция элемента)

Console.Clear();
Main();

void Main()
{
    int rows = 3;
    int columns = 4;
    int minValue = -10;
    int maxValue = 10;
    Console.WriteLine("print row number: ");
    int rowIndex = int.Parse(Console.ReadLine());
    Console.WriteLine("print column number: ");
    int columnIndex = int.Parse(Console.ReadLine());
    double[,] array = FillArray(rows, columns, minValue, maxValue);
    PrintArray(array);
    Console.WriteLine();
    PositionCheck(array, rowIndex, columnIndex);
}

void PositionCheck(double[,] array, int rowId, int columnId)
{
    if (rowId < array.GetLength(0) && columnId < array.GetLength(1))
    {
        Console.WriteLine($"{array[rowId, columnId]}");
    }
    else
    {
        Console.WriteLine("This position doesn't exist");
    }
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
