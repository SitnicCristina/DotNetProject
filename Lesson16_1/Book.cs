namespace DotNetExamples.Lesson16_1;

public class Book : LibraryItem, IBorrowable
{
    public Book(string title, string author, int publicationYear) : base(title, author, publicationYear)
    {
    }
}