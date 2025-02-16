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
        BinarySearch mySearch = new BinarySearch(); //create instance of BinarySearch class

        int myIndex = mySearch.SearchList(searchTerm.ToLower());
        //binary search is case sensative. Make searchTerm all lowercase. SearchList method will make all terms in main list lowercase.

        if (myIndex>0)
            Console.WriteLine($"The term '{searchTerm}' was found at index {myIndex.ToString()}.");
        else
            Console.WriteLine($"The term '{searchTerm}' was not found.");
    }

    public class BinarySearch
    {
        static string filePath = @"C:\Users\jkilk\OneDrive\SPC\CSharp 1 2360\A8\horticulture_terms.txt";
        List<string> terms = new List<string> (File.ReadAllLines(filePath));
       
       public int SearchList(string searchTerm)
        {
            //make all terms in list lowercase to match the (lower) case of the search term
            for (int i =0; i < terms.Count; i++)
                {
                    terms[i] = terms[i].ToLower();
                }
            terms.Sort();
            int index = terms.BinarySearch(searchTerm);
            return index;
        }
    }
  
}
