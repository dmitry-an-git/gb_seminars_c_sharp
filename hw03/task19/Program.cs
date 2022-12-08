// task 19

Console.Clear();

string n = "dummy";
bool input = false;

while (input == false)
{
    Console.Write("Pls input a 5-digit number: ");
    n = Console.ReadLine();
    if (n.Length != 5)
        continue;
    for(int i=0;i<n.Length;i++)
    {
        int utf_code = Convert.ToInt32(n[i]);
        if (utf_code<48 || utf_code>57) // 0 is 48 and 9 is 57 in decimal utf
        {
            input = false;
            break;
        }
        input = true;
    }
}

if (n[0]==n[4] && n[1]==n[3])
    Console.WriteLine("Congratulations! Your number is a palindrome!");
else
    Console.WriteLine("Your number is not a palindrome, try again.");