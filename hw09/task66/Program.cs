// task66
// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int RangeSum(int start, int finish)
{
    if (start - finish == 0)
        return start;
    else 

        return finish+RangeSum(start, finish-1);
}

Console.Clear();
Console.Write("Задайте промежуток: ");
int[] range = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

Console.WriteLine(RangeSum(range[0],range[1]));