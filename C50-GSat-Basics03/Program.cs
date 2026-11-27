using System.Text;

class Program
{
    static void Main(string[] args)
    {
        #region Question1
        //string tittle = "clean code";
        //string upperTitle = tittle.ToUpper();

        ////tittle unchanged because string is immutable 
        //Console.WriteLine(tittle.GetHashCode());
        //Console.WriteLine(upperTitle);
        #endregion
        #region Question2
        //string tittle1 = "Clean Code";
        //string tittle2 = "Clean Code";

        //Console.WriteLine(ReferenceEquals(tittle1, tittle2));
        #endregion
        #region Question3
        //StringBuilder books = new StringBuilder();
        //books.Append("Book List");
        //books.Append("- Updated");
        //Console.WriteLine(books);
        #endregion
        #region Question4
        //StringBuilder books = new StringBuilder();
        //books.Append("Book List");
        //books.Append("- Updated");
        //books.Replace("Book List", "Library");
        //Console.WriteLine(books);
        #endregion
        #region Question5
        //string tittle = "Clean Code";
        //int pages = 464;
        //Console.WriteLine("Books: "+ tittle +" Pages: "+pages);
        #endregion
        #region Question6
        //string tittle = "Clean Code";
        //int pages = 464;
        //Console.WriteLine($"Books: {tittle}, pages: {pages}");
        #endregion
        #region Question7
        //string tittle = "Clean Code";
        //int pages = 464;
        //string sentence = string.Format("Book: {0},\nPages: {1}", tittle, pages);

        //Console.WriteLine(sentence);     
        #endregion
        #region Question8
        //int pages = 464;
        //if (pages > 300)
        //    Console.WriteLine("Long Book");
        //else
        //    Console.WriteLine("Short Book");
        #endregion
        #region Question9
        //int pages = 464;
        //bool isAvailable = true;

        //if (pages > 300 && isAvailable == true)
        //    Console.WriteLine("You can borrow this book");
        //else
        //    Console.WriteLine("You canot borrow this book");

        #endregion
        #region Question10
        //string tittle = "Refactoring";
        //switch (tittle)
        //{
        //    case "Clean Code":
        //        Console.WriteLine("Great choice!");
        //        break;
        //    case "Refactoring":
        //        Console.WriteLine("Nice pick!");
        //        break;
        //    default:
        //        Console.WriteLine("Never heard of it");
        //        break;
        //}
        #endregion
        #region Question11
        //int pages = 464;

        //string result = pages > 300 ? "Long Book" : "Short Book";

        //Console.WriteLine(result);
        #endregion
        #region Question12
        //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
        //for (int i = 0; i < books.Length; i++)
        //{
        //    Console.WriteLine($"{i+1}.{books[i]}");
        //}
        #endregion
        #region Question13
        //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
        //int i = 0;
        //while (i<books.Length)
        //{
        //    Console.WriteLine(books[i]);
        //    i++;
        //}
        #endregion
        #region Question14
        int count = 0;

        do
        {
            Console.WriteLine("Checking book...");
            count++;
        }
        while (count < 3);
        #endregion
    }
}