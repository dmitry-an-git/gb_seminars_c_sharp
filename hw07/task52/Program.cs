// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateArray(int m, int n)
{
    int[,] newArray = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newArray[i,j] = new Random().Next(0,10);
        }
    }
    return newArray;
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

void ColumnAverage(int[,] someArray)
{
    double[] ans = new double[someArray.GetLength(1)];
    for (int i = 0; i < someArray.GetLength(1); i++)
    {   
        double tmp = 0;
        for (int j = 0; j < someArray.GetLength(0); j++)
        {
            tmp += someArray[j,i];
        }
        tmp = Math.Round(tmp/someArray.GetLength(0),1);
        ans[i] = tmp;
    }
    Console.WriteLine($"[{string.Join(", ",ans)}]");
}

Console.Clear();
Console.Write("Задайте размер массива: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] myArray = CreateArray(size[0],size[1]);
PrintArray(myArray); 
ColumnAverage(myArray);

