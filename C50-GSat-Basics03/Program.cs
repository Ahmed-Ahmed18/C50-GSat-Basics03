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
        string tittle = "Clean Code";
        int pages = 464;
        Console.WriteLine("Books: "+ tittle +" Pages: "+pages);
        #endregion
    }
}