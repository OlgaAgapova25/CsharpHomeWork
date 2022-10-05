// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Clear();
Console.Write("Print a number: ");
int Number = Math.Abs(int.Parse(Console.ReadLine()));
if (Number < 100) Console.Write("There's no third digit");
else
{
    while (Number >=1000)
    {
        Number = Number/10;
    }
int Symbol3 = Number%10;
Console.Write(Symbol3);
}