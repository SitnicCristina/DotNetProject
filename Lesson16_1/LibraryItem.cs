namespace DotNetExamples.Lesson16_1;

public class LibraryItem : IBorrowable
{
    public string Title { get; }
    public string Author { get; }
    public int PublicationYear { get; }
    public bool IsBorrowed { get; private set; }

    public LibraryItem(string title, string author, int publicationYear)
    {
        Title = title;
        Author = author;
        PublicationYear = publicationYear;
        IsBorrowed = false;
    }

    public virtual void Borrow()
    {
        if (IsBorrowed)
            Console.WriteLine("Itemul este deja împrumutat :( ");
        else
        {
            Console.WriteLine("Ai imprumutat cu succes itemul :)");
        }
        IsBorrowed = true;
    }

    public virtual void Return()
    {
        if (IsBorrowed)
            Console.WriteLine("Ai returntat cu succes :) ");
        else
        {
            Console.WriteLine("Nu poti returna :( ");
        }
        IsBorrowed = false;
    }
}