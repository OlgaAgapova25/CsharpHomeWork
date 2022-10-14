// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 2, 4, 9 -> [1, 2, 5, 7, 19, 2, 4, 9 ]
// 6, 1, 33, 2, 93, 15, 424, 0-> [6, 1, 33, 2, 93, 15, 424, 0]

Console.Clear();
PrintArray(FillArray());

int[] FillArray ()
{
    int number = 8;
    int[] arr = new int[number];
    int length = number;
    int index = 0;
    while (index < length)
    {
        arr[index] = new Random().Next(1,100);
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
        Console.Write($"{array[index]}  ");
    }
    Console.WriteLine();
}

