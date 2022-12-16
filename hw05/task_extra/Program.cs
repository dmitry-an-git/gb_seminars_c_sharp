// task  extra english marks by odd and even calendar days
Console.Clear();

int[] new_array_days(int size)
{
    int[] new_array = new int[size];
    for (int i=0; i<size; i++)
    {
        new_array[i] = new Random().Next(1,32);
    }
    Console.WriteLine($"[{string.Join(" ",new_array)}]");
    return new_array;
}

void print_odd(int[] some_array)
{
    Console.WriteLine("Числа с тройками (нечетные):");
    for (int i=0; i<some_array.Length; i++)
    {
        if ((some_array[i]%2)==1)
            Console.Write($"{some_array[i]} ");
    }
    Console.WriteLine();
}

void print_even(int[] some_array)
{
    Console.WriteLine("Числа с четверками (четные):");
    for (int i=0; i<some_array.Length; i++)
    {
        if ((some_array[i]%2)==0) 
        Console.Write($"{some_array[i]} ");
    }
    Console.WriteLine();
}

string final_mark(int[] some_array)
{
    float[] marks = new float[some_array.Length];
    
    int count3=0, count4=0;

    for (int i=0; i<some_array.Length; i++)
    {
        if ((some_array[i]%2)==0) 
            {
                marks[i] = 4;
                count4++;
            }
        else
            {
                marks[i] = 3;
                count3++;
            }
    }
    Console.WriteLine("Итого оценки");
    Console.WriteLine($"[{string.Join(" ",marks)}]");
    Console.WriteLine("Сможет Вася расчитывать на 4?");
    if (count4>=count3)
        return "YES";
    else
        return "NO";
}

Console.Write("Задайте длину массива (число дней с уроками): ");
int my_size = Convert.ToInt32(Console.ReadLine());
int[] my_schedule = new_array_days(my_size);

print_odd(my_schedule);
print_even(my_schedule);
Console.WriteLine(final_mark(my_schedule));


