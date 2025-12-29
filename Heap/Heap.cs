using System.Collections;

namespace DSA.Heap;

public class Heap
{
    private int _length;
    private ArrayList _data;

    public Heap()
    {
        _length = 0;
        _data = [];
    }

    public void Insert(int value)
    {
        _data.Add(value);
        HeapifyUp(_length);
        _length++;
    }

    public int Delete()
    {
        if(_length == 0)
        {
            return -1;
        }

        int output = (int)_data[0];
        
        _length--;
        
        if(_length == 0)
        {
            _data = new ArrayList();
            return output;
        }

        _data[0] = _data[_length];
        HeapifyDown(0);
        return output; 
    }

    private void HeapifyDown(int index)
    {
        int leftIndex = LeftChild(index);
        int rightIndex = RightChild(index);

        if(index >= _length || leftIndex >= _length)
        {
            return;
        }

        int leftValue = (int)_data[leftIndex];
        int rightValue = (int)_data[rightIndex];
        int value = (int)_data[index];

        if(leftValue > rightValue && value > rightValue)
        {
            _data[index] = rightValue;
            _data[rightIndex] = value;
            HeapifyDown(rightIndex);
        }
        else if (rightValue > leftValue && value > leftValue)
        {
            _data[index] = leftValue;
            _data[leftIndex] = value;
            HeapifyDown(leftIndex);
        }
    }

    private void HeapifyUp(int index)
    {
        if(index == 0)
        {
            return;
        }

        int parent = Parent(index);
        int parentValue = (int)_data[parent];
        int value = (int)_data[index];

        if(parentValue > (int)_data[index])
        {
            _data[index] = parentValue;
            _data[parent] = value;

            HeapifyUp(parent);
        }
    }

    private static int Parent(int index) => (index - 1) / 2;

    private static int LeftChild(int index) => 2 * index + 1;

    private static int RightChild(int index) => 2 * index + 2;
}