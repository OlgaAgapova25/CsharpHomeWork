//  Напишите программу, которая принимает на вход трёхзначное число 
//  и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Print 3-digit number: ");
int Number = int.Parse(Console.ReadLine());
int Symbol2 = Number / 10 % 10;
Console.Write(Symbol2);