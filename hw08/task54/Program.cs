// task 54
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortLines(int[,] someArray)
{
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            int max = someArray[i,0];
            for (int k = 1; k < someArray.GetLength(1)-j; k++)
            {
                
                if (someArray[i,k]<max)
                {
                    someArray[i,k-1] = someArray[i,k];
                    someArray[i,k] = max;
                }
                else 
                    max = someArray[i,k];
            }
        }

    }
}


Console.Clear();
Console.Write("Задайте размеры массива: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] myArray = CreateRandomArray(size[0],size[1]);
Console.WriteLine("Исходный массив:");
PrintArray(myArray);
Console.WriteLine("Упорядоченный массив:");
SortLines(myArray);
PrintArray(myArray);