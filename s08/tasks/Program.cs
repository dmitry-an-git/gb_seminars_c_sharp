// // task 48
// // replace first and last string

// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
//         }
//     }
// }

// void PrintMatrix(int[,] someMatrix)
// {
//     for (int i = 0; i < someMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < someMatrix.GetLength(1); j++)
//         {
//             Console.Write($"{someMatrix[i,j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// void ReplaceString(int[,] someMatrix)
// {
//     for (int i = 0; i < someMatrix.GetLength(1); i++)
//     {
//         int tmp = someMatrix[0,i];
//         someMatrix[0,i] = someMatrix[someMatrix.GetLength(0)-1,i];
//         someMatrix[someMatrix.GetLength(0)-1,i] = tmp;
//     }
// }

// Console.Clear();
// Console.Write("Введите размеры матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];

// InputMatrix(matrix);
// PrintMatrix(matrix);
// ReplaceString(matrix);
// PrintMatrix(matrix);

// // задача 55
// // транспонировать квадратную
// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
//     }
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write($"{matrix[i, j]} \t");
//         Console.WriteLine();
//     }
// }

// int[,] ReplaceElement(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = i + 1; j < matrix.GetLength(1); j++)
//         {
//             int temp = matrix[i, j];
//             matrix[i, j] = matrix[j, i];
//             matrix[j, i] = temp;
//         }
//     }
//     return matrix;
// }


// Console.Clear();
// Console.Write("Введите размер матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// // size[0] - row
// // size[1] - column
// while (size[0] != size[1])
// {
//     Console.Write("Вы ошиблись!\nВведите размер матрицы: ");
//     size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// }
// int[,] matrix = new int[size[0], size[1]];
// Console.WriteLine("Начальный массив:");
// InputMatrix(matrix);
// PrintMatrix(matrix);
// Console.WriteLine("Конечный массив:");
// PrintMatrix(ReplaceElement(matrix));


// // задача ЧЧ
// // частотный словарь v1
// bool checkValue(int[] array, int numbers)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == numbers)
//             return false;
//     }
//     return true;
// }


// int InputMatrix(int[,] matrix, int[] array)
// {
//     int k = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 11); // [1, 10]
//             Console.Write($"{matrix[i, j]} \t");
//             if (checkValue(array, matrix[i, j]))
//             {
//                 array[k] = matrix[i, j];
//                 k++;
//             }
//         }
//         Console.WriteLine();
//     }
//     return k;
// }


// void SwapFirstLastString(int[,] matrix, int[] array, int countNumbers)
// {
//     for (int k = 0; k < countNumbers; k++)
//     {
//         int count = 0;
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 if (array[k] == matrix[i, j])
//                     count++;
//             }
//         }
//         Console.WriteLine($"Элемент {array[k]} встречается {count}  раз");   
//     }
// }

// Console.Clear();
// Console.Write("Введите размер матрицы: ");
// int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[coord[0], coord[1]];
// int[] array = new int[coord[0] * coord[1]];
// Console.WriteLine("Начальный массив");
// int count = InputMatrix(matrix, array);
// Console.WriteLine("Конечный массив");
// SwapFirstLastString(matrix, array, count);

// // void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(1, 11); // [1, 10]
//     }
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write($"{matrix[i, j]} \t");
//         Console.WriteLine();
//     }
// }

// void DictionaryMatrix(int[,] matrix)
// {
//     int count = 1;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             count = 1;
//             if (matrix[i, j] != -100)
//             {
//                 for (int k = 0; k < matrix.GetLength(0); k++)
//                 {
//                     for (int m = 0; m < matrix.GetLength(1); m++)
//                     {  
//                         if (matrix[i, j] == matrix[k, m] && (i != k || j != m))
//                         {
//                             matrix[k, m] = -100;
//                             count++;
//                         }
//                         // PrintMatrix(matrix);
//                         // Console.WriteLine();
//                     }
//                 }
//                 Console.WriteLine($"{matrix[i, j]} встречается {count} раз");
//             }
//         }
//     }
// }


// Console.Clear();
// Console.Write("Введите размер матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// // size[0] - row
// // size[1] - column
// int[,] matrix = new int[size[0], size[1]];
// Console.WriteLine("Начальный массив:");
// InputMatrix(matrix);
// PrintMatrix(matrix);
// Console.WriteLine("Конечный массив:");
// DictionaryMatrix(matrix);


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

void DelMin(int[,] matrix)
{
    int min = matrix[0,0];
    int min_i = 0;
    int min_j = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] < min)
            {
            min = matrix[i,j];
            min_i = i;
            min_j = j;
            }
        }
    }

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i != min_i && j != min_j)
                Console.Write($"{matrix[i,j]}\t");
         }
         Console.WriteLine();
    }
           
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine("Начальный массив:");
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();

DelMin(matrix);