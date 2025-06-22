namespace DotNetExamples.Lesson22;

public class Program
{
    public static void Main(string[] args)
    {
        var q1 = new PriorityQueue<string>();
        q1.Enqueue("Prioritate mica",1);
        q1.Enqueue("Prioritate mare",10);
        q1.Enqueue("Prioritate medie",5);
        
        Console.WriteLine(q1.Peek());
        
        while (!q1.IsEmpty())
        {
            Console.WriteLine(q1.Dequeue());
        }
        
        var q2 = new PriorityQueue<int>();
        q2.Enqueue(1,1);
        q2.Enqueue(10,10);
        q2.Enqueue(5,5);
        
        while (!q2.IsEmpty())
        {
            Console.WriteLine(q2.Dequeue());
        }
    }
}