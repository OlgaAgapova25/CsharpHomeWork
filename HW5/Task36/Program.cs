// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int numberOfElements = 10;
int minValue = - 1000;
int maxValue = 1000;

int[] array = FillArray(numberOfElements, minValue, maxValue);
PrintArray(array);
if (numberOfElements < 2)
    {
        Console.WriteLine("Check the array length");
    }
    else
    {
        Console.WriteLine($" -> {Main(array)}");
    }


int[] FillArray (int number, int min, int max)
{
    int[] arr = new int[number];
    int length = number;
    int index = 0;
    while (index < length)
    {
        arr[index] = new Random().Next(min,max+1);
        index++;
    }
    return arr;
}

void PrintArray(int[] array)
{
    int index = 0;
    int length = array.Length;
    while (index < length)
    {
        if (index == 0) Console.Write($"[{array[index]}, ");
        else if (index == length - 1) Console.Write($"{array[index]}]");
        else Console.Write($"{array[index]}, ");
        index++;
    }
}

int Main(int[] array)
{
    int index = 1;
    int sum = 0;
    while (index < array.Length)
    {
        sum += array [index]; 
        index += 2;
    }
    return sum;
}