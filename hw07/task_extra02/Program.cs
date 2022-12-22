// task_extra02
// https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=8&id_topic=121&id_problem=749
// Misha & negative 
// I used "X-" instead of "BW" to make them look clear


string[,] CreateMatrix(int m, int n)
{   
    string options = "X-";
    string[,] newMatrix = new string[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newMatrix[i,j] = options[new Random().Next(0,options.Length)].ToString();
        }
    }
    return newMatrix;
}

void PrintMatrix(string[,] someMatrix)
{
    for (int i = 0; i < someMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < someMatrix.GetLength(1); j++)
        {
            Console.Write($"{someMatrix[i,j]}");
        }
        Console.WriteLine();
    }
}

string[,] TrueNegative(string[,] someMatrix)
{
    string options = "X-";
    string[,] trueNegativeMatrix = new string[someMatrix.GetLength(0),someMatrix.GetLength(1)];
    for (int i = 0; i < someMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < someMatrix.GetLength(1); j++)
        {
            if (someMatrix[i,j]==options[0].ToString())
                trueNegativeMatrix[i,j]=options[1].ToString();
            else 
                trueNegativeMatrix[i,j]=options[0].ToString();
        }
    }
    return trueNegativeMatrix;
}

int WrongPixels(string[,] someTrueNegative, string[,] someFalseNegative)
{
    int ans = 0;
    for (int i = 0; i < someTrueNegative.GetLength(0); i++)
    {
        for (int j = 0; j < someTrueNegative.GetLength(1); j++)
        {
            if (someTrueNegative[i,j] != someFalseNegative[i,j])
                ans += 1;
        }
    }
    return ans;
}


Console.Clear();
Console.Write("Задайте размерность матриц: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

string[,] positiveMatrix = CreateMatrix(size[0], size[1]);
Console.WriteLine("Позитив:");
PrintMatrix(positiveMatrix);
Console.WriteLine();

string[,] falseNegativeMatrix = CreateMatrix(size[0], size[1]);
Console.WriteLine("Негатив с ошибками:");
PrintMatrix(falseNegativeMatrix);
Console.WriteLine();

string[,] trueNegativeMatrix = TrueNegative(positiveMatrix);
Console.WriteLine("Правильный негатив:");
PrintMatrix(trueNegativeMatrix);
Console.WriteLine();

Console.WriteLine($"Ошибок: {WrongPixels(trueNegativeMatrix,falseNegativeMatrix)}");