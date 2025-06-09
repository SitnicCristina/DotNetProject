namespace DotNetExamples.Lesson16_1;

public class Library
{
    private List<LibraryItem> items = new List<LibraryItem>();

    public void AddItem(LibraryItem item)
    {
        items.Add(item);
    }
    
    public void BorrowItem(string title)
    {
        foreach (var item in items)
        {
            if (item.Title == title)
            {
                Console.WriteLine($"\nVerificam daca itemul {title} este valid");
                item.Borrow();
            }
        }
       
    }
    
    
    public void ReturnItem(string title)
    {
        foreach (var item in items)
        {
            if (item.Title == title)
            {
                Console.WriteLine($"\nVerificam daca itemul {title} este valid");
                item.Return();
            }
        }
       
    }
}