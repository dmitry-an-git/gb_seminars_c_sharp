// See https://aka.ms/new-console-template for more information

int input()
{
    bool success = false;
    int n=-1;
    while (success == false)
    {
        Console.Write("Введите число: ");
        n = Convert.ToInt32(Console.ReadLine());
        if (n>998 || n<4)
            continue;
        else if (n%2 == 1)
            continue;
        else
            success = true;
    }
    return n;
}

bool is_prime(int some_number)
{
    for (int i=2;i<some_number;i++)
        {
            if (some_number%i==0)
                return false;
        }
    return true;
}

int[] min_pair_prime(int some_number)
{
    int[] ans = new int[2];
    for (int i=3;i<some_number;i++)
    {
        if (is_prime(i) && is_prime(some_number-i))
        {
            ans[0] = i;
            ans[1] = some_number-i;
            break;
        }
    }
    return ans;
}

int my_number = input();
Console.WriteLine($"[{string.Join(", ", min_pair_prime(my_number))}]");
