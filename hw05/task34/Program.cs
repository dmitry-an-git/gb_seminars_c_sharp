// task 34

// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

int[] new_3_digit_array(int size)
{
    int[] new_array = new int[size];
    for (int i=0; i<size; i++)
    {
        new_array[i] = new Random().Next(100,1000);
    }
    return new_array;

}

int count_even(int[] some_array)
{
    int counter = 0, size = some_array.Length;
    for (int i=0;i<size;i++)
    {
        if (some_array[i]%2==0)
        counter++;
    }

    return counter;
}

Console.Write("Задайте длину массива: ");
int my_size = Convert.ToInt32(Console.ReadLine());

int[] my_array = new_3_digit_array(my_size);

Console.WriteLine($"[{string.Join(", ", my_array)}]");
Console.WriteLine($"Четных элементов: {count_even(my_array)}");

