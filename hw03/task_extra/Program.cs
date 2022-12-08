Console.Clear();


Console.Write("Задайте количество кустов на грядке (натуральное число): ");
int n = Convert.ToInt32(Console.ReadLine());

int[] my_array = new int[n];

Console.WriteLine("В этом году у вас такой урожай (ягод на кусте):");

Random r = new Random();

for (int i = 0; i<n; i++)
    {
        my_array[i] = r.Next(0, 100);
        Console.Write($"{my_array[i]} ");
    }

Console.WriteLine("");

int max = 0;

for (int i=0; i<n; i++)
    {
        int moving_sum = my_array[(i)%n]+my_array[(i+1)%n]+my_array[(i+2)%n];
        if (moving_sum>max)
            max = moving_sum;
    }

Console.WriteLine($"За один заход вы сможете собрать максимум {max} ягод");

