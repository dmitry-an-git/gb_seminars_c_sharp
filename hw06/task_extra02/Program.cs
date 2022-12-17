// task extra 02

// area of a triangle
// 2 1 2 4 6 1	- 6
// 0 0 0 3 3 0	- 4.5

Console.Clear();

double ask_for_input(string message)
{
    Console.Write($"{message}: ");
    double z = Convert.ToDouble(Console.ReadLine());
    return z;
}

double area(double x1, double x2, double x3, double y1, double y2, double y3)

{
    double length(double x1, double x2, double y1, double y2)
    {
        double length = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
        return length;
    }

    double first = length(x1, x2, y1, y2);
    double second = length(x1, x3, y1, y3);
    double third = length(x2, x3, y2, y3);

    double p = (first+second+third)/2;

    double ans = Math.Sqrt(p*(p-first)*(p-second)*(p-third));
    return ans;
    
}

// y = a*x + b
double x1 = ask_for_input("Введите параметр x1");
double y1 = ask_for_input("Введите параметр y1");
double x2 = ask_for_input("Введите параметр x2");
double y2 = ask_for_input("Введите параметр y2");
double x3 = ask_for_input("Введите параметр x3");
double y3 = ask_for_input("Введите параметр y3");

Console.WriteLine(area(x1,x2,x3,y1,y2,y3));
