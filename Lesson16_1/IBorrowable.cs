namespace DotNetExamples.Lesson16_1;

public interface IBorrowable
{
    void Borrow();
    void Return();
    bool IsBorrowed { get; }
}
