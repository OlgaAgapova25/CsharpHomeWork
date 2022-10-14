// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.WriteLine(Task25Result(NumberInput(),DegreeInput()));

double NumberInput ()
{
    Console.WriteLine("print a number: ");
    double number = double.Parse(Console.ReadLine());
    return number;
}

int DegreeInput()
{
    Console.WriteLine("print a degree to apply: ");
    int degree = int.Parse(Console.ReadLine());
    return degree;
}

double Task25Result(double number, int degree)
{
    double result = Math.Pow(number, degree); 
    return result;
}