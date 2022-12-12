// task27
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int sum_of_digits(int number)
{
    int sum = 0;
    while (number>0)
    {
        int res = number%10;
        number = number/10;
        sum += res;
    }
    return sum;
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел вашего числа: {sum_of_digits(a)}");
