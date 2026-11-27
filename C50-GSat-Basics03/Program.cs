class Program
{
    static void Main(string[] args)
    {
        #region Question1
        string tittle = "clean code";
        string upperTitle = tittle.ToUpper();

        //tittle unchanged because string is immutable 
        Console.WriteLine(tittle.GetHashCode());
        Console.WriteLine(upperTitle);
        #endregion
    }
}