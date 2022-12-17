// task extra 01

// permutations

// C, AB BA > CAB CBA 
// B, AC CA > BAC BCA 
// A, BC CB > ABC ACB  

// ABCD 4*3*2 = 24 факториал
// A BCD >  B CD DC 
//          C BD DB
//          D CB BC
// B ACD > 
// C ABD > 
// D ABC > 


string[] permutations(string set)
{
    int factorial(int x) // some helper function as we dont know how to extend arrays yet
    {
        if (x == 0)
            return 1;
        else return x*factorial(x-1);
    }

    if (set.Length < 2)
    {
        string[] ans = new string[1];
        ans[0] = set;
        return ans;
    }

    else if (set.Length == 2)
    {    
        string[] ans = new string[2];
        ans[0] = set[0].ToString()+set[1].ToString();
        ans[1] = set[1].ToString()+set[0].ToString();
        return ans;
    }

    else
    {
        string[] ans = new string[factorial(set.Length)]; // we create an array of the right size 
        int counter = 0;
        foreach (char x in set)
        {
            string set_to_edit = set;
            string short_set = set_to_edit.Replace(x.ToString(),"");
            string[] sub_sets = permutations(short_set);
            foreach (string element in sub_sets)
            {
                ans[counter] = x.ToString() + element;
                counter++; // and fill it consequently 
            }
        }
        return ans;
    }
}

Console.Write("Введите символы для перестановок: ");
string? s = Console.ReadLine();

Console.WriteLine($"[{string.Join(", ",permutations(s))}]");

