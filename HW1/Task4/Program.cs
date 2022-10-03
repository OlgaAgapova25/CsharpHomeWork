Console.Write ("Print first number: ");
int Number0 = int.Parse(Console.ReadLine());
Console.Write ("Print second number: ");
int Number1 = int.Parse(Console.ReadLine());
Console.Write ("Print third number: ");
int Number2 = int.Parse(Console.ReadLine());
if (Number0 > Number1 & Number0 > Number2)
{
    Console.WriteLine(Number0);
}
if (Number1 > Number0 & Number1 > Number2)
{
    Console.WriteLine(Number1);
}
if (Number2 > Number1 & Number2 > Number0)
{
    Console.WriteLine(Number2);
}