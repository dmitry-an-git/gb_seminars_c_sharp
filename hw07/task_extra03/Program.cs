// task_extra03
// https://gbcdn.mrgcdn.ru/uploads/asset/4818495/attachment/8272f91a9a93ba1514a1eea1365f042a.jpg
// diagonal fill

void DiagonalFill(int[,] matrix, int start_m = 0, int start_n = 0, int count = 0)
{   
    if (count == matrix.GetLength(0)*matrix.GetLength(1))
        return;

    if (start_m>-1 
        && start_n>-1
        && start_m<matrix.GetLength(0)
        && start_n<matrix.GetLength(1))
        {
            matrix[start_m, start_n]=count;
            count++;
        }
    
    int next_m = (start_m + 1) % matrix.GetLength(0);
    int next_n = (start_n - 1) + ((start_m + 1 )/ matrix.GetLength(0))*(matrix.GetLength(0)+1);
    
    DiagonalFill(matrix,next_m,next_n,count);
}

void PrintMatrix(int[,] someMatrix)
{
    for (int i = 0; i < someMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < someMatrix.GetLength(1); j++)
        {
            Console.Write($"{someMatrix[i,j]}\t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Задайте размерность матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

int[,] myMatrix = new int[size[0], size[1]];

DiagonalFill(myMatrix);
PrintMatrix(myMatrix);