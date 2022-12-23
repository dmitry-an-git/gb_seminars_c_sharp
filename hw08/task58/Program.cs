// task 58
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// lets do real matrix multiplication:

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

int[,] MatProduct(int[,] array1, int[,] array2)
{
    int[,] ans = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < ans.GetLength(0); i++)
    {
        for (int j = 0; j < ans.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                ans[i,j] += array1[i,k]*array2[k,j];
            }
        }
    }
    return ans;
}

Console.Clear();
Console.Write("Задайте размеры первого массива: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] firstArray = CreateRandomArray(size[0],size[1]);
Console.WriteLine("Первый массив:");
PrintArray(firstArray);
Console.WriteLine();

// num of cols of the first array should be equal to num of lines of the second

Console.Write("Задайте количество колонок во втором массиве: ");
int col2 = Convert.ToInt32(Console.ReadLine());
int[,] secondArray = CreateRandomArray(size[1],col2);
Console.WriteLine("Второй массив:");
PrintArray(secondArray);
Console.WriteLine();

Console.WriteLine("Произведение массивов:");
PrintArray(MatProduct(firstArray,secondArray));

// // 2 4 | 3 4
// // 3 2 | 3 3
// int[,] first = new int[,]{{2,4},{3,2}};
// int[,] second = new int[,]{{3,4},{3,3}};
// Console.WriteLine("Произведение массивов:");
// PrintArray(MatProduct(first,second));
// // OK