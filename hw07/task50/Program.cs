// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такой позиции в массиве нет (пользователь вводит нумерацию с 1)


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
            Console.Write($"{spacer}{someArray[i,j]}\t");
        }
        Console.WriteLine();
    }
}

void SearchArray(int m, int n, int[,] someArray)
{
    if (m < someArray.GetLength(0)
        && n < someArray.GetLength(1)
        && m>0
        && n>0)
    {
        Console.WriteLine(someArray[m,n]);
    }
    else 
        Console.WriteLine("Такой позиции в массиве нет");
}

Console.Clear();
Console.WriteLine("Задайте размер массива:");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

int[,] myArray = CreateArray(size[0],size[1]);
PrintArray(myArray);

Console.WriteLine("Введите индекс элемента:");
int[] location = Console.ReadLine().Split(" ").Select(x => int.Parse(x)-1).ToArray(); // корректируем на 1
SearchArray(location[0], location[1], myArray);
