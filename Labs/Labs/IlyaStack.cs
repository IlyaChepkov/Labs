namespace Labs
{
    internal class IlyaStack<T>
    {
        OneWayNode<T> top;
        int lenght;

        public int Lenght
        {
            get { return lenght; }
        }

        public void Push(T data)
        {
            OneWayNode<T> newTop = new OneWayNode<T> 
            {
                next = top,
                data = data 
            };
            top = newTop;
            lenght++;
        }

        public T Pop()
        {
            if (top == null) new Exception("стек пустой");
            T value = top.data;
            top = top.next;
            lenght--;
            return value;
        }

        class OneWayNode<T>
        {
            public OneWayNode<T> next;
            public T data;
        }
    }
}
