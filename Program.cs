// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void FindAPoint(double b1, double b2, double k1, double k2)
{
    double x = (b2 - b1)/(k1-k2);
    double y = (k1 * x) + b1;
    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y})");
}

double GetInput(string text)
{
    Console.WriteLine(text);
    return Convert.ToDouble(Console.ReadLine());
}

double b1 = GetInput("Введите значение b1: ");
double b2 = GetInput("Введите значение b2: ");
double k1 = GetInput("Введите значение k1: ");
double k2 = GetInput("Введите значение k2: ");
FindAPoint(b1, b2, k1, k2);