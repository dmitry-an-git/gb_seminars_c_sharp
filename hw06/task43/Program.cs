// task 43

// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

double ask_for_input(string message)
{
    Console.Write($"{message}: ");
    double z = Convert.ToDouble(Console.ReadLine());
    return z;
}

double[] intersection(double k1, double b1, double k2, double b2)
 
// k1*x+b1 = k2*x+b2 => x = (b2-b1)/(k1-k2); y = x*k1 + b1

{
    double x = (b2-b1)/(k1-k2);
    double y = x*k1 + b1;
    double[] ans = new double[2];
    ans[0] = x;
    ans[1] = y;
    return ans;
}

// y = a*x + b
double k1 = ask_for_input("Введите параметр k1");
double b1 = ask_for_input("Введите параметр b1");
double k2 = ask_for_input("Введите параметр k2");
double b2 = ask_for_input("Введите параметр b2");

if (k1 == k2)
    if (b1 == b2)
        Console.WriteLine("Прямые совпадают");
    else
        Console.WriteLine("Прямые параллельны и не пересекаются");
else
    Console.WriteLine($"({string.Join("; ", intersection(k1, b1, k2, b2))})");