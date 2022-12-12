// task29
// Напишите программу, которая спрашивает у пользователя кол-во элементов и спршивает сами элементы. 
// После записи элементов в массив, необходимо его вывести на экран.



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


Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] my_array = fill_array(size);
Console.WriteLine($"[{string.Join(", ", my_array)}]");
