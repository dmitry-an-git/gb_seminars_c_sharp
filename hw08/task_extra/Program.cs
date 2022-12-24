// task extra
// pascal triangle
// power => coefficients

int[] PascalCoef(int power)
{
    if (power == 0) return new int[]{1};
    else 
    {
        int[] coef = new int[power + 1];
        coef[0] = 1;
        coef[coef.Length-1] = 1;
        for (int i = 1; i < coef.Length-1; i++)
        {
            int[] coef_upper = PascalCoef(power-1);
            coef[i] = coef_upper[i-1]+coef_upper[i];
        }
        return coef;
    }
}

void PrintPascal(int power)
{
    for (int i = 0; i < power; i++)
    {   
        int x_i = (power-i)/2*8+(power-i)%2*4;
        if (i == 0) 
        {
            Console.SetCursorPosition(x_i,i+2);
            Console.Write($"X");
            Console.SetCursorPosition(x_i,i+3);
            Console.Write($"|");
        }
        Console.SetCursorPosition(x_i,i+4);
        int place = 0;
        foreach (int element in PascalCoef(i))
        {
            Console.SetCursorPosition(x_i + 8*place,i+4);
            Console.Write($"{element}");
            place++;
        } 
        
        if (i == power - 1) 
        {
            Console.SetCursorPosition((power)/2*8+(power)%2*4,i+4+1);
            Console.Write($"|");
            Console.SetCursorPosition((power)/2*8+(power)%2*4-2,i+4+2);
            Console.Write($"~~~~~");
        }
    }
    Console.WriteLine();
}

Console.Clear();
Console.Write("Задайте степень: ");
int power = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Коэффициенты многочлена:");
//Console.WriteLine($"[{string.Join(", ",PascalCoef(power))}]");
PrintPascal(power);

// this is what you get:
//
// Задайте степень: 7
// Коэффициенты многочлена:
//                             X
//                             |
//                             1
//                         1       1
//                     1       2       1
//                 1       3       3       1
//             1       4       6       4       1
//         1       5       10      10      5       1
//     1       6       15      20      15      6       1
//                             |
//                           ~~~~~
// merry X-mas!!