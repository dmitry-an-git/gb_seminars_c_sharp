// task 06 - odd or even

Console.Clear();
Console.Write("Please enter an integer number: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a%2 == 0)
    Console.WriteLine($"Your number ({a}) is even"); // incl 0
else 
    Console.WriteLine($"Your number ({a}) is odd");