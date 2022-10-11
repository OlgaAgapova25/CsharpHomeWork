// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Print 5-digit number: ");
int number = int.Parse(Console.ReadLine());
int S1 = number/10000;
int S2 = (number/1000)%10;
int S3 = (number/100)%10;
int S4 = (number/10)%10;
int S5 = (number%10);
if (S1 == S5 && S2 == S4) 
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}