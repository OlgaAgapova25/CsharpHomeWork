// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
int numberOfElements = 5;
int minValue = 10;
int maxValue = 100;

double[] array = FillArray (numberOfElements, minValue, maxValue);
PrintArray(array);
Console.WriteLine($" -> {Main (MinElement(array), MaxElement(array))}");


double[] FillArray (int number, int min, int max)
{
    double[] numbers = new double[number];
    Random rnd = new Random();
    for (int i = 0; i < number; i++)
    {
        numbers[i] = Math.Round(rnd.NextDouble(),2) + rnd.Next(min,max);
    }
    return numbers;
}

void PrintArray(double[] array)
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

double MaxElement (double[] array)
{
    double maxElement = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxElement)
        {
            maxElement = array[i];
        }
    }
    return maxElement;
}

double MinElement (double[] array)
{
    double minElement = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minElement)
        {
            minElement = array[i];
        }
    }
    return minElement;
}

double Main (double min, double max)
{
    double dif = max - min;
    return dif;
}