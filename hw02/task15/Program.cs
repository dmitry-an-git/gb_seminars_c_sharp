// task 15
Console.Clear();

int a = 0;

while (a<1 || a>7)
{
    Console.Write("Введите номер дня недели: ");
    a = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Вы ввели: {a}");

if (a > 5 )
    Console.WriteLine("Это выходной день");
else
    Console.WriteLine("Это будний день");

