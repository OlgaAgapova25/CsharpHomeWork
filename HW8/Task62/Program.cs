// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
Main();

void Main()
{
int rowsNumber = 4;
int columnsNumber = 4;
int[,] array = new int[rowsNumber, columnsNumber];
int[,] fillOrder = FillOrder(array);
int startValue = 1;
int[,] snailArray = FillValues(array, fillOrder, startValue);
PrintArray(snailArray);
}

int[,] FillOrder (int[,] array)
{
int m = array.GetLength(0);
int n = array.GetLength(1);
int[] qi = new int[m*n];
int[] qj = new int[m*n];

int i = 0;
int j = 0;
int k = 0;
qi[k] = i;
qj[k] = j;
int count = 0;
int snailSize = m*n;
while (k < snailSize)
{
while (j+1 < n - count && k+1 < snailSize)
{
    j++;
    k++;
    qi[k] = i;
    qj[k] = j;
}
while (i+1 < m - count  && k+1 < snailSize)
{
    i++;
    k++;
    qi[k] = i;
    qj[k] = j;
}
while (j-1 >= 0 + count  && k+1 < snailSize)
{
    j--;
    k++;
    qi[k] = i;
    qj[k] = j;
}
while (i-1 > 0 + count  && k+1 < snailSize)
{
    i--;
    k++;
    qi[k] = i;
    qj[k] = j;
}
if (k+1 >= snailSize) break;
else count++;
}

int[,] qij = new int[2, k+1];  //new array containing order of snail filling. 2 rows: 1st row - i indexes, 2nd row - j indexes.
    
    for (int b = 0; b < k+1; b++)
    {
        qij[0, b] = qi[b];
        qij[1, b] = qj[b];
    }
    return qij;
}

int[,] FillValues (int[,] array, int[,] coordinates, int startValue)
{
    int coordLength = coordinates.GetLength(1);
    int i = 0;
    
    while (i < coordLength)
    {
        array[coordinates[0, i], coordinates[1, i]] = startValue;
        startValue++;
        i++;
    }
    return array;
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