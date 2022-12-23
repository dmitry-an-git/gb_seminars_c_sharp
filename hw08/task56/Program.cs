// task 56
// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

int[,] CreateRandomArray(int m, int n)
{
    int[,] array = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = new Random().Next(-10,10);
        }
    }
    return array;
}

void PrintArray(int[,] someArray)
{
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            Console.Write($"{someArray[i,j]}\t");
        }
        Console.WriteLine();
    }
}

int MinSumLine(int[,] someArray)
{
    int[] sums = new int[someArray.GetLength(0)];
    for (int i = 0; i < someArray.GetLength(0); i++)
    {   
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            sums[i] += someArray[i,j];
        }
    }

    int mix = sums[0];
    int mix_line = 0;
    for (int i = 1; i < someArray.GetLength(0); i++)
    {
        if (sums[i]<mix) 
        {
            mix = sums[i];
            mix_line = i;
        }
    }
    return mix_line+1; // lets be user friendly
}


Console.Clear();
Console.Write("Задайте размеры прямоугольного массива: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
while (size[1]==size[0])
{
    Console.WriteLine("Ваш массив квадратный!");
    Console.Write("Задайте размеры прямоугольного массива: ");
    size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
int[,] myArray = CreateRandomArray(size[0],size[1]);
Console.WriteLine("Исходный массив:");
PrintArray(myArray);
Console.WriteLine();
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {MinSumLine(myArray)}");
