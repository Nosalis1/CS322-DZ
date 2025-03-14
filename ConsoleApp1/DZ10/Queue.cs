using System.Collections;

namespace DZ10
{
    internal class Queue
    {
        private ArrayList elements;

        public Queue() => elements = new ArrayList();

        public void Enqueue(object element) => elements.Add(element);

        public object? Dequeue()
        {
            if (elements.Count == 0)
                throw new InvalidOperationException("Queue is empty!");

            object? front = elements[0];
            if (front == null) return null;
            elements.RemoveAt(0);
            return front;
        }

        public object? Peek()
        {
            if (elements.Count == 0)
                throw new InvalidOperationException("Queue is empty!");
            return elements[0];
        }

        public int Count => elements.Count;
        public bool IsEmpty => elements.Count == 0;
    }
}
