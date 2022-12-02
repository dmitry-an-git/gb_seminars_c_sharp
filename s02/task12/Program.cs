Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a% == 0 && a%b == 0)
{
    Console.WriteLine("Первое число кратно второму");
}
else
{
    Console.WriteLine($"Не кратно, остаток от деления {a%b}");
}


// Console.Write("Pls enter the third number: ");
// int c = Convert.ToInt32(Console.ReadLine());