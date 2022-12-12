// task extra 01
// суперсдвиг

int[] fill_array(int size)
{
    int[] my_array = new int[size];
    for (int i=0; i<size;i++)
    {
        Console.Write($"Введите значение {i+1}-го элемента: ");
        int a = Convert.ToInt32(Console.ReadLine());
        my_array[i] = a;
    }
    return my_array;
}

int[] supershift(int[] some_array, int some_shift)
{
    int size = some_array.Length;
    int[] shifted_array = new int[size];

    for (int i=0;i<size;i++)
    {
        shifted_array[i]=some_array[(size+i-some_shift)%size];    
    }

    return shifted_array;
}

Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] my_array = fill_array(size);
Console.WriteLine($"[{string.Join(", ", my_array)}]");

Console.Write("Введите параметр сдвига: ");
int my_shift = Convert.ToInt32(Console.ReadLine());

int[] new_array = supershift(my_array, my_shift);
Console.WriteLine($"[{string.Join(", ", new_array)}]");