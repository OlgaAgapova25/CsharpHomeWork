// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Main();

void Main()
{
    int m = InputM();
    int n = InputN();
    if (m > n) 
    {
        int temp = m;
        m = n;
        n = temp;
    }
    Console.WriteLine(Sum(m,n));
}

int InputM()
{
    Console.WriteLine("Print first number: ");
    int m = int.Parse(Console.ReadLine());
    return m;
}

int InputN()
{
    Console.WriteLine("Print second number: ");
    int n = int.Parse(Console.ReadLine());
    return n;
}

int Sum (int a, int b)
{
    if (a == b) return a;
    return a + Sum (a+1, b);   
}