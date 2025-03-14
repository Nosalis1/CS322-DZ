using System.Collections;

namespace DZ10
{
    internal class Stack
    {
        private ArrayList elements;

        public Stack() => elements = new ArrayList();

        public void Push(object element) => elements.Add(element);

        public object? Pop()
        {
            if (elements.Count == 0)
                throw new InvalidOperationException("Stack is empty!");

            object? top = elements[elements.Count - 1];
            if (top == null) return null;
            elements.RemoveAt(elements.Count - 1);
            return top;
        }

        public object? Peek()
        {
            if (elements.Count == 0)
                throw new InvalidOperationException("Stack is empty!");
            return elements[elements.Count - 1];
        }

        public int Count => elements.Count;
        public bool IsEmpty => elements.Count == 0;
    }
}
