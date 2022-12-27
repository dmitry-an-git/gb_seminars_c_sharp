// task 68
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman(int m, int n)
{
    if (m == 0) return n+1;
    else if (n == 0) return Akkerman(m-1, 1);
    else return Akkerman(m-1, Akkerman(m,n-1));
}

Console.Clear();
int[] input = new int[]{-1,-1};
while (input[0]<0 || input[1]<0)
{
    Console.Write("Введите два неотрицательных числа: ");
    input = Console.ReadLine().Split(" ").Select(x => Convert.ToInt32(x)).ToArray();
}

Console.WriteLine(Akkerman(input[0], input[1]));