namespace DSA;

public class Stack<T>
{
    private Node<T>? _Head;
    private int _Length;

    public T? Peek() => _Head != null ? _Head.Value : default;

    public T? Pop()
    {
        if(_Length == 0)
        {
            return default;
        }

        _Length = Math.Max(0, _Length - 1);

        T value = _Head.Value;
        _Head = _Head.Previous;
        return value;
    }

    public T Push(T value)
    {
        Node<T> newNode = new(){ Value = value};

        if(_Length > 0)
        {
            newNode.Previous = _Head;
        }

        _Head = newNode;

        _Length++;
        return value;
    }

    private class Node<U>
    {
        public Node<U>? Previous { get; set; }
        public required U Value { get; set; }
    }
}