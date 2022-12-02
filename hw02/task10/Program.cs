// task10

int a = 0;
while (a<100 || a>999)
{
Console.Write("Введите трехзначное натуральное число: ");
a = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Вы ввели {a}");
int b = (a%100)/10;
Console.WriteLine($"Вторая цифра этого числа: {b}");