// Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2,"

Console.Clear();
Main();

void Main()
{
    int N = 8;
    if (N % 2 == 1) N--;
    if (N < 2) Console.WriteLine("It's a wrong number: check N.");
    else EvenNumbers(N);
}

void EvenNumbers(int N)
{
    if (N == 2) Console.Write("2");
    else
    {
        Console.Write($"{N} ");
        N -= 2;
        EvenNumbers(N);
    }

}
