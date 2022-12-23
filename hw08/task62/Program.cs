// task62
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void FillClockwise(int[,] array, int start_m = 0, int start_n = 0, int counter = 1, int rule = 0)
{   
    if (counter > array.GetLength(0)*array.GetLength(1))
        return;
    
    array[start_m,start_n] = counter;
    counter++;

    int[,] rules = new int[,]{{0,1},{1,0},{0,-1},{-1,0}};

    int[] targetElement = new int[]{start_m+rules[rule,0],start_n+rules[rule,1]};

    if (targetElement[0]>=array.GetLength(0)
        || targetElement[1]>=array.GetLength(1)
        || targetElement[0]<0
        || targetElement[1]<0)
    {
        rule = (rule+1)%4;
    }
    else if (array[targetElement[0],targetElement[1]]!=0)
    {
        rule = (rule+1)%4;
    }
    
    FillClockwise(array, start_m+rules[rule,0],start_n+rules[rule,1], counter, rule);
}

// rules are inertial
// check if next (out or not 0), if so, go to next rule
// (i,j+1) right
// (i+1,j) down
// (i,j-1) left
// (i-1,j) up
// works for arrays of any size

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

Console.Clear();
int[,] myArray = new int[4,4];
FillClockwise(myArray);
PrintArray(myArray);


