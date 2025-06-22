namespace DotNetExamples.Lesson22;

public class PriorityQueue<T>
{
    private class PriorityQueueItem
    {
        public T Element;
        public int Prioritate;

        public PriorityQueueItem(T element, int prioritate)
        {
            Element = element;
            Prioritate = prioritate;
        }
    }

    private List<PriorityQueueItem> _queue = new();

    public void Enqueue(T item, int priority)
    {
        _queue.Add(new PriorityQueueItem(item, priority));
    }

    public T Dequeue()
    {
        var PrioritateInalta = _queue.OrderByDescending(p => p.Prioritate).First();
        _queue.Remove(PrioritateInalta);
        return PrioritateInalta.Element;
    }

    public T Peek()
    {
        return _queue.OrderByDescending(p => p.Prioritate).First().Element;
    }

    public bool IsEmpty()
    {
        return _queue.Count == 0;
    }
}