// Вывести первые N строк треугольника
// Паскаля. Сделать вывод в виде равнобедренного
// треугольника

Console.Clear();
Main();

void Main()
{
int N = 5;
int[,] pascalTriangle = FillPascalTriangle(N);
PrintArray(pascalTriangle);
}

int[,] FillPascalTriangle (int N)
{
int[,] triangle = new int[N, N*2-1];

triangle[0,N-1] = 1;
for (int i = 1; i < N; i++)
{
    for (int j = N-1; j >= 0; j--)
    {
        if (j == 0) triangle [i,j] = triangle[i-1, j+1];
        else
        {
            triangle[i,j] = triangle[i-1,j+1] + triangle[i-1,j-1];
        }
    }
    for (int j = N; j < N*2-1; j++)
    {
        if (j == N*2-2) triangle [i,j] = triangle[i-1, j-1];
        else
        {
            triangle[i,j] = triangle[i-1,j+1] + triangle[i-1,j-1];
        }
    }
}
return triangle;
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