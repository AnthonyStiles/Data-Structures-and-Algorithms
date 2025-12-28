namespace DSA.Tree;

public static class BreadthFirstTreeSearch<T>
{
    public static bool Find(T value, TreeNode<T> root)
    {
        Queue<TreeNode<T>> queue = new();
        queue.Enqueue(root);

        while(queue.Peek() != null)
        {
            TreeNode<T> current = queue.Deque();
            
            if(current.Value.Equals(value))
            {
                return true;
            }
            
            if(current.Left != null)
            {
                queue.Enqueue(current.Left);
            }

            if(current.Right != null)
            {
                queue.Enqueue(current.Right);
            }
        }
        return false;
    }
}