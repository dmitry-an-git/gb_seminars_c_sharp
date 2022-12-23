// task 60
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] CreateRandom3dArray(int m, int n, int o)
{
    int[,,] array = new int[m,n,o];
    int start = 10;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < o; k++)
            {
                array[i,j,k] = start;
                start++;
            }
        }
    }
    return array;
}

void Print3dArray(int[,,] someArray)
{
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            for (int k = 0; k < someArray.GetLength(2); k++)
            {
                Console.WriteLine($"{someArray[i,j,k]} ({i},{j},{k})");
            }
        }
    }
}

Console.Clear();
Console.Write("Задайте размеры массива: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
while (size[0]*size[1]*size[2]>90)
{
    Console.WriteLine("Ваш массив слишком большой!");
    Console.Write("Задайте новые размеры массива: ");
    size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
int[,,] myArray = CreateRandom3dArray(size[0],size[1],size[2]);
Console.WriteLine();
Print3dArray(myArray);