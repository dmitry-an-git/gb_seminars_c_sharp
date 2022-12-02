// task extra

//Console.Clear();

// валидацию ввода хочется попробовать сделать через функцию c кодом из задачи 13

int inputDigit()
{
	
    bool isDigit = false;
    string input = "dummy";

    while (isDigit == false)
    {
        //Console.Write("Введите число: ");
        input = Console.ReadLine();
        for (int i = 0; i < input.Length; i++)
        {    
            int utf_dec = Convert.ToInt32(input[i]);
            if (utf_dec<48 || utf_dec>57) // 0 is 48 and 9 is 57 in decimal
            {
                isDigit = false;
                Console.WriteLine("Ввод не верен, введите число еще раз.");
                break;
            }
            else
                isDigit = true;
        }
    }

    return Convert.ToInt32(input);
}

Console.WriteLine("Пожалуйста, введите натуральные числа для поиска второго максимума:");
int input = inputDigit();
int max1 = input;
int max2 = input;

while (input != 0)
{
    input = inputDigit();
    if (input > max1)
    {        
        max2 = max1;
        max1 = input;
    }
    else if (input > max2)
        max2 = input;
}

Console.WriteLine($"Второй максимум равен {max2}");
