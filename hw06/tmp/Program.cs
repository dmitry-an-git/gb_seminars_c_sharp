// See https://aka.ms/new-console-template for more information
string a = "abc";
Console.WriteLine(a[0]);
Console.WriteLine(a[0].ToString()+a[2].ToString());
foreach (char x in a)
    Console.WriteLine(x);

string short_set = set.Replace(x,"");