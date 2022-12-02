// Task 13
Console.Clear();

// Погугил и написал проверку на то, что ввод является числом через TryParse()

// string input = "dummy";
// int numericValue;
// while (int.TryParse(a, out numericValue)==false)
// {
//     Console.Write("Введите число: ");
//     input = Convert.ToString(Console.ReadLine());
// }

// Потом решил что это читерство и нам такого не давали, решил использовать что есть

bool isDigit = false;
string input = "dummy";

while (isDigit == false)
{
    Console.Write("Введите число: ");
    input = Console.ReadLine();
    for (int i = 0; i < input.Length; i++)
    {    
        int utf_dec = Convert.ToInt32(input[i]);
        if (utf_dec<48 || utf_dec>57) // 0 is 48 and 9 is 57 in decimal
        {
            isDigit = false;
            break;
        }
        else
            isDigit = true;
    }
}

Console.WriteLine($"Вы ввели {input}");

// мы можем дать третий (индекс 2) символ строки

// if (input.Length<3)
//     Console.WriteLine("В этом числе меньше трех цифр");
// else
//     Console.WriteLine($"Третья цифра этого числа: {input[2]}");

// но можем работать со строкой как с числом, используя математические операции

int n = Convert.ToInt32(input);


if (n < 100)
    Console.WriteLine("В этом числе меньше трех цифр");
else 
{
    if (n > 1000)
    {
        while (n > 1000)
            n = n/10;
    }

    int answer = n%10;
    Console.WriteLine($"Третья цифра этого числа: {answer}");
}
    


// также можно так:

// int digits = input.Length;
// int n = Convert.ToInt32(input);
// int divider = 1;

// if (digits>2)
// {
//     for (int i=2; i<digits; i++)
//         divider *=10;
//     int answer = (n%divider)/(divider/10);
//     Console.WriteLine($"Третья цифра этого числа: {answer}");    
// }
// else
//     Console.WriteLine("В этом числе меньше трех цифр");
