// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Task19Result();

void Task19Result()
{
    int[] array = DigitsIdentification();
    if (array[0] == 0 || array[0] > 9)
    {
        Console.WriteLine("error: you've entered not a 5-digits number");
    }
    else
    {
        if (array[0] == array[4] && array[1] == array[3])
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

int NumberInput()
{
    Console.WriteLine("Print 5-digit number: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[] DigitsIdentification()
{
    int number = NumberInput();
    int s1 = number / 10000;
    int s2 = (number / 1000) % 10;
    int s3 = (number / 100) % 10;
    int s4 = (number / 10) % 10;
    int s5 = (number % 10);
    int[] array = { s1, s2, s3, s4, s5 };
    return array;
}

// Console.Clear();
// Console.WriteLine("Print 5-digit number: ");
// int number = int.Parse(Console.ReadLine());
// int S1 = number / 10000;
// int S2 = (number / 1000) % 10;
// int S3 = (number / 100) % 10;
// int S4 = (number / 10) % 10;
// int S5 = (number % 10);
// if (S1 == 0 || S1 > 9)
// {
//     Console.WriteLine("you've entered not a 5-digit number");
// }
// else
// {
//     if (S1 == S5 && S2 == S4)
//     {
//         Console.WriteLine("Yes");
//     }
//     else
//     {
//         Console.WriteLine("No");
//     }
// }