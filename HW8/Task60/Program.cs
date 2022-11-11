// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();
Main();

void Main()
{
    int i = 2;
    int j = 2;
    int k = 2;
    int[,,] array3D = FillArray(i,j,k,10);
    PrintArray(array3D);
    Console.WriteLine();
}

int[,,] FillArray(int m, int n, int l, int startValue)
{
    int[,,] result = new int[m, n, l];
    
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < l; k++)
            {
                result[i, j, k] = startValue;
                startValue ++;
            }
        }
    }
    return result;
}

void PrintArray(int[,,] array)
{
    int rowsNumber = array.GetLength(0);
    int columnsNumber = array.GetLength(1);
    int depthNumber = array.GetLength(2);
    for (int i = 0; i < rowsNumber; i++)
    {
        for (int j = 0; j < columnsNumber; j++)
        {
            for (int k = 0; k < depthNumber; k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");   
            }
            Console.WriteLine();
        }
    }
}