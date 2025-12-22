namespace DSA;

public class Queue<T>
{
    private int _Length = 0;
    private Node<T>? _Head;
    private Node<T>? _Tail;

    public T? Deque()
    {
        if(_Length == 0)
        {
            return default;
        }

        Node<T> _CurrentHead = _Head;
        _Head = _Head.Next;

        _Length --;

        if(_Length == 0)
        {
            _Tail = null;
        }

        return _CurrentHead.Value;
    }

    public T Enqueue(T value)
    {
        Node<T> _NewNode = new()
        {
            Value = value
        };

        if(_Length == 0)
        {
            _Head = _Tail = _NewNode;
        }
        else
        {
            _Tail.Next = _NewNode;
            _Tail = _NewNode;
        }

        _Length++;
        return _NewNode.Value;
    }

    public T? Peek() => _Head != null ? _Head.Value : default;

    private class Node<U>
    {
        public Node<U>? Next { get; set; }
        public required U Value { get; set; }
    }
}