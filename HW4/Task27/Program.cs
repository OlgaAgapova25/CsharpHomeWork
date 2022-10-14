// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine(Task27Result(DigitsCalculation(NumberInput())));

int NumberInput()
{
    Console.WriteLine("print an integer: ");
    int number = Math.Abs(int.Parse(Console.ReadLine()));
    return number;
}

int[] DigitsCalculation(int number)
{
    int number_of_digits = 0;
    int number_ = number;
    while (number_ >= 1)
    {
        number_ /=10;
        number_of_digits++;
    }
    int[] digits_mirror = new int[number_of_digits];
    int index = 0;
    while(index < number_of_digits)
    {
        digits_mirror[index] = number % 10;
        number /= 10;
        index++;
    }
    return digits_mirror;
}

int Task27Result(int[] digits)
{
    int sum = 0;
    int index = 0;
    while (index < digits.Length)
    {
        sum += digits[index];
        index++;
    }
    return sum;
}