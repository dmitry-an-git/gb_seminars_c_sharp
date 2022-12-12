// // Array

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(1, 11); // [1, 10]

// Console.WriteLine($"[{string.Join(", ", array)}]");


// // Array
// // Double numbers
// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double[] array = new double[n];
// for (int i = 0; i < array.Length; i++)
// {
//     //                                              * (end - begin) + begin
//     array[i] = Math.Round(new Random().NextDouble() * (50 - 10) + 10, 2); // [10, 50]
// }

// // Function
// // Необходимо вывести наибольшее число из 2-х

// char test(int a, int b=10)
// {
//     if (a > b)
//         return '>';
//     return '<';
// }

// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ое число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(test(n));
// // 1. return
// //       * Возвращает аргумент туда, где была вызвана функция
// //       * Завершает работу функции
// //       * Возвращаемое значение необходимо принимать в консоль(вывод) или в переменную нужного типа данных
// //       * Сколько аргументов мы принимаем, столько и передаем


//// Процедуры (не возвращают значение)
//// Передача по ссылке (нужна только для переменных, иначе функция работает с копией)
// void test(ref int a)
// {
//     a += 5;
// }
// 
// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// test(ref n);
// Console.WriteLine(n);
//

//// task 24
// Console.Clear();
// Console.Write("Введите число: ");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.Write((x+1)*x/2);
// Console.WriteLine();


// // task 26
// Console.Clear();
// Console.Write("Введите число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// while (x>0)
// {
//     x = x/10;
//     count += 1;
// }
// Console.WriteLine(count);

// // task 28
// Console.Clear();
// Console.Write("Введите число: ");
// int x = Convert.ToInt32(Console.ReadLine()), mult = 2, res = 1;
// while (mult<=x)
// {
//     res *= mult;
//     mult ++;

// }
// Console.WriteLine(res);

// task 30

Console.Clear();
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 2); // [0, 1]
Console.WriteLine($"[{string.Join(", ", array)}]");

// using System;
  
// public class Sum{
//   private static void Main(){
//     string[] tokens = Console.ReadLine().Split(' '); // 1 ЭТи две строки меняем на наш код
//     Console.WriteLine(int.Parse(tokens[0]) + int.Parse(tokens[1])); // 2
//   }
// }