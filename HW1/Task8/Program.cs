Console.WriteLine("Print a number: ");
int N = int.Parse(Console.ReadLine());
int number = 2;
while (number <= N)
{
    Console.Write(number);
    if(number + 2 <= N)
    {
        Console.Write(", ");
    }
    number = number + 2;
}