// task25
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Нельзя использовать функцию Math.Pow

Console.Write("Введите число - основание степени: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());

int power(int x, int y) 
{
    if (y == 1) return x;
    else if (y == 0) return 1;
    else return x*power(x,y-1);

}

Console.WriteLine($"Ответ: {power(a,b)}");