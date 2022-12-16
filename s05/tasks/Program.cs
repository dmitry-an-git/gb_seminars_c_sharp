// task 31
// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
// Console.Clear();

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10); // [-9, 9]
// }


// void ReleaseArray(int[] array)
// {
//     int sumPositive = 0, sumNegative = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//             sumPositive += array[i];
//         else
//             sumNegative += array[i];
//     }
//     Console.WriteLine($"Сумма положительных чисел равна {sumPositive}");
//     Console.WriteLine($"Сумма отрицательных чисел равна {sumNegative}");
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");
// ReleaseArray(array);

// // task 32

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10); // [-9, 9]
// }

// void InverseSign(int[] array)
// {
//    for (int i = 0; i < array.Length; i++)
//         array[i] = -array[i]; 

// }


// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");
// InverseSign(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");



// // task 33

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10); // [-9, 9]
// }

// string SearchArray(int[] array, int number)
// {
//    for (int i = 0; i < array.Length; i++)
//         if (array[i] == number)
//             {
//             return "Yes";
//             }
//        return "No"; 

// }

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");

// Console.Write("Введите искомое число: ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(SearchArray(array, x));

// task 35

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-100, 100); // [-9, 9]
// }

// int CountArray(int[] array)
// {
//     int counter =0;
//     for (int i = 0; i < array.Length; i++)
//         if (array[i]>9 && array[i]<100)
//             counter ++;
//     return counter;
// }

// Console.Clear();
// int n = 123;
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");

// Console.WriteLine(CountArray(array));

// task 37

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10); // [-9, 9]
// }

// int[] PairProduct(int[] some_array)
// {

//     int new_n = some_array.Length/2+some_array.Length%2;
 
//     int[] new_array = new int[new_n];

//     for (int i = 0; i<new_n;i++)
//         new_array[i]=some_array[i]*some_array[some_array.Length-1-i];

//     return new_array;
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");

// int[] new_array = PairProduct(array);
// Console.WriteLine($"[{string.Join(", ", new_array)}]");


// 35 task

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 11); // [1, 10]
}


void ReleaseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
        Console.Write($"{array[i] * array[array.Length - 1 - i]} ");

}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
ReleaseArray(array);