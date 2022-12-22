// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateArray(int m, int n)
{
    double[,] newArray = new double[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newArray[i,j] = Math.Round(new Random().NextDouble()*10-5,1);
        }
    }
    return newArray;
}

void PrintArray(double[,] someArray)
{
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            string spacer = " ";
            if (someArray[i,j]<0) {spacer = "";}
            Console.Write($"{spacer}{someArray[i,j]}\t");
        }
        Console.WriteLine();
    }   
}

Console.Clear();
Console.Write("Задайте размер массива:");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
double[,] myArray = CreateArray(size[0],size[1]);
PrintArray(myArray);
