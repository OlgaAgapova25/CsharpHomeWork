// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Введите координату X точки A: ");
double Ax = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y точки A: ");
double Ay = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Z точки A: ");
double Az = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату X точки B: ");
double Bx = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B: ");
double By = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Z точки B: ");
double Bz = double.Parse(Console.ReadLine());
double distance = Math.Round(Math.Sqrt(Math.Pow((Ax-Bx),2)+Math.Pow((Ay-By),2)+Math.Pow((Az-Bz),2)),2);
Console.WriteLine($"{distance}");