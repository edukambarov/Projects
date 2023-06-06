// Задача 43: Напишите программу, 
// которая найдёт точку пересечения двух прямых,
//  заданных уравнениями 
//  y = k1 * x + b1, 
//  y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// y  = (k2*b1 - k1*b2)/(k2-k1)
// x = (y - b1)/k1

Console.WriteLine("Прямые можно представить в виде уравнения  y = k * x + b.");
double b1 = FromStringToDouble("Введите параметр (константу) b для первой прямой: ");
double k1 = FromStringToDouble("Введите коэффициент k для первой прямой: ");
double b2 = FromStringToDouble("Введите параметр (константу) b для второй прямой: ");
double k2 = FromStringToDouble("Введите коэффициент k для второй прямой: ");
// double y = FindIntersectionCoordinateY(k1, k2, b1, b2);
// double x = FindIntersectionCoordinateX(y, k1, b1);
double x = FindIntersectionX(k1, k2, b1, b2);
double y = FindIntersectionY(x, k1, b1);

if (CheckInputData (k1, k2, b1, b2))
{
    Console.WriteLine($"Точкой пересечения прямых с заданными b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} является точка с координатами ({Math.Round(x,1)}; {Math.Round(y,1)})");
}

double FromStringToDouble(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    double result1 = Convert.ToDouble(value);
    return result1;
}

// y = a* x + c
bool CheckInputData (double a1, double a2, double c1, double c2)
{
    if (a1 == a2)
    {
        if (c1 == c2)
        {
            Console.WriteLine ("Прямые совпадают.");
            return false;
        }
        else
        {
            Console.WriteLine ("Прямые с заданными коэффициентами параллельны друг другу и не имеют точек пересечения.");
            return false;
        }
    }
    return true;
}

// double FindIntersectionCoordinateY(double a1, double a2, double c1, double c2)
// {
//     double y = (a2 * c1 - a1 * c2) / (a2 - a1);
//     return y;
// }

// double FindIntersectionCoordinateX(double y, double a1, double c1)
// {
//     double x = (y - c1)/a1;
//     return x;
// }

double FindIntersectionX(double a1, double a2, double c1, double c2)
{
    double x = (c2 - c1) / (a1 - a2);
    return x;
}

double FindIntersectionY(double x, double a1, double c1)
{
    double y = a1 * x + c1;
    return y;
}