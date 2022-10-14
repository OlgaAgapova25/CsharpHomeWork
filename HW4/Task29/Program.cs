// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 2, 4, 9 -> [1, 2, 5, 7, 19, 2, 4, 9 ]
// 6, 1, 33, 2, 93, 15, 424, 0-> [6, 1, 33, 2, 93, 15, 424, 0]

Console.Clear();
int number_of_elements = 8;
int minimal_value = 1;
int maximal_value = 100;
PrintArray(FillArray(number_of_elements, minimal_value, maximal_value));

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