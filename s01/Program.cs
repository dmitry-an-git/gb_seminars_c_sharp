// 1 вариант
// int n = Convert.ToInt32(Console.ReadLine());
// 2 вариант
// int n = int.Parse(Console.ReadLine());
// warning means that ReadLine can provide input

// ----
// Console.WriteLine("Введите число: ");
// int n = int.Parse(Console.ReadLine());
// ---- 

// задача про год
// Console.Clear();
// Console.Write("Введите год: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n % 400 == 0 || n % 100 != 0 && n % 4 == 0)
//     Console.WriteLine("yes");
// else
//     Console.WriteLine("no");


// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a == b*b)
// {
//     Console.WriteLine("Первое число есть квадрат второго");
// }
// else
// {
//     Console.WriteLine("Первое число не является квадратом второго");
// }


// task 3
// Console.Write("Введите номер дня недели: ");
// int a = Convert.ToInt32(Console.ReadLine());

// if (a==1)
//     Console.WriteLine("пн");
// else if (a==2)
//     Console.WriteLine("вт"); 
// else if (a==3)
//     Console.WriteLine("ср"); 
// else if (a==4)
//     Console.WriteLine("чт"); 
// else if (a==5)
//     Console.WriteLine("пт"); 
// else if (a==6)
//     Console.WriteLine("сб");
// else if (a==7)
//     Console.WriteLine("вс");
// else 
//     Console.WriteLine("Неверный ввод");


// task 5 - me
// Console.Write("Введите положительное целое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int i = -a;
// while (i >= -a && i <= a)
// {
//     Console.Write(i);
//     Console.Write(", ");
//     i++;
// }


// task 5 - denis
// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int i = (-1) * n;
// while (i <= n)
// {
//     Console.Write($"{i} ");
//     i++;
// }


// task 7 - division by 10
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(n % 10);