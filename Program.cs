namespace KilkellyJA8;
//John Kilkelly
//ID: 350439
//COP2360
//Assignment 8

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"\nEnter search term.");
        string? searchTerm = Console.ReadLine();
        BinarySearch mySearch = new BinarySearch();
        int myIndex = mySearch.SearchList(searchTerm);
        
        if (myIndex>0)
            Console.WriteLine($"The term '{searchTerm}' was found at index {myIndex.ToString()}.");
        else
            Console.WriteLine($"The term '{searchTerm}' was not found.");
    }

    public class BinarySearch
    {
        List<string> terms = new List<string> (File.ReadAllLines(@"C:\Users\jkilk\OneDrive\SPC\CSharp 1 2360\A8\horticulture_terms.txt"));
        
       public int SearchList(string searchTerm)
        {
            terms.Sort();
            int index = terms.BinarySearch(searchTerm);
            return index;
        }
    }
  
}
