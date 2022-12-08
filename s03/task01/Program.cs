// task16
// Console.Clear();
// Console.WriteLine("Введите X");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Y");
// double y = Convert.ToDouble(Console.ReadLine());

// while(x == 0)
// {
//     Console.WriteLine("Вы ошиблись, введите X");
//     double x = Convert.ToDouble(Console.ReadLine());
// }

// while(y == 0)
// {
//     Console.WriteLine("Вы ошиблись, введите Y");
//     double y = Convert.ToDouble(Console.ReadLine());
// }

// if (x > 0 && y > 0)
//     Console.WriteLine("I");
// else if (x < 0 && y > 0)
//     Console.WriteLine("II");
// else if (x < 0 && y < 0)
//     Console.WriteLine("III");
// else
//     Console.WriteLine("IV");


// task17
// Console.Clear();
// Console.WriteLine("Введите номер четверти: ");
// int x = Convert.ToInt32(Console.ReadLine());

// if (x == 1)
//     {
//     Console.WriteLine("X>0");
//     Console.WriteLine("Y>0");
//     }

// else if (x == 2)
//     {
//     Console.WriteLine("X>0");
//     Console.WriteLine("Y<0");
//     }

// else if (x == 3)
//     {
//     Console.WriteLine("X<0");
//     Console.WriteLine("Y>0");
//     }

// else if (x == 4)
//     {
//     Console.WriteLine("X<0");
//     Console.WriteLine("Y<0");
//     }

// else 
//     Console.WriteLine("Неверный ввод");


// task21

// Console.Clear();
// Console.WriteLine("Введите X первой точки");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Y первой точки");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите X второй точки");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Y второй точки");
// double y2 = Convert.ToDouble(Console.ReadLine());

// double dist = Math.Sqrt((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2));
// double dist = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2));

// Console.WriteLine(Math.Round(dist,2));

// task22
Console.Clear();
Console.Write("Введите число (N): ");
int n = Convert.ToInt32(Console.ReadLine());

int step = 1;

Console.WriteLine("N -> N^2");

while (step<=n)
{
    Console.WriteLine($"{step} -> {step*step}");
    step++;
}