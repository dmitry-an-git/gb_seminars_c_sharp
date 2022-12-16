// task 36

// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();

int[] create_random_array(int some_size)
{
    int[] new_array = new int[some_size];
    for (int i=0;i<some_size;i++)
        new_array[i]= new Random().Next(-100,100);
    Console.WriteLine($"[{string.Join(" ",new_array)}]");
    return new_array;
}

Console.Write("Задайте длину массива: ");
int my_size = Convert.ToInt32(Console.ReadLine());
int[] my_array = create_random_array(my_size);

int ans = 0;

for (int i=1; i<my_size; i = i+2)
{
    ans += my_array[i];
}
Console.WriteLine($"Сумма элементов на нечетных позициях: {ans}");