namespace DotNetExamples.Lesson16_1;

public class Program 
{
    
    public static void Main(string[] args)
    {
        Library library =  new Library();
        
        library.AddItem(new Book("Clean Code", "Robert C. Martin", 2008));
        library.AddItem(new Magazine("National Geographic", "Divers", 2022));
        library.AddItem(new DVD("The Matrix", "Wachowski", 1999));
        
        library.BorrowItem("Clean Code");
        library.BorrowItem("Clean Code");
        
        library.BorrowItem("National Geographic");
        library.ReturnItem("National Geographic");
        
        library.BorrowItem("The Matrix");
        library.BorrowItem("The Matrix");
        library.ReturnItem("The Matrix");
        library.ReturnItem("The Matrix");
        
        
    }
    
}