namespace DotNetExamples.Lesson16_1;

public class Magazine : LibraryItem, IBorrowable
{
    public Magazine(string title, string author, int publicationYear) : base(title, author, publicationYear)
    {
    }
}