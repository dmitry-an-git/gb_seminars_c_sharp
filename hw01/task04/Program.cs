// task 04 - max of three

Console.Clear();
Console.Write("Please enter the first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter the second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter the third number: ");
int c = Convert.ToInt32(Console.ReadLine());

// only one max

if (a>b && a>c)
    Console.WriteLine($"The first number ({a}) is max");
else if (b>a && b>c)
    Console.WriteLine($"The second number ({b}) is max");
else if (c>a && c>b)
    Console.WriteLine($"The third number ({c}) is max");

// two max numbers

else if (a==b && a>c)
    Console.WriteLine($"The first ({a}) and the second ({b}) numbers are equal and are maximums");
else if (a==c && a>b)
    Console.WriteLine($"The first ({a}) and the third ({c}) numbers are equal and are maximums");
else if (b==c && b>a)
    Console.WriteLine($"The second ({b}) and the third ({c}) numbers are equal and are maximums");

// all equal (no max / all three are maximums)
else
    Console.WriteLine($"All three numbers are equal ({a}={b}={c})");





