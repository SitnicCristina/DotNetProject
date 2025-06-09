namespace DotNetExamples.Lesson16_1;

public class DVD : LibraryItem, IBorrowable
{
    public DVD(string title, string author, int publicationYear) : base(title, author, publicationYear)
    {
    }
}