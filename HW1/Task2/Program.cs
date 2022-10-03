Console.WriteLine("Print first number: ");
int Number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Print second number: ");
int Number2 = int.Parse(Console.ReadLine());
if (Number1 > Number2)
{
    Console.WriteLine("max = " + Number1);
}
if (Number2 > Number1)
{
    Console.WriteLine("max = " + Number2);
}
if (Number1 == Number2)
{
    Console.WriteLine ("Numbers are equal.");
}