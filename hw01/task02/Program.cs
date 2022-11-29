// task 02 - max of two

Console.Clear();
Console.Write("Please enter the first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter the second number: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a>b)
    {Console.WriteLine($"The first number ({a}) is max");
    Console.WriteLine($"The second number ({b}) is min");}
else if (a<b)
    {Console.WriteLine($"The second number ({b}) is max");
    Console.WriteLine($"The first number ({a}) is min");}
else
    Console.WriteLine($"The numbers are equal ({a}={b})");    