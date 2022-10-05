// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();
Console.Write("Print day number: ");
int DayNumber = int.Parse(Console.ReadLine());
if (DayNumber == 6 || DayNumber == 7) Console.WriteLine("Yes");
else if (DayNumber >= 1 && DayNumber <= 5) Console.WriteLine("No");
else Console.WriteLine("error: Incorrect number");