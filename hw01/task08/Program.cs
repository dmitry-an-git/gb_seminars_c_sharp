// task 08 - even numbers from 0 to n


Console.Clear();
Console.Write("Please enter an integer number: ");
int a = Convert.ToInt32(Console.ReadLine());
int start = 2;

Console.WriteLine($"The lisf of even numbers in the range [1; your_number]:");

if (a<start)
    Console.WriteLine($"No numbers here, {a} is too low");

for (int iter = start;iter <= a;iter+=2)
    Console.Write($"{iter} ");

Console.WriteLine("");