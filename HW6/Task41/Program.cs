// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Main(5);

void Main(int M)
{
Console.Clear();
double[] array = UserNumbers(M);
PrintArray(array);
PositiveNumbersCalculation(array);
}

double NumberInput()
{
Console.WriteLine("print a number: ");
double number = double.Parse(Console.ReadLine());
return number;
}

double[] UserNumbers(int size)
{
    double[] userNumbers = new double[size];
    for (int i=0; i < size; i++)
    {
        userNumbers[i] = NumberInput();
    }
    return userNumbers;
}

void PrintArray (double[] array)
{
    int index = 0;
    while (index < array.Length)
    {
        Console.Write($"{array[index]}  ");
        index++;
    }
}

void PositiveNumbersCalculation(double[] arr)
{
    int count = 0;
    foreach (double el in arr)
    {
        if (el > 0) count ++;
    }
    Console.Write($"-> {count}");
}
