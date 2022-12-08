// task23

Console.Clear();
Console.Write("Введите число (N): ");
int n = Convert.ToInt32(Console.ReadLine());

int step = 1;

Console.WriteLine("N -> N^3");

while (step<=n)
{
    Console.WriteLine($"{step} -> {Math.Pow(step,3)}");
    step++;
}