// task_extra01
// https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=8&id_topic=120&id_problem=745
// transpose horizontal


int[,] CreateMatrix(int m, int n)
{
    int[,] newMatrix = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newMatrix[i,j] = new Random().Next(0,10);
        }
    }
    return newMatrix;
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

int[,] TransposeHorizontal(int[,] someMatrix)
{
    int[,] newMatrix = new int[someMatrix.GetLength(0),someMatrix.GetLength(1)];
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            newMatrix[i,j] = someMatrix[someMatrix.GetLength(0)-1-i,j];
        }
    }
    return newMatrix;
}

Console.Clear();
Console.Write("Задайте размерность матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] myMatrix = CreateMatrix(size[0], size[1]);
PrintMatrix(myMatrix);
Console.WriteLine();
int[,] transpMatrix = TransposeHorizontal(myMatrix)
;PrintMatrix(transpMatrix);