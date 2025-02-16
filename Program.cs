namespace KilkellyJA8;
//John Kilkelly
//ID: 350439
//COP2360
//Assignment 8

class Program
{
    static void Main(string[] args)
    {
        List<string> terms = new List<string> (File.ReadAllLines(@"C:\Users\jkilk\OneDrive\SPC\CSharp 1 2360\A8\horticulture_terms.txt"));
        terms.Sort();
        Console.WriteLine($"\n{terms[0]}");
       
    }
}
