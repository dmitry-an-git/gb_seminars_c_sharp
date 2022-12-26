// See https://aka.ms/new-console-template for more information


int rec(int a, int b)
{
    if (b==0) return 1;
    else return a*rec(a,b-1);
}

Console.Write("Задайте число: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(rec(m,n));