// random 3 digit number and then remove middle digit


Console.Clear();

int n = new Random().Next(100, 1000);

Console.WriteLine($"Случайное число: {n}");

int n1 = n % 10; // кол-во единиц
int n2 = n / 100; // кол-во сотен
int answer = n2*10+n1;

Console.WriteLine(answer);

// task 11

Console.Clear();

string? s = Console.ReadLine();

Console.WriteLine(Convert.ToInt32(s[0].ToString()) * 5);