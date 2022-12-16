// task 38
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

double[] create_random_array(int some_size)
{
    double[] new_array = new double[some_size];
    for (int i=0;i<some_size;i++)
        new_array[i]= new Random().NextDouble()*1000-500; // не сказано что надо округлять
    Console.WriteLine($"[{string.Join(" ",new_array)}]");
    return new_array;
}

double find_max(double[] some_array)
{
    double max = some_array[0];
    for (int i=1; i<some_array.Length;i++)
    {
        if (some_array[i]>max)
            max = some_array[i];
    }
    return max;
}

double find_min(double[] some_array)
{
    double min = some_array[0];
    for (int i=1; i<some_array.Length;i++)
    {
        if (some_array[i]<min)
            min = some_array[i];
    }
    return min;
}


Console.Write("Задайте длину массива: ");
int my_size = Convert.ToInt32(Console.ReadLine());
double[] my_array = create_random_array(my_size);

Console.WriteLine($"Разница большего и меньшего: {find_max(my_array) - find_min(my_array)}");