// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Main();

void Main()
{
    Console.Clear();
    double[] coeffs = CoefValues();
    double x = Xcalculation (coeffs);
    double y = Ycalculation (coeffs, x);
    Console.Write($"({x}; {y})");
}

double[] CoefValues()
{
    string[] coefNames = { "k1", "b1", "k2", "b2" };
    double[] coefs = new double[coefNames.Length];
    for (int i = 0; i < coefNames.Length; i++)
    {
        Console.WriteLine($"print {coefNames[i]}: ");
        double number = double.Parse(Console.ReadLine());
        coefs[i] = number;
    }
    return coefs;
}

double Xcalculation (double[] values)
{
    double k1 = values [0];
    double b1 = values [1];
    double k2 = values [2];
    double b2 = values [3];
    double x = (b2 - b1)/ (k1 - k2);
    return x;
}

double Ycalculation (double[] values, double x)
{
    double k1 = values [0];
    double b1 = values [1];
    double y = k1 * x + b1;
    return y;
}